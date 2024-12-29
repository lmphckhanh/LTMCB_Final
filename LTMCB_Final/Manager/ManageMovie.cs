using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LTMCB_Final.Manager
{
    public partial class ManageMovie : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        string Status = "(0,1)";
        ImageList imagelist = new ImageList();
        public ManageMovie()
        {
            InitializeComponent();
            cbAge.SelectedIndex = 0;
            cbRate.SelectedIndex = 0;
            cbStatus.SelectedIndex = 2;

            LoadMovieList();
        }

        void LoadMovieList()
        {
            lsvMovieList.Items.Clear();
            switch (cbStatus.SelectedIndex)
            {
                case 0:
                    Status = "(1)";
                    break;
                case 1:
                    Status = "(0)";
                    break;
                case 2:
                    Status = "(0,1)";
                    break;
                default:
                    Status = "(0,1)";
                    break;
            }


            string query = @"QSELECT * FROM dbo.Movie WHERE Name LIKE '%" + tbSearch.Text + "%' AND MinAge >= " + cbAge.Text.Replace("+", "") + " AND Rate >= " + cbRate.Text.Replace("+", "") + " AND Status IN " + Status + ";";

            string[] list = tcp.SendAndRevceiveStr(query).Split("<*>");
            JObject[] jlist = new JObject[list.Length - 1];


            for (int i = 0; i < list.Length - 1; i++)
            {
                jlist[i] = JObject.Parse(list[i]);
            }

            foreach (var i in jlist)
            {
                string MovieID = i.GetValue("MovieID").ToString();
                string url = i.GetValue("Image").ToString();
                ListViewItem item = new ListViewItem(i.GetValue("Name").ToString());
                item.SubItems.Add(MovieID);//1
                item.SubItems.Add(i.GetValue("Director").ToString());//2
                item.SubItems.Add(i.GetValue("Duration").ToString());//3
                item.SubItems.Add(i.GetValue("ReleaseDay").ToString());//4
                item.SubItems.Add(i.GetValue("Language").ToString());//5
                item.SubItems.Add(i.GetValue("MinAge").ToString());//6
                item.SubItems.Add(i.GetValue("Rate").ToString());//7
                item.SubItems.Add(url);//8
                item.SubItems.Add(i.GetValue("Status").ToString());//9

                Image img;
                try
                {
                    using (WebClient client = new WebClient())
                    {
                        Stream stream = client.OpenRead(url);
                        img = Image.FromStream(stream);
                    }

                }
                catch
                {
                    img = Image.FromFile(@"..\..\..\Resources\UIT.png");
                }
                imagelist.Images.Add(MovieID, img);
                lsvMovieList.LargeImageList = imagelist;
                item.ImageKey = MovieID;


                lsvMovieList.Items.Add(item);
            }
            jlist = null;
        }

        private void lsvMovieList_ItemActivate(object sender, EventArgs e)
        {
            string id = lsvMovieList.SelectedItems[0].SubItems[1].Text;
            //string name = lsvMovieList.SelectedItems[0].SubItems[0].Text;
            //string dir = lsvMovieList.SelectedItems[0].SubItems[2].Text;
            //string dur = lsvMovieList.SelectedItems[0].SubItems[3].Text;
            //string reDay = lsvMovieList.SelectedItems[0].SubItems[4].Text;
            //string lang = lsvMovieList.SelectedItems[0].SubItems[5].Text;
            //string minAge = lsvMovieList.SelectedItems[0].SubItems[6].Text;
            //string rate = lsvMovieList.SelectedItems[0].SubItems[7].Text;
            //string status = lsvMovieList.SelectedItems[0].SubItems[9].Text;
            //Image img = imageList.Images[id];
            MovieInfo info = new MovieInfo(id);
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string id = lsvMovieList.SelectedItems[0].SubItems[1].Text;
            string query = @"CDELETE FROM dbo.MovieOnCat WHERE MovieID = '" + id + "'; DELETE FROM dbo.MovieOnType WHERE MovieID = '" + id + "'; DELETE FROM dbo.Movie WHERE MovieID = '" + id + "'";

            string rs = tcp.SendAndRevceiveStr(query);
            if (Int32.Parse(rs) > 0)
            {
                LoadMovieList();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }

        }

        
    }
}
