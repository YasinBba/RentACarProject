using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Desktop
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars formCars = new FormCars();
            formCars.MdiParent = this;
            formCars.Show();
        }

        private void toolStripMenuItemCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.MdiParent = this;
            formCustomers.Show();
        }

        private void ToolStripMenuItemRentalCars_Click(object sender, EventArgs e)
        {
            FormRentalCars formRentalCar = new FormRentalCars();
            formRentalCar.MdiParent = this;
            formRentalCar.Show();
        }
    }
}
