using DTO;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.UserControl_Admin
{
    public partial class UC_ThongkeAdmin : UserControl
    {
        public UC_ThongkeAdmin()
        {
            InitializeComponent();

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            // Lấy ngày bắt đầu và kết thúc từ DateTimePicker
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // Lấy dữ liệu doanh thu
            var doanhThuData = GetSoLuongBanTheoSanPham(startDate, endDate);
            var theLoaiData = GetThongKeTheLoai(startDate, endDate); // Dữ liệu thể loại bán ra
            var nhanVienData = GetThongKeNhanVien(startDate, endDate); // Dữ liệu nhân viên

            // Xóa dữ liệu cũ trên biểu đồ
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            // Biểu đồ thống kê sách bán ra (Biểu đồ cột)
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartRevenue.ChartAreas.Add(chartArea);
            Series series = new Series("Sách Bán Ra")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true
            };
            chartRevenue.Series.Add(series);

            // Lặp qua dữ liệu doanh thu để tính tổng số lượng bán ra của mỗi sách
            foreach (var item in doanhThuData)
            {
                // Giả sử mỗi item có thuộc tính "TongSoLuongBan" đại diện cho tổng số lượng bán ra của sách
                series.Points.AddXY(item.TenSach, item.TongSoLuongBan);
            }


            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add("Báo Cáo Doanh Thu Theo Sách");
            chartRevenue.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            chartRevenue.ChartAreas[0].AxisX.Title = "Tên Sách";
            chartRevenue.ChartAreas[0].AxisY.Title = "Tổng Doanh Thu (VNĐ)";

            // Biểu đồ tròn thống kê thể loại bán ra
            // Biểu đồ tròn thống kê thể loại bán ra
            chartCategoryRevenue.Series.Clear();
            chartCategoryRevenue.ChartAreas.Clear();

            // Tạo ChartArea
            ChartArea chartAreaCategory = new ChartArea("ChartArea2");
            chartCategoryRevenue.ChartAreas.Add(chartAreaCategory);

            // Tạo Series cho biểu đồ
            Series seriesCategory = new Series("Thể Loại")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };
            chartCategoryRevenue.Series.Add(seriesCategory);

            // Tính tổng doanh thu
            decimal totalRevenue = theLoaiData.Sum(item => item.TongDoanhThu);

            foreach (var item in theLoaiData)
            {
                // Tính tỷ lệ phần trăm
                decimal percentage = (item.TongDoanhThu / totalRevenue) * 100;

                // Thêm điểm vào biểu đồ với giá trị doanh thu
                var point = seriesCategory.Points.AddXY(item.TenTL, item.TongDoanhThu);

                // Hiển thị phần trăm trên biểu đồ
                seriesCategory.Points[point].Label = $"{percentage:F2}%";

                // Hiển thị tên thể loại trong legend
                seriesCategory.Points[point].LegendText = item.TenTL;
            }



            chartCategoryRevenue.Titles.Clear();
            chartCategoryRevenue.Titles.Add("Thống Kê Thể Loại Bán Ra");

            // Biểu đồ đường thống kê hiệu suất bán hàng của nhân viên
            // Biểu đồ đường thống kê hiệu suất bán hàng của nhân viên
            // Xóa dữ liệu cũ trên biểu đồ
            chartEmployeePerformance.Series.Clear();
            chartEmployeePerformance.ChartAreas.Clear();

            // Tạo ChartArea
            ChartArea chartAreaEmployee = new ChartArea("ChartArea3");
            chartEmployeePerformance.ChartAreas.Add(chartAreaEmployee);

            // Lấy dữ liệu thống kê
             nhanVienData = GetThongKeNhanVien(startDate, endDate);

            // Lặp qua danh sách nhân viên
            foreach (var nhanVien in nhanVienData.GroupBy(x => x.TenNhanVien))
            {
                // Tạo Series cho từng nhân viên
                Series seriesEmployee = new Series(nhanVien.Key) // Tên nhân viên làm tên Series
                {
                    ChartType = SeriesChartType.Line,
                    XValueType = ChartValueType.Date,
                    IsValueShownAsLabel = true
                };

                // Thêm dữ liệu vào Series
                foreach (var item in nhanVien.OrderBy(x => x.Ngay)) // Sắp xếp theo ngày
                {
                    seriesEmployee.Points.AddXY(item.Ngay, item.TongDoanhThu);
                }

                // Thêm Series vào biểu đồ
                chartEmployeePerformance.Series.Add(seriesEmployee);
            }

            // Thêm tiêu đề biểu đồ
            chartEmployeePerformance.Titles.Clear();
            chartEmployeePerformance.Titles.Add("Hiệu Suất Bán Hàng Của Nhân Viên");


        }

        // Lấy dữ liệu hiệu suất bán hàng của nhân viên
        public List<BaoCaoDoanhThuTheoNhanVien> GetThongKeNhanVien(DateTime startDate, DateTime endDate)
        {
            using (var context = new BookStoreDBEntities())
            {
                var nhanVien = context.CT_DonHang
                    .Where(ct => ct.DonHang.NgayMuaHang >= startDate && ct.DonHang.NgayMuaHang <= endDate)
                    .GroupBy(ct => ct.TaiKhoan.HoTen) // Group by employee name (TaiKhoan)
                    .Select(g => new BaoCaoDoanhThuTheoNhanVien
                    {
                        TenNhanVien = g.Key,
                        Ngay = g.FirstOrDefault().DonHang.NgayMuaHang.Value,
                        TongDoanhThu = g.Sum(x => x.SoLuongBan * x.DonGiaBan)
                    })
                    .ToList();
                return nhanVien;
            }
        }


        // Lấy dữ liệu thể loại bán ra
        public List<BaoCaoDoanhThuTheoTheLoai> GetThongKeTheLoai(DateTime startDate, DateTime endDate)
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

        // Các lớp DTO cho thể loại và nhân viên
        public class BaoCaoDoanhThuTheoTheLoai
        {
            public string TenTL { get; set; }
            public decimal TongDoanhThu { get; set; }
        }

        public class BaoCaoDoanhThuTheoNhanVien
        {
            public string TenNhanVien { get; set; }
            public DateTime Ngay { get; set; }
            public decimal TongDoanhThu { get; set; }
        }

        public List<BaoCaoSoLuongBanTheoSanPham> GetSoLuongBanTheoSanPham(DateTime startDate, DateTime endDate)
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


        private void btnXuatThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                // Đường dẫn tới thư mục lưu báo cáo
                string folderPath = @"C:\BaoCao";

                // Gọi hàm xuất báo cáo
                ExportReportHelper.ExportToWordAndPdf(startDate, endDate, folderPath);

                MessageBox.Show("Đã xuất báo cáo thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
