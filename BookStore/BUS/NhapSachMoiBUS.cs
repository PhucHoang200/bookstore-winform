using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhapSachMoiBUS
    {
        private readonly NhapSachMoiDAL _dal;

        public NhapSachMoiBUS()
        {
            _dal = new NhapSachMoiDAL();
        }

        // Kiểm tra tác giả tồn tại hay không
        public bool KiemTraTacGiaTonTai(string tacGia)
        {
            return _dal.KiemTraTacGiaTonTai(tacGia);
        }

        // Lưu tác giả và trả về Id
        public int LuuTacGia(string tacGia)
        {
            return _dal.LuuTacGia(tacGia);
        }

        // Lấy Id tác giả
        public int LayIdTacGia(string tacGia)
        {
            return _dal.LayIdTacGia(tacGia);
        }

        // Thêm chi tiết phiếu nhập
        public void ThemChiTietPhieuNhap(CT_PhieuNhap chiTiet)
        {
            _dal.ThemChiTietPhieuNhap(chiTiet);
        }

        public bool KiemTraTheLoaiTonTai(string theLoai)
        {
            return _dal.KiemTraTheLoaiTonTai(theLoai);
        }

        public int LuuTheLoai(string theLoai)
        {
            return _dal.LuuTheLoai(theLoai);
        }

        // Kiểm tra nhà xuất bản tồn tại
        public bool KiemTraNhaXBTonTai(string nhaXB)
        {
            return _dal.KiemTraNhaXBTonTai(nhaXB);
        }

        public int LuuNhaXB(string nhaXB)
        {
            return _dal.LuuNhaXB(nhaXB);
        }

        public bool KiemTraNCCTonTai(string nhaCungCap)
        {
            return _dal.KiemTraNCCTonTai(nhaCungCap);
        }

        public int LuuNCC(string nhaCungCap)
        {
            return _dal.LuuNCC(nhaCungCap);
        }
    }
}
