using BLL;
using DevExpress.XtraEditors;
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
    public partial class fmQLSanPham : DevExpress.XtraEditors.XtraForm
    {
        HyggeDbDataContext db = new HyggeDbDataContext();

        int statusButton = 0;
        public fmQLSanPham()
        {
            InitializeComponent();
        }

        private void fmQLSanPham_Load(object sender, EventArgs e)
        {
            loadDgv_SanPham();
            loadCbo_NhomSanPham();
            List<string> trangthais = new List<string>();
            trangthais.Add("Hiện");
            trangthais.Add("Ẩn");
            cboTrangThai.DataSource = trangthais;
        }
        public void loadDgv_SanPham()
        {
            dgvSanPham.Rows.Clear();
            var listItem = db.tb_SanPhams.Select(x => new
            {
                x.MaSanPham,
                x.TenSanPham,
                x.DonGia,
                x.DonViTinh,
                x.tb_NhomSanPham.TenNSP,
                x.DaXoa
            }).ToList();

            foreach (var item in listItem)
            {
                dgvSanPham.Rows.Add(item.MaSanPham, item.TenSanPham, string.Format("{0:#,##0}", item.DonGia), item.DonViTinh, item.TenNSP, (item.DaXoa == true ? "Ẩn" : "Hiện"));
            }
        }
        public void loadDgv_SanPhamByKey(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                loadDgv_SanPham();
            }
            else
            {
                dgvSanPham.Rows.Clear();
                var listItem = db.tb_SanPhams.Where(x => x.TenSanPham.Contains(key)).Select(x => new
                {
                    x.MaSanPham,
                    x.TenSanPham,
                    x.DonGia,
                    x.DonViTinh,
                    x.tb_NhomSanPham.TenNSP,
                    x.DaXoa
                }).ToList();

                foreach (var item in listItem)
                {
                    dgvSanPham.Rows.Add(item.MaSanPham, item.TenSanPham, string.Format("{0:#,##0}", item.DonGia), item.DonViTinh, item.TenNSP, (item.DaXoa == true ? "Ẩn" : "Hiện"));
                }
            }
        }
        public void loadCbo_NhomSanPham()
        {
            var listItem = db.tb_NhomSanPhams.ToList();

            cboNhomSanPham.DataSource = listItem;
            cboNhomSanPham.DisplayMember = "TenNSP";
            cboNhomSanPham.ValueMember = "MaNSP";
        }

        public void DefaultNull()
        {
            txtDonGia.Text = txtDonViTinh.Text = txtMaSanPham.Text = txtTenSanPham.Text = cboNhomSanPham.Text = cboTrangThai.Text = "";
        }

        public bool CheckNull()
        {
            if (string.IsNullOrEmpty(txtDonGia.Text) || string.IsNullOrEmpty(txtDonViTinh.Text) || string.IsNullOrEmpty(txtTenSanPham.Text))
            {
                return true;
            }
            return false;
        }

        private void dgvSanPham_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvSanPham.CurrentRow;
            if (row != null)
            {
                txtMaSanPham.Text = row.Cells[0].Value.ToString();
                txtTenSanPham.Text = row.Cells[1].Value.ToString();
                txtDonGia.Text = row.Cells[2].Value.ToString();
                txtDonViTinh.Text = row.Cells[3].Value.ToString();
                cboNhomSanPham.Text = row.Cells[4].Value.ToString();
                cboTrangThai.Text = row.Cells[5].Value.ToString();

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DefaultNull();
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            statusButton = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaSanPham.Text))
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm để xóa !!!");
                return;
            }
            try
            {
                if (SanPhamBLL.removeProduct(txtMaSanPham.Text))
                {
                    MessageBox.Show("Xóa thành công ");
                    loadDgv_SanPham();
                    DefaultNull();
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                    btnCapNhat.Enabled = false;
                    return;

                }
                MessageBox.Show("Xóa thất bại !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                MessageBox.Show("Vui lòng chọn 1 sản phẩm để sửa !!!");
                return;
            }
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnCapNhat.Enabled = true;
            statusButton = 2;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (CheckNull())
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
                return;
            }
            if (statusButton == 1)
            {

                if (SanPhamBLL.CheckName(txtTenSanPham.Text))
                {
                    MessageBox.Show("Sản phẩm đã tồn tại !!!");
                    return;
                }

                Random rd = new Random();
                string maSP = "SP" + rd.Next(0, 10000);

                bool status = true;
                if (cboTrangThai.Text == "Hiện")
                {
                    status = false;
                }

                tb_SanPham sp = new tb_SanPham();
                sp.MaSanPham = maSP.ToString();
                sp.TenSanPham = txtTenSanPham.Text;
                sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                sp.DonViTinh = txtDonViTinh.Text;
                sp.MaNSP = Convert.ToInt32(cboNhomSanPham.SelectedValue.ToString());
                sp.DaXoa = status;

                try
                {
                    if (SanPhamBLL.AddProduct(sp))
                    {
                        MessageBox.Show("Thêm thành công ");
                        loadDgv_SanPham();
                        DefaultNull();
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        btnCapNhat.Enabled = false;
                        return;

                    }
                    MessageBox.Show("Thêm thất bại !!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else if (statusButton == 2)
            {
                bool status = true;
                if (cboTrangThai.Text.ToString() == "Hiện")
                {
                    status = false;
                }

                tb_SanPham sp = new tb_SanPham();
                sp.MaSanPham = txtMaSanPham.Text;
                sp.TenSanPham = txtTenSanPham.Text;
                sp.DonGia = Convert.ToDecimal(txtDonGia.Text);
                sp.DonViTinh = txtDonViTinh.Text;
                sp.MaNSP = Convert.ToInt32(cboNhomSanPham.SelectedValue.ToString());
                sp.DaXoa = status;



                try
                {
                    if (SanPhamBLL.UpdateProduct(sp))
                    {
                        MessageBox.Show("Sửa thành công ");
                        loadDgv_SanPham();
                        DefaultNull();
                        btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                        btnCapNhat.Enabled = false;
                        return;

                    }
                    MessageBox.Show("Sửa thất bại !!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            loadDgv_SanPhamByKey(txtTimKiem.Text);
        }

        private void txtDonGia_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDonGia.Text))
            {
                try
                {
                    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
                    int valueBefore = Int32.Parse(txtDonGia.Text, System.Globalization.NumberStyles.AllowThousands);
                    txtDonGia.Text = String.Format(culture, "{0:N0}", valueBefore);
                    txtDonGia.Select(txtDonGia.Text.Length, 0);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message.ToString());
                }
            }
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}