using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class KhachHangDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        // Lấy danh sách khách hàng
        public List<KhachHang> GetAllKhachHang()
        {
            return db.KhachHangs.ToList();
        }

        // Thêm khách hàng mới
        public void AddKhachHang(KhachHang khachHang)
        {
            db.KhachHangs.Add(khachHang);
            db.SaveChanges();
        }

        public bool UpdateKhachHang(KhachHang khachHang)
        {
            var existingKhachHang = db.KhachHangs.FirstOrDefault(k => k.Id == khachHang.Id);
            if (existingKhachHang != null)
            {
                // Cập nhật thông tin
                existingKhachHang.HoTenKH = khachHang.HoTenKH;
                existingKhachHang.Email = khachHang.Email;
                existingKhachHang.SoDienThoai = khachHang.SoDienThoai;
                existingKhachHang.DiaChi = khachHang.DiaChi;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Xóa khách hàng
        public bool DeleteKhachHang(int id)
        {
            var khachHang = db.KhachHangs.FirstOrDefault(k => k.Id == id);
            if (khachHang != null)
            {
                db.KhachHangs.Remove(khachHang);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<KhachHang> FindKhachHangByName(string name)
        {
            return db.KhachHangs
                     .Where(kh => kh.HoTenKH.Contains(name))
                     .ToList();
        }

    }


}
