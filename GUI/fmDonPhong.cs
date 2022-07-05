using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDonPhong : Form
    {
        private string _maPhong;

        public fmDonPhong(string maPhong)
        {
            InitializeComponent();
            _maPhong = maPhong;
        }

        private void btnDaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận đã dọn phòng.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PhongBLL.UpdateStatus(_maPhong, "Phòng trống");
                fmDangNhap.mainForm.barBtnSoDoPhong.PerformClick();
                this.Close();
            }
        }

        private void btnChuaDon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}