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

namespace GUI.UserControl_Admin
{
    public partial class UC_DsDonhangAdmin : UserControl
    {
        private readonly DonHangBUS _bus;

        public UC_DsDonhangAdmin()
        {
            InitializeComponent();
            _bus = new DonHangBUS();
        }

        private void UC_DsDonhangAdmin_Load(object sender, EventArgs e)
        {
            LoadDonHang();

            // Thêm các lựa chọn lọc vào ComboBox
            cbbLocTheoThoiGianVaTongTien.Items.Add("Mới nhất");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Cũ nhất");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Tăng dần");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Giảm dần");

            // Đặt lựa chọn mặc định
            cbbLocTheoThoiGianVaTongTien.SelectedIndex = 0;
        }
        private void LoadDonHang()
        {
            var danhSachDonHang = _bus.LayDanhSachDonHang();
            dgvDsDonHang.Rows.Clear();

            foreach (var donhang in danhSachDonHang)
            {
                object[] row = new object[]
                {
            donhang.Id,
            donhang.NgayMuaHang,
            donhang.HoTenKH,
            donhang.TongTienBan
                };

                dgvDsDonHang.Rows.Add(row);
            }

            dgvDsDonHang.Refresh();

        }
        private void dgvDsDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                var selectedRow = dgvDsDonHang.Rows[e.RowIndex];
                int idDonHang = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // "Column1" là cột Mã đơn

                // Mở form fCT_DonHang và truyền Id đơn hàng
                fCT_DonHang formChiTiet = new fCT_DonHang(idDonHang);
                formChiTiet.ShowDialog();
            }
        }

        private void cbbLocTheoThoiGianVaTongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy danh sách đơn hàng từ BUS
            var danhSachDonHang = _bus.LayDanhSachDonHang();

            // Lọc dữ liệu theo lựa chọn
            switch (cbbLocTheoThoiGianVaTongTien.SelectedItem.ToString())
            {
                case "Mới nhất":
                    danhSachDonHang = danhSachDonHang
                        .OrderByDescending(dh => dh.NgayMuaHang)
                        .ToList();
                    break;

                case "Cũ nhất":
                    danhSachDonHang = danhSachDonHang
                        .OrderBy(dh => dh.NgayMuaHang)
                        .ToList();
                    break;

                case "Tăng dần":
                    danhSachDonHang = danhSachDonHang
                        .OrderBy(dh => dh.TongTienBan)
                        .ToList();
                    break;

                case "Giảm dần":
                    danhSachDonHang = danhSachDonHang
                        .OrderByDescending(dh => dh.TongTienBan)
                        .ToList();
                    break;
            }

            // Hiển thị lại dữ liệu sau khi lọc
            dgvDsDonHang.Rows.Clear();

            foreach (var donhang in danhSachDonHang)
            {
                object[] row = new object[]
                {
            donhang.Id,
            donhang.NgayMuaHang,
            donhang.HoTenKH,
            donhang.TongTienBan
                };

                dgvDsDonHang.Rows.Add(row);
            }

            dgvDsDonHang.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng nào chưa
            if (dgvDsDonHang.SelectedRows.Count > 0)
            {
                // Lấy Id của đơn hàng từ dòng đang được chọn
                var selectedRow = dgvDsDonHang.SelectedRows[0];
                var idDonHang = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // "Column1" là DataPropertyName của cột Mã đơn

                // Hiển thị thông báo xác nhận
                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa đơn hàng này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    // Gọi BUS để xóa đơn hàng
                    var result = _bus.XoaDonHang(idDonHang);

                    if (result) // Nếu xóa thành công
                    {
                        MessageBox.Show("Xóa đơn hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDonHang(); // Tải lại danh sách đơn hàng
                    }
                    else
                    {
                        MessageBox.Show("Xóa đơn hàng thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đơn hàng cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadDonHang();
        }

    }
}
