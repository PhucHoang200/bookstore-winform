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
    public partial class UC_Tacgiasachadmin : UserControl
    {
        TacGiaBUS tacGiaBUS = new TacGiaBUS();
        private string Id;
        public UC_Tacgiasachadmin()
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

        private void datagridviewTacgia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = datagridviewTacgia.Rows[e.RowIndex];
                Id = row.Cells["Id"].Value.ToString();
                txtTentacgia.Text = row.Cells["TenTG"].Value.ToString();
            }
        }

        public void XoaDulieu()
        {
            txtTentacgia.Clear();
            txtTimkiemtacgia.Clear();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenTacGia = txtTentacgia.Text;

            string thongbao = tacGiaBUS.AddTacGia(tenTacGia);

            MessageBox.Show(thongbao);
            if (thongbao == "Thêm tác giả thành công!")
            {
                // Cập nhật lại danh sách hiển thị
                hienThiDSTacGia();
                XoaDulieu();
            }
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

                if (ds_TacGia == null)
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

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            hienThiDSTacGia();
            XoaDulieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string TenTG = txtTentacgia.Text;

            if (Id == null)
            {
                MessageBox.Show("Chọn tác giả cần sửa thông tin");
            }
            else
            {
                int MaTG = int.Parse(Id);
                string thongbao = tacGiaBUS.UpdateTacGia(MaTG, TenTG);
                MessageBox.Show(thongbao);

                if (thongbao == "Cập nhật thông tin tác giả thành công")
                {
                    // Cập nhật lại danh sách hiển thị
                    hienThiDSTacGia();

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

                string kq = tacGiaBUS.DeleteTacGia(Id);

                if (kq == "Xóa tác giả thành công")
                {
                    XoaDulieu();
                    hienThiDSTacGia();
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
