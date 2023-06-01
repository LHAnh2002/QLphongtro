using System;
using System.Data;
using QLPhongTro.DAO;
using QLPhongTro.DTO;

namespace QLPhongTro.BUS
{
    class TangtroBUS
    {
        private static TangtroBUS instance;

        public static TangtroBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TangtroBUS();
                return TangtroBUS.instance;
            }
        }
        public DataTable GetAllTangTro()
        {
            try
            {
                return TangtroDAO.Instance.GetAllTangTro();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool InsertKhuTro(TangtroDTO newtangtro)
        {
            return TangtroDAO.Instance.InsertTangTro(newtangtro);
        }

        public bool UpdateKhuTro(TangtroDTO tangtro)
        {
            return TangtroDAO.Instance.UpdateTangTro(tangtro);
        }

        public bool DeleteKhuTro(int ID)
        {
            return TangtroDAO.Instance.DeleteTangTro(ID);
        }
    }
}
