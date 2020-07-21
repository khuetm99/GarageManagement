using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement_DTO
{
    public class AccountDTO
    {
        private string displayname;
        public AccountDTO( string userName, int accesslevel, string password , string displayname)
        {
            
            this.UserName = userName;
            this.Password = password;
            this.AccessLevel = accesslevel;
            this.Displayname = displayname;
        }
        public AccountDTO(DataRow row)
        {       
            this.UserName = row["userName"].ToString();
            this.Displayname = row["displayname"].ToString();
            this.Password = row["password"].ToString();
            this.AccessLevel = (int)row["accesslevel"];
        }


        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }


        private string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }


        private int access_level;
        public int AccessLevel
        {
            get { return access_level; }
            set { access_level = value; }
        }

        public string Displayname { get => displayname; set => displayname = value; }
    }
}
