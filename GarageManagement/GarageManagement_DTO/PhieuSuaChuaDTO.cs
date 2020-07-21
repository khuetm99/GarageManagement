using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement.GarageManagement_DTO
{
    class PhieuSuaChuaDTO
    {
        private int idpsc;
        private int carnumber;
        private string detail;
        private int iditem;
        private DateTime? createddate;
        private float dongia;
        private float tiencong;
        private float totalprice;

        public PhieuSuaChuaDTO(int idpsc , int carnumber,  int iditem ,string detail, DateTime? createddate, float dongia, float tiencong, float totalprice)
        {
            this.Idpsc =  idpsc;
            this.Carnumber = carnumber;
            this.Iditem = iditem;
            this.Detail = detail;           
            this.Createddate = createddate;
            this.Dongia = dongia;
            this.Tiencong = tiencong;
            this.Totalprice = totalprice;

        }

        public PhieuSuaChuaDTO(DataRow row)
        {
            this.Idpsc = (int)row["idpsc"];
            this.Carnumber = (int)row["carnumber"];
            this.Iditem = (int)row["iditem"];
            this.Detail = row["detail"].ToString();            
            this.Createddate = (DateTime?)row["createddate"];
            this.Dongia = (float)Convert.ToDouble(row["dongia"].ToString());
            this.Tiencong = (float)Convert.ToDouble(row["tiencong"].ToString());
            this.Totalprice = (float)Convert.ToDouble(row["totalprice"].ToString());
        }

        public int Idpsc { get => idpsc; set => idpsc = value; }
        public int Carnumber { get => carnumber; set => carnumber = value; }
        public string Detail { get => detail; set => detail = value; }
        public int Iditem { get => iditem; set => iditem = value; }
        public DateTime? Createddate { get => createddate; set => createddate = value; }
        public float Dongia { get => dongia; set => dongia = value; }
        public float Tiencong { get => tiencong; set => tiencong = value; }
        public float Totalprice { get => totalprice; set => totalprice = value; }
    }
}
