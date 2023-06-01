using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using QLPhongTro.DAO;
using QLPhongTro.DTO;

namespace QLPhongTro.BUS
{
    class KhutroBUS
    {
        private static KhutroBUS instance;

        public static KhutroBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhutroBUS();
                return KhutroBUS.instance;
            }
        }

        public DataTable GetAllKhuTro()
        {
            try
            {
                return DAO.KhutroDAO.Instance.GetAllKhuTro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




        public bool InsertKhuTro(string TenKhu)
        {
            return DAO.KhutroDAO.Instance.InsertKhuTro(TenKhu);
        }

        public bool UpdateKhuTro(int id, string TenKhu)
        {
            return DAO.KhutroDAO.Instance.UpdateKhuTro(id, TenKhu);
        }

        public bool DeleteKhuTro(int id)
        {
            return DAO.KhutroDAO.Instance.DeleteKhuTro(id);
        }
    }
}
