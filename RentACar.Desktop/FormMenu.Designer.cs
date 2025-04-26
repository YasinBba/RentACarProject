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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arabalarToolStripMenuItemCars,
            this.toolStripMenuItemCustomers});
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
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 622);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arabalarToolStripMenuItemCars;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCustomers;
    }
}