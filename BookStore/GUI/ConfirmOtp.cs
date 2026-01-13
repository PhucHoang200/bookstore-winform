using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GUI
{
    public partial class ConfirmOtp : Form
    {
        private string generatedOtp;
        private string userEmail;
        private TaiKhoanBUS taiKhoanBUS;
        private int attemptCount = 0;
        private const int MaxAttempts = 5;
        public ConfirmOtp(string otp, string email, TaiKhoanBUS bus)
        {
            InitializeComponent();
            generatedOtp = otp;
            userEmail = email;
            taiKhoanBUS = bus;
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            string enteredOtp = txtOtp.Text.Trim();

            if (enteredOtp == generatedOtp)
            {
                MessageBox.Show("OTP chính xác! Vui lòng đặt lại mật khẩu mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide(); // Ẩn form hiện tại trước khi mở form mới
                using (ResetPassword resetPasswordForm = new ResetPassword(userEmail, taiKhoanBUS))
                {
                    resetPasswordForm.ShowDialog();
                }
                this.Close();
            }
            else
            {
                attemptCount++;
                if (attemptCount >= MaxAttempts)
                {
                    MessageBox.Show("Bạn đã nhập sai OTP quá 5 lần! OTP sẽ được gửi lại.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    generatedOtp = new Random().Next(100000, 999999).ToString();
                    EmailBUS emailBUS = new EmailBUS();
                    emailBUS.SendOtpEmail(userEmail, generatedOtp);
                    attemptCount = 0;
                }
                else
                {
                    MessageBox.Show($"OTP không chính xác! Bạn còn {MaxAttempts - attemptCount} lần thử.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ConfirmOtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của button
                btnXacnhan.PerformClick();
                // Ngăn Enter thực hiện hành động mặc định khác
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
