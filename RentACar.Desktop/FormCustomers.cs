using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentACar.BLL;
using RentACar.DLLModel.Model;

namespace RentACar.Desktop
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
        }
        CustomerManagement customerManagement = new CustomerManagement();

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            dataGridViewAllCustomers.DataSource = customerManagement.GetAllCustomers();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.FirstName = textBoxName.Text;
            customers.LastName = textBoxLastName.Text;

            customers.Email = textBoxEmail.Text;
            customers.PhoneNumber = textBoxPhone.Text;
            customers.Address = textBoxAddress.Text;
            customers.Description = textBoxDescription.Text;
            customers.CreateDate = DateTime.Now;
            customers.IsActive = true;
            customers.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            customers.DateOfBirth = dateTimePicker1.Value;
            var result = customerManagement.AddCustomer(customers);
            dataGridViewAllCustomers.DataSource = customerManagement.GetAllCustomers();
            MessageBox.Show(result);

        }



        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            Customers customers = new Customers();
            customers.Id = Convert.ToInt32(dataGridViewAllCustomers.CurrentRow.Cells[0].Value);
            customers.FirstName = textBoxName.Text;
            
            customers.Email = textBoxEmail.Text;
            customers.PhoneNumber = textBoxPhone.Text;
            customers.Address = textBoxAddress.Text;
            customers.Description = textBoxDescription.Text;
            customers.UpdateDate = DateTime.Now;
            customers.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            customers.DateOfBirth = dateTimePicker1.Value;

            // Fix: UpdateCustomer returns void, so remove the assignment to a variable
            customerManagement.UpdateCustomer(customers);

            dataGridViewAllCustomers.DataSource = customerManagement.GetAllCustomers();
        }

        private void dataGridViewAllCustomers_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            textBoxName.Text = dataGridViewAllCustomers.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridViewAllCustomers.CurrentRow.Cells[2].Value.ToString();
            textBoxEmail.Text = dataGridViewAllCustomers.CurrentRow.Cells[3].Value.ToString();
            textBoxPhone.Text = dataGridViewAllCustomers.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewAllCustomers.CurrentRow.Cells[5].Value.ToString();
            textBoxDescription.Text = dataGridViewAllCustomers.CurrentRow.Cells[6].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridViewAllCustomers.CurrentRow.Cells[7].Value);


        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAllCustomers.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz müşteriyi seçin.");
                return;
            }

            DialogResult confirm = MessageBox.Show("Bu müşteriyi silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dataGridViewAllCustomers.CurrentRow.Cells[0].Value);
                CustomerManagement customerManagement = new CustomerManagement();
                string result = customerManagement.DeleteCustomer(id);

                // Güncel veriyi al
                dataGridViewAllCustomers.DataSource = customerManagement.GetAllCustomers();

                MessageBox.Show(result);
            }

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
