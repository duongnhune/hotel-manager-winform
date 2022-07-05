using BLL;
using DevExpress.XtraSplashScreen;
using DTO;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public static Main mainForm;

        public fmDangNhap()
        {
            InitializeComponent();
        }
        
        private void BtnDangNhap_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            int result = Config.Check_Config();
            if (result != 0)
            {
                fmConfig fC = new fmConfig();
                fC.ShowDialog();
                this.Cursor = Cursors.Default;
                return;
            }
            if (IsValidateForm())
            {
                try
                {
                    if (TaiKhoanBLL.checkUsernameExist(txtUsername.Text))
                    {
                        if (TaiKhoanBLL.checkPassword(txtUsername.Text, txtPassword.Text))
                        {
                            mainForm = new Main(txtUsername.Text);
                            mainForm.Show();
                            this.Visible = false;
                            this.Cursor = Cursors.Default;
                        }
                        else
                        {
                            this.Cursor = Cursors.Default;
                            MessageBox.Show("Mật khẩu không đúng.");
                        }
                    }
                    else
                    {
                        this.Cursor = Cursors.Default;
                        MessageBox.Show("Tài khoản không tồn tại");
                    }
                }
                catch
                {
                    MessageBox.Show("Database không hợp lệ, vui lòng cập nhật lại cấu hình");
                    fmConfig fC = new fmConfig();
                    fC.ShowDialog();
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
        }

        private void FmDangNhap_Load(object sender, EventArgs e)
        {
            int result = Config.Check_Config();
            if (result != 0)
            {
                SplashScreenManager splashScreenManager1 = new SplashScreenManager(this, typeof(global::GUI.fmStart), true, true);
                splashScreenManager1.ClosingDelay = 1000;
                fmConfig fC = new fmConfig();
                fC.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private ErrorProvider errorProvider = new ErrorProvider();

        private bool IsValidateForm()
        {
            return IsValidateUsername() && IsValidatePassword();
        }

        private bool IsValidateUsername()
        {
            if (txtUsername.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(txtUsername, "Tên đăng nhập không được để trống");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }

        private bool IsValidatePassword()
        {
            if (txtPassword.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(txtPassword, "Mật khẩu không được để trống");
                return false;
            }
            else
            {
                errorProvider.Clear();
                return true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            IsValidateUsername();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            IsValidatePassword();
        }

        private void fmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}