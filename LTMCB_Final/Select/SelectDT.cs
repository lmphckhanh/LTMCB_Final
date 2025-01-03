﻿using System;
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
using Azure;

namespace LTMCB_Final
{
    public partial class SelectDT : Form
    {
        string MovieID = "";
        private ClientTcpConnection tcp = Program.tcpConnection;
        ImageList imagelist = new ImageList
        {
            ImageSize = new Size(100, 100),
        };
        JObject[] jlist;
        public SelectDT(string MovieID)
        {
            InitializeComponent();
            imagelist.Images.Add("UIT", Image.FromFile(@"../../../Resources/UIT.png"));
            lsvShowTimes.LargeImageList = imagelist;
            this.MovieID = MovieID;
            LoadCinema();
            //LoadShowTimes();
        }

        // Tải danh sách khung giờ
        private void LoadShowTimes()
        {
            string cinema = "";
            string selectedDate = "";
            string headquery = @"QSELECT ST.ShowTimeID, ST.Date, S.Time FROM (dbo.ShowTimes ST JOIN dbo.Shifts S ON S.ShiftID = ST.ShiftID) JOIN dbo.RoomInCinema RC ON RC.RoomID = ST.RoomID WHERE ST.MovieID = '" + MovieID +"'";
            string query = "";
            //" AND RC.CinemaID = '" + cinema + "' AND ST.Date >=  CONVERT(VARCHAR(20),GETDATE())";

            if (string.IsNullOrEmpty(tbDate.Text))
            {
                query += headquery + @" AND CAST(ST.Date as DATETIME) + CAST(S.Time as DATETIME) >= GETDATE()";
            }
            else
            {
                query += headquery + @" AND ST.Date = '" + tbDate.Text + "'";
            }

            if (!string.IsNullOrEmpty(tbCinema.Text))
            {
                query += @" AND RC.CinemaID = '" + tbCinema.Text + "'";
            }
            query += ";";

            try
            {

                string[] response = tcp.SendAndRevceiveStr(query).Split("<*>");

                JObject[] list = new JObject[response.Length - 1];

                if (string.IsNullOrEmpty(response[0])) return;

                for (int i = 0; i < response.Length - 1; i++)
                {
                    list[i] = JObject.Parse(response[i]);
                }
                foreach (var i in list)
                {
                    string date = i.GetValue("Date").ToString();
                    string time = i.GetValue("Time").ToString();
                    ListViewItem item = new ListViewItem(date.Split(" ")[0] + "\n" + time);
                    item.SubItems.Add(i.GetValue("ShowTimeID").ToString());
                    item.ImageKey = "UIT";
                    lsvShowTimes.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phim: " + ex.Message, "Lỗi");
            }
        }

        // Tải thông tin phim
        private void LoadCinema()
        {
            string query = @"QSELECT * FROM dbo.Cinema;";
            string[] list = tcp.SendAndRevceiveStr(query).Split("<*>");
            jlist = new JObject[list.Length - 1];

            for (int i = 0; i < list.Length - 1; i++)
            {
                jlist[i] = JObject.Parse(list[i]);
            }
            foreach (var i in jlist)
            {
                cbCinema.Items.Add(i.GetValue("CinemaName").ToString());
            }
        }

        // Sự kiện thay đổi ngày
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Next
            if (lsvShowTimes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ca chiếu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string stID = lsvShowTimes.SelectedItems[0].SubItems[1].Text;
            SelectSeat selectSeat = new SelectSeat(stID);
            selectSeat.Show();
            this.Close();
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            tbDate.Text = dtpDate.Value.ToShortDateString();
        }

        private void cbCinema_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbCinema.Text = jlist[cbCinema.SelectedIndex].GetValue("CinemaID").ToString();
            tbAddress.Text = jlist[cbCinema.SelectedIndex].GetValue("Address").ToString();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            lsvShowTimes.Items.Clear();
            if (string.IsNullOrEmpty(tbCinema.Text))
            {
                return;
            }
            LoadShowTimes();
        }
    }
}
