using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTSachVM
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime? NgayNhapMoiNhat { get; set; }
    }

    public class SachChiTietDTO
    {
        public int MaSach { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public string TheLoai { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public int SoLuongTon { get; set; }
        public List<ChiTietPhieuNhapDTO> ChiTietPhieuNhap { get; set; }
    }

    public class ChiTietPhieuNhapDTO
    {
        public string TenNCC { get; set; }
        public int SoLuongNhap { get; set; }
        public decimal DonGiaNhap { get; set; }
        public decimal DonGiaBan { get; set; }
        public DateTime? NgayNhap { get; set; }
        public decimal ThanhTien { get; set; }
    }

}
