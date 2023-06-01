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
    public partial class frmDangky : DevExpress.XtraEditors.XtraForm
    {
        public frmDangky()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string taikhoan = txttaikhoan.Text.Trim();
            string matkhau = txtmatkhau.Text.Trim();
            string tenphongtro = "ĐH Hà Tĩnh";
            string chuphongtro = txtchuphongtro.Text.Trim(); 
            string diachiphongtro = txtdiachiphongtro.Text.Trim();
            string sodienthoai = txtsdt.Text.Trim();
            string idtype = cbbquyen.Text.Trim();
            try
            {
                if (taikhoan == "")
                {
                    XtraMessageBox.Show("Tài Khoản Không Hợp lệ");
                    return;
                }
                if (matkhau == "")
                {
                    XtraMessageBox.Show("Mật Khẩu không hợp lệ");
                    return;
                }
                if (chuphongtro == "")
                {
                    XtraMessageBox.Show("Tên chủ phòng trọ không hợp lệ");
                    return;
                }
                if (diachiphongtro == "")
                {
                    XtraMessageBox.Show("Địa chỉ phòng trọ không hợp lệ");
                    return;
                }
                if (sodienthoai == "")
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ");
                    return;
                }
                if (idtype == "")
                {
                    XtraMessageBox.Show("Số điện thoại không hợp lệ");
                }

                    AccountDTO account = new AccountDTO(taikhoan, matkhau, tenphongtro, chuphongtro, diachiphongtro, sodienthoai,int.Parse(idtype));
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                if (AccountBUS.Instance.Insertcauhinh(account))
                {   
                    
                    XtraMessageBox.Show("Đang ký tài khoản thành công!", "Thông báo!");
                    txttaikhoan.Text = "";
                    txtmatkhau.Text = "";
                    txtchuphongtro.Text = "";
                    txtdiachiphongtro.Text = "";
                    txtsdt.Text = "";
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đang ký tài khoản thất bại!", "Thông báo!");
                }
            }catch (Exception ex)
            {
                XtraMessageBox.Show("Error:" + ex);
            }
        }
    }
}