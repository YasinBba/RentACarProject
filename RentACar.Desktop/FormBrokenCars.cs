using RentACar.BLL;
using RentACar.DLLModel.Model;
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
    public partial class FormBrokenCars : Form
    {
        public FormBrokenCars()
        {
            InitializeComponent();
        }
        BrokenCarsManagment brokenCarsManagment = new BrokenCarsManagment();
        YasinRentACarEntities db = new YasinRentACarEntities();
        private void FormBrokenCars_Load(object sender, EventArgs e)
        {
            //dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCars();
            dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();
            dataGridViewBrokenCarList.AutoGenerateColumns = true;
            comboBoxCarName.DisplayMember = "Name";
            comboBoxCarName.ValueMember = "Id";
            comboBoxCarName.DataSource = db.Cars.ToList();
            comboBoxCustomerName.DisplayMember = "CustomerName";
            comboBoxCustomerName.ValueMember = "Id";
            comboBoxCustomerName.DataSource = db.Customers.ToList();



        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            BrokenCars brokenCars = new BrokenCars();
            brokenCars.CarId = Convert.ToInt32(comboBoxCarName.SelectedValue);
            brokenCars.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            brokenCars.CreateDate = dateTimePicker1.Value;
            brokenCars.BrokenDescription = textBoxDescription.Text;
            brokenCars.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            var result = brokenCarsManagment.AddBrokenCar(brokenCars);
            dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();
            MessageBox.Show(result);




        }
        //Cars cars = new Cars();
        //cars.Name = textBoxAracTanim.Text;
        //    cars.Brand = textBoxAracMarka.Text;
        //    cars.Model = textBoxAracModel.Text;
        //    cars.Descrpton = textBoxAciklama.Text;
        //    cars.CreateDate = DateTime.Now;
        //    cars.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user

        //   var result = carManagement.AddCar(cars);
        //dataGridViewAllCars.DataSource = carManagement.GetAllCars();
        //    MessageBox.Show(result);
    }
}
