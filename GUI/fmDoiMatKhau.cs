using BLL;
using DTO;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDoiMatKhau : Form
    {

        private tb_NhanVien _nhanVien;
        private ErrorProvider errorProvider;

        public tb_NhanVien NhanVien { get => _nhanVien; set => _nhanVien = value; }

        public fmDoiMatKhau(tb_NhanVien nhanVien)
        {
            InitializeComponent();
            NhanVien = nhanVien;
            errorProvider = new ErrorProvider();
        }

        private void btnHuy_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnDoiMatKhau_Click(object sender, System.EventArgs e)
        {
            if(validatePassOld() && validatePassNew()) 
            {
                if (checkPassOdl())
                {
                    if(MessageBox.Show("Xác nhận đổi mật khẩu","Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if(TaiKhoanBLL.changePassword(NhanVien.tb_TaiKhoan.TenDangNhap, NhanVien.tb_TaiKhoan.MatKhau, txtPassNew.Text))
                        {
                            MessageBox.Show("Đổi mật khẩu thành công");
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại sau");
                        }
                    }
                }
            }
        }
        

        public bool validatePassOld()
        {
            if(txtPassOld.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(txtPassOld, "Mật khẩu cũ không được để trống");
                return false;
            }
            return true;
        }
        public bool validatePassNew()
        {
            if (txtPassNew.Text.Trim() == string.Empty)
            {
                errorProvider.SetError(txtPassNew, "Mật khẩu mới không được để trống");
                return false;
            }
            return true;
        }
        private bool checkPassOdl()
        {
            if (txtPassOld.Text.Equals(NhanVien.tb_TaiKhoan.MatKhau))
            {
                errorProvider.SetError(txtPassOld, "Mật khẩu cũ không chính xác");
                return false;
            }
            return true;
        }

        private void txtPassOld_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtPassNew_TextChanged(object sender, System.EventArgs e)
        {
            errorProvider.Clear();
        }

        private void fmDoiMatKhau_Load(object sender, System.EventArgs e)
        {

        }
    }
}