using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;

namespace CustomersDbApplication
{
    public partial class HomePage : Form
    {


        public HomePage()
        {
            InitializeComponent();

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
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

            addPersonPage.MdiParent = this;
            addPersonPage.Show();
        }

        private void listAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListCustomerPage listCustomerPage = new ListCustomerPage(new CustomerManager(new EfCustomerDal()));
            listCustomerPage.MdiParent = this;
            listCustomerPage.Show();
        }

        private void listPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListPersonPage listPersonPage = new ListPersonPage(new PersonManager(new EfPersonDal()));
            listPersonPage.MdiParent = this;
            listPersonPage.Show();
        }

        private void listCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}