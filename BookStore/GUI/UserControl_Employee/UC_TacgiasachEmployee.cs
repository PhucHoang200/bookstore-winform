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
    public partial class UC_TacgiasachEmployee : UserControl
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        
        public UC_TacgiasachEmployee()
        {
            InitializeComponent();
            hienThiDSTacGia();
        }

        public void hienThiDSTacGia()
        {
            var ds_TacGia = tacGiaBUS.GetAllTacGia();

            // Gán dữ liệu trực tiếp vào DataGridView
            datagridviewTacgia.DataSource = ds_TacGia;

            // Thay đổi tên cột
            datagridviewTacgia.Columns["Id"].HeaderText = "Mã tác giả";
            datagridviewTacgia.Columns["TenTG"].HeaderText = "Tên tác giả";
            datagridviewTacgia.Columns["Saches"].Visible = false;
        }

        private void btnTimkiemtacgia_Click(object sender, EventArgs e)
        {
            string TimKiem = txtTimkiemtacgia.Text;

            if (TimKiem == "")
            {
                MessageBox.Show("Khung nhập không được để trống");
            }
            else
            {


                var ds_TacGia = tacGiaBUS.FindTacGiaByName(TimKiem);

                if (ds_TacGia.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu cần tìm.");
                }
                else
                {
                    // Gán dữ liệu trực tiếp vào DataGridView
                    datagridviewTacgia.DataSource = ds_TacGia;

                    // Thay đổi tên cột
                    datagridviewTacgia.Columns["Id"].HeaderText = "Mã tác giả";
                    datagridviewTacgia.Columns["TenTG"].HeaderText = "Tên tác giả";
                    datagridviewTacgia.Columns["Saches"].Visible = false;
                }

            }
        }

        public void XoaDulieu()
        {
            txtTimkiemtacgia.Clear();
        }
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSTacGia();
            XoaDulieu();
        }
    }
}
