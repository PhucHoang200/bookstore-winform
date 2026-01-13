using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TacGiaDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        // Lấy danh sách khách hàng
        public List<TacGia> GetAllTacGia()
        {
            return db.TacGias.ToList();
        }

        // Thêm khách hàng mới
        public void AddTacGia(TacGia tacGia)
        {
            db.TacGias.Add(tacGia);
            db.SaveChanges();
        }

        public bool UpdateTacGia(TacGia tacGia)
        {
            var existingTacGia = db.TacGias.FirstOrDefault(i => i.Id == tacGia.Id);
            if (existingTacGia != null)
            {
                // Cập nhật thông tin
                existingTacGia.TenTG = tacGia.TenTG;
               
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Xóa khách hàng
        public bool DeleteTacGia(int id)
        {
            var tacGia = db.TacGias.FirstOrDefault(i => i.Id == id);
            if (tacGia != null)
            {
                db.TacGias.Remove(tacGia);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TacGia> FindTacGiaByName(string name)
        {
            return db.TacGias
                     .Where(kh => kh.TenTG.Contains(name))
                     .ToList();
        }

    }
}
