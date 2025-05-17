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
    public partial class FormUserPassword : Form
    {
        public FormUserPassword()
        {
            InitializeComponent();
        }
        string username = "admin";
        string password = "admin";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == username && textBox2.Text == password)
            {
                FormUsers formUsers = new FormUsers();
                formUsers.MdiParent = this.MdiParent;
                formUsers.Show();
                this.Hide();


            }
            
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

        }
    }
}
