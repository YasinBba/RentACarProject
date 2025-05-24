using RentACar.Desktop.Enums;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        public string UserRole;
        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCars formCars = new FormCars();
            formCars.MdiParent = this;
            formCars.Show();
        }

        private void toolStripMenuItemCustomers_Click(object sender, EventArgs e)
        {
            FormCustomers formCustomers = new FormCustomers();
            formCustomers.MdiParent = this;
            formCustomers.Show();
        }

        private void ToolStripMenuItemRentalCars_Click(object sender, EventArgs e)
        {
            FormRentalCars formRentalCar = new FormRentalCars();
            formRentalCar.MdiParent = this;
            formRentalCar.Show();
        }

        private void employeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployees formEmployees = new FormEmployees();
            formEmployees.MdiParent = this;
            formEmployees.Show();
        }



       

        private void brokenCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBrokenCars formBrokenCars = new FormBrokenCars();
            formBrokenCars.MdiParent = this;
            formBrokenCars.Show();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers formUsers = new FormUsers();
            formUsers.MdiParent = this;
            formUsers.Show();

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            //rulesToolStripMenuItem.Visible = false;
            //brokenCarsToolStripMenuItem.Visible = false;
            //arabalarToolStripMenuItemCars.Visible = false;
            //toolStripMenuItemCustomers.Visible = false;
            //ToolStripMenuItemRentalCars.Visible = false;



            if (UserRole == RuleEnum.IT.ToString())
            {

            }
            else if (UserRole == RuleEnum.Developer.ToString())
            {

            }
            else if (UserRole == RuleEnum.admin.ToString())
            {

            }
            else if (UserRole == RuleEnum.usertest.ToString())
            {

            }
            else if (UserRole == RuleEnum.Manager.ToString())
            {
            }
        }
    }
}
