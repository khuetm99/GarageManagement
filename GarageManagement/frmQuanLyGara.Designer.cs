namespace GarageManagement
{
    partial class AdministratorForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsDanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDoanhSo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTTTK = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsDanhmuc,
            this.mnsBaocao,
            this.mnsTaiKhoan,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsDanhmuc
            // 
            this.mnsDanhmuc.Name = "mnsDanhmuc";
            this.mnsDanhmuc.Size = new System.Drawing.Size(90, 24);
            this.mnsDanhmuc.Text = "Danh mục";
            this.mnsDanhmuc.Click += new System.EventHandler(this.mnsDanhmuc_Click);
            // 
            // mnsBaocao
            // 
            this.mnsBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsDoanhSo,
            this.tsTonKho});
            this.mnsBaocao.Name = "mnsBaocao";
            this.mnsBaocao.Size = new System.Drawing.Size(154, 24);
            this.mnsBaocao.Text = "Báo cáo kinh doanh";
            // 
            // tsDoanhSo
            // 
            this.tsDoanhSo.Name = "tsDoanhSo";
            this.tsDoanhSo.Size = new System.Drawing.Size(224, 26);
            this.tsDoanhSo.Text = "Báo cáo doanh số";
            this.tsDoanhSo.Click += new System.EventHandler(this.tsDoanhSo_Click);
            // 
            // tsTonKho
            // 
            this.tsTonKho.Name = "tsTonKho";
            this.tsTonKho.Size = new System.Drawing.Size(224, 26);
            this.tsTonKho.Text = "Báo cáo tồn kho";
            // 
            // mnsTaiKhoan
            // 
            this.mnsTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsTTTK,
            this.tsDangXuat});
            this.mnsTaiKhoan.Name = "mnsTaiKhoan";
            this.mnsTaiKhoan.Size = new System.Drawing.Size(85, 24);
            this.mnsTaiKhoan.Text = "Tài khoản";
            // 
            // tsTTTK
            // 
            this.tsTTTK.Name = "tsTTTK";
            this.tsTTTK.Size = new System.Drawing.Size(224, 26);
            this.tsTTTK.Text = "Thông tin tài khoản";
            // 
            // tsDangXuat
            // 
            this.tsDangXuat.Name = "tsDangXuat";
            this.tsDangXuat.Size = new System.Drawing.Size(224, 26);
            this.tsDangXuat.Text = "Đăng xuất";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(226, 298);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 320);
            this.panel1.TabIndex = 1;
            // 
            // AdministratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Gara";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsDanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnsBaocao;
        private System.Windows.Forms.ToolStripMenuItem tsDoanhSo;
        private System.Windows.Forms.ToolStripMenuItem tsTonKho;
        private System.Windows.Forms.ToolStripMenuItem mnsTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsTTTK;
        private System.Windows.Forms.ToolStripMenuItem tsDangXuat;
        private System.Windows.Forms.Panel panel1;
    }
}