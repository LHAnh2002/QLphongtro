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
    public partial class frmhopdong : DevExpress.XtraEditors.XtraForm
    {
        //CtHopdongDTO curThanhtoan;
        public frmhopdong()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            btnXoa.Enabled = false;
            btngiahan.Enabled = false;
            btnthanhtoan.Enabled = false;
            btntraphong.Enabled = false;
            cbbHopdong.SelectedIndex = 0;
            txtThanhtoan.Enabled = false;
            CTLoadHopdong();
            SplashScreenManager.CloseForm();
            gvCTHopDong.OptionsView.ColumnAutoWidth = false;

        }
        private void CTLoadHopdong()
        {
            try
            {
                if (cbbHopdong.Text == "Hợp Đồng")
                {
                    gcCTHopDong.DataSource = HopdongBUS.Instance.GetAllHopDong();
                    gvCTHopDong.Columns[0].Caption = "Mã Số CT Hợp Đồng";
                    gvCTHopDong.Columns[0].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[1].Caption = "Mã Số Hợp Đồng";
                    gvCTHopDong.Columns[1].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[2].Caption = "Tên Phòng";
                    gvCTHopDong.Columns[2].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[3].Caption = "Giá Phòng";
                    gvCTHopDong.Columns[3].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice = gvCTHopDong.Columns[3];
                    colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[4].Caption = "Đặt Cọc";
                    gvCTHopDong.Columns[4].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice1 = gvCTHopDong.Columns[4];
                    colModelPrice1.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice1.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[5].Caption = "Ngày Thuê";
                    gvCTHopDong.Columns[6].Caption = "Ngày Trả";
                    gvCTHopDong.Columns[7].Caption = "Chỉ số điện cũ";
                    gvCTHopDong.Columns[8].Caption = "Chỉ số điện mới";
                    gvCTHopDong.Columns[9].Caption = "Đơn Giá Điện";
                    gvCTHopDong.Columns[9].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice3 = gvCTHopDong.Columns[9];
                    colModelPrice3.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice3.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[10].Caption = "Đơn Giá Nước";
                    gvCTHopDong.Columns[10].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice2 = gvCTHopDong.Columns[10];
                    colModelPrice2.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice2.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[11].Caption = "Chỉ số nước cũ";
                    gvCTHopDong.Columns[12].Caption = "Chỉ số nước mới";
                    gvCTHopDong.Columns[13].Caption = "Số điện tiêu thụ";
                    gvCTHopDong.Columns[13].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[14].Caption = "Số Nước tiêu thụ";
                    gvCTHopDong.Columns[14].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[15].Caption = "Tiền Điện";
                    gvCTHopDong.Columns[15].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice7 = gvCTHopDong.Columns[15];
                    colModelPrice7.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice7.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[16].Caption = "Tiền Nước";
                    gvCTHopDong.Columns[16].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice8 = gvCTHopDong.Columns[16];
                    colModelPrice8.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice8.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[17].Caption = "Tiền Internet";
                    GridColumn colModelPrice4 = gvCTHopDong.Columns[17];
                    colModelPrice4.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice4.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[18].Caption = "Tiền Vệ Sinh";
                    GridColumn colModelPrice5 = gvCTHopDong.Columns[18];
                    colModelPrice5.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice5.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[19].Caption = "Tổng Tiền";
                    gvCTHopDong.Columns[19].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice6 = gvCTHopDong.Columns[19];
                    colModelPrice6.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice6.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[20].Caption = "Đã Thanh Toán";
                    gvCTHopDong.Columns[20].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice9 = gvCTHopDong.Columns[20];
                    colModelPrice9.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice9.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[21].Caption = "Còn lại";
                    gvCTHopDong.Columns[21].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice10 = gvCTHopDong.Columns[21];
                    colModelPrice10.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice10.DisplayFormat.FormatString = "n0";
                }
                else if (cbbHopdong.Text == "Tất Cả Hợp Đồng")
                {
                    gcCTHopDong.DataSource = HopdongBUS.Instance.GetAllAllHopDong();
                    gvCTHopDong.Columns[0].Caption = "Mã Số CT Hợp Đồng";
                    gvCTHopDong.Columns[0].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[1].Caption = "Mã Số Hợp Đồng";
                    gvCTHopDong.Columns[1].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[2].Caption = "Tên Phòng";
                    gvCTHopDong.Columns[2].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[3].Caption = "Giá Phòng";
                    gvCTHopDong.Columns[3].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice = gvCTHopDong.Columns[3];
                    colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[4].Caption = "Đặt Cọc";
                    gvCTHopDong.Columns[4].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice1 = gvCTHopDong.Columns[4];
                    colModelPrice1.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice1.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[5].Caption = "Ngày Thuê";
                    gvCTHopDong.Columns[6].Caption = "Ngày Trả";
                    gvCTHopDong.Columns[7].Caption = "Chỉ số điện cũ";
                    gvCTHopDong.Columns[8].Caption = "Chỉ số điện mới";
                    gvCTHopDong.Columns[9].Caption = "Đơn Giá Điện";
                    gvCTHopDong.Columns[9].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice3 = gvCTHopDong.Columns[9];
                    colModelPrice3.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice3.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[10].Caption = "Đơn Giá Nước";
                    gvCTHopDong.Columns[10].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice2 = gvCTHopDong.Columns[10];
                    colModelPrice2.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice2.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[11].Caption = "Chỉ số nước cũ";
                    gvCTHopDong.Columns[12].Caption = "Chỉ số nước mới";
                    gvCTHopDong.Columns[13].Caption = "Số điện tiêu thụ";
                    gvCTHopDong.Columns[13].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[14].Caption = "Số Nước tiêu thụ";
                    gvCTHopDong.Columns[14].OptionsColumn.AllowEdit = false;
                    gvCTHopDong.Columns[15].Caption = "Tiền Điện";
                    gvCTHopDong.Columns[15].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice7 = gvCTHopDong.Columns[15];
                    colModelPrice7.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice7.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[16].Caption = "Tiền Nước";
                    gvCTHopDong.Columns[16].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice8 = gvCTHopDong.Columns[16];
                    colModelPrice8.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice8.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[17].Caption = "Tiền Internet";
                    GridColumn colModelPrice4 = gvCTHopDong.Columns[17];
                    colModelPrice4.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice4.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[18].Caption = "Tiền Vệ Sinh";
                    GridColumn colModelPrice5 = gvCTHopDong.Columns[18];
                    colModelPrice5.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice5.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[19].Caption = "Tổng Tiền";
                    gvCTHopDong.Columns[19].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice6 = gvCTHopDong.Columns[19];
                    colModelPrice6.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice6.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[20].Caption = "Đã Thanh Toán";
                    gvCTHopDong.Columns[20].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice9 = gvCTHopDong.Columns[20];
                    colModelPrice9.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice9.DisplayFormat.FormatString = "n0";
                    gvCTHopDong.Columns[21].Caption = "Còn lại";
                    gvCTHopDong.Columns[21].OptionsColumn.AllowEdit = false;
                    GridColumn colModelPrice10 = gvCTHopDong.Columns[21];
                    colModelPrice10.DisplayFormat.FormatType = FormatType.Numeric;
                    colModelPrice10.DisplayFormat.FormatString = "n0";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void gcCTHopDong_DoubleClick(object sender, EventArgs e)
        {
            txtTenphong.Text = "";
            txtTienPhong.Text = "0";
            txtTienDien.Text = "0";
            txtTienNuoc.Text = "0";
            txtTienmang.Text = "0";
            txtTienVesinh.Text = "0";
            txtTongtiencuathang.Text = "0";
            txtNoconthieu.Text = "0";
            txtTongtiencanthanhtoan.Text = "0";
            if (gvCTHopDong.FocusedRowHandle >= 0)
            {
                btnthanhtoan.Enabled = false;
                btnXoa.Enabled = true;
                btngiahan.Enabled = true;
                btntraphong.Enabled = false;
                txtThanhtoan.Enabled = false;
            }
            string csd_moi = gvCTHopDong.GetRowCellValue(gvCTHopDong.FocusedRowHandle, gvCTHopDong.Columns[8]).ToString();
            string csn_moi = gvCTHopDong.GetRowCellValue(gvCTHopDong.FocusedRowHandle, gvCTHopDong.Columns[12]).ToString();
            if (csn_moi == "")
            {
                XtraMessageBox.Show("bạn cần tính chỉ số nước trước khi thanh toán hợp đồng!");
                return;
            }else if(csd_moi == "")
            {
                XtraMessageBox.Show("bạn cần tính chỉ số điện trước khi thanh toán hợp đồng!");
                return;
            }
            else
            {
                int id = (int)gvCTHopDong.GetRowCellValue(gvCTHopDong.FocusedRowHandle, gvCTHopDong.Columns[1]);
                string tenphong = gvCTHopDong.GetRowCellValue(gvCTHopDong.FocusedRowHandle, gvCTHopDong.Columns[2]).ToString();
                txtTenphong.Text = tenphong;
                LoadHopdong(id);
            }
        }
        private void LoadHopdong(int id)
        {
            try {
                gcHopdong.DataSource = HopdongBUS.Instance.loadHopdong(id);
                gvHopdong.Columns[0].Caption = "Mã Số Hợp Đồng";
                gvHopdong.Columns[0].OptionsColumn.AllowEdit = false;
                gvHopdong.Columns[1].Caption = "Tên Phòng";
                gvHopdong.Columns[1].OptionsColumn.AllowEdit = false;
                gvHopdong.Columns[2].Caption = "Giá Phòng";
                gvHopdong.Columns[2].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice = gvHopdong.Columns[2];
                colModelPrice.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[3].Caption = "Tiền Điện";
                gvHopdong.Columns[3].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice1 = gvHopdong.Columns[3];
                colModelPrice1.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice1.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[4].Caption = "Tiền Nước";
                gvHopdong.Columns[4].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice2 = gvHopdong.Columns[4];
                colModelPrice2.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice2.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[5].Caption = "Tiền Internet";
                gvHopdong.Columns[5].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice3 = gvHopdong.Columns[5];
                colModelPrice3.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice3.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[6].Caption = "Tiền Vệ Sinh";
                gvHopdong.Columns[6].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice4 = gvHopdong.Columns[6];
                colModelPrice4.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice4.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[7].Caption = "Tổng tiền của tháng";
                gvHopdong.Columns[7].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice5 = gvHopdong.Columns[7];
                colModelPrice5.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice5.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[8].Caption = "Số nợ còn thiếu";
                gvHopdong.Columns[8].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice6 = gvHopdong.Columns[8];
                colModelPrice6.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice6.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[9].Caption = "Tổng tiền các tháng";
                gvHopdong.Columns[9].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice7 = gvHopdong.Columns[9];
                colModelPrice7.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice7.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[10].Caption = "Đã trả";
                gvHopdong.Columns[10].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice8 = gvHopdong.Columns[10];
                colModelPrice8.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice8.DisplayFormat.FormatString = "n0";
                gvHopdong.Columns[11].Caption = "Tổng Tiền Phải Trả";
                gvHopdong.Columns[11].OptionsColumn.AllowEdit = false;
                GridColumn colModelPrice9 = gvHopdong.Columns[11];
                colModelPrice9.DisplayFormat.FormatType = FormatType.Numeric;
                colModelPrice9.DisplayFormat.FormatString = "n0";
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show("Error: " + ex);
            }
        }
        private void gvCTHopDong_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            GridView view = sender as GridView;
            UpdateDiennuocmoi(view, e.RowHandle);
        }
        private void UpdateDiennuocmoi(GridView view, int rowHandle)
        {
            string id = view.GetRowCellValue(rowHandle, view.Columns[1]).ToString();
            string csd_moiTemp = view.GetRowCellValue(rowHandle, view.Columns[8]).ToString();
            string csd_cuTemp = view.GetRowCellValue(rowHandle, view.Columns[7]).ToString();
            int csd_moi = int.Parse(csd_moiTemp);
            int csd_cu = int.Parse(csd_cuTemp);
            if (csd_moi < csd_cu)
            {
                XtraMessageBox.Show("Chỉ số điện mới không thể nhỏ hơn chỉ số điện cũ!");
                return;
            }
            string csn_cuTemp = view.GetRowCellValue(rowHandle, view.Columns[11]).ToString();
            string csn_moiTemp = view.GetRowCellValue(rowHandle, view.Columns[12]).ToString();
            int csn_moi = int.Parse(csn_moiTemp);
            int csn_cu = int.Parse(csn_cuTemp);
            if (csn_moi < csn_cu)
            {
                XtraMessageBox.Show("Chỉ số nước mới không thể nhỏ hơn chỉ số nước cũ!");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            CtHopdongDTO khachhang = new CtHopdongDTO(int.Parse(id), csd_moi,csn_moi);
            if (CtHopdongBUS.Instance.UpdateCtHopDong(khachhang))
            {
                CTLoadHopdong();
                SplashScreenManager.CloseForm();
                //Log.WriteLog("update Chỉ số điện nước: ID chi tiết Hợp đồng:" + curThanhtoan.id_cthopdong + "  -> " + id
                //              + ", Chỉ số điện mới:  " + curThanhtoan.csd_moi + "-> " + csd_moi
                //              + ", Chỉ số nước mới:  " + curThanhtoan.csn_moi + "-> " + csn_moi);
                XtraMessageBox.Show("Update chỉ số điện nước mới thành công", "Thông báo!!");
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Update chỉ số điện nước mới thất bại\n Không thể update thông tin hàng hiện hành", "Lỗi");
            }


        }
        private void gvCTHopDong_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTaiLai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CTLoadHopdong();
        }

        private void btnThemHopdong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThemhopdong f = new frmThemhopdong();
            f.ShowDialog();
        }

        private void btnthanhtoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[0]).ToString();
            string thanhtoan = txtThanhtoan.Text.Trim();
            if (thanhtoan == "")
            {
                XtraMessageBox.Show("Số tiền thanh toán Không Hợp lệ");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            
            try
            {
                CtHopdongDTO thanhtoanhd = new CtHopdongDTO(int.Parse(id), int.Parse(thanhtoan));
                if (CtHopdongBUS.Instance.UpdateThanhtoanandgiahan(thanhtoanhd))
                {
                    SplashScreenManager.CloseForm();
                    CTLoadHopdong();
                    //Log.WriteLog("update Chi tiết khách hàng: id hợp đồng:" + curThanhtoan.idhopdong + "  -> " + id
                    //              + ", Số tiền thanh toán:  " + curThanhtoan.dathanhtoan + "-> " + thanhtoan);
                    XtraMessageBox.Show("Thanh toán hợp đồng và gia hạn thành công", "Thông báo!!");
                }
            }catch
            {
                XtraMessageBox.Show("Thanh toán hợp đồng thất bại", "Lỗi");
            } 
            

        }

        private void gcHopdong_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (gvHopdong.FocusedRowHandle >= 0)
                {
                    btnthanhtoan.Enabled = true;
                    btnXoa.Enabled = false;
                    btngiahan.Enabled = false;
                    btntraphong.Enabled = true;
                    txtThanhtoan.Enabled = true;
                }
                string tenphong = gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[1]).ToString();
                int giaphong = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[2]);
                int tiendien = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[3]);
                int tiennuoc = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[4]);
                int tienInternet = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[5]);
                int tienVeSinh = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[6]);
                int tongtiencuathang = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[7]);
                int sonoconthieu = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[8]);
                int tongtienphaitra = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[11]);
                txtTenphong.Text = tenphong;
                txtTienPhong.Text = String.Format("{0:N0}", giaphong);
                txtTienDien.Text = String.Format("{0:N0}", tiendien);
                txtTienNuoc.Text = String.Format("{0:N0}", tiennuoc);
                txtTienmang.Text = String.Format("{0:N0}", tienInternet);
                txtTienVesinh.Text = String.Format("{0:N0}", tienVeSinh);
                txtTongtiencuathang.Text = String.Format("{0:N0}", tongtiencuathang);
                txtNoconthieu.Text = String.Format("{0:N0}", sonoconthieu);
                txtTongtiencanthanhtoan.Text = String.Format("{0:N0}", tongtienphaitra);
            }catch
            {
                XtraMessageBox.Show("Hãy Update điện nước mới!");
            }

        }

        private void txtThanhtoan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtThanhtoan.Text))
            {
                txtConlai.Text = "0";
            }
            else
            {
                int tongtienphaitra = (int)gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[11]);
                int thanhtoan = Convert.ToInt32(txtThanhtoan.Text);
                int kq = tongtienphaitra - thanhtoan;
                txtConlai.Text = String.Format("{0:N0}", kq);
            }
        }

        private void btntraphong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = gvHopdong.GetRowCellValue(gvHopdong.FocusedRowHandle, gvHopdong.Columns[0]).ToString();
            string thanhtoan = txtThanhtoan.Text.Trim();
            string conlai = txtConlai.Text.Trim();
            int conlaiit = int.Parse(conlai.Replace(".",""));
            if (conlaiit > 0)
            {
                XtraMessageBox.Show("Số tiền thanh toán phải bằng với hơn số tiền tổng thanh toán!");
                return;
            }
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            CtHopdongDTO giahanvatp = new CtHopdongDTO(int.Parse(id),int.Parse(thanhtoan));
            if (CtHopdongBUS.Instance.UpdateThanhtoanandtraphong(giahanvatp))
            {
                CTLoadHopdong();
                SplashScreenManager.CloseForm();
                //Log.WriteLog("update Chi tiết khách hàng: id hợp đồng:" + curThanhtoan.idhopdong + "  -> " + id
                //              + ", Số tiền thanh toán:  " + curThanhtoan.dathanhtoan + "-> " + thanhtoan);
                XtraMessageBox.Show("Thanh toán hợp đồng và kết thúc hợp đồng thành công", "Thông báo!!");
            }

        }

        private void cbbHopdong_TextChanged(object sender, EventArgs e)
        {
            CTLoadHopdong();
        }
    }
}