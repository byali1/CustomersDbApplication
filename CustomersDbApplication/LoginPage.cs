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

        private async void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                var username = tbxUsername.Text;
                var password = tbxPassword.Text;

                if (!checkBoxIHaveAccount.Checked)
                {
                    // Hesap oluşturma
                    if (!await IsUserExistAsync(username))
                    {
                        await SignUpAsync(username, password);
                        return;
                    }

                    MessageBox.Show("Bu kullanıcı adı ile zaten bir üye mevcut.", "UYARI", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                // Hesabım var
                if (await IsUserExistAsync(username))
                {
                    string passwordHash = await GetPasswordHashByUsernameAsync(username);

                    if (await VerifyUserPasswordAsync(password, passwordHash))
                    {
                        await SignInAsync(username, password);
                        return;
                    }

                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.", "HATA", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Böyle bir hesap bulunamadı.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Veritabanına bağlanılamadı.", "DİKKAT", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
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

        private async Task SignUpAsync(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var user = new User
                {
                    UserRoleId = 1,
                    Username = username.ToLower(),
                    PasswordHash = password, 
                    AccountCreatedTime = DateTime.UtcNow,
                    LastAciveTime = DateTime.UtcNow,
                    IsActive = true
                };

                await _userService.AddAsync(user);
                MessageBox.Show("Başarıyla üye oldunuz.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"Kayıt işlemi başarısız. {exception.Message}", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async Task SignInAsync(string username, string password)
        {
            await _userService.UpdateLastActiveTimeAsync(username);
            isSignInSuccess = true;
            this.Close();
        }


        private async Task<bool> IsUserExistAsync(string username)
        {
            return await _userService.IsUserExistAsync(username);
        }

        private async Task<bool> VerifyUserPasswordAsync(string password, string passwordHash)
        {
            return await _userService.VerifyPasswordAsync(password, passwordHash);
        }

        private async Task<string> GetPasswordHashByUsernameAsync(string username)
        {
            return await _userService.GetPasswordHashByUsernameAsync(username);
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            tbxUsername.Text = "byali";
            tbxPassword.Text = "byali123";
            checkBoxIHaveAccount.Checked = true;
        }
    }
}
