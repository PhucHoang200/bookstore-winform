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

namespace GUI.UserControl_Admin
{
    public partial class UC_Nxbsachadmin : UserControl
    {
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        private string Id;
        public UC_Nxbsachadmin()
        {
            InitializeComponent();
            hienThiDSNhaXuatBan();
        }

        public void hienThiDSNhaXuatBan()
        {
            var ds_NhaXuatBan = nhaXuatBanBUS.GetAllTheLoai();

            datagridviewNxb.DataSource = ds_NhaXuatBan;

            datagridviewNxb.Columns["Id"].HeaderText = "Mã nhà xuất bản";
            datagridviewNxb.Columns["TenNXB"].HeaderText = "Tên nhà xuất bản";
            datagridviewNxb.Columns["Saches"].Visible = false;
        }

       

        public void XoaDulieu()
        {
            txtTenNxb.Clear();
            txtTimkiemNxb.Clear();
        }

        private void btnTimkiemnxb_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemNxb.Text;

            if (TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {
                var ds_NhaXuatBan = nhaXuatBanBUS.FindNhaXuatBanByName(TimKiem);

                if (ds_NhaXuatBan.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    datagridviewNxb.DataSource = ds_NhaXuatBan;

                    datagridviewNxb.Columns["Id"].HeaderText = "Mã nhà xuất bản";
                    datagridviewNxb.Columns["TenNXB"].HeaderText = "Tên nhà xuất bản";
                    datagridviewNxb.Columns["Saches"].Visible = false;
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            XoaDulieu();
            hienThiDSNhaXuatBan();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenNhaXuatBan = txtTenNxb.Text;
            string thongbao = nhaXuatBanBUS.AddNhaXuatBan(tenNhaXuatBan);

            MessageBox.Show(thongbao);
            if (thongbao == "Thêm nhà xuất bản thành công!")
            {
                hienThiDSNhaXuatBan();
                XoaDulieu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string tenNXB = txtTenNxb.Text;

            if (Id == null)
            {
                MessageBox.Show("Chọn nhà xuất bản cần sửa thông tin");
            }
            else
            {
                int maNXB = int.Parse(Id);
                string thongbao = nhaXuatBanBUS.UpdateNhaXuatBan(maNXB, tenNXB);
                MessageBox.Show(thongbao);

                if (thongbao == "Cập nhật thông tin nhà xuất bản thành công")
                {
                    hienThiDSNhaXuatBan();
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
                string kq = nhaXuatBanBUS.DeleteNhaXuatBan(Id);
                MessageBox.Show(kq);
                if (kq == "Xóa nhà xuất bản thành công")
                {
                    XoaDulieu();
                    hienThiDSNhaXuatBan();
                }
            }
        }

        private void datagridviewNxb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewNxb.Rows[e.RowIndex];
                Id = row.Cells["Id"].Value.ToString();
                txtTenNxb.Text = row.Cells["TenNXB"].Value.ToString();
            }
        }
    }
}
