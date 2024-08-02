using DataAccess.Concrete.EntityFramework;
using Entities.DTOs;
using Entities;
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
using Entities.Concrete;

namespace CustomersDbApplication.CompanyForms
{
    public partial class UpdateCompanyPage : Form
    {
        private readonly ICustomerService _customerService;
        private readonly ICustomerAddressService _customerAddressService;
        private readonly IAddressDetailService _addressDetailService;
        private readonly ICustomerEmailService _customerEmailService;
        private readonly IEmailDetailService _emailDetailService;
        private readonly ICustomerPhoneNumberService _customerPhoneNumberService;
        private readonly IPhoneNumberDetailService _phoneNumberDetailService;
        private readonly ICompanyService _companyService;

        private CompanyDetailDto _companyDetailDto;
        public UpdateCompanyPage(CompanyDetailDto companyDetailDto, ICustomerService customerService, ICustomerAddressService customerAddressService, IAddressDetailService addressDetailService, ICustomerEmailService customerEmailService, IEmailDetailService emailDetailService, ICustomerPhoneNumberService customerPhoneNumberService, IPhoneNumberDetailService phoneNumberDetailService, ICompanyService companyService)
        {
            _companyDetailDto = companyDetailDto;
            _customerService = customerService;
            _customerAddressService = customerAddressService;
            _addressDetailService = addressDetailService;
            _customerEmailService = customerEmailService;
            _emailDetailService = emailDetailService;
            _customerPhoneNumberService = customerPhoneNumberService;
            _phoneNumberDetailService = phoneNumberDetailService;
            _companyService = companyService;
            InitializeComponent();
        }

