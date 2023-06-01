using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.BUS
{
    class CtHopdongBUS
    {
        private static CtHopdongBUS instance;

        public static CtHopdongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CtHopdongBUS();
                return CtHopdongBUS.instance;
            }
        }
        public bool UpdateThanhtoanandgiahan(CtHopdongDTO tthopdong)
        {
            return CtHopdongDAO.Instance.UpdateThanhtoanandgiahan(tthopdong);
        }
        public bool UpdateThanhtoanandtraphong(CtHopdongDTO tthopdong)
        {
            return CtHopdongDAO.Instance.UpdateThanhtoanandtraphong(tthopdong);
        }
        public bool UpdateCtHopDong(CtHopdongDTO tthopdong)
        {
            return CtHopdongDAO.Instance.UpdateCtHopDong(tthopdong);
        }
    }
    
}
