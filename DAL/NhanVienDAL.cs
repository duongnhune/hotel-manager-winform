using DTO;
using System.Linq;

namespace DAL
{
    public class NhanVienDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        public tb_NhanVien GetEmployee(string tenDangNhap)
        {
            return dataContext.tb_NhanViens.Where(nv => nv.TenDangNhap.Equals(tenDangNhap)).FirstOrDefault();
        }
    }
}