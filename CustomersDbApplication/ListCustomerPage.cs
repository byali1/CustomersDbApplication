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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using CheckBox = System.Windows.Forms.CheckBox;

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

        private async void tbxSearchCustomerByName_TextChanged(object sender, EventArgs e)
        {
            if (!checkBxGetActiveCustomers.Checked && !checkBxGetInActiveCustomers.Checked)
            {
                SearchCustomersByName(tbxSearchCustomerByName.Text);
            }
            else if (checkBxGetActiveCustomers.Checked && !checkBxGetInActiveCustomers.Checked)
            {
                dgwCustomers.DataSource = await _customerService.GetAllByNameForActiveAsync(tbxSearchCustomerByName.Text);
            }
            else if (checkBxGetInActiveCustomers.Checked && !checkBxGetActiveCustomers.Checked)
            {
                dgwCustomers.DataSource = await _customerService.GetAllByNameForInActiveAsync(tbxSearchCustomerByName.Text);
            }
        }


        private async void SearchCustomersByName(string text)
        {
            dgwCustomers.DataSource = await _customerService.GetAllByNameAsync(text);
        }

        private async void ListCustomerPage_Load(object sender, EventArgs e)
        {
            dgwCustomers.DataSource = await _customerService.GetAllAsync();
        }

        private async void checkBxGetActiveCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox changedCheckBox)
            {
                if (changedCheckBox.Checked)
                {
                    if (changedCheckBox == checkBxGetActiveCustomers)
                    {

                        checkBxGetInActiveCustomers.CheckedChanged -= checkBxGetActiveCustomers_CheckedChanged;
                        checkBxGetInActiveCustomers.Checked = false;
                        checkBxGetInActiveCustomers.CheckedChanged += checkBxGetActiveCustomers_CheckedChanged;

                        dgwCustomers.DataSource = await _customerService.GetActiveCustomersAsync();
                    }
                    else if (changedCheckBox == checkBxGetInActiveCustomers)
                    {

                        checkBxGetActiveCustomers.CheckedChanged -= checkBxGetActiveCustomers_CheckedChanged;
                        checkBxGetActiveCustomers.Checked = false;
                        checkBxGetActiveCustomers.CheckedChanged += checkBxGetActiveCustomers_CheckedChanged;

                        dgwCustomers.DataSource = await _customerService.GetInActiveCustomersAsync();
                    }
                }
                else
                {

                    if (!checkBxGetActiveCustomers.Checked && !checkBxGetInActiveCustomers.Checked)
                    {
                        checkBxGetActiveCustomers.CheckedChanged -= checkBxGetActiveCustomers_CheckedChanged;
                        checkBxGetActiveCustomers.CheckedChanged += checkBxGetActiveCustomers_CheckedChanged;

                        checkBxGetInActiveCustomers.CheckedChanged -= checkBxGetActiveCustomers_CheckedChanged;
                        checkBxGetInActiveCustomers.CheckedChanged += checkBxGetActiveCustomers_CheckedChanged;

                        dgwCustomers.DataSource = await _customerService.GetAllAsync();
                    }
                }
            }
        }
    }
}
