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
            görüntüleToolStripMenuItem = new ToolStripMenuItem();
            listAllCustomersToolStripMenuItem = new ToolStripMenuItem();
            listPersonsToolStripMenuItem = new ToolStripMenuItem();
            listCompaniesToolStripMenuItem = new ToolStripMenuItem();
            menuStripHomePage.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripHomePage
            // 
            menuStripHomePage.Items.AddRange(new ToolStripItem[] { görüntüleToolStripMenuItem });
            menuStripHomePage.Location = new Point(0, 0);
            menuStripHomePage.Name = "menuStripHomePage";
            menuStripHomePage.Size = new Size(1164, 24);
            menuStripHomePage.TabIndex = 1;
            menuStripHomePage.Text = "menuStrip1";
            // 
            // görüntüleToolStripMenuItem
            // 
            görüntüleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listAllCustomersToolStripMenuItem, listPersonsToolStripMenuItem, listCompaniesToolStripMenuItem });
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
            listPersonsToolStripMenuItem.Click += listPersonsToolStripMenuItem_Click;
            // 
            // listCompaniesToolStripMenuItem
            // 
            listCompaniesToolStripMenuItem.Name = "listCompaniesToolStripMenuItem";
            listCompaniesToolStripMenuItem.Size = new Size(202, 22);
            listCompaniesToolStripMenuItem.Text = "Tüzel müşterileri listele";
            listCompaniesToolStripMenuItem.Click += listCompaniesToolStripMenuItem_Click;
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
            WindowState = FormWindowState.Maximized;
            Load += HomePage_Load;
            menuStripHomePage.ResumeLayout(false);
            menuStripHomePage.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStripHomePage;
        private ToolStripMenuItem görüntüleToolStripMenuItem;
        private ToolStripMenuItem listAllCustomersToolStripMenuItem;
        private ToolStripMenuItem listPersonsToolStripMenuItem;
        private ToolStripMenuItem listCompaniesToolStripMenuItem;
    }
}
