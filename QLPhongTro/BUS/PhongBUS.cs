using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.BUS
{
    class PhongBUS
    {
        private static PhongBUS instance;

        public static PhongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new PhongBUS();
                return PhongBUS.instance;
            }
        }
        public DataTable GetAllPhong()
        {
            try
            {
                return PhongDAO.Instance.GetAllPhong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPhongTrong()
        {
            try
            {
                return PhongDAO.Instance.GetAllPhongTrong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllPhongHopdong()
        {
            try
            {
                return PhongDAO.Instance.GetAllPhongHopdong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertPhong(PhongDTO newPhong)
        {
            return PhongDAO.Instance.InsertPhong(newPhong);
        }
        public bool UpdatePhong(PhongDTO phong)
        {
            return PhongDAO.Instance.UpdatePhong(phong);
        }
        public bool DeletePhong(int ID)
        {
            return PhongDAO.Instance.DeletePhong(ID);
        }
    }
}
