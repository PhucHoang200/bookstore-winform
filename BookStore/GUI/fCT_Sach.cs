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

namespace GUI
{
    public partial class fCT_Sach : Form
    {
        private int _maSach;
        private SachBUS _bus = new SachBUS();
        private Action _onReloadData;

        public fCT_Sach(int maSach, Action onReloadData)
        {
            InitializeComponent();
            _maSach = maSach;
            LoadThongTinChiTietSach();
            _onReloadData = onReloadData;
        }

        private void LoadThongTinChiTietSach()
        {
            // Lấy thông tin sách
            var sachInfo = _bus.GetSachDetailsById(_maSach);

            if (sachInfo != null)
            {
                lblMaSach.Text = sachInfo.MaSach.ToString();
                txtTenSach.Text = sachInfo.TenSach;
                txtTG.Text = sachInfo.TacGia;
                txtTL.Text = sachInfo.TheLoai;
                txtNhaXB.Text = sachInfo.NhaXuatBan;
                txtNamXB.Text = sachInfo.NamXuatBan.ToString();
                lblSoLuongTon.Text = sachInfo.SoLuongTon.ToString();
            }

            // Lấy danh sách từ CT_PhieuNhap
            dgvChiTietPhieuNhap.Rows.Clear();
            foreach (var item in sachInfo.ChiTietPhieuNhap)
            {
                dgvChiTietPhieuNhap.Rows.Add(item.TenNCC, item.SoLuongNhap,
                                             item.DonGiaNhap, item.DonGiaBan,
                                             item.NgayNhap?.ToString("dd/MM/yyyy"), item.ThanhTien);
            }
            dgvChiTietPhieuNhap.Refresh();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtTenSach.Text) || string.IsNullOrWhiteSpace(txtTG.Text) ||
                    string.IsNullOrWhiteSpace(txtTL.Text) || string.IsNullOrWhiteSpace(txtNhaXB.Text) ||
                    string.IsNullOrWhiteSpace(txtNamXB.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtNamXB.Text, out int namXB))
                {
                    MessageBox.Show("Năm xuất bản phải là số nguyên hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var isUpdated = _bus.UpdateSach(_maSach, txtTenSach.Text.Trim(), txtTG.Text.Trim(),
                    txtTL.Text.Trim(), txtNhaXB.Text.Trim(), namXB);

                if (isUpdated)
                {
                    MessageBox.Show("Cập nhật thông tin sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _onReloadData?.Invoke();
                    this.Close(); // Đóng form
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sách này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    var isDeleted = _bus.DeleteSach(_maSach);

                    if (isDeleted)
                    {
                        MessageBox.Show("Xóa sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _onReloadData?.Invoke();
                        this.Close(); // Đóng form
                    }
                    else
                    {
                        MessageBox.Show("Xóa sách thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
