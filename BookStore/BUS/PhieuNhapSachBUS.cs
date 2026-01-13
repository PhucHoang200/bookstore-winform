using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class PhieuNhapSachBUS
    {
        private readonly PhieuNhapSachDAL _dal;

        public PhieuNhapSachBUS()
        {
            _dal = new PhieuNhapSachDAL();
        }

        public List<PhieuNhapSachVM> LayDanhSachPhieuNhapSach()
        {
            return _dal.LayDanhSachPhieuNhapSach();
        }

        public bool XoaPhieuNhapSach(int idPhieuNhap)
        {
            return _dal.XoaPhieuNhapSach(idPhieuNhap);
        }

        public PhieuNhapVM LayThongTinPhieuNhap(int maPhieuNhap)
        {
            return _dal.LayThongTinPhieuNhap(maPhieuNhap);
        }

        public List<SanPhamPhieuNhapVM> LayDanhSachSanPhamTrongPhieuNhap(int maPhieuNhap)
        {
            return _dal.LayDanhSachSanPhamTrongPhieuNhap(maPhieuNhap);
        }

    }
}
