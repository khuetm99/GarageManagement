namespace GarageManagement.GarageManagement_GUI
{
    partial class frmVatLieu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVatLieu));
            this.dgvKho = new System.Windows.Forms.DataGridView();
            this.txtTimKho = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.nmSoLuongVatLieu = new System.Windows.Forms.NumericUpDown();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtpNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtVatLieu = new DevExpress.XtraEditors.TextEdit();
            this.txtMaSoVatLieu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnXemKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaKho = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemKho = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongVatLieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatLieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoVatLieu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKho
            // 
            this.dgvKho.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKho.Location = new System.Drawing.Point(474, 144);
            this.dgvKho.Name = "dgvKho";
            this.dgvKho.RowHeadersWidth = 51;
            this.dgvKho.RowTemplate.Height = 24;
            this.dgvKho.Size = new System.Drawing.Size(1045, 459);
            this.dgvKho.TabIndex = 16;
            // 
            // txtTimKho
            // 
            this.txtTimKho.EditValue = "";
            this.txtTimKho.Location = new System.Drawing.Point(377, 16);
            this.txtTimKho.Name = "txtTimKho";
            this.txtTimKho.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKho.Properties.Appearance.Options.UseFont = true;
            this.txtTimKho.Size = new System.Drawing.Size(390, 28);
            this.txtTimKho.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.nmSoLuongVatLieu);
            this.groupControl1.Controls.Add(this.btnXoaKho);
            this.groupControl1.Controls.Add(this.btnSuaKho);
            this.groupControl1.Controls.Add(this.btnThemKho);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.dtpNgayNhap);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtVatLieu);
            this.groupControl1.Controls.Add(this.txtMaSoVatLieu);
            this.groupControl1.Location = new System.Drawing.Point(12, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 505);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Điền thông tin vật liệu";
            // 
            // nmSoLuongVatLieu
            // 
            this.nmSoLuongVatLieu.Location = new System.Drawing.Point(133, 195);
            this.nmSoLuongVatLieu.Name = "nmSoLuongVatLieu";
            this.nmSoLuongVatLieu.Size = new System.Drawing.Size(230, 23);
            this.nmSoLuongVatLieu.TabIndex = 5;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(15, 247);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(79, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Ngày nhập";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 194);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(67, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Số lượng";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(58, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Đơn giá";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên vật liệu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ID vật liệu";
            // 
            // dtpNgayNhap
            // 
            this.dtpNgayNhap.Location = new System.Drawing.Point(133, 245);
            this.dtpNgayNhap.Name = "dtpNgayNhap";
            this.dtpNgayNhap.Size = new System.Drawing.Size(230, 23);
            this.dtpNgayNhap.TabIndex = 6;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(133, 145);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(230, 22);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtVatLieu
            // 
            this.txtVatLieu.Location = new System.Drawing.Point(133, 95);
            this.txtVatLieu.Name = "txtVatLieu";
            this.txtVatLieu.Size = new System.Drawing.Size(230, 22);
            this.txtVatLieu.TabIndex = 3;
            // 
            // txtMaSoVatLieu
            // 
            this.txtMaSoVatLieu.Location = new System.Drawing.Point(133, 45);
            this.txtMaSoVatLieu.Name = "txtMaSoVatLieu";
            this.txtMaSoVatLieu.Properties.ReadOnly = true;
            this.txtMaSoVatLieu.Size = new System.Drawing.Size(230, 22);
            this.txtMaSoVatLieu.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(947, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(177, 24);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Thông tin vật liệu";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(275, 21);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(87, 18);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Tìm vật liệu";
            // 
            // btnXemKho
            // 
            this.btnXemKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemKho.ImageOptions.Image")));
            this.btnXemKho.Location = new System.Drawing.Point(474, 98);
            this.btnXemKho.Name = "btnXemKho";
            this.btnXemKho.Size = new System.Drawing.Size(40, 40);
            this.btnXemKho.TabIndex = 10;
            this.btnXemKho.Text = "refresh";
            this.btnXemKho.Click += new System.EventHandler(this.btnXemKho_Click);
            // 
            // btnTimKho
            // 
            this.btnTimKho.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKho.ImageOptions.Image")));
            this.btnTimKho.Location = new System.Drawing.Point(780, 10);
            this.btnTimKho.Name = "btnTimKho";
            this.btnTimKho.Size = new System.Drawing.Size(41, 42);
            this.btnTimKho.TabIndex = 1;
            this.btnTimKho.Click += new System.EventHandler(this.btnTimKho_Click);
            // 
            // btnXoaKho
            // 
            this.btnXoaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaKho.ImageOptions.Image")));
            this.btnXoaKho.Location = new System.Drawing.Point(170, 440);
            this.btnXoaKho.Name = "btnXoaKho";
            this.btnXoaKho.Size = new System.Drawing.Size(100, 40);
            this.btnXoaKho.TabIndex = 8;
            this.btnXoaKho.Text = "Xoá";
            this.btnXoaKho.Click += new System.EventHandler(this.btnXoaKho_Click);
            // 
            // btnSuaKho
            // 
            this.btnSuaKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaKho.ImageOptions.Image")));
            this.btnSuaKho.Location = new System.Drawing.Point(310, 440);
            this.btnSuaKho.Name = "btnSuaKho";
            this.btnSuaKho.Size = new System.Drawing.Size(100, 40);
            this.btnSuaKho.TabIndex = 9;
            this.btnSuaKho.Text = "Sửa";
            this.btnSuaKho.Click += new System.EventHandler(this.btnSuaKho_Click);
            // 
            // btnThemKho
            // 
            this.btnThemKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKho.ImageOptions.Image")));
            this.btnThemKho.Location = new System.Drawing.Point(30, 440);
            this.btnThemKho.Name = "btnThemKho";
            this.btnThemKho.Size = new System.Drawing.Size(100, 40);
            this.btnThemKho.TabIndex = 7;
            this.btnThemKho.Text = "Tạo";
            this.btnThemKho.Click += new System.EventHandler(this.btnThemKho_Click);
            // 
            // frmVatLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 615);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.btnXemKho);
            this.Controls.Add(this.dgvKho);
            this.Controls.Add(this.btnTimKho);
            this.Controls.Add(this.txtTimKho);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmVatLieu";
            this.Text = "Quản lý vật liệu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongVatLieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVatLieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSoVatLieu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXemKho;
        private System.Windows.Forms.DataGridView dgvKho;
        private DevExpress.XtraEditors.SimpleButton btnTimKho;
        private DevExpress.XtraEditors.TextEdit txtTimKho;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaKho;
        private DevExpress.XtraEditors.SimpleButton btnSuaKho;
        private DevExpress.XtraEditors.SimpleButton btnThemKho;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DateTimePicker dtpNgayNhap;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtVatLieu;
        private DevExpress.XtraEditors.TextEdit txtMaSoVatLieu;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.NumericUpDown nmSoLuongVatLieu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}