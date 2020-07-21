namespace GarageManagement
{
    partial class frmQuanLyGara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyGara));
            this.chu = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKhachHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnXe = new DevExpress.XtraBars.BarButtonItem();
            this.btnVattu = new DevExpress.XtraBars.BarButtonItem();
            this.btnPTT = new DevExpress.XtraBars.BarButtonItem();
            this.btnPSC = new DevExpress.XtraBars.BarButtonItem();
            this.btnDoanhThu = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonKho = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangeInfor = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem3 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.skinPaletteRibbonGalleryBarItem2 = new DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem();
            this.rbQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ưa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgAccount = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbThongTin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbBaocao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgBaocao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbAbout = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chu
            // 
            this.chu.ExpandCollapseItem.Id = 0;
            this.chu.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.chu.ExpandCollapseItem,
            this.chu.SearchEditItem,
            this.btnKhachHang,
            this.btnXe,
            this.btnVattu,
            this.btnPTT,
            this.btnPSC,
            this.btnDoanhThu,
            this.btnTonKho,
            this.barButtonItem1,
            this.btnChangeInfor,
            this.skinRibbonGalleryBarItem1,
            this.skinRibbonGalleryBarItem2,
            this.skinPaletteRibbonGalleryBarItem1,
            this.barButtonItem2,
            this.skinRibbonGalleryBarItem3,
            this.skinPaletteRibbonGalleryBarItem2});
            this.chu.Location = new System.Drawing.Point(0, 0);
            this.chu.MaxItemId = 30;
            this.chu.Name = "chu";
            this.chu.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbQuanLy,
            this.rbThongTin,
            this.rbBaocao,
            this.rbAbout});
            this.chu.QuickToolbarItemLinks.Add(this.skinRibbonGalleryBarItem3);
            this.chu.QuickToolbarItemLinks.Add(this.skinPaletteRibbonGalleryBarItem2);
            this.chu.Size = new System.Drawing.Size(1352, 178);
            this.chu.StatusBar = this.ribbonStatusBar;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Khách hàng";
            this.btnKhachHang.Id = 7;
            this.btnKhachHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.Image")));
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKhachHang_ItemClick);
            // 
            // btnXe
            // 
            this.btnXe.Caption = "Xe";
            this.btnXe.Id = 8;
            this.btnXe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXe.ImageOptions.Image")));
            this.btnXe.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnXe.ImageOptions.LargeImage")));
            this.btnXe.Name = "btnXe";
            this.btnXe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXe_ItemClick);
            // 
            // btnVattu
            // 
            this.btnVattu.Caption = "Vật tư";
            this.btnVattu.Id = 9;
            this.btnVattu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnVattu.ImageOptions.Image")));
            this.btnVattu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnVattu.ImageOptions.LargeImage")));
            this.btnVattu.Name = "btnVattu";
            this.btnVattu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVattu_ItemClick);
            // 
            // btnPTT
            // 
            this.btnPTT.Caption = "Phiếu thu tiền";
            this.btnPTT.Id = 11;
            this.btnPTT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPTT.ImageOptions.Image")));
            this.btnPTT.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPTT.ImageOptions.LargeImage")));
            this.btnPTT.Name = "btnPTT";
            this.btnPTT.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPTT_ItemClick);
            // 
            // btnPSC
            // 
            this.btnPSC.Caption = "Phiếu sửa chữa";
            this.btnPSC.Id = 12;
            this.btnPSC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPSC.ImageOptions.Image")));
            this.btnPSC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPSC.ImageOptions.LargeImage")));
            this.btnPSC.Name = "btnPSC";
            this.btnPSC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPSC_ItemClick);
            // 
            // btnDoanhThu
            // 
            this.btnDoanhThu.Caption = "Doanh thu";
            this.btnDoanhThu.Id = 14;
            this.btnDoanhThu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.ImageOptions.Image")));
            this.btnDoanhThu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDoanhThu.ImageOptions.LargeImage")));
            this.btnDoanhThu.Name = "btnDoanhThu";
            this.btnDoanhThu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDoanhThu_ItemClick);
            // 
            // btnTonKho
            // 
            this.btnTonKho.Caption = "Tồn kho";
            this.btnTonKho.Id = 15;
            this.btnTonKho.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTonKho.ImageOptions.Image")));
            this.btnTonKho.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnTonKho.ImageOptions.LargeImage")));
            this.btnTonKho.Name = "btnTonKho";
            this.btnTonKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTonKho_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tài khoản";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAccount_ItemClick);
            // 
            // btnChangeInfor
            // 
            this.btnChangeInfor.Caption = "Thay đổi thông tin";
            this.btnChangeInfor.Id = 17;
            this.btnChangeInfor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeInfor.ImageOptions.Image")));
            this.btnChangeInfor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnChangeInfor.ImageOptions.LargeImage")));
            this.btnChangeInfor.Name = "btnChangeInfor";
            this.btnChangeInfor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangeInfor_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Id = 23;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // skinRibbonGalleryBarItem2
            // 
            this.skinRibbonGalleryBarItem2.Id = 24;
            this.skinRibbonGalleryBarItem2.Name = "skinRibbonGalleryBarItem2";
            // 
            // skinPaletteRibbonGalleryBarItem1
            // 
            this.skinPaletteRibbonGalleryBarItem1.Id = 25;
            this.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thông tin phần mềm";
            this.barButtonItem2.Id = 26;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // skinRibbonGalleryBarItem3
            // 
            this.skinRibbonGalleryBarItem3.Caption = "skinRibbonGalleryBarItem3";
            this.skinRibbonGalleryBarItem3.Id = 28;
            this.skinRibbonGalleryBarItem3.Name = "skinRibbonGalleryBarItem3";
            // 
            // skinPaletteRibbonGalleryBarItem2
            // 
            this.skinPaletteRibbonGalleryBarItem2.Caption = "skinPaletteRibbonGalleryBarItem2";
            this.skinPaletteRibbonGalleryBarItem2.Id = 29;
            this.skinPaletteRibbonGalleryBarItem2.Name = "skinPaletteRibbonGalleryBarItem2";
            // 
            // rbQuanLy
            // 
            this.rbQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ưa,
            this.rpgAccount});
            this.rbQuanLy.Name = "rbQuanLy";
            this.rbQuanLy.Text = "Quản lý";
            // 
            // ưa
            // 
            this.ưa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ưa.ImageOptions.Image")));
            this.ưa.ImageOptions.ImageIndex = 1;
            this.ưa.ItemLinks.Add(this.btnKhachHang, true);
            this.ưa.ItemLinks.Add(this.btnXe, true);
            this.ưa.ItemLinks.Add(this.btnVattu, true);
            this.ưa.ItemLinks.Add(this.btnPSC, true);
            this.ưa.ItemLinks.Add(this.btnPTT, true);
            this.ưa.Name = "ưa";
            this.ưa.Text = " Quản lý kinh doanh";
            this.ưa.CaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.ribbonPageGroup1_CaptionButtonClick);
            // 
            // rpgAccount
            // 
            this.rpgAccount.ItemLinks.Add(this.barButtonItem1, true);
            this.rpgAccount.Name = "rpgAccount";
            this.rpgAccount.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.rpgAccount.Text = "Tài khoản";
            // 
            // rbThongTin
            // 
            this.rbThongTin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.rbThongTin.Name = "rbThongTin";
            this.rbThongTin.Text = "Thông tin cá nhân";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangeInfor);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Quản lý thông tin cá nhân";
            // 
            // rbBaocao
            // 
            this.rbBaocao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgBaocao});
            this.rbBaocao.Name = "rbBaocao";
            this.rbBaocao.Text = "Báo cáo ";
            // 
            // rpgBaocao
            // 
            this.rpgBaocao.ItemLinks.Add(this.btnDoanhThu, true);
            this.rpgBaocao.ItemLinks.Add(this.btnTonKho, true);
            this.rpgBaocao.Name = "rpgBaocao";
            this.rpgBaocao.Text = "Danh mục báo cáo";
            // 
            // rbAbout
            // 
            this.rbAbout.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rbAbout.Name = "rbAbout";
            this.rbAbout.Text = "About";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Thông tin";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 942);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.chu;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1352, 37);
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "ribbonPageGroup5";
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.chu;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // frmQuanLyGara
            // 
            this.AllowDraggingByPageCategory = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1352, 979);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.chu);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.HtmlText = "Quản lý Gara";
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmQuanLyGara";
            this.Ribbon = this.chu;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLyGara_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl chu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ưa;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbBaocao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgBaocao;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbAbout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnKhachHang;
        private DevExpress.XtraBars.BarButtonItem btnXe;
        private DevExpress.XtraBars.BarButtonItem btnVattu;
        private DevExpress.XtraBars.BarButtonItem btnPTT;
        private DevExpress.XtraBars.BarButtonItem btnPSC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnDoanhThu;
        private DevExpress.XtraBars.BarButtonItem btnTonKho;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnChangeInfor;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem2;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem3;
        private DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem skinPaletteRibbonGalleryBarItem2;
    }
}