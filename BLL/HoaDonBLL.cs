using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class HoaDonBLL
    {
        /// <summary>
        /// Get a invoice by invoice ID
        /// </summary>
        /// <param name="maHoaDon">Invoice ID</param>
        /// <returns>A invoice</returns>
        public static tb_HoaDon GetInvoice(string maHoaDon)
        {
            return new HoaDonDAL().GetInvoice(maHoaDon);
        }

        /// <summary>
        /// Get a invoice by reserved ticket ID
        /// </summary>
        /// <param name="maPhieuDat">Reserved ticket ID</param>
        /// <returns>A invoice</returns>
        public static tb_HoaDon GetInvoiceByReservedTicket(string maPhieuDat)
        {
            return new HoaDonDAL().GetInvoiceByReservedTicket(maPhieuDat);
        }

        /// <summary>
        /// Get list of all unpaid invoices
        /// </summary>
        /// <returns>list of all unpaid invoices</returns>
        public static List<tb_HoaDon> GetUnpaidInvoices()
        {
            return new HoaDonDAL().GetUnpaidInvoices();
        }

        public static void UpdateTotalAmount(string maPhieuDatPhong)
        {
            var hoaDon = GetInvoiceByReservedTicket(maPhieuDatPhong);
            using (HyggeDbDataContext dataContext = new HyggeDbDataContext())
            {
                var phieuDatPhong = PhieuDatPhongBLL.GetReservedTicket(maPhieuDatPhong);
                var ctDatPhongs = CTDatPhongBLL.GetDetailReservedTicket(maPhieuDatPhong);
                double totalAmount = DatPhongBLL.CalcTotalAmount(phieuDatPhong.LoaiHinh, ctDatPhongs);
                hoaDon.TongTien = (decimal)totalAmount;

                Update(hoaDon);
            }
        }

        public static void Update(tb_HoaDon hoaDonMoi)
        {
            new HoaDonDAL().Update(hoaDonMoi);
        }

        public static void UpdateStatus(string maHD, bool status)
        {
            new HoaDonDAL().UpdateStatus(maHD, status);
        }

        public static decimal MaximumDiscount(string maPhieuDatPhong)
        {
            tb_HoaDon _hoaDon = HoaDonBLL.GetInvoiceByReservedTicket(maPhieuDatPhong);
            if (_hoaDon != null)
            {
                decimal tongTien = (decimal)_hoaDon.TongTien;
                decimal traTruoc = (decimal)_hoaDon.tb_PhieuDatPhong.TraTruoc;

                return (tongTien - traTruoc);
            }
            return -1;
        }

        public static decimal IntoMoney(decimal giamTru, string maPhieuDatPhong)
        {
            decimal tinhTien = MaximumDiscount(maPhieuDatPhong);
            if (tinhTien != -1)
            {
                if (giamTru >= 0 && giamTru <= tinhTien)
                {
                    return (tinhTien - giamTru);
                }
                else return -1;
            }
            else return -1;
        }
    }
}