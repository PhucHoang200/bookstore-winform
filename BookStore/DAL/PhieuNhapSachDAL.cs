using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapSachDAL
    {
        private readonly BookStoreDBEntities _context;

        public PhieuNhapSachDAL()
        {
            _context = new BookStoreDBEntities();
        }

        public List<PhieuNhapSachVM> LayDanhSachPhieuNhapSach()
        {
            var query = _context.PhieuNhapSaches
                .Select(pn => new PhieuNhapSachVM
                {
                    Id = pn.Id,
                    NgayNhapSach = pn.NgayNhapSach,
                    TongTienNhap = pn.TongTienNhap
                })
                .ToList();

            return query;
        }

        public bool XoaPhieuNhapSach(int idPhieuNhap)
        {
            try
            {
                var phieuNhap = _context.PhieuNhapSaches.FirstOrDefault(pn => pn.Id == idPhieuNhap);

                if (phieuNhap != null)
                {
                    _context.PhieuNhapSaches.Remove(phieuNhap);
                    _context.SaveChanges();
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi xóa phiếu nhập: " + ex.Message);
                return false;
            }
        }

        public PhieuNhapVM LayThongTinPhieuNhap(int maPhieuNhap)
        {
            return _context.PhieuNhapSaches
                .Where(pn => pn.Id == maPhieuNhap)
                .Select(pn => new PhieuNhapVM
                {
                    Id = pn.Id,
                    NgayNhapSach = pn.NgayNhapSach,
                    TongTienNhap = pn.TongTienNhap,                    
                })
                .FirstOrDefault();
        }

        public List<SanPhamPhieuNhapVM> LayDanhSachSanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            return _context.CT_PhieuNhap
                .Where(ct => ct.MaPhieuNhap == maPhieuNhap)
                .Select(ct => new SanPhamPhieuNhapVM
                {
                    TenSach = ct.Sach.TenSach,
                    SoLuongNhap = ct.SoLuongNhap,
                    DonGiaNhap = ct.DonGiaNhap,
                    DonGiaBan = ct.DonGiaBan,
                    ThanhTien = ct.SoLuongNhap * ct.DonGiaNhap,
                    TenNCC = ct.PhieuNhapSach.NhaCungCap.TenNCC
                })
                .ToList();
        }

    }
}
