using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;


namespace LTMCB_Final
{
    public partial class ChonPhim : Form
    {


        ClientTcpConnection tcp = Program.tcpConnection;


        public ChonPhim()
        {
            InitializeComponent();
        }

        public List<Movie> movies;


        private void ChonPhim_Load(object sender, EventArgs e)
        {
            LoadMovies();
            LoadCategories();

        }
        private void LoadCategories()
        {
            try
            {
                // Truy vấn SQL lấy danh sách thể loại
                string query = @"QSELECT CategoryName FROM Category"; // Thay đổi với câu truy vấn thực tế
                string[] rs = tcp.SendAndRevceiveStr(query).Split("<*>"); // Tách dữ liệu từ phản hồi

                JObject[] jlist = new JObject[rs.Length - 1]; // Khởi tạo mảng JObject

                // Phân tích từng phần tử trong chuỗi kết quả
                for (int i = 0; i < rs.Length; i++)
                {
                    jlist[i] = JObject.Parse(rs[i]); // Phân tích chuỗi thành đối tượng JSON
                }

                // Duyệt qua các đối tượng JObject và thêm vào ComboBox
                foreach (var item in jlist)
                {
                    string categoryName = item.GetValue("CategoryName").ToString(); // Lấy tên thể loại
                    comboBox1.Items.Add(categoryName); // Thêm tên thể loại vào ComboBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message); // Hiển thị thông báo lỗi nếu có
            }
        }



        private void LoadMovies()
        {
            {
                try
                {
                    movies = new List<Movie>();

                    string query = @"QSELECT MovieID, Name, Image FROM Movie";
                    string[] rs = tcp.SendAndRevceiveStr(query).Split("<*>");
                    JObject[] jlist = new JObject[rs.Length - 1];
                    for (int i = 0; i < rs.Length; i++)
                    {
                        jlist[i] = JObject.Parse(rs[i]);
                    }
                    foreach (var item in jlist)
                    {
                        Movie mov = new Movie
                        {
                            ID = item.GetValue("MovieID").ToString(),
                            Name = item.GetValue("Name").ToString(),
                            Image = item.GetValue("Image").ToString()
                        };
                        movies.Add(mov);
                    }
                    DisplayMovies(); // Hiển thị danh sách phim sau khi tải
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading movies: " + ex.Message);
                }
            }
            // Display movies in the UI
            DisplayMovies();
        }

        private void DisplayMovies()
        {
            flowLayoutPanel1.Controls.Clear(); // Clear existing items to prevent duplication

            foreach (var movie in movies)
            {
                try
                {
                    movielistitem listItem = new movielistitem(movie.Name)
                    {
                        Title = movie.Name,
                        URL = movie.Image
                    };

                    // Add a booking button
                    Button btnBook = new Button
                    {
                        Text = "Đặt phim",
                        Dock = DockStyle.Bottom
                    };


                    listItem.Controls.Add(btnBook);
                    flowLayoutPanel1.Controls.Add(listItem);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying movie: " + ex.Message);
                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // This method can be left empty or customized as needed
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                //Đóng form hiện tại và quay lại màn hình đăng nhập
                this.Hide(); // Hoặc `this.Close();` nếu cần
                login loginForm = new login();
                loginForm.Show();
            }
        }
        private void accountInfomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountInfo accountInfo = new AccountInfo();
            accountInfo.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }
    }

    public class Movie
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public DateTime SelectedDate { get; set; } // Ngày được chọn
    }
}