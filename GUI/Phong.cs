using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class Phong
    {
        private string trangThai;
        private string maPhong;
        private string tenPhong;

        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string MaPhong { get => maPhong; set => maPhong = value; }
        public string TenPhong { get => tenPhong; set => tenPhong = value; }

        public Phong(string trangThai, string maPhong, string tenPhong)
        {
            this.trangThai = trangThai;
            this.maPhong = maPhong;
            this.tenPhong = tenPhong;
        }
    }
}
