using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class UcTangLau : UserControl
    {
        private tb_TangLau _tangLau;
        private List<tb_Phong> _lstPhongSelected;
        private List<tb_Phong> _lstPhongExcept;

        public tb_TangLau TangLau { get => _tangLau; set => _tangLau = value; }
        public List<tb_Phong> LstPhong { get => _lstPhongSelected; }

        public UcTangLau(tb_TangLau tangLau)
        {
            InitializeComponent();
            TangLau = tangLau;
            _lstPhongSelected = PhongBLL.GetRooms(tangLau);
            lblTang.Text = TangLau.TenTang;

            LoadPhong();
        }

        public UcTangLau(tb_TangLau tangLau, List<tb_Phong> lstPhongSelected)
        {
            InitializeComponent();
            TangLau = tangLau;
            _lstPhongSelected = PhongBLL.GetRooms(tangLau);
            lblTang.Text = TangLau.TenTang;

            LoadPhongWithSelected(lstPhongSelected, null);
        }

        public UcTangLau(tb_TangLau tangLau, List<tb_Phong> lstPhongSelected, List<tb_Phong> lstPhongExcept)
        {
            InitializeComponent();
            TangLau = tangLau;
            _lstPhongSelected = PhongBLL.GetRooms(tangLau);
            _lstPhongExcept = lstPhongExcept;
            lblTang.Text = TangLau.TenTang;

            LoadPhongWithSelected(lstPhongSelected, lstPhongExcept);
        }

        private void LoadPhong()
        {
            foreach (tb_Phong phong in _lstPhongSelected)
            {
                UcPhong uc = new UcPhong(phong);
                uc.btnPhong.Click += (o, e) =>
                  {
                      if (phong.TrangThai.Equals("Phòng trống"))
                      {
                          fmCTPhongTrong fmCTPhongTrong = new fmCTPhongTrong(phong);
                          fmCTPhongTrong.ShowDialog();
                      }
                      else if (phong.TrangThai.Equals("Đang có khách"))
                      {
                          fmCTPhongCoKhach fmCTPhongCoKhach = new fmCTPhongCoKhach(phong);
                          fmCTPhongCoKhach.ShowDialog();
                      }
                      else if (phong.TrangThai.Equals("Chưa dọn"))
                      {
                          fmDonPhong fmDonPhong = new fmDonPhong(phong.MaPhong);
                          fmDonPhong.ShowDialog();
                      }
                  };
                pnlContainerPhong.Controls.Add(uc);
            }
        }

        private void LoadPhongWithSelected(List<tb_Phong> lstPhongSelected, List<tb_Phong> lstPhongExcept)
        {
            foreach (tb_Phong phong in _lstPhongSelected)
            {
                UcPhong uc = new UcPhong(phong);
                if (lstPhongSelected.Any(p => p.MaPhong.Equals(phong.MaPhong)))
                {
                    uc.btnPhong.Appearance.BackColor = Color.Blue;
                }

                // If the room status isn't "Phòng trống", it isn't available
                if (!phong.TrangThai.Equals("Phòng trống") || lstPhongExcept != null && lstPhongExcept.Any(p => p.MaPhong.Equals(phong.MaPhong)))
                {
                    uc.btnPhong.Enabled = false;
                }

                // Handle event click
                uc.btnPhong.Click += (o, e) =>
                {
                    if (lstPhongSelected.Any(p => p.MaPhong.Equals(phong.MaPhong)))
                    {
                        lstPhongSelected.RemoveAll(p => p.MaPhong.Equals(phong.MaPhong));
                        uc.btnPhong.Appearance.BackColor = Color.Green;
                    }
                    else
                    {
                        lstPhongSelected.Add(phong);
                        uc.btnPhong.Appearance.BackColor = Color.Blue;
                    }
                };
                pnlContainerPhong.Controls.Add(uc);
            }
        }

        private void pnlContainerPhong_Paint(object sender, PaintEventArgs e)
        {
        }

        private void lblTang_Click(object sender, EventArgs e)
        {
        }
    }
}