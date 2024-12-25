using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;


namespace LTMCB_Final
{
    public partial class ChonPhim : Form
    {


        private string connectionString = "Data Source=LPK;Initial Catalog=CinemaManagement;Integrated Security=True;Trust Server Certificate=True";

        public ChonPhim()
        {
            InitializeComponent();
        }

        public List<Movie> movies;

        private void ChonPhim_Load(object sender, EventArgs e)
        {
            LoadMovies();
            // LoadCategories();
        }
        /* private void LoadCategories()
         {
             using (SqlConnection connection = new SqlConnection(connectionString))
             {
                 try
                 {
                     connection.Open();
                     string query = "SELECT DISTINCT Category_ID FROM Movie"; // Lấy danh sách thể loại duy nhất
                     SqlCommand command = new SqlCommand(query, connection);
                     SqlDataReader reader = command.ExecuteReader();

                     while (reader.Read())
                     {
                         string category = reader.GetString(0);
                         comboBox1.Items.Add(category); // Thêm thể loại vào ComboBox
                     }
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show("Error loading categories: " + ex.Message);
                 }
             }
         }*/
        private void LoadMovies()
        {
            movies = new List<Movie>();

            // Fetch movies from database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Image FROM Movie"; // Select relevant columns
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Movie movie = new Movie
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Image = reader.GetString(2)
                        };
                        movies.Add(movie);
                    }
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
                    btnBook.Click += (s, e) =>
                    {
                        var selectedMovie = (Movie)((Button)s).Tag;

                        // Gắn ngày từ DateTimePicker vào đối tượng Movie
                        selectedMovie.SelectedDate = dateTimePicker1.Value;

                        // Chuyển sang màn hình chọn ghế ngồi và truyền thông tin
                        /*   SelectSeatForm selectSeatForm = new SelectSeatForm(selectedMovie);
                           selectSeatForm.ShowDialog(); */
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox1.SelectedItem.ToString(); // Lấy thể loại đã chọn

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT Id, Name, Image FROM Movie WHERE Category_ID = @Category"; // Lọc theo thể loại
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Category", selectedCategory);

                    SqlDataReader reader = command.ExecuteReader();
                    movies.Clear(); // Xóa danh sách cũ

                    while (reader.Read())
                    {
                        Movie movie = new Movie
                        {
                            ID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Image = reader.GetString(2)
                        };
                        movies.Add(movie); // Thêm phim vào danh sách
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading movies by category: " + ex.Message);
                }
            }

            DisplayMovies();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(Cursor.Position);
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click_2(object sender, EventArgs e)
        {

        }
    }

    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public DateTime SelectedDate { get; set; } // Ngày được chọn
    }
}
