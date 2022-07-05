using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThemDichVu : Form
    {
        private List<tb_CTDatPhong> _ctDatPhongs;

        public fmThemDichVu(List<tb_CTDatPhong> ctDatPhongs)
        {
            InitializeComponent();
            _ctDatPhongs = ctDatPhongs;

            UcSanPhamDichVu ucSanPhamDichVu = new UcSanPhamDichVu(ctDatPhongs)
            {
                Dock = DockStyle.Fill
            };
            panelContainer.Controls.Add(ucSanPhamDichVu);
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            CTDatPhong_SanPhamBLL.Update(_ctDatPhongs);
            Close();
            string maPhieuDatPhong = _ctDatPhongs[0].MaPhieuDat;
            HoaDonBLL.UpdateTotalAmount(maPhieuDatPhong);
        }

        private void fmThemDichVu_Load(object sender, EventArgs e)
        {
        }
    }
}