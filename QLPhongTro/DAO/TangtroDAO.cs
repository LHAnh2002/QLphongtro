using System;
using System.Data;
using QLPhongTro.DTO;

namespace QLPhongTro.DAO
{
    class TangtroDAO
    {
        private static TangtroDAO instance;

        public static TangtroDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TangtroDAO();
                return TangtroDAO.instance;
            }
        }
        public DataTable GetAllTangTro()
        {
            string query = "USP_GetAllTangTro";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertTangTro(TangtroDTO newTangTro)
        {
            string query = string.Format("USP_InsertTang @tentang , @ID_Khu ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newTangTro.TenTang, newTangTro.ID_Khu });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateTangTro(TangtroDTO tangtro)
        {
            string query = string.Format("USP_UpdateTang @ID_Tang , @TenTang , @ID_Khu");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { tangtro.ID_Tang, tangtro.TenTang, tangtro.ID_Khu });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool DeleteTangTro(int ID_Tang)
        {
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery("USP_DeleteTang @ID_Tang", new object[] { ID_Tang });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
