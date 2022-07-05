using DTO;
using System;
using System.Linq;

namespace DAL
{
    public class IdentifyDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        public int GetCounter(string parameter)
        {
            tb_Identify identify = dataContext.tb_Identifies.Select(i => i).First();
            switch (parameter)
            {
                case "Phong":
                    return (int)identify.Phong;

                case "NhanVien":
                    return (int)identify.NhanVien;

                case "SanPham":
                    return (int)identify.SanPham;

                case "PhieuDatPhong":
                    return (int)identify.PhieuDatPhong;

                case "HoaDon":
                    return (int)identify.HoaDon;

                default: throw new Exception("Invalid parameter.");
            }
        }
    }
}