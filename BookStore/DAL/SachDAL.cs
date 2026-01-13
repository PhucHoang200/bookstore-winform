using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        private BookStoreDBEntities db = new BookStoreDBEntities();

        public List<Sach> GetAllSach()
        {
            return db.Saches.ToList();
        }

        public List<Sach> FindSachByName(string name)
        {
            return db.Saches
                     .Where(i => i.TenSach.Contains(name))
                     .ToList();
        }

        public List<CTSachVM> GetChiTietSachTrongKho()
        {
            var query = from s in db.Saches
                        join k in db.Khoes on s.Id equals k.IdSach
                        select new CTSachVM
                        {
                            MaSach = s.Id,
                            TenSach = s.TenSach,
                            SoLuongTon = k.SoLuongTon,
                            NgayNhapMoiNhat = (from pn in db.CT_PhieuNhap
                                               where pn.MaSach == s.Id
                                               orderby pn.PhieuNhapSach.NgayNhapSach descending
                                               select pn.PhieuNhapSach.NgayNhapSach).FirstOrDefault()
                        };

            return query.ToList();
        }

        public SachChiTietDTO GetSachDetailsById(int maSach)
        {
            var sach = db.Saches
                .Where(s => s.Id == maSach)
                .Select(s => new
                {
                    MaSach = s.Id,
                    TenSach = s.TenSach,
                    TacGia = s.TacGias.Select(t => t.TenTG), // Truy vấn danh sách
                    TheLoai = s.TheLoais.Select(t => t.TenTL), // Truy vấn danh sách
                    NhaXuatBan = s.NhaXuatBan.TenNXB,
                    NamXuatBan = s.NamXuatBan,
                    SoLuongTon = db.Khoes.Where(k => k.IdSach == maSach).Select(k => k.SoLuongTon).FirstOrDefault(),
                    ChiTietPhieuNhap = db.CT_PhieuNhap
                        .Where(p => p.MaSach == maSach)
                        .Select(p => new ChiTietPhieuNhapDTO
                        {
                            TenNCC = p.PhieuNhapSach.NhaCungCap.TenNCC,
                            SoLuongNhap = p.SoLuongNhap,
                            DonGiaNhap = p.DonGiaNhap,
                            DonGiaBan = p.DonGiaBan,
                            NgayNhap = p.PhieuNhapSach.NgayNhapSach,
                            ThanhTien = p.DonGiaNhap * p.SoLuongNhap
                        }).ToList()
                })
                .AsEnumerable() // Chuyển sang LINQ to Objects
                .Select(s => new SachChiTietDTO
                {
                    MaSach = s.MaSach,
                    TenSach = s.TenSach,
                    TacGia = string.Join(", ", s.TacGia), // Xử lý trong bộ nhớ
                    TheLoai = string.Join(", ", s.TheLoai), // Xử lý trong bộ nhớ
                    NhaXuatBan = s.NhaXuatBan,
                    NamXuatBan = s.NamXuatBan,
                    SoLuongTon = s.SoLuongTon,
                    ChiTietPhieuNhap = s.ChiTietPhieuNhap
                })
                .FirstOrDefault();

            return sach;
        }

        public bool UpdateSach(int maSach, string tenSach, string tacGia, string theLoai, string nhaXuatBan, int namXuatBan)
        {
            try
            {
                var sach = db.Saches.FirstOrDefault(s => s.Id == maSach);
                if (sach == null) return false;

                // Cập nhật thông tin sách
                sach.TenSach = tenSach;
                sach.TacGias.Clear();
                var tacGiaList = tacGia.Split(',').Select(t => t.Trim()).ToList();
                foreach (var tenTG in tacGiaList)
                {
                    var tacGiaEntity = db.TacGias.FirstOrDefault(t => t.TenTG == tenTG) ?? new TacGia { TenTG = tenTG };
                    sach.TacGias.Add(tacGiaEntity);
                }

                sach.TheLoais.Clear();
                var theLoaiList = theLoai.Split(',').Select(t => t.Trim()).ToList();
                foreach (var tenTL in theLoaiList)
                {
                    var theLoaiEntity = db.TheLoais.FirstOrDefault(t => t.TenTL == tenTL) ?? new TheLoai { TenTL = tenTL };
                    sach.TheLoais.Add(theLoaiEntity);
                }

                sach.NhaXuatBan = db.NhaXuatBans.FirstOrDefault(n => n.TenNXB == nhaXuatBan) ?? new NhaXuatBan { TenNXB = nhaXuatBan };
                sach.NamXuatBan = namXuatBan;

                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteSach(int maSach)
        {
            try
            {
                var sach = db.Saches.FirstOrDefault(s => s.Id == maSach);
                if (sach == null) return false;

                // Xóa các liên kết với tác giả, thể loại và các bảng liên quan khác
                sach.TacGias.Clear();
                sach.TheLoais.Clear();

                db.Saches.Remove(sach);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Sach> FindSach(string keyword)
        {
            // Chuyển từ khóa tìm kiếm về dạng chữ thường để so sánh không phân biệt hoa thường
            keyword = keyword.ToLower();

            return db.Saches
                     .Where(sach => sach.TenSach.ToLower().Contains(keyword) || // Tìm theo tên sách
                                    sach.TacGias.Any(tg => tg.TenTG.ToLower().Contains(keyword)) || // Tìm theo tác giả
                                    sach.TheLoais.Any(tl => tl.TenTL.ToLower().Contains(keyword)) || // Tìm theo thể loại
                                    sach.NhaXuatBan.TenNXB.ToLower().Contains(keyword) || // Tìm theo nhà xuất bản
                                    sach.NamXuatBan.ToString().Contains(keyword)) // Tìm theo năm xuất bản
                     .ToList();
        }

        public List<Sach> GetAllSachesWithKho()
        {
            return db.Saches
                     .Include("Khoes") // Chỉ định bảng liên quan bằng tên chuỗi
                     .ToList();
        }

    }
}
