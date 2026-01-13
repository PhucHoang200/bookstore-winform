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
    public partial class UC_NhacungcapAdmin : UserControl
    {
        private readonly NhaCungCapBUS _bus;
        private int selectedMaNCC = -1;

        public UC_NhacungcapAdmin()
        {
            InitializeComponent();
            _bus = new NhaCungCapBUS();
            LoadData();
        }

        private void LoadData()
        {
            // Xóa tất cả các hàng hiện tại trong DataGridView
            dgvNhaCungCap.Rows.Clear();

            // Lấy danh sách nhà cung cấp từ BLL
            var nhaCungCapList = _bus.GetAllNhaCungCap();

            // Thêm từng nhà cung cấp vào DataGridView
            foreach (var ncc in nhaCungCapList)
            {
                dgvNhaCungCap.Rows.Add(ncc.Id, ncc.TenNCC);
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy giá trị từ các ô trong hàng được chọn
                selectedMaNCC = Convert.ToInt32(dgvNhaCungCap.Rows[e.RowIndex].Cells[0].Value); // Cột "Mã NCC"
                txtTenNCC.Text = dgvNhaCungCap.Rows[e.RowIndex].Cells[1].Value.ToString(); // Cột "Tên NCC"
            }
        }

        private void txtTenNCC_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                if (_bus.IsTenNCCExists(txtTenNCC.Text))
                {
                    MessageBox.Show("Tên nhà cung cấp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_bus.AddNhaCungCap(txtTenNCC.Text))
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (selectedMaNCC > 0 && !string.IsNullOrWhiteSpace(txtTenNCC.Text))
            {
                if (_bus.IsTenNCCExists(txtTenNCC.Text))
                {
                    MessageBox.Show("Tên nhà cung cấp đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (_bus.UpdateNhaCungCap(selectedMaNCC, txtTenNCC.Text))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectedMaNCC > 0)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (_bus.DeleteNhaCungCap(selectedMaNCC))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadData();
                        txtTenNCC.Clear();
                        selectedMaNCC = -1;
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại!");
                    }
                }
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void txtTimkiemNCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemNCC_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiemNCC.Text.Trim();

            if (!string.IsNullOrWhiteSpace(keyword))
            {
                // Lấy danh sách nhà cung cấp theo từ khóa từ BLL
                var filteredList = _bus.SearchNhaCungCap(keyword);

                // Xóa các hàng cũ trong DataGridView
                dgvNhaCungCap.Rows.Clear();

                // Hiển thị danh sách đã lọc vào DataGridView
                foreach (var ncc in filteredList)
                {
                    dgvNhaCungCap.Rows.Add(ncc.Id, ncc.TenNCC);
                }

                // Nếu không tìm thấy kết quả
                if (filteredList.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy nhà cung cấp phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp để tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
