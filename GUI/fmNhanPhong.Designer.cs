namespace GUI
{
    partial class fmNhanPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmNhanPhong));
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblCheckin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTraTruoc = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.timeFrom = new DevExpress.XtraEditors.TimeEdit();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.cboxLoaiHinh = new System.Windows.Forms.ComboBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.numerTraTruoc = new DevExpress.XtraEditors.SpinEdit();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.timeTo = new DevExpress.XtraEditors.TimeEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lstBoxKhachHang = new DevExpress.XtraEditors.ListBoxControl();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCTDatPhong = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemPhong = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.lblTamTinh = new DevExpress.XtraEditors.LabelControl();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerTraTruoc.Properties)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstBoxKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDatPhong)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Location = new System.Drawing.Point(0, 0);
            this.tabPane1.Margin = new System.Windows.Forms.Padding(15);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage1,
            this.tabNavigationPage2});
            this.tabPane1.RegularSize = new System.Drawing.Size(1299, 776);
            this.tabPane1.SelectedPage = this.tabNavigationPage1;
            this.tabPane1.Size = new System.Drawing.Size(1299, 776);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.TabPane1_SelectedPageChanged);
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Thông tin";
            this.tabNavigationPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabNavigationPage1.Margin = new System.Windows.Forms.Padding(12);
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1299, 735);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel7, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1299, 735);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel4);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(12);
            this.groupBox3.Size = new System.Drawing.Size(1275, 428);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin đăng ký:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7683F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2317F));
            this.tableLayoutPanel4.Controls.Add(this.lblCheckin, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label7, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblTraTruoc, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboxLoaiHinh, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtKhachHang, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.lblKhachHang, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.numerTraTruoc, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(12, 37);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.04124F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.23711F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.83505F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1251, 379);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // lblCheckin
            // 
            this.lblCheckin.AutoSize = true;
            this.lblCheckin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCheckin.Location = new System.Drawing.Point(12, 0);
            this.lblCheckin.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblCheckin.Name = "lblCheckin";
            this.lblCheckin.Size = new System.Drawing.Size(127, 68);
            this.lblCheckin.TabIndex = 0;
            this.lblCheckin.Text = "Check in *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(12, 68);
            this.label7.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 61);
            this.label7.TabIndex = 0;
            this.label7.Text = "Loại hình";
            // 
            // lblTraTruoc
            // 
            this.lblTraTruoc.AutoSize = true;
            this.lblTraTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTraTruoc.Location = new System.Drawing.Point(12, 129);
            this.lblTraTruoc.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblTraTruoc.Name = "lblTraTruoc";
            this.lblTraTruoc.Size = new System.Drawing.Size(127, 50);
            this.lblTraTruoc.TabIndex = 0;
            this.lblTraTruoc.Text = "Trả trước";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.timeFrom, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.dateFrom, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(163, 12);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(523, 44);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // timeFrom
            // 
            this.timeFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeFrom.EditValue = new System.DateTime(2022, 4, 24, 0, 0, 0, 0);
            this.timeFrom.Location = new System.Drawing.Point(267, 6);
            this.timeFrom.Margin = new System.Windows.Forms.Padding(6);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeFrom.Properties.Appearance.Options.UseFont = true;
            this.timeFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeFrom.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeFrom.Size = new System.Drawing.Size(250, 30);
            this.timeFrom.TabIndex = 1;
            this.timeFrom.EditValueChanged += new System.EventHandler(this.TimeFrom_EditValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(6, 6);
            this.dateFrom.Margin = new System.Windows.Forms.Padding(6);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFrom.Properties.Appearance.Options.UseFont = true;
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(249, 30);
            this.dateFrom.TabIndex = 0;
            this.dateFrom.EditValueChanged += new System.EventHandler(this.DateFrom_EditValueChanged);
            // 
            // cboxLoaiHinh
            // 
            this.cboxLoaiHinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cboxLoaiHinh.FormattingEnabled = true;
            this.cboxLoaiHinh.Items.AddRange(new object[] {
            "Ngày",
            "Giờ"});
            this.cboxLoaiHinh.Location = new System.Drawing.Point(163, 80);
            this.cboxLoaiHinh.Margin = new System.Windows.Forms.Padding(12);
            this.cboxLoaiHinh.Name = "cboxLoaiHinh";
            this.cboxLoaiHinh.Size = new System.Drawing.Size(523, 32);
            this.cboxLoaiHinh.TabIndex = 9;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKhachHang.Location = new System.Drawing.Point(163, 191);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(12);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(523, 32);
            this.txtKhachHang.TabIndex = 9;
            this.txtKhachHang.TextChanged += new System.EventHandler(this.TxtKhachHang_TextChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKhachHang.Location = new System.Drawing.Point(12, 179);
            this.lblKhachHang.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(127, 200);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách hàng *";
            // 
            // numerTraTruoc
            // 
            this.numerTraTruoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numerTraTruoc.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numerTraTruoc.Location = new System.Drawing.Point(156, 134);
            this.numerTraTruoc.Margin = new System.Windows.Forms.Padding(5);
            this.numerTraTruoc.Name = "numerTraTruoc";
            this.numerTraTruoc.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerTraTruoc.Properties.Appearance.Options.UseFont = true;
            this.numerTraTruoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.numerTraTruoc.Properties.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numerTraTruoc.Size = new System.Drawing.Size(537, 30);
            this.numerTraTruoc.TabIndex = 9;
            this.numerTraTruoc.ToolTip = "Số tiền khách đưa trước";
            this.numerTraTruoc.EditValueChanged += new System.EventHandler(this.NumerTraTruoc_EditValueChanged);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.timeTo, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dateTo, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(710, 12);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(529, 44);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // timeTo
            // 
            this.timeTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeTo.EditValue = new System.DateTime(2022, 4, 24, 0, 0, 0, 0);
            this.timeTo.Location = new System.Drawing.Point(270, 6);
            this.timeTo.Margin = new System.Windows.Forms.Padding(6);
            this.timeTo.Name = "timeTo";
            this.timeTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeTo.Properties.Appearance.Options.UseFont = true;
            this.timeTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeTo.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.timeTo.Size = new System.Drawing.Size(253, 30);
            this.timeTo.TabIndex = 1;
            this.timeTo.EditValueChanged += new System.EventHandler(this.TimeTo_EditValueChanged);
            // 
            // dateTo
            // 
            this.dateTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(6, 6);
            this.dateTo.Margin = new System.Windows.Forms.Padding(6);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTo.Properties.Appearance.Options.UseFont = true;
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(252, 30);
            this.dateTo.TabIndex = 0;
            this.dateTo.EditValueChanged += new System.EventHandler(this.DateTo_EditValueChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lstBoxKhachHang, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.searchControl1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(710, 80);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel4.SetRowSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(529, 287);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // lstBoxKhachHang
            // 
            this.lstBoxKhachHang.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxKhachHang.Appearance.Options.UseFont = true;
            this.lstBoxKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBoxKhachHang.ItemAutoHeight = true;
            this.lstBoxKhachHang.Location = new System.Drawing.Point(19, 97);
            this.lstBoxKhachHang.Margin = new System.Windows.Forms.Padding(19);
            this.lstBoxKhachHang.Name = "lstBoxKhachHang";
            this.lstBoxKhachHang.Padding = new System.Windows.Forms.Padding(19);
            this.lstBoxKhachHang.ShowToolTipForTrimmedText = DevExpress.Utils.DefaultBoolean.True;
            this.lstBoxKhachHang.Size = new System.Drawing.Size(491, 171);
            this.lstBoxKhachHang.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.lstBoxKhachHang.TabIndex = 1;
            this.lstBoxKhachHang.Visible = false;
            this.lstBoxKhachHang.SelectedIndexChanged += new System.EventHandler(this.LstBoxKhachHang_SelectedIndexChanged);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.lstBoxKhachHang;
            this.searchControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchControl1.Location = new System.Drawing.Point(15, 15);
            this.searchControl1.Margin = new System.Windows.Forms.Padding(15);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchControl1.Properties.Appearance.Options.UseFont = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.lstBoxKhachHang;
            this.searchControl1.Properties.NullValuePrompt = "Tìm khách hàng";
            this.searchControl1.Size = new System.Drawing.Size(499, 30);
            this.searchControl1.TabIndex = 1;
            this.searchControl1.EditValueChanged += new System.EventHandler(this.SearchControl1_EditValueChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.88942F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.11058F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.dgvCTDatPhong, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(8, 460);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1283, 166);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(8, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1137, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách phòng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvCTDatPhong
            // 
            this.dgvCTDatPhong.AllowUserToAddRows = false;
            this.dgvCTDatPhong.AllowUserToDeleteRows = false;
            this.dgvCTDatPhong.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCTDatPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel3.SetColumnSpan(this.dgvCTDatPhong, 2);
            this.dgvCTDatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTDatPhong.Location = new System.Drawing.Point(5, 65);
            this.dgvCTDatPhong.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCTDatPhong.Name = "dgvCTDatPhong";
            this.dgvCTDatPhong.ReadOnly = true;
            this.dgvCTDatPhong.RowHeadersWidth = 51;
            this.dgvCTDatPhong.RowTemplate.Height = 24;
            this.dgvCTDatPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCTDatPhong.Size = new System.Drawing.Size(1273, 96);
            this.dgvCTDatPhong.TabIndex = 1;
            this.dgvCTDatPhong.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.DataGridView1_RowStateChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnThemPhong);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1158, 5);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(120, 50);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnThemPhong.Appearance.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnThemPhong.Appearance.Options.UseBackColor = true;
            this.btnThemPhong.Appearance.Options.UseForeColor = true;
            this.btnThemPhong.AutoSize = true;
            this.btnThemPhong.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.btnThemPhong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemPhong.ImageOptions.SvgImage")));
            this.btnThemPhong.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.btnThemPhong.Location = new System.Drawing.Point(71, 5);
            this.btnThemPhong.Margin = new System.Windows.Forms.Padding(5);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(44, 42);
            this.btnThemPhong.TabIndex = 0;
            this.btnThemPhong.ToolTip = "Chọn thêm phòng";
            this.btnThemPhong.Click += new System.EventHandler(this.BtnThemPhong_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.lblTamTinh, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(8, 642);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(8);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1283, 85);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.simpleButton2);
            this.flowLayoutPanel1.Controls.Add(this.simpleButton3);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(649, 8);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(626, 69);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Crimson;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton2.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton2.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.simpleButton2.Location = new System.Drawing.Point(465, 5);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.MaximumSize = new System.Drawing.Size(156, 62);
            this.simpleButton2.MinimumSize = new System.Drawing.Size(156, 62);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(156, 62);
            this.simpleButton2.TabIndex = 2;
            this.simpleButton2.Text = "Huỷ";
            this.simpleButton2.ToolTip = "Huỷ";
            this.simpleButton2.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.simpleButton3.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.simpleButton3.ImageOptions.SvgImageSize = new System.Drawing.Size(30, 30);
            this.simpleButton3.Location = new System.Drawing.Point(299, 5);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.MaximumSize = new System.Drawing.Size(156, 62);
            this.simpleButton3.MinimumSize = new System.Drawing.Size(156, 62);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(156, 62);
            this.simpleButton3.TabIndex = 1;
            this.simpleButton3.Text = "Lưu";
            this.simpleButton3.ToolTip = "Lưu";
            this.simpleButton3.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lblTamTinh
            // 
            this.lblTamTinh.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTamTinh.Appearance.Options.UseFont = true;
            this.lblTamTinh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.lblTamTinh.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTamTinh.Location = new System.Drawing.Point(5, 5);
            this.lblTamTinh.Margin = new System.Windows.Forms.Padding(5);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(142, 24);
            this.lblTamTinh.TabIndex = 1;
            this.lblTamTinh.Text = "Tạm tính 0 VNĐ";
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Sản phẩm & dịch vụ";
            this.tabNavigationPage2.Margin = new System.Windows.Forms.Padding(12);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1598, 799);
            // 
            // fluentDesignFormContainer1
            // 
            this.fluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fluentDesignFormContainer1.Location = new System.Drawing.Point(0, 0);
            this.fluentDesignFormContainer1.Margin = new System.Windows.Forms.Padding(5);
            this.fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            this.fluentDesignFormContainer1.Size = new System.Drawing.Size(1299, 776);
            this.fluentDesignFormContainer1.TabIndex = 1;
            // 
            // fmNhanPhong
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 776);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.fluentDesignFormContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "fmNhanPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhận phòng";
            this.Load += new System.EventHandler(this.FmDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numerTraTruoc.Properties)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timeTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lstBoxKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDatPhong)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblCheckin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTraTruoc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.ComboBox cboxLoaiHinh;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.ListBoxControl lstBoxKhachHang;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private DevExpress.XtraEditors.TimeEdit timeFrom;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.TimeEdit timeTo;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SpinEdit numerTraTruoc;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnThemPhong;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl lblTamTinh;
        private System.Windows.Forms.DataGridView dgvCTDatPhong;
    }
}