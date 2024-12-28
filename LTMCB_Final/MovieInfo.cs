using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTMCB_Final
{
    public partial class MovieInfo : Form
    {
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

    }
}
