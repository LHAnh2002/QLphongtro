using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class CtHopdongDAO
    {
        private static CtHopdongDAO instance;

        public static CtHopdongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtHopdongDAO();
                return CtHopdongDAO.instance;
            }
        }
        public bool UpdateCtHopDong(CtHopdongDTO ctHopdong)
        {
            string query = string.Format("USP_UpdateDiennuocmoi @id_hopdong , @csd_Moi , @csn_moi ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { ctHopdong.id_cthopdong ,ctHopdong.csd_moi,ctHopdong.csn_moi });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateThanhtoanandgiahan(CtHopdongDTO ctHopdongthanhtoan)
        {
            string query = string.Format("USP_InsertThanhToanVaGiaHan @id_hopdong , @dathanhtoan ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { ctHopdongthanhtoan.idhopdong,ctHopdongthanhtoan.dathanhtoan});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdateThanhtoanandtraphong(CtHopdongDTO ctHopdongthanhtoan)
        {
            string query = string.Format("USP_UpdateThanhtoanvatraphong @id_hopdong , @sotientra ");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { ctHopdongthanhtoan.idhopdong, ctHopdongthanhtoan.dathanhtoan });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }

    }
}
