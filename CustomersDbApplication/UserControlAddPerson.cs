using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Abstract;
using Business.Utilities.SpecialFunctions;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace CustomersDbApplication
{
    public partial class UserControlAddPerson : UserControl
    {

        private readonly ICustomerService _customerService;
        private readonly IPersonService _personService;
        private readonly ICustomerAddressService _customerAddressService;
        private readonly IAddressDetailService _addressDetailService;
        private readonly IPhoneNumberDetailService _phoneNumberDetailService;
        private readonly ICustomerPhoneNumberService _customerPhoneNumberService;
        private readonly IEmailDetailService _emailDetailService;
        private readonly ICustomerEmailService _customerEmailService;


        public UserControlAddPerson(ICustomerService customerService, IPersonService personService, ICustomerAddressService customerAddressService, IAddressDetailService addressDetailService, IPhoneNumberDetailService phoneNumberDetailService, ICustomerPhoneNumberService customerPhoneNumberService, IEmailDetailService emailDetailService, ICustomerEmailService customerEmailService)
        {
            _customerService = customerService;
            _personService = personService;
            _customerAddressService = customerAddressService;
            _addressDetailService = addressDetailService;
            _phoneNumberDetailService = phoneNumberDetailService;
            _customerPhoneNumberService = customerPhoneNumberService;
            _emailDetailService = emailDetailService;
            _customerEmailService = customerEmailService;
            InitializeComponent();

        }



        private void UserControlAddPerson_Load(object sender, EventArgs e)
        {


            dgwPersons.DataSource = _personService.GetAll();
            //FillComboBoxPersonIdentityTypes(new EfPersonIdentityTypeDal());
            //FillComboBoxPersonOccupations(new EfPersonOccupationDal());

            FillComboBox(cbxPersonIdentityType, new EfPersonIdentityTypeDal().GetAll(), "IdentityTypeDescription", "PersonIdentityTypeId");
            FillComboBox(cbxPersonOccupations, new EfPersonOccupationDal().GetAll(), "OccupationName", "PersonOccupationId");

            FillComboBox(cbxAddressTypes, new EfAddressTypeDal().GetAll(), "AddressTypeDescription", "AddressTypeId");

            FillComboBox(cbxCities, new EfCityDal().GetAll(), "CityName", "CityId");




        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string customerName = tbxCustomerName.Text;
            string customerLastName = tbxCustomerLastName.Text;



            var check = IsNullOrEmptyCustomerInformation(customerName, customerLastName);

            if (!check)
            {
                if (ControlFunctions.CheckStartsWithNumber(customerName) || ControlFunctions.CheckStartsWithNumber(customerLastName))
                {
                    MessageBox.Show("Müşteri adı ve soyadı sayı ile başlayamaz.", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                var customer = new Customer
                {
                    Name = customerName,
                    LastName = customerLastName
                };

                _customerService.Add(customer);

                // int customerId = customer.CustomerId;

                var selectedIdentityType = (PersonIdentityType)cbxPersonIdentityType.SelectedItem;
                int personIdentityTypeId = selectedIdentityType.PersonIdentityTypeId;


                var selectedOccupation = (PersonOccupation)cbxPersonOccupations.SelectedItem;
                int personOccupationId = selectedOccupation.PersonOccupationId;

                var selectedAddressType = (AddressType)cbxAddressTypes.SelectedItem;
                int customerAddressTypeId = selectedAddressType.AddressTypeId;

                var selectedCity = (City)cbxCities.SelectedItem;
                int cityId = selectedCity.CityId;

                var selectedDistrict = (District)cbxDistricts.SelectedItem;
                int districtId = selectedDistrict.DistrictId;

                int personGenderId = GetGenderId(radioBtnMale.Checked, radioBtnFemale.Checked);

                var customerAddress = new CustomerAddress
                {
                    CustomerId = customer.CustomerId,
                    AddressTypeId = customerAddressTypeId,
                    AddressName = tbxAddressName.Text,
                    IsBillingAddress = checkBxIsBillingAddress.Checked
                };

                _customerAddressService.Add(customerAddress);

                var addressDetail = new AddressDetail
                {
                    CustomerAddressId = customerAddress.CustomerAddressId,
                    AddressDetailDescription = richTbxAddressDetailDescription.Text,
                    CityId = cityId,
                    CountryId = 190,
                    DistrictId = districtId
                };

                _addressDetailService.Add(addressDetail);



                _personService.Add(new Person
                {
                    CustomerId = customer.CustomerId,
                    PersonIdentityTypeId = personIdentityTypeId,
                    PersonOccupationId = personOccupationId,
                    PersonGenderId = personGenderId,
                    IdentityNumber = tbxIdentityNumber.Text,
                    BirthDate = dTimePickerBirthDate.Value,
                    BirthPlace = tbxBirthPlace.Text,
                    CreatedTime = DateTime.UtcNow,
                    UpdatedTime = DateTime.UtcNow
                });


                var phoneNumberDetail = new PhoneNumberDetail
                {
                    PhoneNumber = tbxPhoneNumber.Text
                };

                _phoneNumberDetailService.Add(phoneNumberDetail);

                var customerPhoneNumber = new CustomerPhoneNumber
                {
                    PhoneNumberDetailId = phoneNumberDetail.PhoneNumberDetailId,
                    CustomerId = customer.CustomerId,
                    IsPrimary = checkBxIsPrimaryPhoneNumber.Checked
                };

                _customerPhoneNumberService.Add(customerPhoneNumber);

                var emailDetail = new EmailDetail
                {
                    Email = tbxEmail.Text
                };

                _emailDetailService.Add(emailDetail);

                var customerEmail = new CustomerEmail
                {
                    CustomerEmailDetailId = emailDetail.CustomerEmailDetailId,
                    CustomerId = customer.CustomerId,
                    IsPrimary = checkBxIsPrimaryEmail.Checked
                };

                _customerEmailService.Add(customerEmail);


                MessageBox.Show("Müşteri başarıyla eklendi.", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Müşteri ad ve soyad kısmı boş olamaz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }


        private bool IsNullOrEmptyCustomerInformation(string customerName, string customerLastName)
        {
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerLastName))
            {
                return true;
            }
            return false;
        }

        private int GetGenderId(bool radioBtnMaleChecked, bool radioBtnFemaleChecked)
        {
            if (radioBtnMaleChecked)
            {
                return 1;
            }
            if (radioBtnFemaleChecked)
            {
                return 2;
            }

            MessageBox.Show("Lütfen cinsiyet seçin.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -1;
        }


        private void tbxIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void grpBxAddPerson_Enter(object sender, EventArgs e)
        {

        }

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = (City)cbxCities.SelectedItem;
            int cityId = selectedCity.CityId;

            FillComboBox(cbxDistricts, new EfDistrictDal().GetAll(d => d.CityId == cityId), "DistrictName", "DistrictId");
        }

        private void FillComboBox<T>(ComboBox comboBox, List<T> dataSource, string displayMember, string valueMember)
        {
            BindingSource bindingSource = new BindingSource
            {
                DataSource = dataSource
            };
            comboBox.DataSource = bindingSource;
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
        }
    }
}