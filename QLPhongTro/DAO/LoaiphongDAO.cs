using DevExpress.XtraEditors;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class LoaiphongDAO
    {
        private static LoaiphongDAO instance;
        public static LoaiphongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiphongDAO();
                return LoaiphongDAO.instance;
            }
        }
        public DataTable GetAllLoaiPhong()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllLoaiPhong");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertLoaiPhong(LoaiphongDTO newLoaiPhong)
        {
            string query = string.Format("USP_InsertLoaiPhong @LoaiPhong , @DonGia ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newLoaiPhong.LoaiPhong, newLoaiPhong.DonGia });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateLoaiPhong(LoaiphongDTO newLoaiPhong)
        {
            string query = string.Format("USP_UpdateLoaiPhong @ID_Loaiphong , @LoaiPhong , @Dongia ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newLoaiPhong.ID_LoaiPhong, newLoaiPhong.LoaiPhong, newLoaiPhong.DonGia});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }


        public bool DeleteLoaiPhong(int id)
        {
            string query = string.Format("USP_DeleteLoaiPhong @ID_loaiphong");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
