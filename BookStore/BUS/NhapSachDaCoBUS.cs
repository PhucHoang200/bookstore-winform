using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhapSachDaCoBUS
    {
        private NhapSachDaCoDAL _dal = new NhapSachDaCoDAL();

        // Lấy danh sách nhà cung cấp
        public List<NhaCungCapViewModel> GetAllNhaCungCap()
        {
            return _dal.GetNhaCungCapList();
        }

        // Lấy danh sách sách theo nhà cung cấp
        public List<SachViewModel> GetSachByNhaCungCap(int nhaCungCapId)
        {
            return _dal.GetSachListByNhaCungCap(nhaCungCapId);
        }

        // Lấy danh sách sách
        public List<SachViewModel> LoadSachList()
        {
            return _dal.GetSachList();
        }

        // Lấy chi tiết sách theo Id
        public SachViewModel GetSachDetails(int sachId)
        {
            return _dal.GetSachDetailsById(sachId);
        }

        public int SavePhieuNhap(int nhaCungCapId, decimal tongTien)
        {
            return _dal.SavePhieuNhap(nhaCungCapId, tongTien);
        }

    }
}
