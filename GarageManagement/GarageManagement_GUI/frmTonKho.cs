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
    public partial class frmTonKho : DevExpress.XtraEditors.XtraForm
    {
        public frmTonKho()
        {
            InitializeComponent();
        }

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'GARAGEMANAGEMENTDataSet_Tonkho.USP_GetTonKhoByMonth' table. You can move, or remove it, as needed.

            this.rptTonkho.RefreshReport();
        }

        private void btnCreateRPDT_Click(object sender, EventArgs e)
        {
            DateTime? createddate = dtpkTonkho.Value;

            List<VatLieuDTO> pbcDoanhthu = VatLieuDAL.Instance.GetTonKhoByMonth(createddate);
            this.USP_GetTonKhoByMonthTableAdapter.Fill(this.GARAGEMANAGEMENTDataSet_Tonkho.USP_GetTonKhoByMonth, dtpkTonkho.Value);
            this.rptTonkho.RefreshReport();
        }
    }
}