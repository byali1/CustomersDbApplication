using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;

namespace CustomersDbApplication
{
    public partial class HomePage : Form
    {
        private IDbContext _dbContext;

        //public HomePage()
        //{
        //    InitializeComponent();
        //}
        public HomePage(IDbContext dbContext)
        {
            _dbContext = dbContext;
            InitializeComponent();

        }



        private void HomePage_Load(object sender, EventArgs e)
        {
            CustomerManager customerManager = new CustomerManager(new AdoNetCustomerDal(_dbContext));
            dgwCustomers.DataSource = customerManager.GetAll();

        }
    }
}
