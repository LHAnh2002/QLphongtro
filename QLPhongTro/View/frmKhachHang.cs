using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLPhongTro.DAO;
using QLPhongTro.BUS;
using System;
using QLPhongTro.DTO;
using DevExpress.XtraGrid.Views.Grid;
using System.Windows.Forms;

namespace QLPhongTro.View
{   
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        KhachhangDTO curKhachhang;
        public frmKhachHang()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            btnXoaa.Enabled = false;
            cbbKhachhangh.SelectedIndex = 0;
            LoadKhachhang();
            SplashScreenManager.CloseForm();
        }
        private void LoadKhachhang()
        {
            try
            {   
                if(cbbKhachhangh.Text == "Khách Hàng") {
                    gcKhachHang.DataSource = KhachhangBUS.Instance.GetAllKhachHang();
                    gvKhachHang.Columns[0].Caption = "Mã số";
                    gvKhachHang.Columns[0].OptionsColumn.AllowEdit = false;
                    gvKhachHang.Columns[1].Caption = "Họ";
                    gvKhachHang.Columns[2].Caption = "Tên Đệm";
                    gvKhachHang.Columns[3].Caption = "Tên";
                    gvKhachHang.Columns[4].Caption = "Tên Phòng";
                    gvKhachHang.Columns[5].Caption = "Giá Phòng";
                    gvKhachHang.Columns[6].Caption = "CCCD";
                    gvKhachHang.Columns[7].Caption = "Số điện thoại";
                    gvKhachHang.Columns[8].Caption = "Quê Quán";
                    gvKhachHang.Columns[9].Caption = "HKTT";
                    gvKhachHang.Columns[10].Caption = "Trạng Thái";
                }else if(cbbKhachhangh.Text == "Tất Cả Khách Hàng")
                {
                    gcKhachHang.DataSource = KhachhangBUS.Instance.GetAllAllKhachHang();
                    gvKhachHang.Columns[0].Caption = "Mã số";
                    gvKhachHang.Columns[0].OptionsColumn.AllowEdit = false;
                    gvKhachHang.Columns[1].Caption = "Họ";
                    gvKhachHang.Columns[2].Caption = "Tên Đệm";
                    gvKhachHang.Columns[3].Caption = "Tên";
                    gvKhachHang.Columns[4].Caption = "Tên Phòng";
                    gvKhachHang.Columns[5].Caption = "Giá Phòng";
                    gvKhachHang.Columns[6].Caption = "CCCD";
                    gvKhachHang.Columns[7].Caption = "Số điện thoại";
                    gvKhachHang.Columns[8].Caption = "Quê Quán";
                    gvKhachHang.Columns[9].Caption = "HKTT";
                    gvKhachHang.Columns[10].Caption = "Trạng Thái";
                }
                

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void gvKhachHang_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

            object id = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[0]);
            if (id == null || id == DBNull.Value)
                return;
            object ho = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[1]);
            if (ho == null || ho == DBNull.Value)
                return;
            object tendem = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[2]);
            if (tendem == null || tendem == DBNull.Value)
                return;
            object ten = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[3]);
            if (ten == null || ten == DBNull.Value)
                return;
            object cccd = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[6]);
            if (cccd == null || cccd == DBNull.Value)
                return;
            object sdt = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[7]);
            if (sdt == null || sdt == DBNull.Value)
                return;
            object quequan = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[8]);
            if (quequan == null || quequan == DBNull.Value)
                return;
            object hktt = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[9]);
            if (hktt == null || hktt == DBNull.Value)
                return;
            object trangthai = gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, gvKhachHang.Columns[10]);
            if (trangthai == null || trangthai == DBNull.Value)
                return;

            curKhachhang = new KhachhangDTO((int)id,ho.ToString(), tendem.ToString(), ten.ToString(), cccd.ToString(), sdt.ToString(), quequan.ToString(), hktt.ToString(),(bool)trangthai);
        }
        private void gvKhachHang_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            UpdateKhachhang(view, e.RowHandle);
        }
        private void UpdateKhachhang(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[0]).ToString();
            string ho = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            if (ho == "")
            {
                XtraMessageBox.Show("Họ Không Hợp lệ");
                return;
            }
            string tendem = view.GetRowCellValue(rowHandle, view.Columns[2]).ToString();
            if (tendem == "")
            {
                XtraMessageBox.Show("Tên đệm không hợp lệ");
                return;
            }
            string ten = view.GetRowCellValue(rowHandle, view.Columns[3]).ToString();
            if (ten == "")
            {
                XtraMessageBox.Show("Tên không hợp lệ");
                return;
            }
            string cccd = view.GetRowCellValue(rowHandle, view.Columns[6]).ToString();
            if (cccd == "")
            {
                XtraMessageBox.Show("CCCD không hợp lệ");
                return;
            }
            string sdt = view.GetRowCellValue(rowHandle, view.Columns[7]).ToString();
            if (sdt == "")
            {
                XtraMessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            string quequan = view.GetRowCellValue(rowHandle, view.Columns[8]).ToString();
            if (quequan == "")
            {
                XtraMessageBox.Show("Quê Quán không hợp lệ");
                return;
            }
            string hktt = view.GetRowCellValue(rowHandle, view.Columns[9]).ToString();
            if (hktt == "")
            {
                XtraMessageBox.Show("HKTT không hợp lệ");
                return;
            }
            string trangthai = view.GetRowCellValue(rowHandle, view.Columns[10]).ToString();
            if (trangthai == "")
            {
                XtraMessageBox.Show("Trạng Thái không hợp lệ");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            KhachhangDTO khachhang = new KhachhangDTO(int.Parse(id), ho, tendem, ten, cccd, sdt, quequan, hktt , bool.Parse(trangthai));
            if (KhachhangBUS.Instance.UpdateKhachhang(khachhang))
            {
                LoadKhachhang();
                SplashScreenManager.CloseForm();
                Log.WriteLog("update khách hàng: Tên khách hàng:" + curKhachhang.Ho + " " + curKhachhang.TenDem + " " + curKhachhang.Ten+ "  -> " + ho + " " + tendem + " " + ten
                              + ", CCCD:  " + curKhachhang.CCCD + "-> " + cccd
                              + ", Số Điện Thoại:  " + curKhachhang.sdt + "-> " + sdt
                              + ", Quê Quán:  " + curKhachhang.quequan + "-> " + quequan
                              + ", HKTT:  " + curKhachhang.hktt + "-> " + hktt
                              + ", Trạng thái:  " + curKhachhang.trangthai + "-> " + trangthai);
                XtraMessageBox.Show("Sửa thông tin Khách hàng thành công", "Thông báo!!");
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Sửa thông tin khách hàng thất bại\n Không thể thay đổi thông tin khách hàng hiện hành", "Lỗi");
            }
        }
        private void gcKhachHang_DoubleClick(object sender, EventArgs e)
        {
            if (gvKhachHang.FocusedRowHandle >= 0)
                btnXoaa.Enabled = true;
        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            LoadKhachhang();
            SplashScreenManager.CloseForm();
        }

        private void cbbKhachhangh_TextChanged(object sender, EventArgs e)
        {
            LoadKhachhang();
        }
    }
}