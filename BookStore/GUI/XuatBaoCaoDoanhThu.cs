using DTO;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GUI.UserControl_Admin.UC_BCDoanhThuAdmin;
using System.Windows.Forms;
using GUI.UserControl_Admin;

namespace GUI
{
    public class XuatBaoCaoDoanhThu
    {

        public static void ExportToWordAndPdf(Label label1, DateTime startDate, DateTime endDate)
        {
            // Đường dẫn tới tệp Word mẫu
            string templatePath = @"C:\BaoCao\BaoCaoDoanhThuTemplate.docx";
            string folderPath = @"C:\BaoCao";
            string wordFilePath = System.IO.Path.Combine(folderPath, "BaoCaoDoanhThu.docx");
            string pdfFilePath = System.IO.Path.Combine(folderPath, "BaoCaoDoanhThu.pdf");

            // Kiểm tra nếu thư mục chưa tồn tại thì tạo mới
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            // Mở tệp Word mẫu
            Document document = new Document();
            document.LoadFromFile(templatePath);

            // Thay thế các placeholder trong tệp Word
            document.Replace("{Ngày bắt đầu:}", startDate.ToString("dd/MM/yyyy"), false, true);
            document.Replace("{Ngày kết thúc:}", endDate.ToString("dd/MM/yyyy"), false, true);

            // Lấy dữ liệu doanh thu
            var doanhThuData = GetDoanhThuTheoSanPham(startDate, endDate);

            // Thêm sách bán chạy nhất
            var sachBanChay = GetSachBanChay(startDate, endDate);
            string sachBanChayText = sachBanChay != null ? $"{sachBanChay.TenSach} - {sachBanChay.TongDoanhThu:C}" : "Không có dữ liệu";

            // Thay thế các placeholder mới
            document.Replace("{Sách bán chạy nhất:}", sachBanChayText, false, true);
            document.Replace("{Tổng Doanh Thu:}", label1.Text, false, true);

            // Lưu tệp Word với thông tin mới
            document.SaveToFile(wordFilePath, Spire.Doc.FileFormat.Docx);

            // Sau khi lưu file Word thành công, tiến hành chuyển đổi sang PDF
            try
            {
                // Sử dụng Spire.Doc để chuyển đổi từ .docx sang .pdf
                document.SaveToFile(pdfFilePath, Spire.Doc.FileFormat.PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi chuyển đổi sang PDF: {ex.Message}");
            }
        }

        // Phương thức để lấy sách bán chạy nhất
        public static BaoCaoDoanhThuTheoSanPham GetSachBanChay(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var sachBanChay = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate)
                    .GroupBy(ct => ct.Sach.TenSach)
                    .OrderByDescending(g => g.Sum(x => x.SoLuongBan * x.DonGiaBan))
                    .FirstOrDefault();

                if (sachBanChay != null)
                {
                    return new BaoCaoDoanhThuTheoSanPham
                    {
                        TenSach = sachBanChay.Key,
                        TongDoanhThu = sachBanChay.Sum(x => x.SoLuongBan * x.DonGiaBan)
                    };
                }
                return null;
            }
        }

        public static BaoCaoDoanhThuTheoSanPham GetDoanhThuTheoSanPham(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var doanhThu = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate)
                    .GroupBy(ct => ct.Sach.TenSach)
                    .Select(g => new BaoCaoDoanhThuTheoSanPham
                    {
                        TenSach = g.Key,
                        TongDoanhThu = g.Sum(x => x.SoLuongBan * x.DonGiaBan)
                    })
                    .ToList();

                return null;
            }
        }


    }
}
