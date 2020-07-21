namespace GarageManagement.GarageManagement_GUI
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.USP_GetTonKhoByMonthBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GARAGEMANAGEMENTDataSet_Tonkho = new GarageManagement.GARAGEMANAGEMENTDataSet_Tonkho();
            this.rptTonkho = new Microsoft.Reporting.WinForms.ReportViewer();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpkTonkho = new System.Windows.Forms.DateTimePicker();
            this.btnCreateRPDT = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.USP_GetTonKhoByMonthTableAdapter = new GarageManagement.GARAGEMANAGEMENTDataSet_TonkhoTableAdapters.USP_GetTonKhoByMonthTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTonKhoByMonthBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GARAGEMANAGEMENTDataSet_Tonkho)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_GetTonKhoByMonthBindingSource
            // 
            this.USP_GetTonKhoByMonthBindingSource.DataMember = "USP_GetTonKhoByMonth";
            this.USP_GetTonKhoByMonthBindingSource.DataSource = this.GARAGEMANAGEMENTDataSet_Tonkho;
            // 
            // GARAGEMANAGEMENTDataSet_Tonkho
            // 
            this.GARAGEMANAGEMENTDataSet_Tonkho.DataSetName = "GARAGEMANAGEMENTDataSet_Tonkho";
            this.GARAGEMANAGEMENTDataSet_Tonkho.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptTonkho
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetTonKhoByMonthBindingSource;
            this.rptTonkho.LocalReport.DataSources.Add(reportDataSource1);
            this.rptTonkho.LocalReport.ReportEmbeddedResource = "GarageManagement.rptTonKho.rdlc";
            this.rptTonkho.Location = new System.Drawing.Point(5, 228);
            this.rptTonkho.Name = "rptTonkho";
            this.rptTonkho.ServerReport.BearerToken = null;
            this.rptTonkho.Size = new System.Drawing.Size(1900, 608);
            this.rptTonkho.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Open Sans Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(604, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(434, 45);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "BÁO CÁO TỒN KHO THÁNG";
            // 
            // dtpkTonkho
            // 
            this.dtpkTonkho.CalendarFont = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkTonkho.Location = new System.Drawing.Point(89, 31);
            this.dtpkTonkho.Name = "dtpkTonkho";
            this.dtpkTonkho.Size = new System.Drawing.Size(200, 23);
            this.dtpkTonkho.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.btnCreateRPDT);
            this.groupBox1.Controls.Add(this.dtpkTonkho);
            this.groupBox1.Location = new System.Drawing.Point(659, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 139);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê tồn kho";
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
            // USP_GetTonKhoByMonthTableAdapter
            // 
            this.USP_GetTonKhoByMonthTableAdapter.ClearBeforeFill = true;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1910, 1045);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.rptTonkho);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmTonKho";
            this.Text = "Báo cáo tồn kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetTonKhoByMonthBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GARAGEMANAGEMENTDataSet_Tonkho)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptTonkho;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpkTonkho;
        private DevExpress.XtraEditors.SimpleButton btnCreateRPDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private GARAGEMANAGEMENTDataSet_Tonkho GARAGEMANAGEMENTDataSet_Tonkho;
        private System.Windows.Forms.BindingSource USP_GetTonKhoByMonthBindingSource;
        private GARAGEMANAGEMENTDataSet_TonkhoTableAdapters.USP_GetTonKhoByMonthTableAdapter USP_GetTonKhoByMonthTableAdapter;
    }
}