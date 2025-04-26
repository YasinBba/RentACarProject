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
            cars.CreateDate = DateTime.Now;
            cars.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user

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
            cars.Descrpton = textBoxAciklama.Text;
            cars.UpdateDate = DateTime.Now;
            cars.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            var result = carManagement.UpdateCar(cars);
            dataGridViewAllCars.DataSource = carManagement.GetAllCars();
            MessageBox.Show(result);
        }

        private void dataGridViewAllCars_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxAracTanim.Text = dataGridViewAllCars.CurrentRow.Cells[1].Value.ToString();
            textBoxAracMarka.Text = dataGridViewAllCars.CurrentRow.Cells[2].Value.ToString();
            textBoxAracModel.Text = dataGridViewAllCars.CurrentRow.Cells[3].Value.ToString();
            textBoxAciklama.Text = dataGridViewAllCars.CurrentRow.Cells[4].Value.ToString();
            

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAllCars.CurrentRow.Cells[0].Value);
            carManagement.DeleteCar(id);
            dataGridViewAllCars.DataSource = carManagement.GetAllCars();
            MessageBox.Show("Silme işlemi başarılı");

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
