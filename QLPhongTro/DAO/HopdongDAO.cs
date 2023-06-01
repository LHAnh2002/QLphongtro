using System;
using System.Data;

namespace QLPhongTro.DAO
{
    class HopdongDAO
    {
        private static HopdongDAO instance;

        public static HopdongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new HopdongDAO();
                return HopdongDAO.instance;
            }
        }
        public DataTable GetAllHopdong()
        {
            string query = "USP_GetALLDSthuephong"; 
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAllHopdong()
        {
            string query = "USP_GetALLALLDSthuephong";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable loadHopdong(int id_hopdong)
        {

            string query = "USP_GetAllHopdong @id_hopdong";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { id_hopdong });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }
    }
}
