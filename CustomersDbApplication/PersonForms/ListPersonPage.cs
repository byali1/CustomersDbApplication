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
using Business.Concrete;
using CustomersDbApplication.PersonForms;
using DataAccess.Concrete.EntityFramework;
using Entities;
using Entities.Concrete;
using Entities.DTOs;


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

        private void btnOpenFormToAddPerson_Click(object sender, EventArgs e)
        {
            if (HomePage.IsFormOpen(typeof(AddPersonPage)))
            {
                MessageBox.Show("Gerçek müşteri ekleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (Form form in Application.OpenForms)
            {

                if (form is HomePage homePage)
                {
                    AddPersonPage addPersonPage = new AddPersonPage(
                        new CustomerManager(new EfCustomerDal()),
                        new PersonManager(new EfPersonDal()),
                        new CustomerAddressManager(new EfCustomerAddressDal()),
                        new AddressDetailManager(new EfAddressDetailDal()),
                        new PhoneNumberDetailManager(new EfPhoneNumberDetailDal()),
                        new CustomerPhoneNumberManager(new EfCustomerPhoneNumberDal()),
                        new EmailDetailManager(new EfEmailDetailDal()),
                        new CustomerEmailManager(new EfCustomerEmailDal())
                    );
                    addPersonPage.MdiParent = homePage;
                    addPersonPage.Show();
                    break;
                }

            }


        }

        private void btnOpenFormToUpdatePerson_Click(object sender, EventArgs e)
        {
            if (HomePage.IsFormOpen(typeof(UpdatePersonPage)))
            {
                MessageBox.Show("Gerçek müşteri güncelleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var personDTO = new PersonDetailDto
            {
                CustomerId = Convert.ToInt32(dgwPersons.CurrentRow.Cells[0].Value),
                PersonId = Convert.ToInt32(dgwPersons.CurrentRow.Cells[1].Value),
                Name = dgwPersons.CurrentRow.Cells[2].Value.ToString(),
                LastName = dgwPersons.CurrentRow.Cells[3].Value.ToString(),
                IdentityNumber = dgwPersons.CurrentRow.Cells[4].Value.ToString(),
                IdentityTypeDescription = dgwPersons.CurrentRow.Cells[5].Value.ToString(),
                BirthDate = Convert.ToDateTime(dgwPersons.CurrentRow.Cells[6].Value),
                BirthPlace = dgwPersons.CurrentRow.Cells[7].Value.ToString(),
                OccupationName = dgwPersons.CurrentRow.Cells[8].Value.ToString(),
                AddressDetailDescription = dgwPersons.CurrentRow.Cells[9].Value.ToString(),
                IsBillingAddress = Convert.ToBoolean(dgwPersons.CurrentRow.Cells[10].Value),
                CountryName = dgwPersons.CurrentRow.Cells[11].Value.ToString(),
                CityName = dgwPersons.CurrentRow.Cells[12].Value.ToString(),
                DistrictName = dgwPersons.CurrentRow.Cells[13].Value.ToString(),
                AddressTypeDescription = dgwPersons.CurrentRow.Cells[14].Value.ToString(),
                PhoneNumber = dgwPersons.CurrentRow.Cells[15].Value.ToString(),
                IsPrimaryPhone = Convert.ToBoolean(dgwPersons.CurrentRow.Cells[16].Value),
                Email = dgwPersons.CurrentRow.Cells[17].Value.ToString(),
                IsPrimaryEmail = Convert.ToBoolean(dgwPersons.CurrentRow.Cells[18].Value),
                PersonGenderId = Convert.ToInt16(dgwPersons.CurrentRow.Cells[19].Value)

            };


            foreach (Form form in Application.OpenForms)
            {

                if (form is HomePage homePage)
                {
                    UpdatePersonPage updatePersonPage = new UpdatePersonPage(personDTO,new PersonManager(new EfPersonDal()));
                    updatePersonPage.MdiParent = homePage;
                    updatePersonPage.Show();
                    break;
                }

            }
        }

        private void dgwPersons_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgwPersons_SelectionChanged(object sender, EventArgs e)
        {
            bool anyRowSelected = dgwPersons.SelectedRows.Count == 1;
            btnOpenFormToUpdatePerson.Enabled = anyRowSelected;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void FillComboBox<T>(ComboBox comboBox, List<T> dataSource, string displayMember, string valueMember)
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
