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

namespace GUI.UserControl_Employee
{
    public partial class UC_NxbsachEmployee : UserControl
    {
        NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();
        
        public UC_NxbsachEmployee()
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

        private void btnTimkiemNxb_Click(object sender, EventArgs e)
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

        public void XoaDulieu()
        {
            txtTimkiemNxb.Clear();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            XoaDulieu();
            hienThiDSNhaXuatBan();
        }
    }
}
