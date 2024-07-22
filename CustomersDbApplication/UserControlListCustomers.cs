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

namespace CustomersDbApplication
{
    public partial class UserControlListCustomers : UserControl
    {
        private readonly ICustomerService _customerService;


        public UserControlListCustomers(ICustomerService customerService)
        {

            _customerService = customerService;
            InitializeComponent();
        }

        private void UserControlListCustomers_Load(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            dgwCustomers.DataSource = customerManager.GetAll();
        }

        private void tbxSearchCustomerByName_TextChanged(object sender, EventArgs e)
        {
            SearchCustomersByName(tbxSearchCustomerByName.Text);
        }


        private void SearchCustomersByName(string text)
        {
            dgwCustomers.DataSource = _customerService.GetAllByName(text);
        }
    }
}
