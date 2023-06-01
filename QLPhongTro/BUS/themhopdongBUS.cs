using QLPhongTro.DAO;
using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.BUS
{
    class themhopdongBUS
    {
        private static themhopdongBUS instance;

        public static themhopdongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new themhopdongBUS();
                return themhopdongBUS.instance;
            }
        }
        public bool Insertchitiethopdong(ThemhopdongDTO newloaiphong)
        {
            return themhopdongDAO.Instance.Insertthemchitiethopdong(newloaiphong);
        }
        public bool Inserthopdong(ThemhopdongDTO newloaiphong)
        {
            return themhopdongDAO.Instance.Inserthopdong(newloaiphong);
        }
    }
}
