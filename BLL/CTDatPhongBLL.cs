using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CTDatPhongBLL
    {
        /// <summary>
        /// Get list of detail reserved ticket by reserved ticket ID
        /// </summary>
        /// <param name="maPhieuDatPhong">Reserved ticket ID</param>
        /// <returns>List of detail reserved ticket</returns>
        public static List<tb_CTDatPhong> GetDetailReservedTicket(string maPhieuDatPhong)
        {
            return new CTDatPhongDAL().GetDetailReservedTicket(maPhieuDatPhong);
        }

        /// <summary>
        /// Get list of details reserved ticket for a period of time
        /// </summary>
        /// <param name="from">From</param>
        /// <param name="to">To</param>
        /// <returns>List of detail reserved ticket</returns>
        public static List<tb_CTDatPhong> GetDetailReservedTicket(DateTime from, DateTime to)
        {
            return new CTDatPhongDAL().GetDetailReservedTicket(from, to);
        }
    }
}