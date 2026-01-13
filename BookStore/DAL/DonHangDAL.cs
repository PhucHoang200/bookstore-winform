using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class DonHangDAL
    {
        private readonly BookStoreDBEntities _context;

        public DonHangDAL()
        {
            _context = new BookStoreDBEntities();
        }

        public int LuuKhachHangVaLayMa(KhachHang khachHang)
        {
           
            _context.KhachHangs.Add(khachHang);
            _context.SaveChanges();
            return khachHang.Id; // Trả về mã khách hàng mới tạo
        }

        public bool KiemTraEmailTrung(string email)
        {
            return _context.KhachHangs.Any(kh => kh.Email == email);
        }

        public bool KiemTraSoDienThoaiTrung(string sdt)
        {
            return _context.KhachHangs.Any(kh => kh.SoDienThoai == sdt);
        }

        public void CapNhatKhachHang(int maKH, KhachHang khachHangMoi)
        {
            var khachHang = _context.KhachHangs.FirstOrDefault(k => k.Id == maKH);
            if (khachHang != null)
            {
                khachHang.HoTenKH = khachHangMoi.HoTenKH;
                khachHang.Email = khachHangMoi.Email;
                khachHang.SoDienThoai = khachHangMoi.SoDienThoai;
                khachHang.DiaChi = khachHangMoi.DiaChi;
                _context.SaveChanges();
            }
        }


        public int LayMaKHTheoEmail(string email)
        {
            return _context.KhachHangs.FirstOrDefault(k => k.Email == email)?.Id ?? 0;
        }

        public void LuuDonHang(DonHang donHang, List<CT_DonHang> chiTietDonHangs)
        {
            // Lưu đơn hàng
            _context.DonHangs.Add(donHang);
            _context.SaveChanges();

            // Lưu chi tiết đơn hàng
            foreach (var ct in chiTietDonHangs)
            {
                ct.IdDonHang = donHang.Id; // Gán IdDonHang từ đơn hàng vừa lưu
                _context.CT_DonHang.Add(ct);
            }
            _context.SaveChanges();
        }


        public void CapNhatSachTrongKho(int idSach, int soLuong)
        {
            var kho = _context.Khoes.FirstOrDefault(k => k.IdSach == idSach);
            if (kho != null)
            {
                kho.SoLuongTon += soLuong;
                _context.SaveChanges();
            }
        }

        // Lấy danh sách sách từ cơ sở dữ liệu
        public List<Sach> LayDanhSachSach(string tuKhoa = null, int? namXuatBan = null, int? soLuongTon = null)
        {
            var query = _context.Saches
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .Include(s => s.NhaXuatBan)
                .Include(s => s.Khoes)
                .AsQueryable();

            // Lọc theo từ khóa
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                query = query.Where(s =>
                    s.TenSach.Contains(tuKhoa) ||
                    s.TacGias.Any(tg => tg.TenTG.Contains(tuKhoa)) ||
                    s.TheLoais.Any(tl => tl.TenTL.Contains(tuKhoa)) ||
                    s.NhaXuatBan.TenNXB.Contains(tuKhoa) ||
                s.NamXuatBan.ToString().Contains(tuKhoa) || // Lọc theo năm xuất bản
           s.Khoes.Any(k => k.SoLuongTon.ToString().Contains(tuKhoa))
           );// Lọc theo số lượng tồn
            }

            // Lọc theo năm xuất bản
            if (namXuatBan.HasValue)
            {
                query = query.Where(s => s.NamXuatBan == namXuatBan.Value);
            }

            // Lọc theo số lượng tồn
            if (soLuongTon.HasValue)
            {
                query = query.Where(s => s.Khoes.Any(k => k.SoLuongTon >= soLuongTon.Value));
            }

            return query.ToList();
        }

        public List<Sach> LayDanhSachSach()
        {
            var query = _context.Saches
                .Include(s => s.TacGias)
                .Include(s => s.TheLoais)
                .Include(s => s.NhaXuatBan)
                .Include(s => s.Khoes)
                .AsQueryable();

            return query.ToList();
        }

        public List<DonHangVM> LayDanhSachDonHang()
        {
            var query = _context.DonHangs
                .Join(
                    _context.KhachHangs,
                    dh => dh.IdKhachHang,
                    kh => kh.Id,
                    (dh, kh) => new DonHangVM
                    {
                        Id = dh.Id,
                        NgayMuaHang = dh.NgayMuaHang,
                        HoTenKH = kh.HoTenKH,
                        TongTienBan = dh.TongTienBan
                    })
                .ToList();

            return query;
        }

        public bool XoaDonHang(int idDonHang)
        {
            try
            {
                // Tìm đơn hàng trong cơ sở dữ liệu
                var donHang = _context.DonHangs.FirstOrDefault(dh => dh.Id == idDonHang);

                if (donHang != null)
                {
                    _context.DonHangs.Remove(donHang); // Xóa đơn hàng
                    _context.SaveChanges();           // Lưu thay đổi vào cơ sở dữ liệu
                    return true;
                }
                return false; // Không tìm thấy đơn hàng
            }
            catch (Exception ex)
            {
                // Ghi log lỗi nếu cần thiết
                Console.WriteLine("Lỗi khi xóa đơn hàng: " + ex.Message);
                return false;
            }
        }

        public DonHangVM LayThongTinDonHang(int idDonHang)
        {
            return _context.DonHangs
                .Where(dh => dh.Id == idDonHang)
                .Select(dh => new DonHangVM
                {
                    Id = dh.Id,
                    NgayMuaHang = dh.NgayMuaHang,
                    HoTenKH = dh.KhachHang.HoTenKH,
                    Email = dh.KhachHang.Email,
                    DiaChi = dh.KhachHang.DiaChi,
                    SoDienThoai = dh.KhachHang.SoDienThoai,
                    TongTienBan = dh.TongTienBan
                })
                .FirstOrDefault();
        }


        public List<SanPhamDonHangVM> LayDanhSachSanPhamTrongDonHang(int idDonHang)
        {
            return _context.CT_DonHang
          .Where(ct => ct.IdDonHang == idDonHang)
          .Select(ct => new SanPhamDonHangVM
          {
              TenSach = ct.Sach.TenSach,
              SoLuongBan = ct.SoLuongBan,
              DonGiaBan = ct.DonGiaBan,
              ThanhTien = ct.SoLuongBan * ct.DonGiaBan
          })
          .ToList();
        }

       
    }
}
