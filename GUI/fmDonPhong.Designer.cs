
namespace GUI
{
    partial class fmDonPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDaDon = new System.Windows.Forms.Button();
            this.btnChuaDon = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChuaDon);
            this.panel1.Controls.Add(this.btnDaDon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 184);
            this.panel1.TabIndex = 0;
            // 
            // btnDaDon
            // 
            this.btnDaDon.Location = new System.Drawing.Point(52, 27);
            this.btnDaDon.Name = "btnDaDon";
            this.btnDaDon.Size = new System.Drawing.Size(294, 55);
            this.btnDaDon.TabIndex = 1;
            this.btnDaDon.Text = "Đã dọn phòng";
            this.btnDaDon.UseVisualStyleBackColor = true;
            this.btnDaDon.Click += new System.EventHandler(this.btnDaDon_Click);
            // 
            // btnChuaDon
            // 
            this.btnChuaDon.Location = new System.Drawing.Point(52, 104);
            this.btnChuaDon.Name = "btnChuaDon";
            this.btnChuaDon.Size = new System.Drawing.Size(294, 55);
            this.btnChuaDon.TabIndex = 2;
            this.btnChuaDon.Text = "Chưa dọn";
            this.btnChuaDon.UseVisualStyleBackColor = true;
            this.btnChuaDon.Click += new System.EventHandler(this.btnChuaDon_Click);
            // 
            // fmDonPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 224);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDonPhong";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dọn phòng";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChuaDon;
        private System.Windows.Forms.Button btnDaDon;
    }
}