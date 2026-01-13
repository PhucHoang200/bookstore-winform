using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        // Lấy danh sách khách hàng
        public List<TheLoai> GetAllTheLoai()
        {
            return db.TheLoais.ToList();
        }

        // Thêm khách hàng mới
        public void AddTheLoai(TheLoai theLoai)
        {
            db.TheLoais.Add(theLoai);
            db.SaveChanges();
        }

        public bool UpdateTheLoai(TheLoai theLoai)
        {
            var existingTheLoai = db.TheLoais.FirstOrDefault(i => i.Id == theLoai.Id);
            if (existingTheLoai != null)
            {
               existingTheLoai.TenTL = theLoai.TenTL;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Xóa khách hàng
        public bool DeleteTheLoai(int id)
        {
            var theLoai = db.TheLoais.FirstOrDefault(i => i.Id == id);
            if (theLoai != null)
            {
                db.TheLoais.Remove(theLoai);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<TheLoai> FindTheLoaiByName(string name)
        {
            return db.TheLoais
                     .Where(i => i.TenTL.Contains(name))
                     .ToList();
        }
    }
}
