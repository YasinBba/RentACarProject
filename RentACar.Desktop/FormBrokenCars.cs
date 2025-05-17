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
            //

         

            //comboBoxCustomerName.DisplayMember = "FirstName";//Customer tablosundaki hangi alanı göstereceğini belirtiyoruz. Kolo adı 1-1 eşleşmeli, tek karakter bile farklı olmamalı
            comboBoxCustomerName.DisplayMember = "FullName";//Customer tablosundaki hangi alanı göstereceğini belirtiyoruz. Kolo adı 1-1 eşleşmeli, tek karakter bile farklı olmamalı
            //Value => DisplayMember = "FirstName" + " " + "LastName"; //Customer tablosundaki FirstName ve LastName alanlarını birleştirip göstereceğiz.
            comboBoxCustomerName.ValueMember = "Id";//Key alanı, yani Customer tablosundaki Id alanını kullanıyoruz.
            //comboBoxCustomerName.DataSource = db.Customers.ToList();
            comboBoxCustomerName.DataSource = db.Customers.
                Select(y=>new
                {
                    Id=y.Id,
                    FullName=y.FirstName+ " " + y.LastName //Customer tablosundaki FirstName ve LastName alanlarını birleştirip göstereceğiz.

                }).ToList();



        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            BrokenCars brokenCars = new BrokenCars();
            brokenCars.CarId = Convert.ToInt32(comboBoxCarName.SelectedValue);
            brokenCars.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            brokenCars.CreateDate = dateTimePicker1.Value;
            brokenCars.UpdateDate = dateTimePicker1.Value;
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
