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
    public partial class SelectCinema : Form
    {
        private ClientTcpConnection tcp = Program.tcpConnection;
        public SelectCinema()
        {
            InitializeComponent();
            LoadLocations();
            LoadCinemaGroups();
        }


        //chọn cụm rạp: lotte, cgv, ...
        private void LoadCinemaGroups()
        {
            try
            {
                string query = "SELECT FROM ";
                string response = tcp.SendAndRevceiveStr(query);
                JArray groups = JArray.Parse(response);

                comboBox2.Items.Clear();
                foreach (var group in groups)
                {
                    comboBox2.Items.Add(group[" "].ToString());
                }
                comboBox2.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách cụm rạp: " + ex.Message, "Lỗi");
            }
        }

        //load thông tin các rạp: xa gần, địa chỉ
        private void LoadCinemas(string location, string group)
        {
            try
            {
                if (string.IsNullOrEmpty(location) || string.IsNullOrEmpty(group))
                {
                    MessageBox.Show("Vui lòng chọn đầy đủ địa điểm và cụm rạp.", "Thông báo");
                    return;
                }

                listView1.Items.Clear();

                string query = $@"
                SELECT 
                FROM 
                WHERE ";

                string response = tcp.SendAndRevceiveStr(query);
                JArray cinemas = JArray.Parse(response);

                if (cinemas.Count == 0)
                {
                    MessageBox.Show("Không có rạp nào phù hợp.", "Thông báo");
                    return;
                }

                foreach (var cinema in cinemas)
                {
                    ListViewItem item = new ListViewItem(cinema["CinemaName"].ToString());
                    item.SubItems.Add($"{cinema["Distance"]} km");
                    listView1.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách rạp: " + ex.Message, "Lỗi");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
                MessageBox.Show("Vui lòng chọn rạp.", "Thông báo");
            }
        }
    }
}
