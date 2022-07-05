
namespace GUI
{
    partial class UcPhong
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
            this.btnPhong = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnPhong
            // 
            this.btnPhong.Appearance.BackColor = System.Drawing.Color.White;
            this.btnPhong.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhong.Appearance.Options.UseBackColor = true;
            this.btnPhong.Appearance.Options.UseFont = true;
            this.btnPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPhong.ImageOptions.Image = global::GUI.Properties.Resources.icons8_room_64px_1;
            this.btnPhong.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnPhong.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btnPhong.Location = new System.Drawing.Point(0, 0);
            this.btnPhong.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnPhong.Name = "btnPhong";
            this.btnPhong.Size = new System.Drawing.Size(180, 165);
            this.btnPhong.TabIndex = 0;
            this.btnPhong.Text = "simpleButton1";
            this.btnPhong.Click += new System.EventHandler(this.btnPhong_Click);
            // 
            // UcPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPhong);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "UcPhong";
            this.Size = new System.Drawing.Size(180, 165);
            this.Load += new System.EventHandler(this.UcPhong_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public DevExpress.XtraEditors.SimpleButton btnPhong;
    }
}
