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
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using Entities.DTOs;

namespace CustomersDbApplication.PersonForms
{
    public partial class UpdatePersonPage : Form
    {

        private readonly ICustomerService _customerService;
        private readonly IPersonService _personService;
        private readonly ICustomerAddressService _customerAddressService;
        private readonly IAddressDetailService _addressDetailService;
        private readonly ICustomerEmailService _customerEmailService;
        private readonly IEmailDetailService _emailDetailService;
        private readonly ICustomerPhoneNumberService _customerPhoneNumberService;
        private readonly IPhoneNumberDetailService _phoneNumberDetailService;

        private PersonDetailDto _personDetailDto;
        public UpdatePersonPage(PersonDetailDto personDetailDto, ICustomerService customerService, IPersonService personService, ICustomerAddressService customerAddressService, IAddressDetailService addressDetailService, ICustomerEmailService customerEmailService, IEmailDetailService emailDetailService, ICustomerPhoneNumberService customerPhoneNumberService, IPhoneNumberDetailService phoneNumberDetailService)
        {

            _personDetailDto = personDetailDto;
            _customerService = customerService;
            _personService = personService;
            _customerAddressService = customerAddressService;
            _addressDetailService = addressDetailService;
            _customerEmailService = customerEmailService;
            _emailDetailService = emailDetailService;
            _customerPhoneNumberService = customerPhoneNumberService;
            _phoneNumberDetailService = phoneNumberDetailService;
            InitializeComponent();
        }

        private async void UpdatePersonPage_Load(object sender, EventArgs e)
        {
            var personById = await _personService.GetPersonIdValuesByIdAsync(_personDetailDto.PersonId);


            await ListPersonPage.FillComboBoxAsync(cbxCities, new EfCityDal().GetAllAsync(), "CityName", "CityId");
            await ListPersonPage.FillComboBoxAsync(cbxPersonOccupations, new EfPersonOccupationDal().GetAllAsync(), "OccupationName", "PersonOccupationId");
            await ListPersonPage.FillComboBoxAsync(cbxAddressTypes, new EfAddressTypeDal().GetAllAsync(), "AddressTypeDescription", "AddressTypeId");
            await ListPersonPage.FillComboBoxAsync(cbxPersonIdentityType, new EfPersonIdentityTypeDal().GetAllAsync(), "IdentityTypeDescription", "PersonIdentityTypeId");

            //cbxAddressTypes.DataSource 

            tbxCustomerName.Text = _personDetailDto.Name;
            tbxCustomerLastName.Text = _personDetailDto.LastName;
            tbxIdentityNumber.Text = _personDetailDto.IdentityNumber;
            tbxBirthPlace.Text = _personDetailDto.BirthPlace;
            tbxPhoneNumber.Text = _personDetailDto.PhoneNumber;
            tbxEmail.Text = _personDetailDto.Email;
            tbxAddressName.Text = _personDetailDto.AddressTypeDescription;

            richTbxAddressDetailDescription.Text = _personDetailDto.AddressDetailDescription;

            //CBX
            cbxPersonIdentityType.SelectedValue = personById.PersonIdentityTypeId;
            cbxPersonOccupations.SelectedValue = personById.PersonOccupationId;
            cbxAddressTypes.SelectedValue = personById.AddressTypeId;

            cbxCities.SelectedValue = personById.CityId;
            //cbxDistricts.SelectedValue = personById.DistrictId;


            //Checkbox
            checkBxIsBillingAddress.Checked = _personDetailDto.IsBillingAddress;
            checkBxIsPrimaryEmail.Checked = _personDetailDto.IsPrimaryEmail;
            checkBxIsPrimaryPhoneNumber.Checked = _personDetailDto.IsPrimaryPhone;

            dTimePickerBirthDate.Value = _personDetailDto.BirthDate;

            if (personById.PersonGenderId == 1)
            {
                radioBtnMale.Checked = true;
                radioBtnFemale.Checked = false;
            }
            else if (personById.PersonGenderId == 2)
            {
                radioBtnMale.Checked = false;
                radioBtnFemale.Checked = true;
            }


        }

        private void tbxIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var personById =await _personService.GetPersonIdValuesByIdAsync( _personDetailDto.PersonId);

            //sıkıntı
            var selectedCity = (ComboBoxItem)cbxCities.SelectedItem;

