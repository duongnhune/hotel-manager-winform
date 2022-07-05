using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class fmThemKhachHang : Form
    {
        HyggeDbDataContext db = new HyggeDbDataContext();
        public fmThemKhachHang()
        {
            InitializeComponent();
        }

        private void txtCCCD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (CheckNull())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
                return;
            }

            int reuslt = DateTime.Compare(Convert.ToDateTime(dateNgaySinh.Value), Convert.ToDateTime(dateNgayCap.Value));
            if (reuslt >= 0)
            {
                MessageBox.Show("Ngày cấp và ngày sinh không hợp lệ !!!");
                return;
            }

            try
            {
                char gioiTinh = Convert.ToChar("F");
                if (cboGioiTinh.SelectedItem.ToString() == "Nam")
                {
                    gioiTinh = Convert.ToChar("M");
                }
                tb_KhachHang kh = new tb_KhachHang();
                kh.CCCD = txtCCCD.Text;
                kh.NoiCap = txtNoiCap.Text;
                kh.HoTen = txtHoTen.Text;   
                kh.Email = txtEmail.Text;
                kh.DienThoai = txtDienThoai.Text;
                kh.GioiTinh = gioiTinh;
                kh.DiaChi = txtDiaChi.Text;
                kh.NgayCap = dateNgayCap.Value;
                kh.NgaySinh = dateNgaySinh.Value;
                kh.DaXoa = false;

                if(KhachHangBLL.AddCustomer(kh))
                {
                    MessageBox.Show("Thêm thành công ");
                    DefaultNull();
                    return;

                }
                MessageBox.Show("Thêm thất bại !!!");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        public void DefaultNull()
        {
            txtCCCD.Text = txtHoTen.Text = txtDienThoai.Text = txtEmail.Text = "";
            txtNoiCap.Text = txtDiaChi.Text = "";
        }

        public bool CheckNull()
        {
            if
                (
                string.IsNullOrEmpty(txtCCCD.Text) ||
                string.IsNullOrEmpty(txtHoTen.Text) ||
                string.IsNullOrEmpty(txtDienThoai.Text) ||
                string.IsNullOrEmpty(txtDiaChi.Text) ||
                string.IsNullOrEmpty(txtNoiCap.Text))
            {
                return true;
            }
            return false;
        }
        private void fmThemKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
