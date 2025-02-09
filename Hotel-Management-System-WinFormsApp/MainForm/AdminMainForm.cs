using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_WinFormsApp
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }



        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to exit?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void logout_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void dashbord_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = false;
            admin_adduser1.Visible = false;

            admin_dashboard admin_Dashboard = admin_dashboard1 as admin_dashboard;
            if (admin_Dashboard != null)
            {
                admin_Dashboard.refreshData();
            }
        }

        private void adduser_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = false;
            admin_adduser1.Visible = true;

            admin_adduser admin_Adduser = admin_adduser1 as admin_adduser;
            if (admin_Adduser != null)
            {
                admin_Adduser.refreshData();
            }
        }

        private void rooms_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = false;
            admin_rooms1.Visible = true;
            admin_adduser1.Visible = false;

            admin_rooms admin_Rooms = admin_rooms1 as admin_rooms;
            if (admin_Rooms != null)
            {
                admin_Rooms.refreshData();
            }
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = true;
            admin_rooms1.Visible = false;
            admin_adduser1.Visible = false;

            admin_customers admin_Customers= admin_customers1 as admin_customers;
            if (admin_Customers != null)
            {
                admin_Customers.refreshData();
            }
        }
    }
}