        private async void UpdateCompanyPage_Load(object sender, EventArgs e)
        {
            var companyById = await _companyService.GetCompanyIdValuesByIdAsync(_companyDetailDto.CompanyId);
            await ListPersonPage.FillComboBoxAsync(cbxCities, new EfCityDal().GetAllAsync(), "CityName", "CityId");
            await ListPersonPage.FillComboBoxAsync(cbxAddressTypes, new EfAddressTypeDal().GetAllAsync(), "AddressTypeDescription", "AddressTypeId");
            await ListPersonPage.FillComboBoxAsync(cbxCompanySectors, new EfCompanySectorDal().GetAllAsync(), "CompanySectorType", "CompanySectorTypeId");

            tbxCompanyName.Text = _companyDetailDto.Name;
            tbxTaxNumber.Text = _companyDetailDto.TaxNumber;
            tbxEmployeeCount.Text = _companyDetailDto.EmployeeCount.ToString();
            tbxPhoneNumber.Text = _companyDetailDto.PhoneNumber;
            tbxEmail.Text = _companyDetailDto.Email;
            tbxAddressName.Text = _companyDetailDto.AddressTypeDescription;

            richTbxAddressDetailDescription.Text = _companyDetailDto.AddressDetailDescription;

            //CBX
            cbxAddressTypes.SelectedValue = companyById.AddressTypeId;
            cbxCities.SelectedValue = companyById.CityId;
            cbxCompanySectors.SelectedValue = companyById.CompanySectorTypeId;
            //cbxDistricts.SelectedValue = personById.DistrictId;

            //Checkbox
            checkBxIsBillingAddress.Checked = _companyDetailDto.IsBillingAddress;
            checkBxIsPrimaryEmail.Checked = _companyDetailDto.IsPrimaryEmail;
            checkBxIsPrimaryPhoneNumber.Checked = _companyDetailDto.IsPrimaryPhone;

            dTimePickerEstablishedDate.Value = _companyDetailDto.EstablishedDate;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var companyById = await _companyService.GetCompanyIdValuesByIdAsync(_companyDetailDto.CompanyId);

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
                cbxDistricts.SelectedValue = companyById.DistrictId;
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

        private async void btnUpdateCompany_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Değişiklikler kaydedilecektir. Onaylıyor musunuz ?", "Onay Gerekiyor", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (tbxTaxNumber.Text.Length != 10)
            {
                MessageBox.Show("Vergi numarası 10 haneli olmalıdır.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (HomePage.AreFilledAllTextBoxes(grpBxUpdateCompany) && HomePage.AreFilledAllComboBoxes(grpBxUpdateCompany) && HomePage.AreFilledAllRichTextBoxes(grpBxUpdateCompany))
            {
                var companById = await _companyService.GetCompanyIdValuesByIdAsync(_companyDetailDto.CompanyId);

                var customer = new Customer
                {
                    CustomerId = companById.CustomerId,
                    Name = tbxCompanyName.Text,
                    IsActiveCustomer = _companyDetailDto.IsActiveCustomer
                };

                var company = new Company
                {
                    CompanyId = companById.CompanyId,
                    CustomerId = companById.CustomerId,
                    TaxNumber = tbxTaxNumber.Text,
                    EstablishedDate = dTimePickerEstablishedDate.Value,
                    EmployeeCount = Convert.ToInt32(tbxEmployeeCount.Text),
                    CompanySectorTypeId = Convert.ToInt16(cbxCompanySectors.SelectedValue),
                    AuthorizedPersonId = 0,
                    CreatedTime = companById.CreatedTime,
                    UpdatedTime = DateTime.Now
                };
                
                var customerAddress = new CustomerAddress
                {
                    CustomerId = companById.CustomerId,
                    CustomerAddressId = companById.CustomerAddressId,
                    AddressName = tbxAddressName.Text,
                    AddressTypeId = Convert.ToInt16(cbxAddressTypes.SelectedValue),
                    IsBillingAddress = checkBxIsBillingAddress.Checked
                };

                var addressDetail = new AddressDetail
                {
                    AddressDetailId = companById.AddressDetailId,
                    DistrictId = Convert.ToInt16(cbxDistricts.SelectedValue),
                    CustomerAddressId = companById.CustomerAddressId,
                    CityId = Convert.ToInt16(cbxCities.SelectedValue),
                    AddressDetailDescription = richTbxAddressDetailDescription.Text,
                    CountryId = 190
                };

                var customerEmail = new CustomerEmail
                {
                    CustomerId = companById.CustomerId,
                    IsPrimary = checkBxIsPrimaryEmail.Checked,
                    CustomerEmailDetailId = companById.CustomerEmailDetailId,
                    CustomerEmailId = companById.CustomerEmailId,
                };

                var emailDetail = new EmailDetail
                {
                    CustomerEmailDetailId = companById.CustomerEmailDetailId,
                    Email = tbxEmail.Text
                };

                var customerPhoneNumber = new CustomerPhoneNumber
                {
                    CustomerId = companById.CustomerId,
                    PhoneNumberDetailId = companById.PhoneNumberDetailId,
                    CustomerPhoneNumberId = companById.CustomerPhoneNumberId,
                    IsPrimary = checkBxIsPrimaryPhoneNumber.Checked
                };

                var phoneNumberDetail = new PhoneNumberDetail
                {
                    PhoneNumberDetailId = companById.PhoneNumberDetailId,
                    PhoneNumber = tbxPhoneNumber.Text
                };

                //UPDATE
                await _customerService.UpdateAsync(customer);
                await _companyService.UpdateAsync(company);
                await _customerAddressService.UpdateAsync(customerAddress);
                await _addressDetailService.UpdateAsync(addressDetail);
                await _customerEmailService.UpdateAsync(customerEmail);
                await _emailDetailService.UpdateAsync(emailDetail);
                await _customerPhoneNumberService.UpdateAsync(customerPhoneNumber);
                await _phoneNumberDetailService.UpdateAsync(phoneNumberDetail);


                MessageBox.Show("Güncelleme işlemi başarılı.", "BAŞARILI", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
                ListCompanyPage.dgwCompanies.DataSource = await _companyService.GetCompanyDetailsAsync();
                return;
            }

            MessageBox.Show("Tüm alanları doğru bir şekilde doldurduğunuza emin olun.", "BAŞARISIZ", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
