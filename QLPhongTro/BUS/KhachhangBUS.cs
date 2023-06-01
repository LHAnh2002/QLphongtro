using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class KhachhangBUS
    {
        private static KhachhangBUS instance;

        public static KhachhangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachhangBUS();
                return KhachhangBUS.instance;
            }
        }
        public DataTable GetAllKhachHang()
        {
            try
            {
                return KhachhangDAO.Instance.GetAllKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAllKhachHang()
        {
            try
            {
                return KhachhangDAO.Instance.GetAllAllKhachHang();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertKhachHang(KhachhangDTO newKhachhang)
        {
            return KhachhangDAO.Instance.InsertKhachHang(newKhachhang);
        }

        public bool UpdateKhachhang(KhachhangDTO khachhang)
        {
            return KhachhangDAO.Instance.UpdateKhachHang(khachhang);
        }

    }
}
