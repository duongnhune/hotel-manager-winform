using System;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Linq;
using System.Drawing;

namespace GUI
{
    public partial class fmDsNhanPhong : Form
    {
        HyggeDbDataContext db = new HyggeDbDataContext();
        public fmDsNhanPhong()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmDsNhanPhong_Load(object sender, EventArgs e)
        {
            loadDataGridView();
        }

        private bool checkHoaDonByMaPhieu(string strMaPhieu)
        {
            var item = db.tb_HoaDons.Where(t => t.MaPhieuDat.Equals(strMaPhieu) && t.TrangThai == false).FirstOrDefault();
            if (item != null) return true;
            else return false;
        }

        public void loadDataGridView()
        {
            dgvPhong.Rows.Clear();



            var listItem = db.tb_CTDatPhongs
                .Where(x => x.tb_Phong.TrangThai.Equals("Đang có khách"))
                .Select(x => new
                {
                    x.MaPhong,
                    x.tb_PhieuDatPhong.tb_KhachHang.HoTen,
                    x.tb_Phong.TenPhong,
                    x.tb_Phong.tb_LoaiPhong.TenLoaiPhong,
                    x.tb_Phong.tb_TangLau.TenTang,
                    x.tb_Phong.TrangThai,
                    x.tb_PhieuDatPhong.MaPhieuDat
                }).ToList();

            var items = listItem.Where(t => checkHoaDonByMaPhieu(t.MaPhieuDat) == true);

            foreach (var item in items)
            {
                dgvPhong.Rows.Add(item.MaPhong,item.HoTen ,item.TenPhong, item.TenLoaiPhong, item.TenTang, item.TrangThai, "Thanh toán", item.MaPhieuDat);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPhong.Columns["ThanhToan"].Index && e.RowIndex >= 0)
            {
                if(dgvPhong.CurrentRow.Cells["TrangThai"].Value.ToString() != "Đang có khách")
                {
                    MessageBox.Show("Trạng thái không hợp lệ. Không thể thanh toán !!!");
                    return;
                }
                string id = dgvPhong.CurrentRow.Cells[7].Value.ToString();
                var item = db.tb_CTDatPhongs.Where(x => x.MaPhieuDat == id).FirstOrDefault();
                if(item != null)
                {
                    fmThanhToan thanhToan = new fmThanhToan(item);
                    thanhToan.ShowDialog();
                }
            }
        }

        private void dgvPhong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}