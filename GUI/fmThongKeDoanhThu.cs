using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmThongKeDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        HyggeDbDataContext db = new HyggeDbDataContext();
        public fmThongKeDoanhThu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            
            for (int i = DateTime.Now.Year; i >= 2001; i--)
            {
                cbbNam.Items.Add(i.ToString());
            }
            cbbNam.SelectedIndex = 0;
            SetData();

            chartControl1.SeriesDataMember = "Month";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Section";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControl1.SeriesTemplate.LegendTextPattern = "Tháng";
            chartControl1.SeriesNameTemplate.BeginText = "Month: ";
            dgvNgay.Columns[1].DefaultCellStyle.Format = "0#,##0 đ";
            dgvThang.Columns[1].DefaultCellStyle.Format = "0#,##0 đ";
        }

        private void SetData()
        {
            chartControl1.DataSource = CreateChartData();
        }

        private DataTable CreateChartData()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Month", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Value", typeof(Int32));

            var items = db.tb_HoaDons.Where(t=> (bool)(t.TrangThai == true) && t.NgayLap.Value.Year == int.Parse(cbbNam.SelectedItem.ToString())).GroupBy(t => new { t.NgayLap.Value.Month , t.NgayLap.Value.Year}).Select(g =>
            new
            {
                date = g.Key.Month + "/" + g.Key.Year,
                sum = g.Sum(t=> t.ThanhTien)
            });

            dgvThang.DataSource = items;
           

            foreach (var item in items)
            {
                table.Rows.Add(new object[] { "Jan", item.date, item.sum });
            }

            return table;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvThang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvThang.CurrentRow != null)
            {
                DataGridViewRow r = dgvThang.CurrentRow;

                string[] date = r.Cells[0].Value.ToString().Split('/');

                var items = db.tb_HoaDons.Where(t => (bool)(t.TrangThai == true) && t.NgayLap.Value.Month == int.Parse(date[0]) && t.NgayLap.Value.Year == int.Parse(date[1])).GroupBy(t => t.NgayLap.Value.Date).Select(g =>
                  new
                  {
                      g.Key,
                      sum = g.Sum(t => t.ThanhTien)
                  });

                dgvNgay.DataSource = items;
            }

        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetData();
            dgvNgay.Rows.Clear();
        }

        private void cbbNam_Click(object sender, EventArgs e)
        {
            CreateChartData();
            SetData();
        }

        private void dgvNgay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}