using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class fmThongKePhong : DevExpress.XtraEditors.XtraForm
    {
        HyggeDbDataContext db = new HyggeDbDataContext();
        public fmThongKePhong()
        {
            InitializeComponent();
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }

        private void fmThongKePhong_Load(object sender, EventArgs e)
        {
            chartControl.DataSource = CreateChartData();

            chartControl.SeriesDataMember = "Month";
            chartControl.SeriesTemplate.ArgumentDataMember = "Section";
            chartControl.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControl.SeriesTemplate.LegendTextPattern = "Phòng {A} - {V}";
            // Specify the template's series view.
            chartControl.SeriesTemplate.View = new DoughnutSeriesView();
            // Specify the template's name prefix.
            chartControl.SeriesNameTemplate.BeginText = "Month: ";

            chartControl1.DataSource = CreateChartDataBar();

            chartControl1.SeriesDataMember = "Month";
            chartControl1.SeriesTemplate.ArgumentDataMember = "Section";
            chartControl1.SeriesTemplate.ValueDataMembers.AddRange(new string[] { "Value" });
            chartControl1.SeriesTemplate.LegendTextPattern = "Phòng {A}";
            // Specify the template's series view.
            chartControl1.SeriesTemplate.View = new StackedBarSeriesView();
            // Specify the template's name prefix.
            chartControl1.SeriesNameTemplate.BeginText = "Month: ";
        }

        private DataTable CreateChartData()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Month", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Value", typeof(Int32));


            var items = db.tb_CTDatPhongs.GroupBy(t => t.tb_Phong.TenPhong).Select(g =>
            new
            {
                g.Key,
                count = g.Count()
            });


            foreach (var item in items)
            {
                table.Rows.Add(new object[] { "Jan", item.Key, item.count });
            }

            return table;
        }
        private DataTable CreateChartDataBar()
        {
            // Create an empty table.
            DataTable table = new DataTable("Table1");

            // Add three columns to the table.
            table.Columns.Add("Month", typeof(String));
            table.Columns.Add("Section", typeof(String));
            table.Columns.Add("Value", typeof(Int32));


            var items = db.tb_CTDatPhongs.GroupBy(t => t.tb_Phong.MaPhong).Select(g =>
            new
            {
                g.Key,
                sum = g.Sum(x => x.ThanhTien)
            });


            foreach (var item in items)
            {
                table.Rows.Add(new object[] { "Jan", item.Key,  float.Parse(string.Format("{0:#,##0}", item.sum)) });
            }

            return table;
        }

        private void diagramControl1_Click(object sender, EventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click_2(object sender, EventArgs e)
        {
                    }

        private void chartControl2_Click(object sender, EventArgs e)
        {

        }

        private void chartControl_Click(object sender, EventArgs e)
        {

        }

        private void chartControl1_Click_3(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}