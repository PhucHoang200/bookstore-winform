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
    public partial class UC_Sachsachadmin : UserControl
    {
        SachBUS sachBUS = new SachBUS();
        public UC_Sachsachadmin()
        {
            InitializeComponent();
            var ds_Sach = sachBUS.GetAllSach();
            hienThiDS_Sach(ds_Sach);
        }

        public void hienThiDS_Sach(List<Sach> ds_Sach)
        {
            

            // Tạo DataTable
            DataTable dt = new DataTable();
            dt.Columns.Add("MaSach");
            dt.Columns.Add("TenSach");
            dt.Columns.Add("TacGia");
            dt.Columns.Add("TheLoai");
            dt.Columns.Add("NhaXuatBan");
            dt.Columns.Add("NamXuatBan");
            dt.Columns.Add("DonGiaBan");

            // Duyệt qua danh sách sách và thêm vào DataTable
            foreach (var sach in ds_Sach)
            {
                decimal? donGiaBan = sach.Khoes.FirstOrDefault()?.DonGiaBan;

                dt.Rows.Add(
                    sach.Id,
                    sach.TenSach,
                    String.Join(", ", sach.TacGias.Select(i => i.TenTG)), // Nối tên tác giả thành chuỗi
                    String.Join(", ", sach.TheLoais.Select(i => i.TenTL)), // Nối tên thể loại thành chuỗi
                    sach.NhaXuatBan.TenNXB,
                    sach.NamXuatBan,
                    donGiaBan.HasValue ? donGiaBan.Value.ToString("N0") : "Chưa có giá"
                );
            }

            // Gán DataTable cho DataGridView
            datagridviewSach.DataSource = dt;

            // Tùy chỉnh hiển thị DataGridView (nếu cần)
            datagridviewSach.Columns["MaSach"].HeaderText = "Mã Sách";
            datagridviewSach.Columns["TenSach"].HeaderText = "Tên Sách";
            datagridviewSach.Columns["TacGia"].HeaderText = "Tác Giả";
            datagridviewSach.Columns["TheLoai"].HeaderText = "Thể Loại";
            datagridviewSach.Columns["NhaXuatBan"].HeaderText = "Nhà Xuất Bản";
            datagridviewSach.Columns["NamXuatBan"].HeaderText = "Năm Xuất Bản";
            datagridviewSach.Columns["DonGiaBan"].HeaderText = "Đơn giá bán";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {

            var ds_Sach = sachBUS.GetAllSach();
            hienThiDS_Sach(ds_Sach);
        }

        private void btnTimkiemsach_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemsach.Text.Trim();

            if (string.IsNullOrEmpty(TimKiem))
            {
                MessageBox.Show("Nhập thông tin tìm kiếm.");
            }
            else
            {
                // Gọi hàm tìm kiếm từ lớp BUS
                var ds_Sach = sachBUS.FindSach(TimKiem);

                if (ds_Sach == null || ds_Sach.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    hienThiDS_Sach(ds_Sach); // Hiển thị danh sách sách tìm được
                }
            }
        }

        private void cbbLocTheoGiaBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn trong ComboBox
            string selectedValue = cbbLocTheoGiaBan.SelectedItem?.ToString();

            if (selectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn cách sắp xếp.");
                return;
            }

            // Lấy danh sách sách kèm giá bán từ Kho
            List<Sach> ds_Sach = sachBUS.GetAllSachesWithKho();

            if (ds_Sach == null || ds_Sach.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu sách để lọc.");
                return;
            }

            // Sắp xếp danh sách theo lựa chọn
            switch (selectedValue)
            {
                case "Tăng dần":
                    ds_Sach = ds_Sach
                        .OrderBy(s => s.Khoes.FirstOrDefault()?.DonGiaBan ?? decimal.MaxValue)
                        .ToList();
                    break;

                case "Giảm dần":
                    ds_Sach = ds_Sach
                        .OrderByDescending(s => s.Khoes.FirstOrDefault()?.DonGiaBan ?? decimal.MinValue)
                        .ToList();
                    break;

                default:
                    MessageBox.Show("Lựa chọn không hợp lệ.");
                    return;
            }

            // Hiển thị danh sách sau khi sắp xếp
            hienThiDS_Sach(ds_Sach);
        }

        private void UC_Sachsachadmin_Load(object sender, EventArgs e)
        {
            // Thêm tùy chọn vào ComboBox
            cbbLocTheoGiaBan.Items.Clear();
            cbbLocTheoGiaBan.Items.Add("Tăng dần");
            cbbLocTheoGiaBan.Items.Add("Giảm dần");

            // Đặt giá trị mặc định
            cbbLocTheoGiaBan.SelectedIndex = 0;
        }
    }
}
