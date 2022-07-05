using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        private bool isClose = true;
        private static tb_NhanVien _nhanVien;
        private String username;
        public static tb_NhanVien NhanVien { get => _nhanVien; set => _nhanVien = value; }

        public Main(String username)
        {
            this.username = username;
            InitializeComponent();
            _nhanVien = NhanVienBLL.GetEmployee(username);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            mnHome.PerformClick();
        }

        private void BarBtnSoDoPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmSoDoPhong fmSoDoPhong = new fmSoDoPhong();
            OpenChildForm(fmSoDoPhong);
        }

        private void BarBtnDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDatPhong fmDatPhong = new fmDatPhong(new List<tb_Phong>());
            fmDatPhong.ShowDialog();
        }

        private void OpenChildForm(Form childForm)
        {
            if (MdiChildren.Length > 0)
            {
                foreach (var child in MdiChildren)
                {
                    child.Close();
                }
            }

            childForm.MdiParent = this;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Show();
        }

        private void mnHome_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmHome f = new frmHome();
            OpenChildForm(f);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClose)
            {
                fmDangNhap f = new fmDangNhap();
                f.Show();
            }
            else Application.Exit();
        }

        private void barBtnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barBtnDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmDoiMatKhau f = new fmDoiMatKhau(_nhanVien);
            f.ShowDialog();
        }

        private void barBtnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                isClose = false;
                this.Close();
            }
        }

        private void barBtnSanPham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmQLSanPham());

        }

        private void barBtnThemKH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fmThemKhachHang fmkhachHang = new fmThemKhachHang();
            fmkhachHang.ShowDialog();
        }

        private void barBtnDsKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmKhachHang());
        }

        private void barBtnDoanhThu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmThongKeDoanhThu());
        }

        private void barBtnPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmThongKePhong());
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void S_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            barBtnSoDoPhong.PerformClick();
        }

        private void btnDsDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmDsDatPhong());
        }

        private void btnDsNhanP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenChildForm(new fmDsNhanPhong());
        }
    }
}