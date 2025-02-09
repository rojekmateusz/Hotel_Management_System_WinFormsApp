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
    public partial class admin_dashboard : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        public admin_dashboard()
        {
            InitializeComponent();
            displayTotalStaff();
            displayAvailabelRooms();
            displayTodaysProfit();
            displayTotalProfit();
            displayAllRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayTotalStaff();
            displayAvailabelRooms();
            displayTodaysProfit();
            displayTotalProfit();
            displayAllRooms();
        }

        public void displayAllRooms()
        { 
            roomsData roomsData = new roomsData();
            dataGridView1.DataSource = roomsData.roomsDataList();
        }
        public void displayTotalStaff()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                conn.Open();
                string selectData = "SELECT COUNT(id) FROM users WHERE role = 'Staff'";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    { 
                        totalStaff.Text = result.ToString();
                    }
                }
            }    
        }

        public void displayAvailabelRooms()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Availabel' OR status = 'Active'";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        availabelRooms.Text = result.ToString();
                    }
                }
            }
        }

        public void displayTodaysProfit()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT SUM(price) FROM customer WHERE date_book = @datebook";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@datebook", today);
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        todayProfit.Text = result.ToString();
                    }
                }
            }
        }

        public void displayTotalProfit()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT SUM(price) FROM customer";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalProfit.Text = result.ToString();
                    }
                }
            }
        }
    }
}
