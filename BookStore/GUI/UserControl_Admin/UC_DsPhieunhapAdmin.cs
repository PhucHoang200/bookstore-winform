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
    public partial class UC_DsPhieunhapAdmin : UserControl
    {
        private readonly PhieuNhapSachBUS _bus;

        public UC_DsPhieunhapAdmin()
        {
            InitializeComponent();
            _bus = new PhieuNhapSachBUS();
        }

        private void UC_DsPhieunhapAdmin_Load(object sender, EventArgs e)
        {
            LoadPhieuNhapSach();

            // Thêm các lựa chọn lọc vào ComboBox
            cbbLocTheoThoiGianVaTongTien.Items.Add("Mới nhất");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Cũ nhất");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Tăng dần");
            cbbLocTheoThoiGianVaTongTien.Items.Add("Giảm dần");

            // Đặt lựa chọn mặc định
            cbbLocTheoThoiGianVaTongTien.SelectedIndex = 0;
        }

        private void LoadPhieuNhapSach()
        {
            var danhSachPhieuNhap = _bus.LayDanhSachPhieuNhapSach();
            dgvDsPhieuNhap.Rows.Clear();

            foreach (var phieuNhap in danhSachPhieuNhap)
            {
                object[] row = new object[]
                {
                    phieuNhap.Id,
                    phieuNhap.NgayNhapSach,
                    phieuNhap.TongTienNhap
                };

                dgvDsPhieuNhap.Rows.Add(row);
            }

            dgvDsPhieuNhap.Refresh();
        }

        private void dgvDsPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra dòng hợp lệ
            {
                var selectedRow = dgvDsPhieuNhap.Rows[e.RowIndex];
                int maPhieuNhap = Convert.ToInt32(selectedRow.Cells["Column1"].Value); // "MaPhieuNhap" là cột Mã phiếu nhập

                // Mở form fCT_PhieuNhap và truyền MaPhieuNhap
                fCT_PhieuNhap formChiTiet = new fCT_PhieuNhap(maPhieuNhap);
                formChiTiet.ShowDialog();
            }
        }

        private void cbbLocTheoThoiGianVaTongTien_SelectedIndexChanged(object sender, EventArgs e)
        {
            var danhSachPhieuNhap = _bus.LayDanhSachPhieuNhapSach();

            switch (cbbLocTheoThoiGianVaTongTien.SelectedItem.ToString())
            {
                case "Mới nhất":
                    danhSachPhieuNhap = danhSachPhieuNhap
                        .OrderByDescending(pn => pn.NgayNhapSach)
                        .ToList();
                    break;

                case "Cũ nhất":
                    danhSachPhieuNhap = danhSachPhieuNhap
                        .OrderBy(pn => pn.NgayNhapSach)
                        .ToList();
                    break;

                case "Tăng dần":
                    danhSachPhieuNhap = danhSachPhieuNhap
                        .OrderBy(pn => pn.TongTienNhap)
                        .ToList();
                    break;

                case "Giảm dần":
                    danhSachPhieuNhap = danhSachPhieuNhap
                        .OrderByDescending(pn => pn.TongTienNhap)
                        .ToList();
                    break;
            }

            dgvDsPhieuNhap.Rows.Clear();

            foreach (var phieuNhap in danhSachPhieuNhap)
            {
                object[] row = new object[]
                {
                    phieuNhap.Id,
                    phieuNhap.NgayNhapSach,
                    phieuNhap.TongTienNhap
                };

                dgvDsPhieuNhap.Rows.Add(row);
            }

            dgvDsPhieuNhap.Refresh();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDsPhieuNhap.SelectedRows.Count > 0)
            {
                var selectedRow = dgvDsPhieuNhap.SelectedRows[0];
                var idPhieuNhap = Convert.ToInt32(selectedRow.Cells["Column1"].Value);

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa phiếu nhập này?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    var result = _bus.XoaPhieuNhapSach(idPhieuNhap);

                    if (result)
                    {
                        MessageBox.Show("Xóa phiếu nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadPhieuNhapSach();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu nhập thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadPhieuNhapSach();
        }

    }
}