            if (selectedCity != null && selectedCity.Id.HasValue)
            {
                int cityId = selectedCity.Id.Value;
                var districts = await new EfDistrictDal().GetAllAsync(d => d.CityId == cityId);

                var districtItems = new List<ComboBoxItem>
                {
                    new ComboBoxItem { Id = null, Name = "Seçiniz" } 
                };

                districtItems.AddRange(districts.Select(d => new ComboBoxItem
                {
                    Id = d.DistrictId,
                    Name = d.DistrictName
                }));

                cbxDistricts.DataSource = districtItems;
                cbxDistricts.DisplayMember = "Name";
                cbxDistricts.ValueMember = "Id";
                //cbxDistricts.SelectedIndex = 0;
                cbxDistricts.SelectedValue = personById.DistrictId;
                cbxDistricts.Enabled = true;
            }
            else
            {
                var emptyDistrict = new List<ComboBoxItem>
                {
                    new ComboBoxItem { Id = null, Name = "Önce şehir seçiniz" }
                };

                cbxDistricts.DataSource = emptyDistrict;
                cbxDistricts.DisplayMember = "Name";
                cbxDistricts.ValueMember = "Id";
                cbxDistricts.SelectedIndex = 0;
                cbxDistricts.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private async void btnUpdatePerson_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişiklikler kaydedilecektir. Onaylıyor musunuz ?", "Onay Gerekiyor", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (tbxIdentityNumber.Text.Length != 11)
            {
                MessageBox.Show("TC Kimlik no 11 haneli olmalıdır.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (Convert.ToInt64(tbxIdentityNumber.Text) % 2 != 0)
            {
                MessageBox.Show("TC Kimlik no'nun son hanesi çift sayı olmalıdır.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            if (HomePage.AreFilledAllTextBoxes(grpBxUpdatePerson) && HomePage.AreFilledAllComboBoxes(grpBxUpdatePerson) && HomePage.AreFilledAllRichTextBoxes(grpBxUpdatePerson))
            {
                var personById = await _personService.GetPersonIdValuesByIdAsync(_personDetailDto.PersonId);

                var customer = new Customer
                {
                    CustomerId = personById.CustomerId,
                    Name = tbxCustomerName.Text,
                    LastName = tbxCustomerLastName.Text
                };

                var person = new Person
                {
                    PersonId = personById.PersonId,
                    CustomerId = personById.CustomerId,
                    PersonIdentityTypeId = Convert.ToInt16(cbxPersonIdentityType.SelectedValue),
                    PersonOccupationId = Convert.ToInt16(cbxPersonOccupations.SelectedValue),
                    PersonGenderId = HomePage.GetGenderId(radioBtnMale.Checked, radioBtnFemale.Checked),
                    IdentityNumber = tbxIdentityNumber.Text,
                    BirthDate = dTimePickerBirthDate.Value,
                    BirthPlace = tbxBirthPlace.Text,
                    CreatedTime = personById.CreatedTime,
                    UpdatedTime = DateTime.Now

                };

                var customerAddress = new CustomerAddress
                {
                    CustomerId = personById.CustomerId,
                    CustomerAddressId = personById.CustomerAddressId,
                    AddressName = tbxAddressName.Text,
                    AddressTypeId = Convert.ToInt16(cbxAddressTypes.SelectedValue),
                    IsBillingAddress = checkBxIsBillingAddress.Checked
                };

                var addressDetail = new AddressDetail
                {
                    AddressDetailId = personById.AddressDetailId,
                    DistrictId = Convert.ToInt16(cbxDistricts.SelectedValue),
                    CustomerAddressId = personById.CustomerAddressId,
                    CityId = Convert.ToInt16(cbxCities.SelectedValue),
                    AddressDetailDescription = richTbxAddressDetailDescription.Text,
                    CountryId = 190
                };

                var customerEmail = new CustomerEmail
                {
                    CustomerId = personById.CustomerId,
                    IsPrimary = checkBxIsPrimaryEmail.Checked,
                    CustomerEmailDetailId = personById.CustomerEmailDetailId,
                    CustomerEmailId = personById.CustomerEmailId,
                };

                var emailDetail = new EmailDetail
                {
                    CustomerEmailDetailId = personById.CustomerEmailDetailId,
                    Email = tbxEmail.Text
                };

                var customerPhoneNumber = new CustomerPhoneNumber
                {
                    CustomerId = personById.CustomerId,
                    PhoneNumberDetailId = personById.PhoneNumberDetailId,
                    CustomerPhoneNumberId = personById.CustomerPhoneNumberId,
                    IsPrimary = checkBxIsPrimaryPhoneNumber.Checked
                };

                var phoneNumberDetail = new PhoneNumberDetail
                {
                    PhoneNumberDetailId = personById.PhoneNumberDetailId,
                    PhoneNumber = tbxPhoneNumber.Text
                };

                //UPDATE
                await _customerService.UpdateAsync(customer);
                await _personService.UpdateAsync(person);
                await _customerAddressService.UpdateAsync(customerAddress);
                await _addressDetailService.UpdateAsync(addressDetail);
                await _customerEmailService.UpdateAsync(customerEmail);
                await _emailDetailService.UpdateAsync(emailDetail);
                await _customerPhoneNumberService.UpdateAsync(customerPhoneNumber);
                await _phoneNumberDetailService.UpdateAsync(phoneNumberDetail);


                MessageBox.Show("Güncelleme işlemi başarılı.", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
                ListPersonPage.dgwPersons.DataSource = await _personService.GetPersonDetailsAsync();
                return;
            }

            MessageBox.Show("Tüm alanları doğru bir şekilde doldurduğunuza emin olun.", "BAŞARISIZ", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);

        }
    }
}
