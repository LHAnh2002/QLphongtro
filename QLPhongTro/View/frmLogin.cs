using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLPhongTro.BUS;
using QLPhongTro.DTO;
using System;
using System.IO;
using System.Windows.Forms;

namespace QLPhongTro.View
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
            txtMatKhau.Properties.PasswordChar = '*';
            
        }

        private void btnDangNhap_CheckedChanged(object sender, EventArgs e)
        {
            
            AccountDTO account = new AccountDTO(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
            try
            {
                if (AccountBUS.Instance.CheckLogin(account))
                {
                    Log.WriteLog("----------" + account.taikhoan + " log in ----------");
                    
                    AccountDTO acc = AccountBUS.Instance.GetAccountByUserName(account.taikhoan);
                    frmMain f = new frmMain(acc);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    XtraMessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex);
            }
            
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";// tên giao diện mặc định bắt đầu loadform
        }


        private void frmLogin_Load(object sender, EventArgs e)
        {
            skin();
            this.KeyPreview = true;
            this.KeyDown += frmLogin_KeyDown;
            txtTaiKhoan.Text = Properties.Settings.Default.taikhoan;
            txtMatKhau.Text = Properties.Settings.Default.matkhau;
            if (Properties.Settings.Default.taikhoan != "")
            {
                cbGhiNho.Checked = true;
            }
        }

        private void btnCancel_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
                e.Cancel = true;
        }

        private void cbGhiNho_CheckedChanged(object sender, EventArgs e)
        {
            if(txtTaiKhoan.Text !="" && txtMatKhau.Text != "")
            {
                if(cbGhiNho.Checked == true)
                {
                    string taikhoan = txtTaiKhoan.Text;
                    string matkhau = txtMatKhau.Text;
                    Properties.Settings.Default.taikhoan = taikhoan;
                    Properties.Settings.Default.matkhau = matkhau;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_CheckedChanged(sender, e);
            }
        }
    }
}