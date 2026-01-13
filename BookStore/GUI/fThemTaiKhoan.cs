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
using System.Windows.Forms;

namespace GUI
{
    public partial class fThemTaiKhoan : Form
    {
        private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public fThemTaiKhoan()
        {
            InitializeComponent();
            LoadVaiTro();
        }

        // Đổ dữ liệu vai trò vào ComboBox
        private void LoadVaiTro()
        {
            var vaiTroList = taiKhoanBUS.GetAllVaiTro();
            cbbVaiTro.DataSource = vaiTroList;
            cbbVaiTro.DisplayMember = "TenVaiTro";
            cbbVaiTro.ValueMember = "Id";
        }

        // Chuyển mật khẩu sang dạng băm SHA256
        private byte[] HashPassword(string plainPassword)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                return sha256.ComputeHash(Encoding.UTF8.GetBytes(plainPassword));
            }
        }

        private void cbbVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                var newTaiKhoan = new TaiKhoan
                {
                    HoTen = txtHoTen.Text.Trim(),
                    SoDienThoai = txtSĐT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    MatKhau = HashPassword(txtMatKhau.Text.Trim()),
                    NgayTaoTaiKhoan = DateTime.Now,
                    IdVaiTro = (int)cbbVaiTro.SelectedValue
                };

                if (taiKhoanBUS.SaveTaiKhoan(newTaiKhoan))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Lỗi khi thêm tài khoản.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xóa dữ liệu trong các TextBox sau khi lưu
        private void ClearFields()
        {
            txtHoTen.Clear();
            txtSĐT.Clear();
            txtEmail.Clear();
            txtMatKhau.Clear();
            cbbVaiTro.SelectedIndex = 0;
        }
    }
}
