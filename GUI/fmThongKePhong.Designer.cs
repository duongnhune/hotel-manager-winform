namespace GUI
{
    partial class fmThongKePhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.DoughnutSeriesLabel doughnutSeriesLabel1 = new DevExpress.XtraCharts.DoughnutSeriesLabel();
            DevExpress.XtraCharts.DoughnutSeriesView doughnutSeriesView1 = new DevExpress.XtraCharts.DoughnutSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SeriesPoint seriesPoint1 = new DevExpress.XtraCharts.SeriesPoint("aa", new object[] {
            ((object)(12D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint2 = new DevExpress.XtraCharts.SeriesPoint("asss", new object[] {
            ((object)(8D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint3 = new DevExpress.XtraCharts.SeriesPoint("122321", new object[] {
            ((object)(50D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint4 = new DevExpress.XtraCharts.SeriesPoint("122312", new object[] {
            ((object)(6D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint5 = new DevExpress.XtraCharts.SeriesPoint("12212", new object[] {
            ((object)(27D))});
            DevExpress.XtraCharts.SeriesPoint seriesPoint6 = new DevExpress.XtraCharts.SeriesPoint("12212", new object[] {
            ((object)(10D))});
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton7 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1630, 749);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartControl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartControl1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartControl2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1610, 729);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // chartControl
            // 
            this.chartControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop;
            this.chartControl.Legend.MarkerSize = new System.Drawing.Size(22, 18);
            this.chartControl.Legend.Title.Text = "Chi tiết";
            this.chartControl.Legend.Title.Visible = true;
            this.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl.Location = new System.Drawing.Point(3, 3);
            this.chartControl.Name = "chartControl";
            this.tableLayoutPanel1.SetRowSpan(this.chartControl, 2);
            doughnutSeriesLabel1.TextPattern = "{A} - {V}";
            series1.Label = doughnutSeriesLabel1;
            series1.Name = "Series 1";
            series1.View = doughnutSeriesView1;
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl.Size = new System.Drawing.Size(799, 662);
            this.chartControl.TabIndex = 0;
            chartTitle1.Text = "Thống kê số lượng đặt của mỗi phòng";
            this.chartControl.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl.Click += new System.EventHandler(this.chartControl_Click);
            // 
            // chartControl1
            // 
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(808, 3);
            this.chartControl1.Name = "chartControl1";
            series2.Name = "Series 1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
            this.chartControl1.Size = new System.Drawing.Size(799, 328);
            this.chartControl1.TabIndex = 1;
            chartTitle2.Text = "Số tiền phòng kiếm được";
            this.chartControl1.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
            this.chartControl1.Click += new System.EventHandler(this.chartControl1_Click_3);
            // 
            // chartControl2
            // 
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl2.Diagram = swiftPlotDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.RightToLeft;
            this.chartControl2.Location = new System.Drawing.Point(808, 337);
            this.chartControl2.Name = "chartControl2";
            series3.Name = "Series 1";
            series3.Points.AddRange(new DevExpress.XtraCharts.SeriesPoint[] {
            seriesPoint1,
            seriesPoint2,
            seriesPoint3,
            seriesPoint4,
            seriesPoint5,
            seriesPoint6});
            series3.View = swiftPlotSeriesView1;
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
            this.chartControl2.Size = new System.Drawing.Size(799, 328);
            this.chartControl2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 671);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1604, 55);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // simpleButton7
            // 
            this.simpleButton7.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton7.Appearance.Options.UseFont = true;
            this.simpleButton7.Location = new System.Drawing.Point(1468, 10);
            this.simpleButton7.Name = "simpleButton7";
            this.simpleButton7.Size = new System.Drawing.Size(133, 43);
            this.simpleButton7.TabIndex = 6;
            this.simpleButton7.Text = "In ra file";
            // 
            // fmThongKePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 749);
            this.Controls.Add(this.panel1);
            this.Name = "fmThongKePhong";
            this.Text = "Thống kê phòng";
            this.Load += new System.EventHandler(this.fmThongKePhong_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(doughnutSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton7;
    }
}