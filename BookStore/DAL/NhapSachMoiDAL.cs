using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapSachMoiDAL
    {
        private readonly BookStoreDBEntities _context;

        public NhapSachMoiDAL()
        {
            _context = new BookStoreDBEntities();
        }

        // Kiểm tra tác giả có tồn tại trong cơ sở dữ liệu không
        public bool KiemTraTacGiaTonTai(string tacGia)
        {
            // Kiểm tra nếu tên tác giả rỗng hoặc null
            if (string.IsNullOrEmpty(tacGia))
            {
                return false; // Trả về false nếu tên tác giả không hợp lệ
            }

            // Kiểm tra xem _context có được khởi tạo chưa
            if (_context == null)
            {
                throw new InvalidOperationException("Database context is not initialized.");
            }

            // Tìm kiếm tác giả theo tên, so sánh không phân biệt chữ hoa chữ thường
            return _context.TacGias.Any(x => x.TenTG.Equals(tacGia, StringComparison.OrdinalIgnoreCase));
        }



        // Lưu tác giả vào cơ sở dữ liệu
        public int LuuTacGia(string tacGia)
        {
            var newTacGia = new TacGia() { TenTG = tacGia };
            _context.TacGias.Add(newTacGia);
            _context.SaveChanges();
            return newTacGia.Id;
        }

        // Lấy ID của tác giả
        public int LayIdTacGia(string tacGia)
        {
            return _context.TacGias.FirstOrDefault(x => x.TenTG == tacGia).Id;
        }

        // Kiểm tra thể loại tồn tại
        public bool KiemTraTheLoaiTonTai(string theLoai)
        {
            return _context.TheLoais.Any(x => x.TenTL == theLoai);
        }

        // Lưu thể loại vào cơ sở dữ liệu
        public int LuuTheLoai(string theLoai)
        {
            var newTheLoai = new TheLoai() { TenTL = theLoai };
            _context.TheLoais.Add(newTheLoai);
            _context.SaveChanges();
            return newTheLoai.Id;
        }

        // Kiểm tra nhà xuất bản tồn tại
        public bool KiemTraNhaXBTonTai(string nhaXB)
        {
            return _context.NhaXuatBans.Any(x => x.TenNXB == nhaXB);
        }

        // Lưu nhà xuất bản vào cơ sở dữ liệu
        public int LuuNhaXB(string nhaXB)
        {
            var newNhaXB = new NhaXuatBan() { TenNXB = nhaXB };
            _context.NhaXuatBans.Add(newNhaXB);
            _context.SaveChanges();
            return newNhaXB.Id;
        }

        // Kiểm tra nhà cung cấp tồn tại
        public bool KiemTraNCCTonTai(string nhaCungCap)
        {
            return _context.NhaCungCaps.Any(x => x.TenNCC == nhaCungCap);
        }

        // Lưu nhà cung cấp vào cơ sở dữ liệu
        public int LuuNCC(string nhaCungCap)
        {
            var newNCC = new NhaCungCap() { TenNCC = nhaCungCap };
            _context.NhaCungCaps.Add(newNCC);
            _context.SaveChanges();
            return newNCC.Id;
        }


        // Thêm chi tiết phiếu nhập
        public void ThemChiTietPhieuNhap(CT_PhieuNhap chiTiet)
        {
            _context.CT_PhieuNhap.Add(chiTiet);
            _context.SaveChanges();
        }

    }
}
