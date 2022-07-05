
namespace GUI
{
    partial class fmSoDoPhong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmSoDoPhong));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDangCoKhach = new System.Windows.Forms.Label();
            this.lblChuaDon = new System.Windows.Forms.Label();
            this.lblPhongTrong = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8_home_32px_1.png");
            this.imageList2.Images.SetKeyName(1, "icons8_room_32px_1.png");
            this.imageList2.Images.SetKeyName(2, "icons8_room_32px_2.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8_room_64px_1.png");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlContainer, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1224, 711);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblDangCoKhach);
            this.flowLayoutPanel1.Controls.Add(this.lblChuaDon);
            this.flowLayoutPanel1.Controls.Add(this.lblPhongTrong);
            this.flowLayoutPanel1.Controls.Add(this.lblTong);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 18, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1216, 88);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // lblDangCoKhach
            // 
            this.lblDangCoKhach.BackColor = System.Drawing.Color.Red;
            this.lblDangCoKhach.ForeColor = System.Drawing.Color.White;
            this.lblDangCoKhach.Location = new System.Drawing.Point(1013, 18);
            this.lblDangCoKhach.Name = "lblDangCoKhach";
            this.lblDangCoKhach.Size = new System.Drawing.Size(200, 50);
            this.lblDangCoKhach.TabIndex = 0;
            this.lblDangCoKhach.Text = "Đang có khách";
            this.lblDangCoKhach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChuaDon
            // 
            this.lblChuaDon.BackColor = System.Drawing.Color.Gray;
            this.lblChuaDon.ForeColor = System.Drawing.Color.White;
            this.lblChuaDon.Location = new System.Drawing.Point(807, 18);
            this.lblChuaDon.Name = "lblChuaDon";
            this.lblChuaDon.Size = new System.Drawing.Size(200, 50);
            this.lblChuaDon.TabIndex = 1;
            this.lblChuaDon.Text = "Chưa dọn";
            this.lblChuaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhongTrong
            // 
            this.lblPhongTrong.BackColor = System.Drawing.Color.Green;
            this.lblPhongTrong.ForeColor = System.Drawing.Color.White;
            this.lblPhongTrong.Location = new System.Drawing.Point(601, 18);
            this.lblPhongTrong.Name = "lblPhongTrong";
            this.lblPhongTrong.Size = new System.Drawing.Size(200, 50);
            this.lblPhongTrong.TabIndex = 2;
            this.lblPhongTrong.Text = "Phòng trống";
            this.lblPhongTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTong
            // 
            this.lblTong.BackColor = System.Drawing.Color.Black;
            this.lblTong.ForeColor = System.Drawing.Color.White;
            this.lblTong.Location = new System.Drawing.Point(395, 18);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(200, 50);
            this.lblTong.TabIndex = 3;
            this.lblTong.Text = "Tổng";
            this.lblTong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlContainer
            // 
            this.pnlContainer.AutoScroll = true;
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlContainer.Location = new System.Drawing.Point(3, 99);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1218, 609);
            this.pnlContainer.TabIndex = 2;
            this.pnlContainer.WrapContents = false;
            // 
            // fmSoDoPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 711);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fmSoDoPhong";
            this.Text = "Sơ đồ phòng";
            this.Resize += new System.EventHandler(this.FmSoDoPhong_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel pnlContainer;
        private System.Windows.Forms.Label lblDangCoKhach;
        private System.Windows.Forms.Label lblChuaDon;
        private System.Windows.Forms.Label lblPhongTrong;
        private System.Windows.Forms.Label lblTong;
    }
}