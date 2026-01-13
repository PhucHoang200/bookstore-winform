using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ResetPassword : Form
    {
        private string userEmail;
        private TaiKhoanBUS taiKhoanBUS;
        public ResetPassword(string email, TaiKhoanBUS bus)
        {
            InitializeComponent();
            userEmail = email;
            taiKhoanBUS = bus;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string newPassword = txtMatKhauMoi.Text.Trim();
            string confirmPassword = txtXacNhanMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash mật khẩu
            string hashedPassword = HashPassword(newPassword);

            // Cập nhật mật khẩu vào database
            if (taiKhoanBUS.UpdatePassword(userEmail, hashedPassword))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Đã xảy ra lỗi khi cập nhật mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        private void ResetPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của button
                btnXacNhan.PerformClick();
                // Ngăn Enter thực hiện hành động mặc định khác
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
