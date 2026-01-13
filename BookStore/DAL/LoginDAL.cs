using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Security.Cryptography;

namespace DAL
{
    public class LoginDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        public TaiKhoan GetTaiKhoanByEmail(string email)
        {
            return db.TaiKhoans.FirstOrDefault(x => x.Email == email);
        }

    }
}
