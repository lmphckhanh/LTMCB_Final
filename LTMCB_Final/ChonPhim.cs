using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.CodeDom;
using LTMCB_Final.Manager;


namespace LTMCB_Final
{
    public partial class ChonPhim : Form
    {


        ClientTcpConnection tcp = Program.tcpConnection;


        public ChonPhim()
        {
            InitializeComponent();
            if (login.RoleID == "QL")
            {
                btnManage.Visible = true;
                btnManage.Enabled = true;
            }
            else
            {
                btnManage.Visible = false;
                btnManage.Enabled = false;
            }
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
                string query = @"QSELECT CategoryName FROM dbo.Category;"; // Thay đổi với câu truy vấn thực tế
                string[] rs = tcp.SendAndRevceiveStr(query).Split("<*>"); // Tách dữ liệu từ phản hồi

                JObject[] jlist = new JObject[rs.Length - 1]; // Khởi tạo mảng JObject

                // Phân tích từng phần tử trong chuỗi kết quả
                for (int i = 0; i < rs.Length - 1; i++)
                {
                    jlist[i] = JObject.Parse(rs[i]); // Phân tích chuỗi thành đối tượng JSON
                }

                // Duyệt qua các đối tượng JObject và thêm vào ComboBox
                foreach (var item in jlist)
                {
                    string categoryName = item.GetValue("CategoryName").ToString();


                    comboBox1.Items.Add(categoryName);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading categories: " + ex.Message); // Hiển thị thông báo lỗi nếu có
            }
        }



        private void LoadMovies(string categoryID = null)
        {
            {
                try
                {
                    string query = "";
                    movies = new List<Movie>();
                    if (comboBox1.Text == string.Empty)
                    {
                        query = @"QSELECT MovieID, Name, Image FROM dbo.Movie;";
                    }
                    else
                    {
                        query = @"QSELECT DISTINCT M.MovieID, M.Name, M.Image FROM (dbo.Movie M JOIN dbo.MovieOnCat MC ON MC.MovieID = M.MovieID) JOIN dbo.Category C ON C.CategoryID = MC.CategoryID WHERE C.CategoryName =  N'" + comboBox1.Text + "';";
                    }
                    string[] rs = tcp.SendAndRevceiveStr(query).Split("<*>");
                    JObject[] jlist = new JObject[rs.Length - 1];
                    for (int i = 0; i < rs.Length - 1; i++)
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
                        URL = movie.Image,
                        ID = movie.ID
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


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadMovies();
        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            comboBox1.Text = string.Empty;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            ManageMovie manage = new ManageMovie();
            manage.Show();
            this.Hide();
        }

        private void ChonPhim_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    public class Movie
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
         public string CategoryID { get; set; } 

        public DateTime SelectedDate { get; set; } // Ngày được chọn
    }
}