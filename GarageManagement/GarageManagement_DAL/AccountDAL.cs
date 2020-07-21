using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using GarageManagement_DTO;


namespace GarageManagement_DAL
{
    public class AccountDAL
    {   
        private static AccountDAL instance;

        internal static AccountDAL Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }
        private AccountDAL() { }
        public bool Login(string userName, string passWord)
        {
            

            string query = "USP_Login @userName , @passWord";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
        public AccountDTO GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM account WHERE USERNAME = '" + userName + "'");
            foreach(DataRow item in data.Rows)
            {           
                return new AccountDTO(item);
            }
            return null;
        }

        public bool UpdateAccount(string username, string displayname, string pass, string newpass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @username , @displayname , @password , @newpassword ", new object[] { username, displayname, pass, newpass });
            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("select username, displayname, accesslevel from dbo.account");
        }


        public bool InsertAccount(string username, string displayname, int accesslevel)
        {
            string query = string.Format("insert dbo.account (username, displayname, accesslevel) values( N'{0}' , N'{1}' , {2})", username, displayname, accesslevel);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateAccount(string username, string displayname, int accesslevel)
        {
            string query = string.Format("update dbo.account set displayname = N'{1}' , accesslevel ={2} where username = N'{0}' ", username, displayname, accesslevel);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("delete dbo.account  where username = N'{0}' ", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ResetPassword(string username)
        {
            string query = string.Format("update dbo.account set password = N'0' where username = N'{0}' ", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}

