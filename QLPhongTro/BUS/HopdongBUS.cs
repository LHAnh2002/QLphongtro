using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
namespace QLPhongTro.BUS
{
    class HopdongBUS
    {
        private static HopdongBUS instance;

        public static HopdongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HopdongBUS();
                return HopdongBUS.instance;
            }
        }
        public DataTable GetAllHopDong()
        {
            try
            {
                return HopdongDAO.Instance.GetAllHopdong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAllHopDong()
        {
            try
            {
                return HopdongDAO.Instance.GetAllAllHopdong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable loadHopdong(int idhopdong)
        {
            try
            {
                return HopdongDAO.Instance.loadHopdong(idhopdong);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
