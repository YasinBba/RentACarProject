using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.DLL.Entities;
using RentACar.BLL;

namespace RentACar.Desktop
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }

        private void FormCars_Load(object sender, EventArgs e)
        {

            CarManagement carManagement = new CarManagement();

            dataGridViewAllCars.DataSource = carManagement.GetAll();

        }
    }
}
