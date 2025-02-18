using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;


namespace Hotel_Management_System_WinFormsApp
{
    internal class usersData
    {
        
        string connectionString = ConfigurationManager.ConnectionStrings["HotelDb"].ConnectionString;
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DateReg { get; set; }
        
        public string Notepad { get; set; }
        public List<usersData> listuserData()
        {
            List<usersData> usersList = new List<usersData>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            { 
                connect.Open();
                string selectData = "SELECT * FROM users";

                using (SqlCommand command = new SqlCommand(selectData, connect))
                {
                    SqlDataReader sqlDataReader = command.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        usersData userData = new usersData();

                        userData.ID = (int)sqlDataReader["id"];
                        userData.Username = sqlDataReader["username"].ToString();
                        userData.Password = sqlDataReader["password"].ToString();
                        userData.Role = sqlDataReader["role"].ToString();
                        userData.Status = sqlDataReader["status"].ToString();
                        userData.DateReg = sqlDataReader["register_date"].ToString();
                        

                        usersList.Add(userData);
                    }
                }
            }
            return usersList;
        }

    }
}
