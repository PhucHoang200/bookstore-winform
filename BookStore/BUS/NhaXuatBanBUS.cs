using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaXuatBanBUS
    {
        private NhaXuatBanDAL nhaXuatBanDAL = new NhaXuatBanDAL();

        // Lấy danh sách khách hàng
        public List<NhaXuatBan> GetAllTheLoai()
        {
            return nhaXuatBanDAL.GetAllNhaXuatBan();
        }

        // Thêm khách hàng mới với logic kiểm tra
        public string AddNhaXuatBan(string tenNXB)
        {
            if (string.IsNullOrWhiteSpace(tenNXB))
            {
                return "Tên nhà xuất bản không được để trống!";
            }


            // Kiểm tra trùng lặp số điện thoại
            var existingName = nhaXuatBanDAL.GetAllNhaXuatBan().FirstOrDefault(i => i.TenNXB == tenNXB);
            if (existingName != null)
            {
                return "Tên nhà xuất bản đã tồn tại.";
            }


            var nhaXuatBan = new NhaXuatBan
            {
                TenNXB = tenNXB
            };

            nhaXuatBanDAL.AddNhaXuatBan(nhaXuatBan);
            return "Thêm nhà xuất bản thành công!";
        }

        public string UpdateNhaXuatBan(int id, string tenNXB)
        {
            var existingNXB = nhaXuatBanDAL.GetAllNhaXuatBan().FirstOrDefault(i => i.Id == id);
            if (existingNXB != null)
            {
                if (string.IsNullOrWhiteSpace(tenNXB))
                {
                    return "Không được để trống thông tin!";
                }

                var existingTenNXB = nhaXuatBanDAL.GetAllNhaXuatBan()
                                            .FirstOrDefault(i => i.TenNXB == tenNXB && i.Id != id);
                if (existingTenNXB != null)
                {
                    return "Tên nhà xuất bản đã tồn tại.";
                }

                var nhaXuatBan = new NhaXuatBan
                {
                    Id = id,
                    TenNXB = tenNXB
                };

                bool kq = nhaXuatBanDAL.UpdateNhaXuatBan(nhaXuatBan);
                if (kq)
                {
                    return "Cập nhật thông tin nhà xuất bản thành công";
                }
                else
                {
                    return "Cập nhật thông tin nhà xuất bản thất bại";
                }
            }
            else
            {
                return "Mã nhà xuất bản không tồn tại";
            }
        }

        public string DeleteNhaXuatBan(string Id)
        {
            if (string.IsNullOrWhiteSpace(Id) || !int.TryParse(Id, out int parsedId))
            {
                return "Mã nhà xuất bản không hợp lệ";
            }
            bool kq = nhaXuatBanDAL.DeleteNhaXuatBan(parsedId);

            if (kq)
            {
                return "Xóa nhà xuất bản thành công";
            }
            else
            {
                return "Xóa nhà xuất bản thất bại!";
            }
        }

        public List<NhaXuatBan> FindNhaXuatBanByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<NhaXuatBan>();
            }
            return nhaXuatBanDAL.FindNhaXuatBanByName(name);
        }
    }
}
