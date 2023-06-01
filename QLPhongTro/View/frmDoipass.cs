using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLPhongTro.BUS;
using QLPhongTro.DTO;
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
    public partial class frmDoipass : DevExpress.XtraEditors.XtraForm
    {
        private AccountDTO loginAccount;

        private AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public frmDoipass(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(AccountDTO acc)
        {
            txttaikhoan.Text = acc.taikhoan;
        }

        private void UpdateAccount()
        {
            string taikhoan = txttaikhoan.Text;
            string password = txtmatkhaucu.Text;
            string newPass = txtmatkhaumoi.Text;
            string retypePass = txtnhaplaimk.Text;

            if (!newPass.Equals(retypePass))
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            else
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                AccountDTO accountDTO = new AccountDTO(taikhoan, password , newPass);
                if (AccountBUS.Instance.UpdatePassword(accountDTO))
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Cập nhật thành công");
                    Log.WriteLog("change account's information");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }
    }
}