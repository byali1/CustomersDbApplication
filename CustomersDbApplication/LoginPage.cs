using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Utilities.SpecialFunctions;
using Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace CustomersDbApplication
{
    public partial class LoginPage : Form
    {
        private IDbContext _dbContext;
        private IUserDal _userDal;
        //public LoginPage()
        //{
        //    InitializeComponent();
        //}

        public LoginPage(IDbContext dbContext, IUserDal userDal)
        {
            InitializeComponent();
            _dbContext = dbContext;
            _userDal = userDal;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = tbxUsername.Text;
            var password = tbxPassword.Text;

            if (ControlFunctions.IsNullOrWhiteSpace(username) || ControlFunctions.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz, boşluk karakteri içeremez.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if (ControlFunctions.CheckStartsWithNumber(username))
            {
                MessageBox.Show("Kullanıcı adı sayı ile başlayamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (ControlFunctions.IsContainsSpace(username))
            {

              ControlFunctions.RemoveSpaces(username);
            }




            try
            {
                _userDal.Add(new User
                {
                    UserRoleId = 1,
                    Username = username.ToLower(),
                    PasswordHash = password,
                    AccountCreatedTime = DateTime.UtcNow,
                    LastAciveTime = DateTime.UtcNow,
                    IsActive = true
                });
                MessageBox.Show("Başarıyla üye oldunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Kayıt işlemi başarısız. {exception.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }




    }
}