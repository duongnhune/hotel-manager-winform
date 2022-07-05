using BLL;
using DTO;
using GUI.ReportViewer;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThanhToan : Form
    {
        private tb_CTDatPhong _ctDatPhong;
        private tb_HoaDon _hoaDon;

        public fmThanhToan(tb_CTDatPhong _ctDatPhong)
        {
            InitializeComponent();
            this._ctDatPhong = _ctDatPhong;
            _hoaDon = HoaDonBLL.GetInvoiceByReservedTicket(_ctDatPhong.MaPhieuDat);
        }

        private void fmThanhToan_Load(object sender, EventArgs e)
        {
            LoadListProduct();
            LoadPhieuDatPhong();
            LoadChiTietPhong();
            LoadHoaDon();
            nudGiamTru.Minimum = 0;
        }

        private void LoadListProduct()
        {
            HyggeDbDataContext db = new HyggeDbDataContext();
            var temp = db.tb_CTDatPhong_SanPhams
                .Where(t => t.MaCTDatPhong == _ctDatPhong.MaCTDatPhong)
                .Select(t => new
                {
                    TenSanPham = t.tb_SanPham.TenSanPham,
                    DonGia = t.tb_SanPham.DonGia,
                    SoLuong = t.SoLuong,
                }).ToList();

            int i = 1;
            // Add to datagridview
            dgvDsSanPham.Rows.Clear();
            foreach (var item in temp)
            {
                dgvDsSanPham.Rows.Add(i, item.TenSanPham, string.Format("{0:#,##0}", item.DonGia), item.SoLuong, string.Format("{0:#,##0}", item.DonGia * item.SoLuong));
                i++;
            }
        }

        private void LoadPhieuDatPhong()
        {
            var phieuDatPhong = PhieuDatPhongBLL.GetReservedTicket(_ctDatPhong.MaPhieuDat);
            txtMaPhieu.Text = phieuDatPhong.MaPhieuDat;
            txtCCCD.Text = phieuDatPhong.CCCD;
            txtHoTenKH.Text = phieuDatPhong.tb_KhachHang.HoTen;
            txtLoaiHinh.Text = phieuDatPhong.LoaiHinh;
            txtHoTenNV.Text = phieuDatPhong.tb_NhanVien.HoTen;
            txtNgayLap.Text = phieuDatPhong.NgayLap.ToString();
        }

        private void LoadChiTietPhong()
        {
            var items = CTDatPhongBLL.GetDetailReservedTicket(_ctDatPhong.MaPhieuDat).Select(t => new {
                t.tb_Phong.TenPhong,
                t.SoLuongNguoiLon,
                t.SoLuongTreEm,
                t.CheckIn,
                t.CheckOut,
                ThanhTien = string.Format("{0:#,##0}", t.ThanhTien)
            }).ToList();

            dgvPhong.DataSource = items;
        }

        private void LoadHoaDon()
        {
            txtMaHoaDon.Text = _hoaDon.MaHD;
            txtTraTruoc.Text = string.Format("{0:#,##0 đ}", _hoaDon.tb_PhieuDatPhong.TraTruoc);
            txtTongTien.Text = string.Format("{0:#,##0 đ}", _hoaDon.TongTien);
            nudGiamTru.Value = _hoaDon.GiamTru == null ? 0 : (decimal)_hoaDon.GiamTru;

            TongTien();
        }

        private void dgvDsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //fmDangNhap.mainForm.barBtnSoDoPhong.PerformClick();
            this.Close();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thanh toán.", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    PhongBLL.UpdateStatusPhongByMaPhieu(_hoaDon.tb_PhieuDatPhong.MaPhieuDat, "Chưa dọn");

                    _hoaDon.GiamTru = nudGiamTru.Value;
                    _hoaDon.ThanhTien = _hoaDon.TongTien - nudGiamTru.Value - _hoaDon.tb_PhieuDatPhong.TraTruoc;
                    _hoaDon.TrangThai = true;

                    HoaDonBLL.Update(_hoaDon);
                    lbResult.Text = "Thanh toán thành công.";
                    fmDangNhap.mainForm.barBtnSoDoPhong.PerformClick();
                    btnThanhToan.Enabled = false;
                }
                catch
                {
                    lbResult.Text = "Thanh toán thất bại.";
                }
            }
        }

        private void nudGiamTru_ValueChanged(object sender, EventArgs e)
        {
            TongTien();
        }

        private void nudGiamTru_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void TongTien()
        {
            nudGiamTru.Maximum = HoaDonBLL.MaximumDiscount(_ctDatPhong.MaPhieuDat);

            decimal thanhTien = HoaDonBLL.IntoMoney(nudGiamTru.Value, _ctDatPhong.MaPhieuDat);
            if (thanhTien == -1)
            {
                MessageBox.Show("Số tiền giảm trừ không hợp lệ");
            }
            else
            {
                txtSoTienPhaiThanhToan.Text = string.Format("{0:#,##0 đ}", thanhTien);
            }
        }

        private void nudGiamTru_KeyUp(object sender, KeyEventArgs e)
        {
            TongTien();
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            fmReport fm = new fmReport(_ctDatPhong);
            fm.ShowDialog();
        }

        private void txtSoTienPhaiThanhToan_Click(object sender, EventArgs e)
        {

        }
    }
}