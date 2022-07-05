using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmDatPhong : DevExpress.XtraEditors.XtraForm
    {
        #region Global variable
        /// <summary>
        /// Check-in time
        /// </summary>
        private DateTime checkIn;

        /// <summary>
        /// Check-out time
        /// </summary>
        private DateTime checkOut;

        /// <summary>
        /// List of details reserved ticket
        /// </summary>
        private List<tb_CTDatPhong> ctDatPhongs = new List<tb_CTDatPhong>();

        private double totalAmount = 0;
        #endregion

        #region Property
        /// <summary>
        /// Reserved ticket
        /// </summary>
        public tb_PhieuDatPhong PhieuDatPhong { get; set; }

        /// <summary>
        /// List of room
        /// </summary>
        public List<tb_Phong> Phongs { get; set; }
        #endregion

        public fmDatPhong()
        {
            InitializeComponent();
        }

        public fmDatPhong(List<tb_Phong> phongs)
        {
            InitializeComponent();
            Phongs = phongs;

            // Default check-in time is 12 o'clock.
            // If the current time is over 12 o'clock, set check-in time to 12 o'clock tomorrow
            checkIn = DateTime.Now.Hour <= 12 ? DateTime.Now : new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day + 1, 12, 0, 0);

            // Default check-out time is after check-in 1 day at 14 o'clock
            checkOut = new DateTime(checkIn.Year, checkIn.Month, checkIn.Day + 1, 14, 0, 0);


            // Get the MaPhieuDat by concatenating the prefix "PD" with the value selected in the Identify table as the suffix
            string maPhieuDat = $"PD{(IdentifyBLL.GetCounter("PhieuDatPhong") + 1).ToString().PadLeft(5, '0')}";
            // Initialize PhieuDatPhong
            PhieuDatPhong = new tb_PhieuDatPhong
            {
                MaPhieuDat = maPhieuDat,
                MaNV = Main.NhanVien.MaNV, // Get NhanVien from account signed in
                NgayLap = DateTime.Now,
                DaHuy = false
            };

        }

        /// <summary>
        /// Flag to stop date or time's EditValueChanged event from firing when form load
        /// </summary>
        private bool isFormLoad = true;
        private void FmDatPhong_Load(object sender, EventArgs e)
        {
            // Load list box control KhachHang
            LoadListBoxKhachHang();
            cboxLoaiHinh.SelectedIndex = 0; // Default type is "Ngày"

            // Set value for check-in and check-out time
            dateFrom.EditValue = checkIn;
            timeFrom.EditValue = checkIn;
            dateTo.EditValue = checkOut;
            timeTo.EditValue = checkOut;

            AddRecordPhong(Phongs);

            UcSanPhamDichVu ucSanPhamDichVu = new UcSanPhamDichVu(ctDatPhongs);
            ucSanPhamDichVu.Dock = DockStyle.Fill;
            tabNavigationPage2.Controls.Add(ucSanPhamDichVu);
            isFormLoad = false;
        }

        #region Prepare data
        /// <summary>
        /// Load data for list box KhachHang control 
        /// </summary>
        private void LoadListBoxKhachHang()
        {
            List<tb_KhachHang> khachHangs = KhachHangBLL.GetCustomers();
            lstBoxKhachHang.Items.AddRange(khachHangs.Select(x => $"{x.CCCD} - {x.HoTen}").ToArray());
        }

        /// <summary>
        /// Add rows of data to datagridview
        /// </summary>
        /// <param name="phongs">List of room</param>
        private void AddRecordPhong(List<tb_Phong> phongs)
        {
            try
            {
                // First make sure the datagridview has been initialized
                if (dgvCTDatPhong.Columns.Count == 0)
                {
                    AddHeaderDgv();
                }

                // Clear datagridview
                dgvCTDatPhong.Rows.Clear();

                var tmpCTDatPhongs = new List<tb_CTDatPhong>(ctDatPhongs);
                ctDatPhongs.Clear();
                foreach (var phong in phongs)
                {
                    bool isExist = false;
                    tb_CTDatPhong ctDatPhong = new tb_CTDatPhong();
                    foreach (var ctdp in tmpCTDatPhongs)
                    {
                        if (ctdp.MaPhong.Equals(phong.MaPhong))
                        {
                            ctDatPhong = ctdp;
                            isExist = true;
                            break;
                        }
                    }

                    if (!isExist)
                    {
                        // Initialize CTDatPhong based on Phong
                        ctDatPhong = new tb_CTDatPhong
                        {
                            MaPhieuDat = PhieuDatPhong.MaPhieuDat,
                            MaPhong = phong.MaPhong,
                            SoLuongNguoiLon = phong.tb_LoaiPhong.SoLuongNguoiLon,
                            SoLuongTreEm = phong.tb_LoaiPhong.SoLuongTreEm,
                            CheckIn = checkIn,
                            CheckOut = checkOut
                        };
                        ctDatPhong.ThanhTien = (decimal)DatPhongBLL.CalcSubtotal(cboxLoaiHinh.Text, ctDatPhong);
                    }

                    // Add ctDatPhong to list of CTDatPhong
                    ctDatPhongs.Add(ctDatPhong);

                    // Add to datagridview
                    dgvCTDatPhong.Rows.Add(dgvCTDatPhong.Rows.Count + 1, ctDatPhong.MaPhong, phong.TenPhong, phong.tb_LoaiPhong.TenLoaiPhong, ctDatPhong.SoLuongNguoiLon, ctDatPhong.SoLuongTreEm, ctDatPhong.CheckIn, ctDatPhong.CheckOut);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Initialize datagridview columns
        /// </summary>
        private void AddHeaderDgv()
        {
            dgvCTDatPhong.Columns.Add("STT", "STT");
            dgvCTDatPhong.Columns.Add("MaPhong", "Mã phòng");
            dgvCTDatPhong.Columns["MaPhong"].Visible = false;
            dgvCTDatPhong.Columns.Add("TenPhong", "Tên phòng");
            dgvCTDatPhong.Columns.Add("LoaiPhong", "Loại phòng");
            dgvCTDatPhong.Columns.Add("NguoiLon", "Người lớn");
            dgvCTDatPhong.Columns.Add("TreEm", "Trẻ em");
            dgvCTDatPhong.Columns.Add("Checkin", "Check in");
            dgvCTDatPhong.Columns.Add("Checkout", "Check out");
            dgvCTDatPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCTDatPhong.Columns["STT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCTDatPhong.Columns["NguoiLon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvCTDatPhong.Columns["TreEm"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        #endregion

        #region Validate form

        private ErrorProvider errorProvider = new ErrorProvider();
        private bool IsValidForm()
        {
            return IsValidCheckin() && IsValidCheckout() && IsValidCustomer() && IsValidDeposit();
        }

        private bool IsValidCheckin()
        {
            if (!DatPhongBLL.IsValidCheckIn(checkIn, checkOut))
            {
                errorProvider.SetError(lblCheckin, "Thời gian check-in không hợp lệ.");
                return false;
            }
            else
            {
                errorProvider.SetError(lblCheckin, string.Empty);
                return true;
            }
        }

        private bool IsValidCheckout()
        {
            if (!DatPhongBLL.IsValidCheckOut(checkIn, checkOut))
            {
                errorProvider.SetError(lblCheckin, "Thời gian check-out không hợp lệ.");
                return false;
            }
            else
            {
                errorProvider.SetError(lblCheckin, string.Empty);
                return true;
            }
        }

        private bool IsValidCustomer()
        {
            if (!DatPhongBLL.IsValidCustomer(txtKhachHang.Text.Split('-')[0].Trim()))
            {
                errorProvider.SetError(lblKhachHang, "Khách hàng không hợp lệ.");
                return false;
            }
            else
            {
                errorProvider.SetError(lblKhachHang, string.Empty);
                return true;
            }
        }

        private bool IsValidDeposit()
        {
            if (!DatPhongBLL.IsValidDeposit((double)numerTraTruoc.Value, totalAmount))
            {
                errorProvider.SetError(lblTraTruoc, "Số tiền không hợp lệ.");
                return false;
            }
            else
            {
                errorProvider.SetError(lblTraTruoc, string.Empty);
                return true;
            }
        }
        #endregion

        #region Handle event

        private void CalcTotalAmount()
        {
            totalAmount = DatPhongBLL.CalcTotalAmount(cboxLoaiHinh.Text, ctDatPhongs);
            lblTamTinh.Text = $"Tạm tính: {string.Format("{0:#,##0}", totalAmount)} VNĐ";
        }

        private void SearchControl1_EditValueChanged(object sender, EventArgs e)
        {
            if (searchControl1.Text == null || searchControl1.Text.Trim().Length == 0)
            {
                lstBoxKhachHang.Visible = false;
            }
            else
            {
                lstBoxKhachHang.Visible = true;
            }
        }

        private void LstBoxKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBoxKhachHang.SelectedValue != null)
            {
                txtKhachHang.Text = lstBoxKhachHang.SelectedValue.ToString();
                ValidateChildren();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Valid form
            if (!IsValidForm())
            {
                return;
            }

            // Reserved ticket
            string cccd = txtKhachHang.Text.Split('-')[0].Trim();
            PhieuDatPhong.CCCD = cccd;
            PhieuDatPhong.TraTruoc = numerTraTruoc.Value;
            PhieuDatPhong.LoaiHinh = cboxLoaiHinh.Text;

            // Perform save all to database
            try
            {
                DatPhongBLL.Booking(PhieuDatPhong, ctDatPhongs);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnThemPhong_Click(object sender, EventArgs e)
        {
            // Get a list of rooms already booked during the check-in time and check-out time
            var ctDatPhongs = CTDatPhongBLL.GetDetailReservedTicket(checkIn, checkOut);
            List<tb_Phong> lstPhongExcept = new List<tb_Phong>();
            foreach (var ctDatPhong in ctDatPhongs)
            {
                lstPhongExcept.Add(ctDatPhong.tb_Phong);
            }

            fmChonThemPhong fmChonThemPhong = new fmChonThemPhong(Phongs, lstPhongExcept);
            fmChonThemPhong.FormClosed += (o, args) =>
            {
                AddRecordPhong(Phongs);
            };
            fmChonThemPhong.ShowDialog();
        }

        private void DataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            CalcTotalAmount();
        }

        private void DateFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                DateTime date = DateTime.Parse(dateFrom.Text);
                DateTime time = DateTime.Parse(timeFrom.Text);
                checkIn = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                IsValidCheckin();
                CalcTotalAmount();
            }

        }

        private void TimeFrom_EditValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                DateTime date = DateTime.Parse(dateFrom.Text);
                DateTime time = DateTime.Parse(timeFrom.Text);
                checkIn = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                IsValidCheckin();
                CalcTotalAmount();
            }

        }

        private void DateTo_EditValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                DateTime date = DateTime.Parse(dateTo.Text);
                DateTime time = DateTime.Parse(timeTo.Text);
                checkOut = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                IsValidCheckout();
                CalcTotalAmount();
            }

        }

        private void TimeTo_EditValueChanged(object sender, EventArgs e)
        {
            if (!isFormLoad)
            {
                DateTime date = DateTime.Parse(dateTo.Text);
                DateTime time = DateTime.Parse(timeTo.Text);
                checkOut = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);
                IsValidCheckout();
                CalcTotalAmount();
            }
        }

        private void NumerTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            IsValidDeposit();
        }

        private void TxtKhachHang_TextChanged(object sender, EventArgs e)
        {
            IsValidCustomer();
        }

        private void TabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            UcSanPhamDichVu ucSanPhamDichVu = new UcSanPhamDichVu(ctDatPhongs)
            {
                Dock = DockStyle.Fill
            };
            tabNavigationPage2.Controls.Clear();
            tabNavigationPage2.Controls.Add(ucSanPhamDichVu);
        }
        #endregion

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lblCheckin_Click(object sender, EventArgs e)
        {

        }

        private void lblTamTinh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}