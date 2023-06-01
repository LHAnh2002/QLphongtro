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
    public partial class frmCauHinh : DevExpress.XtraEditors.XtraForm
    {
        private AccountDTO loginAccount;

        private AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public frmCauHinh(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        void ChangeAccount(AccountDTO acc)
        {
            txttaikhoan.Text = acc.taikhoan;
            txttenphongtro.Text = acc.tenchutro;
            txtchuphongtro.Text = acc.chuphongtro;
            txtdiachiphongtro.Text = acc.diachiphongtro;
            txtdongiadien.Text = acc.dongiadien.ToString();
            txtdongianuoc.Text = acc.dongianuoc.ToString();
            txtsdt.Text = acc.sodienthoai;
            //txtDisplayName.Text = acc.DisplayName;
        }
        private void UpdateAccount()
        {
            string taikhoan = txttaikhoan.Text;
            string tenphongtro = txttenphongtro.Text;
            string chuphongtro = txtchuphongtro.Text;
            string diachiphongtro = txtdiachiphongtro.Text;
            string dongiadien = txtdongiadien.Text;
            string dongianuoc = txtdongianuoc.Text;
            string sodienthoai = txtsdt.Text;

                SplashScreenManager.ShowForm(typeof(WaitForm1));
                AccountDTO accountDTO = new AccountDTO(taikhoan, tenphongtro, chuphongtro, diachiphongtro, int.Parse(dongiadien), int.Parse(dongianuoc), sodienthoai);
                if (AccountBUS.Instance.UpdateInformation(accountDTO))
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Cập nhật thành công");
                    Log.WriteLog("change account's information");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Lỗi thực thi");
                }
         }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            txtdongiadien.Enabled = true;
            txtdongianuoc.Enabled = true;
        }
    }
}
