using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DatPhongBLL
    {
        /// <summary>
        /// Perform booking business
        /// </summary>
        /// <param name="phieuDatPhong">Reserved ticket</param>
        /// <param name="ctDatPhongs">List of details reserved ticket</param>
        public static void Booking(tb_PhieuDatPhong phieuDatPhong, List<tb_CTDatPhong> ctDatPhongs)
        {
            new DatPhongDAL().Booking(phieuDatPhong, ctDatPhongs);
        }

        public static void Checkin(tb_PhieuDatPhong phieuDatPhong, List<tb_CTDatPhong> ctDatPhongs, double tamTinh)
        {
            // Get the MaHoaDon by concatenating the prefix "HD" with the value selected in the Identify table as the suffix
            string maHoaDon = $"HD{(IdentifyBLL.GetCounter("PhieuDatPhong") + 1).ToString().PadLeft(5, '0')}";
            tb_HoaDon hoaDon = new tb_HoaDon
            {
                MaHD = maHoaDon,
                MaPhieuDat = phieuDatPhong.MaPhieuDat,
                TongTien = (decimal)tamTinh,
                NgayLap = phieuDatPhong.NgayLap,
                TrangThai = false
            };
            new DatPhongDAL().Checkin(phieuDatPhong, ctDatPhongs, hoaDon);

            // Update status for room after check-in
            foreach (var ctDatPhong in ctDatPhongs)
            {
                PhongBLL.UpdateStatus(ctDatPhong.MaPhong, "Đang có khách");
            }
        }

        /// <summary>
        /// Calculate subtotal for detail of the reserved ticket
        /// </summary>
        /// <param name="loaiHinh">Rental type</param>
        /// <param name="ctDatPhong">Detail of reserved ticket</param>
        /// <returns>Subtotal for detailed reserved ticket</returns>
        public static double CalcSubtotal(string loaiHinh, tb_CTDatPhong ctDatPhong)
        {
            double total = 0;

            // Room charge
            tb_Gia gia = GiaBLL.GetPrice(ctDatPhong.MaPhong);
            if (loaiHinh.Equals("Ngày"))
            {
                double donGia = (double)gia.DonGiaNgay;
                double diffDays = ctDatPhong.CheckOut.GetValueOrDefault().Subtract(ctDatPhong.CheckIn.GetValueOrDefault()).TotalDays;

                // Surcharge for late check-out (after 14:00)
                diffDays = ctDatPhong.CheckOut.Value.Hour > 14 || ctDatPhong.CheckOut.Value.Hour == 14 && ctDatPhong.CheckOut.Value.Minute > 0 ? Math.Round(diffDays + 1) : Math.Round(diffDays);

                total += donGia * diffDays;
            }
            else // "Đơn giá giờ"
            {
                double donGia = (double)gia.DonGiaGio;
                double diffHours = ctDatPhong.CheckOut.GetValueOrDefault().Subtract(ctDatPhong.CheckIn.GetValueOrDefault()).TotalHours;

                total += donGia * diffHours;
            }

            // Product and service charge
            foreach (var ctDatPhong_SanPham in ctDatPhong.tb_CTDatPhong_SanPhams)
            {
                var sanPham = SanPhamBLL.GetProducts(ctDatPhong_SanPham.MaSanPham);
                total += (double)(sanPham.DonGia * ctDatPhong_SanPham.SoLuong);
            }

            return total;
        }

        /// <summary>
        /// Calculate the total amount
        /// </summary>
        /// <param name="loaiHinh">Rental type</param>
        /// <param name="ctDatPhongs">List of details reserved ticket</param>
        /// <returns>Total amount of reserved ticket</returns>
        public static double CalcTotalAmount(string loaiHinh, List<tb_CTDatPhong> ctDatPhongs)
        {
            double totalAmount = 0;

            foreach (var ctDatPhong in ctDatPhongs)
            {
                totalAmount += CalcSubtotal(loaiHinh, ctDatPhong);
            }

            return totalAmount;
        }

        /// <summary>
        /// Validate check-in time
        /// </summary>
        /// <param name="checkin">Check-in time</param>
        /// <param name="checkout">Check-out time</param>
        /// <returns>True if check-in time from current time and less than or equal to check-out time; otherwise false</returns>
        public static bool IsValidCheckIn(DateTime checkin, DateTime checkout)
        {
            return checkin.Year - DateTime.Now.Year >= 0 && checkin.Day - DateTime.Now.Day >= 0 && checkin.CompareTo(checkout) <= 0;
        }

        /// <summary>
        /// Validate check-out time
        /// </summary>
        /// <param name="checkin">Check-in time</param>
        /// <param name="checkout">Check-out time</param>
        /// <returns>True if check-out time greater than check-in time; otherwise false</returns>
        public static bool IsValidCheckOut(DateTime checkin, DateTime checkout)
        {
            return checkout.CompareTo(checkin) >= 0;
        }

        /// <summary>
        /// Validate customer
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>True if customer exist in the database, otherwise false</returns>
        public static bool IsValidCustomer(string id)
        {
            return id != null && id.Trim().Length > 0 && KhachHangBLL.GetCustomer(id) != null;
        }

        /// <summary>
        /// Validate deposit money
        /// </summary>
        /// <param name="deposit">Deposit money</param>
        /// <returns>True if the deposit is greater than 0 and less than or equal to the total amount; otherwise false</returns>
        public static bool IsValidDeposit(double deposit, double totalAmount)
        {
            return deposit >= 0 && deposit <= totalAmount;
        }
    }
}
