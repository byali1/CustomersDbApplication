using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Windows.Forms;
using CustomersDbApplication.CompanyForms;

namespace CustomersDbApplication
{
    public partial class HomePage : Form
    {


        public HomePage()
        {
            InitializeComponent();

        }

        //Public Operations
        public static void ClearAllTextBoxes(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        public static bool IsFormOpen(Type targetForm)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == targetForm)
                {
                    return true;
                }
            }
            return false;
        }

        public static int GetGenderId(bool radioBtnMaleChecked, bool radioBtnFemaleChecked)
        {
            if (radioBtnMaleChecked)
            {
                return 1;
            }
            if (radioBtnFemaleChecked)
            {
                return 2;
            }

            MessageBox.Show("Lütfen cinsiyet seçin.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return -1;
        }

        public static bool AreFilledAllTextBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    return false;
                }   
            }

            return true;
        }

        public static bool AreFilledAllComboBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is ComboBox comboBox && (comboBox.SelectedIndex == -1 || comboBox.SelectedIndex == 0))
                {
                    return false;
                }
            }

            return true;
                
        }

        public static bool AreFilledAllRichTextBoxes(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RichTextBox richTextBox && string.IsNullOrWhiteSpace(richTextBox.Text))
                {
                    return false;
                }
            }

            return true;
        }

        //Private
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
            if (IsFormOpen(typeof(ListCustomerPage)))
            {
                MessageBox.Show("Müşteri listeleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListCustomerPage listCustomerPage = new ListCustomerPage(new CustomerManager(new EfCustomerDal()));
            listCustomerPage.MdiParent = this;
            listCustomerPage.Show();
        }

        private void listPersonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ListPersonPage)))
            {
                MessageBox.Show("Gerçek müşteri listeleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListPersonPage listPersonPage = new ListPersonPage(new PersonManager(new EfPersonDal()),new CustomerManager(new EfCustomerDal()));
            listPersonPage.MdiParent = this;
            listPersonPage.Show();
        }

        private void listCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsFormOpen(typeof(ListCompanyPage)))
            {
                MessageBox.Show("Tüzel müşteri listeleme paneli zaten açık.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListCompanyPage listCompanyPage = new ListCompanyPage(new CompanyManager(new EfCompanyDal()));
            listCompanyPage.MdiParent = this;
            listCompanyPage.Show();
        }

        
    }
}