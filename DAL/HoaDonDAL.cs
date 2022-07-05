using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class HoaDonDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get a invoice by invoice ID
        /// </summary>
        /// <param name="maHoaDon">Invoice ID</param>
        /// <returns>A invoice</returns>
        public tb_HoaDon GetInvoice(string maHoaDon)
        {
            return dataContext.tb_HoaDons.FirstOrDefault(hoaDon => hoaDon.MaHD.Equals(maHoaDon));
        }

        /// <summary>
        /// Get a invoice by reserved ticket ID
        /// </summary>
        /// <param name="maPhieuDat">Reserved ticket ID</param>
        /// <returns>A invoice</returns>
        public tb_HoaDon GetInvoiceByReservedTicket(string maPhieuDat)
        {
            return dataContext.tb_HoaDons.FirstOrDefault(hoaDon => hoaDon.MaPhieuDat.Equals(maPhieuDat));
        }

        /// <summary>
        /// Get list of all unpaid invoices
        /// </summary>
        /// <returns>list of all unpaid invoices</returns>
        public List<tb_HoaDon> GetUnpaidInvoices()
        {
            return dataContext.tb_HoaDons.Where(hoaDon => hoaDon.TrangThai == false).ToList();
        }

        public void Update(tb_HoaDon hoaDonMoi)
        {
            var hoaDonCu = dataContext.tb_HoaDons.Where(x => x.MaHD.Equals(hoaDonMoi.MaHD)).FirstOrDefault();
            hoaDonCu.TongTien = hoaDonMoi.TongTien;
            hoaDonCu.GiamTru = hoaDonMoi.GiamTru;
            hoaDonCu.ThanhTien = hoaDonMoi.ThanhTien;
            hoaDonCu.TrangThai = hoaDonMoi.TrangThai;
            dataContext.SubmitChanges();
        }

        public void UpdateStatus(string maHD, bool status)
        {
            var hoaDonCu = dataContext.tb_HoaDons.Where(x => x.MaHD.Equals(maHD)).FirstOrDefault();
            hoaDonCu.TrangThai = status;
            dataContext.SubmitChanges();
        }
    }
}