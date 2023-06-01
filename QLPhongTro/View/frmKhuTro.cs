using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;
using QLPhongTro.BUS;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraGrid.Views.Grid;
using QLPhongTro.DTO;

namespace QLPhongTro.View
{
    public partial class frmKhuTro : DevExpress.XtraEditors.XtraForm
    {
        KhutroDTO curTable;
        public frmKhuTro()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            LoadTable();
            btnXoa.Enabled = false;
            SplashScreenManager.CloseForm();
        }


        private void LoadTable()
        {
            try
            {
                gcKhutro.DataSource = BUS.KhutroBUS.Instance.GetAllKhuTro();
                gvKhuTro.Columns[0].Caption = "Mã số";
                gvKhuTro.Columns[0].OptionsColumn.AllowEdit = false;
                gvKhuTro.Columns[1].Caption = "Tên Khu";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            mark:
            fThemKhu f = new fThemKhu();
            f.ShowDialog();
            if (f.Khu == -1)
                return;
            string khu = "Khu " + f.Khu;

            for (int i = 0; i < gvKhuTro.RowCount - 1; i++)
            {
                if (khu.Equals(gvKhuTro.GetRowCellValue(i, gvKhuTro.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên Khu này đã tồn tại!");
                    goto mark;
                }
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            if (KhutroBUS.Instance.InsertKhuTro(khu))
            {
                
                LoadTable();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Khu mới thành công","Thông Báo!");
                int tableID = (int)gvKhuTro.GetRowCellValue(gvKhuTro.RowCount - 1, gvKhuTro.Columns[0]);
                Log.WriteLog("Thêm Mới Khu, ID = " + tableID);
            }
            else
                XtraMessageBox.Show("Thêm Khu mới thất bại!", "Lỗi");
        }

        private void gcKhutro_DoubleClick(object sender, EventArgs e)
        {
            btnXoa.Enabled = true;
        }

        private void gvKhuTro_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            string name = view.GetRowCellValue(e.RowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên Khu không hợp lệ", "Lỗi");
                return;
            }

            for (int i = 0; i < gvKhuTro.RowCount - 1; i++)
            {
                if (name.Equals(gvKhuTro.GetRowCellValue(i, gvKhuTro.Columns[1]).ToString()))
                {
                    XtraMessageBox.Show("Tên Khu này đã tồn tại!");
                    gvKhuTro.SetRowCellValue(gvKhuTro.FocusedRowHandle, gvKhuTro.Columns[1], gvKhuTro);
                    return;
                }
            }
            int id = (int)view.GetRowCellValue(e.RowHandle, view.Columns[0]);
            if (KhutroBUS.Instance.UpdateKhuTro(id, name))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                SplashScreenManager.CloseForm();
                Log.WriteLog("update Khu: " + curTable.KhuTro + " to " + name);
                XtraMessageBox.Show("Sửa thông tin khu thành công", "Thông báo!!");
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin khu thất bại!!", "Lỗi");
            }
        }

       

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            int id = (int)gvKhuTro.GetRowCellValue(gvKhuTro.FocusedRowHandle, gvKhuTro.Columns[0]);
            string name = gvKhuTro.GetRowCellValue(gvKhuTro.FocusedRowHandle, gvKhuTro.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (KhutroBUS.Instance.DeleteKhuTro(id))
                {
                    LoadTable();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("Đã Xóa Tên Kho, ID = " + id);
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Không thể xóa "+name, "Thông báo");
                }
            }
            btnXoa.Enabled = false;
        }
        private void gvKhuTro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object khu = gvKhuTro.GetRowCellValue(gvKhuTro.FocusedRowHandle, gvKhuTro.Columns[1]);
            if (khu == null || khu == DBNull.Value)
                return;
            curTable = new KhutroDTO(khu.ToString());
        }
    }
}