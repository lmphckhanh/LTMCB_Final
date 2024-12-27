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
    public partial class SelectCinema : Form
    {
        private string connectionString = " ";
        public SelectCinema()
        {
            InitializeComponent();
            LoadLocations();
            LoadCinemaGroups();
        }

        //lấy địa chỉ user
        private void LoadLocations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(" ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["LocationName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading locations: " + ex.Message);
            }
        }

        //chọn cụm rạp: lotte, cgv, ...
        private void LoadCinemaGroups()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(" ", conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["GroupName"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }
        }

        //load thông tin các rạp: xa gần, địa chỉ
        private void LoadCinemas(string location, string group)
        {
            try
            {
                listView1.Items.Clear();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(
                        " ",
                        conn
                    );

                    cmd.Parameters.AddWithValue("@Location", location);
                    cmd.Parameters.AddWithValue("@GroupName", group);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["CinemaName"].ToString());
                        item.SubItems.Add(reader["Distance"].ToString() + " km");
                        listView1.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!" + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                LoadCinemas(comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedCinema = listView1.SelectedItems[0].Text;
                Form selectDateForm = new SelectDT(selectedCinema);
                selectDateForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn rạp.");
            }
        }
    }
}
