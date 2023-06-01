using DevExpress.LookAndFeel;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using QLPhongTro.BUS;
using QLPhongTro.DTO;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace QLPhongTro.View
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private AccountDTO loginAccount;
        int idtypes = 0;
        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; DisplayAccount(loginAccount); }
        }
        public frmMain(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;

        }
        DefaultLookAndFeel defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
        void DisplayAccount(AccountDTO acc)
        {
                baquanly.Caption = "Chào Bạn: " + acc.tenchutro;
            idtypes = acc.idtype;
            if (acc.idtype == 1)
            {
                btntaotaikhoan.Enabled = true;
                btnkhutro.Enabled = true;
                btntangtro.Enabled = true;
                btnkhoiphuc.Enabled = true;
                btnsaoluu.Enabled = true;
                btnloaitro.Enabled = true;
                btnkhutro.Enabled = true;
                btnloaiphong.Visible = true;
                bachucvu.Caption = "Chức Vụ: Quản Lý";
            }
            else
            {
                bachucvu.Caption = "Chức Vụ: Nhân Viên";
            }
                
        }
        public void skin()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Valentine";// tên giao diện mặc định bắt đầu loadform
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            skin();
          
        }
        private Form CheckFormExist(Type fType)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }
        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmTangtro));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmTangtro f = new frmTangtro();
                
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmKhuTro));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhuTro f = new frmKhuTro();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmPhong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhong f = new frmPhong();
                f.idtype = idtypes.ToString();
                f.MdiParent = this;
                f.Show();
            }
            
        }
        private void barButtonItem16_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmLoaiPhong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLoaiPhong f = new frmLoaiPhong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem22_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmhopdong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmhopdong f = new frmhopdong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(backupData));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                backupData f = new backupData();
                f.ShowDialog();
            }
            
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(RestoreData));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                RestoreData f = new RestoreData();
                f.ShowDialog();
            }
            
        }

        private void btnthemhopdong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmThemhopdong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmThemhopdong f = new frmThemhopdong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnhopdong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmhopdong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmhopdong f = new frmhopdong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnkhachhang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
           
        }

        private void btnphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmPhong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmPhong f = new frmPhong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void btnloaiphong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmLoaiPhong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmLoaiPhong f = new frmLoaiPhong();
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmCauHinh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmCauHinh f = new frmCauHinh(loginAccount);
                f.MdiParent = this;
                f.Show();
            }
            
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                frmMain_Load(sender, e);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmDoipass));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmDoipass f = new frmDoipass(loginAccount);
                f.Show();
            }
        }

        private void barButtonItem26_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmKhachHang));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void barButtonItem27_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = this.CheckFormExist(typeof(frmhopdong));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                frmhopdong f = new frmhopdong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btntaotaikhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDangky frmRegister = new frmDangky();
            frmRegister.Show();
        }
    }
}