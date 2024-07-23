using Business.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomersDbApplication
{
    public partial class ListCustomerPage : Form
    {
        private readonly ICustomerService _customerService;
        public ListCustomerPage(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
        }

        private void tbxSearchCustomerByName_TextChanged(object sender, EventArgs e)
        {
            SearchCustomersByName(tbxSearchCustomerByName.Text);
        }


        private void SearchCustomersByName(string text)
        {
            dgwCustomers.DataSource = _customerService.GetAllByName(text);
        }

        private void ListCustomerPage_Load(object sender, EventArgs e)
        {
            dgwCustomers.DataSource = _customerService.GetAll();
        }
    }
}
