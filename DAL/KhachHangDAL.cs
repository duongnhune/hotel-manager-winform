using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class KhachHangDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get a customer by id
        /// </summary>
        /// <param name="id">Customer ID</param>
        /// <returns>A customer</returns>
        public tb_KhachHang GetCustomer(string id)
        {
            return dataContext.tb_KhachHangs.FirstOrDefault(kh => kh.CCCD.Equals(id));
        }

        /// <summary>
        /// Get a list of all customers
        /// </summary>
        /// <returns>List of all customers</returns>
        public List<tb_KhachHang> GetCustomers()
        {
            return dataContext.tb_KhachHangs.ToList();
        }

        public bool AddCustomers(tb_KhachHang khachHang)
        {
            var checkCCCD = dataContext.tb_KhachHangs.Where(x => x.CCCD == khachHang.CCCD).FirstOrDefault();

            if(checkCCCD == null)
            {
                dataContext.tb_KhachHangs.InsertOnSubmit(khachHang);
                dataContext.SubmitChanges();
                return true;
            }
            return false;
        }
        public tb_KhachHang GetListKhachHangByCCCD(string cccd)
        {
            return dataContext.tb_KhachHangs.FirstOrDefault(x => x.CCCD.Equals(cccd));
        }
    }
}