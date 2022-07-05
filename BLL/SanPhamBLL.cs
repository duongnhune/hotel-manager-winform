using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class SanPhamBLL
    {
        /// <summary>
        /// Get list of all products
        /// </summary>
        /// <returns>List of all products</returns>
        public static List<tb_SanPham> GetProducts()
        {
            return new SanPhamDAL().GetProducts();
        }

        /// <summary>
        /// Get product by product ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns>Product</returns>
        public static tb_SanPham GetProducts(string maSanPham)
        {
            return new SanPhamDAL().GetProducts(maSanPham);
        }

        public static bool removeProduct(string id)
        {
             return new SanPhamDAL().removeProduct(id);
        }

        public static bool UpdateProduct(tb_SanPham sp)
        {
             return new SanPhamDAL().UpdateProduct(sp);
        }

        public static bool AddProduct(tb_SanPham sp)
        {
             return new SanPhamDAL().AddProduct(sp);
        }
        public static bool CheckName(string name)
        {
            return new SanPhamDAL().CheckName(name);
        }
    }
}