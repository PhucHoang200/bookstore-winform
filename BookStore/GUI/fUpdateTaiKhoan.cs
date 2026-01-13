using BUS;
using DTO;
using GUI.UserControl_Admin;
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
    public partial class fUpdateTaiKhoan : Form
    {
        private int TaiKhoanId;
        private TaiKhoanBUS _bus = new TaiKhoanBUS();
        private Action _onReloadData;

        public fUpdateTaiKhoan(int id, Action onReloadData)
        {
            InitializeComponent();
            TaiKhoanId = id;
            _onReloadData = onReloadData;

            // Load thông tin tài khoản
            LoadTaiKhoan();
        }

        private void fUpdateTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void LoadTaiKhoan()
        {
            var taiKhoan = _bus.GetTaiKhoanById(TaiKhoanId);
            if (taiKhoan != null)
            {
                txtHoTen.Text = taiKhoan.HoTen;
                txtEmail.Text = taiKhoan.Email;
                txtSĐT.Text = taiKhoan.SoDienThoai;
                txtLuong.Text = taiKhoan.Luong.HasValue ? taiKhoan.Luong.Value.ToString() : "";
                txtNgayTaoTK.Text = taiKhoan.NgayTaoTaiKhoan.HasValue ? taiKhoan.NgayTaoTaiKhoan.Value.ToString("dd/MM/yyyy") : "N/A";

                // Load Vai trò vào ComboBox
                cbbVaiTro.DataSource = _bus.GetAllVaiTro();
                cbbVaiTro.DisplayMember = "TenVaiTro";
                cbbVaiTro.ValueMember = "Id";
                cbbVaiTro.SelectedValue = taiKhoan.IdVaiTro;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            var taiKhoan = new TaiKhoan
            {
                Id = TaiKhoanId,
                HoTen = txtHoTen.Text,
                Email = txtEmail.Text,
                SoDienThoai = txtSĐT.Text,
                Luong = decimal.TryParse(txtLuong.Text, out decimal luong) ? luong : (decimal?)null,
                IdVaiTro = (int)cbbVaiTro.SelectedValue
            };

            bool result = _bus.UpdateTaiKhoan(taiKhoan);

            if (result)
            {
                MessageBox.Show("Cập nhật thành công!");
                _onReloadData?.Invoke();
                this.Close(); // Đóng form
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này không?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                bool result = _bus.DeleteTaiKhoan(TaiKhoanId);

                if (result)
                {
                    MessageBox.Show("Xóa thành công!");
                    UC_TaikhoanAdmin uC_TaikhoanAdmin = new UC_TaikhoanAdmin();
                    uC_TaikhoanAdmin.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void btnResetMatKhau_Click(object sender, EventArgs e)
        {
            // Mật khẩu mặc định
            string matKhauMacDinh = "123";

            // Băm mật khẩu trước khi gọi ResetMatKhau
            string matKhauHashBase64 = HashPasswordToBase64(matKhauMacDinh);

            // Gọi phương thức ResetMatKhau và truyền mật khẩu đã băm
            bool result = _bus.ResetMatKhau(TaiKhoanId, Convert.FromBase64String(matKhauHashBase64));

            if (result)
            {
                MessageBox.Show("Đặt lại mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại!");
            }
        }

        // Băm mật khẩu bằng SHA256
        public string HashPasswordToBase64(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }

        private void fUpdateTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
