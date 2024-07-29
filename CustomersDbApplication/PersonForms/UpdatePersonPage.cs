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
        private IPersonService _personService;
        private PersonDetailDto _personDetailDto;
        public UpdatePersonPage(PersonDetailDto personDetailDto, IPersonService personService)
        {
            _personDetailDto = personDetailDto;
            _personService = personService;
            InitializeComponent();
        }

        private void UpdatePersonPage_Load(object sender, EventArgs e)
        {
            var personById = _personService.GetPersonIdValuesById(_personDetailDto.PersonId);


            ListPersonPage.FillComboBox(cbxCities, new EfCityDal().GetAll(), "CityName", "CityId");
            ListPersonPage.FillComboBox(cbxPersonOccupations, new EfPersonOccupationDal().GetAll(), "OccupationName", "PersonOccupationId");
            ListPersonPage.FillComboBox(cbxAddressTypes, new EfAddressTypeDal().GetAll(), "AddressTypeDescription", "AddressTypeId");
            ListPersonPage.FillComboBox(cbxPersonIdentityType, new EfPersonIdentityTypeDal().GetAll(), "IdentityTypeDescription", "PersonIdentityTypeId");

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
            cbxDistricts.SelectedValue = personById.DistrictId;


            //Checkbox
            checkBxIsBillingAddress.Checked = _personDetailDto.IsBillingAddress;
            checkBxIsPrimaryEmail.Checked = _personDetailDto.IsPrimaryEmail;
            checkBxIsPrimaryPhoneNumber.Checked = _personDetailDto.IsPrimaryPhone;

            dTimePickerBirthDate.Value = _personDetailDto.BirthDate;

            if (_personDetailDto.PersonGenderId == 1)
            {
                radioBtnMale.Checked = true;
                radioBtnFemale.Checked = false;
            }
            else if (_personDetailDto.PersonGenderId == 2)
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

        private void cbxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = (ComboBoxItem)cbxCities.SelectedItem;
            if (selectedCity.Id.HasValue)
            {
                int cityId = selectedCity.Id.Value;
                ListPersonPage.FillComboBox(cbxDistricts, new EfDistrictDal().GetAll(d => d.CityId == cityId), "DistrictName", "DistrictId");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpBxUpdatePerson_Enter(object sender, EventArgs e)
        {

        }
    }
}
