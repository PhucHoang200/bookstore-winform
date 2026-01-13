using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DTO;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

      

        // Cập nhật mật khẩu mới (băm SHA256)
        public bool UpdatePassword(string email, string newPasswordHash)
        {
            using (var context = new BookStoreDBEntities())
            {
                var taiKhoan = context.TaiKhoans.SingleOrDefault(tk => tk.Email == email);
                if (taiKhoan == null)
                {
                    return false; // Không tìm thấy tài khoản
                }

                taiKhoan.MatKhau = Convert.FromBase64String(newPasswordHash);
                context.SaveChanges();
                return true;
            }
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

        private byte[] HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                return sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool CompareHashes(byte[] hash1, byte[] hash2)
        {
            if (hash1.Length != hash2.Length) return false;
            for (int i = 0; i < hash1.Length; i++)
            {
                if (hash1[i] != hash2[i]) return false;
            }
            return true;
        }

        public bool CheckOldPassword(TaiKhoan taiKhoan, string inputPassword)
        {
            var inputHash = HashPassword(inputPassword);
            return CompareHashes(taiKhoan.MatKhau, inputHash);
        }

        public List<TaiKhoan> GetAllTaiKhoans()
        {
            return taiKhoanDAL.GetAllTaiKhoans();
        }

        public List<TaiKhoan> GetTaiKhoansByVaiTro(string tenVaiTro)
        {
            return taiKhoanDAL.GetTaiKhoansByVaiTro(tenVaiTro);
        }

        // Lấy danh sách vai trò
        public List<VaiTro> GetAllVaiTro()
        {
            return taiKhoanDAL.GetAllVaiTro();
        }

        // Lưu tài khoản mới
        public bool SaveTaiKhoan(TaiKhoan taiKhoan)
        {
            return taiKhoanDAL.SaveTaiKhoan(taiKhoan);
        }

        // Phương thức GetTaiKhoanById
        public TaiKhoan GetTaiKhoanById(int id)
        {
            // Gọi phương thức DAL để lấy tài khoản theo ID
            return taiKhoanDAL.GetTaiKhoanById(id);
        }

        // Phương thức UpdateTaiKhoan
        public bool UpdateTaiKhoan(TaiKhoan taiKhoan)
        {
            // Gọi phương thức DAL để cập nhật tài khoản
            return taiKhoanDAL.UpdateTaiKhoan(taiKhoan);
        }

        // Phương thức DeleteTaiKhoan
        public bool DeleteTaiKhoan(int id)
        {
            // Gọi phương thức DAL để xóa tài khoản
            return taiKhoanDAL.DeleteTaiKhoan(id);
        }

        // Phương thức ResetMatKhau
        public bool ResetMatKhau(int id, byte[] matKhauHash)
        {
            // Gọi phương thức DAL để reset mật khẩu
            return taiKhoanDAL.ResetMatKhau(id, matKhauHash);
        }

        public TaiKhoan GetTaiKhoanByEmail(string email)
        {
            using (var context = new BookStoreDBEntities())
            {
                return context.TaiKhoans.Include("VaiTro").SingleOrDefault(t => t.Email == email);
            }
        }

    }
}
