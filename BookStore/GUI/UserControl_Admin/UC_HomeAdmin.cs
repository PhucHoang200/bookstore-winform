using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI.UserControl_Admin
{
    public partial class UC_HomeAdmin : UserControl
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
        private LoginViewModel _currentUser;
        public UC_HomeAdmin(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            _currentUser = loginViewModel;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            var taiKhoan = taiKhoanBUS.GetTaiKhoanByEmail(_currentUser.Email);
            if (taiKhoan != null)
            {
                lblHoTen.Text = taiKhoan.HoTen;
                lblEmail.Text = taiKhoan.Email;
                lblVaiTro.Text = taiKhoan.VaiTro.TenVaiTro;
                lblNgayTaoTaiKhoan.Text = taiKhoan.NgayTaoTaiKhoan?.ToString("dd/MM/yyyy") ?? "Chưa xác định";
                lblSĐT.Text = taiKhoan.SoDienThoai;
                lblLuong.Text = taiKhoan.Luong?.ToString("C0") ?? "Chưa xác định";
            }
        }

        private void lblHoTen_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblVaiTro_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayTaoTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void lblSĐT_Click(object sender, EventArgs e)
        {

        }

        private void lblLuong_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhauCu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhaplaiMatKhauMoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            string matKhauCu = txtMatKhauCu.Text;
            string matKhauMoi = txtMatKhauMoi.Text;
            string nhapLaiMatKhauMoi = txtNhaplaiMatKhauMoi.Text;

            if (string.IsNullOrEmpty(matKhauCu) || string.IsNullOrEmpty(matKhauMoi) || string.IsNullOrEmpty(nhapLaiMatKhauMoi))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (matKhauMoi != nhapLaiMatKhauMoi)
            {
                MessageBox.Show("Mật khẩu mới và nhập lại mật khẩu không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var taiKhoan = taiKhoanBUS.GetTaiKhoanByEmail(_currentUser.Email);
            if (taiKhoan == null)
            {
                MessageBox.Show("Không tìm thấy tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra mật khẩu cũ
            if (!taiKhoanBUS.CheckOldPassword(taiKhoan, txtMatKhauCu.Text.Trim()))
            {
                MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Hash mật khẩu mới
            string hashMatKhauMoi = HashPassword(matKhauMoi);

            // Cập nhật mật khẩu vào database
            if (taiKhoanBUS.UpdatePassword(_currentUser.Email, hashMatKhauMoi))
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Xóa các trường nhập
                txtMatKhauCu.Clear();
                txtMatKhauMoi.Clear();
                txtNhaplaiMatKhauMoi.Clear();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
