using Business.Abstract;
using Business.Concrete;
using CustomersDbApplication.PersonForms;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace CustomersDbApplication.CompanyForms
{
    public partial class ListCompanyPage : Form
    {
        private readonly ICompanyService _companyService;
        public ListCompanyPage(ICompanyService companyService)
        {
            _companyService = companyService;
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ListCompanyPage_Load(object sender, EventArgs e)
        {
            btnOpenFormToUpdateCompany.Enabled = false;
            btnDeleteCompany.Enabled = false;

            dgwCompanies.DataSource = await _companyService.GetCompanyDetailsAsync();

            cbxCities.Items.Clear();
            cbxDistricts.Items.Clear();
            cbxCompanySectorTypes.Items.Clear();

            await ListPersonPage.FillComboBoxAsync(cbxCities, new EfCityDal().GetAllAsync(), "CityName", "CityId");
            await ListPersonPage.FillComboBoxAsync(cbxCompanySectorTypes, new EfPersonOccupationDal().GetAllAsync(), "OccupationName", "PersonOccupationId");

            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxCompanySectorTypes.SelectedIndex = 0;
            cbxDistricts.Enabled = false;


        }

        private async void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = (ComboBoxItem)cbxCities.SelectedItem;
            if (selectedCity.Id.HasValue)
            {
                int cityId = selectedCity.Id.Value;
                await ListPersonPage.FillComboBoxAsync(cbxDistricts, new EfDistrictDal().GetAllAsync(d => d.CityId == cityId), "DistrictName", "DistrictId");
                cbxDistricts.Enabled = true;
            }
            else
            {
                var districts = new List<ComboBoxItem>
                {
                    new ComboBoxItem { Id = null, Name = "Önce şehir seçiniz" }
                };

                cbxDistricts.DataSource = districts;
                cbxDistricts.SelectedIndex = 0;
                cbxDistricts.DisplayMember = "Name";
                cbxDistricts.Enabled = false;
            }
        }

        private async void tbxSearchCompanyByName_TextChanged(object sender, EventArgs e)
        {
            // dgwCompanies.DataSource = await _companyService.GetCompanyDetailsByNameAsync(tbxSearchCompanyByName.Text);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            dgwCompanies.DataSource = await _companyService.GetCompanyDetailsAsync();
        }

        private void btnOpenFormToAddCompany_Click(object sender, EventArgs e)
        {
            if (HomePage.IsFormOpen(typeof(AddCompanyPage)))
            {
                MessageBox.Show("Tüzel müşteri ekleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Form form in Application.OpenForms)
            {

                if (form is HomePage homePage)
                {
                    AddCompanyPage addCompanyPage = new AddCompanyPage(
                        new CustomerManager(new EfCustomerDal()),
                        new CustomerAddressManager(new EfCustomerAddressDal()),
                        new AddressDetailManager(new EfAddressDetailDal()),
                        new PhoneNumberDetailManager(new EfPhoneNumberDetailDal()),
                        new CustomerPhoneNumberManager(new EfCustomerPhoneNumberDal()),
                        new EmailDetailManager(new EfEmailDetailDal()),
                        new CustomerEmailManager(new EfCustomerEmailDal()),
                        new CompanyManager(new EfCompanyDal())

                    );
                    addCompanyPage.MdiParent = homePage;
                    addCompanyPage.Show();
                    break;
                }

            }
        }

        private void dgwCompanies_SelectionChanged(object sender, EventArgs e)
        {
            bool anyRowSelected = dgwCompanies.SelectedRows.Count == 1;
            btnOpenFormToUpdateCompany.Enabled = anyRowSelected;
            btnDeleteCompany.Enabled = anyRowSelected;
        }

        private void btnOpenFormToUpdateCompany_Click(object sender, EventArgs e)
        {
            if (HomePage.IsFormOpen(typeof(UpdateCompanyPage)))
            {
                MessageBox.Show("Tüzel müşteri güncelleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var companyDTO = new CompanyDetailDto
                {
                    CustomerId = Convert.ToInt32(dgwCompanies.CurrentRow.Cells[0].Value),
                    CompanyId = Convert.ToInt32(dgwCompanies.CurrentRow.Cells[1].Value),
                    Name = dgwCompanies.CurrentRow.Cells[2].Value.ToString(),
                    TaxNumber = dgwCompanies.CurrentRow.Cells[3].Value.ToString(),
                    EstablishedDate = Convert.ToDateTime(dgwCompanies.CurrentRow.Cells[4].Value),
                    EmployeeCount = Convert.ToInt32(dgwCompanies.CurrentRow.Cells[5].Value),
                    CompanySectorType = dgwCompanies.CurrentRow.Cells[6].Value.ToString(),
                    AddressName = dgwCompanies.CurrentRow.Cells[7].Value.ToString(),
                    AddressTypeDescription = dgwCompanies.CurrentRow.Cells[8].Value.ToString(),
                    AddressDetailDescription = dgwCompanies.CurrentRow.Cells[9].Value.ToString(),
                    IsBillingAddress = Convert.ToBoolean(dgwCompanies.CurrentRow.Cells[10].Value),
                    CityName = dgwCompanies.CurrentRow.Cells[11].Value.ToString(),
                    DistrictName = dgwCompanies.CurrentRow.Cells[12].Value.ToString(),
                    CountryName = dgwCompanies.CurrentRow.Cells[13].Value.ToString(),
                    Email = dgwCompanies.CurrentRow.Cells[14].Value.ToString(),
                    IsPrimaryEmail = Convert.ToBoolean(dgwCompanies.CurrentRow.Cells[15].Value),
                    PhoneNumber = dgwCompanies.CurrentRow.Cells[16].Value.ToString(),
                    IsPrimaryPhone = Convert.ToBoolean(dgwCompanies.CurrentRow.Cells[17].Value),
                    IsActiveCustomer = Convert.ToBoolean(dgwCompanies.CurrentRow.Cells[18].Value),
                    CreatedTime = Convert.ToDateTime(dgwCompanies.CurrentRow.Cells[19].Value)
                };


                foreach (Form form in Application.OpenForms)
                {

                    if (form is HomePage homePage)
                    {
                        UpdateCompanyPage updateCompanyPage = new UpdateCompanyPage(companyDTO,
                            new CustomerManager(new EfCustomerDal()),
                            new CustomerAddressManager(new EfCustomerAddressDal()),
                            new AddressDetailManager(new EfAddressDetailDal()),
                            new CustomerEmailManager(new EfCustomerEmailDal()),
                            new EmailDetailManager(new EfEmailDetailDal()),
                            new CustomerPhoneNumberManager(new EfCustomerPhoneNumberDal()),
                            new PhoneNumberDetailManager(new EfPhoneNumberDetailDal()),
                            new CompanyManager(new EfCompanyDal())

                        );
                        updateCompanyPage.MdiParent = homePage;
                        updateCompanyPage.Show();
                        break;
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Beklenmeyen bir hata meydana geldi! Lütfen daha sonra tekrar deneyin.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
