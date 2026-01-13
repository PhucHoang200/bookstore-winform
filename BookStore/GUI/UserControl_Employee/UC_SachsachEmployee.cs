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

namespace GUI.UserControl_Employee
{
    public partial class UC_SachsachEmployee : UserControl
    {
        SachBUS sachBUS = new SachBUS();
        public UC_SachsachEmployee()
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
            dt.Columns.Add("SoLuong");

            // Duyệt qua danh sách sách và thêm vào DataTable
            foreach (var sach in ds_Sach)
            {
                dt.Rows.Add(
                    sach.Id,
                    sach.TenSach,
                    String.Join(", ", sach.TacGias.Select(i => i.TenTG)), // Nối tên tác giả thành chuỗi
                    String.Join(", ", sach.TheLoais.Select(i => i.TenTL)), // Nối tên thể loại thành chuỗi
                    sach.NhaXuatBan.TenNXB,
                    sach.NamXuatBan,
                    sach.Khoes.Sum(i => i.SoLuongTon) // Tính tổng số lượng tồn (nếu cần)
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
            datagridviewSach.Columns["SoLuong"].HeaderText = "Số Lượng";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            var ds_Sach = sachBUS.GetAllSach();
            hienThiDS_Sach(ds_Sach);
        }

        private void btnTimkiemsach_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemsach.Text;

            if (TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {
                var ds_Sach = sachBUS.FindNhaXuatBanByName(TimKiem);

                if (ds_Sach.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    hienThiDS_Sach(ds_Sach);
                }
            }
        }
    }
}
