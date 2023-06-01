using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using QLPhongTro.BUS;
using QLPhongTro.DTO;
using System;
using System.Windows.Forms;

namespace QLPhongTro.View
{
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        LoaiphongDTO curFood;
        public frmLoaiPhong()
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
                gcLoaiPhong.DataSource = LoaiphongBUS.Instance.GetAllLoaiPhong();
                gvLoaiPhong.Columns[0].Caption = "Mã số";
                gvLoaiPhong.Columns[0].OptionsColumn.AllowEdit = false;
                gvLoaiPhong.Columns[1].Caption = "Loại Phòng";
                gvLoaiPhong.Columns[2].Caption = "Giá Phòng";
                GridColumn colModelPrice = gvLoaiPhong.Columns[2];
                colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice.DisplayFormat.FormatString = "n0";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void gvLoaiPhong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object id = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;
            object name = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns[1]);
            if (name == null || name == DBNull.Value)
                return;
            object dongia = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns[2]);
            if (dongia == null || dongia == DBNull.Value)
                return;


            curFood = new LoaiphongDTO(name.ToString(), (int)dongia);
        }
        private void gvLoaiPhong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            if (view.IsNewItemRow(e.RowHandle))
                AddLoaiPhong(view, e.RowHandle);
            else
                UpdateLoaiPhong(view, e.RowHandle);
        }
        private void AddLoaiPhong(GridView view, int rowHandle)
        {
            string name = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (name == "")
            {
                XtraMessageBox.Show("Tên Loại Phòng được bỏ trống");
                return;
            }
            string priceTemp = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (priceTemp == "")
            {
                XtraMessageBox.Show("Đơn giá không được bỏ trống");
                return;
            }
            int price = int.Parse(priceTemp);
            if (price <= 0 || price > 100000000)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            LoaiphongDTO newloaiphong = new LoaiphongDTO(name, price);
            if (LoaiphongBUS.Instance.InsertLoaiPhong(newloaiphong))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                LoadTable();
                SplashScreenManager.CloseForm();
                Log.WriteLog("add new Loại Phòng: " + name);
                XtraMessageBox.Show("Thêm Loại Phòng mới Thành Công", "Thông Báo");
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Loại Phòng mới thất bại", "Lỗi");
            }
        }
        private void UpdateLoaiPhong(GridView view, int rowHandle)
        {
            string id_loaiphong = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            if (id_loaiphong == "") // id = "" when data is not inserted into database
            {
                AddLoaiPhong(view, rowHandle);
                return;
            }

            string loaiphong = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (loaiphong == "")
            {
                XtraMessageBox.Show("Tên Loại Phòng Không Hợp Lệ");
                return;
            }

            string priceTemp = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (priceTemp == "")
            {
                XtraMessageBox.Show("Đơn giá không được bỏ trống");
                return;
            }
            int dongia = int.Parse(priceTemp);
            if (dongia <= 0 || dongia > 100000000)
            {
                XtraMessageBox.Show("Đơn giá không hợp lệ");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoaiphongDTO newl = new LoaiphongDTO(int.Parse(id_loaiphong), loaiphong, dongia);
            if (LoaiphongBUS.Instance.UpdateLoaiPhong(newl))
            {
                LoadTable();
                
                Log.WriteLog("update Loại Phòng: Tên Loai Phong: " + curFood.LoaiPhong + " -> " + loaiphong
                                + ", Đơn Giá: " + curFood.DonGia + " -> " + dongia);
                XtraMessageBox.Show("Sửa thông tin tầng thành công", "Thông báo!!");
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin tầng thất bại\n Không thể thay đổi thông tin tầng hiện hành", "Lỗi");
            }
        }

        private void gcLoaiPhong_DoubleClick(object sender, EventArgs e)
        {
            if (gvLoaiPhong.FocusedRowHandle >= 0)
                btnXoa.Enabled = true;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = (int)gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns[0]);
            string name = gvLoaiPhong.GetRowCellValue(gvLoaiPhong.FocusedRowHandle, gvLoaiPhong.Columns[1]).ToString();

            if (XtraMessageBox.Show("Xóa " + name + "?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (LoaiphongBUS.Instance.DeleteLoaiPhong(id))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    LoadTable();
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Đã xóa " + name, "Thông báo");
                    Log.WriteLog("delete Tầng: " + name);
                }
                else
                    XtraMessageBox.Show("Không thể xóa loại phòng hiện hành", "Lỗi");
            }
            btnXoa.Enabled = false;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadTable();
            SplashScreenManager.CloseForm();
        }

        
    }
}