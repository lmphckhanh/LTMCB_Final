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
        }

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
                            Image = reader.GetString(2) // Ensure this column contains a valid URL or path
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
                    movielistitem listItem = new movielistitem
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
    }

    public class Movie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
