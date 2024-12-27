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
using System.Windows.Forms.VisualStyles;

namespace LTMCB_Final
{
    public partial class SelectSeat : Form
    {
        private string cinemaName;
        private DateTime selectedDate;
        private string selectedTime;
        private Dictionary<string, (bool isBooked, decimal price)> seatData;
        private List<string> selectedSeats = new List<string>();

        public SelectSeat(string cinemaName, DateTime selectedDate, string selectedTime)
        {
            InitializeComponent();
            this.cinemaName = cinemaName;
            this.selectedDate = selectedDate;
            this.selectedTime = selectedTime;

            // Lấy dữ liệu ghế từ database
            seatData = GetSeatsFromDatabase();

            // Tạo giao diện ghế
            GenerateSeats();
            UpdateTotalPrice();
        }

        private Dictionary<string, (bool isBooked, decimal price)> GetSeatsFromDatabase()
        {
            string connectionString = " ";
            var seatData = new Dictionary<string, (bool isBooked, decimal price)>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SeatID, IsBooked, Price FROM Seats";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string seatID = reader["SeatID"].ToString();
                    bool isBooked = (bool)reader["IsBooked"];
                    decimal price = (decimal)reader["Price"];
                    seatData[seatID] = (isBooked, price);
                }

                reader.Close();
            }

            return seatData;
        }

        // Tạo giao diện ghế
        private void GenerateSeats()
        {
            groupBox1.Controls.Clear();

            int x = 10, y = 10;
            int buttonWidth = 60, buttonHeight = 60;
            int padding = 10;

            foreach (var seat in seatData)
            {
                string seatName = seat.Key;
                bool isBooked = seat.Value.isBooked;
                decimal price = seat.Value.price;

                Button seatButton = new Button
                {
                    Name = $"btn{seatName}",
                    Text = $"{seatName}\n{price:N0}₫",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    BackColor = isBooked ? Color.Red : Color.Green,
                    Enabled = !isBooked,
                    Tag = seatName
                };

                seatButton.Click += SeatButton_Click;
                groupBox1.Controls.Add(seatButton);
                seatButton.Location = new Point(x, y);

                x += buttonWidth + padding;
                if (x + buttonWidth > groupBox1.Width)
                {
                    x = 10;
                    y += buttonHeight + padding;
                }
            }
        }

        // Sự kiện khi nhấn vào ghế
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            string seatName = seatButton.Tag.ToString();

            if (selectedSeats.Contains(seatName))
            {
                // Bỏ chọn ghế
                selectedSeats.Remove(seatName);
                seatButton.BackColor = Color.Green;
            }
            else
            {
                // Chọn ghế
                selectedSeats.Add(seatName);
                seatButton.BackColor = Color.Yellow;
            }

            UpdateTotalPrice();
        }

        // Cập nhật tổng tiền
        private void UpdateTotalPrice()
        {
            decimal totalPrice = selectedSeats.Sum(seat => seatData[seat].price);
            label2.Text = $"Tổng tiền: {totalPrice:N0}₫";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo");
                return;
            }

            MessageBox.Show($"Bạn đã chọn các ghế: {string.Join(", ", selectedSeats)}", "Xác nhận");
            // Thực hiện chuyển đến trang thanh toán
        }
    }
}
