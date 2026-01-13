using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhaCungCapBUS
    {
        private NhaCungCapDAL dal = new NhaCungCapDAL();

        public List<NhaCungCap> GetAllNhaCungCap()
        {
            return dal.GetAllNhaCungCap();
        }

        public bool AddNhaCungCap(string tenNCC)
        {
            return dal.AddNhaCungCap(tenNCC);
        }

        public bool UpdateNhaCungCap(int maNCC, string tenNCC)
        {
            return dal.UpdateNhaCungCap(maNCC, tenNCC);
        }

        public bool DeleteNhaCungCap(int maNCC)
        {
            return dal.DeleteNhaCungCap(maNCC);
        }

        public List<NhaCungCap> SearchNhaCungCap(string keyword)
        {
            // Tìm kiếm theo tên nhà cung cấp (không phân biệt chữ hoa/thường)
            return dal.GetAllNhaCungCap()
                      .Where(ncc => ncc.TenNCC.ToLower().Contains(keyword.ToLower()))
                      .ToList();
        }

        public bool IsTenNCCExists(string tenNCC)
        {
            return dal.IsTenNCCExists(tenNCC);
        }
    }
}
