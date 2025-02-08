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
    public partial class admin_adduser : UserControl
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        public admin_adduser()
        {
            InitializeComponent();
            dispayData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            { 
                Invoke((MethodInvoker)refreshData);
                return;
            }
            dispayData();
        }

        public void dispayData()
        {
            usersData usersData = new usersData();
            dataGridView1.DataSource = usersData.listuserData();
        }
        public void clearFields()
        {
            addUser_username.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedItem = -1;
            addUser_status.SelectedItem = -1;
        }

        public void displayData()
        {
            usersData usersData = new usersData();
            dataGridView1.DataSource = usersData.listuserData();
        }

        private int getId;

        private void gridDataView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            { 
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;
                addUser_username.Text = row.Cells[1].Value.ToString();
                addUser_password.Text = row.Cells[2].Value.ToString();
                addUser_role.Text = row.Cells[3].Value.ToString();
                addUser_status.Text = row.Cells[4].Value.ToString();

            }
        }

        private void addUser_addButton_Click(object sender, EventArgs e)
        {
            if (addUser_username.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string checkUsername = "SELECT * FROM users WHERE username = @user";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@user", addUser_username.Text.Trim());

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(checkUser);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            string tempUser = addUser_username.Text.Substring(0, 1).ToUpper() + addUser_username.Text.Substring(1);
                            MessageBox.Show($"{tempUser} existing already!.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (addUser_password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users(username, password, role, status, register_date) VALUES (@user, @password, @role, @status, @date)";

                            using (SqlCommand command = new SqlCommand(insertData, connect))
                            {
                                command.Parameters.AddWithValue("@user", addUser_username.Text.Trim());
                                command.Parameters.AddWithValue("@password", addUser_password.Text.Trim());
                                command.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                                command.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());
                                DateTime today = DateTime.Today;
                                command.Parameters.AddWithValue("@date", today);
                                command.ExecuteNonQuery();
                                clearFields();
                                displayData();
                                MessageBox.Show("User added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                        }
                    }
                }
            }
        }
        

        private void addUser_clearButton_Click(object sender, EventArgs e)
        {
            addUser_username.Text = "";
            addUser_password.Text = "";
            addUser_role.SelectedIndex = -1;
            addUser_status.SelectedIndex = -1;
        }
        //Update
        private void addUser_updateButton_Click(object sender, EventArgs e)
        {

            if (addUser_username.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to update ID {getId} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string updateData = "UPDATE users SET password = @password, role = @role, status = @status WHERE username = @user";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@user", addUser_username.Text.Trim());
                            command.Parameters.AddWithValue("@password", addUser_password.Text.Trim());
                            command.Parameters.AddWithValue("@role", addUser_role.SelectedItem.ToString());
                            command.Parameters.AddWithValue("@status", addUser_status.SelectedItem.ToString());

                            command.ExecuteNonQuery();
                            displayData();
                            clearFields();
                            MessageBox.Show("Update successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void addUser_deleteButton_Click(object sender, EventArgs e)
        {
            if (addUser_username.Text == "" || addUser_password.Text == "" || addUser_role.SelectedIndex == -1 || addUser_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to Delete ID {getId} ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string updateData = "DELETE FROM users WHERE username = @user";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@user", addUser_username.Text.Trim());
                            command.ExecuteNonQuery();
                            displayData();

                            MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
    }
}
