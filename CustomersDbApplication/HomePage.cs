using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;
using DataAccess.Concrete.EntityFramework;

namespace CustomersDbApplication
{
    public partial class HomePage : Form
    {


        private Panel userControlPanel;

        //public HomePage()
        //{
        //    InitializeComponent();
        //}
        public HomePage()
        {
            InitializeComponent();

            userControlPanel = new Panel();
            userControlPanel.Dock = DockStyle.Fill;

            this.Controls.Add(userControlPanel);
            userControlPanel.BringToFront();

        }



        private void HomePage_Load(object sender, EventArgs e)
        {


        }



        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlAddPerson(
                new CustomerManager(new EfCustomerDal()),
                new PersonManager(new EfPersonDal()),
                new CustomerAddressManager(new EfCustomerAddressDal()),
                new AddressDetailManager(new EfAddressDetailDal()),
                new PhoneNumberDetailManager(new EfPhoneNumberDetailDal()),
                new CustomerPhoneNumberManager(new EfCustomerPhoneNumberDal()),
                new EmailDetailManager(new EfEmailDetailDal()),
                new CustomerEmailManager(new EfCustomerEmailDal())
                ));



        }




        //Other func.
        private void LoadUserControl(UserControl userControl)
        {
            userControlPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            userControlPanel.Controls.Add(userControl);
        }

        private void listAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadUserControl(new UserControlListCustomers(new CustomerManager(new EfCustomerDal())));
        }
    }
}