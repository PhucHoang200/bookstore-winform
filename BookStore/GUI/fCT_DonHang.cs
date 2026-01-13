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
    public partial class fCT_DonHang : Form
    {
        private readonly DonHangBUS _bus;

        public fCT_DonHang(int idDonHang)
        {
            InitializeComponent();
            _bus = new DonHangBUS();
            LoadThongTinDonHang(idDonHang);
            LoadDanhSachSanPham(idDonHang);
        }

        private void LoadThongTinDonHang(int idDonHang)
        {
            var thongTinDonHang = _bus.LayThongTinDonHang(idDonHang);
            if (thongTinDonHang != null)
            {
                lblMaDH.Text = thongTinDonHang.Id.ToString();
                // Kiểm tra kiểu dữ liệu của NgayMuaHang trước khi gọi ToString
                if (thongTinDonHang.NgayMuaHang != null)
                {
                    lblNgayMuaHang.Text = thongTinDonHang.NgayMuaHang.Value.ToString("dd/MM/yyyy");
                }
                lblHoTenKH.Text = thongTinDonHang.HoTenKH;
                lblEmail.Text = thongTinDonHang.Email;
                lblDiaChi.Text = thongTinDonHang.DiaChi;
                lblSĐT.Text = thongTinDonHang.SoDienThoai;
                // Kiểm tra kiểu dữ liệu của TongTienBan trước khi định dạng
                if (thongTinDonHang.TongTienBan != null)
                {
                    lblTongTien.Text = thongTinDonHang.TongTienBan.Value.ToString("C");
                }
            }
        }

        private void LoadDanhSachSanPham(int idDonHang)
        {
            var danhSachSanPham = _bus.LayDanhSachSanPhamTrongDonHang(idDonHang);
            dgvDsSanPham.Rows.Clear();

            foreach (var sp in danhSachSanPham)
            {
                dgvDsSanPham.Rows.Add(sp.TenSach, sp.SoLuongBan, sp.DonGiaBan, sp.ThanhTien);
            }

            dgvDsSanPham.Refresh();
        }


        private void lblMaDH_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayMuaHang_Click(object sender, EventArgs e)
        {

        }

        private void lblHoTenKH_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }

        private void lblSĐT_Click(object sender, EventArgs e)
        {

        }

        private void dgvDsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                // Xuất hóa đơn dưới dạng Word
                InvoiceExporter.ExportToWordAndPdf(dgvDsSanPham, lblMaDH, lblNgayMuaHang, lblHoTenKH, lblEmail, lblDiaChi, lblSĐT, lblTongTien);

                // Xuất hóa đơn dưới dạng PDF
                //InvoiceExporter.ExportToPdf(dgvDsSanPham, lblMaDH, lblNgayMuaHang, lblHoTenKH, lblEmail, lblDiaChi, lblSĐT, lblTongTien);

                MessageBox.Show("Hóa đơn đã được xuất thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
