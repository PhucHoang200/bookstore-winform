using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapSachDaCoDAL
    {
        // Lấy danh sách nhà cung cấp
        public List<NhaCungCapViewModel> GetNhaCungCapList()
        {
            using (var context = new BookStoreDBEntities())
            {
                var nhaCungCapList = context.NhaCungCaps.Select(ncc => new NhaCungCapViewModel
                {
                    Id = ncc.Id,
                    TenNCC = ncc.TenNCC
                }).ToList();

                return nhaCungCapList;
            }
        }

        // Lấy sách theo nhà cung cấp
        public List<SachViewModel> GetSachListByNhaCungCap(int nhaCungCapId)
        {
            using (var context = new BookStoreDBEntities())
            {
                var sachList = context.Saches
                    .Where(s => s.NhaCungCaps.Any(ncc => ncc.Id == nhaCungCapId))
                    .Select(s => new SachViewModel
                    {
                        Id = s.Id,
                        TenSach = s.TenSach
                    }).ToList();

                return sachList;
            }
        }

        // Lấy danh sách sách (bao gồm Id và TenSach)
        public List<SachViewModel> GetSachList()
        {
            using (var context = new BookStoreDBEntities())
            {
                var sachList = context.Saches.Select(s => new SachViewModel
                {
                    Id = s.Id,
                    TenSach = s.TenSach
                }).ToList();

                return sachList;
            }
        }

       
        public SachViewModel GetSachDetailsById(int sachId)
        {
            using (var context = new BookStoreDBEntities())
            {
                var sach = context.Saches
                    .Where(s => s.Id == sachId)
                    .Select(s => new
                    {
                        s.Id,
                        s.TenSach,
                        TacGias = s.TacGias.Select(tg => tg.TenTG),  // Lấy danh sách tên tác giả mà không gọi ToList() trong truy vấn
                        TheLoais = s.TheLoais.Select(tl => tl.TenTL), // Lấy danh sách tên thể loại mà không gọi ToList()
                        s.NhaXuatBan.TenNXB,
                        s.NamXuatBan,
                        Kho = s.Khoes.FirstOrDefault(),
                        NhaCungCapId = s.NhaCungCaps.Select(ncc => ncc.Id).FirstOrDefault() // Lấy Id của nhà cung cấp
                    })
                    .FirstOrDefault();

                if (sach != null)
                {
                    // Lấy tên nhà cung cấp từ NhaCungCapId
                    var nhaCungCap = context.NhaCungCaps
                        .Where(ncc => ncc.Id == sach.NhaCungCapId)
                        .Select(ncc => ncc.TenNCC)
                        .FirstOrDefault();

                    return new SachViewModel
                    {
                        Id = sach.Id,
                        TenSach = sach.TenSach,
                        TenTG = string.Join(", ", sach.TacGias),  // Nối các tên tác giả lại với nhau sau khi truy vấn
                        TenTL = string.Join(", ", sach.TheLoais), // Nối các tên thể loại lại với nhau sau khi truy vấn
                        TenNXB = sach.TenNXB,
                        NamXuatBan = sach.NamXuatBan,
                        DonGiaNhap = sach.Kho?.DonGiaNhap ?? 0,  // Kiểm tra null và cung cấp giá trị mặc định
                        DonGiaBan = sach.Kho?.DonGiaBan ?? 0,    // Kiểm tra null và cung cấp giá trị mặc định
                        TenNCC = nhaCungCap // Gán tên nhà cung cấp vào TenNCC
                    };
                }

                return null; // Trả về null nếu không tìm thấy sách
            }
        }

        public int SavePhieuNhap(int nhaCungCapId, decimal tongTien)
        {
            using (var context = new BookStoreDBEntities())
            {
                var phieuNhap = new PhieuNhapSach
                {
                    MaNCC = nhaCungCapId, // Lưu mã nhà cung cấp vào PhieuNhapSach
                    NgayNhapSach = DateTime.Now,
                    TongTienNhap = tongTien
                };

                context.PhieuNhapSaches.Add(phieuNhap);
                context.SaveChanges();
                return phieuNhap.Id;  // Trả về Id của phiếu nhập vừa được lưu
            }
        }



    }
}
