using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class KhutroDAO
    {
        private static KhutroDAO instance;
        public static KhutroDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhutroDAO();
                return instance;
            }
        }
        public DataTable GetAllKhuTro()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllKhutro");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public bool InsertKhuTro(string TenKhu)
        {
            string query = "USP_InsertKhuTro @TenKhu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { TenKhu });
            return result > 0;
        }
        public bool UpdateKhuTro(int id, string TenKhu)
        {
            string query = "USP_UpdateKhuTro @ID_khutro , @Tenkhu";
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, TenKhu });
            return result > 0;
        }

        public bool DeleteKhuTro(int id)
        {
            string query = string.Format("USP_DeleteKhuTro @ID_khutro");
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
            return result > 0;
        }
    }
}
