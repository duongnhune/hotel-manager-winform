namespace GUI.UserControls
{
    partial class UcTangLau
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTang = new System.Windows.Forms.Label();
            this.pnlContainerPhong = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.lblTang, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlContainerPhong, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 205);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTang
            // 
            this.lblTang.AutoSize = true;
            this.lblTang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTang.Location = new System.Drawing.Point(4, 0);
            this.lblTang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTang.Name = "lblTang";
            this.lblTang.Size = new System.Drawing.Size(198, 205);
            this.lblTang.TabIndex = 0;
            this.lblTang.Text = "Tầng";
            this.lblTang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTang.Click += new System.EventHandler(this.lblTang_Click);
            // 
            // pnlContainerPhong
            // 
            this.pnlContainerPhong.AutoScroll = true;
            this.pnlContainerPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainerPhong.Location = new System.Drawing.Point(209, 3);
            this.pnlContainerPhong.Name = "pnlContainerPhong";
            this.pnlContainerPhong.Size = new System.Drawing.Size(788, 199);
            this.pnlContainerPhong.TabIndex = 1;
            this.pnlContainerPhong.WrapContents = false;
            this.pnlContainerPhong.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainerPhong_Paint);
            // 
            // UcTangLau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UcTangLau";
            this.Size = new System.Drawing.Size(1000, 205);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTang;
        private System.Windows.Forms.FlowLayoutPanel pnlContainerPhong;
    }
}
