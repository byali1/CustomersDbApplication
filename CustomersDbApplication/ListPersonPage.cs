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
            dgwPersons.DataSource = _personService.GetAll();
        }
    }
}
