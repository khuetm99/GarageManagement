using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement.GarageManagement_DTO
{
    class PhieuThuTienDTO
    {
        private int idptt;
        private int idkhachhang;
        private int carnumber;
        private DateTime? createddate;
        private float sotienthu;

        public PhieuThuTienDTO (int idptt , int idkhachhang , int carnumber, DateTime? createddate, float sotienthu)
        {
            Idptt = idptt;
            Idkhachhang = idkhachhang;
            Carnumber = carnumber;
            Createddate = createddate;
            Sotienthu = sotienthu;
        }

        public PhieuThuTienDTO(DataRow row)
        {
            Idptt = (int)row["idptt"];
            Idkhachhang = (int)row["idkhachhang"];
            Carnumber = (int)row["carnumber"];
            Createddate = (DateTime?)row["createddate"];
            Sotienthu = (float)Convert.ToDouble(row["sotienthu"].ToString());
        }

        public int Idptt { get => idptt; set => idptt = value; }
        public int Idkhachhang { get => idkhachhang; set => idkhachhang = value; }
        public int Carnumber { get => carnumber; set => carnumber = value; }
        public DateTime? Createddate { get => createddate; set => createddate = value; }
        public float Sotienthu { get => sotienthu; set => sotienthu = value; }
    }
}
