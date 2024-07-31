using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
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
using static System.Net.Mime.MediaTypeNames;

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
            dgwCompanies.DataSource = await _companyService.GetAllAsync();

            cbxCities.Items.Clear();
            cbxDistricts.Items.Clear();
            cbxOccupations.Items.Clear();

            await ListPersonPage.FillComboBoxAsync(cbxCities, new EfCityDal().GetAllAsync(), "CityName", "CityId");
            await ListPersonPage.FillComboBoxAsync(cbxOccupations, new EfPersonOccupationDal().GetAllAsync(), "OccupationName", "PersonOccupationId");

            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxOccupations.SelectedIndex = 0;
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
    }
}
