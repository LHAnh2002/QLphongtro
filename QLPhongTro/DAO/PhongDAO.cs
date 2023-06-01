using QLPhongTro.DTO;
using System;
using System.Data;

namespace QLPhongTro.DAO
{
    class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongDAO();
                return PhongDAO.instance;
            }
        }
        public DataTable GetAllPhong() { 
            string query = "USP_GetAllPhong";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPhongTrong()
        {
            string query = "USP_GetAllPhongTrong";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPhongHopdong()
        {
            string query = "USP_GetAllPhongHopdong";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertPhong(PhongDTO newPhong)
        {
            string query = string.Format("USP_InsertPhong @id_loaiphong , @ID_tang , @tenphong");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newPhong.ID_Loaiphong, newPhong.ID_Tang,newPhong.TenPhong});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdatePhong(PhongDTO phong)
        {
            string query = string.Format("USP_UpdatePhong @id_phong , @id_loaiphong , @ID_tang , @tenphong ,  @trangthai");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] {phong.ID_Phong, phong.ID_Loaiphong, phong.ID_Tang, phong.TenPhong, phong.TrangThai });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool DeletePhong(int idphong)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("USP_DeletePhong @ID_Phong", new object[] { idphong });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
