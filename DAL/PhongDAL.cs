using DTO;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL
{
    public class PhongDAL
    {
        private HyggeDbDataContext dataContext = new HyggeDbDataContext();

        /// <summary>
        /// Get list all of rooms
        /// </summary>
        /// <returns>List all of rooms</returns>
        public List<tb_Phong> GetRooms()
        {
            return dataContext.tb_Phongs.ToList();
        }

        /// <summary>
        /// Get list all of rooms by floor
        /// </summary>
        /// <param name="tangLau">Floor</param>
        /// <returns>List all of rooms</returns>
        public List<tb_Phong> GetRooms(tb_TangLau tangLau)
        {
            return dataContext.tb_Phongs.Where(p => p.MaTang.Equals(tangLau.MaTang)).ToList();
        }

        public void UpdateStatus(string maPhong, string trangThai)
        {
            try
            {
                tb_Phong phong = dataContext.tb_Phongs.Single(p => p.MaPhong.Equals(maPhong));
                phong.TrangThai = trangThai;
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void UpdateStatusPhongByMaPhieu(string maPhieus, string trangThai)
        {
            try
            {
                var items = dataContext.tb_CTDatPhongs.Where(t => t.MaPhieuDat.Equals(maPhieus)).ToList();
                foreach (var item in items)
                {
                    tb_Phong phong = dataContext.tb_Phongs.Single(p => p.MaPhong.Equals(item.MaPhong));
                    phong.TrangThai = trangThai;
                }
                dataContext.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Count the number of rooms by status
        /// </summary>
        /// <param name="trangThai">Status want to count</param>
        /// <returns>Number of rooms</returns>
        public int Count(string trangThai = null)
        {
            switch (trangThai)
            {
                case "Phòng trống":
                    return dataContext.tb_Phongs.Where(p => p.TrangThai.Equals("Phòng trống")).Count();

                case "Đang có khách":
                    return dataContext.tb_Phongs.Where(p => p.TrangThai.Equals("Đang có khách")).Count();

                case "Chưa dọn":
                    return dataContext.tb_Phongs.Where(p => p.TrangThai.Equals("Chưa dọn")).Count();

                default:
                    return dataContext.tb_Phongs.Count();
            }
        }
    }
}