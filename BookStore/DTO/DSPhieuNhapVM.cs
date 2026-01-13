using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapVM
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> NgayNhapSach { get; set; }
        public Nullable<decimal> TongTienNhap { get; set; }
        
    }

    public class SanPhamPhieuNhapVM
    {
        public string TenSach { get; set; }
        public string TenNCC { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
    }

}
