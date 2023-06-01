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
    public partial class backupData : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LHANH\SQLEXPRESS;Initial Catalog=QLPhong;Integrated Security=True");

        public backupData()
        {
            InitializeComponent();
        }

        private void btnTep_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog = new FolderBrowserDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtTep.Text = openFileDialog.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            string connectionString = conn.ConnectionString; // Sử dụng chuỗi kết nối từ biến conn
            string backupPath = txtTep.Text.Trim(); // Đường dẫn tới thư mục lưu file sao lưu

            // Tạo tên tệp tin sao lưu không chứa các ký tự không hợp lệ
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string backupName = "backup_" + timeStamp + ".bak";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string databaseName = connection.Database;
                    string backupQuery = $"BACKUP DATABASE {databaseName} TO DISK = '{backupPath}\\{backupName}'";

                    using (SqlCommand command = new SqlCommand(backupQuery, connection))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sao lưu dữ liệu thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sao lưu dữ liệu: " + ex.Message);
            }
        }
    }
}