using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageManagement.GarageManagement_DTO
{
    class XeDTO
    {
        private int user;
        private int carnumber;
        private string carbrand;
        private int idKH;
        private string status;

        public XeDTO(int carnumber, string carbrand , int idKH, string status)
        {
            this.Carnumber = carnumber;
            this.Carbrand = carbrand;
            this.IdKH = idKH;
            this.Status = status;
        }

        public XeDTO(DataRow row)
        {
            this.Carnumber = (int)row["carnumber"];
            this.Carbrand = row["carbrand"].ToString();
            this.IdKH = (int)row["idKH"];
            this.Status = row["status"].ToString();
        }

        public int Carnumber { get => carnumber; set => carnumber = value; }
        public string Carbrand { get => carbrand; set => carbrand = value; }
        public int IdKH { get => idKH; set => idKH = value; }
        public string Status { get => status; set => status = value; }

    }
}
