using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using QLPhongTro.DAO;
using QLPhongTro.DTO;

namespace QLPhongTro.BUS
{
    class LoaiphongBUS
    {
        private static LoaiphongBUS instance;

        public static LoaiphongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiphongBUS();
                return LoaiphongBUS.instance;
            }
        }

        public DataTable GetAllLoaiPhong()
        {
            try
            {
                return DAO.LoaiphongDAO.Instance.GetAllLoaiPhong();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool InsertLoaiPhong(LoaiphongDTO newloaiphong)
        {
            return LoaiphongDAO.Instance.InsertLoaiPhong(newloaiphong);
        }


        
        public bool UpdateLoaiPhong(LoaiphongDTO newloaiphong)
        {
           return LoaiphongDAO.Instance.UpdateLoaiPhong(newloaiphong);
        }

        public bool DeleteLoaiPhong(int id)
        {
           return LoaiphongDAO.Instance.DeleteLoaiPhong(id);
        }
    }
}
