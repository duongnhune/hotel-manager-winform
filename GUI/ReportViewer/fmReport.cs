using DTO;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.ReportViewer
{
    public partial class fmReport : Form
    {
        private tb_CTDatPhong _ctDatPhong;
        HyggeDbDataContext db = new HyggeDbDataContext();
        public fmReport(tb_CTDatPhong _ctDatPhong)
        {
            InitializeComponent();
            this._ctDatPhong = _ctDatPhong;
            WindowState = FormWindowState.Maximized;
        }

        private void fmReport_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            LoadReport();

        }

        public void LoadReport()
        {
            var phieuDatPhong = db.tb_PhieuDatPhongs.Where(x => x.MaPhieuDat == _ctDatPhong.MaPhieuDat).FirstOrDefault();
            var chiTietDatPhong = db.tb_CTDatPhongs.Where(x => x.MaPhieuDat == _ctDatPhong.MaPhieuDat).ToList();
            var chiTietDatPhong_SanPham = db.tb_CTDatPhong_SanPhams.Where(x => x.MaSanPham == x.tb_SanPham.MaSanPham && x.tb_CTDatPhong.MaPhieuDat == _ctDatPhong.MaPhieuDat).ToList();
            var maHoaDon = db.tb_HoaDons.Where(x => x.MaPhieuDat == _ctDatPhong.MaPhieuDat).SingleOrDefault();


            

            this.reportViewer1.LocalReport.ReportPath = @"C:\Users\hungt\OneDrive\Desktop\New folder\QL_KhachSan\GUI\ReportViewer\Report1.rdlc";

            List<CustomizeModel> listItem = new List<CustomizeModel>();
            for (int i = 0; i < chiTietDatPhong_SanPham.Count; i++)
            {
                CustomizeModel item = new CustomizeModel();
                item.maSp = chiTietDatPhong_SanPham[i].MaSanPham.ToString();
                item.tenSp = chiTietDatPhong_SanPham[i].tb_SanPham.TenSanPham.ToString();
                item.soLuong = (int)chiTietDatPhong_SanPham[i].SoLuong;
                item.donGia = chiTietDatPhong_SanPham[i].tb_SanPham.DonGia;
                item.tongTien = (decimal)chiTietDatPhong_SanPham[i].ThanhTien;

                listItem.Add(item);
            }

            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = ZoomMode.Percent;
            this.reportViewer1.ZoomPercent = 100;
            reportViewer1.LocalReport.DataSources.Clear();

            var soureChiTietDatPhong = new ReportDataSource("tb_ChiTietDatPhong", chiTietDatPhong);
            reportViewer1.LocalReport.DataSources.Add(soureChiTietDatPhong);

            var soureChiTietDatPhong_SanPham = new ReportDataSource("tb_DichVu", listItem);
            reportViewer1.LocalReport.DataSources.Add(soureChiTietDatPhong_SanPham);

            ReportParameterInfoCollection parainfos = reportViewer1.LocalReport.GetParameters();
            ReportParameterCollection paras = new ReportParameterCollection();
            ReportParameter para;

            if (CheckExistsParameter(parainfos, "maPhieuDatPhong"))
            {
                para = new ReportParameter("maPhieuDatPhong", phieuDatPhong.MaPhieuDat.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "hoTen"))
            {
                para = new ReportParameter("hoTen", phieuDatPhong.tb_KhachHang.HoTen.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "cccd"))
            {
                para = new ReportParameter("cccd", phieuDatPhong.CCCD.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "ngayLap"))
            {
                para = new ReportParameter("ngayLap", phieuDatPhong.NgayLap.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "loaiHinh"))
            {
                para = new ReportParameter("loaiHinh", phieuDatPhong.LoaiHinh.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "maHoaDon"))
            {
                para = new ReportParameter("maHoaDon", maHoaDon.MaHD.ToString());
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "tongThanhTien"))
            {
                var tongTien = maHoaDon.TongTien;
                if (string.IsNullOrEmpty(tongTien.ToString()))
                {
                    tongTien = 0;
                }
                para = new ReportParameter("tongThanhTien", string.Format("{0:#,##0}", tongTien));
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "giamTru"))
            {
                var giamTru = maHoaDon.GiamTru;
                if (string.IsNullOrEmpty(giamTru.ToString()))
                {
                    giamTru = 0;
                }
                para = new ReportParameter("giamTru", string.Format("{0:#,##0}", giamTru));
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "tienDichVu"))
            {
                var dichVu = chiTietDatPhong_SanPham.Sum(x => x.ThanhTien);
                if (string.IsNullOrEmpty(dichVu.ToString()))
                {
                    dichVu = 0;
                }
                para = new ReportParameter("tienDichVu", string.Format("{0:#,##0}", dichVu));
                paras.Add(para);
            }
            if (CheckExistsParameter(parainfos, "tongTienPhong"))
            {
                var tienPhong = chiTietDatPhong.Sum(x => x.ThanhTien);
                if (string.IsNullOrEmpty(tienPhong.ToString()))
                {
                    tienPhong = 0;
                }
                para = new ReportParameter("tongTienPhong", string.Format("{0:#,##0}", tienPhong));
                paras.Add(para);
            }
            this.reportViewer1.LocalReport.SetParameters(paras);
            this.reportViewer1.RefreshReport();

        }

        public bool CheckExistsParameter(ReportParameterInfoCollection parainfos, string paraName)
        {
            foreach (ReportParameterInfo pi in parainfos)
            {
                if (pi.Name == paraName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
