using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        private readonly BookStoreDBEntities _context;

        public NhaCungCapDAL()
        {
            _context = new BookStoreDBEntities();
        }

        // Lấy danh sách tất cả nhà cung cấp
        public List<NhaCungCap> GetAllNhaCungCap()
        {
            return _context.NhaCungCaps.ToList();
        }

        // Thêm nhà cung cấp mới
        public bool AddNhaCungCap(string tenNCC)
        {
            if (string.IsNullOrWhiteSpace(tenNCC)) return false;

            // Kiểm tra trùng lặp tên
            if (IsTenNCCExists(tenNCC)) return false;

            var newNCC = new NhaCungCap
            {
                TenNCC = tenNCC
            };

            _context.NhaCungCaps.Add(newNCC);
            return _context.SaveChanges() > 0;
        }

        // Cập nhật thông tin nhà cung cấp
        public bool UpdateNhaCungCap(int maNCC, string tenNCC)
        {
            if (maNCC <= 0 || string.IsNullOrWhiteSpace(tenNCC)) return false;

            // Kiểm tra trùng lặp tên
            if (IsTenNCCExists(tenNCC)) return false;

            var ncc = _context.NhaCungCaps.FirstOrDefault(n => n.Id == maNCC);
            if (ncc != null)
            {
                ncc.TenNCC = tenNCC;
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        // Xóa nhà cung cấp
        public bool DeleteNhaCungCap(int maNCC)
        {
            if (maNCC <= 0) return false;

            var ncc = _context.NhaCungCaps.FirstOrDefault(n => n.Id == maNCC);
            if (ncc != null)
            {
                _context.NhaCungCaps.Remove(ncc);
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        // Tìm kiếm nhà cung cấp theo tên
        public List<NhaCungCap> SearchNhaCungCap(string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword)) return new List<NhaCungCap>();

            return _context.NhaCungCaps
                           .Where(ncc => ncc.TenNCC.Contains(keyword))
                           .ToList();
        }

        // Kiểm tra tên nhà cung cấp có tồn tại hay không
        public bool IsTenNCCExists(string tenNCC)
        {
            if (string.IsNullOrWhiteSpace(tenNCC)) return false;

            return _context.NhaCungCaps.Any(ncc => ncc.TenNCC == tenNCC);
        }
    }
}
