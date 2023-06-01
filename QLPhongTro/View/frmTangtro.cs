using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraSplashScreen;
using System;
using System.Windows.Forms;
using QLPhongTro.DTO;
using QLPhongTro.BUS;
using DevExpress.XtraGrid.Views.Grid;

namespace QLPhongTro.View
{
    public partial class frmTangtro : DevExpress.XtraEditors.XtraForm
    {
        TangtroDTO curTang;
        //string curTang;
        public frmTangtro()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            btnXoa.Enabled = false;
            LoadTangTroToGridControl();
            SplashScreenManager.CloseForm();
        }
        private void LoadTangTroToGridControl()
        {
            try
            {
                gcTangTro.DataSource = TangtroBUS.Instance.GetAllTangTro();
                gvTangTro.Columns[0].Caption = "Mã số";
                gvTangTro.Columns[0].OptionsColumn.AllowEdit = false;
                gvTangTro.Columns[1].Caption = "Khu Trọ";
                gvTangTro.Columns[2].Caption = "Tên Tầng";
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }

            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = KhutroBUS.Instance.GetAllKhuTro();
                myLookup.DisplayMember = "Tenkhu";
                myLookup.ValueMember = "ID_Khutro";    
                myLookup.NullText = "-- Chọn danh mục --";
                gvTangTro.Columns[1].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void gvTangTro_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddTangTro(view, e.RowHandle);
            else
                UpdateTangTro(view, e.RowHandle);
        }
        private void AddTangTro(GridView view, int rowHandle)
        {   
            string khu = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (khu == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                return;
            }
            string name = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên Tầng không hợp lệ");
                return;
            }
            
            TangtroDTO newFood = new TangtroDTO(name, int.Parse(khu));
            if (TangtroBUS.Instance.InsertKhuTro(newFood))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTangTroToGridControl();
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Tầng mới thành công");
                Log.WriteLog("add new Tầng: " + name);
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Tầng mới thất bại", "Lỗi");
            }
        }
        private void UpdateTangTro(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id == "") // id = "" when data is not inserted into database
            {
                AddTangTro(view, rowHandle);
                return;
            }

            string khu = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (khu == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục");
                return;
            }
            string name = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên Tầng không hợp lệ");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            TangtroDTO food = new TangtroDTO(int.Parse(id), name, int.Parse(khu));
            if (TangtroBUS.Instance.UpdateKhuTro(food))
            {
                LoadTangTroToGridControl();
                SplashScreenManager.CloseForm();
                Log.WriteLog("update Tầng: Tên Tầng:"+ curTang.TenTang + "  -> " + name
                              + ", ID Khu:  " + curTang.ID_Khu + "-> " + khu);
                XtraMessageBox.Show("Sửa thông tin Tầng thành công", "Thông báo!!");
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin tầng thất bại\n Không thể thay đổi thông tin tầng hiện hành", "Lỗi");
            }
        }

        private void gcTangTro_DoubleClick(object sender, EventArgs e)
        {
            if (gvTangTro.FocusedRowHandle >= 0)
                btnXoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)gvTangTro.GetRowCellValue(gvTangTro.FocusedRowHandle, gvTangTro.Columns[0]);
            string name = gvTangTro.GetRowCellValue(gvTangTro.FocusedRowHandle, gvTangTro.Columns[2]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (TangtroBUS.Instance.DeleteKhuTro(id))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTangTroToGridControl();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Tầng: " + name);
                }
                else
                    XtraMessageBox.Show("Không thể xóa "+ name + " hiện hành", "Lỗi");
            }
            btnXoa.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTangTroToGridControl();
            SplashScreenManager.CloseForm();
        }

        private void gvTangTro_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object id = gvTangTro.GetRowCellValue(gvTangTro.FocusedRowHandle, gvTangTro.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;
            object categoryID = gvTangTro.GetRowCellValue(gvTangTro.FocusedRowHandle, gvTangTro.Columns[1]);
            if (categoryID == null || categoryID == DBNull.Value)
                return;

            object name = gvTangTro.GetRowCellValue(gvTangTro.FocusedRowHandle, gvTangTro.Columns[2]);
            if (name == null || name == DBNull.Value)
                return;

            curTang = new TangtroDTO(name.ToString(), (int)categoryID);
        }
    }
}