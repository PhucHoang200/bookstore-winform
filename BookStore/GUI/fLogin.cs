using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Net;
using System.Net.Mail;
using DTO;
using System.Runtime.CompilerServices;

namespace GUI
{
    public partial class fLogin : Form
    {       
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private string tempOtp; // Lưu OTP tạm thời
        private string tempEmail; // Lưu email tạm thời
        private LoginViewModel currentUser;
        private LoginBUS loginBUS = new LoginBUS();
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string email = txtTaikhoan.Text.Trim();
            string password = txtMatkhau.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string role;
                int idTaiKhoan;

                if (loginBUS.CheckLogin(email, password, out role, out idTaiKhoan))
                {
                    // Lưu thông tin đăng nhập
                    var currentUser = new LoginViewModel
                    {
                        IdTaiKhoan = idTaiKhoan,
                        Email = email,
                        Role = role
                    };

                    if (role == "Admin")
                    {
                        MessageBox.Show("Đăng nhập thành công với vai trò Admin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fDashboardAdmin dashboardAdmin = new fDashboardAdmin(currentUser);
                        dashboardAdmin.Show();
                        this.Hide();
                    }
                    else if (role == "Nhân viên")
                    {
                        MessageBox.Show("Đăng nhập thành công với vai trò Nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fDashboardEmployee dashboardEmployee = new fDashboardEmployee(currentUser);
                        dashboardEmployee.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Vai trò không xác định!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.resetTextboxs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuenmatkhau_Click(object sender, EventArgs e)
        {
            string email = txtTaikhoan.Text.Trim();

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Kiểm tra email tồn tại
                if (!loginBUS.CheckEmailExist(email))
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tạo OTP và gửi email
                tempOtp = GenerateOtp();
                tempEmail = email;
                EmailBUS emailBUS = new EmailBUS();
                if (emailBUS.SendOtpEmail(email, tempOtp))
                {
                    MessageBox.Show("OTP đã được gửi đến email của bạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển đến form ConfirmOtp
                    ConfirmOtp confirmOtpForm = new ConfirmOtp(tempOtp, tempEmail, taiKhoanBUS);
                    confirmOtpForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đã xảy ra lỗi khi gửi OTP!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GenerateOtp()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString();
        }

        private void guna2ControlBoxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // Gọi sự kiện Click của button
                btnDangnhap.PerformClick();

                // Ngăn Enter thực hiện hành động mặc định khác
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void resetTextboxs()
        {
            txtTaikhoan.Clear();
            txtMatkhau.Clear();
        }

        private void txtTaikhoan_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
