
namespace GUI
{
    partial class fmDoiMatKhau
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDoiMatKhau = new System.Windows.Forms.Button();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassOld = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtPassNew);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPassOld);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(30);
            this.groupBox1.Size = new System.Drawing.Size(522, 317);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đổi mật khẩu";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnDoiMatKhau);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(30, 217);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel1.Size = new System.Drawing.Size(462, 67);
            this.panel1.TabIndex = 4;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(153, 22);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 42);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDoiMatKhau
            // 
            this.btnDoiMatKhau.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDoiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDoiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiMatKhau.Location = new System.Drawing.Point(286, 22);
            this.btnDoiMatKhau.Name = "btnDoiMatKhau";
            this.btnDoiMatKhau.Size = new System.Drawing.Size(173, 42);
            this.btnDoiMatKhau.TabIndex = 0;
            this.btnDoiMatKhau.Text = "Đổi mật khẩu";
            this.btnDoiMatKhau.UseVisualStyleBackColor = false;
            this.btnDoiMatKhau.Click += new System.EventHandler(this.btnDoiMatKhau_Click);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassNew.Location = new System.Drawing.Point(30, 185);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(462, 32);
            this.txtPassNew.TabIndex = 1;
            this.txtPassNew.TextChanged += new System.EventHandler(this.txtPassNew_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(30, 121);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 30, 0, 10);
            this.label2.Size = new System.Drawing.Size(138, 64);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật khẩu mới:";
            // 
            // txtPassOld
            // 
            this.txtPassOld.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPassOld.Location = new System.Drawing.Point(30, 89);
            this.txtPassOld.Name = "txtPassOld";
            this.txtPassOld.Size = new System.Drawing.Size(462, 32);
            this.txtPassOld.TabIndex = 0;
            this.txtPassOld.TextChanged += new System.EventHandler(this.txtPassOld_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(30, 55);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.label1.Size = new System.Drawing.Size(125, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu cũ:";
            // 
            // fmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 337);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmDoiMatKhau";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.fmDoiMatKhau_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDoiMatKhau;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassOld;
        private System.Windows.Forms.Label label1;
    }
}