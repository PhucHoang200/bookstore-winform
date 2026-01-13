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

namespace GUI.UserControl_Admin
{
    public partial class UC_Theloaisachadmin : UserControl
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        private string Id;
        public UC_Theloaisachadmin()
        {
            InitializeComponent();
            hienThiDSTheLoai();
        }

        public void hienThiDSTheLoai()
        {
            var ds_TheLoai = theLoaiBUS.GetAllTheLoai();

            // Gán dữ liệu trực tiếp vào DataGridView
            datagridviewTheloai.DataSource = ds_TheLoai;

            // Thay đổi tên cột
            datagridviewTheloai.Columns["Id"].HeaderText = "Mã thể loại";
            datagridviewTheloai.Columns["TenTL"].HeaderText = "Tên thể loại";
            datagridviewTheloai.Columns["Saches"].Visible = false;
        }

        private void datagridviewTheloai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewTheloai.Rows[e.RowIndex];
                Id = row.Cells["Id"].Value.ToString();
                txtTentheloai.Text = row.Cells["TenTL"].Value.ToString();
            }
        }

        public void XoaDulieu()
        {
            txtTentheloai.Clear();
            txtTimkiemtheloai.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTentheloai.Text;

            string thongbao = theLoaiBUS.AddTheLoai(tenTheLoai);

            MessageBox.Show(thongbao);
            if (thongbao == "Thêm thể loại thành công!")
            {
                // Cập nhật lại danh sách hiển thị
                hienThiDSTheLoai();
                XoaDulieu();
            }

        }

        private void btnTimkiemtheloai_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemtheloai.Text;

            if (TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {


                var ds_TheLoai = theLoaiBUS.FindTheLoaiByName(TimKiem);

                if (ds_TheLoai.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    // Gán dữ liệu trực tiếp vào DataGridView
                    datagridviewTheloai.DataSource = ds_TheLoai;

                    // Thay đổi tên cột
                    datagridviewTheloai.Columns["Id"].HeaderText = "Mã thể loại";
                    datagridviewTheloai.Columns["TenTL"].HeaderText = "Tên thể loại";
                    datagridviewTheloai.Columns["Saches"].Visible = false;
                }

            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSTheLoai();
            XoaDulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string TenTL = txtTentheloai.Text;

            if (Id == null)
            {
                MessageBox.Show("Chọn thể loại cần sửa thông tin");
            }
            else
            {
                int MaTL = int.Parse(Id);
                string thongbao = theLoaiBUS.UpdateTheLoai(MaTL, TenTL);
                MessageBox.Show(thongbao);

                if (thongbao == "Cập nhật thông tin thể loại thành công")
                {
                    // Cập nhật lại danh sách hiển thị
                    hienThiDSTheLoai();

                    // Xóa dữ liệu trên form sau khi thêm
                    XoaDulieu();

                }

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

                string kq = theLoaiBUS.DeleteTheLoai(Id);

                if (kq == "Xóa thể loại thành công")
                {
                    XoaDulieu();
                    hienThiDSTheLoai();
                    MessageBox.Show(kq);
                }
                else
                {
                    MessageBox.Show(kq);
                }

            }
        }
    }
}
