using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GarageManagement_DTO;

namespace GarageManagement_DAL
{
    class KhachHangDAL
    {
        private static KhachHangDAL instance;

        public static KhachHangDAL Instance
        {
            get
            {
                if (instance == null) instance = new KhachHangDAL();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public List<KhachHangDTO>  GetListKhachHang()
        {
            List<KhachHangDTO> khachhangList = new List<KhachHangDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from dbo.hosokhachhang ");
            foreach (DataRow item in data.Rows)
            {
                KhachHangDTO khachhang = new KhachHangDTO(item);
                khachhangList.Add(khachhang);
            }
            return khachhangList;
        }

        public bool InsertKhachHang(string customername, string address , int phone , DateTime? createdate , float debt)
        {
            string query = "insert dbo.hosokhachhang ( customername , address , phone , createddate , debt )";
            query += string.Format(" values (  N'{0}' , N'{1}' , {2} , N'{3}' , {4} )",  customername, address, phone, createdate, debt );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool UpdateKhachHang(string customername, string address, int phone, DateTime? createdate, float debt , int id )
        {
            string query = "update dbo.hosokhachhang set ";
            query += string.Format("  customername = N'{0}' , address = N'{1}' , phone = {2} , createddate = N'{3}' , debt = {4} where id = {5} ", customername,  address, phone, createdate, debt , id );
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool DeleteKhachHang( int id)
        {
            string query = string.Format("delete dbo.hosokhachhang where id = {0} ", id );     
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<KhachHangDTO> SearchKhachHangByNameAndID(string name)
        {
            List<KhachHangDTO> khachhangList = new List<KhachHangDTO>();
            string query = string.Format("select * from dbo.hosokhachhang where dbo.GetUnsignString(customername) like N'%' + dbo.GetUnsignString(N'{0}') + '%'", name);
            query += string.Format(" or id like N'%' + N'{0}' + '%'", name);
                       
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow item in data.Rows)
                {
                    KhachHangDTO khachhang = new KhachHangDTO(item);
                    khachhangList.Add(khachhang);
                }           
        
            return khachhangList;
        }
    }
}
