using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement_DTO
{
    class KhachHangDTO
    {
        private int id;
        private string customername;
        private string address;
        private int phone;
        private float debt;
        private DateTime? createddate;

        public KhachHangDTO(int id , string customername,  string address, int phone , float debt, DateTime? createddate)
        {
            this.Id = id;
            this.Customername = customername;
            this.Address = address;
            this.Phone = phone;
            this.Debt = debt;
            this.Createddate = createddate;
        }

        public KhachHangDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Customername = row["CUSTOMERNAME"].ToString();
            this.Address = row["address"].ToString();
            this.Phone= (int)row["phone"];
            this.Createddate = (DateTime?)row["createddate"];
            this.Debt = (float)Convert.ToDouble(row["debt"].ToString());           
        }
        public int Id { get => id; set => id = value; }
        public string Customername { get => customername; set => customername = value; }
        public string Address { get => address; set => address = value; }
        public float Debt { get => debt; set => debt = value; }
        public DateTime? Createddate { get => createddate; set => createddate = value; }
        public int Phone { get => phone; set => phone = value; }
    }
}
