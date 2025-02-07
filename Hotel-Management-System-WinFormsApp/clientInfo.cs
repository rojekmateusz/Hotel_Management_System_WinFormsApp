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
    public partial class clientInfo : Form
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        public clientInfo()
        {
            InitializeComponent();
            displayBookId();
        }

        private void label2_Click(object sender, EventArgs e)
        {

            this.Hide();
        }
        public void displayBookId()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectBookID = "SELECT COUNT(id) FROM customer";
                int BookID = 0;

                using (SqlCommand cmd = new SqlCommand(selectBookID, conn))
                {
                    BookID = Convert.ToInt32(cmd.ExecuteScalar());

                    if (Convert.ToInt32(BookID) == 0)
                    {
                        BookID += 1;
                    }
                    else
                    {
                        BookID += 1;
                    }
                }

                clientInfo_bookID.Text = $"Book ID - {BookID}";
            }
        }
        private void staffBook_clearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to book now?", "Confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clientInfo_fullname.Text == "" || clientInfo_email.Text == "" || clientInfo_contact.Text == "" || clientInfo_gender.SelectedIndex == -1
                   || clientInfo_address.Text == "" || hotelData.roomID == "")
                {
                    MessageBox.Show("Please fill all blank fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        string insertData = "INSERT INTO customer (book_id, full_name, email, contact, gender, address, room_id, price, status_payment, status, date_from, date_to, date_book)"
                            + "VALUES (@bookid, @fullname, @email, @contact, @gender, @address, @roomid, @price, @status_payment, @status, @date_from, @date_to, @date_book)";

                        using (SqlCommand cmd = new SqlCommand(insertData, conn))
                        {
                            cmd.Parameters.AddWithValue("@bookid", clientInfo_bookID.Text);
                            cmd.Parameters.AddWithValue("@fullname", clientInfo_fullname.Text);
                            cmd.Parameters.AddWithValue("@email", clientInfo_email.Text);
                            cmd.Parameters.AddWithValue("@contact", clientInfo_contact.Text);
                            cmd.Parameters.AddWithValue("@gender", clientInfo_gender.SelectedItem.ToString());
                            cmd.Parameters.AddWithValue("@address", clientInfo_address.Text);
                            cmd.Parameters.AddWithValue("@roomid", hotelData.roomID);
                            cmd.Parameters.AddWithValue("@price", hotelData.price);
                            cmd.Parameters.AddWithValue("@status_payment", "Paid");
                            cmd.Parameters.AddWithValue("@status", "Checked In");
                            cmd.Parameters.AddWithValue("@date_from", hotelData.fromDate);
                            cmd.Parameters.AddWithValue("@date_to", hotelData.toDate);
                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date_book", today.ToString());
                            cmd.ExecuteNonQuery();
                            updateRoomStatus();
                            MessageBox.Show("Booked successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                        }
                    }
                }
            }

        }

        public void updateRoomStatus()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string updateStatus = "UPDATE rooms SET status = @status WHERE room_id = @roomid";

                using (SqlCommand cmd = new SqlCommand(updateStatus, conn))
                {
                    cmd.Parameters.AddWithValue("@status", "Unavaialbe");
                    cmd.Parameters.AddWithValue("@roomid", hotelData.roomID);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        private void clientInfo_clearButton_Click(object sender, EventArgs e)
        {
            clientInfo_bookID.Text = "------------";
            clientInfo_fullname.Text = "";
            clientInfo_email.Text = "";
            clientInfo_contact.Text = "";
            clientInfo_gender.SelectedIndex = -1;
            clientInfo_address.Text = "";

        }
    }
}
