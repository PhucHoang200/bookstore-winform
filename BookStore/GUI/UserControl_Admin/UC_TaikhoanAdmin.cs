using BUS;
using DTO;
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

namespace GUI.UserControl_Admin
{
    public partial class UC_TaikhoanAdmin : UserControl
    {
        TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

        public UC_TaikhoanAdmin()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            var taiKhoans = taiKhoanBUS.GetAllTaiKhoans();
            dgvTaiKhoan.Rows.Clear();
            foreach (var tk in taiKhoans)
            {
                dgvTaiKhoan.Rows.Add(tk.Id, tk.HoTen, tk.Email, tk.NgayTaoTaiKhoan?.ToString("dd/MM/yyyy"), tk.VaiTro.TenVaiTro);
            }
        }

        // Đổ dữ liệu "Admin" và "Nhân viên" vào ComboBox
        private void PopulateRoleFilter()
        {
            cbbLocTheoVaiTro.Items.Add("Admin");
            cbbLocTheoVaiTro.Items.Add("Nhân viên");
            cbbLocTheoVaiTro.SelectedIndex = 0; // Mặc định chọn vai trò đầu tiên
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Khởi tạo form fThemTaiKhoan
            fThemTaiKhoan formThemTaiKhoan = new fThemTaiKhoan();

            // Hiển thị form dưới dạng modal (chặn form hiện tại cho đến khi form này đóng)
            formThemTaiKhoan.ShowDialog();

            // Nếu muốn cập nhật lại danh sách tài khoản sau khi thêm, gọi phương thức LoadData hoặc tương tự
            LoadData();
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }        

        private void cbbLocTheoVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedRole = cbbLocTheoVaiTro.SelectedItem.ToString();
            var filteredTaiKhoans = taiKhoanBUS.GetTaiKhoansByVaiTro(selectedRole);
            dgvTaiKhoan.Rows.Clear();
            foreach (var tk in filteredTaiKhoans)
            {
                dgvTaiKhoan.Rows.Add(tk.Id, tk.HoTen, tk.Email, tk.NgayTaoTaiKhoan?.ToString("dd/MM/yyyy"), tk.VaiTro.TenVaiTro);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy Id từ cột đầu tiên
                int id = Convert.ToInt32(dgvTaiKhoan.Rows[e.RowIndex].Cells["Column1"].Value);

                // Khởi tạo và truyền Id sang form fUpdateTaiKhoan
                fUpdateTaiKhoan formUpdate = new fUpdateTaiKhoan(id, ReloadData);
                formUpdate.ShowDialog();

                // Cập nhật lại DataGridView sau khi sửa/xóa
                LoadData();
            }
        }

        private void UC_TaikhoanAdmin_Load(object sender, EventArgs e)
        {
            LoadData();
            PopulateRoleFilter();
        }

        public void ReloadData() { LoadData(); }    
    }
}
