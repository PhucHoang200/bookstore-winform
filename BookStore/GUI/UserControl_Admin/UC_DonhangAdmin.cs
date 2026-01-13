using BUS;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class UC_DonhangAdmin : UserControl
    {

        private readonly DonHangBUS _bus;
        private LoginViewModel currentUser;

        public UC_DonhangAdmin(LoginViewModel loginViewModel)
        {
            InitializeComponent();
            _bus = new DonHangBUS();
            currentUser = loginViewModel;

            // Gán IdTaiKhoan vào txtMaTK khi UC_DonhangAdmin được load
            txtMaTK.Text = currentUser.IdTaiKhoan.ToString();
        }

        private void dgvDsSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra chỉ số hàng hợp lệ
            {
                txtMasach.Text = dgvDsSach.CurrentRow.Cells["Column1"].Value.ToString();
            }
        }

        private void btnHuyKH_Click(object sender, EventArgs e)
        {
            txtHotenKH.Clear();
            txtEmail.Clear();
            txtSĐT.Clear();
            txtDiachi.Clear();
        }

        private void btnCapnhatKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHotenKH.Text))
            {
                MessageBox.Show("Họ tên khách hàng là bắt buộc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_bus.KiemTraEmailTrung(txtEmail.Text))
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtSĐT.Text))
            {
                if (!IsValidPhoneNumber(txtSĐT.Text))
                {
                    //MessageBox.Show("Số điện thoại không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_bus.KiemTraSoDienThoaiTrung(txtSĐT.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Thực hiện cập nhật
            try
            {
                var email = !string.IsNullOrWhiteSpace(txtEmail.Text) ? txtEmail.Text : null;
                var sdt = !string.IsNullOrWhiteSpace(txtSĐT.Text) ? txtSĐT.Text : null;
                var diaChi = !string.IsNullOrWhiteSpace(txtDiachi.Text) ? txtDiachi.Text : null;

                _bus.CapNhatKhachHang(int.Parse(txtMaKH.Text), txtHotenKH.Text, txtEmail.Text, txtSĐT.Text, txtDiachi.Text);
                MessageBox.Show("Cập nhật khách hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHotenKH.Text))
            {
                MessageBox.Show("Họ tên khách hàng là bắt buộc.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_bus.KiemTraEmailTrung(txtEmail.Text))
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (!string.IsNullOrWhiteSpace(txtSĐT.Text))
            {
                if (!IsValidPhoneNumber(txtSĐT.Text))
                {
                    //MessageBox.Show("Số điện thoại không hợp lệ.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_bus.KiemTraSoDienThoaiTrung(txtSĐT.Text))
                {
                    MessageBox.Show("Số điện thoại đã tồn tại. Vui lòng nhập số khác.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                var email = !string.IsNullOrWhiteSpace(txtEmail.Text) ? txtEmail.Text : null;
                var sdt = !string.IsNullOrWhiteSpace(txtSĐT.Text) ? txtSĐT.Text : null;
                var diaChi = !string.IsNullOrWhiteSpace(txtDiachi.Text) ? txtDiachi.Text : null;

                var maKH = _bus.LuuKhachHangVaLayMa(txtHotenKH.Text, email, sdt, diaChi);
                txtMaKH.Text = maKH.ToString();
                MessageBox.Show("Lưu khách hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        // Hàm kiểm tra định dạng email
        private bool IsValidEmail(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return mailAddress.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Hàm kiểm tra định dạng số điện thoại
        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra nếu không phải chuỗi 10 ký tự số hoặc không bắt đầu bằng số 0
            if (!System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^0\d{9}$"))
            {
                MessageBox.Show("Số điện thoại không hợp lệ! Số điện thoại phải bao gồm 10 chữ số và bắt đầu bằng số 0.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnThemDonHang_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMasach.Text) || string.IsNullOrWhiteSpace(txtSoluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sách và số lượng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSach = int.Parse(txtMasach.Text);
                int soLuong = int.Parse(txtSoluong.Text);

                // Tìm thông tin sách từ dgvDsSach
                decimal donGia = 0;
                int soLuongTon = 0;
                var rowFound = dgvDsSach.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["Column1"].Value != null && Convert.ToInt32(r.Cells["Column1"].Value) == maSach);

                if (rowFound != null)
                {
                    donGia = Convert.ToDecimal(rowFound.Cells["Column8"].Value);
                    soLuongTon = Convert.ToInt32(rowFound.Cells["Column7"].Value);
                }

                if (donGia == 0)
                {
                    MessageBox.Show("Không tìm thấy giá sách cho mã sách đã chọn.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (soLuong > soLuongTon)
                {
                    MessageBox.Show($"Số lượng nhập ({soLuong}) vượt quá số lượng tồn ({soLuongTon}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm chi tiết đơn hàng
                _bus.ThemChiTietDonHang(dgvChitietDonhang, maSach, soLuong, donGia);
                txtTongtienDonhang.Text = _bus.TinhTongTien(dgvChitietDonhang).ToString("N0");
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ. Vui lòng kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyDonHang_Click(object sender, EventArgs e)
        {
            txtMasach.Clear();
            txtSoluong.Clear();
            txtTimkiemSach.Clear();
        }

        private void btnCapnhatSach_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMasach.Text) || string.IsNullOrWhiteSpace(txtSoluong.Text))
                {
                    MessageBox.Show("Vui lòng nhập mã sách và số lượng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int maSach = int.Parse(txtMasach.Text);
                int soLuongMoi = int.Parse(txtSoluong.Text);

                // Tìm thông tin sách từ dgvDsSach
                int soLuongTon = 0;
                var rowFound = dgvDsSach.Rows
                    .Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["Column1"].Value != null && Convert.ToInt32(r.Cells["Column1"].Value) == maSach);

                if (rowFound != null)
                {
                    soLuongTon = Convert.ToInt32(rowFound.Cells["Column7"].Value);
                }

                if (soLuongMoi > soLuongTon)
                {
                    MessageBox.Show($"Số lượng mới ({soLuongMoi}) vượt quá số lượng tồn ({soLuongTon}).", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Cập nhật số lượng trong DataGridView chi tiết đơn hàng
                foreach (DataGridViewRow row in dgvChitietDonhang.Rows)
                {
                    if (Convert.ToInt32(row.Cells["Column9"].Value) == maSach)
                    {
                        row.Cells["Column11"].Value = soLuongMoi;
                    }
                }

                txtTongtienDonhang.Text = _bus.TinhTongTien(dgvChitietDonhang).ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvChitietDonhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMasach.Text = dgvChitietDonhang.CurrentRow.Cells["Column9"].Value.ToString();
                txtSoluong.Text = dgvChitietDonhang.CurrentRow.Cells["Column11"].Value.ToString();
            }
        }

        private void btnXoaDonhang_Click(object sender, EventArgs e)
        {
            if (dgvChitietDonhang.SelectedRows.Count > 0)
            {
                dgvChitietDonhang.Rows.RemoveAt(dgvChitietDonhang.SelectedRows[0].Index);
                txtTongtienDonhang.Text = _bus.TinhTongTien(dgvChitietDonhang).ToString("N0");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn hàng để xóa.");
            }
        }

        private void btnLuuDonhang_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng lưu thông tin khách hàng trước khi lưu đơn hàng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra nếu danh sách chi tiết đơn hàng rỗng
            if (dgvChitietDonhang.Rows.Count == 0)
            {
                MessageBox.Show("Chi tiết đơn hàng trống. Vui lòng thêm sản phẩm trước khi lưu.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Thực hiện lưu đơn hàng
                var donHang = new DonHang
                {
                    IdKhachHang = int.Parse(txtMaKH.Text),
                    TongTienBan = decimal.Parse(txtTongtienDonhang.Text),
                    NgayMuaHang = DateTime.Now
                };

                var chiTietDonHangs = new List<CT_DonHang>();
                foreach (DataGridViewRow row in dgvChitietDonhang.Rows)
                {
                    chiTietDonHangs.Add(new CT_DonHang
                    {
                        IdSach = Convert.ToInt32(row.Cells["Column9"].Value),
                        SoLuongBan = Convert.ToInt32(row.Cells["Column11"].Value),
                        DonGiaBan = Convert.ToDecimal(row.Cells["Column10"].Value),
                        IdTaiKhoan = int.Parse(txtMaTK.Text)
                    });
                }

                _bus.LuuDonHang(donHang, chiTietDonHangs);
                MessageBox.Show("Lưu đơn hàng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadSachData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            txtHotenKH.Clear();
            txtMaKH.Clear();
            txtMaTK.Clear();
            txtTongtienDonhang.Clear();
            txtMasach.Clear();
            txtSoluong.Clear();
            dgvChitietDonhang.Rows.Clear();
        }

        private void btnTimkiemSach_Click(object sender, EventArgs e)
        {
            try
            {
                string tuKhoa = txtTimkiemSach.Text.Trim();

                if (string.IsNullOrWhiteSpace(tuKhoa))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Gọi phương thức tìm kiếm từ BUS với từ khóa
                var danhSachSach = _bus.TimKiemSach(tuKhoa);

                if (danhSachSach == null || !danhSachSach.Any())
                {
                    MessageBox.Show("Không tìm thấy sách phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDsSach.Rows.Clear(); // Xóa dữ liệu cũ
                    return;
                }

                // Xóa dữ liệu cũ trước khi thêm mới
                dgvDsSach.Rows.Clear();

                foreach (var sach in danhSachSach)
                {
                    // Lấy thông tin chi tiết của từng sách từ CSDL
                    var tenTacGia = sach.TacGias.Any() ? sach.TacGias.First().TenTG : "Không có tác giả";
                    var tenTheLoai = sach.TheLoais.Any() ? sach.TheLoais.First().TenTL : "Không có thể loại";
                    var tenNXB = sach.NhaXuatBan != null ? sach.NhaXuatBan.TenNXB : "Không có nhà xuất bản";
                    var giaBan = sach.Khoes.Any() ? sach.Khoes.First().DonGiaBan ?? 0 : 0;
                    var soLuongTon = sach.Khoes.Any() ? sach.Khoes.First().SoLuongTon : 0;

                    // Thêm dữ liệu vào DataGridView
                    dgvDsSach.Rows.Add(sach.Id, sach.TenSach, tenTacGia, tenTheLoai, tenNXB, sach.NamXuatBan, soLuongTon, giaBan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void UC_DonhangAdmin_Load(object sender, EventArgs e)
        {
            LoadSachData();
            SetupDataGridView();
        }

        private void LoadSachData()
        {
            try
            {
                // Lấy danh sách sách từ BUS (sử dụng phương thức đã tạo trong DonHangBUS)
                var danhSachSach = _bus.LayDanhSachSach();

                // Đưa dữ liệu vào DataGridView
                dgvDsSach.Rows.Clear();  // Xóa tất cả các hàng cũ trước khi thêm mới

                dgvDsSach.Refresh();

                foreach (var sach in danhSachSach)
                {
                    // Lấy tên tác giả (giả sử mỗi sách có thể có nhiều tác giả, lấy tên tác giả đầu tiên)
                    var tenTacGia = sach.TacGias.Any() ? sach.TacGias.First().TenTG : "Không có tác giả";

                    // Lấy tên thể loại (giả sử mỗi sách có thể có nhiều thể loại, lấy tên thể loại đầu tiên)
                    var tenTheLoai = sach.TheLoais.Any() ? sach.TheLoais.First().TenTL : "Không có thể loại";

                    // Lấy tên nhà xuất bản
                    var tenNXB = sach.NhaXuatBan != null ? sach.NhaXuatBan.TenNXB : "Không có nhà xuất bản";

                    // Lấy giá bán từ bảng Kho (lấy giá bán của kho đầu tiên liên quan đến sách)
                    var giaBan = sach.Khoes.Any() ? sach.Khoes.First().DonGiaBan ?? 0 : 0;

                    // Lấy số lượng tồn từ bảng Kho (lấy số lượng tồn của kho đầu tiên liên quan đến sách)
                    var soLuongTon = sach.Khoes.Any() ? sach.Khoes.First().SoLuongTon : 0;

                    // Thêm dữ liệu vào DataGridView
                    dgvDsSach.Rows.Add(sach.Id, sach.TenSach, tenTacGia, tenTheLoai, tenNXB, sach.NamXuatBan, soLuongTon, giaBan);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu sách: {ex.Message}");
            }
        }


        private void SetupDataGridView()
        {
            dgvDsSach.Columns["Column1"].HeaderText = "Mã Sách";  // Mã sách
            dgvDsSach.Columns["Column2"].HeaderText = "Tên Sách";  // Tên sách
            dgvDsSach.Columns["Column3"].HeaderText = "Tác Giả";   // Tác giả
            dgvDsSach.Columns["Column4"].HeaderText = "Thể Loại";  // Thể loại
            dgvDsSach.Columns["Column5"].HeaderText = "NXB";       // Nhà xuất bản
            dgvDsSach.Columns["Column6"].HeaderText = "Năm XB";    // Năm xuất bản
            dgvDsSach.Columns["Column7"].HeaderText = "SL Tồn";    // Số lượng tồn
            dgvDsSach.Columns["Column8"].HeaderText = "Giá";       // Giá

            dgvDsSach.Columns["Column1"].DataPropertyName = "Id";     // Mã sách
            dgvDsSach.Columns["Column2"].DataPropertyName = "TenSach"; // Tên sách
            dgvDsSach.Columns["Column3"].DataPropertyName = "TacGia";  // Tác giả
            dgvDsSach.Columns["Column4"].DataPropertyName = "TheLoai"; // Thể loại
            dgvDsSach.Columns["Column5"].DataPropertyName = "NXB";     // Nhà xuất bản
            dgvDsSach.Columns["Column6"].DataPropertyName = "NamXB";   // Năm xuất bản
            dgvDsSach.Columns["Column7"].DataPropertyName = "SoLuongTon"; // SL tồn
            dgvDsSach.Columns["Column8"].DataPropertyName = "GiaBan"; // Giá
        }
     
        private void btnRefesh_Click(object sender, EventArgs e)
        {
            LoadSachData();
        }

    }
}
