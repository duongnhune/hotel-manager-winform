using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class SanPhamDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get list of all products
        /// </summary>
        /// <returns>List of all products</returns>
        public List<tb_SanPham> GetProducts()
        {
            return dataContext.tb_SanPhams.ToList();
        }

        /// <summary>
        /// Get product by product ID
        /// </summary>
        /// <param name="maSanPham">Product ID</param>
        /// <returns>Product</returns>
        public tb_SanPham GetProducts(string maSanPham)
        {
            return dataContext.tb_SanPhams.FirstOrDefault(sp => sp.MaSanPham.Equals(maSanPham));
        }

        public bool removeProduct(string id)
        {
            var item = dataContext.tb_SanPhams.FirstOrDefault(x=>x.MaSanPham == id);
            if(item != null)
            {
                dataContext.tb_SanPhams.DeleteOnSubmit(item);
                dataContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool UpdateProduct(tb_SanPham sp)
        {
            var item = dataContext.tb_SanPhams.Where(x => x.MaSanPham == sp.MaSanPham).FirstOrDefault();
            if(item != null)
            {
                item.TenSanPham = sp.TenSanPham;
                item.DonGia = sp.DonGia;
                item.DonViTinh = sp.DonViTinh;
                item.MaNSP = sp.MaNSP;
                item.DaXoa = sp.DaXoa;

                dataContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool AddProduct(tb_SanPham sp)
        {
            if(sp != null)
            {
                dataContext.tb_SanPhams.InsertOnSubmit(sp);
                dataContext.SubmitChanges();
                return true;
            }
            return false;
        }

        public bool CheckName(string name)
        {
            var CheckName = dataContext.tb_SanPhams.Where(x => x.TenSanPham.ToLower().Trim() == name.ToLower().Trim()).ToList();
            if (CheckName.Count > 0)
            {
                return true;
            }
            return false;
        }
    }
}