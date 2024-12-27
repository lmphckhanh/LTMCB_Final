using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LTMCB_Final
{
    public partial class Edit_Info : Form
    {
        // Chuỗi kết nối tới cơ sở dữ liệu
        string connectionString = @"Data Source=LPK;Initial Catalog=CinemaManagement;Integrated Security=True;Trust Server Certificate=True";

        public Edit_Info()
        {
            InitializeComponent();

            // Đảm bảo đăng ký sự kiện
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            // Đặt mục mặc định cho ComboBox (có thể chọn "Name" mặc định)
            comboBox1.SelectedIndex = 0;

            // Gọi sự kiện để hiển thị thông tin tương ứng khi form load
            UpdateFields(comboBox1.SelectedItem.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra có chọn đúng mục không
            if (comboBox1.SelectedItem != null)
            {
                // Lấy mục được chọn từ ComboBox
                string selectedItem = comboBox1.SelectedItem.ToString();

                // Cập nhật các Label cho các trường nhập liệu tương ứng
                UpdateFields(selectedItem);
            }
        }

        private void UpdateFields(string selectedItem)
        {
            // Cập nhật các Label cho trường nhập liệu dựa trên mục đã chọn
            switch (selectedItem)
            {
                case "Name":
                    lbNew.Text = "New Name:";
                    lbComfirm.Text = "Confirm Name:";
                    break;

                case "Email":
                    lbNew.Text = "New Email:";
                    lbComfirm.Text = "Confirm Email:";
                    break;

                case "PhoneNumber":
                    lbNew.Text = "New Phone Number:";
                    lbComfirm.Text = "Confirm Phone Number:";
                    break;

                case "Address":
                    lbNew.Text = "New Address:";
                    lbComfirm.Text = "Confirm Address:";
                    break;

                default:
                    lbNew.Text = "";
                    lbComfirm.Text = "";
                    break;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        // Phương thức để lưu dữ liệu vào cơ sở dữ liệu
        private void btnSave_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            // Lấy thông tin từ các TextBox (thêm TextBox vào form tương ứng với từng mục)
            string newValue = tbNew.Text;
            string confirmValue = tbComfirm.Text;

            // Kiểm tra nếu giá trị xác nhận trùng khớp
            if (newValue != confirmValue)
            {
                MessageBox.Show("The new value and confirmation value do not match.");
                return;
            }

            // Cập nhật vào cơ sở dữ liệu
            UpdateDatabase(selectedItem, newValue);
        }

        // Phương thức cập nhật cơ sở dữ liệu
        private void UpdateDatabase(string fieldName, string newValue)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Câu lệnh SQL để cập nhật thông tin người dùng
                    string query = $"UPDATE Users SET {fieldName} = @NewValue WHERE UserId = @UserId";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số để tránh SQL Injection
                        command.Parameters.AddWithValue("@NewValue", newValue);
                        command.Parameters.AddWithValue("@UserId", 1); // Giả sử UserId là 1, thay thế với ID người dùng thực tế

                        // Thực thi câu lệnh UPDATE
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Information updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update information.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
