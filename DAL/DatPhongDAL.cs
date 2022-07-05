using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DatPhongDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();
        /// <summary>
        /// Perform reservation
        /// </summary>
        /// <param name="phieuDatPhong">Reserved ticket</param>
        /// <param name="ctDatPhongs">List of detail reserved ticket</param>
        /// <param name="hoaDon">Invoice for check-in business. Default is false</param>
        public void Booking(tb_PhieuDatPhong phieuDatPhong, List<tb_CTDatPhong> ctDatPhongs)
        {
            phieuDatPhong.tb_CTDatPhongs.AddRange(ctDatPhongs);
            dataContext.tb_PhieuDatPhongs.InsertOnSubmit(phieuDatPhong);

            dataContext.SubmitChanges(); // save it all.
        }

        /// <summary>
        /// Perform check-in
        /// </summary>
        /// <param name="phieuDatPhong">Reserved ticket</param>
        /// <param name="ctDatPhongs">List of detail reserved ticket</param>
        /// <param name="hoaDon">Invoice</param>
        public void Checkin(tb_PhieuDatPhong phieuDatPhong, List<tb_CTDatPhong> ctDatPhongs, tb_HoaDon hoaDon)
        {
            phieuDatPhong.tb_CTDatPhongs.AddRange(ctDatPhongs);
            phieuDatPhong.tb_HoaDons.Add(hoaDon);
            dataContext.tb_PhieuDatPhongs.InsertOnSubmit(phieuDatPhong);

            dataContext.SubmitChanges(); // save it all.
        }
    }
}
