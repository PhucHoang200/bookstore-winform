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

namespace GUI.UserControl_Employee
{
    public partial class UC_TheloaisachEmployee : UserControl
    {
        TheLoaiBUS theLoaiBUS = new TheLoaiBUS();
        
        public UC_TheloaisachEmployee()
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

        public void XoaDulieu()
        {
            txtTimkiemtheloai.Clear();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSTheLoai();
            XoaDulieu();
        }
    }
}
