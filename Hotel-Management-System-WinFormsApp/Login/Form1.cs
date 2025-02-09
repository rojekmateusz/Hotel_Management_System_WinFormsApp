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
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;Integrated Security=True;Connect Timeout=30";
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.Show();

            this.Hide();
        }

        private void login_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_ShowPassword.Checked ? '\0' : '*';
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (login_username.Text == "" || label_login_password.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users WHERE (username = @user AND password = @password) AND status = @status";

                    using (SqlCommand command = new SqlCommand(selectData, connect))
                    {
                        command.Parameters.AddWithValue("@user", login_username.Text.Trim());
                        command.Parameters.AddWithValue("@password", login_password.Text.Trim());
                        command.Parameters.AddWithValue("@status", "Active");

                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        if (dataTable.Rows.Count != 0)
                        {
                            MessageBox.Show("Login successfully!", "Information message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            string selectRole = "SELECT role FROM users WHERE username = @user AND password = @password";
                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@user", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@password", login_password.Text.Trim());

                                string userRole = getRole.ExecuteScalar() as string;

                                if (userRole == "Admin")
                                {
                                    AdminMainForm adminMainForm = new AdminMainForm();
                                    adminMainForm.Show();
                                    this.Hide();
                                }
                                else if (userRole == "Staff")
                                {
                                    staffMainForm staffMainForm = new staffMainForm();
                                    staffMainForm.Show();
                                    this.Hide();
                                }

                            }


                        }
                        else
                        {
                            MessageBox.Show("Incorrect username or password", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }
    }
}
