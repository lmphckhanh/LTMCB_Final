using LTMCB_Final.FunctionClass;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        ImageList imageList = new ImageList
        {
            ImageSize = new Size(150, 100) //Tùy chỉnh
        };
        private DirectoryInfo df = new DirectoryInfo(@"../../../Resources");
        FileInfo[] files;
        public ManageMovie()
        {
            InitializeComponent();
            cbAge.SelectedIndex = 0;
            cbRate.SelectedIndex = 0;
            cbStatus.SelectedIndex = 2;
            string[] fileInfos = Directory.GetFiles(df.FullName);
            files = new FileInfo[fileInfos.Length];
            for (int i = 0; i < fileInfos.Length; i++)
            {
                files[i] = new FileInfo(fileInfos[i]);
            }
            foreach (var i in files)
            {
                imageList.Images.Add(i.Name.Replace(i.Extension, ""), Image.FromFile(i.FullName));
            }
        }

        void LoadMovieList()
        {
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


            string query = @"QSELECT * FROM dbo.Movie WHERE Name LIKE '%" + tbSearch + "%' AND MinAge >= " + cbAge.Text.Replace("+", "") + " AND Rate >= " + cbRate.Text.Replace("+", "") + " AND Status IN " + Status + ";";

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
                byte[] pic = tcp.SendAndRevceiveBytes("P" + i.GetValue("Status").ToString());
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

                lsvMovieList.LargeImageList = imageList;
                try
                {
                    item.ImageKey = MovieID;
                }
                catch
                {

                    using (FileStream fs = new FileStream(df.FullName + @"/" + MovieID + ".png", FileMode.OpenOrCreate))
                    {
                        fs.Write(tcp.SendAndRevceiveBytes(url));
                    }
                    imageList.Images.Add(item.SubItems[1].Text, (Image)new ImageConverter().ConvertFrom(File.ReadAllBytes(df.FullName + @"/" + MovieID)));
                    lsvMovieList.LargeImageList = imageList;
                    item.ImageKey = MovieID;
                }

                lsvMovieList.Items.Add(item);
            }
        }

        private void lsvMovieList_ItemActivate(object sender, EventArgs e)
        {
            string id = lsvMovieList.SelectedItems[0].SubItems[1].Text;
            string name = lsvMovieList.SelectedItems[0].SubItems[0].Text;
            string dir = lsvMovieList.SelectedItems[0].SubItems[2].Text;
            string dur = lsvMovieList.SelectedItems[0].SubItems[3].Text;
            string reDay = lsvMovieList.SelectedItems[0].SubItems[4].Text;
            string lang = lsvMovieList.SelectedItems[0].SubItems[5].Text;
            string minAge = lsvMovieList.SelectedItems[0].SubItems[6].Text;
            string rate = lsvMovieList.SelectedItems[0].SubItems[7].Text;
            string status = lsvMovieList.SelectedItems[0].SubItems[9].Text;
            Image img = imageList.Images[id];
            MovieInfo info = new MovieInfo(id,name,dir,dur,reDay,lang,minAge,rate,status,img);
        }
    }
}
