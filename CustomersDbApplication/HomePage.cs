using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;
using DataAccess.Concrete.EntityFramework;

namespace CustomersDbApplication
{
    public partial class HomePage : Form
    {
        private IDbContext _dbContext;

        private Panel userControlPanel;

        //public HomePage()
        //{
        //    InitializeComponent();
        //}
        public HomePage(IDbContext dbContext)
        {
            _dbContext = dbContext;
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
            LoadUserControl(new UserControlAddPerson(_dbContext));
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