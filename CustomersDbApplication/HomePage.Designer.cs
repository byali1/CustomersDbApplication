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
            müşterileriListeleToolStripMenuItem = new ToolStripMenuItem();
            gerçekMüşterileriListeleToolStripMenuItem = new ToolStripMenuItem();
            tüzelMüşterileriListeleToolStripMenuItem = new ToolStripMenuItem();
            menuStripHomePage.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHomePage
            // 
            menuStripHomePage.Items.AddRange(new ToolStripItem[] { cRUDİşlemleriToolStripMenuItem, görüntüleToolStripMenuItem });
            menuStripHomePage.Location = new Point(0, 0);
            menuStripHomePage.Name = "menuStripHomePage";
            menuStripHomePage.Size = new Size(707, 24);
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
            addCustomerToolStripMenuItem.Size = new Size(180, 22);
            addCustomerToolStripMenuItem.Text = "Müşteri ekle";
            // 
            // addPersonToolStripMenuItem
            // 
            addPersonToolStripMenuItem.Name = "addPersonToolStripMenuItem";
            addPersonToolStripMenuItem.Size = new Size(180, 22);
            addPersonToolStripMenuItem.Text = "Gerçek müşteri ekle";
            addPersonToolStripMenuItem.Click += addPersonToolStripMenuItem_Click;
            // 
            // addCompanyToolStripMenuItem
            // 
            addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            addCompanyToolStripMenuItem.Size = new Size(180, 22);
            addCompanyToolStripMenuItem.Text = "Tüzel müşteri ekle";
            // 
            // kullanıcıSilToolStripMenuItem
            // 
            kullanıcıSilToolStripMenuItem.Name = "kullanıcıSilToolStripMenuItem";
            kullanıcıSilToolStripMenuItem.Size = new Size(180, 22);
            kullanıcıSilToolStripMenuItem.Text = "Müşteri sil";
            // 
            // kullanıcıDüzenleToolStripMenuItem
            // 
            kullanıcıDüzenleToolStripMenuItem.Name = "kullanıcıDüzenleToolStripMenuItem";
            kullanıcıDüzenleToolStripMenuItem.Size = new Size(180, 22);
            kullanıcıDüzenleToolStripMenuItem.Text = "Müşteri düzenle";
            // 
            // görüntüleToolStripMenuItem
            // 
            görüntüleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { müşterileriListeleToolStripMenuItem, gerçekMüşterileriListeleToolStripMenuItem, tüzelMüşterileriListeleToolStripMenuItem });
            görüntüleToolStripMenuItem.Name = "görüntüleToolStripMenuItem";
            görüntüleToolStripMenuItem.Size = new Size(72, 20);
            görüntüleToolStripMenuItem.Text = "Görüntüle";
            // 
            // müşterileriListeleToolStripMenuItem
            // 
            müşterileriListeleToolStripMenuItem.Name = "müşterileriListeleToolStripMenuItem";
            müşterileriListeleToolStripMenuItem.Size = new Size(202, 22);
            müşterileriListeleToolStripMenuItem.Text = "Müşterileri listele";
            // 
            // gerçekMüşterileriListeleToolStripMenuItem
            // 
            gerçekMüşterileriListeleToolStripMenuItem.Name = "gerçekMüşterileriListeleToolStripMenuItem";
            gerçekMüşterileriListeleToolStripMenuItem.Size = new Size(202, 22);
            gerçekMüşterileriListeleToolStripMenuItem.Text = "Gerçek müşterileri listele";
            // 
            // tüzelMüşterileriListeleToolStripMenuItem
            // 
            tüzelMüşterileriListeleToolStripMenuItem.Name = "tüzelMüşterileriListeleToolStripMenuItem";
            tüzelMüşterileriListeleToolStripMenuItem.Size = new Size(202, 22);
            tüzelMüşterileriListeleToolStripMenuItem.Text = "Tüzel müşterileri listele";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 324);
            Controls.Add(menuStripHomePage);
            MainMenuStrip = menuStripHomePage;
            MaximizeBox = false;
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
        private ToolStripMenuItem müşterileriListeleToolStripMenuItem;
        private ToolStripMenuItem gerçekMüşterileriListeleToolStripMenuItem;
        private ToolStripMenuItem tüzelMüşterileriListeleToolStripMenuItem;
        private ToolStripMenuItem addPersonToolStripMenuItem;
        private ToolStripMenuItem addCompanyToolStripMenuItem;
    }
}
