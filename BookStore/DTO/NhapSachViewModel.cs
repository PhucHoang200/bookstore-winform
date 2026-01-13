using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapSachViewModel
    {
        public string TenSach { get; set; }
        public string TenTG { get; set; }
        public string TenTL { get; set; }
        public string TenNXB { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string TenNCC { get; set; }
        public decimal ThanhTien { get; set; }
    }
}
