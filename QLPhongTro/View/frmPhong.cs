using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using QLPhongTro.BUS;
using QLPhongTro.DTO;
using System;
using System.Windows.Forms;

namespace QLPhongTro.View
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        PhongDTO Phong;
        public string idtype { get; set; }
        public frmPhong()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            btnXoa.Enabled = false;
            cbbPhong.SelectedIndex = 0;
            LoadTangTroToGridControl();
            SplashScreenManager.CloseForm();
        }
        private void LoadTangTroToGridControl()
        {
            try
            {
                if (cbbPhong.Text == "Phòng Trống")
                {
                    gcPhong.DataSource = PhongBUS.Instance.GetAllPhongTrong();
                    gvPhong.Columns[0].Caption = "Mã số";
                    gvPhong.Columns[0].OptionsColumn.AllowEdit = false;
                    gvPhong.Columns[1].Caption = "Khu";
                    gvPhong.Columns[1].OptionsColumn.AllowEdit = false;
                    gvPhong.Columns[2].Caption = "Tầng";
                    gvPhong.Columns[3].Caption = "Tên Phòng";
                    gvPhong.Columns[4].Caption = "Loại Phong";
                    gvPhong.Columns[5].Caption = "Đơn giá";
                    gvPhong.Columns[5].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice = gvPhong.Columns[5];
                    colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice.DisplayFormat.FormatString = "n0";
                    gvPhong.Columns[6].Caption = "Trạng Thái Hoạt Động";
                }
                else if(cbbPhong.Text == "Tất Cả Phòng")
                {
                    gcPhong.DataSource = PhongBUS.Instance.GetAllPhong();
                    gvPhong.Columns[0].Caption = "Mã số";
                    gvPhong.Columns[0].OptionsColumn.AllowEdit = false;
                    gvPhong.Columns[1].Caption = "Khu";
                    gvPhong.Columns[1].OptionsColumn.AllowEdit = false;
                    gvPhong.Columns[2].Caption = "Tầng";
                    gvPhong.Columns[3].Caption = "Tên Phòng";
                    gvPhong.Columns[4].Caption = "Loại Phong";
                    gvPhong.Columns[5].Caption = "Đơn giá";
                    gvPhong.Columns[5].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice = gvPhong.Columns[5];
                    colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice.DisplayFormat.FormatString = "n0";
                    gvPhong.Columns[6].Caption = "Trạng Thái Hoạt Động";
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
            RepositoryItemLookUpEdit myLookup = new RepositoryItemLookUpEdit();
            try
            {
                myLookup.DataSource = LoaiphongBUS.Instance.GetAllLoaiPhong();
                myLookup.DisplayMember = "Tenloaiphong";
                myLookup.ValueMember = "ID_Loaiphong";
                myLookup.NullText = "-- Chọn danh mục --";
                gvPhong.Columns[4].ColumnEdit = myLookup;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
            RepositoryItemLookUpEdit myLookup1 = new RepositoryItemLookUpEdit();
            try
            {
                myLookup1.DataSource = TangtroBUS.Instance.GetAllTangTro();
                myLookup1.DisplayMember = "Tentang";
                myLookup1.ValueMember = "ID_Tangtro";
                myLookup1.NullText = "-- Chọn danh mục --";
                gvPhong.Columns[2].ColumnEdit = myLookup1;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }

        private void gvPhong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddPhong(view, e.RowHandle);
            else
                UpdatePhong(view, e.RowHandle);
        }
        private void AddPhong(GridView view, int rowHandle)
        {
            if (int.Parse(idtype) == 1)
            {
                string tang = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
                if (tang == "")
                {
                    XtraMessageBox.Show("Hãy chọn danh mục tầng");
                    return;
                }
                string tenphong = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
                if (tenphong == "")
                {
                    XtraMessageBox.Show("Tên phòng không hợp lệ");
                    return;
                }
                string loaiphong = view.GetRowCellValue(rowHandle, view.Columns[4]).ToString();
                if (loaiphong == "")
                {
                    XtraMessageBox.Show("Hãy chọn danh mục Loai phong");
                    return;
                }
                PhongDTO newPhong = new PhongDTO(int.Parse(loaiphong), int.Parse(tang), tenphong);
                if (PhongBUS.Instance.InsertPhong(newPhong))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTangTroToGridControl();

                    Log.WriteLog("add new Tầng: " + tenphong);
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Thêm Phòng mới thành công");
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Thêm Phòng mới thất bại", "Lỗi");
                }
            }
            else
            {
                XtraMessageBox.Show("Bạn không đủ quyền để thêm phòng trọ!", "Thông báo!");
            }
        }
        private void UpdatePhong(GridView view, int rowHandle)
        {
            string id_phong = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id_phong == "") // id = "" when data is not inserted into database
            {
                AddPhong(view, rowHandle);
                return;
            }
            string tang = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (tang == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục tầng");
                return;
            }
            string tenphong = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (tenphong == "")
            {
                XtraMessageBox.Show("Tên phòng không hợp lệ");
                return;
            }
            string loaiphong = view.GetRowCellValue(rowHandle, view.Columns[4]).ToString();
            if (loaiphong == "")
            {
                XtraMessageBox.Show("Hãy chọn danh mục Loai phong");
                return;
            }
            string trangthai = view.GetRowCellValue(rowHandle, view.Columns[6]).ToString();
            if (trangthai == "")
            {
                XtraMessageBox.Show("Trạng Thái không hợp lệ");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            PhongDTO phong = new PhongDTO(int.Parse(id_phong), int.Parse(loaiphong), int.Parse(tang), tenphong, bool.Parse(trangthai));
            if (PhongBUS.Instance.UpdatePhong(phong))
            {
                LoadTangTroToGridControl();
                
                Log.WriteLog("update Phòng:ID Loại Phòng: "+phong.ID_Loaiphong+" -> " + loaiphong
                              + ", ID Tầng:  " + phong.ID_Tang + " -> " + tang
                              + ", Tên Phòng:  " + phong.TenPhong + " -> " + tenphong
                              + ", Trạng Thái: " + phong.TrangThai + "  -> " + trangthai);
                XtraMessageBox.Show("Sửa thông tin Phòng thành công", "Thông báo!!");
                    SplashScreenManager.CloseForm();
                }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin phòng thất bại\n Không thể thay đổi thông tin phòng hiện hành", "Lỗi");
            }
        }

        private void gcPhong_DoubleClick(object sender, EventArgs e)
        {
            if (gvPhong.FocusedRowHandle >= 0)
                btnXoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[0]);
            string name = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[3]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (PhongBUS.Instance.DeletePhong(id))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTangTroToGridControl();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Tầng: " + name);
                }
                else
                    XtraMessageBox.Show("Không thể xóa phòng hiện hành", "Lỗi");
            }
            btnXoa.Enabled = false;
        }

        private void btnTailai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTangTroToGridControl();
            SplashScreenManager.CloseForm();
        }

        private void gvPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object id = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;
            object tang = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[2]);
            if (tang == null || tang == DBNull.Value)
                return;

            object tenphong = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[3]);
            if (tenphong == null || tenphong == DBNull.Value)
                return;
            object loaiphong = gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, gvPhong.Columns[4]);
            if (loaiphong == null || loaiphong == DBNull.Value)
                return;

            Phong = new PhongDTO((int)tang, (int)loaiphong,  tenphong.ToString());
        }

        private void cbbPhong_TextChanged(object sender, EventArgs e)
        {
            LoadTangTroToGridControl();
        }
    }
}