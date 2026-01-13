using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHangVM
    {
        public int Id { get; set; }
        public Nullable<System.DateTime> NgayMuaHang { get; set; }
        public string HoTenKH { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public Nullable<decimal> TongTienBan { get; set; }
    }
}
