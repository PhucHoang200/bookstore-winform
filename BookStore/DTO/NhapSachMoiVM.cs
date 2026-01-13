using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachInfo
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public string NhaCungCap { get; set; }
    }

    public class PhieuNhapSachInfo
    {
        public string NhaCungCap { get; set; }
        public List<SachInfo> ChiTietSach { get; set; }
    }

    public class ChiTietPhieuNhap
    {
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NhaXB { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public string NhaCungCap { get; set; }
        public decimal ThanhTien { get; set; }
    }

}
