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
using Business.Abstract;
using Business.Utilities.SpecialFunctions;
using DataAccess.Concrete;
using Entities.Concrete;
using static System.Net.Mime.MediaTypeNames;

namespace CustomersDbApplication
{
    public partial class LoginPage : Form
    {
        private IDbContext _dbContext;
        private IUserService _userService;
        //public LoginPage()
        //{
        //    InitializeComponent();
        //}

        public LoginPage( IUserService userService, IDbContext dbContext)
        {
            InitializeComponent();
            _userService = userService;
            _dbContext = dbContext;
        }


        private void btnSignUp_Click(object sender, EventArgs e)
        {
            var username = tbxUsername.Text;
            var password = tbxPassword.Text;



            if (!checkBoxIHaveAccount.Checked)
            {
                if (!IsUserExist(username))
                {
                    SignUp(username, password);
                    return;
                }

                MessageBox.Show("Bu kullanıcı adı ile zaten bir üye mevcut.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            //Hesabım var
            if (IsUserExist(username))
            {
                string passwordHash = GetPasswordHash(username);

                if (VerifyUserPassword(password, passwordHash))
                {
                    SignIn(username, password);
                    return;
                }

                MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Böyle bir hesap bulunamadı..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);




        }



        private void checkBoxIHaveAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxIHaveAccount.Checked)
            {
                btnSignUp.Text = "Giriş yap";

                return;
            }

            btnSignUp.Text = "Üye ol";
        }



        private void SignUp(string username, string password)
        {
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
                _userService.Add(new User
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


        private void SignIn(string username, string password)
        {
            this.Hide();
            HomePage homePage = new HomePage();
            homePage.Show();
        }

        private bool IsUserExist(string username)
        {
            return _userService.IsUserExist(username);
        }

        private bool VerifyUserPassword(string password, string passworHash)
        {
            return _userService.VerifyPassword(password, passworHash);
        }

        private string GetPasswordHash(string username)
        {
            return _userService.GetPasswordHashByUsername(username);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}