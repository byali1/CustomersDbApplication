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


namespace CustomersDbApplication
{
    public partial class ListPersonPage : Form
    {
        private IPersonService _personService;


        public ListPersonPage(IPersonService personService)
        {
            _personService = personService;
            InitializeComponent();
        }

        private void ListPersonPage_Load(object sender, EventArgs e)
        {
            dgwPersons.DataSource = _personService.GetPersonDetails();

            cbxCities.Items.Clear();
            cbxDistricts.Items.Clear();
            cbxOccupations.Items.Clear();

            FillComboBox(cbxCities, new EfCityDal().GetAll(), "CityName", "CityId");
            FillComboBox(cbxOccupations, new EfPersonOccupationDal().GetAll(), "OccupationName", "PersonOccupationId");

            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxOccupations.SelectedIndex = 0;
            cbxDistricts.Enabled = false;
        }



        private void FillDataGridViewPerson()
        {
            dgwPersons.DataSource = _personService.GetPersonDetails();
        }

        private void tbxSearchPersonByName_TextChanged(object sender, EventArgs e)
        {
            SearchPersonDetailByName(tbxSearchPersonByName.Text);
        }

        private void SearchPersonDetailByName(string text)
        {
            dgwPersons.DataSource = _personService.GetPersonDetailsByName(text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string firstName = tbxPersonFirstName.Text;
            string lastName = tbxPersonLastName.Text;
            string identityNumber = tbxIdentityNumber.Text;
            string birthPlace = tbxBirthPlace.Text;

            string occupation = "";

            string city = "";
            string district = "";
            if (cbxCities.Text != "Seçiniz")
            {
                city = cbxCities.Text;
            }
            if (cbxDistricts.Text != "Seçiniz" && cbxDistricts.Text != "Önce şehir seçiniz")
            {
                district = cbxDistricts.Text;
            }

            if (cbxOccupations.Text != "Seçiniz")
            {
                occupation = cbxOccupations.Text;
            }

            string phoneNumber = tbxPhoneNumber.Text;
            string email = tbxEmail.Text;

            dgwPersons.DataSource = _personService.GetPersonDetailsByFilter(firstName, lastName, email, identityNumber, city, district, phoneNumber, birthPlace, occupation);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewPerson();
        }

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = (ComboBoxItem)cbxCities.SelectedItem;
            if (selectedCity.Id.HasValue)
            {
                int cityId = selectedCity.Id.Value;
                FillComboBox(cbxDistricts, new EfDistrictDal().GetAll(d => d.CityId == cityId), "DistrictName", "DistrictId");
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

        private void cbxOccupations_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes(grpBoxFilterPerson);
            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxOccupations.SelectedIndex = 0;
        }

        private void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }


        private void FillComboBox<T>(ComboBox comboBox, List<T> dataSource, string displayMember, string valueMember)
        {
            var comboBoxItems = new List<ComboBoxItem>();
            comboBoxItems.Add(new ComboBoxItem { Id = null, Name = "Seçiniz" });

            foreach (var item in dataSource)
            {
                var itemPropertyId = item.GetType().GetProperty(valueMember);
                var itemPropertyName = item.GetType().GetProperty(displayMember);
                comboBoxItems.Add(new ComboBoxItem
                {
                    Id = (int?)itemPropertyId.GetValue(item),
                    Name = (string)itemPropertyName.GetValue(item)
                });
            }

            comboBox.DataSource = comboBoxItems;
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "Id";

            comboBox.SelectedIndex = 0;
        }



    }
}
