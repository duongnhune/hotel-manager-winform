using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class PhieuDatPhongBLL
    {
        /// <summary>
        /// Get reserved ticket
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>Reserved ticket</returns>
        public static tb_PhieuDatPhong GetReservedTicket(string maPhieuDatPhong)
        {
            return new PhieuDatPhongDAL().GetReservedTicket(maPhieuDatPhong);
        }
        public static List<tb_PhieuDatPhong> GetReservedTicket(bool daHuy)
        {
            return new PhieuDatPhongDAL().GetReservedTicket(daHuy);
        }
    }
}