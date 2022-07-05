using DAL;
using DTO;

namespace BLL
{
    public class NhanVienBLL
    {
        public static tb_NhanVien GetEmployee(string tenDangNhap)
        {
            return new NhanVienDAL().GetEmployee(tenDangNhap);
        }
    }
}