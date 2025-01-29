using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management_System_WinFormsApp
{
    internal class roomsData
    {
        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\rojek\\HotelManagmentSystem_Db.mdf;" +
            "Integrated Security=True;Connect Timeout=30";

        public int Id { get; set; }
        public string roomId { get; set; }
        public string roomType { get; set; }
        public string roomName { get; set; }
        public string price { get; set; }
        public string status { get; set; }
        public string date { get; set; }
        
        public List<roomsData> roomsDataList()
        {
            List<roomsData> listData = new List<roomsData>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT * FROM rooms WHERE delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    SqlDataReader DataReader = cmd.ExecuteReader();
                    while (DataReader.Read())
                    {
                        roomsData roomData = new roomsData();

                        roomData.Id = (int)DataReader["id"];
                        roomData.roomId = DataReader["room_id"].ToString();
                        roomData.roomType = DataReader["type"].ToString();
                        roomData.roomName = DataReader["room_name"].ToString();
                        roomData.price = DataReader["price"].ToString();
                        roomData.status = DataReader["status"].ToString();
                        roomData.date = DataReader["register_date"].ToString();

                        listData.Add(roomData);
                    }
                }
            }
            return listData;
        }
    }
}
