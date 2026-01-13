using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms; // Để sử dụng Guna2DataGridView
using System.Windows.Forms; // Để sử dụng DataGridView và DataGridViewRow

namespace BUS
{
    public class DonHangBUS
    {
        private readonly DonHangDAL _dal;

        public DonHangBUS()
        {
            _dal = new DonHangDAL();
        }

        public int LuuKhachHangVaLayMa(string hoTen, string email, string sdt, string diaChi)
        {

            return _dal.LuuKhachHangVaLayMa(new KhachHang
            {
                HoTenKH = hoTen,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diaChi
            });
        }

        public bool KiemTraEmailTrung(string email)
        {
            return _dal.KiemTraEmailTrung(email);
        }

        public bool KiemTraSoDienThoaiTrung(string sdt)
        {
            return _dal.KiemTraSoDienThoaiTrung(sdt);
        }

        public void CapNhatKhachHang(int maKH, string hoTen, string email, string sdt, string diaChi)
        {
            _dal.CapNhatKhachHang(maKH, new KhachHang
            {
                HoTenKH = hoTen,
                Email = email,
                SoDienThoai = sdt,
                DiaChi = diaChi
            });
        }


        public void ThemChiTietDonHang(Guna2DataGridView dgv, int maSach, int soLuong, decimal donGia)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToInt32(row.Cells["Column9"].Value) == maSach)
                {
                    throw new Exception("Sách đã tồn tại trong giỏ hàng, vui lòng cập nhật số lượng.");
                }
            }

            dgv.Rows.Add(maSach, donGia, soLuong);
        }

        public decimal TinhTongTien(Guna2DataGridView dgv)
        {
            return dgv.Rows.Cast<DataGridViewRow>().Sum(row =>
                Convert.ToDecimal(row.Cells["Column10"].Value) *
                Convert.ToInt32(row.Cells["Column11"].Value));
        }

        public void LuuDonHang(DonHang donHang, List<CT_DonHang> chiTietDonHangs)
        {
            _dal.LuuDonHang(donHang, chiTietDonHangs);

            // Cập nhật số lượng tồn trong kho cho mỗi sách trong chi tiết đơn hàng
            foreach (var chiTiet in chiTietDonHangs)
            {
                _dal.CapNhatSachTrongKho(chiTiet.IdSach, -chiTiet.SoLuongBan); // Giảm số lượng tồn khi bán
            }
        }


        public List<Sach> LayDanhSachSach()
        {
            return _dal.LayDanhSachSach();
        }

        public List<Sach> TimKiemSach(string tuKhoa, int? namXuatBan = null, int? soLuongTon = null)
        {
            return _dal.LayDanhSachSach(tuKhoa, namXuatBan, soLuongTon);
        }

        public List<DonHangVM> LayDanhSachDonHang()
        {
            return _dal.LayDanhSachDonHang();
        }

        public bool XoaDonHang(int idDonHang)
        {
            return _dal.XoaDonHang(idDonHang);
        }

        public DonHangVM LayThongTinDonHang(int idDonHang)
        {
            return _dal.LayThongTinDonHang(idDonHang);
        }

        public List<SanPhamDonHangVM> LayDanhSachSanPhamTrongDonHang(int idDonHang)
        {
            return _dal.LayDanhSachSanPhamTrongDonHang(idDonHang);
        }


    }
}
