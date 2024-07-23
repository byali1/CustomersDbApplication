namespace CustomersDbApplication
{
    partial class HomePage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStripHomePage = new MenuStrip();
            cRUDİşlemleriToolStripMenuItem = new ToolStripMenuItem();
            addCustomerToolStripMenuItem = new ToolStripMenuItem();
            addPersonToolStripMenuItem = new ToolStripMenuItem();
            addCompanyToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıSilToolStripMenuItem = new ToolStripMenuItem();
            kullanıcıDüzenleToolStripMenuItem = new ToolStripMenuItem();
            görüntüleToolStripMenuItem = new ToolStripMenuItem();
            listAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            listPersonsToolStripMenuItem = new ToolStripMenuItem();
            listCompaniesListeleToolStripMenuItem = new ToolStripMenuItem();
            menuStripHomePage.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHomePage
            // 
            menuStripHomePage.Items.AddRange(new ToolStripItem[] { cRUDİşlemleriToolStripMenuItem, görüntüleToolStripMenuItem });
            menuStripHomePage.Location = new Point(0, 0);
            menuStripHomePage.Name = "menuStripHomePage";
            menuStripHomePage.Size = new Size(1164, 24);
            menuStripHomePage.TabIndex = 1;
            menuStripHomePage.Text = "menuStrip1";
            // 
            // cRUDİşlemleriToolStripMenuItem
            // 
            cRUDİşlemleriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCustomerToolStripMenuItem, kullanıcıSilToolStripMenuItem, kullanıcıDüzenleToolStripMenuItem });
            cRUDİşlemleriToolStripMenuItem.Name = "cRUDİşlemleriToolStripMenuItem";
            cRUDİşlemleriToolStripMenuItem.Size = new Size(97, 20);
            cRUDİşlemleriToolStripMenuItem.Text = "CRUD İşlemleri";
            // 
            // addCustomerToolStripMenuItem
            // 
            addCustomerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addPersonToolStripMenuItem, addCompanyToolStripMenuItem });
            addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            addCustomerToolStripMenuItem.Size = new Size(158, 22);
            addCustomerToolStripMenuItem.Text = "Müşteri ekle";
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(177, 22);
            addPersonToolStripMenuItem.Text = "Gerçek müşteri ekle";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // addCompanyToolStripMenuItem
            // 
            addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            addCompanyToolStripMenuItem.Size = new Size(177, 22);
            addCompanyToolStripMenuItem.Text = "Tüzel müşteri ekle";
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            kullanıcıSilToolStripMenuItem.Size = new Size(158, 22);
            kullanıcıSilToolStripMenuItem.Text = "Müşteri sil";
            // 
            // kullanıcıDüzenleToolStripMenuItem
            // 
            kullanıcıDüzenleToolStripMenuItem.Name = "kullanıcıDüzenleToolStripMenuItem";
            kullanıcıDüzenleToolStripMenuItem.Size = new Size(158, 22);
            kullanıcıDüzenleToolStripMenuItem.Text = "Müşteri düzenle";
            // 
            // görüntüleToolStripMenuItem
            // 
            görüntüleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listAllCustomersToolStripMenuItem, listPersonsToolStripMenuItem, listCompaniesListeleToolStripMenuItem });
            görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            görüntüleToolStripMenuItem.Size = new Size(72, 20);
            görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // listAllCustomersToolStripMenuItem
            // 
            listAllCustomersToolStripMenuItem.Name = "listAllCustomersToolStripMenuItem";
            listAllCustomersToolStripMenuItem.Size = new Size(202, 22);
            listAllCustomersToolStripMenuItem.Text = "Müşterileri listele";
            listAllCustomersToolStripMenuItem.Click += listAllCustomersToolStripMenuItem_Click;
            // 
            // listPersonsToolStripMenuItem
            // 
            listPersonsToolStripMenuItem.Name = "listPersonsToolStripMenuItem";
            listPersonsToolStripMenuItem.Size = new Size(202, 22);
            listPersonsToolStripMenuItem.Text = "Gerçek müşterileri listele";
            // 
            // listCompaniesListeleToolStripMenuItem
            // 
            listCompaniesListeleToolStripMenuItem.Name = "listCompaniesListeleToolStripMenuItem";
            listCompaniesListeleToolStripMenuItem.Size = new Size(202, 22);
            listCompaniesListeleToolStripMenuItem.Text = "Tüzel müşterileri listele";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 559);
            Controls.Add(menuStripHomePage);
            IsMdiContainer = true;
            MainMenuStrip = menuStripHomePage;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersDb App";
            Load += HomePage_Load;
            menuStripHomePage.ResumeLayout(false);
            menuStripHomePage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStripHomePage;
        private ToolStripMenuItem cRUDİşlemleriToolStripMenuItem;
        private ToolStripMenuItem addCustomerToolStripMenuItem;
        private ToolStripMenuItem kullanıcıSilToolStripMenuItem;
        private ToolStripMenuItem kullanıcıDüzenleToolStripMenuItem;
        private ToolStripMenuItem görüntüleToolStripMenuItem;
        private ToolStripMenuItem listAllCustomersToolStripMenuItem;
        private ToolStripMenuItem listPersonsToolStripMenuItem;
        private ToolStripMenuItem listCompaniesListeleToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem addCompanyToolStripMenuItem;
    }
}
