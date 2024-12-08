using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LTMCB_Final
{
    public partial class movielistitem : UserControl
    {


        public movielistitem(string title)
        {
            InitializeComponent();
            // Khởi tạo poster (nếu chưa có trong Designer)
            poster = new PictureBox();
            poster.SizeMode = PictureBoxSizeMode.StretchImage; // Điều chỉnh cách hiển thị ảnh
            this.Controls.Add(poster); // Thêm PictureBox vào UserControl
            poster.Location = new Point(40, 10);
            poster.Size = new Size(100, 150); // Kích thước của poster (có thể điều chỉnh)
            lbName.Text = title;

            // Optional: Initialize a loading label or progress bar
            loadingLabel = new Label();
            loadingLabel.Text = "Loading...";
            loadingLabel.Location = new Point(10, 170);
            loadingLabel.Visible = false;
            this.Controls.Add(loadingLabel);
        }

        #region Properties
        private string _title;
        private string _url;
        private Button _btnBook;
        private PictureBox poster;
        private Label loadingLabel;  // For displaying loading message

        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        [Category("Custom Props")]
        public Button btnbook
        {
            get { return _btnBook; }
            set { _btnBook = value; }
        }

        [Category("Custom Props")]
        public string URL
        {
            get { return _url; }
            set
            {
                _url = value;
                if (poster != null && !string.IsNullOrEmpty(value))
                {
                    // Show loading indicator
                    loadingLabel.Visible = true;

                    // Load image asynchronously from the URL and set it to the PictureBox
                    poster.LoadAsync(value); // Async load image from URL

                    // Once loading is complete, hide the loading indicator
                    poster.LoadCompleted += (sender, e) =>
                    {
                        loadingLabel.Visible = false;
                        if (e.Cancelled || e.Error != null)
                        {
                            MessageBox.Show("Failed to load image.");
                        }
                    };
                }
            }
        }
        #endregion

        private void CustomListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void CustomListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Movie selectedMovie = button.Tag as Movie; // Lấy thông tin phim từ nút

            // Mở form đặt vé và truyền thông tin phim
            //DatVeForm datVeForm = new DatVeForm(selectedMovie);
            //datVeForm.Show(); // Hiển thị form đặt vé
        }
    }
}
