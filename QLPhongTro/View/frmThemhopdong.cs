using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;
using QLPhongTro.BUS;
using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;

namespace QLPhongTro.View
{
    public partial class frmThemhopdong : DevExpress.XtraEditors.XtraForm
    {
        public frmThemhopdong()
        {
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            InitializeComponent();
            loadhopdong();
            cbTienVesinh.Checked = true;
            SplashScreenManager.CloseForm();
        }
        private List<khachhang> lstKH;
        private void loadhopdong()
        {
            lstKH = new List<khachhang>();
            lvPhong.Properties.DataSource = PhongBUS.Instance.GetAllPhongHopdong();
            lvPhong.Properties.DisplayMember = "Tenphong";
            lvPhong.Properties.ValueMember = "ID_Phong";
            lvPhong.Properties.NullText = "-- Chọn danh mục --";
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //khởi tạo hợp đồng
            string id_phong = lvPhong.EditValue.ToString().Trim();
            string datcoc = txtDatCoc.Text.Trim();
            string Tienvesinh = cbTienVesinh.Text.Trim();
            string TienInternet = cbTienInternet.Text.Trim();
            SplashScreenManager.ShowForm(typeof(WaitForm1));
            ThemhopdongDTO newloaiphong = new ThemhopdongDTO(int.Parse(id_phong),int.Parse(datcoc), int.Parse(Tienvesinh), int.Parse(TienInternet));
            if (themhopdongBUS.Instance.Inserthopdong(newloaiphong))
            {
                SplashScreenManager.CloseForm();
                //dateBatdau.Text = "";
                //dateKetthuc.Text = "";
                //txtDatCoc.Text = "";
                //txtCSD.Text = "";
                //txtCSN.Text = "";
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Loại Hợp đồng thất bại", "Lỗi");
            }
            //khởi tạo chi tiết hợp đồng
            string ngaybatdau = dateBatdau.Text.Trim();
            string ngayketthuc = dateKetthuc.Text.Trim();
            string csd_cu = txtCSD.Text.Trim();
            string csn_cu = txtCSN.Text.Trim();

            ThemhopdongDTO newchitietloaiphong = new ThemhopdongDTO(DateTime.Parse(ngaybatdau), DateTime.Parse(ngayketthuc),int.Parse(csd_cu),int.Parse(csn_cu));
            if (themhopdongBUS.Instance.Insertchitiethopdong(newchitietloaiphong))
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                SplashScreenManager.CloseForm();
            }
            else
            {
                SplashScreenManager.CloseForm();
                XtraMessageBox.Show("Thêm Loại Hợp đồng thất bại", "Lỗi");
            }

            //lưu trữ thông tin khách hàng
            foreach (var kh in lstKH)
            {
                string ho = kh.Ho;
                string tendem = kh.TenDem;
                string ten = kh.Ten;
                string cccd = kh.CCCD;
                string sdt = kh.Sdt;
                string quequan = kh.Quequan;
                string hktt = kh.Hktt;
                KhachhangDTO khachhang = new KhachhangDTO( ho, tendem,  ten, cccd, sdt, quequan, hktt);
                if (KhachhangBUS.Instance.InsertKhachHang(khachhang))
                {
                    SplashScreenManager.ShowForm(typeof(WaitForm1));
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    SplashScreenManager.CloseForm();
                    XtraMessageBox.Show("Thêm khách hàng mới thất bại", "Lỗi");
                }
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            var ho = txtHo.Text.Trim();
            var tendem = txtTenDem.Text.Trim();
            var ten = txtTen.Text.Trim();
            var cccd = txtCCCD.Text.Trim();
            var sdt = txtSDT.Text.Trim();
            var quequan = txtQueQuan.Text.Trim();
            var hktt = txtHKTT.Text.Trim();
            if (ten == "" || ho == "")
            {
                XtraMessageBox.Show("Vui lòng nhập đầy đủ họ tên khách hàng");
                return;
            }
            if (cccd == "")
            {
                XtraMessageBox.Show("CCCD không hợp lệ");
                return;
            }
            if (sdt == "")
            {
                XtraMessageBox.Show("Số điện thoại không hợp lệ");
                return;
            }
            if (quequan == "")
            {
                XtraMessageBox.Show("Quê Quán không hợp lệ");
                return;
            }
            if (hktt == "")
            {
                XtraMessageBox.Show("HKTT không hợp lệ");
                return;
            }
            lstKH.Add(new khachhang()
            {
                Ho = ho,
                TenDem = tendem,
                Ten = ten,
                CCCD = cccd,
                Sdt = sdt,
                Quequan = quequan,
                Hktt=hktt
            }) ;
            gcHopdong.DataSource = null;
            gcHopdong.DataSource = lstKH;
            txtHo.Text = txtTenDem.Text = txtTen.Text = txtCCCD.Text = txtSDT.Text = txtQueQuan.Text = txtHKTT.Text = null;
            txtHo.Select();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dateBatdau_TextChanged(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Parse(dateBatdau.Text).AddDays(30);
            string date = dateTime.ToString("dd/MM/yyyy");
            dateKetthuc.Text = date;
        }
    }
}