using BLL;
using DTO;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmSoDoPhong : Form
    {
        public fmSoDoPhong()
        {
            InitializeComponent();
            LoadUI();
        }

        private void FmSoDoPhong_Resize(object sender, EventArgs e)
        {
            foreach (Control control in pnlContainer.Controls)
            {
                control.Width = control.Parent.Width - 50;
            }
        }

        private void LoadUI()
        {
            lblTong.Text = $"Tổng: {PhongBLL.Count()}";
            lblPhongTrong.Text = $"Phòng trống: {PhongBLL.Count("Phòng trống")}";
            lblChuaDon.Text = $"Chưa dọn: {PhongBLL.Count("Chưa dọn")}";
            lblDangCoKhach.Text = $"Đang có khách: {PhongBLL.Count("Đang có khách")}";

            List<tb_TangLau> lstTangLau = TangLauBLL.GetFloors();

            foreach (tb_TangLau tangLau in lstTangLau)
            {
                UcTangLau ucTang = new UcTangLau(tangLau);
                ucTang.Parent = pnlContainer;
                ucTang.Width = ucTang.Parent.Width - 50;
                pnlContainer.Controls.Add(ucTang);
            }
        }
    }
}