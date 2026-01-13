using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachViewModel
    {
        public int Id { get; set; }
        public string TenSach { get; set; }
        public string TenTG { get; set; }
        public string TenTL { get; set; }
        public string TenNXB { get; set; }
        public int NamXuatBan { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string TenNCC { get; set; }
    }

    public class NhaCungCapViewModel
    {
        public int Id { get; set; }  // Mã nhà cung cấp
        public string TenNCC { get; set; }  // Tên nhà cung cấp
    }
}
