﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
       
        string connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;
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

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
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
                                displayRoomData();
                                clearFields();
                                MessageBox.Show(rooms_room_id.Text.Trim() + " is successfully added!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                }
            }
        }

        private void rooms_update_button_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Erros Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string dataUpdate = "UPDATE rooms SET room_id = @roomid, type = @type, room_name = @name, price = @price, status = @status, update_date = @update WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(dataUpdate, conn))
                    {
                        cmd.Parameters.AddWithValue("@roomid", rooms_room_id.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@name", rooms_name.Text.Trim());
                        cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());
                        DateTime dateTime = DateTime.Today;
                        cmd.Parameters.AddWithValue("@update", dateTime);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();  
                        displayRoomData();
                        clearFields();

                        MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        
            clearFields();
        }
        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_room_id.Text = row.Cells[1].Value.ToString();
                rooms_type.Text = row.Cells[2].Value.ToString();
                rooms_name.Text = row.Cells[3].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();
                rooms_status.Text = row.Cells[5].Value.ToString();

            }
        }

        public void clearFields()
        {
            rooms_room_id.Text = "";
            rooms_type.SelectedIndex = -1;
            rooms_name.Text = "";
            rooms_price.Text = "";
            rooms_status.SelectedIndex = -1;


        }
        private void rooms_clear_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void rooms_delete_button_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Erros Meesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string dataUpdate = "UPDATE rooms SET delete_date = @delete WHERE id = @id";

                    using (SqlCommand cmd = new SqlCommand(dataUpdate, conn))
                    {
                      
                        DateTime dateTime = DateTime.Today;
                        cmd.Parameters.AddWithValue("@delete", dateTime);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                        displayRoomData();
                        clearFields();

                        MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }

            clearFields();
        }

       
    }
}
