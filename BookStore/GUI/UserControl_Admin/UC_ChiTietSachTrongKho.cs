using BUS;
using DTO;
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
    public partial class UC_ChiTietSachTrongKho : UserControl
    {
        private SachBUS bus = new SachBUS();

        public UC_ChiTietSachTrongKho()
        {
            InitializeComponent();
            LoadChiTietSachTrongKho();
            LoadFilterOptions();
        }

        private void LoadChiTietSachTrongKho()
        {
            string filterOption = cbbLocTheoThoiGianVaSoLuongTon.SelectedItem?.ToString();

            // Thực hiện lọc dữ liệu
            List<CTSachVM> danhSach = bus.GetChiTietSachTrongKho();
            switch (filterOption)
            {
                case "Mới nhất":
                    danhSach = danhSach.OrderByDescending(x => x.NgayNhapMoiNhat).ToList();
                    break;
                case "Cũ nhất":
                    danhSach = danhSach.OrderBy(x => x.NgayNhapMoiNhat).ToList();
                    break;
                case "Nhiều nhất":
                    danhSach = danhSach.OrderByDescending(x => x.SoLuongTon).ToList();
                    break;
                case "Ít nhất":
                    danhSach = danhSach.OrderBy(x => x.SoLuongTon).ToList();
                    break;
                default:
                    break;
            }

            // Load dữ liệu lên DataGridView
            dgvChiTietSach.Rows.Clear();
            foreach (var item in danhSach)
            {
                dgvChiTietSach.Rows.Add(item.MaSach, item.TenSach, item.SoLuongTon,
                                        item.NgayNhapMoiNhat?.ToString("dd/MM/yyyy"));
            }

            dgvChiTietSach.Refresh();
        }

        private void LoadFilterOptions()
        {
            cbbLocTheoThoiGianVaSoLuongTon.Items.Clear();
            cbbLocTheoThoiGianVaSoLuongTon.Items.AddRange(new object[]
            {
        "Mới nhất",
        "Cũ nhất",
        "Nhiều nhất",
        "Ít nhất"
            });
            cbbLocTheoThoiGianVaSoLuongTon.SelectedIndex = 0; // Chọn mặc định "Mới nhất"
        }

        private void dgvChiTietSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Đảm bảo không click vào tiêu đề cột
            {
                int maSach = (int)dgvChiTietSach.Rows[e.RowIndex].Cells["Column1"].Value;
                fCT_Sach formCTSach = new fCT_Sach(maSach, ReloadData);
                formCTSach.ShowDialog();
            }
        }

        public void ReloadData()
        {
            LoadChiTietSachTrongKho();
        }

        private void cbbLocTheoThoiGianVaSoLuongTon_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChiTietSachTrongKho();
        }
    }
}
