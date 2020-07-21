using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GarageManagement.GarageManagement_DTO;
using GarageManagement.GarageManagement_DAL;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmDoanhThu : DevExpress.XtraEditors.XtraForm
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }

        private void btnCreateRPDT_Click(object sender, EventArgs e)
        {
            DateTime? createddate = dtpkDoanhthu.Value;

            List<PhieuThuTienDTO> pbcDoanhthu = PhieuThuTienDAL.Instance.GetDoanhThuByMonthYear(createddate);

            this.USP_GetDoanhThuByMonthYearTableAdapter.Fill(this.GARAGEMANAGEMENTDataSet_Doanhthu.USP_GetDoanhThuByMonthYear, dtpkDoanhthu.Value);
            this.rptDoanhthu.RefreshReport();
        }

        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GARAGEMANAGEMENTDataSet_Doanhthu.USP_GetDoanhThuByMonthYear' table. You can move, or remove it, as needed.

            this.rptDoanhthu.RefreshReport();
        }
    }
}