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
    class PhieuSuaChuaDAL
    {
        private static PhieuSuaChuaDAL instance;

        internal static PhieuSuaChuaDAL Instance
        {
            get
            {
                if (instance == null) instance = new PhieuSuaChuaDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<PhieuSuaChuaDTO> GetListPhieuSuaChua()
        {
            List<PhieuSuaChuaDTO> phieusuachuaList = new List<PhieuSuaChuaDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.phieusuachua");
            foreach (DataRow item in data.Rows)
            {
                PhieuSuaChuaDTO phieusuachua = new PhieuSuaChuaDTO(item);
                phieusuachuaList.Add(phieusuachua);
            }
            return phieusuachuaList;
        }

        public bool InsertPhieuSuaChua( int carnumber, int iditem, string detail, DateTime? createddate, float dongia, float tiencong, float totalprice)
        {
            string query = string.Format("insert dbo.phieusuachua ( carnumber , iditem , detail , createddate , dongia , tiencong , totalprice ) ");
            query += string.Format("values ( {0} , {1} , N'{2}' , '{3}' , {4}, {5}, {6}) ", carnumber, iditem, detail, createddate, dongia, tiencong, totalprice);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePhieuSuaChua(int idpsc, int carnumber, int iditem, string detail, DateTime? createddate, float dongia, float tiencong, float totalprice)
        {
            string query = string.Format("update dbo.phieusuachua set");
            query += string.Format(" carnumber = {0} , iditem = {1} , detail = N'{2}' , createddate = '{3}' , dongia = {4} , tiencong = {5}, totalprice ={6} where idpsc = {7} ",  carnumber, iditem, detail, createddate, dongia, tiencong, totalprice, idpsc);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieuSuaChua(int idpsc)
        {
            string query = string.Format("delete dbo.phieusuachua where idpsc ={0}" ,idpsc );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
