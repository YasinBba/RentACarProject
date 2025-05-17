using RentACar.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net.Http;
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

                /*
                1- Session => Server tarafında saklanır.
                2-Cookie=> Client tarafında saklanır.
                3- JWT (Json Web Token)=> Client tarafında saklanır.
                 
                 */
                if (login!=null)
                {
                    FormMenu formMenu = new FormMenu();
                    formMenu.labelLoginName.Text = login.UserName;
                    formMenu.UserRole = login.UserRole;

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
