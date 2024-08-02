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
        private ICustomerService _customerService;


        public ListPersonPage(IPersonService personService, ICustomerService customerService)
        {
            _personService = personService;
            _customerService = customerService;
            InitializeComponent();
        }

        private async void ListPersonPage_Load(object sender, EventArgs e)
        {
            dgwPersons.DataSource = await _personService.GetPersonDetailsAsync();

            cbxCities.Items.Clear();
            cbxDistricts.Items.Clear();
            cbxOccupations.Items.Clear();

            await FillComboBoxAsync(cbxCities, new EfCityDal().GetAllAsync(), "CityName", "CityId");
            await FillComboBoxAsync(cbxOccupations, new EfPersonOccupationDal().GetAllAsync(), "OccupationName", "PersonOccupationId");

            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxOccupations.SelectedIndex = 0;
            cbxDistricts.Enabled = false;
        }

        private async void FillDataGridViewPersonAsync()
        {
            dgwPersons.DataSource = await _personService.GetPersonDetailsAsync();
        }

        private void tbxSearchPersonByName_TextChanged(object sender, EventArgs e)
        {
            SearchPersonDetailByName(tbxSearchPersonByName.Text);
        }

        private async void SearchPersonDetailByName(string text)
        {
            dgwPersons.DataSource = await _personService.GetPersonDetailsByNameAsync(text);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
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

            dgwPersons.DataSource = await _personService.GetPersonDetailsByFilterAsync(firstName, lastName, email, identityNumber, city, district, phoneNumber, birthPlace, occupation);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillDataGridViewPersonAsync();
        }

        private async void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {

            var selectedCity = (ComboBoxItem)cbxCities.SelectedItem;
            if (selectedCity.Id.HasValue)
            {
                int cityId = selectedCity.Id.Value;
                await FillComboBoxAsync(cbxDistricts, new EfDistrictDal().GetAllAsync(d => d.CityId == cityId), "DistrictName", "DistrictId");
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
            HomePage.ClearAllTextBoxes(grpBoxFilterPerson);
            cbxCities.SelectedIndex = 0;
            cbxDistricts.SelectedIndex = 0;
            cbxOccupations.SelectedIndex = 0;
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
                GenderName = dgwPersons.CurrentRow.Cells[19].ToString()

            };


            foreach (Form form in Application.OpenForms)
            {

                if (form is HomePage homePage)
                {
                    UpdatePersonPage updatePersonPage = new UpdatePersonPage(personDTO, new CustomerManager(new EfCustomerDal()),
                        new PersonManager(new EfPersonDal()),
                        new CustomerAddressManager(new EfCustomerAddressDal()),
                        new AddressDetailManager(new EfAddressDetailDal()),
                        new CustomerEmailManager(new EfCustomerEmailDal()),
                        new EmailDetailManager(new EfEmailDetailDal()),
                        new CustomerPhoneNumberManager(new EfCustomerPhoneNumberDal()), new PhoneNumberDetailManager(new EfPhoneNumberDetailDal()));
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
            btnDeletePerson.Enabled = anyRowSelected;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnDeletePerson_Click(object sender, EventArgs e)
        {

            try
            {
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
                    GenderName = dgwPersons.CurrentRow.Cells[19].ToString()

                };

                var personById = await _personService.GetPersonIdValuesByIdAsync(personDTO.PersonId);


                var targetPerson = new Person
                {
                    PersonId = personDTO.PersonId,
                    CustomerId = personDTO.CustomerId,
                    PersonIdentityTypeId = personById.PersonIdentityTypeId,
                    PersonOccupationId = personById.PersonOccupationId,
                    PersonGenderId = personById.PersonGenderId,
                    IdentityNumber = personDTO.IdentityNumber,
                    BirthDate = personDTO.BirthDate,
                    BirthPlace = personDTO.BirthPlace,
                    CreatedTime = personById.CreatedTime,
                    UpdatedTime = personById.UpdatedTime
                };

                var targetCustomer = new Customer
                {
                    CustomerId = personById.CustomerId,
                    Name = personDTO.Name,
                    LastName = personDTO.LastName,
                    IsActiveCustomer = false


                };

                DialogResult dialogResult = MessageBox.Show($"Aşağıda bilgileri verilen müşteri silinecektir. Onaylıyor musunuz ?\n\nAd Soyad: {personDTO.Name} {personDTO.LastName}\nTC: {personDTO.IdentityNumber}", "ONAY GEREKİYOR", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Stop);

                if (dialogResult == DialogResult.No)
                {
                    return;
                }



                await _personService.DeleteAsync(targetPerson);
                await _customerService.UpdateAsync(targetCustomer);
                FillDataGridViewPersonAsync();
                MessageBox.Show("Silme işlemi başarıyla tamamlandı.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception exception)
            {
                MessageBox.Show("Silme işlemi tamamlanamadı. Daha sonra tekrar deneyin.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void cbxDistricts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public static async Task FillComboBoxAsync<T>(ComboBox comboBox, Task<List<T>> dataSourceTask, string displayMember, string valueMember)
        {
            try
            {
                var dataSource = await dataSourceTask;

                var comboBoxItems = new List<ComboBoxItem>
                {
                    new ComboBoxItem { Id = null, Name = "Seçiniz" }
                };

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
            catch (Exception ex)
            {
                MessageBox.Show("Veri yüklenirken bir hata oluştu:", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




    }
}
