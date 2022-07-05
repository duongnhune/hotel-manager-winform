using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class UcSanPhamDichVu : UserControl
    {
        private List<tb_CTDatPhong> _ctDatPhongs;

        public UcSanPhamDichVu(List<tb_CTDatPhong> ctDatPhongs)
        {
            InitializeComponent();
            _ctDatPhongs = ctDatPhongs;

            LoadSanPham();
            LoadDgvCTDatPhong();
        }

        private void LoadSanPham()
        {
            var sanphams = SanPhamBLL.GetProducts();
            foreach (var sanpham in sanphams)
            {
                // Create UI
                Button button = new Button
                {
                    Text = $"{sanpham.TenSanPham}\n{string.Format("{0:#,##0}", sanpham.DonGia)}",
                    Size = new Size(200, 60),
                    Cursor = Cursors.Hand
                };

                // Handle event click
                button.Click += (o, e) =>
                {
                    int index = dgvCTDatPhong.SelectedRows[0].Index;
                    // Check if already exist then increase the quantity
                    tb_CTDatPhong ctDatPhongSelected = _ctDatPhongs.ElementAt(index);
                    foreach (var item in ctDatPhongSelected.tb_CTDatPhong_SanPhams)
                    {
                        if (item.MaSanPham.Equals(sanpham.MaSanPham))
                        {
                            item.SoLuong++;
                            item.ThanhTien = SanPhamBLL.GetProducts(item.MaSanPham).DonGia * item.SoLuong;
                            DgvCTDatPhong_SelectionChanged(null, null);
                            return;
                        }
                    }

                    // If it doesn't exist, create a new CTDatPhong_SanPham
                    tb_CTDatPhong_SanPham ctDatPhong_SanPham = new tb_CTDatPhong_SanPham
                    {
                        MaSanPham = sanpham.MaSanPham,
                        SoLuong = 1,
                        ThanhTien = SanPhamBLL.GetProducts(sanpham.MaSanPham).DonGia
                    };
                    ctDatPhongSelected.tb_CTDatPhong_SanPhams.Add(ctDatPhong_SanPham);
                    DgvCTDatPhong_SelectionChanged(null, null);
                };

                panelSanPham.Controls.Add(button);
            }
        }

        private void LoadDgvCTDatPhong()
        {
            foreach (var ctDatPhong in _ctDatPhongs)
            {
                dgvCTDatPhong.Rows.Add(ctDatPhong.MaPhong, ctDatPhong.MaCTDatPhong);
            }
        }

        private void DgvCTDatPhong_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCTDatPhong.Rows.Count == 0)
                return;

            string maPhongSelected = dgvCTDatPhong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
            // Get CTDatPhong match with MaPhong
            tb_CTDatPhong ctDatPhongSelected = _ctDatPhongs.FirstOrDefault(x => x.MaPhong.Equals(maPhongSelected));

            // Add to datagridview
            dgvSanPhamDichVu.Rows.Clear();
            foreach (var item in ctDatPhongSelected.tb_CTDatPhong_SanPhams)
            {
                tb_SanPham sanPham = SanPhamBLL.GetProducts(item.MaSanPham);

                dgvSanPhamDichVu.Rows.Add(dgvSanPhamDichVu.Rows.Count + 1, sanPham.MaSanPham, sanPham.TenSanPham, string.Format("{0:#,##0}", sanPham.DonGia), item.SoLuong, string.Format("{0:#,##0}", sanPham.DonGia * item.SoLuong));
            }
        }

        private void DgvSanPhamDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                DataGridViewRow rowSelected = dgvSanPhamDichVu.Rows[e.RowIndex];
                string maSanPham = rowSelected.Cells["MaSanPham"].Value.ToString();

                string maPhongSelected = dgvCTDatPhong.SelectedRows[0].Cells["MaPhong"].Value.ToString();
                // Get product want to delete
                tb_CTDatPhong_SanPham productDelete = _ctDatPhongs.FirstOrDefault(x => x.MaPhong.Equals(maPhongSelected)).tb_CTDatPhong_SanPhams.FirstOrDefault(x => x.MaSanPham.Equals(maSanPham));

                // Delete product from list
                _ctDatPhongs.FirstOrDefault(x => x.MaPhong.Equals(maPhongSelected)).tb_CTDatPhong_SanPhams.Remove(productDelete);

                // Refresh datagridview
                DgvCTDatPhong_SelectionChanged(null, null);
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}