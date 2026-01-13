using BUS;
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

namespace GUI.UserControl_Admin
{
    public partial class UC_NhapSachDaCo : UserControl
    {
        private NhapSachDaCoBUS _bus = new NhapSachDaCoBUS();
        private List<CT_PhieuNhap> _chiTietPhieuNhapList = new List<CT_PhieuNhap>();

        public UC_NhapSachDaCo()
        {
            InitializeComponent();
        }


        private void UC_NhapSachDaCo_Load(object sender, EventArgs e)
        {
            //LoadSachToComboBox();
            LoadNhaCungCapToComboBox();
        }

        private void LoadNhaCungCapToComboBox()
        {
            var nhaCungCapList = _bus.GetAllNhaCungCap();  // Lấy tất cả nhà cung cấp
            cbbLocNCC.DataSource = nhaCungCapList;
            cbbLocNCC.DisplayMember = "TenNCC";
            cbbLocNCC.ValueMember = "Id";
        }

        private void cbbTenSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTenSach.SelectedValue is int selectedId)
            {
                var sachDetails = _bus.GetSachDetails(selectedId);
                if (sachDetails != null)
                {
                    txtTacGia.Text = sachDetails.TenTG;
                    txtTheLoai.Text = sachDetails.TenTL;
                    txtNXB.Text = sachDetails.TenNXB;
                    txtNamXB.Text = sachDetails.NamXuatBan.ToString();
                    txtDonGiaNhap.Text = sachDetails.DonGiaNhap.ToString();
                    txtDonGiaBan.Text = sachDetails.DonGiaBan.ToString();
                }
            }
        }

        private void btnThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(txtDonGiaNhap.Text) || string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giá nhập và giá bán.");
                return;
            }

            if (numSLNhap.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.");
                return;
            }

            // Kiểm tra giá nhập phải bé hơn hoặc bằng giá bán
            if (Convert.ToDecimal(txtDonGiaNhap.Text) > Convert.ToDecimal(txtDonGiaBan.Text))
            {
                MessageBox.Show("Giá nhập không thể lớn hơn giá bán.");
                return;
            }

            // Lấy mã sách từ SelectedValue (nếu đã thiết lập ValueMember là mã sách)
            if (cbbTenSach.SelectedValue is int selectedSachId)
            {
                var tenSach = cbbTenSach.Text; // Lấy tên sách từ ComboBox (SelectedItem là tên sách)
                int selectedNCCId = (int)cbbLocNCC.SelectedValue; // Lấy ID nhà cung cấp từ cbbLocNCC

                // Kiểm tra nếu sách đã có trong DataGridView
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    if (row.Cells["Column1"].Value.ToString() == tenSach)  // Kiểm tra tên sách đã có chưa
                    {
                        MessageBox.Show("Sách này đã được thêm vào phiếu nhập. Vui lòng cập nhật thông tin.");
                        return;
                    }

                    // Kiểm tra nếu đã có sách và ID nhà cung cấp khác
                    int nhaCungCapIdInRow = Convert.ToInt32(row.Cells["Column9"].Value);  // Cột ID nhà cung cấp trong DataGridView
                    if (nhaCungCapIdInRow != selectedNCCId)
                    {
                        MessageBox.Show("Các sách trong phiếu nhập phải cùng một nhà cung cấp. Vui lòng kiểm tra lại.");
                        return;
                    }
                }

                // Tạo chi tiết phiếu nhập
                var chiTiet = new CT_PhieuNhap
                {
                    SoLuongNhap = (int)numSLNhap.Value,
                    DonGiaNhap = Convert.ToDecimal(txtDonGiaNhap.Text),
                    DonGiaBan = Convert.ToDecimal(txtDonGiaBan.Text),
                    MaSach = selectedSachId, // Lưu mã sách vào chi tiết phiếu nhập
                };

                // Tính thành tiền cho sách này
                decimal thanhTien = chiTiet.SoLuongNhap * chiTiet.DonGiaNhap;

                // Thêm chi tiết vào danh sách tạm thời
                _chiTietPhieuNhapList.Add(chiTiet);

                // Tính toán tổng tiền cho phiếu nhập
                decimal tongTien = _chiTietPhieuNhapList.Sum(ct => ct.SoLuongNhap * ct.DonGiaNhap);

                // Cập nhật tổng tiền vào label lblTinhTongTien
                lblTinhTongTien.Text = $"{tongTien:N2}";  // Định dạng tiền tệ

                // Thêm vào DataGridView
                dgvChitietPhieunhap.Rows.Add(
                    tenSach,               // Tên sách (lấy từ cbbTenSach.Text)
                    txtTacGia.Text,        // Tác giả
                    txtTheLoai.Text,       // Thể loại
                    txtNXB.Text,           // Nhà xuất bản
                    txtNamXB.Text,         // Năm xuất bản
                    numSLNhap.Value,       // Số lượng nhập
                    txtDonGiaNhap.Text,    // Đơn giá nhập
                    txtDonGiaBan.Text,     // Đơn giá bán
                    selectedNCCId,          // ID nhà cung cấp (lưu vào cột trước thành tiền)
                    thanhTien             // Thành tiền

                );

                MessageBox.Show("Thêm sách vào phiếu nhập thành công!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách.");
            }
        }

        private void dgvChitietPhieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu người dùng click vào một hàng (không phải tiêu đề)
            if (e.RowIndex >= 0)
            {
                // Lấy thông tin từ hàng đã click
                var row = dgvChitietPhieunhap.Rows[e.RowIndex];

                // Cập nhật thông tin vào các TextBox và ComboBox tương ứng
                cbbTenSach.Text = row.Cells["Column1"].Value.ToString();
                txtTacGia.Text = row.Cells["Column2"].Value.ToString();
                txtTheLoai.Text = row.Cells["Column3"].Value.ToString();
                txtNXB.Text = row.Cells["Column4"].Value.ToString();
                txtNamXB.Text = row.Cells["Column5"].Value.ToString();
                numSLNhap.Value = Convert.ToDecimal(row.Cells["Column6"].Value);
                txtDonGiaNhap.Text = row.Cells["Column7"].Value.ToString();
                txtDonGiaBan.Text = row.Cells["Column8"].Value.ToString();
            }
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường nhập liệu
            if (string.IsNullOrEmpty(txtDonGiaNhap.Text) || string.IsNullOrEmpty(txtDonGiaBan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin giá nhập và giá bán.");
                return;
            }

            if (numSLNhap.Value <= 0)
            {
                MessageBox.Show("Số lượng nhập phải lớn hơn 0.");
                return;
            }

            // Kiểm tra giá nhập phải bé hơn hoặc bằng giá bán
            if (Convert.ToDecimal(txtDonGiaNhap.Text) > Convert.ToDecimal(txtDonGiaBan.Text))
            {
                MessageBox.Show("Giá nhập không thể lớn hơn giá bán.");
                return;
            }

            // Kiểm tra nếu sách đã được chọn
            if (cbbTenSach.SelectedValue is int selectedSachId)
            {
                var tenSach = cbbTenSach.Text; // Lấy tên sách từ ComboBox

                // Duyệt qua danh sách chi tiết phiếu nhập để cập nhật thông tin
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    // Kiểm tra xem sách có tên tương ứng với tên sách đã chọn
                    if (row.Cells["Column1"].Value.ToString() == tenSach)
                    {
                        // Cập nhật thông tin vào dòng tương ứng
                        row.Cells["Column2"].Value = txtTacGia.Text;
                        row.Cells["Column3"].Value = txtTheLoai.Text;
                        row.Cells["Column4"].Value = txtNXB.Text;
                        row.Cells["Column5"].Value = txtNamXB.Text;
                        row.Cells["Column6"].Value = numSLNhap.Value;
                        row.Cells["Column7"].Value = txtDonGiaNhap.Text;
                        row.Cells["Column8"].Value = txtDonGiaBan.Text;

                        // Tính lại thành tiền cho sách này
                        decimal thanhTien = (decimal)numSLNhap.Value * Convert.ToDecimal(txtDonGiaNhap.Text);
                        row.Cells["Column10"].Value = thanhTien;

                        // Tính toán tổng tiền cho phiếu nhập
                        decimal tongTien = 0;
                        foreach (DataGridViewRow r in dgvChitietPhieunhap.Rows)
                        {
                            tongTien += Convert.ToDecimal(r.Cells["Column10"].Value);
                        }

                        // Cập nhật tổng tiền vào label lblTinhTongTien
                        lblTinhTongTien.Text = $"{tongTien:N2}";  // Định dạng tiền tệ

                        MessageBox.Show("Cập nhật thông tin sách thành công!");
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sách để cập nhật.");
            }
        }   

        private void btnHuy_Click(object sender, EventArgs e)
        {
            numSLNhap.Value = 0;
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Loại bỏ phần không phải số trong lblTinhTongTien.Text
                string totalText = lblTinhTongTien.Text.Replace("Tổng Tiền: ", "").Replace(",", "").Trim();

                // Kiểm tra tổng tiền có hợp lệ hay không
                if (!decimal.TryParse(totalText, out decimal tongTien) || tongTien <= 0)
                {
                    MessageBox.Show("Tổng tiền không hợp lệ hoặc bằng 0. Vui lòng kiểm tra lại.");
                    return;
                }

                // Kiểm tra danh sách chi tiết phiếu nhập
                if (dgvChitietPhieunhap.Rows.Count == 0)
                {
                    MessageBox.Show("Danh sách chi tiết phiếu nhập trống. Vui lòng thêm sách trước khi lưu.");
                    return;
                }

                int? nhaCungCapId = null;
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Kiểm tra xem ô có giá trị hay không
                    if (row.Cells["Column9"].Value != null)
                    {
                        // Lấy ID nhà cung cấp từ cột "Mã nhà cung cấp"
                        int currentNCCId;
                        if (int.TryParse(row.Cells["Column9"].Value.ToString(), out currentNCCId))
                        {
                            // Nếu chưa có nhà cung cấp, gán nhà cung cấp từ sách đầu tiên
                            if (nhaCungCapId == null)
                            {
                                nhaCungCapId = currentNCCId;
                            }
                            else if (nhaCungCapId != currentNCCId)
                            {
                                // Nếu có sách có nhà cung cấp khác, thông báo lỗi và dừng lại
                                MessageBox.Show("Các sách trong phiếu nhập phải cùng một nhà cung cấp. Vui lòng kiểm tra lại.");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã nhà cung cấp không hợp lệ.");
                            return;
                        }
                    }
                }

                // Nếu không tìm thấy nhà cung cấp hoặc nhà cung cấp không hợp lệ
                if (nhaCungCapId == null)
                {
                    MessageBox.Show("Không thể xác định nhà cung cấp cho phiếu nhập.");
                    return;
                }

                // Lưu phiếu nhập và lấy ID của phiếu nhập vừa lưu
                int phieuNhapId = _bus.SavePhieuNhap(nhaCungCapId.Value, tongTien);

                if (phieuNhapId <= 0) // Kiểm tra nếu ID phiếu nhập không hợp lệ
                {
                    MessageBox.Show("Lỗi khi tạo phiếu nhập. Vui lòng kiểm tra lại.");
                    return;
                }

                // Lưu chi tiết phiếu nhập
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Kiểm tra giá trị trước khi chuyển đổi
                    if (row.Cells["Column1"].Value == null || row.Cells["Column6"].Value == null || row.Cells["Column7"].Value == null || row.Cells["Column8"].Value == null || row.Cells["Column10"].Value == null)
                    {
                        MessageBox.Show("Một hoặc nhiều ô không có giá trị hợp lệ. Vui lòng kiểm tra lại.");
                        return;
                    }

                    // Lấy tên sách từ cột "Column1"
                    string tenSach = row.Cells["Column1"].Value.ToString();

                    // Tra cứu IdSach từ tên sách
                    int sachId = GetSachIdByName(tenSach); // Phương thức này sẽ trả về Id của sách

                    if (sachId == 0)
                    {
                        MessageBox.Show($"Không tìm thấy sách với tên {tenSach}. Vui lòng kiểm tra lại.");
                        return;
                    }
                    // Chuyển đổi giá trị từ các ô trong DataGridView
                    if (
                        !int.TryParse(row.Cells["Column6"].Value.ToString(), out int soLuongNhap) ||
                        !decimal.TryParse(row.Cells["Column7"].Value.ToString(), out decimal donGiaNhap) ||
                        !decimal.TryParse(row.Cells["Column8"].Value.ToString(), out decimal donGiaBan) ||
                        !decimal.TryParse(row.Cells["Column10"].Value.ToString(), out decimal thanhTien))
                    {
                        MessageBox.Show("Dữ liệu không hợp lệ trong các ô. Vui lòng kiểm tra lại.");
                        return;
                    }

                    // Lưu chi tiết phiếu nhập
                    LuuCTPhieuNhap(phieuNhapId, sachId, soLuongNhap, donGiaNhap, donGiaBan, thanhTien);
                }

                // Hiển thị thông báo thành công
                MessageBox.Show($"Lưu phiếu nhập thành công! Mã phiếu nhập: {phieuNhapId}");

                // Xóa dữ liệu trong DataGridView và reset tổng tiền
                ClearAll();
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi trong quá trình lưu phiếu nhập: {ex.Message}");
            }
        }

        private void LuuCTPhieuNhap(int phieuNhapId, int sachId, int soLuongNhap, decimal donGiaNhap, decimal donGiaBan, decimal thanhTien)
        {
            try
            {
                if (phieuNhapId <= 0) // Kiểm tra phieuNhapId hợp lệ
                {
                    MessageBox.Show("Mã phiếu nhập không hợp lệ.");
                    return;
                }

                using (var context = new BookStoreDBEntities())
                {
                    var ctPhieuNhap = new CT_PhieuNhap
                    {
                        MaPhieuNhap = phieuNhapId,
                        MaSach = sachId,
                        SoLuongNhap = soLuongNhap,
                        DonGiaNhap = donGiaNhap,
                        DonGiaBan = donGiaBan,
                        ThanhTien = thanhTien
                    };

                    context.CT_PhieuNhap.Add(ctPhieuNhap);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu chi tiết phiếu nhập: {ex.Message}");
            }
        }

        // Phương thức để tra cứu IdSach dựa trên tên sách
        private int GetSachIdByName(string tenSach)
        {
            using (var context = new BookStoreDBEntities())
            {
                // Tra cứu sách theo tên
                var sach = context.Saches.FirstOrDefault(s => s.TenSach == tenSach);
                return sach?.Id ?? 0; // Nếu không tìm thấy sách, trả về 0
            }
        }

        private int GetNhaCungCapIdByName(string tenNCC)
        {
            using (var context = new BookStoreDBEntities())
            {
                // Tìm nhà cung cấp theo tên
                var nhaCungCap = context.NhaCungCaps
                    .Where(ncc => ncc.TenNCC.Equals(tenNCC, StringComparison.OrdinalIgnoreCase))
                    .FirstOrDefault();

                // Nếu tìm thấy, trả về Id của nhà cung cấp
                if (nhaCungCap != null)
                {
                    return nhaCungCap.Id;
                }

                // Nếu không tìm thấy, trả về -1 để báo lỗi
                return -1;
            }
        }

        private int GetNhaCungCapIdForSach(int sachId)
        {
            using (var context = new BookStoreDBEntities())
            {
                // Tìm nhà cung cấp của sách dựa trên mã sách thông qua bảng trung gian
                var sach = context.Saches
                    .Where(s => s.Id == sachId)
                    .SelectMany(s => s.NhaCungCaps)  // Lấy danh sách nhà cung cấp của sách qua mối quan hệ nhiều-nhiều
                    .FirstOrDefault();  // Lấy nhà cung cấp đầu tiên liên kết với sách

                if (sach != null)
                {
                    return sach.Id; // Trả về mã nhà cung cấp của sách
                }

                // Nếu không tìm thấy nhà cung cấp, trả về -1 để báo lỗi
                return -1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra xem có dòng nào được chọn trong DataGridView không
                if (dgvChitietPhieunhap.SelectedRows.Count > 0)
                {
                    // Xóa dòng đã chọn
                    foreach (DataGridViewRow row in dgvChitietPhieunhap.SelectedRows)
                    {
                        // Xóa dòng
                        dgvChitietPhieunhap.Rows.RemoveAt(row.Index);
                    }
                    // Thông báo xóa thành công
                    MessageBox.Show("Xóa hàng thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng cần xóa!");
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi
                MessageBox.Show($"Lỗi khi xóa hàng: {ex.Message}");
            }
        }

        private void cbbLocNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLocNCC.SelectedValue is int nhaCungCapId)
            {
                LoadSachByNhaCungCap(nhaCungCapId);  // Load sách theo nhà cung cấp
            }
        }

        private void LoadSachByNhaCungCap(int nhaCungCapId)
        {
            var sachList = _bus.GetSachByNhaCungCap(nhaCungCapId);  // Lấy sách của nhà cung cấp
            cbbTenSach.DataSource = sachList;
            cbbTenSach.DisplayMember = "TenSach";
            cbbTenSach.ValueMember = "Id";
        }

        private void ClearAll()
        {
            // Xóa tất cả các TextBox
            cbbTenSach.Items.Clear(); // Xóa toàn bộ mục trong ComboBox
            cbbTenSach.SelectedIndex = -1; // Đặt ComboBox về trạng thái không chọn gì
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNXB.Clear();
            txtNamXB.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            cbbLocNCC.Items.Clear(); // Xóa toàn bộ mục trong ComboBox
            cbbLocNCC.SelectedIndex = -1; // Đặt ComboBox về trạng thái không chọn gì

            // Đặt lại giá trị của numSLNhap về mặc định (0)
            numSLNhap.Value = 0;

            // Xóa dữ liệu trong DataGridView
            dgvChitietPhieunhap.Rows.Clear();
            lblTinhTongTien.Text = string.Empty;
        }
    }
}
