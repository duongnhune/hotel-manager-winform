using DTO;
using System;
using System.Linq;

namespace DAL
{
    public class TaiKhoanDAL
    {
        public bool checkUsernameExist(String username)
        {
            bool isExist = false;
            using (var db = new HyggeDbDataContext())
            {
                var acc = db.tb_TaiKhoans.Where(t => t.TenDangNhap.Equals(username)).FirstOrDefault();
                if (acc != null)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        public bool checkPassword(String username, String password)
        {
            bool isExist = false;
            using (var db = new HyggeDbDataContext())
            {
                var acc = db.tb_TaiKhoans.Where(t => t.TenDangNhap.Equals(username) && t.MatKhau.Equals(password)).FirstOrDefault();
                if (acc != null)
                {
                    isExist = true;
                }
            }
            return isExist;
        }

        public bool changePassword(String username, String passwordOld, String passwordNew)
        {
            using (var db = new HyggeDbDataContext())
            {
                tb_TaiKhoan taiKhoan = db.tb_TaiKhoans.Where(t => t.TenDangNhap.Equals(username) && t.MatKhau.Equals(passwordOld)).FirstOrDefault();
                if (taiKhoan != null)
                {
                    taiKhoan.MatKhau = passwordNew;
                    db.SubmitChanges();
                    return true;
                }
            }
            return false;
        }
    }
}