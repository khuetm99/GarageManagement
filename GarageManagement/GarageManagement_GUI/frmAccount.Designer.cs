namespace GarageManagement.GarageManagement_GUI
{
    partial class frmAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccount));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cbLoaiTK = new System.Windows.Forms.ComboBox();
            this.btnDatLaiMK = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenHienThi = new DevExpress.XtraEditors.TextEdit();
            this.txtTenTK = new DevExpress.XtraEditors.TextEdit();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnXemAcc = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemAcc = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoaAcc = new DevExpress.XtraEditors.SimpleButton();
            this.btnSuaAcc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHienThi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cbLoaiTK);
            this.groupControl1.Controls.Add(this.btnThemAcc);
            this.groupControl1.Controls.Add(this.btnXoaAcc);
            this.groupControl1.Controls.Add(this.btnDatLaiMK);
            this.groupControl1.Controls.Add(this.btnSuaAcc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtTenHienThi);
            this.groupControl1.Controls.Add(this.txtTenTK);
            this.groupControl1.Location = new System.Drawing.Point(12, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 505);
            this.groupControl1.TabIndex = 17;
            this.groupControl1.Text = "Điền thông tin tài khoản";
            // 
            // cbLoaiTK
            // 
            this.cbLoaiTK.FormattingEnabled = true;
            this.cbLoaiTK.Items.AddRange(new object[] {
            "Admin",
            "Staff"});
            this.cbLoaiTK.Location = new System.Drawing.Point(133, 145);
            this.cbLoaiTK.Name = "cbLoaiTK";
            this.cbLoaiTK.Size = new System.Drawing.Size(230, 24);
            this.cbLoaiTK.TabIndex = 2;
            this.cbLoaiTK.Text = "Admin";
            // 
            // btnDatLaiMK
            // 
            this.btnDatLaiMK.Location = new System.Drawing.Point(243, 195);
            this.btnDatLaiMK.Name = "btnDatLaiMK";
            this.btnDatLaiMK.Size = new System.Drawing.Size(120, 30);
            this.btnDatLaiMK.TabIndex = 3;
            this.btnDatLaiMK.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMK.Click += new System.EventHandler(this.btnDatLaiMK_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(106, 18);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Loại tài khoản";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 95);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên hiển thị";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên đăng nhập";
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(133, 95);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(230, 22);
            this.txtTenHienThi.TabIndex = 1;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(133, 45);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(230, 22);
            this.txtTenTK.TabIndex = 0;
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(474, 144);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.RowHeadersWidth = 51;
            this.dgvTaiKhoan.RowTemplate.Height = 24;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(1045, 459);
            this.dgvTaiKhoan.TabIndex = 18;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(947, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(196, 24);
            this.labelControl7.TabIndex = 20;
            this.labelControl7.Text = "Thông tin tài khoản";
            // 
            // btnXemAcc
            // 
            this.btnXemAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemAcc.ImageOptions.Image")));
            this.btnXemAcc.Location = new System.Drawing.Point(474, 98);
            this.btnXemAcc.Name = "btnXemAcc";
            this.btnXemAcc.Size = new System.Drawing.Size(40, 40);
            this.btnXemAcc.TabIndex = 7;
            this.btnXemAcc.Text = "refresh";
            this.btnXemAcc.Click += new System.EventHandler(this.btnXemAcc_Click);
            // 
            // btnThemAcc
            // 
            this.btnThemAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemAcc.ImageOptions.Image")));
            this.btnThemAcc.Location = new System.Drawing.Point(30, 440);
            this.btnThemAcc.Name = "btnThemAcc";
            this.btnThemAcc.Size = new System.Drawing.Size(100, 40);
            this.btnThemAcc.TabIndex = 4;
            this.btnThemAcc.Text = "Thêm";
            this.btnThemAcc.Click += new System.EventHandler(this.btnThemAcc_Click);
            // 
            // btnXoaAcc
            // 
            this.btnXoaAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaAcc.ImageOptions.Image")));
            this.btnXoaAcc.Location = new System.Drawing.Point(170, 440);
            this.btnXoaAcc.Name = "btnXoaAcc";
            this.btnXoaAcc.Size = new System.Drawing.Size(100, 40);
            this.btnXoaAcc.TabIndex = 5;
            this.btnXoaAcc.Text = "Xoá";
            this.btnXoaAcc.Click += new System.EventHandler(this.btnXoaAcc_Click);
            // 
            // btnSuaAcc
            // 
            this.btnSuaAcc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaAcc.ImageOptions.Image")));
            this.btnSuaAcc.Location = new System.Drawing.Point(310, 440);
            this.btnSuaAcc.Name = "btnSuaAcc";
            this.btnSuaAcc.Size = new System.Drawing.Size(100, 40);
            this.btnSuaAcc.TabIndex = 6;
            this.btnSuaAcc.Text = "Sửa";
            this.btnSuaAcc.Click += new System.EventHandler(this.btnSuaAcc_Click);
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 615);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btnXemAcc);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAccount";
            this.Text = "Thông tin tài khoản";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenHienThi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaAcc;
        private DevExpress.XtraEditors.SimpleButton btnSuaAcc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTenHienThi;
        private DevExpress.XtraEditors.TextEdit txtTenTK;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private DevExpress.XtraEditors.SimpleButton btnXemAcc;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.ComboBox cbLoaiTK;
        private DevExpress.XtraEditors.SimpleButton btnThemAcc;
        private DevExpress.XtraEditors.SimpleButton btnDatLaiMK;
    }
}