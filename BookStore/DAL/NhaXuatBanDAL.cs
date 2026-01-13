using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaXuatBanDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        public List<NhaXuatBan> GetAllNhaXuatBan()
        {
            return db.NhaXuatBans.ToList();
        }

        public void AddNhaXuatBan(NhaXuatBan nxb)
        {
            db.NhaXuatBans.Add(nxb);
            db.SaveChanges();
        }

        public bool UpdateNhaXuatBan(NhaXuatBan nxb)
        {
            var existingNXB = db.NhaXuatBans.FirstOrDefault(i => i.Id == nxb.Id);
            if (existingNXB != null)
            {
                existingNXB.TenNXB = nxb.TenNXB;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Xóa khách hàng
        public bool DeleteNhaXuatBan(int id)
        {
            var nxb = db.NhaXuatBans.FirstOrDefault(i => i.Id == id);
            if (nxb != null)
            {
                db.NhaXuatBans.Remove(nxb);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<NhaXuatBan> FindNhaXuatBanByName(string name)
        {
            return db.NhaXuatBans
                     .Where(i => i.TenNXB.Contains(name))
                     .ToList();
        }
    }
}
