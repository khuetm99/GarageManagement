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
    class PhieuThuTienDAL
    {
        private static PhieuThuTienDAL instance;

        internal static PhieuThuTienDAL Instance
        {
            get
            {
                if (instance == null) instance = new PhieuThuTienDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<PhieuThuTienDTO> GetListPhieuThuTien()
        {
            List<PhieuThuTienDTO> phieuthutienList = new List<PhieuThuTienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.phieuthutien");
            foreach (DataRow item in data.Rows)
            {
                PhieuThuTienDTO phieuthutien = new PhieuThuTienDTO(item);
                phieuthutienList.Add(phieuthutien);
            }
            return phieuthutienList;
        }


        public bool InsertPhieuThuTien( int idkhachhang, int carnumber, DateTime? createddate, float sotienthu)
        {
            string query = string.Format("insert dbo.phieuthutien ( idkhachhang, carnumber, createddate, sotienthu ) ");
            query += string.Format("values ( {0} , {1} , N'{2}' , '{3}' ) ", idkhachhang, carnumber, createddate, sotienthu);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdatePhieuThuTien(int idptt, int idkhachhang, int carnumber, DateTime? createddate, float sotienthu)
        {
            string query = string.Format("update dbo.phieuthutien set");
            query += string.Format(" idkhachhang = {0} , carnumber = {1} , createddate = '{2}' , sotienthu = {3} where idptt = {4} ",  idkhachhang, carnumber, createddate, sotienthu , idptt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeletePhieuThuTien(int idptt)
        {
            string query = string.Format("delete dbo.phieuthutien where idptt ={0}", idptt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public DataTable CreateBCDT(DateTime? createdDate)
        {
            List<PhieuThuTienDTO> phieuthutienList = new List<PhieuThuTienDTO>();
            string query = string.Format("exec USP_GetDoanhThuByMonthYear @createdDate ");
            return DataProvider.Instance.ExecuteQuery(query, new object[] { createdDate });
            
        }
        public List<PhieuThuTienDTO> GetDoanhThuByMonthYear(DateTime? createdDate)  //SELECT* FROM account WHERE USERNAME = '" + userName + "'
        {
            List<PhieuThuTienDTO> phieuthutienList = new List<PhieuThuTienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDPTT, IDKHACHHANG, CARNUMBER, SOTIENTHU, CREATEDDATE FROM PHIEUTHUTIEN WHERE MONTH(CREATEDDATE) = MONTH('" + createdDate + "')  AND YEAR(CREATEDDATE) = YEAR('" + createdDate + "')");
            foreach (DataRow item in data.Rows)
            {
                PhieuThuTienDTO phieuthutien = new PhieuThuTienDTO(item);
                phieuthutienList.Add(phieuthutien);
            }
            return phieuthutienList;
        }

        public List<PhieuThuTienDTO> GetBill(int idPTT)  //SELECT* FROM account WHERE USERNAME = '" + userName + "'
        {
            List<PhieuThuTienDTO> phieuthutienList = new List<PhieuThuTienDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT IDPTT, kh.CUSTOMERNAME , ptt.CARNUMBER , SOTIENTHU, ptt.CREATEDDATE FROM dbo.PHIEUTHUTIEN as ptt, dbo.HOSOKHACHHANG as kh WHERE  kh.ID = ptt.IDKHACHHANG  AND IDPTT = " + idPTT + ")");
            foreach (DataRow item in data.Rows)
            {
                PhieuThuTienDTO phieuthutien = new PhieuThuTienDTO(item);
                phieuthutienList.Add(phieuthutien);
            }
            return phieuthutienList;
        }

    }
}
