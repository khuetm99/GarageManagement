namespace GarageManagement.GarageManagement_GUI
{
    partial class frmPTT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPTT));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtXe_PTT = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaPhieuThuTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaPhieuThuTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemPhieuThuTien = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgayTao_PTT = new System.Windows.Forms.DateTimePicker();
            this.txtSoTienThu = new DevExpress.XtraEditors.TextEdit();
            this.txtBienSo_PTT = new DevExpress.XtraEditors.TextEdit();
            this.txtMaKH_PTT = new DevExpress.XtraEditors.TextEdit();
            this.txtIDPTT = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dgvXe_PTT = new System.Windows.Forms.DataGridView();
            this.dgvPTT = new System.Windows.Forms.DataGridView();
            this.btnXemPhieuThuTien = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKH_PTT = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtXe_PTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBienSo_PTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH_PTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPTT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe_PTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTT)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(250, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(115, 18);
            this.labelControl8.TabIndex = 20;
            this.labelControl8.Text = "Tìm khách hàng";
            // 
            // txtXe_PTT
            // 
            this.txtXe_PTT.EditValue = "";
            this.txtXe_PTT.Location = new System.Drawing.Point(377, 16);
            this.txtXe_PTT.Name = "txtXe_PTT";
            this.txtXe_PTT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXe_PTT.Properties.Appearance.Options.UseFont = true;
            this.txtXe_PTT.Size = new System.Drawing.Size(390, 28);
            this.txtXe_PTT.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.btnXoaPhieuThuTien);
            this.groupControl1.Controls.Add(this.btnSuaPhieuThuTien);
            this.groupControl1.Controls.Add(this.btnThemPhieuThuTien);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtpNgayTao_PTT);
            this.groupControl1.Controls.Add(this.txtSoTienThu);
            this.groupControl1.Controls.Add(this.txtBienSo_PTT);
            this.groupControl1.Controls.Add(this.txtMaKH_PTT);
            this.groupControl1.Controls.Add(this.txtIDPTT);
            this.groupControl1.Location = new System.Drawing.Point(12, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 505);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Điền thông tin khách hàng";
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(297, 295);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(66, 40);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnXoaPhieuThuTien
            // 
            this.btnXoaPhieuThuTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaPhieuThuTien.ImageOptions.Image")));
            this.btnXoaPhieuThuTien.Location = new System.Drawing.Point(170, 440);
            this.btnXoaPhieuThuTien.Name = "btnXoaPhieuThuTien";
            this.btnXoaPhieuThuTien.Size = new System.Drawing.Size(100, 40);
            this.btnXoaPhieuThuTien.TabIndex = 8;
            this.btnXoaPhieuThuTien.Text = "Xoá";
            this.btnXoaPhieuThuTien.Click += new System.EventHandler(this.btnXoaPhieuThuTien_Click);
            // 
            // btnSuaPhieuThuTien
            // 
            this.btnSuaPhieuThuTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaPhieuThuTien.ImageOptions.Image")));
            this.btnSuaPhieuThuTien.Location = new System.Drawing.Point(310, 440);
            this.btnSuaPhieuThuTien.Name = "btnSuaPhieuThuTien";
            this.btnSuaPhieuThuTien.Size = new System.Drawing.Size(100, 40);
            this.btnSuaPhieuThuTien.TabIndex = 9;
            this.btnSuaPhieuThuTien.Text = "Sửa";
            this.btnSuaPhieuThuTien.Click += new System.EventHandler(this.btnSuaPhieuThuTien_Click);
            // 
            // btnThemPhieuThuTien
            // 
            this.btnThemPhieuThuTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemPhieuThuTien.ImageOptions.Image")));
            this.btnThemPhieuThuTien.Location = new System.Drawing.Point(30, 440);
            this.btnThemPhieuThuTien.Name = "btnThemPhieuThuTien";
            this.btnThemPhieuThuTien.Size = new System.Drawing.Size(100, 40);
            this.btnThemPhieuThuTien.TabIndex = 7;
            this.btnThemPhieuThuTien.Text = "Tạo";
            this.btnThemPhieuThuTien.Click += new System.EventHandler(this.btnThemPhieuThuTien_Click);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(15, 245);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(81, 18);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Số tiền thu";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 197);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Ngày tạo";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Biển số xe";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(107, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "ID khách hàng";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ID phiếu";
            // 
            // dtpNgayTao_PTT
            // 
            this.dtpNgayTao_PTT.Location = new System.Drawing.Point(133, 195);
            this.dtpNgayTao_PTT.Name = "dtpNgayTao_PTT";
            this.dtpNgayTao_PTT.Size = new System.Drawing.Size(230, 23);
            this.dtpNgayTao_PTT.TabIndex = 5;
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.Location = new System.Drawing.Point(133, 245);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(230, 22);
            this.txtSoTienThu.TabIndex = 6;
            // 
            // txtBienSo_PTT
            // 
            this.txtBienSo_PTT.Location = new System.Drawing.Point(133, 145);
            this.txtBienSo_PTT.Name = "txtBienSo_PTT";
            this.txtBienSo_PTT.Size = new System.Drawing.Size(230, 22);
            this.txtBienSo_PTT.TabIndex = 4;
            // 
            // txtMaKH_PTT
            // 
            this.txtMaKH_PTT.Location = new System.Drawing.Point(133, 95);
            this.txtMaKH_PTT.Name = "txtMaKH_PTT";
            this.txtMaKH_PTT.Size = new System.Drawing.Size(230, 22);
            this.txtMaKH_PTT.TabIndex = 3;
            // 
            // txtIDPTT
            // 
            this.txtIDPTT.Location = new System.Drawing.Point(133, 45);
            this.txtIDPTT.Name = "txtIDPTT";
            this.txtIDPTT.Properties.ReadOnly = true;
            this.txtIDPTT.Size = new System.Drawing.Size(230, 22);
            this.txtIDPTT.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(947, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(304, 24);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Thông tin xe và phiếu thu tiền";
            // 
            // dgvXe_PTT
            // 
            this.dgvXe_PTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe_PTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe_PTT.Location = new System.Drawing.Point(474, 144);
            this.dgvXe_PTT.Name = "dgvXe_PTT";
            this.dgvXe_PTT.RowHeadersWidth = 51;
            this.dgvXe_PTT.RowTemplate.Height = 24;
            this.dgvXe_PTT.Size = new System.Drawing.Size(1045, 225);
            this.dgvXe_PTT.TabIndex = 22;
            this.dgvXe_PTT.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_PTT_CellContentClick);
            // 
            // dgvPTT
            // 
            this.dgvPTT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTT.Location = new System.Drawing.Point(474, 378);
            this.dgvPTT.Name = "dgvPTT";
            this.dgvPTT.RowHeadersWidth = 51;
            this.dgvPTT.RowTemplate.Height = 24;
            this.dgvPTT.Size = new System.Drawing.Size(1045, 225);
            this.dgvPTT.TabIndex = 22;
            // 
            // btnXemPhieuThuTien
            // 
            this.btnXemPhieuThuTien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemPhieuThuTien.ImageOptions.Image")));
            this.btnXemPhieuThuTien.Location = new System.Drawing.Point(474, 98);
            this.btnXemPhieuThuTien.Name = "btnXemPhieuThuTien";
            this.btnXemPhieuThuTien.Size = new System.Drawing.Size(40, 40);
            this.btnXemPhieuThuTien.TabIndex = 10;
            this.btnXemPhieuThuTien.Text = "refresh";
            this.btnXemPhieuThuTien.Click += new System.EventHandler(this.btnXemPhieuThuTien_Click);
            // 
            // btnTimKH_PTT
            // 
            this.btnTimKH_PTT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKH_PTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKH_PTT.ImageOptions.Image")));
            this.btnTimKH_PTT.Location = new System.Drawing.Point(780, 10);
            this.btnTimKH_PTT.Name = "btnTimKH_PTT";
            this.btnTimKH_PTT.Size = new System.Drawing.Size(41, 42);
            this.btnTimKH_PTT.TabIndex = 1;
            this.btnTimKH_PTT.Click += new System.EventHandler(this.btnTimKH_PTT_Click);
            // 
            // frmPTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 615);
            this.Controls.Add(this.dgvPTT);
            this.Controls.Add(this.dgvXe_PTT);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.btnXemPhieuThuTien);
            this.Controls.Add(this.btnTimKH_PTT);
            this.Controls.Add(this.txtXe_PTT);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPTT";
            this.Text = "Phiếu thu tiền";
            this.Load += new System.EventHandler(this.frmPTT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtXe_PTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTienThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBienSo_PTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKH_PTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPTT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe_PTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton btnXemPhieuThuTien;
        private DevExpress.XtraEditors.SimpleButton btnTimKH_PTT;
        private DevExpress.XtraEditors.TextEdit txtXe_PTT;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaPhieuThuTien;
        private DevExpress.XtraEditors.SimpleButton btnSuaPhieuThuTien;
        private DevExpress.XtraEditors.SimpleButton btnThemPhieuThuTien;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpNgayTao_PTT;
        private DevExpress.XtraEditors.TextEdit txtSoTienThu;
        private DevExpress.XtraEditors.TextEdit txtBienSo_PTT;
        private DevExpress.XtraEditors.TextEdit txtMaKH_PTT;
        private DevExpress.XtraEditors.TextEdit txtIDPTT;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DataGridView dgvXe_PTT;
        private System.Windows.Forms.DataGridView dgvPTT;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}