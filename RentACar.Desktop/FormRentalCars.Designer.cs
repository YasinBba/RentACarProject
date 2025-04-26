namespace RentACar.Desktop
{
    partial class FormRentalCars
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
            this.dataGridViewRentalCarList = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalCarList)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewRentalCarList
            // 
            this.dataGridViewRentalCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRentalCarList.Location = new System.Drawing.Point(35, 160);
            this.dataGridViewRentalCarList.Name = "dataGridViewRentalCarList";
            this.dataGridViewRentalCarList.Size = new System.Drawing.Size(993, 251);
            this.dataGridViewRentalCarList.TabIndex = 0;
            // 
            // FormRentalCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 450);
            this.Controls.Add(this.dataGridViewRentalCarList);
            this.Name = "FormRentalCars";
            this.Text = "FormRentalCars";
            this.Load += new System.EventHandler(this.FormRentalCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRentalCarList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRentalCarList;
    }
}