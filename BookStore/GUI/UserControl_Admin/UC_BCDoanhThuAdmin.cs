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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.UserControl_Admin
{
    public partial class UC_BCDoanhThuAdmin : UserControl
    {

        public UC_BCDoanhThuAdmin()
        {
            InitializeComponent();
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            // Lấy ngày bắt đầu và kết thúc từ DateTimePicker
            DateTime startDate = dtpStartDate.Value.Date;
            DateTime endDate = dtpEndDate.Value.Date;

            // Lấy dữ liệu doanh thu
            var doanhThuData = GetDoanhThuTheoSanPham(startDate, endDate);

            // Tính tổng doanh thu
            decimal tongDoanhThu = doanhThuData.Sum(item => item.TongDoanhThu);

            // Hiển thị tổng doanh thu lên label1
            label1.Text = $"Tổng Doanh Thu: {tongDoanhThu:C}"; // C: hiển thị số theo định dạng tiền tệ

            // Xóa dữ liệu cũ trên biểu đồ
            chartRevenue.Series.Clear();
            chartRevenue.ChartAreas.Clear();

            // Cấu hình ChartArea
            ChartArea chartArea = new ChartArea("ChartArea1");
            chartRevenue.ChartAreas.Add(chartArea);

            // Tạo Series cho biểu đồ cột
            Series series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                IsValueShownAsLabel = true
            };

            chartRevenue.Series.Add(series);

            // Thêm dữ liệu vào biểu đồ
            foreach (var item in doanhThuData)
            {
                series.Points.AddXY(item.TenSach, item.TongDoanhThu);
            }

            // Cấu hình hiển thị
            chartRevenue.Titles.Clear();
            chartRevenue.Titles.Add("Báo Cáo Doanh Thu Theo Sách");
            chartRevenue.Titles[0].Font = new Font("Segoe UI", 14, FontStyle.Bold);
            chartRevenue.ChartAreas[0].AxisX.Title = "Tên Sách";
            chartRevenue.ChartAreas[0].AxisY.Title = "Tổng Doanh Thu (VNĐ)";
            chartRevenue.ChartAreas[0].AxisX.Interval = 1;
        }

        public List<BaoCaoDoanhThuTheoSanPham> GetDoanhThuTheoSanPham(DateTime startDate, DateTime endDate)
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

                return doanhThu;
            }
        }

        public class BaoCaoDoanhThuTheoSanPham
        {
            public string TenSach { get; set; }
            public decimal TongDoanhThu { get; set; }
            public string TenTL { get; set; }
        }

        private void btnXuatBCDoanhThu_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Value.Date;
                DateTime endDate = dtpEndDate.Value.Date;

                XuatBaoCaoDoanhThu.ExportToWordAndPdf(label1, startDate, endDate);

                MessageBox.Show("Xuất báo cáo doanh thu thành công.");
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
            }
        }
    }
}
