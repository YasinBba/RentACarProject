using RentACar.BLL;
using RentACar.DLLModel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
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
           dataGridViewBrokenCarList.AutoGenerateColumns = true;
           
          dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();




            comboBoxCarName.DisplayMember = "Name";
            comboBoxCarName.ValueMember = "Id";
            comboBoxCarName.DataSource = db.Cars.ToList();
            



            comboBoxCustomerName.DisplayMember = "FirstName";//Customer tablosundaki hangi alanı göstereceğini belirtiyoruz. Kolo adı 1-1 eşleşmeli, tek karakter bile farklı olmamalı
            comboBoxCustomerName.DisplayMember = "FullName";//Customer tablosundaki hangi alanı göstereceğini belirtiyoruz. Kolo adı 1-1 eşleşmeli, tek karakter bile farklı olmamalı
                                                            //Value => DisplayMember = "FirstName" + " " + "LastName"; //Customer tablosundaki FirstName ve LastName alanlarını birleştirip göstereceğiz.
            comboBoxCustomerName.ValueMember = "Id";//Key alanı, yani Customer tablosundaki Id alanını kullanıyoruz.
                                                    //comboBoxCustomerName.DataSource = db.Customers.ToList();
            comboBoxCustomerName.DataSource = db.Customers.
                Select(y => new
                {
                    Id = y.Id,
                    FullName = y.FirstName + " " + y.LastName //Customer tablosundaki FirstName ve LastName alanlarını birleştirip göstereceğiz.

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
            brokenCars.IsActive = "True"; // TODO: Set the actual active status based on your application logic
            var result = brokenCarsManagment.AddBrokenCar(brokenCars);
            dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();
            MessageBox.Show(result);




        }

       

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            BrokenCars brokenCars = new BrokenCars();
            brokenCars.Id = Convert.ToInt32(dataGridViewBrokenCarList.CurrentRow.Cells[0].Value);
            brokenCars.CarId = Convert.ToInt32(comboBoxCarName.SelectedValue);
            brokenCars.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            brokenCars.UpdateDate = dateTimePicker1.Value;
            brokenCars.BrokenDescription = textBoxDescription.Text;
            brokenCars.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            brokenCars.IsActive = "True";

            var result = brokenCarsManagment.UpdateBrokenCar(brokenCars);
            dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();
            MessageBox.Show(result);


        }
        private void dataGridViewBrokenCarList_DoubleClick(object sender, EventArgs e)
        {
            comboBoxCarName.Text = dataGridViewBrokenCarList.CurrentRow.Cells[1].Value.ToString();
            comboBoxCustomerName.Text = dataGridViewBrokenCarList.CurrentRow.Cells[4].Value.ToString();
            textBoxDescription.Text = dataGridViewBrokenCarList.CurrentRow.Cells[5].Value?.ToString() ?? "";





        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewBrokenCarList.CurrentRow.Cells[0].Value);
            brokenCarsManagment.DeleteBrokenCar(id);
            dataGridViewBrokenCarList.DataSource = brokenCarsManagment.GetAllBrokenCarListDto();
            MessageBox.Show("Silindi");

        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            textBoxDescription.Clear();
            comboBoxCarName.SelectedIndex = -1;
            comboBoxCustomerName.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;

        }
        
    }
}
