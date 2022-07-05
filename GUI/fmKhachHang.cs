using BLL;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public fmKhachHang()
        {
            InitializeComponent();
        }

        private void tileBar1_Click(object sender, EventArgs e)
        {

        }

        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            dgvKhachHangs.AutoGenerateColumns = false;
            dgvKhachHangs.DataSource = KhachHangBLL.GetCustomers();
            rgGioiTinh.SelectedIndex = 1;
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioGroup1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void gcDsKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHangs.CurrentRow != null)
            {
                string strCMND = dgvKhachHangs.CurrentRow.Cells[0].Value.ToString();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            fmThemKhachHang f = new fmThemKhachHang();
            f.ShowDialog();

            dgvKhachHangs.AutoGenerateColumns = false;
            dgvKhachHangs.DataSource = KhachHangBLL.GetCustomers();
            rgGioiTinh.SelectedIndex = 1;
        }
    }
}