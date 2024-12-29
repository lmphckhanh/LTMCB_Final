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
    public partial class SelectSeat : Form
    {
        private string ShowTimeID;
        private Slot seatData;
        private string roomName;
        private string roomID;
        private List<string> selectedSeats = new List<string>();
        private List<string> listTicket = new List<string>();
        private List<string> bookedSeats = new List<string>();

        private ClientTcpConnection tcp = Program.tcpConnection;

        public SelectSeat(string stID)
        {
            InitializeComponent();
            ShowTimeID = stID;
            bookedSeats = GetBookedSeat();
            GenerateSeats();
            //UpdateTotalPrice();
        }

        private List<string> GetBookedSeat()
        {
            List<string> BookedSlot = new List<string>();
            try
            {
                string query = @"QSELECT T.SlotID, R.RoomID, R.RoomName FROM (dbo.Ticket T JOIN dbo.SlotInRoom SR ON SR.SlotID = T.SlotID) JOIN dbo.Room R ON R.RoomID = SR.RoomID WHERE T.ShowTimeID = " + ShowTimeID +";";

                string[] response = tcp.SendAndRevceiveStr(query).Split("<*>");
                JObject[] seats = new JObject[response.Length - 1];
                for (int i = 0; i < response.Length - 1; i++)
                {
                    seats[i] = JObject.Parse(response[i]);
                }
                if (seats.Length > 0)
                {
                    roomID = seats[0].GetValue("RoomID").ToString();
                    roomName = seats[1].GetValue("RoomName").ToString();

                    foreach (var i in seats)
                    {
                        BookedSlot.Add(i.GetValue("SlotID").ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu ghế: " + ex.Message, "Lỗi");
            }

            return BookedSlot;
        }

        // Tạo giao diện ghế
        private void GenerateSeats()
        {
            string query = @"QSELECT S.SlotID, ST.Price, ST.SlotTypeName, S.Row, S.Col FROM ((((dbo.ShowTimes T JOIN dbo.Room R ON R.RoomID = T.RoomID) JOIN dbo.SlotInRoom SR ON SR.RoomID = R.RoomID) JOIN dbo.Slot S ON S.SlotID = SR.SlotID) JOIN dbo.SlotType ST ON ST.SlotTypeID = S.SlotTypeID) WHERE ShowTimeID = " + ShowTimeID + ";";
            string[] response = tcp.SendAndRevceiveStr(query).Split("<*>");
            JObject[] seats = new JObject[response.Length - 1];
            for (int i = 0; i < response.Length - 1; i++)
            {
                seats[i] = JObject.Parse(response[i]);
            }
            foreach (var i in seats)
            {
                Slot sl = new Slot
                {
                    Id = i.GetValue("SlotID").ToString(),
                    TypeName = i.GetValue("SlotTypeName").ToString(),
                    Col = i.GetValue("Col").ToString(),
                    Row = i.GetValue("Row").ToString(),
                    price = i.GetValue("Price").ToString(),
                };
                bool check = bookedSeats.Contains(sl.Id);
                Button btn = new Button
                {
                    Name = sl.Id,
                    Text = sl.Col + sl.Row + ((sl.TypeName == "Vip")?'\n' + sl.TypeName:""),
                    Enabled = !check,
                    BackColor = !check ? Color.Lime : Color.Red,
                    Size = new Size(75, 75),
                    Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    Margin = new Padding(4),
                };
                btn.Click += SelectBtn;
                flowLayoutPanel1.Controls.Add(btn);
            }

        }

        private void SelectBtn(object? sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            string seatName = seatButton.Name;

            if (selectedSeats.Contains(seatName))
            {
                // Bỏ chọn ghế
                selectedSeats.Remove(seatName);
                seatButton.BackColor = Color.Lime;
            }
            else
            {
                // Chọn ghế
                selectedSeats.Add(seatName);
                seatButton.BackColor = Color.Yellow;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một ghế!", "Thông báo");
                return;
            }

            DialogResult rs = MessageBox.Show($"Bạn đã chọn các ghế: {string.Join(", ", selectedSeats)}", "Xác nhận",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                string query = @"CINSERT INTO dbo.Ticket(TicketID,SlotID,ShowTimeID)VALUES";
                foreach (var i in selectedSeats)
                {
                    string ticket = Guid.NewGuid().ToString();
                    query += @"('" + ticket + "', '" + i + "', " + ShowTimeID +"),";
                    listTicket.Add(ticket);
                }
                query = query.Substring(0, query.Length - 1);
                query += ";";
                
                if (Int32.Parse(tcp.SendAndRevceiveStr(query)) > 0)
                {
                    Purchase pur = new Purchase(listTicket);
                    pur.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi, vui lòng thử lại", "Lỗi");
                }
            }
        }

        private void seat_Click(object sender, EventArgs e)
        {

        }
        class Slot
        {
            public string Id { get; set; }
            public string TypeName { get; set; }
            public string price { get; set; }
            public string Row { get; set; }
            public string Col { get; set; }

        }
    }
}
