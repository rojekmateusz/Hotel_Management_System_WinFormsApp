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
using Newtonsoft.Json.Linq;
using System.Net.Http;

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
            displayOccupiedRooms();

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
            displayOccupiedRooms();


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

        public void displayOccupiedRooms()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string selectData = "SELECT COUNT(id) FROM rooms WHERE status = 'Occupied'";
                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        occupiedRooms.Text = result.ToString();
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

        private const string ApiKey = "55a7419153d4bbc903354440d0f233ff"; // Klucz API z weatherstack.com
        private const string BaseUrl = "http://api.weatherstack.com/current";
        private async void buttonGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            if (string.IsNullOrEmpty(city))
            {
                MessageBox.Show("Wprowadź nazwę miasta.");
                return;
            }

            string url = $"{BaseUrl}?access_key={ApiKey}&query={city}"; // Tworzenie URL zapytania

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(url);
                    JObject data = JObject.Parse(response);

                    // Przetwarzanie danych pogodowych
                    string temperature = data["current"]["temperature"].ToString();
                    string weatherDescription = data["current"]["weather_descriptions"][0].ToString();
                    string humidity = data["current"]["humidity"].ToString();
                    string windSpeed = data["current"]["wind_speed"].ToString();
                    string iconUrl = data["current"]["weather_icons"][0].ToString(); // Pobierz URL ikony

                    // Wyświetlanie danych
                    lblDescription.Text = $"{weatherDescription}";
                    lblTemperature.Text = $"{temperature} °C";
                    lblHumidity.Text = $"{humidity}%";
                    lblWindSpeed.Text = $"{windSpeed} km/h";

                    // Ładowanie ikony pogody
                    pictureBoxWeather.Load(iconUrl); // Załaduj ikonę do PictureBox
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Błąd podczas pobierania danych pogodowych: " + ex.Message);
                }
            }
        }


        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void adduser_button_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_saveButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            { 
                connection.Open();
                string selectData = "SELECT * FROM users WHERE ";
            }
        }
    }
}
