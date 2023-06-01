using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class themhopdongDAO
    {

        private static themhopdongDAO instance;
        public static themhopdongDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new themhopdongDAO();
                return themhopdongDAO.instance;
            }
        }

        public bool Insertthemchitiethopdong(ThemhopdongDTO newLoaiPhong)
        {
            string query = string.Format("USP_InsertChiTietHopDong @ngaybatdau , @ngayketthuc , @csd_cu , @csn_cu");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newLoaiPhong.ngaybatdau, newLoaiPhong.ngayketthuc, newLoaiPhong.csd_cu,newLoaiPhong.csn_cu});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool Inserthopdong(ThemhopdongDTO newhopdong)
        {
            string query = string.Format("USP_InsertHopdong @id_phong , @datcoc , @tienvesinh , @tieninternet");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { newhopdong.id_phong, newhopdong.dat_coc , newhopdong.tienvesinh,newhopdong.tieninternet});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
