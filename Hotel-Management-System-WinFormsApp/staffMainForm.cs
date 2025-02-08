using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Hotel_Management_System_WinFormsApp
{
    public partial class staffMainForm : Form
    {
        public staffMainForm()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure you want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure You want to exit?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dashbord_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = true;
            admin_customers1.Visible = false;
            staffBookRoom1.Visible = false;
           

            admin_dashboard admin_Dashboard = admin_dashboard1 as admin_dashboard;
            if (admin_Dashboard != null)
            {
                admin_Dashboard.refreshData();
            }
        }

        private void bookroom_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = false;
            staffBookRoom1.Visible = true;
            
            staffBookRoom staff_bookRoom = staffBookRoom1 as staffBookRoom;
            if (staff_bookRoom != null)
            {
                staff_bookRoom.refreshData();
            }
        }

        private void customer_button_Click(object sender, EventArgs e)
        {
            admin_dashboard1.Visible = false;
            admin_customers1.Visible = true;
            staffBookRoom1.Visible = false;

            admin_customers admin_Customers = admin_customers1 as admin_customers;
            if (admin_Customers != null)
            {
                admin_Customers.refreshData();
            }
        }
    }
}
