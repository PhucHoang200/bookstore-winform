using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAL khachHangDAL = new KhachHangDAL();

        // Lấy danh sách khách hàng
        public List<KhachHang> GetAllKhachHang()
        {
            return khachHangDAL.GetAllKhachHang();
        }

        // Thêm khách hàng mới với logic kiểm tra
        public string AddKhachHang(string hoTen, string email, string soDienThoai, string diaChi)
        {
            if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(soDienThoai) || string.IsNullOrWhiteSpace(diaChi))
            {
                return "Vui lòng điền đầy đủ thông tin!";
            }

            //Kiểm tra trùng lặp email
            var existingEmail = khachHangDAL.GetAllKhachHang().FirstOrDefault(i => i.Email == email);
            if (existingEmail != null)
            {
                return "Email đã tồn tại.";
            }

            // Kiểm tra trùng lặp số điện thoại
            var existingPhone = khachHangDAL.GetAllKhachHang().FirstOrDefault(i => i.SoDienThoai == soDienThoai);
            if (existingPhone != null)
            {
                return "Số điện thoại đã tồn tại.";
            }


            var khachHang = new KhachHang
            {
                HoTenKH = hoTen,
                Email = email,
                SoDienThoai = soDienThoai,
                DiaChi = diaChi
            };

            khachHangDAL.AddKhachHang(khachHang);
            return "Thêm khách hàng thành công!";
        }

        public string UpdateKhachHang(int Id, string hoTen, string email, string soDienThoai, string diaChi)
        {
            var existingKhachHang = khachHangDAL.GetAllKhachHang().FirstOrDefault(i => i.Id == Id);
            if (existingKhachHang != null)
            {
                if (string.IsNullOrWhiteSpace(hoTen) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(soDienThoai) || string.IsNullOrWhiteSpace(diaChi))
                {
                    return "Không được để trống thông tin!";
                }

                //Kiểm tra email trùng lặp, loại trừ khách hàng hiện tại
                var existingEmail = khachHangDAL.GetAllKhachHang()
                                            .FirstOrDefault(i => i.Email == email && i.Id != Id);
                if (existingEmail != null)
                {
                    return "Email đã tồn tại.";
                }

                // Kiểm tra số điện thoại trùng lặp, loại trừ khách hàng hiện tại
                var existingPhone = khachHangDAL.GetAllKhachHang()
                                        .FirstOrDefault(i => i.SoDienThoai == soDienThoai && i.Id != Id);
                if (existingPhone != null)
                {
                    return "Số điện thoại đã tồn tại.";
                }

                var khachHang = new KhachHang
                {
                    Id = Id,
                    HoTenKH = hoTen,
                    Email = email,
                    SoDienThoai = soDienThoai,
                    DiaChi = diaChi
                };

                bool kq = khachHangDAL.UpdateKhachHang(khachHang);
                if (kq)
                {
                    return "Cập nhật thông tin khách hàng thành công";
                }
                else
                {
                    return "Cập nhật thông tin khách hàng thất bại";
                }
            }
            else
            {
                return "Mã khách hàng không tồn tại";
            }
        }

        public string DeleteKhachHang(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id) || !int.TryParse(Id, out int parsedId))
            {
                return "Mã khách hàng không hợp lệ";
            }

            bool kq = khachHangDAL.DeleteKhachHang(parsedId);
            if (kq) 
            {
                return "Xóa khách hàng thành công";
            }
            else
            {
                return "Xóa khách hàng thất bại!";
            }
        }

        public List<KhachHang> FindKhachHangByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<KhachHang>();
            }
            return khachHangDAL.FindKhachHangByName(name);
        }
    }
}
