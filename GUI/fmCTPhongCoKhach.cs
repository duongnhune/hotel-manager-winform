using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmCTPhongCoKhach : Form
    {
        private tb_Phong _phong;
        private tb_PhieuDatPhong _phieuDatPhong;
        private tb_CTDatPhong _ctDatPhong;
        private tb_HoaDon _hoaDon;

        public fmCTPhongCoKhach(tb_Phong phong)
        {
            InitializeComponent();
            _phong = phong;

            GetData();
        }

        private void GetData()
        {
            // Get unpaid invoices
            List<tb_HoaDon> hoaDons = HoaDonBLL.GetUnpaidInvoices();
            // Get reserved tickets of unpaid invoices
            List<tb_PhieuDatPhong> phieuDatPhongs = hoaDons.Select(hd => hd.tb_PhieuDatPhong).ToList();

            foreach (var phieu in phieuDatPhongs)
            {
                foreach (var ctDatPhong in phieu.tb_CTDatPhongs)
                {
                    if (ctDatPhong.MaPhong.Equals(_phong.MaPhong))
                    {
                        _phieuDatPhong = phieu;
                        _ctDatPhong = ctDatPhong;
                        _hoaDon = HoaDonBLL.GetInvoiceByReservedTicket(phieu.MaPhieuDat);
                        return;
                    }
                }
            }
        }

        private void FmCTPhongCoKhach_Load(object sender, EventArgs e)
        {
            try
            {
                Text = $"Thông tin phòng - {_phong.TenPhong}";
                lblKhachHang.Text = KhachHangBLL.GetCustomer(_phieuDatPhong.CCCD).HoTen;
                lblTamTinh.Text = String.Format("{0:#,##0}", _hoaDon.TongTien);
            }
            catch
            {

            }
        }

        private void BtnThemDichVu_Click(object sender, EventArgs e)
        {
            List<tb_CTDatPhong> lstCTDatPhong = new List<tb_CTDatPhong>();
            lstCTDatPhong.Add(_ctDatPhong);
            fmThemDichVu fmThemDichVu = new fmThemDichVu(lstCTDatPhong);
            fmThemDichVu.ShowDialog();
            Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            fmThanhToan fmThanhToan = new fmThanhToan(_ctDatPhong);
            Close();
            fmThanhToan.ShowDialog();
        }
    }
}