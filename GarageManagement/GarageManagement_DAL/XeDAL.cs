using GarageManagement.GarageManagement_DTO;
using GarageManagement_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement.GarageManagement_DAL
{
    class XeDAL
    {
        private static XeDAL instance;

        internal static XeDAL Instance
        {
            get
            {
                if (instance == null) instance = new XeDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<XeDTO> GetListXe()
        {
            List<XeDTO> xeList = new List<XeDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.xe");
            foreach (DataRow item in data.Rows)
            {
                XeDTO xe = new XeDTO(item);
                xeList.Add(xe);

            }
            return xeList;
        }

        public XeDTO GetListXeById(int carnumber)
        {
            XeDTO xe = null;
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.xe where carnumber =" + carnumber);
            foreach (DataRow item in data.Rows)
            {
                xe = new XeDTO(item);
                return xe;

            }
            return xe;
        }


        public bool InsertXe(int carnumber, string carbrand, int idKH , string status)
        {
            string query = string.Format("insert dbo.xe (carnumber , carbrand , idkh , status) values ({0} , N'{1}', {2} , N'{3}')", carnumber, carbrand,idKH , status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteXe(int carnumber)
        {
            string query = string.Format("delete dbo.xe where carnumber = {0}", carnumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateXe( string carbrand , int carnumber , int idkh , string status)
        {
            string query = string.Format("update dbo.xe set carbrand = N'{0}' , idkh = {1} , status = N'{2}' where carnumber = {3}", carbrand ,idkh , status, carnumber);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<XeDTO> SearchXe (string text)
        {
            List<XeDTO> xeList = new List<XeDTO>();
            string query = string.Format("select * from dbo.xe where dbo.GetUnsignString(carbrand) like N'%' + dbo.GetUnsignString(N'{0}') + '%'", text);
            query += string.Format(" or carnumber like N'%' + N'{0}' + '%'", text);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                XeDTO xe = new XeDTO(item);
                xeList.Add(xe);
            }

            return xeList;
        }
    }
}
