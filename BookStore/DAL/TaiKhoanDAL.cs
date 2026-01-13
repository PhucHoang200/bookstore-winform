using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.Entity;
using System.Security.Cryptography;

namespace DAL
{
    public class TaiKhoanDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        public List<TaiKhoan> GetAllTaiKhoans()
        {
            return db.TaiKhoans.Include(t => t.VaiTro).ToList();
        }

        public List<TaiKhoan> GetTaiKhoansByVaiTro(string tenVaiTro)
        {
            return db.TaiKhoans
                .Include(t => t.VaiTro)
                .Where(t => t.VaiTro.TenVaiTro == tenVaiTro)
                .ToList();
        }

        public List<VaiTro> GetAllVaiTro()
        {
            return db.VaiTroes.ToList();
        }

        // Lưu tài khoản mới
        public bool SaveTaiKhoan(TaiKhoan taiKhoan)
        {
            try
            {
                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Lấy tài khoản theo Id
        public TaiKhoan GetTaiKhoanById(int id)
        {
            return db.TaiKhoans.Include("VaiTro").FirstOrDefault(t => t.Id == id);
        }

        // Cập nhật tài khoản
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            var entity = db.TaiKhoans.Find(taiKhoan.Id);
            if (entity != null)
            {
                entity.HoTen = taiKhoan.HoTen;
                entity.Email = taiKhoan.Email;
                entity.SoDienThoai = taiKhoan.SoDienThoai;
                entity.Luong = taiKhoan.Luong;
                entity.IdVaiTro = taiKhoan.IdVaiTro;

                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Xóa tài khoản
        public bool DeleteTaiKhoan(int id)
        {
            var entity = db.TaiKhoans.Find(id);
            if (entity != null)
            {
                db.TaiKhoans.Remove(entity);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Reset mật khẩu
        public bool ResetMatKhau(int id, byte[] matKhauHash)
        {
            var entity = db.TaiKhoans.Find(id);
            if (entity != null)
            {
                // Chuyển đổi mảng byte mật khẩu thành chuỗi base64 băm
                string matKhauHashBase64 = HashPasswordToBase64("123");

                // Lưu mật khẩu đã băm vào cơ sở dữ liệu
                entity.MatKhau = Convert.FromBase64String(matKhauHashBase64);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // Băm mật khẩu bằng SHA256
        public string HashPasswordToBase64(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hash);
            }
        }
    }
}
