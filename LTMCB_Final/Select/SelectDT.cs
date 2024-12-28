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
using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;

namespace LTMCB_Final
{
    public partial class SelectDT : Form
    {
        private string cinemaName;
        private ClientTcpConnection tcp = Program.tcpConnection;
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
            comboBox1.SelectedIndex = 0;
        }

        // Tải thông tin phim
        private void LoadMovies()
        {
            flowLayoutPanel1.Controls.Clear();

            string selectedDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string selectedTime = comboBox1.SelectedItem.ToString();

            try
            {
                string query = $@"
                    SELECT 
                    FROM 
                    WHERE ";

                string response = tcp.SendAndRevceiveStr(query);
                JArray movies = JArray.Parse(response);

                foreach (var movie in movies)
                {
                    GroupBox movieGroup = new GroupBox
                    {
                        Width = flowLayoutPanel1.Width - 20,
                        Height = 150,
                        Text = movie[" "].ToString()
                    };

                    PictureBox poster = new PictureBox
                    {
                        ImageLocation = movie[" "].ToString(),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Width = 100,
                        Height = 120,
                        Location = new Point(10, 20)
                    };

                    Label details = new Label
                    {
                        Text = $"Thời lượng: {movie["Duration"]} phút\n" +
                               $"Giờ chiếu: {movie["ShowTime"]}\n" +
                               $"{movie["Description"]}",
                        Location = new Point(120, 20),
                        AutoSize = true
                    };

                    movieGroup.Controls.Add(poster);
                    movieGroup.Controls.Add(details);
                    flowLayoutPanel1.Controls.Add(movieGroup);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phim: " + ex.Message, "Lỗi");
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
