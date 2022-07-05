using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class KhachHangBLL
    {
        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>A customer</returns>
        public static tb_KhachHang GetCustomer(string id)
        {
            return new KhachHangDAL().GetCustomer(id);
        }

        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        public static List<tb_KhachHang> GetCustomers()
        {
            return new KhachHangDAL().GetCustomers();
        }

        public static bool AddCustomer(tb_KhachHang khachHang)
        {
            return new KhachHangDAL().AddCustomers(khachHang);
        }
        public static tb_KhachHang GetListKhachHangByCCCD(string cccd)
        {
            return new KhachHangDAL().GetListKhachHangByCCCD(cccd);
        }
    }
}