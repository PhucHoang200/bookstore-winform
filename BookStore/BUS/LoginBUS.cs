using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BUS
{
    public class LoginBUS
    {
        private LoginDAL loginDAL = new LoginDAL();
        public bool CheckLogin(string email, string password, out string role, out int idTaiKhoan)
        {
            // Lấy thông tin tài khoản từ DAL
            TaiKhoan taiKhoan = loginDAL.GetTaiKhoanByEmail(email);

            if (taiKhoan == null)
            {
                role = null;
                idTaiKhoan = 0;
                return false; // Không tìm thấy tài khoản
            }

            // Kiểm tra mật khẩu
            byte[] dbHash = taiKhoan.MatKhau;
            byte[] userHash = HashPassword(password);
            if (!CompareHashes(dbHash, userHash))
            {
                role = null;
                idTaiKhoan = 0;
                return false; // Mật khẩu sai
            }

            // Lấy vai trò và Id tài khoản
            role = taiKhoan.VaiTro.TenVaiTro; // Giả sử thuộc tính VaiTro lưu thông tin vai trò
            idTaiKhoan = taiKhoan.Id; // Lấy Id tài khoản
            return true;
        }

        public bool CheckEmailExist(string email)
        {
            using (var context = new BookStoreDBEntities())
            {
                // Kiểm tra xem email có tồn tại trong bảng TaiKhoan không
                return context.TaiKhoans.Any(tk => tk.Email == email);
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
