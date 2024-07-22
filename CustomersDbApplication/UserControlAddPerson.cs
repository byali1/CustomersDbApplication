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
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace CustomersDbApplication
{
    public partial class UserControlAddPerson : UserControl
    {

        private readonly ICustomerService _customerService;
        private readonly IPersonService _personService;
        public UserControlAddPerson(ICustomerService customerService, IPersonService personService)
        {
            _customerService = customerService;
            _personService = personService;
            InitializeComponent();

        }



        private void UserControlAddPerson_Load(object sender, EventArgs e)
        {
            dgwPersons.DataSource = _personService.GetAll();
            FillComboBoxPersonIdentityTypes(new EfPersonIdentityTypeDal());
            //FillComboBoxPersonOccupations(new EfPersonOccupationDal());


        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            string customerName = tbxCustomerName.Text;
            string customerLastName = tbxCustomerLastName.Text;

            var check = IsNullOrEmptyCustomerInformation(customerName, customerLastName);

            if (!check)
            {
                var customer = new Customer
                {
                    Name = customerName,
                    LastName = customerLastName
                };

                _customerService.Add(customer);

                int customerId = customer.CustomerId;

                var selectedIdentityType = (PersonIdentityType)cbxPersonIdentityType.SelectedItem;
                int personIdentityTypeId = selectedIdentityType.PersonIdentityTypeId;







            }

            MessageBox.Show("Müşteri ad ve soyad kısmı boş olamaz.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        private bool AddCustomerToDatabase(string customerName, string customerLastName)
        {
            return true;
        }

        private bool IsNullOrEmptyCustomerInformation(string customerName, string customerLastName)
        {
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(customerLastName))
            {
                return true;
            }
            return false;
        }





        private void FillComboBoxPersonIdentityTypes(IPersonIdentityTypeDal personIdentityTypeDal)
        {
            BindingSource bindingSource = new BindingSource();
            
            bindingSource.DataSource = personIdentityTypeDal.GetAll();
            cbxPersonIdentityType.DataSource = bindingSource;
            cbxPersonIdentityType.DisplayMember = "IdentityTypeDescription";
            cbxPersonIdentityType.ValueMember = "PersonIdentityTypeId";
        }


        private void FillComboBoxPersonOccupations(IPersonOccupationDal personOccupationDal)
        {
            BindingSource bindingSource = new BindingSource();

            bindingSource.DataSource = personOccupationDal.GetAll();
            cbxPersonOccupations.DataSource = bindingSource;
            cbxPersonIdentityType.DisplayMember = "OccupationName";
            cbxPersonIdentityType.ValueMember = "PersonOccupationId";
        }
    }
}