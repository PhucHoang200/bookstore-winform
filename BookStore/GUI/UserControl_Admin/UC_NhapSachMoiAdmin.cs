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
    public partial class UC_NhapSachMoiAdmin : UserControl
    {
        private NhapSachMoiBUS _bus;
        private List<NhapSachViewModel> _phieuNhapList;

        public UC_NhapSachMoiAdmin()
        {
            InitializeComponent();
            _bus = new NhapSachMoiBUS();
            _phieuNhapList = new List<NhapSachViewModel>();
        }

        private void btnThemVaoPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                    string.IsNullOrWhiteSpace(txtTacGia.Text) ||
                    string.IsNullOrWhiteSpace(txtTheLoai.Text) ||
                    string.IsNullOrWhiteSpace(txtNhaXB.Text) ||
                    string.IsNullOrWhiteSpace(txtNamXB.Text) ||
                    string.IsNullOrWhiteSpace(txtDonGiaNhap.Text) ||
                    string.IsNullOrWhiteSpace(txtDonGiaBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số lượng nhập phải lớn hơn 0
                if (numSLNhap.Value <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra đơn giá nhập phải bé hơn đơn giá bán
                if (decimal.Parse(txtDonGiaNhap.Text.Trim()) >= decimal.Parse(txtDonGiaBan.Text.Trim()))
                {
                    MessageBox.Show("Đơn giá nhập phải nhỏ hơn đơn giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng tên sách trong DataGridView (không phân biệt hoa thường)
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    if (row.Cells[0].Value != null &&
                        string.Equals(row.Cells[0].Value.ToString().Trim(), txtTenSach.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Sách đã được thêm vào phiếu. Vui lòng cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Kiểm tra sách đã tồn tại trong cơ sở dữ liệu
                using (var context = new BookStoreDBEntities())
                {
                    if (context.Saches.Any(s => s.TenSach.Trim().ToLower() == txtTenSach.Text.Trim().ToLower()))
                    {
                        MessageBox.Show("Sách đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Nếu tất cả điều kiện hợp lệ, thêm sách vào danh sách và DataGridView
                var model = new NhapSachViewModel
                {
                    TenSach = txtTenSach.Text.Trim(),
                    TenTG = txtTacGia.Text.Trim(),
                    TenTL = txtTheLoai.Text.Trim(),
                    TenNXB = txtNhaXB.Text.Trim(),
                    NamXuatBan = int.Parse(txtNamXB.Text.Trim()),
                    SoLuongNhap = (int)numSLNhap.Value,
                    DonGiaNhap = decimal.Parse(txtDonGiaNhap.Text.Trim()),
                    DonGiaBan = decimal.Parse(txtDonGiaBan.Text.Trim())
                };

                model.ThanhTien = model.SoLuongNhap * model.DonGiaNhap;
                _phieuNhapList.Add(model);
                dgvChitietPhieunhap.Rows.Add(model.TenSach, model.TenTG, model.TenTL, model.TenNXB, model.NamXuatBan, model.SoLuongNhap, model.DonGiaNhap, model.DonGiaBan, model.ThanhTien);
                lblTinhTongTien.Text = _phieuNhapList.Sum(x => x.ThanhTien).ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra các trường bắt buộc
                if (string.IsNullOrWhiteSpace(txtTenSach.Text) ||
                    string.IsNullOrWhiteSpace(txtTacGia.Text) ||
                    string.IsNullOrWhiteSpace(txtTheLoai.Text) ||
                    string.IsNullOrWhiteSpace(txtNhaXB.Text) ||
                    string.IsNullOrWhiteSpace(txtNamXB.Text) ||
                    string.IsNullOrWhiteSpace(txtDonGiaNhap.Text) ||
                    string.IsNullOrWhiteSpace(txtDonGiaBan.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra số lượng nhập phải lớn hơn 0
                if (numSLNhap.Value <= 0)
                {
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra đơn giá nhập phải bé hơn đơn giá bán
                if (decimal.Parse(txtDonGiaNhap.Text.Trim()) >= decimal.Parse(txtDonGiaBan.Text.Trim()))
                {
                    MessageBox.Show("Đơn giá nhập phải nhỏ hơn đơn giá bán!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra trùng tên sách trong DataGridView (không phải chính hàng hiện tại, không phân biệt hoa thường)
                int selectedRowIndex = dgvChitietPhieunhap.CurrentRow?.Index ?? -1;
                for (int i = 0; i < dgvChitietPhieunhap.Rows.Count; i++)
                {
                    if (i != selectedRowIndex &&
                        dgvChitietPhieunhap.Rows[i].Cells[0].Value != null &&
                        string.Equals(dgvChitietPhieunhap.Rows[i].Cells[0].Value.ToString().Trim(), txtTenSach.Text.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Sách đã được thêm vào phiếu. Vui lòng cập nhật hàng khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Kiểm tra sách đã tồn tại trong cơ sở dữ liệu
                using (var context = new BookStoreDBEntities())
                {
                    if (context.Saches.Any(s => s.TenSach.Trim().ToLower() == txtTenSach.Text.Trim().ToLower()))
                    {
                        MessageBox.Show("Sách đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // Cập nhật dữ liệu trong hàng được chọn
                if (selectedRowIndex >= 0)
                {
                    var row = dgvChitietPhieunhap.Rows[selectedRowIndex];

                    // Cập nhật dữ liệu trong hàng
                    row.Cells[0].Value = txtTenSach.Text.Trim();
                    row.Cells[1].Value = txtTacGia.Text.Trim();
                    row.Cells[2].Value = txtTheLoai.Text.Trim();
                    row.Cells[3].Value = txtNhaXB.Text.Trim();
                    row.Cells[4].Value = int.Parse(txtNamXB.Text.Trim());
                    row.Cells[5].Value = (int)numSLNhap.Value;
                    row.Cells[6].Value = decimal.Parse(txtDonGiaNhap.Text.Trim());
                    row.Cells[7].Value = decimal.Parse(txtDonGiaBan.Text.Trim());
                    row.Cells[8].Value = (int)numSLNhap.Value * decimal.Parse(txtDonGiaNhap.Text.Trim());

                    // Tính toán tổng tiền cho phiếu nhập
                    decimal tongTien = 0;
                    foreach (DataGridViewRow r in dgvChitietPhieunhap.Rows)
                    {
                        tongTien += Convert.ToDecimal(r.Cells["Column9"].Value);
                    }

                    // Cập nhật tổng tiền vào label lblTinhTongTien
                    lblTinhTongTien.Text = $"{tongTien:N2}";  // Định dạng tiền tệ

                    MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNhaXB.Clear();
            txtNamXB.Clear();
            numSLNhap.Value = 0;
            txtDonGiaBan.Clear();
            txtDonGiaNhap.Clear();
            txtNCC.Clear();
        }

        private void btnLuuPhieuNhap_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu dgvChitietPhieunhap trống
                if (dgvChitietPhieunhap.Rows.Count == 0 || dgvChitietPhieunhap.Rows.Cast<DataGridViewRow>().All(row => row.IsNewRow))
                {
                    MessageBox.Show("Chi tiết phiếu nhập không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra nếu txtNCC trống
                string tenNCC = txtNCC.Text.Trim();
                if (string.IsNullOrEmpty(tenNCC))
                {
                    MessageBox.Show("Tên nhà cung cấp không được để trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNCC.Focus();
                    return;
                }

                // Lưu nhà cung cấp và lấy mã nhà cung cấp
                int nhaCungCapId = LuuNhaCungCap(tenNCC);

                // Lưu phiếu nhập và gắn mã nhà cung cấp
                int phieuNhapId = LuuPhieuNhapSach(nhaCungCapId);
                foreach (DataGridViewRow row in dgvChitietPhieunhap.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string tenSach = row.Cells["Column1"].Value?.ToString();
                        string tenTacGia = row.Cells["Column2"].Value?.ToString();
                        string tenTheLoai = row.Cells["Column3"].Value?.ToString();
                        string tenNXB = row.Cells["Column4"].Value?.ToString();

                        int namXuatBan = 0;
                        if (!int.TryParse(row.Cells["Column5"].Value?.ToString(), out namXuatBan))
                        {
                            MessageBox.Show("Năm xuất bản không hợp lệ.");
                            continue;
                        }

                        int soLuongNhap = 0;
                        if (!int.TryParse(row.Cells["Column6"].Value?.ToString(), out soLuongNhap))
                        {
                            MessageBox.Show("Số lượng nhập không hợp lệ.");
                            continue;
                        }

                        decimal giaNhap = 0;
                        if (!decimal.TryParse(row.Cells["Column7"].Value?.ToString(), out giaNhap))
                        {
                            MessageBox.Show("Giá nhập không hợp lệ.");
                            continue;
                        }

                        decimal giaBan = 0;
                        if (!decimal.TryParse(row.Cells["Column8"].Value?.ToString(), out giaBan))
                        {
                            MessageBox.Show("Giá bán không hợp lệ.");
                            continue;
                        }

                        decimal thanhTien = 0;
                        if (!decimal.TryParse(row.Cells["Column9"].Value?.ToString(), out thanhTien))
                        {
                            MessageBox.Show("Thành tiền không hợp lệ.");
                            continue;
                        }
                        
                        int tacGiaId = LuuTacGia(tenTacGia);
                        int theLoaiId = LuuTheLoai(tenTheLoai);
                        int nhaXbId = LuuNhaXuatBan(tenNXB);

                        List<int> tacGiaIds = new List<int> { tacGiaId };
                        List<int> theLoaiIds = new List<int> { theLoaiId };
                        List<int> nhaCungCapIds = new List<int> { nhaCungCapId };

                        int sachId = LuuSach(tenSach, namXuatBan, nhaXbId, tacGiaIds, theLoaiIds, nhaCungCapIds);

                        LuuCTPhieuNhap(phieuNhapId, sachId, soLuongNhap, giaNhap, giaBan, thanhTien);
                        LuuKho(sachId, soLuongNhap, giaNhap, giaBan);

                    }
                }


                ClearAll();
                MessageBox.Show("Phiếu nhập đã được lưu thành công!");
            }
            catch (Exception ex)
            {
                string errorMessage = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show("Lỗi khi lưu phiếu nhập: " + errorMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int LuuTacGia(string tenTacGia)
        {
            using (var context = new BookStoreDBEntities())
            {
                var tacGia = context.TacGias.FirstOrDefault(tg => tg.TenTG == tenTacGia);
                if (tacGia != null)
                {
                    // Hiển thị thông báo xác nhận nếu tác giả đã tồn tại
                    var result = MessageBox.Show(
                        $"Tác giả \"{tenTacGia}\" đã tồn tại. Bạn có muốn tiếp tục sử dụng tác giả này không?",
                        "Xác nhận",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.OK)
                    {
                        return tacGia.Id; // Trả về Id nếu người dùng chọn "OK"
                    }
                    else
                    {
                        // Người dùng hủy hành động
                        return -1; // Hoặc xử lý theo logic của bạn
                    }
                }

                // Thêm mới nếu chưa tồn tại
                tacGia = new TacGia { TenTG = tenTacGia };
                context.TacGias.Add(tacGia);
                context.SaveChanges();
                return tacGia.Id;
            }
        }

        private int LuuTheLoai(string tenTheLoai)
        {
            using (var context = new BookStoreDBEntities())
            {
                var theLoai = context.TheLoais.FirstOrDefault(tl => tl.TenTL == tenTheLoai);
                if (theLoai != null)
                {
                    var result = MessageBox.Show(
                        $"Thể loại \"{tenTheLoai}\" đã tồn tại. Bạn có muốn tiếp tục sử dụng thể loại này không?",
                        "Xác nhận",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.OK)
                    {
                        return theLoai.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }

                theLoai = new TheLoai { TenTL = tenTheLoai };
                context.TheLoais.Add(theLoai);
                context.SaveChanges();
                return theLoai.Id;
            }
        }

        private int LuuNhaXuatBan(string tenNhaXuatBan)
        {
            using (var context = new BookStoreDBEntities())
            {
                var nhaXb = context.NhaXuatBans.FirstOrDefault(nxb => nxb.TenNXB == tenNhaXuatBan);
                if (nhaXb != null)
                {
                    var result = MessageBox.Show(
                        $"Nhà xuất bản \"{tenNhaXuatBan}\" đã tồn tại. Bạn có muốn tiếp tục sử dụng nhà xuất bản này không?",
                        "Xác nhận",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.OK)
                    {
                        return nhaXb.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }

                nhaXb = new NhaXuatBan { TenNXB = tenNhaXuatBan };
                context.NhaXuatBans.Add(nhaXb);
                context.SaveChanges();
                return nhaXb.Id;
            }
        }

        private int LuuNhaCungCap(string tenNhaCungCap)
        {
            using (var context = new BookStoreDBEntities())
            {
                var nhaCungCap = context.NhaCungCaps.FirstOrDefault(ncc => ncc.TenNCC == tenNhaCungCap);
                if (nhaCungCap != null)
                {
                    var result = MessageBox.Show(
                        $"Nhà cung cấp \"{tenNhaCungCap}\" đã tồn tại. Bạn có muốn tiếp tục sử dụng nhà cung cấp này không?",
                        "Xác nhận",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Information
                    );

                    if (result == DialogResult.OK)
                    {
                        return nhaCungCap.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }

                nhaCungCap = new NhaCungCap { TenNCC = tenNhaCungCap };
                context.NhaCungCaps.Add(nhaCungCap);
                context.SaveChanges();
                return nhaCungCap.Id;
            }
        }

        private int LuuSach(string tenSach, int namXuatBan, int nhaXbId, List<int> tacGiaIds, List<int> theLoaiIds, List<int> nhaCungCapIds)
        {
            // Thêm sách vào bảng Sach và trả về Id
            using (var context = new BookStoreDBEntities())
            {
                var sach = new Sach
                {
                    TenSach = tenSach,
                    NamXuatBan = namXuatBan,
                    IdNXB = nhaXbId
                };
                context.Saches.Add(sach);
                context.SaveChanges();

                // Liên kết tác giả, thể loại và nhà cung cấp
                foreach (var tacGiaId in tacGiaIds)
                {
                    sach.TacGias.Add(context.TacGias.FirstOrDefault(t => t.Id == tacGiaId)); // Tác giả liên kết
                }

                foreach (var theLoaiId in theLoaiIds)
                {
                    sach.TheLoais.Add(context.TheLoais.FirstOrDefault(t => t.Id == theLoaiId)); // Thể loại liên kết
                }

                foreach (var nhaCungCapId in nhaCungCapIds)
                {
                    sach.NhaCungCaps.Add(context.NhaCungCaps.FirstOrDefault(n => n.Id == nhaCungCapId)); // Nhà cung cấp liên kết
                }

                context.SaveChanges();
                return sach.Id;
            }
        }

        private void LuuKho(int sachId, int soLuongTon, decimal donGiaNhap, decimal donGiaBan)
        {
            // Lưu thông tin vào bảng Kho
            using (var context = new BookStoreDBEntities())
            {
                var kho = new Kho
                {
                    IdSach = sachId,
                    SoLuongTon = soLuongTon,
                    DonGiaNhap = donGiaNhap,
                    DonGiaBan = donGiaBan
                };
                context.Khoes.Add(kho);
                context.SaveChanges();
            }
        }

        private int LuuPhieuNhapSach(int nhaCungCapId)
        {
            // Lấy giá trị từ lblTinhTongTien
            if (!decimal.TryParse(lblTinhTongTien.Text, out decimal tongTien))
            {
                throw new Exception("Giá trị tổng tiền không hợp lệ. Vui lòng kiểm tra lại.");
            }

            // Lưu phiếu nhập vào bảng PhieuNhapSach và trả về Id
            using (var context = new BookStoreDBEntities())
            {
                var phieuNhap = new PhieuNhapSach
                {
                    MaNCC = nhaCungCapId,
                    TongTienNhap = tongTien,                    
                    NgayNhapSach = DateTime.Now // Lưu ngày hiện tại
                };
                context.PhieuNhapSaches.Add(phieuNhap);
                context.SaveChanges();
                return phieuNhap.Id;
            }
        }

        private void LuuCTPhieuNhap(int phieuNhapId, int sachId, int soLuongNhap, decimal donGiaNhap, decimal donGiaBan, decimal thanhTien)
        {
            // Lưu chi tiết phiếu nhập vào bảng CT_PhieuNhap
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


        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu không có hàng nào được chọn
                if (dgvChitietPhieunhap.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Lấy hàng được chọn
                var selectedRow = dgvChitietPhieunhap.SelectedRows[0];

                // Xác nhận trước khi xóa
                var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Xóa hàng trong danh sách _phieuNhapList nếu cần
                    string tenSach = selectedRow.Cells["TenSach"].Value.ToString();
                    var itemToRemove = _phieuNhapList.FirstOrDefault(x => x.TenSach == tenSach);
                    if (itemToRemove != null)
                    {
                        _phieuNhapList.Remove(itemToRemove);
                    }

                    // Xóa hàng trong DataGridView
                    dgvChitietPhieunhap.Rows.Remove(selectedRow);

                    // Cập nhật tổng tiền
                    lblTinhTongTien.Text = _phieuNhapList.Sum(x => x.ThanhTien).ToString("N2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTacGia_Leave(object sender, EventArgs e)
        {
            string tacGia = txtTacGia.Text.Trim();

            // Kiểm tra tác giả có tồn tại không
            if (_bus.KiemTraTacGiaTonTai(tacGia))
            {
                MessageBox.Show("Tác giả này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Nếu không tồn tại, không cần thông báo
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTheLoai_Leave(object sender, EventArgs e)
        {
            string theLoai = txtTheLoai.Text.Trim();

            if (_bus.KiemTraTheLoaiTonTai(theLoai))
            {
                MessageBox.Show("Thể loại này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNhaXB_Leave(object sender, EventArgs e)
        {
            string nhaXB = txtNhaXB.Text.Trim();

            if (_bus.KiemTraNhaXBTonTai(nhaXB))
            {
                MessageBox.Show("Nhà xuất bản này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNCC_Leave(object sender, EventArgs e)
        {
            string nhaCungCap = txtNCC.Text.Trim();

            if (_bus.KiemTraNCCTonTai(nhaCungCap))
            {
                MessageBox.Show("Nhà cung cấp này đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvChitietPhieunhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra nếu hàng được click hợp lệ
                if (e.RowIndex >= 0 && e.RowIndex < dgvChitietPhieunhap.Rows.Count)
                {
                    var selectedRow = dgvChitietPhieunhap.Rows[e.RowIndex];

                    // Truyền dữ liệu từ hàng được chọn vào các textbox
                    txtTenSach.Text = selectedRow.Cells["Column1"].Value?.ToString() ?? string.Empty;
                    txtTacGia.Text = selectedRow.Cells["Column2"].Value?.ToString() ?? string.Empty;
                    txtTheLoai.Text = selectedRow.Cells["Column3"].Value?.ToString() ?? string.Empty;
                    txtNhaXB.Text = selectedRow.Cells["Column4"].Value?.ToString() ?? string.Empty;
                    txtNamXB.Text = selectedRow.Cells["Column5"].Value?.ToString() ?? string.Empty;

                    // Truyền giá trị số lượng và giá
                    numSLNhap.Value = Convert.ToDecimal(selectedRow.Cells["Column6"].Value ?? 0);
                    txtDonGiaNhap.Text = selectedRow.Cells["Column7"].Value?.ToString() ?? string.Empty;
                    txtDonGiaBan.Text = selectedRow.Cells["Column8"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearAll()
        {
            // Xóa tất cả các TextBox
            txtTenSach.Clear();
            txtTacGia.Clear();
            txtTheLoai.Clear();
            txtNhaXB.Clear();
            txtNamXB.Clear();
            txtDonGiaNhap.Clear();
            txtDonGiaBan.Clear();
            txtNCC.Clear();

            // Đặt lại giá trị của numSLNhap về mặc định (0)
            numSLNhap.Value = 0;

            // Xóa dữ liệu trong DataGridView
            dgvChitietPhieunhap.Rows.Clear();
            lblTinhTongTien.Text = string.Empty;
        }

    }
}
