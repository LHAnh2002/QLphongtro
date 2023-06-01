using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPhongTro.View
{
    public partial class RestoreData : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LHANH\SQLEXPRESS;Initial Catalog=QLPhong;Integrated Security=True");

        public RestoreData()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "SQL SERVER database backup files(*.bak) | *.bak";
            openFileDialog.Title = "Database Restore";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtTep.Text = openFileDialog.FileName;
                btnRestore.Enabled = true;
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = conn.Database.ToString();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            conn.Open();
            try
            {
                string cmd = "USE [master]; RESTORE DATABASE [" + database + "] FROM DISK = N'" + txtTep.Text + "' WITH FILE = 1, NOUNLOAD, REPLACE;";
                SqlCommand sqlCommand = new SqlCommand(cmd, conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Khôi phục cơ sở dữ liệu thành công");
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Lỗi: " + ex.Message);
            }
        }



    }
}