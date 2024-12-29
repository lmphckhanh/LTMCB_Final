using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB_Final.Manager
{
    public partial class AddMovie : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        public AddMovie()
        {
            InitializeComponent();
            LoadCategory();
            LoadMovieType();
            cbMinAge.SelectedIndex = 0;
            cbStatus.SelectedIndex = 1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbMovieID.Text) ||
                string.IsNullOrEmpty(tbMovieName.Text) ||
                string.IsNullOrEmpty(tbDirector.Text) ||
                string.IsNullOrEmpty(tbDuration.Text) ||
                string.IsNullOrEmpty(tbReleaseDay.Text) ||
                string.IsNullOrEmpty(tbLang.Text) ||
                string.IsNullOrEmpty(tbPoster.Text) ||
                lsvCategory.CheckedItems.Count == 0 ||
                lsvMovieType.CheckedItems.Count == 0
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Lỗi");
                return;
            }
            string Status = "0";
            string minAge = cbMinAge.Text.Replace("+","");
            switch(cbStatus.SelectedIndex)
            {
                case 0: Status = "0";
                    break;
                case 1: Status = "1";
                    break;
                default: Status = "0";
                    break;
            }

            string cat = "";
            string movtype = "";
            foreach(ListViewItem item in lsvCategory.CheckedItems)
            {
                cat += @" INSERT INTO dbo.MovieOnCat(MovieID,CategoryID)VALUES('" + tbMovieID.Text + "', '" + item.SubItems[1].Text + "');";
            }
            foreach (ListViewItem item in lsvMovieType.CheckedItems)
            {
                movtype += @" INSERT INTO	dbo.MovieOnType(MovieID,MovieTypeID)VALUES('" + tbMovieID.Text + "', '" + item.SubItems[1].Text + "');";
            }


            string headquery = @"CBEGIN TRANSACTION SAVE TRANSACTION CP0 BEGIN TRY ";
            string bodyquery = @"INSERT INTO dbo.Movie(MovieID,Name, Director,Duration,ReleaseDay,Language,MinAge,Rate,Image,Status)" +
                "VALUES('" + tbMovieID.Text + "',  N'" + tbMovieName.Text + "',  N'" + tbDirector.Text + "', '" + tbDuration.Text + "', '" + tbReleaseDay.Text + "', N'" + tbLang.Text + "', " + minAge + ", 0, N'" + tbPoster.Text + "', " + Status + " );"
                + cat + movtype;
            string footquery = @" COMMIT TRANSACTION CP0; RETURN; END TRY BEGIN CATCH ROLLBACK TRANSACTION CP0; RETURN; END CATCH";

            string query = headquery + bodyquery + footquery;
            if (Int32.Parse(tcp.SendAndRevceiveStr(query)) > 0)
            {
                MessageBox.Show("Thêm phim thành công!", "Thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại!", "Thất bại");
            }
        }

        void LoadCategory()
        {
            string query = @"QSELECT * FROM dbo.Category";
            string[] list = tcp.SendAndRevceiveStr(query).Split("<*>");
            JObject[] jlist = new JObject[list.Length - 1];
            for (int i = 0; i < list.Length - 1; i++)
            {
                jlist[i] = JObject.Parse(list[i]);
            }
            foreach (var i in jlist)
            {
                ListViewItem item = new ListViewItem(i.GetValue("CategoryName").ToString());
                item.SubItems.Add(i.GetValue("CategoryID").ToString());

                lsvCategory.Items.Add(item);
            }


        }

        void LoadMovieType()
        {
            string query = @"QSELECT * FROM dbo.MovieType";
            string[] list = tcp.SendAndRevceiveStr(query).Split("<*>");
            JObject[] jlist = new JObject[list.Length - 1];
            for (int i = 0; i < list.Length - 1; i++)
            {
                jlist[i] = JObject.Parse(list[i]);
            }
            foreach (var i in jlist)
            {
                ListViewItem item = new ListViewItem(i.GetValue("MovieTypeName").ToString());
                item.SubItems.Add(i.GetValue("MovieTypeID").ToString());

                lsvMovieType.Items.Add(item);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tbReleaseDay.Text = dtpReleaseDay.Value.ToShortDateString();
        }
    }
}
