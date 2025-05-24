using RentACar.BLL;
using RentACar.DLLModel.Model;
using System;
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
            dataGridViewAllUsers.DataSource = usersManagment.GetAllUsers();
            MessageBox.Show(result);




        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            dataGridViewAllUsers.DataSource = usersManagment.GetAllUsers();
        }

        private void toolStripButtonUpdate_Click(object sender, EventArgs e)
        {
            
           
            Users users = new Users();
            users.Id = Convert.ToInt32(dataGridViewAllUsers.CurrentRow.Cells[0].Value);

            users.UserName = textBoxUserName.Text;
            users.UserPassword = textBoxPassword.Text;
            users.UpdateDate = DateTime.Now;
            users.UpdatorId = 1;
            users.UserEmail = textBoxEmail.Text;
            users.UserPhone = textBoxPhone.Text;
            users.Description = textBoxDescription.Text;
            users.IsActive = true;
            users.UserRole = textBoxRole.Text; 

            var result = usersManagment.UpdateUser(users);
            dataGridViewAllUsers.DataSource = usersManagment.GetAllUsers();
            MessageBox.Show(result);






        }

        private void dataGridViewAllEmployees_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxUserName.Text = dataGridViewAllUsers.CurrentRow.Cells["UserName"].Value?.ToString() ?? "";
            textBoxPassword.Text = dataGridViewAllUsers.CurrentRow.Cells["UserPassword"].Value?.ToString() ?? "";
            textBoxEmail.Text = dataGridViewAllUsers.CurrentRow.Cells["UserEmail"].Value?.ToString() ?? "";
            textBoxPhone.Text = dataGridViewAllUsers.CurrentRow.Cells["UserPhone"].Value?.ToString() ?? "";
            textBoxDescription.Text = dataGridViewAllUsers.CurrentRow.Cells["Description"].Value?.ToString() ?? "";

        }






        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridViewAllUsers.CurrentRow.Cells[0].Value);
            usersManagment.DeleteUser(id);
            dataGridViewAllUsers.DataSource = usersManagment.GetAllUsers();
            MessageBox.Show("Kayıt Silindi");

        }
    }
}
