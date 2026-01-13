using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class TacGiaBUS
    {
        private TacGiaDAL tacGiaDAL = new TacGiaDAL();

        // Lấy danh sách tác giả
        public List<TacGia> GetAllTacGia()
        {
            return tacGiaDAL.GetAllTacGia();
        }

        // Thêm tác giả mới với logic kiểm tra
        public string AddTacGia(string tenTG)
        {
            if (string.IsNullOrWhiteSpace(tenTG))
            {
                return "Tên tác giả không được để trống!";
            }


            // Kiểm tra trùng lặp tên tác giả
            var existingName = tacGiaDAL.GetAllTacGia().FirstOrDefault(i => i.TenTG == tenTG);
            if (existingName != null)
            {
                return "Tên tác giả đã tồn tại.";
            }


            var tacGia = new TacGia
            {
                TenTG = tenTG
            };

            tacGiaDAL.AddTacGia(tacGia);
            return "Thêm tác giả thành công!";
        }

        public string UpdateTacGia(int id, string tenTG)
        {
            var existingTacGia = tacGiaDAL.GetAllTacGia().FirstOrDefault(i => i.Id == id);
            if (existingTacGia != null)
            {
                if (string.IsNullOrWhiteSpace(tenTG))
                {
                    return "Không được để trống thông tin!";
                }

                //Kiểm tra email trùng lặp, loại trừ khách hàng hiện tại
                var existingTenTacGia = tacGiaDAL.GetAllTacGia()
                                            .FirstOrDefault(i => i.TenTG == tenTG && i.Id != id);
                if (existingTenTacGia != null)
                {
                    return "Tên tác giả đã tồn tại.";
                }

                var tacGia = new TacGia
                {
                    Id = id,
                    TenTG = tenTG
                };

                bool kq = tacGiaDAL.UpdateTacGia(tacGia);
                if (kq)
                {
                    return "Cập nhật thông tin tác giả thành công";
                }
                else
                {
                    return "Cập nhật thông tin tác giả thất bại";
                }
            }
            else
            {
                return "Mã tác giả không tồn tại";
            }
        }

        public string DeleteTacGia(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id) || !int.TryParse(Id, out int parsedId))
            {
                return "Mã tác giả không hợp lệ";
            }

            bool kq = tacGiaDAL.DeleteTacGia(parsedId);
            if (kq)
            {
                return "Xóa tác giả thành công";
            }
            else
            {
                return "Xóa tác giả thất bại!";
            }
        }

        public List<TacGia> FindTacGiaByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<TacGia>();
            }
            return tacGiaDAL.FindTacGiaByName(name);
        }
    }
}
