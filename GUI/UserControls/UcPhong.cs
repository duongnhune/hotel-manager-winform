using DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class UcPhong : UserControl
    {
        private tb_Phong _phong;

        public tb_Phong Phong { get => _phong; set => _phong = value; }

        public UcPhong(tb_Phong phong)
        {
            InitializeComponent();
            Phong = phong;

            LoadUI();
        }

        private void LoadUI()
        {
            btnPhong.Text = $"{Phong.TenPhong}\n{Phong.tb_LoaiPhong.TenLoaiPhong}\nSố người: {Phong.tb_LoaiPhong.SoLuongNguoiLon}";
            if (Phong.TrangThai.Equals("Đang có khách"))
                btnPhong.Appearance.BackColor = Color.Red;
            else if (Phong.TrangThai.Equals("Chưa dọn"))
                btnPhong.Appearance.BackColor = Color.Gray;
            else // Phòng trống
                btnPhong.Appearance.BackColor = Color.Green;
        }

        private void UcPhong_Load(object sender, EventArgs e)
        {
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
        }
    }
}