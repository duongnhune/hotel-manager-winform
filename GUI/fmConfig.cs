using DevExpress.XtraEditors;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmConfig : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dt = Config.GetServerName();
        public fmConfig()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmConfig_Load(object sender, EventArgs e)
        {

        }

        private void cbbServer_DropDown(object sender, EventArgs e)
        {

            foreach (DataRow row in dt.Rows)
            {
                cbbServer.Items.Add(row["InstanceName"].ToString());
            }
            
        }
        private void cbbDb_DropDown(object sender, EventArgs e)
        {
            var item = Config.GetDBName(cbbServer.Text, txtUser.Text, txtPass.Text); 
            if(item != null)
            {
                cbbDb.DataSource = item;
                cbbDb.DisplayMember = "name";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = Config.SaveConfig(cbbServer.Text, txtUser.Text, txtPass.Text, cbbDb.Text);
            if(result == 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Chuỗi cấu hình không hợp lệ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbbServer_TextChanged(object sender, EventArgs e)
        {
            checkEmpty();
        }
        private void checkEmpty()
        {
            if(cbbServer.Text.Trim() != string.Empty && txtUser.Text.Trim() != string.Empty && txtPass.Text.Trim() != string.Empty)
            {
                cbbDb.Enabled = true;
                btnLuu.Enabled = true;
            }
        }
    }
}