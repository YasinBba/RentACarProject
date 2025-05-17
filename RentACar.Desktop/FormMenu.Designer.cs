namespace RentACar.Desktop
{
    partial class FormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arabalarToolStripMenuItemCars = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRentalCars = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brokenCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelLoginName = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabalarToolStripMenuItemCars,
            this.toolStripMenuItemCustomers,
            this.ToolStripMenuItemRentalCars,
            this.usersToolStripMenuItem,
            this.rulesToolStripMenuItem,
            this.employeesToolStripMenuItem,
            this.brokenCarsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arabalarToolStripMenuItemCars
            // 
            this.arabalarToolStripMenuItemCars.Name = "arabalarToolStripMenuItemCars";
            this.arabalarToolStripMenuItemCars.Size = new System.Drawing.Size(42, 20);
            this.arabalarToolStripMenuItemCars.Text = "Cars";
            this.arabalarToolStripMenuItemCars.Click += new System.EventHandler(this.arabalarToolStripMenuItem_Click);
            // 
            // toolStripMenuItemCustomers
            // 
            this.toolStripMenuItemCustomers.Name = "toolStripMenuItemCustomers";
            this.toolStripMenuItemCustomers.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItemCustomers.Text = "Customers";
            this.toolStripMenuItemCustomers.Click += new System.EventHandler(this.toolStripMenuItemCustomers_Click);
            // 
            // ToolStripMenuItemRentalCars
            // 
            this.ToolStripMenuItemRentalCars.Name = "ToolStripMenuItemRentalCars";
            this.ToolStripMenuItemRentalCars.Size = new System.Drawing.Size(78, 20);
            this.ToolStripMenuItemRentalCars.Text = "Rental Cars";
            this.ToolStripMenuItemRentalCars.Click += new System.EventHandler(this.ToolStripMenuItemRentalCars_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.employeesToolStripMenuItem.Text = "Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // brokenCarsToolStripMenuItem
            // 
            this.brokenCarsToolStripMenuItem.Name = "brokenCarsToolStripMenuItem";
            this.brokenCarsToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.brokenCarsToolStripMenuItem.Text = "Broken Cars";
            this.brokenCarsToolStripMenuItem.Click += new System.EventHandler(this.brokenCarsToolStripMenuItem_Click);
            // 
            // labelLoginName
            // 
            this.labelLoginName.AutoSize = true;
            this.labelLoginName.Location = new System.Drawing.Point(829, 10);
            this.labelLoginName.Name = "labelLoginName";
            this.labelLoginName.Size = new System.Drawing.Size(33, 13);
            this.labelLoginName.TabIndex = 2;
            this.labelLoginName.Text = "Login";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 622);
            this.Controls.Add(this.labelLoginName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arabalarToolStripMenuItemCars;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomers;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemRentalCars;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brokenCarsToolStripMenuItem;
        public System.Windows.Forms.Label labelLoginName;
    }
}