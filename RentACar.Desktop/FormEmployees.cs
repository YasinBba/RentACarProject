using RentACar.BLL;
using RentACar.DLLModel.Model;
using System;
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
            employees.IsActive = "True";
            employees.DateOfBirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");

            var result = employeeManagement.AddEmployee(employees);
            dataGridViewAllEmployees.DataSource = employeeManagement.GetAllEmployees();
            MessageBox.Show(result);

        }

        private void dataGridViewAllEmployees_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxName.Text = dataGridViewAllEmployees.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewAllEmployees.CurrentRow.Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridViewAllEmployees.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewAllEmployees.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewAllEmployees.CurrentRow.Cells[5].Value.ToString();
            textBoxDescription.Text = dataGridViewAllEmployees.CurrentRow.Cells[6].Value.ToString();

        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            EmployeeManagment employeeManagement = new EmployeeManagment();
            Employess employees = new Employess();
            employees.Id = Convert.ToInt32(dataGridViewAllEmployees.CurrentRow.Cells[0].Value);
            employees.FirstName = textBoxName.Text;
            employees.LastName = textBoxLastName.Text;
            employees.Email = textBoxEmail.Text;
            employees.PhoneNumber = textBoxPhone.Text;
            employees.Address = textBoxAddress.Text;
            employees.Description = textBoxDescription.Text;
            employees.UpdateDate = DateTime.Now;
            employees.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
           
            employeeManagement.UpdateEmployee(employees);
            dataGridViewAllEmployees.DataSource = employeeManagement.GetAllEmployees();
            


        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            EmployeeManagment employeeManagement = new EmployeeManagment();
            Employess employees = new Employess();
            employees.Id = Convert.ToInt32(dataGridViewAllEmployees.CurrentRow.Cells[0].Value);
            employeeManagement.DeleteEmployee(employees.Id);
            dataGridViewAllEmployees.DataSource = employeeManagement.GetAllEmployees();

        }

        private void toolStripButtonClean_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxLastName.Clear();
            textBoxEmail.Clear();
            textBoxPhone.Clear();
            textBoxAddress.Clear();
            textBoxDescription.Clear();
            dateTimePicker1.Value = DateTime.Now;

        }
    }
}
