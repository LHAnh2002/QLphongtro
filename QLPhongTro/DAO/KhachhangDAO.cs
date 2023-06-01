using QLPhongTro.DTO;
using System;
using System.Data;

namespace QLPhongTro.DAO
{
    class KhachhangDAO
    {
        private static KhachhangDAO instance;

        public static KhachhangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangDAO();
                return KhachhangDAO.instance;
            }
        }
        public DataTable GetAllKhachHang()
        {
            string query = "USP_GetAllKhachHang";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAllKhachHang()
        {
            string query = "USP_GetAllAllKhachHang";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertKhachHang(KhachhangDTO newKhachhang)
        {
            string query = string.Format("USP_InsertKhachHang  @Ho , @tendem , @ten , @cccd , @sdt , @quequan , @hktt");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newKhachhang.Ho, newKhachhang.TenDem , newKhachhang.Ten, newKhachhang.CCCD, newKhachhang.sdt, newKhachhang.quequan, newKhachhang.hktt });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateKhachHang(KhachhangDTO khachhang)
        {
            string query = string.Format("USP_UpdateKhachHang @id_khachhang , @Ho , @tendem , @ten , @cccd , @sdt , @quequan , @hktt , @trangthai");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] {khachhang.ID_KhachHang, khachhang.Ho, khachhang.TenDem, khachhang.Ten, khachhang.CCCD, khachhang.sdt, khachhang.quequan, khachhang.hktt,khachhang.trangthai });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
