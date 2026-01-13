using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
namespace GUI.UserControl_Employee
{
    public partial class UC_KhachhangEmployee : UserControl
    {
        KhachHangBUS khBUS = new KhachHangBUS();
        private string Id;
        public UC_KhachhangEmployee()
        {
            InitializeComponent();
            hienThiDSKhachHang();
        }
        public void hienThiDSKhachHang()
        {
            var kh = khBUS.GetAllKhachHang();

            // Gán dữ liệu trực tiếp vào DataGridView
            datagridviewKhachhang.DataSource = kh;


            // Thay đổi tên cột
            datagridviewKhachhang.Columns["Id"].HeaderText = "Mã khách hàng";
            datagridviewKhachhang.Columns["HoTenKH"].HeaderText = "Họ tên khách hàng";
            datagridviewKhachhang.Columns["Email"].HeaderText = "Email";
            datagridviewKhachhang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            datagridviewKhachhang.Columns["DiaChi"].HeaderText = "Địa chỉ";
            datagridviewKhachhang.Columns["DonHangs"].Visible = false;
        }

        private void btnTimkiemKH_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemKH.Text;

            if (TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {


                var kh = khBUS.FindKhachHangByName(TimKiem);

                if (kh.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    // Gán dữ liệu trực tiếp vào DataGridView
                    datagridviewKhachhang.DataSource = kh;


                    // Thay đổi tên cột
                    datagridviewKhachhang.Columns["Id"].HeaderText = "Mã khách hàng";
                    datagridviewKhachhang.Columns["HoTenKH"].HeaderText = "Họ tên khách hàng";
                    datagridviewKhachhang.Columns["Email"].HeaderText = "Email";
                    datagridviewKhachhang.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
                    datagridviewKhachhang.Columns["DiaChi"].HeaderText = "Địa chỉ";
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HotenKH = txtHotenKH.Text;
            string Email = txtEmail.Text;
            string SDT = txtSodienthoai.Text;
            string Diachi = txtDiachi.Text;

            if (KiemTraDuLieuDauVao(HotenKH, Email, SDT, Diachi))
            {
                string thongbao = khBUS.AddKhachHang(HotenKH, Email, SDT, Diachi);

                MessageBox.Show(thongbao);
                if (thongbao == "Thêm khách hàng thành công!")
                {
                    // Cập nhật lại danh sách hiển thị
                    hienThiDSKhachHang();
                    XoaDulieu();
                }

            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập");
            }

        }

        public void XoaDulieu()
        {
            txtHotenKH.Clear();
            txtEmail.Clear();
            txtSodienthoai.Clear();
            txtDiachi.Clear();
        }

        public bool KiemTraDuLieuDauVao(string HotenKH, string Email, string SDT, string DiaChi)
        {
            if (string.IsNullOrWhiteSpace(HotenKH) || string.IsNullOrWhiteSpace(Email) ||
                string.IsNullOrWhiteSpace(SDT) || string.IsNullOrWhiteSpace(DiaChi))
            {
                return false;
            }

            if (!KiemTraEmail(Email))
            {
                return false;
            }


            if (!KiemTraSoDienThoai(SDT))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool KiemTraEmail(string email)
        {

            // Biểu thức chính quy kiểm tra email
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public bool KiemTraSoDienThoai(string soDienThoai)
        {

            // Biểu thức chính quy kiểm tra số điện thoại
            string phonePattern = @"^0\d{9}$";
            return Regex.IsMatch(soDienThoai, phonePattern);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string HotenKH = txtHotenKH.Text;
            string Email = txtEmail.Text;
            string SDT = txtSodienthoai.Text;
            string Diachi = txtDiachi.Text;

            if (KiemTraDuLieuDauVao(HotenKH, Email, SDT, Diachi))
            {

                if (Id == null)
                {
                    MessageBox.Show("Chọn khách hàng cần sửa thông tin");
                }
                else
                {
                    int MaKH = int.Parse(Id);
                    string thongbao = khBUS.UpdateKhachHang(MaKH, HotenKH, Email, SDT, Diachi);
                    MessageBox.Show(thongbao);

                    if (thongbao == "Cập nhật thông tin khách hàng thành công")
                    {
                        // Cập nhật lại danh sách hiển thị
                        hienThiDSKhachHang();

                        // Xóa dữ liệu trên form sau khi thêm
                        XoaDulieu();


                    }

                }


            }
            else
            {
                MessageBox.Show("Kiểm tra lại thông tin nhập");
            }

        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSKhachHang();
        }

        private void datagridviewKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewKhachhang.Rows[e.RowIndex];
                Id = row.Cells["Id"].Value.ToString();
                txtHotenKH.Text = row.Cells["HoTenKH"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSodienthoai.Text = row.Cells["SoDienThoai"].Value.ToString();
                txtDiachi.Text = row.Cells["DiaChi"].Value.ToString();

            }
        }
    }
}
