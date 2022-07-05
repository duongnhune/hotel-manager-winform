using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class Tang
    {
        private string maTang;
        private string tenTang;
        private List<Phong> ltPhong;

        public string MaTang { get => maTang; set => maTang = value; }
        public string TenTang { get => tenTang; set => tenTang = value; }
        internal List<Phong> LtPhong { get => ltPhong; set => ltPhong = value; }


        public Tang(string maTang, string tenTang, List<Phong> ltPhong)
        {
            this.maTang = maTang;
            this.tenTang = tenTang;
            this.ltPhong = ltPhong;
        }
    }
}
