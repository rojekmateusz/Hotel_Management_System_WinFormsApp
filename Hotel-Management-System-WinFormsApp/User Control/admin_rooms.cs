using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_WinFormsApp
{
    public partial class admin_rooms : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        public bool isEmpty()
        {
            if (string.IsNullOrEmpty(rooms_room_id.Text) || string.IsNullOrEmpty(rooms_name.Text) || rooms_type.SelectedIndex == -1 || rooms_status.SelectedIndex == -1
                || string.IsNullOrEmpty(rooms_price.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public admin_rooms()
        {
            InitializeComponent();
            displayRoomData();
        }

        public void displayRoomData()
        {
            roomsData roomsData = new roomsData();
            dataGridView1.DataSource = roomsData.roomsDataList();

        }
        private void rooms_add_button_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string checkRoomId = "SELECT room_id FROM rooms WHERE room_id = @roomid";

                    using (SqlCommand command = new SqlCommand(checkRoomId, connect))
                    {
                        command.Parameters.AddWithValue("@roomid", rooms_room_id.Text.Trim());

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            MessageBox.Show(rooms_room_id.Text.Trim() + "is existing already", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string InsertData = "INSERT INTO rooms (room_id, type, room_name, price, status, register_date)" +
                                "VALUES(@roomid, @type, @room_name, @price, @status, @register_date)";

                            using (SqlCommand cmd = new SqlCommand(InsertData, connect))    
                            {
                                cmd.Parameters.AddWithValue("@roomid", rooms_room_id.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@room_name", rooms_name.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@register_date", today);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show(rooms_room_id.Text.Trim() + " is successfully added!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }    
                        }
                    }

                }   
            }
        }
    }
}
