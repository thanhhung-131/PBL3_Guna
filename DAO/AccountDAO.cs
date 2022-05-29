﻿using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO _instance;
        public static AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountDAO();
                return _instance;
            }
        }

        public Object CheckLogin(AccountDTO account)
        {
            string query = "USP_AuthoLogin @UserName , @PassWord";
            try
            {
                return DataProvider.Instance.ExecuteScalar(query, new Object[] { account.UserName, account.Password });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAccount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllAccount");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAccountByUserName(string UserName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new Object[] {UserName});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddAccountDAO(AccountDTO account)
        {
            string query = "insert into Account values( @UserName , @DisplayName , @PassWord , 1, @IDStaff )";
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { account.UserName,account.DisplayName, account.Password, account.IDStaff });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public void DeleteAccountDAO(int IDStaff)
        {
            string query = "delete from Account where IDStaff =" + IDStaff;
            try
            {
                DataProvider.Instance.ExecuteNonQuery(query, new Object[] { IDStaff });
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }



    }
}
