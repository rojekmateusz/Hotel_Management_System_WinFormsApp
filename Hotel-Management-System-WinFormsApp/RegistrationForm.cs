using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management_System_WinFormsApp
{
    public partial class RegistrationForm : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;Integrated Security=True;Connect Timeout=30";
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void register_SignIn_Button_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

            this.Hide();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_Password.PasswordChar = register_ShowPassword.Checked ? '\0' : '*';
            register_ConfirmPassword.PasswordChar = register_ShowPassword.Checked ? '\0' : '*';
        }

        private void register_SignUp_Click(object sender, EventArgs e)
        {
            if (register_UserName.Text == "" || register_Password.Text == "" || register_ConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill all blank fields!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string checkUsername = "SELECT username FROM users WHERE username = @user";

                    using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                    {
                        checkUser.Parameters.AddWithValue("@user", register_UserName.Text.Trim());
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(checkUser);
                        DataTable datatable = new DataTable();
                        dataAdapter.Fill(datatable);

                        if (datatable.Rows.Count != 0)
                        {
                            string tempUsername = register_UserName.Text.Substring(0, 1).ToUpper() + register_UserName.Text.Substring(1);
                            MessageBox.Show($"{tempUsername} is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (register_Password.Text.Length < 8)
                        {
                            MessageBox.Show("Invalid password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (register_Password.Text != register_ConfirmPassword.Text)
                        {
                            MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string sqlQuery = "INSERT INTO users (username, password, role, status, register_date)" +
                                "VALUES(@user, @pass, @role, @status, @regDate)";

                            using (SqlCommand command = new SqlCommand(sqlQuery, connect))
                            {
                                command.Parameters.AddWithValue("@user", register_UserName.Text.Trim());
                                command.Parameters.AddWithValue("@pass", register_Password.Text.Trim());
                                command.Parameters.AddWithValue("@role","Staff");
                                command.Parameters.AddWithValue("@status", "Active");
                                DateTime totay = DateTime.Now;
                                command.Parameters.AddWithValue("@regDate", totay);
                                command.ExecuteNonQuery();

                                MessageBox.Show("Registred successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                Form1 loginForm = new Form1();
                                loginForm.Show();

                                this.Hide();

                            }
                        }


                    }
                }
            }
        }
    }
}
