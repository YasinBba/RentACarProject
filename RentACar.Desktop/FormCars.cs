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
    }
}
