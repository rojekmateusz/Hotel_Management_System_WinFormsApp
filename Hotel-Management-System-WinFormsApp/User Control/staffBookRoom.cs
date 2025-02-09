using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System_WinFormsApp
{
    public partial class staffBookRoom : UserControl
    {
        public staffBookRoom()
        {
            InitializeComponent();
            displayRooms();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayRooms();
        }

        public void displayRooms()
        {
            roomsData roomsData = new roomsData();
            dataGridView1.DataSource = roomsData.roomsDataList();
        }

        private int getId;
        decimal price = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getId = (int)row.Cells[0].Value;
                staffBook_roomID.Text = row.Cells[1].Value.ToString();
                staffBook_type.Text = row.Cells[2].Value.ToString();
                staffBook_name.Text = row.Cells[3].Value.ToString();
                price = Convert.ToDecimal(row.Cells[4].Value);
                staffBook_status.Text = row.Cells[5].Value.ToString();
                staffBook_regularPrice.Text = row.Cells[4].Value.ToString();
            }
                
        }

        private void staffBook_scheduleButton_Click(object sender, EventArgs e)
        {
            DateTime fromDate = staffBook_from.Value;
            DateTime toDate = staffBook_to.Value;   

            TimeSpan countDays = toDate - fromDate;

            int days = countDays.Days;
            decimal regtotal = price * days;

            if (regtotal <= 0)
            {
                MessageBox.Show("Something goes wrong!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                staffBook_total.Text = "0.00";

            }
            else
            {
                staffBook_total.Text = regtotal.ToString();
            }
        }

        private void staffBook_bookButton_Click(object sender, EventArgs e)
        {
            if (staffBook_status.Text != "Availabel")
            {
                MessageBox.Show("Room is unavailabel!", "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hotelData.roomID = staffBook_roomID.Text;
                hotelData.fromDate = staffBook_from.Value;
                hotelData.toDate = staffBook_to.Value;
                hotelData.price = staffBook_total.Text;

                Form form = new Form();

                try
                {
                    using (clientInfo ciform = new clientInfo())
                    {
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormBorderStyle = FormBorderStyle.None;
                        form.Opacity = .80d;
                        form.WindowState = FormWindowState.Maximized;
                        form.BackColor = Color.Black;
                        form.TopMost = true;
                        form.Location = this.Location;
                        form.ShowInTaskbar = false;
                        form.Show();

                        ciform.Owner = form;
                        ciform.ShowDialog();

                        form.Dispose();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Message" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    form.Dispose();
                }   
            }
            
        }

        private void staffBook_clearButton_Click(object sender, EventArgs e)
        {
            staffBook_roomID.Text = "---------------";
            staffBook_type.Text = "---------------";
            staffBook_name.Text = "---------------";
            staffBook_status.Text = "---------------";
            staffBook_regularPrice.Text = "---------------";
            staffBook_total.Text = "0.00";

        }
    }
}
