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

namespace CustomersDbApplication
{
    public partial class UserControlAddPerson : UserControl
    {
        private readonly IDbContext _dbContext;
        public UserControlAddPerson(IDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();

        }

        

        private void UserControlAddPerson_Load(object sender, EventArgs e)
        {
            //PersonManager olarak değişecek
            CustomerManager customerManager = new CustomerManager(new AdoNetCustomerDal(_dbContext));
            dgwPersons.DataSource = customerManager.GetAll();
        }
    }
}