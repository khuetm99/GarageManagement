namespace GarageManagement.GarageManagement_GUI
{
    partial class frmDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.USP_GetDoanhThuByMonthYearBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GARAGEMANAGEMENTDataSet_Doanhthu = new GarageManagement.GARAGEMANAGEMENTDataSet_Doanhthu();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnCreateRPDT = new DevExpress.XtraEditors.SimpleButton();
            this.dtpkDoanhthu = new System.Windows.Forms.DateTimePicker();
            this.rptDoanhthu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetDoanhThuByMonthYearTableAdapter = new GarageManagement.GARAGEMANAGEMENTDataSet_DoanhthuTableAdapters.USP_GetDoanhThuByMonthYearTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetDoanhThuByMonthYearBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GARAGEMANAGEMENTDataSet_Doanhthu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_GetDoanhThuByMonthYearBindingSource
            // 
            this.USP_GetDoanhThuByMonthYearBindingSource.DataMember = "USP_GetDoanhThuByMonthYear";
            this.USP_GetDoanhThuByMonthYearBindingSource.DataSource = this.GARAGEMANAGEMENTDataSet_Doanhthu;
            // 
            // GARAGEMANAGEMENTDataSet_Doanhthu
            // 
            this.GARAGEMANAGEMENTDataSet_Doanhthu.DataSetName = "GARAGEMANAGEMENTDataSet_Doanhthu";
            this.GARAGEMANAGEMENTDataSet_Doanhthu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(587, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(505, 38);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "BÁO CÁO DOANH THU THÁNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.btnCreateRPDT);
            this.groupBox1.Controls.Add(this.dtpkDoanhthu);
            this.groupBox1.Location = new System.Drawing.Point(659, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 139);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê doanh thu";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 21);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Chọn ngày";
            // 
            // btnCreateRPDT
            // 
            this.btnCreateRPDT.Location = new System.Drawing.Point(89, 88);
            this.btnCreateRPDT.Name = "btnCreateRPDT";
            this.btnCreateRPDT.Size = new System.Drawing.Size(151, 45);
            this.btnCreateRPDT.TabIndex = 3;
            this.btnCreateRPDT.Text = "Tạo báo cáo";
            this.btnCreateRPDT.Click += new System.EventHandler(this.btnCreateRPDT_Click);
            // 
            // dtpkDoanhthu
            // 
            this.dtpkDoanhthu.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDoanhthu.Location = new System.Drawing.Point(89, 31);
            this.dtpkDoanhthu.Name = "dtpkDoanhthu";
            this.dtpkDoanhthu.Size = new System.Drawing.Size(200, 23);
            this.dtpkDoanhthu.TabIndex = 2;
            // 
            // rptDoanhthu
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetDoanhThuByMonthYearBindingSource;
            this.rptDoanhthu.LocalReport.DataSources.Add(reportDataSource1);
            this.rptDoanhthu.LocalReport.ReportEmbeddedResource = "GarageManagement.rptDoanhThu.rdlc";
            this.rptDoanhthu.Location = new System.Drawing.Point(5, 228);
            this.rptDoanhthu.Name = "rptDoanhthu";
            this.rptDoanhthu.ServerReport.BearerToken = null;
            this.rptDoanhthu.Size = new System.Drawing.Size(1900, 608);
            this.rptDoanhthu.TabIndex = 6;
            // 
            // USP_GetDoanhThuByMonthYearTableAdapter
            // 
            this.USP_GetDoanhThuByMonthYearTableAdapter.ClearBeforeFill = true;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1045);
            this.Controls.Add(this.rptDoanhthu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoanhThu";
            this.Text = "Báo cáo doanh thu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetDoanhThuByMonthYearBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GARAGEMANAGEMENTDataSet_Doanhthu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnCreateRPDT;
        private System.Windows.Forms.DateTimePicker dtpkDoanhthu;
        private Microsoft.Reporting.WinForms.ReportViewer rptDoanhthu;
        private GARAGEMANAGEMENTDataSet_DoanhthuTableAdapters.USP_GetDoanhThuByMonthYearTableAdapter USP_GetDoanhThuByMonthYearTableAdapter;
        private System.Windows.Forms.BindingSource USP_GetDoanhThuByMonthYearBindingSource;
        private GARAGEMANAGEMENTDataSet_Doanhthu GARAGEMANAGEMENTDataSet_Doanhthu;
    }
}