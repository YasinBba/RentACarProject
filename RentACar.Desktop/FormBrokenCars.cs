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
            comboBoxCarName.DataSource = db.Cars
            .Where(car => car.IsActive == true) 
            .ToList();




            comboBoxCustomerName.DisplayMember = "FirstName";
            comboBoxCustomerName.DisplayMember = "FullName";
            comboBoxCustomerName.ValueMember = "Id";
            comboBoxCustomerName.DataSource = db.Customers
                .Where(c => c.IsActive == true) 
                .Select(c => new
                {
                    Id = c.Id,
                    FullName = c.FirstName + " " + c.LastName
                })
                .ToList();




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
