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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LTMCB_Final
{
    public partial class MovieInfo : Form
    {
        ClientTcpConnection tcp = Program.tcpConnection;
        public MovieInfo()
        {

            InitializeComponent();
        }
        public MovieInfo(string Id, string Name, string Director, string Duration, string ReleaseDay, string lang, string MinAge, string Rate, string Status, Image img)
        {
            InitializeComponent();
            lbMovieName.Text = Name;
            lbDirector.Text = Director;
            lbDuration.Text = Duration;
            lbReleaseDay.Text = ReleaseDay;
            lbLang.Text = lang;
            lbMinAge.Text = MinAge;
            lbRate.Text = Rate;
            lbStatus.Text = Status;
            pbPoster.Image = img;
        }
        public MovieInfo(string Id)
        {
            InitializeComponent();
            string query = @"GSELECT TOP 1 * FROM dbo.Movie WHERE MovieID = '" + Id + "';";
            pbPoster.SizeMode = PictureBoxSizeMode.StretchImage;
            string json = tcp.SendAndRevceiveStr(query);
            JObject job = new JObject();
            try
            {
                job = JObject.Parse(json);
                lbMovieName.Text = job.GetValue("Name").ToString();
                lbDirector.Text = job.GetValue("Director").ToString();
                lbDuration.Text = job.GetValue("Duration").ToString();
                lbReleaseDay.Text = job.GetValue("ReleaseDay").ToString();
                lbLang.Text = job.GetValue("Language").ToString();
                lbMinAge.Text = job.GetValue("MinAge").ToString();
                lbRate.Text = job.GetValue("Rate").ToString();
                string status = job.GetValue("Status").ToString();

                if (status == "True")
                {
                    lbStatus.Text = "Đang công chiếu";
                }
                else
                {
                    lbStatus.Text = "Không công chiếu";
                } 
                    

                pbPoster.LoadAsync(job.GetValue("Image").ToString());
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void lbMovieName_Click(object sender, EventArgs e)
        {

        }
    }
}
