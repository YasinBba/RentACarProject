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
    public partial class FormRentalCars : Form
    {
        public FormRentalCars()
        {
            InitializeComponent();
        }

        
        RentalCarManagment rentalCarManagment = new RentalCarManagment();
        YasinRentACarEntities db = new YasinRentACarEntities();

        private void FormRentalCars_Load(object sender, EventArgs e)
        {
            dataGridViewRentalCarList.AutoGenerateColumns = true;
            dataGridViewRentalCarList.DataSource = rentalCarManagment.GetAllRentalCarListDto();

            comboBoxCarName.DisplayMember = "Name";
            comboBoxCarName.ValueMember = "Id";
            comboBoxCarName.DataSource = db.Cars
            .Where(car => car.IsActive == true) // filtreleme
            .ToList();


            comboBoxCarPrice.DisplayMember = "Name";
            comboBoxCarPrice.ValueMember = "Id";
            comboBoxCarPrice.DataSource = db.Cars.ToList();
            comboBoxCarPrice.DataSource = db.Cars
            .Where(car => car.IsActive == true) // filtreleme
            .ToList();


            comboBoxCustomerName.DisplayMember = "FullName";
            comboBoxCustomerName.ValueMember = "Id";
            comboBoxCustomerName.DataSource = db.Customers
                .Where(c => c.IsActive == true) // sadece IsActive = "1" olanlar
                .Select(c => new
                {
                    Id = c.Id,
                    FullName = c.FirstName + " " + c.LastName
                })
                .ToList();


            comboBoxDaytime.Items.Add("1-6 gün");
            comboBoxDaytime.Items.Add("7-29 gün");
            comboBoxDaytime.Items.Add("30-89 gün");
            comboBoxDaytime.Items.Add("90-179 gün");
            comboBoxDaytime.Items.Add("180-364 gün");
            comboBoxDaytime.Items.Add("365-> gün");
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            RentalCars rentalCar = new RentalCars();
            rentalCar.CarId = Convert.ToInt32(comboBoxCarName.SelectedValue);
            rentalCar.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            rentalCar.StartDate = dateTimePickerStartDate.Value;
            rentalCar.EndDate = dateTimePickerEndDate.Value;

            rentalCar.PricePerDay = 100; // geçici örnek değer
            rentalCar.FuelAmount = 50;

            rentalCar.Description = textBoxDescription.Text;
            rentalCar.CreateDate = DateTime.Now;
            rentalCar.CreatorId = 1;
            rentalCar.UserId = 1;  // ← eksik olan kısım
            rentalCar.UpdateDate = DateTime.Now;
            rentalCar.UpdatorId = 1;
            rentalCar.IsActive = "True";

            var result = rentalCarManagment.AddRentalCar(rentalCar);
            dataGridViewRentalCarList.DataSource = rentalCarManagment.GetAllRentalCarListDto();
            MessageBox.Show(result);



        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            RentalCars rentalCar = new RentalCars();
            rentalCar.Id = Convert.ToInt32(dataGridViewRentalCarList.CurrentRow.Cells["Id"].Value);
            rentalCar.CarId = Convert.ToInt32(comboBoxCarName.SelectedValue);
            rentalCar.CustomerId = Convert.ToInt32(comboBoxCustomerName.SelectedValue);
            rentalCar.StartDate = dateTimePickerStartDate.Value;
            rentalCar.EndDate = dateTimePickerEndDate.Value;
            rentalCar.PricePerDay = 100; // opsiyonel: formdan al
            rentalCar.FuelAmount = 50;   // opsiyonel: formdan al
            rentalCar.Description = textBoxDescription.Text;
            rentalCar.UpdateDate = DateTime.Now;
            rentalCar.UpdatorId = 1;     // Giriş yapan kullanıcı ID
            rentalCar.IsActive = "True";

            var result = rentalCarManagment.UpdateRentalCar(rentalCar);
            dataGridViewRentalCarList.DataSource = rentalCarManagment.GetAllRentalCarListDto();
            MessageBox.Show(result);

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewRentalCarList.CurrentRow.Cells[0].Value);
            rentalCarManagment.DeleteRentalCar(id);
            dataGridViewRentalCarList.DataSource = rentalCarManagment.GetAllRentalCarListDto();
            MessageBox.Show("Silindi");

        }

        private void dataGridViewRentalCarList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewRentalCarList.CurrentRow != null)
            {
                comboBoxCarName.Text = dataGridViewRentalCarList.CurrentRow.Cells["CarName"].Value.ToString();
                comboBoxCustomerName.Text = dataGridViewRentalCarList.CurrentRow.Cells["CustomerName"].Value.ToString();
                textBoxDescription.Text = dataGridViewRentalCarList.CurrentRow.Cells["Description"].Value.ToString();
                dateTimePickerStartDate.Value = Convert.ToDateTime(dataGridViewRentalCarList.CurrentRow.Cells["StartDate"].Value);
                dateTimePickerEndDate.Value = Convert.ToDateTime(dataGridViewRentalCarList.CurrentRow.Cells["EndDate"].Value);
            }

        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            comboBoxCarName.Text = string.Empty;
            comboBoxCustomerName.Text = string.Empty;
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            textBoxDescription.Text = string.Empty;

        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            
        }
    }
}
