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
using BUS;
using System.Text.RegularExpressions;

namespace GUI.UserControl_Admin
{
    public partial class UC_KhachhangAdmin : UserControl
    {
        KhachHangBUS khBUS = new KhachHangBUS();

        private string Id;

        public UC_KhachhangAdmin()
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




        private void datagridviewKhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewKhachhang.Rows[e.RowIndex];

                // Lấy giá trị từ các ô, kiểm tra null trước khi gán
                Id = row.Cells["Id"].Value?.ToString() ?? string.Empty;
                txtHotenKH.Text = row.Cells["HoTenKH"].Value?.ToString() ?? string.Empty;
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? string.Empty;
                txtSodienthoai.Text = row.Cells["SoDienThoai"].Value?.ToString() ?? string.Empty;
                txtDiachi.Text = row.Cells["DiaChi"].Value?.ToString() ?? string.Empty;
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSKhachHang();
        }

        public void XoaDulieu()
        {
            txtHotenKH.Clear();
            txtEmail.Clear();
            txtSodienthoai.Clear();
            txtDiachi.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string HotenKH = txtHotenKH.Text;
            string Email = txtEmail.Text;
            string SDT = txtSodienthoai.Text;
            string Diachi = txtDiachi.Text;

            if(KiemTraDuLieuDauVao(HotenKH, Email, SDT, Diachi))
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

        public bool KiemTraDuLieuDauVao(string HotenKH, string Email, string SDT, string DiaChi)
        {
            if ( string.IsNullOrWhiteSpace(HotenKH) || string.IsNullOrWhiteSpace(Email)||
                string.IsNullOrWhiteSpace(SDT) || string.IsNullOrWhiteSpace(DiaChi))
            {
                return false;
            }

            if(!KiemTraEmail(Email))
            {
                return false ;
            }


            if(!KiemTraSoDienThoai(SDT))
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

            // Kiểm tra nếu không phải chuỗi 10 ký tự số hoặc không bắt đầu bằng số 0
            if (!System.Text.RegularExpressions.Regex.IsMatch(soDienThoai, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bao gồm 10 chữ số và bắt đầu bằng số 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (Id == null)
            {
                MessageBox.Show("Chọn dữ liệu cần xóa");
            }
            else
            {
                
                string kq = khBUS.DeleteKhachHang(Id);

                if (kq == "Xóa khách hàng thành công")
                {
                    XoaDulieu();
                    hienThiDSKhachHang() ;
                    MessageBox.Show(kq);
                }
                else
                {
                    MessageBox.Show(kq);
                }

            }
        }

        private void btnTimkiemKH_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemKH.Text;

            if(TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {
                

                var kh = khBUS.FindKhachHangByName(TimKiem);

                if(kh.Count == 0)
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

    }
}
