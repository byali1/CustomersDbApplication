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
            dgwCustomers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).BeginInit();
            SuspendLayout();
            // 
            // dgwCustomers
            // 
            dgwCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwCustomers.Location = new Point(40, 25);
            dgwCustomers.Name = "dgwCustomers";
            dgwCustomers.Size = new Size(533, 150);
            dgwCustomers.TabIndex = 0;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(707, 324);
            Controls.Add(dgwCustomers);
            Name = "HomePage";
            Text = "CustomersDb App";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dgwCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgwCustomers;
    }
}
