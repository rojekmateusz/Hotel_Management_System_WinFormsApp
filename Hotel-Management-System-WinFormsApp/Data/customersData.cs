using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Net;
using System.Configuration;

namespace Hotel_Management_System_WinFormsApp
{

    internal class customersData
    {
       
        string connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;
        public int ID { get; set; }
        public string BookID { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string RoomId { get; set; }
        public string Price { get; set; }
        public string Status_Payment { get; set; }
        public string Status { get; set; }
        public  string Date_from { get; set; }
        public  string Date_to { get; set; }
        public  string Date_Book { get; set; }

        public List<customersData> customersListData()
        { 
            List<customersData> ListData = new List<customersData>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            { 
                conn.Open();
                string selectData = "SELECT * FROM customer";
                
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        customersData customData = new customersData();

                        customData.ID = (int)reader["id"];
                        customData.BookID = reader["book_id"].ToString();
                        customData.Fullname = reader["full_name"].ToString();
                        customData.Email = reader["email"].ToString();
                        customData.Contact = reader["contact"].ToString();
                        customData.Gender = reader["gender"].ToString();
                        customData.Address = reader["address"].ToString();
                        customData.RoomId = reader["room_id"].ToString();
                        customData.Price = reader["price"].ToString();
                        customData.Status_Payment = reader["status_payment"].ToString();
                        customData.Status = reader["status"].ToString();
                        customData.Date_from = reader["date_from"].ToString();
                        customData.Date_to = reader["date_to"].ToString();
                        customData.Date_Book = reader["date_book"].ToString();
                        ListData.Add(customData);
                    }

                }
            }
            return ListData;
        }
    }
}
