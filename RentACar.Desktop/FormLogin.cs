using RentACar.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentACar.Desktop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        int hak = 3;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsersManagment usersManagment = new UsersManagment();
                string userName = textBox1.Text;
                string password = textBox2.Text;
                var login= usersManagment.Login(userName, password);
                if (login!=null)
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.labelLoginName.Text = login.UserName;
                    formMenu.Show();//Menu göster
                    this.Hide();//Login
                }

                else
                {
                    hak--;
                    MessageBox.Show("Invalid username or password.");
                }
                if (hak == 0)
                {
                   MessageBox.Show("Giriş hakkınız bittiği için sistemden atıldınız.");
                    this.Hide();

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
