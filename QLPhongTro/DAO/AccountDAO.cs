using QLPhongTro.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPhongTro.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return AccountDAO.instance;
            }
        }
        public bool CheckLogin(AccountDTO account)
        {
            string query = "USP_Login @taikhoan , @matkhau";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] { account.taikhoan, account.matkhau });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }
        public DataTable GetAccountByUserName(string userName)
        {
            string query = "USP_GetAccountByUserName @taikhoan";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new object[] { userName });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdateInformation(AccountDTO accountDTO)
        {
            string query = "USP_UpdateAccount @taikhoan , @tenphongtro , @chuphongtro , @diachiphongtro , @dongiadien , @dongianuoc , @sdt";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { accountDTO.taikhoan, accountDTO.tenchutro, accountDTO.chuphongtro, accountDTO.diachiphongtro, accountDTO.dongiadien, accountDTO.dongianuoc, accountDTO.sodienthoai });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool UpdatePassword(AccountDTO accountDTO)
        {
            string query = "USP_UpdatePassword @taikhoan , @matkhau , @matkhaunew";
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { accountDTO.taikhoan, accountDTO.matkhau,accountDTO.newpass });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
        public bool Insertcauhinh(AccountDTO accountDTO)
        {
            string query = string.Format("USP_Insertcauhinh @taikhoan , @matkhau , @tenphongtro , @chuphongtro , @diachiphongtro , @sdt , @IDtype");
            int result;
            try
            {
                result = DataProvider.Instance.ExecuteNonQuery(query,
                    new object[] { accountDTO.taikhoan,accountDTO.matkhau, accountDTO.tenchutro, accountDTO.chuphongtro, accountDTO.diachiphongtro,  accountDTO.sodienthoai , accountDTO.idtype });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result > 0;
        }
    }
}
