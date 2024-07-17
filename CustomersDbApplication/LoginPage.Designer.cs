﻿namespace CustomersDbApplication
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            lblUsername = new Label();
            lblPassword = new Label();
            checkBoxIHaveAccount = new CheckBox();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // tbxUsername
            // 
            tbxUsername.Location = new Point(230, 104);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(181, 23);
            tbxUsername.TabIndex = 1;
            // 
            // tbxPassword
            // 
            tbxPassword.Location = new Point(230, 162);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(181, 23);
            tbxPassword.TabIndex = 2;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(230, 86);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(74, 15);
            lblUsername.TabIndex = 3;
            lblUsername.Text = "Kullanıcı adı:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(232, 144);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(33, 15);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Şifre:";
            // 
            // checkBoxIHaveAccount
            // 
            checkBoxIHaveAccount.AutoSize = true;
            checkBoxIHaveAccount.Location = new Point(233, 191);
            checkBoxIHaveAccount.Name = "checkBoxIHaveAccount";
            checkBoxIHaveAccount.Size = new Size(92, 19);
            checkBoxIHaveAccount.TabIndex = 5;
            checkBoxIHaveAccount.Text = "Hesabım var";
            checkBoxIHaveAccount.UseVisualStyleBackColor = true;
            checkBoxIHaveAccount.CheckedChanged += checkBoxIHaveAccount_CheckedChanged;
            // 
            // btnSignUp
            // 
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.Location = new Point(230, 235);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(86, 29);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Üye Ol";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(628, 318);
            Controls.Add(btnSignUp);
            Controls.Add(checkBoxIHaveAccount);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersDb - Giriş Paneli";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Label lblUsername;
        private Label lblPassword;
        private CheckBox checkBoxIHaveAccount;
        private Button btnSignUp;
    }
}