using RentACar.BLL;
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
    public partial class FormRentalCars : Form
    {
        public FormRentalCars()
        {
            InitializeComponent();
        }
        RentalCarManagment rentalCarManagment = new RentalCarManagment();

        private void FormRentalCars_Load(object sender, EventArgs e)
        {
            //dataGridViewRentalCarList.DataSource = rentalCarManagment.GetAllRentalCars();
            dataGridViewRentalCarList.DataSource=rentalCarManagment.GetAllRentalCarListDto();
        }
    }
}
