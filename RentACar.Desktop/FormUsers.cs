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
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }
        UsersManagment usersManagment = new UsersManagment();

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
           Users users = new Users();
            users.UserName = textBoxUserName.Text;
            users.UserPassword = textBoxPassword.Text;
            users.UserEmail = textBoxEmail.Text;
            users.UserPhone = textBoxPhone.Text;
            users.Description = textBoxDescription.Text;
            users.IsActive = true;
            users.Id = 0;
            users.UserRole = "User"; // TODO: Set the actual user role based on your application logic
            users.UserId = 0; // TODO: Set the actual user ID based on your application logic
            users.UpdateDate = DateTime.Now;
            users.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user

            users.CreateDate = DateTime.Now;
            users.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user
            var result = usersManagment.AddUser(users);
            dataGridViewAllEmployees.DataSource = usersManagment.GetAllUsers();
            MessageBox.Show(result);




        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewAllEmployees.DataSource = usersManagment.GetAllUsers();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.UserId = Convert.ToInt32(textBoxUserName.Tag);
            users.UserName = textBoxUserName.Text;
            users.UserPassword = textBoxPassword.Text;
            users.UpdateDate = DateTime.Now;
            users.UpdatorId = 1; // TODO: Get the actual updator ID from the logged-in user
            users.UserEmail = textBoxEmail.Text;
            users.UserPhone = textBoxPhone.Text;
            users.Description = textBoxDescription.Text;
            users.IsActive = true;
            users.UserRole = "User"; // TODO: Set the actual user role based on your application logic
            users.CreateDate = DateTime.Now;
            users.CreatorId = 1; // TODO: Get the actual creator ID from the logged-in user

            dataGridViewAllEmployees.DataSource = usersManagment.GetAllUsers();
            

        }

        private void dataGridViewAllEmployees_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserName.Text = dataGridViewAllEmployees.CurrentRow.Cells[1].Value.ToString();
            textBoxPassword.Text = dataGridViewAllEmployees.CurrentRow.Cells[2].Value.ToString();
            textBoxUserName.Tag = dataGridViewAllEmployees.CurrentRow.Cells[0].Value.ToString();
            textBoxDescription.Text = dataGridViewAllEmployees.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewAllEmployees.CurrentRow.Cells[4].Value.ToString();
            textBoxPhone.Text = dataGridViewAllEmployees.CurrentRow.Cells[5].Value.ToString();

        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAllEmployees.CurrentRow.Cells[0].Value);
            usersManagment.DeleteUser(id);
            dataGridViewAllEmployees.DataSource = usersManagment.GetAllUsers();
            MessageBox.Show("Kayıt Silindi");

        }
    }
}
