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
    public partial class fCT_PhieuNhap : Form
    {
        private readonly PhieuNhapSachBUS _bus;

        public fCT_PhieuNhap(int maPhieuNhap)
        {
            InitializeComponent();
            _bus = new PhieuNhapSachBUS(); // Khởi tạo BUS
            LoadThongTinPhieuNhap(maPhieuNhap);
            LoadDanhSachSanPham(maPhieuNhap);
        }

        private void LoadThongTinPhieuNhap(int maPhieuNhap)
        {
            var thongTinPhieuNhap = _bus.LayThongTinPhieuNhap(maPhieuNhap);
            if (thongTinPhieuNhap != null)
            {
                lblMaPN.Text = thongTinPhieuNhap.Id.ToString();
                lblNgayNhapSach.Text = thongTinPhieuNhap.NgayNhapSach?.ToString("dd/MM/yyyy") ?? "Không có dữ liệu";
                if (thongTinPhieuNhap.TongTienNhap != null)
                {
                    lblTongTien.Text = thongTinPhieuNhap.TongTienNhap.Value.ToString("C");
                }                
            }
        }

        private void LoadDanhSachSanPham(int maPhieuNhap)
        {
            var danhSachSanPham = _bus.LayDanhSachSanPhamTrongPhieuNhap(maPhieuNhap);

            if (danhSachSanPham.Any())
            {
                // Lấy tên nhà cung cấp từ sản phẩm đầu tiên
                string tenNCC = danhSachSanPham.FirstOrDefault().TenNCC;
                lblTenNCC.Text = tenNCC; // Giả sử bạn có một label để hiển thị tên nhà cung cấp
            }

            dgvDsSanPham.Rows.Clear();

            foreach (var sp in danhSachSanPham)
            {
                dgvDsSanPham.Rows.Add(sp.TenSach, sp.SoLuongNhap, sp.DonGiaNhap, sp.DonGiaBan, sp.ThanhTien);
            }

            dgvDsSanPham.Refresh();
        }
    
    private void lblMaPN_Click(object sender, EventArgs e)
        {

        }

        private void lblTenNCC_Click(object sender, EventArgs e)
        {

        }

        private void lblNgayNhapSach_Click(object sender, EventArgs e)
        {

        }

        private void dgvDsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Xuất phiếu nhập dưới dạng Word và PDF
                ImportExporter.ExportToWordAndPdf(dgvDsSanPham, lblMaPN, lblNgayNhapSach, lblTenNCC, lblTongTien);

                MessageBox.Show("Phiếu nhập đã được xuất thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
