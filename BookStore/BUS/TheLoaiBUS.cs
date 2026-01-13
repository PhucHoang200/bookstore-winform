using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        private TheLoaiDAL theLoaiDAL = new TheLoaiDAL();

        // Lấy danh sách khách hàng
        public List<TheLoai> GetAllTheLoai()
        {
            return theLoaiDAL.GetAllTheLoai();
        }

        // Thêm khách hàng mới với logic kiểm tra
        public string AddTheLoai(string tenTL)
        {
            if (string.IsNullOrWhiteSpace(tenTL))
            {
                return "Tên thể loại không được để trống!";
            }


            // Kiểm tra trùng lặp số điện thoại
            var existingName = theLoaiDAL.GetAllTheLoai().FirstOrDefault(i => i.TenTL == tenTL);
            if (existingName != null)
            {
                return "Tên thể loại đã tồn tại.";
            }


            var theLoai = new TheLoai
            {
                TenTL = tenTL
            };

            theLoaiDAL.AddTheLoai(theLoai);
            return "Thêm thể loại thành công!";
        }

        public string UpdateTheLoai(int id, string tenTL)
        {
            var existingTheLoai = theLoaiDAL.GetAllTheLoai().FirstOrDefault(i => i.Id == id);
            if (existingTheLoai != null)
            {
                if (string.IsNullOrWhiteSpace(tenTL))
                {
                    return "Không được để trống thông tin!";
                }

                //Kiểm tra email trùng lặp, loại trừ khách hàng hiện tại
                var existingTenTheLoai = theLoaiDAL.GetAllTheLoai()
                                            .FirstOrDefault(i => i.TenTL == tenTL && i.Id != id);
                if (existingTenTheLoai != null)
                {
                    return "Tên thể loại đã tồn tại.";
                }

                var theLoai = new TheLoai
                {
                    Id = id,
                    TenTL = tenTL
                };

                bool kq = theLoaiDAL.UpdateTheLoai(theLoai);
                if (kq)
                {
                    return "Cập nhật thông tin thể loại thành công";
                }
                else
                {
                    return "Cập nhật thông tin thể loại thất bại";
                }
            }
            else
            {
                return "Mã thể loại không tồn tại";
            }
        }

        public string DeleteTheLoai(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id) || !int.TryParse(Id, out int parsedId))
            {
                return "Mã thể loại không hợp lệ";
            }

            bool kq = theLoaiDAL.DeleteTheLoai(parsedId);
            if (kq)
            {
                return "Xóa thể loại thành công";
            }
            else
            {
                return "Xóa thể loại thất bại!";
            }
        }

        public List<TheLoai> FindTheLoaiByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<TheLoai>();
            }
            return theLoaiDAL.FindTheLoaiByName(name);
        }
    }
}
