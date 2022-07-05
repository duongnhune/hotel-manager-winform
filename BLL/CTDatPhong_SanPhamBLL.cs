using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class CTDatPhong_SanPhamBLL
    {
        public static void Update(List<tb_CTDatPhong> ctDatPhongs)
        {
            new CTDatPhong_SanPhamDAL().Update(ctDatPhongs);
        }

        public static List<tb_CTDatPhong_SanPham> GetCTDatPhong_SanPham(int maCTDatPhong)
        {
            return new CTDatPhong_SanPhamDAL().GetCTDatPhong_SanPham(maCTDatPhong);
        }
    }
}