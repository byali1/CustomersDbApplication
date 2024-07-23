using DataAccess.Abstract;
using System;
using System.Windows.Forms;
using Business.Abstract;
using Entities.Concrete;

namespace CustomersDbApplication
{
    public partial class LoginPage : Form
    {
        public bool isSignInSuccess = false;
        private readonly IUserService _userService;

        public LoginPage(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
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

            // Hesabım var
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

            MessageBox.Show("Böyle bir hesap bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            }
        }

        private void SignIn(string username, string password)
        {
            _userService.UpdateLastActiveTime(username);
            isSignInSuccess = true;
            this.Close();
        }

        private bool IsUserExist(string username)
        {
            return _userService.IsUserExist(username);
        }

        private bool VerifyUserPassword(string password, string passwordHash)
        {
            return _userService.VerifyPassword(password, passwordHash);
        }

        private string GetPasswordHash(string username)
        {
            return _userService.GetPasswordHashByUsername(username);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            tbxUsername.Text = "byali";
            tbxPassword.Text = "byali123";
            checkBoxIHaveAccount.Checked = true;
        }
    }
}
