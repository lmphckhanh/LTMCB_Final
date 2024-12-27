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

namespace LTMCB_Final
{
    public partial class SelectDT : Form
    {
        private string cinemaName;
        private string connectionString = " ";
        public SelectDT(string cinemaName)
        {
            InitializeComponent();
            this.cinemaName = cinemaName;

            label2.Text = $"Chọn phim tại {cinemaName}"; // Hiển thị rạp đang chọn
            LoadShowTimes();
            LoadMovies();
        }

        // Tải danh sách khung giờ
        private void LoadShowTimes()
        {
            comboBox1.Items.AddRange(new string[] { "10:00 AM", "12:00 PM", "03:00 PM", "06:00 PM", "09:00 PM" });
            comboBox1.SelectedIndex = 0; // Chọn khung giờ mặc định
        }

        // Tải thông tin phim
        private void LoadMovies()
        {
            flowLayoutPanel1.Controls.Clear(); // Xóa nội dung cũ

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedTime = comboBox1.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Poster, MovieName, Duration, ShowTime, Description " +
                               "FROM Movies " +
                               "WHERE CinemaName = @cinemaName AND ShowDate = @date AND ShowTime = @time";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cinemaName", cinemaName);
                    cmd.Parameters.AddWithValue("@date", selectedDate);
                    cmd.Parameters.AddWithValue("@time", selectedTime);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            GroupBox movieGroup = new GroupBox
                            {
                                Width = flowLayoutPanel1.Width - 20,
                                Height = 150,
                                Text = reader["MovieName"].ToString()
                            };

                            PictureBox poster = new PictureBox
                            {
                                ImageLocation = reader["Poster"].ToString(),
                                SizeMode = PictureBoxSizeMode.StretchImage,
                                Width = 100,
                                Height = 120,
                                Location = new Point(10, 20)
                            };

                            Label details = new Label
                            {
                                Text = $"Thời lượng: {reader["Duration"]} phút\n" +
                                       $"Giờ chiếu: {reader["ShowTime"]}\n" +
                                       $"{reader["Description"]}",
                                Location = new Point(120, 20),
                                AutoSize = true
                            };

                            movieGroup.Controls.Add(poster);
                            movieGroup.Controls.Add(details);
                            flowLayoutPanel1.Controls.Add(movieGroup);
                        }
                    }
                }
            }
        }

        // Sự kiện thay đổi ngày
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }

        // Sự kiện thay đổi giờ
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var selectCinemaForm = new SelectCinema();
            this.Hide();
            selectCinemaForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectSeatForm = new SelectSeat(cinemaName, dateTimePicker1.Value, comboBox1.SelectedItem.ToString());
            this.Hide();
            selectSeatForm.ShowDialog();
            this.Close();
        }
    }
}
