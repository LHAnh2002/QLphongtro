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

namespace QLPhongTro.View
{
    public partial class fThemKhu : DevExpress.XtraEditors.XtraForm
    {
        public fThemKhu()
        {
            InitializeComponent();
        }
        public int Khu { get; set; }
        private void btnThemKho_Click(object sender, EventArgs e)
        {
            if (txtThemKho.Text == "")
            {
                XtraMessageBox.Show("Hãy nhập dữ liệu!!");
                return;
            }

            int temp;
            if (int.TryParse(txtThemKho.Text, out temp) == false)
            {
                XtraMessageBox.Show("Dữ liệu không hợp lệ!!");
                txtThemKho.Focus();
                return;
            }
            else
            {
                Khu = temp;
                this.Close();
            }
        }

        private void fThemKhu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtThemKho.Text == "")
                Khu = -1;
        }
    }
}