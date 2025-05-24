using System;
using System.Windows.Forms;
using RentACar.BLL;
using RentACar.DLLModel.Model;

namespace RentACar.Desktop
{
    public partial class FormCars : Form
    {
        public FormCars()
        {
            InitializeComponent();
        }
        CarManagement carManagement = new CarManagement();

        private void FormCars_Load(object sender, EventArgs e)
        {


            dataGridViewAllCars.DataSource = carManagement.GetAllCars();

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {  
            Cars cars = new Cars();
            cars.Name = textBoxAracTanim.Text;
            cars.Brand = textBoxAracMarka.Text;
            cars.Model = textBoxAracModel.Text;
            cars.Descrpton = textBoxAciklama.Text;
            cars.PricePerDay = textBoxPricePerDay.Text;
            cars.FuelAmount = textBoxFuelAmount.Text;

            cars.CreateDate = DateTime.Now;
            cars.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            cars.IsActive = true; // TODO: Set the actual IsActive value based on your logic

            var result= carManagement.AddCar(cars);
            dataGridViewAllCars.DataSource = carManagement.GetAllCars();
            MessageBox.Show(result);
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            Cars cars = new Cars();
            cars.Id = Convert.ToInt32(dataGridViewAllCars.CurrentRow.Cells[0].Value);
            cars.Name = textBoxAracTanim.Text;
            cars.Brand = textBoxAracMarka.Text;
            cars.Model = textBoxAracModel.Text;
            cars.PricePerDay = textBoxPricePerDay.Text;
            cars.FuelAmount = textBoxFuelAmount.Text;
            cars.Descrpton = textBoxAciklama.Text;
            cars.UpdateDate = DateTime.Now;
            cars.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            cars.IsActive = true; // TODO: Set the actual IsActive value based on your logic
            var result = carManagement.UpdateCar(cars);
            dataGridViewAllCars.DataSource = carManagement.GetAllCars();
            MessageBox.Show(result);
        }

        private void dataGridViewAllCars_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracTanim.Text = dataGridViewAllCars.CurrentRow.Cells[1].Value.ToString();
            textBoxAracMarka.Text = dataGridViewAllCars.CurrentRow.Cells[2].Value.ToString();
            textBoxAracModel.Text = dataGridViewAllCars.CurrentRow.Cells[3].Value.ToString();
           textBoxPricePerDay.Text= dataGridViewAllCars.CurrentRow.Cells[4].Value.ToString();
            textBoxFuelAmount.Text = dataGridViewAllCars.CurrentRow.Cells[5].Value.ToString();
            
            

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllCars.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz aracı seçin.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bu aracı silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewAllCars.CurrentRow.Cells[0].Value);
                CarManagement carManagement = new CarManagement();
                string result = carManagement.DeleteCar(id);

                dataGridViewAllCars.DataSource = carManagement.GetAllCars();

                MessageBox.Show(result);
            }

        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            textBoxAracTanim.Clear();
            textBoxAracMarka.Clear();
            textBoxAracModel.Clear();
            textBoxAciklama.Clear();

        }
    }
}
