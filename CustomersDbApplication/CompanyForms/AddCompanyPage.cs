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
using Entities;
using Entities.Concrete;

namespace CustomersDbApplication.CompanyForms
{
    public partial class AddCompanyPage : Form
    {
        private readonly ICustomerService _customerService;
        private readonly ICompanyService _companyService;
        private readonly ICustomerAddressService _customerAddressService;
        private readonly IAddressDetailService _addressDetailService;
        private readonly IPhoneNumberDetailService _phoneNumberDetailService;
        private readonly ICustomerPhoneNumberService _customerPhoneNumberService;
        private readonly IEmailDetailService _emailDetailService;
        private readonly ICustomerEmailService _customerEmailService;

        public AddCompanyPage(ICustomerService customerService, ICustomerAddressService customerAddressService, IAddressDetailService addressDetailService, IPhoneNumberDetailService phoneNumberDetailService, ICustomerPhoneNumberService customerPhoneNumberService, IEmailDetailService emailDetailService, ICustomerEmailService customerEmailService, ICompanyService companyService)
        {
            _customerService = customerService;
            _customerAddressService = customerAddressService;
            _addressDetailService = addressDetailService;
            _phoneNumberDetailService = phoneNumberDetailService;

            _customerPhoneNumberService = customerPhoneNumberService;
            _emailDetailService = emailDetailService;
            _customerEmailService = customerEmailService;
            _companyService = companyService;
            InitializeComponent();
        }

