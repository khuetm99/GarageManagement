namespace GarageManagement.GarageManagement_GUI
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.dgvKH_Xe = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnXoaXe = new DevExpress.XtraEditors.SimpleButton();
            this.btxSuaXe = new DevExpress.XtraEditors.SimpleButton();
            this.btnThemXe = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaXe = new DevExpress.XtraEditors.TextEdit();
            this.txtHieuXe = new DevExpress.XtraEditors.TextEdit();
            this.txtIDKH_XE = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTimKH_Xe = new DevExpress.XtraEditors.TextEdit();
            this.btnXemXe = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKH_Xe = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH_Xe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHieuXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKH_XE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKH_Xe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKH_Xe
            // 
            this.dgvKH_Xe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH_Xe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH_Xe.Location = new System.Drawing.Point(474, 144);
            this.dgvKH_Xe.Name = "dgvKH_Xe";
            this.dgvKH_Xe.RowHeadersWidth = 51;
            this.dgvKH_Xe.RowTemplate.Height = 24;
            this.dgvKH_Xe.Size = new System.Drawing.Size(1045, 225);
            this.dgvKH_Xe.TabIndex = 16;
            this.dgvKH_Xe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_Xe_CellContentClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtStatus);
            this.groupControl1.Controls.Add(this.btnXoaXe);
            this.groupControl1.Controls.Add(this.btxSuaXe);
            this.groupControl1.Controls.Add(this.btnThemXe);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtMaXe);
            this.groupControl1.Controls.Add(this.txtHieuXe);
            this.groupControl1.Controls.Add(this.txtIDKH_XE);
            this.groupControl1.Location = new System.Drawing.Point(12, 98);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(444, 505);
            this.groupControl1.TabIndex = 15;
            this.groupControl1.Text = "Điền thông tin xe";
            // 
            // txtStatus
            // 
            this.txtStatus.EditValue = "Chưa sửa";
            this.txtStatus.Location = new System.Drawing.Point(133, 195);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStatus.Properties.Items.AddRange(new object[] {
            "Chưa sửa ",
            "Đang sửa",
            "Hoàn thành"});
            this.txtStatus.Size = new System.Drawing.Size(230, 22);
            this.txtStatus.TabIndex = 5;
            // 
            // btnXoaXe
            // 
            this.btnXoaXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaXe.ImageOptions.Image")));
            this.btnXoaXe.Location = new System.Drawing.Point(170, 440);
            this.btnXoaXe.Name = "btnXoaXe";
            this.btnXoaXe.Size = new System.Drawing.Size(100, 40);
            this.btnXoaXe.TabIndex = 7;
            this.btnXoaXe.Text = "Xoá";
            this.btnXoaXe.Click += new System.EventHandler(this.btnXoaXe_Click);
            // 
            // btxSuaXe
            // 
            this.btxSuaXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btxSuaXe.ImageOptions.Image")));
            this.btxSuaXe.Location = new System.Drawing.Point(310, 440);
            this.btxSuaXe.Name = "btxSuaXe";
            this.btxSuaXe.Size = new System.Drawing.Size(100, 40);
            this.btxSuaXe.TabIndex = 8;
            this.btxSuaXe.Text = "Sửa";
            this.btxSuaXe.Click += new System.EventHandler(this.btxSuaXe_Click);
            // 
            // btnThemXe
            // 
            this.btnThemXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThemXe.ImageOptions.Image")));
            this.btnThemXe.Location = new System.Drawing.Point(30, 440);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.Size = new System.Drawing.Size(100, 40);
            this.btnThemXe.TabIndex = 6;
            this.btnThemXe.Text = "Tạo";
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(15, 195);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 18);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Tình trạng";
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
            this.labelControl2.Size = new System.Drawing.Size(56, 18);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Hiệu xe";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(107, 18);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ID khách hàng";
            // 
            // txtMaXe
            // 
            this.txtMaXe.Location = new System.Drawing.Point(133, 145);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(230, 22);
            this.txtMaXe.TabIndex = 4;
            // 
            // txtHieuXe
            // 
            this.txtHieuXe.Location = new System.Drawing.Point(133, 95);
            this.txtHieuXe.Name = "txtHieuXe";
            this.txtHieuXe.Size = new System.Drawing.Size(230, 22);
            this.txtHieuXe.TabIndex = 3;
            // 
            // txtIDKH_XE
            // 
            this.txtIDKH_XE.Location = new System.Drawing.Point(133, 45);
            this.txtIDKH_XE.Name = "txtIDKH_XE";
            this.txtIDKH_XE.Size = new System.Drawing.Size(230, 22);
            this.txtIDKH_XE.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(947, 104);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(280, 24);
            this.labelControl7.TabIndex = 17;
            this.labelControl7.Text = "Thông tin khách hàng và xe";
            // 
            // dgvXe
            // 
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXe.Location = new System.Drawing.Point(474, 378);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.Size = new System.Drawing.Size(1045, 225);
            this.dgvXe.TabIndex = 16;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(250, 21);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(115, 18);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Tìm khách hàng";
            // 
            // txtTimKH_Xe
            // 
            this.txtTimKH_Xe.EditValue = "";
            this.txtTimKH_Xe.Location = new System.Drawing.Point(377, 16);
            this.txtTimKH_Xe.Name = "txtTimKH_Xe";
            this.txtTimKH_Xe.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKH_Xe.Properties.Appearance.Options.UseFont = true;
            this.txtTimKH_Xe.Size = new System.Drawing.Size(390, 28);
            this.txtTimKH_Xe.TabIndex = 0;
            // 
            // btnXemXe
            // 
            this.btnXemXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXemXe.ImageOptions.Image")));
            this.btnXemXe.Location = new System.Drawing.Point(474, 98);
            this.btnXemXe.Name = "btnXemXe";
            this.btnXemXe.Size = new System.Drawing.Size(40, 40);
            this.btnXemXe.TabIndex = 9;
            this.btnXemXe.Click += new System.EventHandler(this.btnXemXe_Click);
            // 
            // btnTimKH_Xe
            // 
            this.btnTimKH_Xe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKH_Xe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKH_Xe.ImageOptions.Image")));
            this.btnTimKH_Xe.Location = new System.Drawing.Point(780, 10);
            this.btnTimKH_Xe.Name = "btnTimKH_Xe";
            this.btnTimKH_Xe.Size = new System.Drawing.Size(41, 42);
            this.btnTimKH_Xe.TabIndex = 1;
            this.btnTimKH_Xe.Click += new System.EventHandler(this.btnTimKH_Xe_Click);
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 615);
            this.Controls.Add(this.btnXemXe);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.dgvKH_Xe);
            this.Controls.Add(this.btnTimKH_Xe);
            this.Controls.Add(this.txtTimKH_Xe);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl7);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmXe";
            this.Text = "Thông tin xe";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH_Xe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHieuXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDKH_XE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKH_Xe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnXemXe;
        private System.Windows.Forms.DataGridView dgvKH_Xe;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnXoaXe;
        private DevExpress.XtraEditors.SimpleButton btxSuaXe;
        private DevExpress.XtraEditors.SimpleButton btnThemXe;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtMaXe;
        private DevExpress.XtraEditors.TextEdit txtHieuXe;
        private DevExpress.XtraEditors.TextEdit txtIDKH_XE;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private System.Windows.Forms.DataGridView dgvXe;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTimKH_Xe;
        private DevExpress.XtraEditors.SimpleButton btnTimKH_Xe;
        private DevExpress.XtraEditors.ComboBoxEdit txtStatus;
    }
}