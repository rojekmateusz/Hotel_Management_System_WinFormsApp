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

    public partial class AdminMainForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;Integrated Security=True;Connect Timeout=30";

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


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectData = "SELECT * FROM users WHERE status = @status";

                using (SqlCommand command = new SqlCommand(selectData, connection))
                {
                    command.Parameters.AddWithValue("@status", "Active");

                    string changeStatus = "UPDATE users SET status = @status";
                    using (SqlCommand cmd = new SqlCommand(changeStatus, connection))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        cmd.ExecuteNonQuery();
                    }
                }
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
