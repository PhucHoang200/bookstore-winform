using DTO;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GUI.UserControl_Admin.UC_ThongkeAdmin;

namespace GUI
{
    public class ExportReportHelper
    {
        public static void ExportToWordAndPdf(DateTime startDate, DateTime endDate, string folderPath, string wordFileName = "BaoCaoThongKe.docx", string pdfFileName = "BaoCaoThongKe.pdf")
        {
            // Kiểm tra nếu thư mục chưa tồn tại thì tạo mới
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            // Đường dẫn tới tệp Word và PDF
            string wordFilePath = Path.Combine(folderPath, wordFileName);
            string pdfFilePath = Path.Combine(folderPath, pdfFileName);

            // Mở tệp Word mẫu
            Document document = new Document();
            string templatePath = Path.Combine(folderPath, "BaoCaoThongKeTemplate.docx");

            if (!File.Exists(templatePath))
            {
                throw new FileNotFoundException("File mẫu không tồn tại!");
            }

            document.LoadFromFile(templatePath);

            // Lấy dữ liệu từ các biểu đồ
            var theLoaiData = GetThongKeTheLoai(startDate, endDate); // Biểu đồ thể loại
            var nhanVienData = GetThongKeNhanVien(startDate, endDate); // Biểu đồ nhân viên
            var sachData = GetSoLuongBanTheoSanPham(startDate, endDate); // Biểu đồ sách bán

            // Thay thế các placeholder trong tệp Word
            document.Replace("{Ngày bắt đầu:}", startDate.ToString("dd/MM/yyyy"), false, true);
            document.Replace("{Ngày kết thúc:}", endDate.ToString("dd/MM/yyyy"), false, true);

            // Sách bán chạy nhất
            var sachBanChay = sachData.OrderByDescending(s => s.TongSoLuongBan).FirstOrDefault();
            string sachBanChayText = sachBanChay != null ? $"{sachBanChay.TenSach} - {sachBanChay.TongSoLuongBan:C}" : "Không có dữ liệu";
            document.Replace("{Sách bán chạy nhất:}", sachBanChayText, false, true);

            // Thể loại bán chạy nhất
            var theLoaiBanChay = theLoaiData.OrderByDescending(t => t.TongDoanhThu).FirstOrDefault();
            string theLoaiBanChayText = theLoaiBanChay != null ? $"{theLoaiBanChay.TenTL} - {theLoaiBanChay.TongDoanhThu:C}" : "Không có dữ liệu";
            document.Replace("{Thể loại bán chạy nhất:}", theLoaiBanChayText, false, true);

            // Nhân viên bán hàng tốt nhất
            var nhanVienXuatSac = nhanVienData.OrderByDescending(nv => nv.TongDoanhThu).FirstOrDefault();
            string nhanVienXuatSacText = nhanVienXuatSac != null ? $"{nhanVienXuatSac.TenNhanVien} - {nhanVienXuatSac.TongDoanhThu:C}" : "Không có dữ liệu";
            document.Replace("{Nhân viên bán hàng tốt nhất:}", nhanVienXuatSacText, false, true);

            // Nhân viên bán hàng tệ nhất
            var nhanVienTeNhat = nhanVienData.OrderBy(nv => nv.TongDoanhThu).FirstOrDefault();
            string nhanVienTeNhatText = nhanVienTeNhat != null ? $"{nhanVienTeNhat.TenNhanVien} - {nhanVienTeNhat.TongDoanhThu:C}" : "Không có dữ liệu";
            document.Replace("{Nhân viên bán hàng tệ nhất:}", nhanVienTeNhatText, false, true);

            // Lưu tệp Word với thông tin mới
            document.SaveToFile(wordFilePath, Spire.Doc.FileFormat.Docx);

            // Chuyển đổi sang PDF nếu cần
            try
            {
                // Sử dụng Spire.Doc để chuyển đổi từ .docx sang .pdf
                document.SaveToFile(pdfFilePath, Spire.Doc.FileFormat.PDF);
            }
            catch (Exception ex)
            {
                throw new Exception($"Có lỗi xảy ra khi chuyển đổi sang PDF: {ex.Message}");
            }
        }
        public static List<BaoCaoSoLuongBanTheoSanPham> GetSoLuongBanTheoSanPham(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var soLuongBan = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate) // Lọc theo ngày mua hàng
                    .GroupBy(ct => ct.Sach.TenSach) // Group theo tên sách
                    .Select(g => new BaoCaoSoLuongBanTheoSanPham
                    {
                        TenSach = g.Key, // Tên sách
                        TongSoLuongBan = g.Sum(x => x.SoLuongBan) // Tính tổng số lượng sách bán ra
                    })
                    .ToList();

                return soLuongBan;
            }
        }

        public class BaoCaoSoLuongBanTheoSanPham
        {
            public string TenSach { get; set; } // Tên sách
            public int TongSoLuongBan { get; set; } // Tổng số lượng sách bán ra
        }

        // Phương thức lấy thống kê thể loại
        public static List<BaoCaoDoanhThuTheoTheLoai> GetThongKeTheLoai(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var theLoai = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate)
                    .GroupBy(ct => ct.Sach.TheLoais.FirstOrDefault().TenTL) // Giả sử Sach có thuộc tính TheLoais
                    .Select(g => new BaoCaoDoanhThuTheoTheLoai
                    {
                        TenTL = g.Key,
                        TongDoanhThu = g.Sum(x => x.SoLuongBan * x.DonGiaBan)
                    })
                    .ToList();

                return theLoai;
            }
        }

        // Phương thức lấy thống kê nhân viên
        private static List<BaoCaoDoanhThuTheoNhanVien> GetThongKeNhanVien(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var nhanVien = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate)
                    .GroupBy(ct => ct.TaiKhoan.HoTen)
                    .Select(g => new BaoCaoDoanhThuTheoNhanVien
                    {
                        TenNhanVien = g.Key,
                        TongDoanhThu = g.Sum(x => x.SoLuongBan * x.DonGiaBan)
                    })
                    .ToList();
                return nhanVien;
            }
        }
    }
}
