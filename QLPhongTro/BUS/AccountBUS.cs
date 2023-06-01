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
    class AccountBUS
    {
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountBUS();
                return instance;
            }
        }
        public bool CheckLogin(AccountDTO account)
        {
            if (account.taikhoan == "")
                return false;
            if (account.matkhau == "")
                return false;

            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountDTO GetAccountByUserName(string userName)
        {
            DataTable table;
            try
            {
                table = AccountDAO.Instance.GetAccountByUserName(userName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new AccountDTO(table.Rows[0]);
        }
        public bool UpdateInformation(AccountDTO accountDTO)
        {
            try
            {
                return AccountDAO.Instance.UpdateInformation(accountDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool UpdatePassword(AccountDTO accountDTO)
        {
            try
            {
                return AccountDAO.Instance.UpdatePassword(accountDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Insertcauhinh(AccountDTO accountDTO)
        {
            try
            {
                return AccountDAO.Instance.Insertcauhinh(accountDTO);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}