        private async void AddCompanyPage_Load(object sender, EventArgs e)
        {

            cbxCities.SelectedIndexChanged -= cbxCities_SelectedIndexChanged;
            cbxDistricts.Enabled = false;

            try
            {
                var companySectorsTask = new EfCompanySectorDal().GetAllAsync();
                var addressTypesTask = new EfAddressTypeDal().GetAllAsync();
                var citiesTask = new EfCityDal().GetAllAsync();

                await ListPersonPage.FillComboBoxAsync(cbxCompanySectors, companySectorsTask, "CompanySectorType", "CompanySectorTypeId");
                await ListPersonPage.FillComboBoxAsync(cbxAddressTypes, addressTypesTask, "AddressTypeDescription", "AddressTypeId");
                await ListPersonPage.FillComboBoxAsync(cbxCities, citiesTask, "CityName", "CityId");
                cbxCities.SelectedIndexChanged += cbxCities_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yükleme sırasında bir hata oluştu: {ex.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxCities.SelectedItem is ComboBoxItem selectedItem && selectedItem.Id.HasValue)
            {
                int cityId = selectedItem.Id.Value;


                var districts = await new EfDistrictDal().GetAllAsync(d => d.CityId == cityId);


                await ListPersonPage.FillComboBoxAsync(cbxDistricts, Task.FromResult(districts), "DistrictName", "DistrictId");
                cbxDistricts.Enabled = true;
            }
            else
            {
                MessageBox.Show("Seçilen şehir geçerli bir şehir değil.");
            }
        }

        private void tbxEmployeeCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxTaxNumber_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAddCompany_Click(object sender, EventArgs e)
        {
            if (ControlFunctions.IsNullOrWhiteSpace(tbxCustomerName.Text))
            {
                MessageBox.Show("Lütfen bir müşteri adı girin.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.CheckStartsWithNumber(tbxCustomerName.Text))
            {
                MessageBox.Show("Müşteri adı sayı ile başlayamaz.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.IsNullOrWhiteSpace(tbxTaxNumber.Text) || tbxTaxNumber.TextLength != 10)
            {
                MessageBox.Show("Vergi numarasını lütfen doğru giriniz.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.CheckStartsWithZero(tbxTaxNumber.Text))
            {
                MessageBox.Show("Vergi numarasını 0 ile başlayamaz.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.IsNullOrWhiteSpace(tbxEmployeeCount.Text))
            {
                MessageBox.Show("Lütfen çalışan sayısın girin.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.IsNullOrWhiteSpace(richTbxAddressDetailDescription.Text))
            {
                MessageBox.Show("Adres kısmını lütfen doldurun.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (richTbxAddressDetailDescription.TextLength < 10)
            {
                MessageBox.Show("Adresinizi detaylı bir şekilde yazdığınızdan emin olun.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (ControlFunctions.IsNullOrWhiteSpace(tbxAddressName.Text))
            {
                MessageBox.Show("Adresinize lütfen bir isim verin.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (ControlFunctions.IsNullOrWhiteSpace(tbxPhoneNumber.Text))
            {
                MessageBox.Show("Lütfen telefon numarası girin.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }



            if (ControlFunctions.IsNullOrWhiteSpace(tbxEmail.Text))
            {
                MessageBox.Show("Lütfen email kısmını doldurun.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!ControlFunctions.IsValidEmail(tbxEmail.Text))
            {
                MessageBox.Show("Lütfen geçerli bir email girin.", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }


            try
            {
                string customerName = tbxCustomerName.Text;
                var check = ControlFunctions.IsNullOrEmptyCustomerInformation(customerName);

                var customer = new Customer
                {
                    Name = customerName,
                    //LastName = "",
                    IsActiveCustomer = true
                };

                await _customerService.AddAsync(customer);
                
                //var selectedSectorType = (CompanySector)cbxCompanySectors.SelectedItem;
                //int companySectorTypeId = selectedSectorType.CompanySectorTypeId;

                if (cbxCompanySectors.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen şirket sektörü seçiniz.", "",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                int selectedCompanySectorId = (int)cbxCompanySectors.SelectedValue;


                //var selectedAddressType = (AddressType)cbxAddressTypes.SelectedItem;
                //int customerAddressTypeId = selectedAddressType.AddressTypeId;

                //var selectedCity = (City)cbxCities.SelectedItem;
                //int cityId = selectedCity.CityId;
                if (cbxCities.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen şehir seçiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int selectedCityId = (int)cbxCities.SelectedValue;

                //var selectedDistrict = (District)cbxDistricts.SelectedItem;
                //int districtId = selectedDistrict.DistrictId;


                if (cbxDistricts.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen ilçe sektörü seçiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int selectedDistrictId = (int)cbxDistricts.SelectedValue;

                if (cbxAddressTypes.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen adres tipi seçiniz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedAddressTypeId = (int)cbxAddressTypes.SelectedValue;

               


                var company = new Company
                {
                    CustomerId = customer.CustomerId,
                    CompanySectorTypeId = selectedCompanySectorId,
                    AuthorizedPersonId = 0,
                    TaxNumber = tbxTaxNumber.Text,
                    EstablishedDate = dTimePickerEstablishedDate.Value,
                    EmployeeCount = Convert.ToInt32(tbxEmployeeCount.Text),
                    CreatedTime = DateTime.Now,
                    UpdatedTime = DateTime.Now

                };

                await _companyService.AddAsync(company);

                var customerAddress = new CustomerAddress
                {
                    CustomerId = customer.CustomerId,
                    AddressTypeId = selectedAddressTypeId,
                    AddressName = tbxAddressName.Text,
                    IsBillingAddress = checkBxIsBillingAddress.Checked
                };

                await _customerAddressService.AddAsync(customerAddress);

                var addressDetail = new AddressDetail
                {
                    CustomerAddressId = customerAddress.CustomerAddressId,
                    AddressDetailDescription = richTbxAddressDetailDescription.Text,
                    CityId = selectedCityId,
                    CountryId = 190,
                    DistrictId = selectedDistrictId
                };

                await _addressDetailService.AddAsync(addressDetail);


                var phoneNumberDetail = new PhoneNumberDetail
                {
                    PhoneNumber = tbxPhoneNumber.Text
                };

                await _phoneNumberDetailService.AddAsync(phoneNumberDetail);

                var customerPhoneNumber = new CustomerPhoneNumber
                {
                    PhoneNumberDetailId = phoneNumberDetail.PhoneNumberDetailId,
                    CustomerId = customer.CustomerId,
                    IsPrimary = checkBxIsPrimaryPhoneNumber.Checked
                };

                await _customerPhoneNumberService.AddAsync(customerPhoneNumber);

                var emailDetail = new EmailDetail
                {
                    Email = tbxEmail.Text
                };

                await _emailDetailService.AddAsync(emailDetail);

                var customerEmail = new CustomerEmail
                {
                    CustomerEmailDetailId = emailDetail.CustomerEmailDetailId,
                    CustomerId = customer.CustomerId,
                    IsPrimary = checkBxIsPrimaryEmail.Checked
                };

                await _customerEmailService.AddAsync(customerEmail);


                MessageBox.Show("Müşteri başarıyla eklendi.", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ListCompanyPage.dgwCompanies.DataSource = await _companyService.GetCompanyDetailsAsync();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Müşteri eklenemedi! Tüm alanları doldurduğunuza emin olun.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
