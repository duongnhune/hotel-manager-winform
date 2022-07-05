using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class CTDatPhongDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get list of details reserved ticket by reserved ticket ID
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>List of detail reserved ticket</returns>
        public List<tb_CTDatPhong> GetDetailReservedTicket(string maPhieuDatPhong)
        {
            return dataContext.tb_CTDatPhongs.Where(x => x.MaPhieuDat.Equals(maPhieuDatPhong)).ToList();
        }

        /// <summary>
        /// Get list of details reserved ticket for a period of time
        /// </summary>
        /// <param name="from">From</param>
        /// <param name="to">To</param>
        /// <returns>List of detail reserved ticket</returns>
        public List<tb_CTDatPhong> GetDetailReservedTicket(DateTime from, DateTime to)
        {
            return dataContext.tb_CTDatPhongs.Where(x => x.CheckIn.Value.Date >= from.Date && x.CheckOut.Value.Date <= to.Date).ToList();
        }
    }
}