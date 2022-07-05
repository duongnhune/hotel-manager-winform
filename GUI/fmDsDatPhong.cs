using DTO;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Drawing;


namespace GUI
{
    public partial class fmDsDatPhong : Form
    {
        List<tb_KhachHang> listKH;
        public fmDsDatPhong()
        {
            InitializeComponent();
            dataGridView2.AutoGenerateColumns = false;
        }

        private void LoadDgvKhachHang()
        {
            var lstPhieuDat = PhieuDatPhongBLL.GetReservedTicket(cbbTimKiem.SelectedItem.Equals("Đang đặt phòng") ? false : true);
            List<tb_KhachHang> lstKhachHang = new List<tb_KhachHang>();
            var lstCMND = lstPhieuDat.Select(x => x.CCCD).Distinct();
            foreach (var cmnd in lstCMND)
            {
                lstKhachHang.Add(KhachHangBLL.GetListKhachHangByCCCD(cmnd));
            }

            dataGridView2.DataSource = lstKhachHang;
        }
        private void fmDsDatPhong_Load(object sender, EventArgs e)
        {
            if (cbbTimKiem.SelectedValue != null)
            {
                //maPhong) = cbbTimKiem.SelectedValue.ToString();
                //LoadKhachHang(maPhong);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void cbbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDgvKhachHang();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}