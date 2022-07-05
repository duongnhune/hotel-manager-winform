using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhieuDatPhongDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get reserved ticket
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>Reserved ticket</returns>
        public tb_PhieuDatPhong GetReservedTicket(string maPhieuDatPhong)
        {
            return dataContext.tb_PhieuDatPhongs.Where(x => x.MaPhieuDat.Equals(maPhieuDatPhong)).FirstOrDefault();
        }
        public List<tb_PhieuDatPhong> GetReservedTicket(bool daHuy)
        {
            return dataContext.tb_PhieuDatPhongs.Where(x => x.DaHuy == daHuy).ToList();
        }
    }
}