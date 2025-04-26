using RentACar.BLL;
using RentACar.DLL.ModelConnection;
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
    public partial class FormEmployees : Form
    {
     
        public FormEmployees()
        {
            InitializeComponent();
        }
        EmployeeManagment employeeManagement = new EmployeeManagment();

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            dataGridViewAllEmployees.DataSource = employeeManagement.GetAllEmployees();


        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Employess employees = new Employess();
            employees.FirstName = textBoxName.Text;
            employees.LastName = textBoxLastName.Text;
            employees.Email = textBoxEmail.Text;
            employees.PhoneNumber = textBoxPhone.Text;
            employees.Address = textBoxAddress.Text;
            employees.Description = textBoxDescription.Text;
            employees.CreateDate = DateTime.Now;
            employees.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            var result = employeeManagement.AddEmployee(employees);
            dataGridViewAllEmployees.DataSource = employeeManagement.GetAllEmployees();
            MessageBox.Show(result);

        }
    }
}
