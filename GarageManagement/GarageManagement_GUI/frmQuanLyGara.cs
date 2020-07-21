using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using GarageManagement_DTO;
using GarageManagement.GarageManagement_GUI;

namespace GarageManagement
{
    public partial class frmQuanLyGara : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private AccountDTO loginaccount;

        public AccountDTO Loginaccount
        {
            get { return loginaccount; }
            set { loginaccount = value; }
        }

        public frmQuanLyGara(AccountDTO acc)
        {
            InitializeComponent();
            this.loginaccount = acc;
            ChangeAccount(loginaccount.AccessLevel);
        }

        private void ribbonPageGroup1_CaptionButtonClick(object sender, DevExpress.XtraBars.Ribbon.RibbonPageGroupEventArgs e)
        {
          
        }

        void ChangeAccount(int AccessLevel)
        {
            rpgAccount.Visible = AccessLevel == 1;
            barButtonItem1.Caption += " (" + Loginaccount.Displayname + ")";
            rbThongTin.Text += " (" + Loginaccount.Displayname + ")"; 
            rbBaocao.Visible = AccessLevel == 1;
        }

        private void btnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void btnXe_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmXe f = new frmXe();
            f.MdiParent = this;
            f.Show();
        }

        private void btnVattu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVatLieu f = new frmVatLieu();
            f.MdiParent = this;
            f.Show();
        }

        private void btnPSC_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPSC f = new frmPSC();
            f.MdiParent = this;
            f.Show();
        }

        private void btnPTT_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPTT f = new frmPTT();
            f.MdiParent = this;
            f.Show();
        }

        private void btnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoanhThu f = new frmDoanhThu();
            f.MdiParent = this;
            f.Show();
        }

        private void btnTonKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTonKho f = new frmTonKho();
            f.MdiParent = this;
            f.Show();
        }

        private void btnChangeInfor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccountChange f = new frmAccountChange(loginaccount);
            f.UpdatingAccount += F_UpdatingAccount;
            f.MdiParent = this;
            f.Show();
        }

        private void F_UpdatingAccount(object sender, AccountEvent e)
        {
            barButtonItem1.Caption = " Tài khoản (" + e.Acc.Displayname + ")";
            rbThongTin.Text = " Thông tin cá nhân (" + e.Acc.Displayname + ")";
        }

        private void btnAccount_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAccount f = new frmAccount(loginaccount);
            f.UpdateAccount += F_UpdateAccount;
            f.MdiParent = this;
            f.Show();
        }

        private void F_UpdateAccount(object sender, AccountEvent e)
        {
            barButtonItem1.Caption = " Tài khoản (" + e.Acc.Displayname + ")";
            rbThongTin.Text = " Thông tin cá nhân (" + e.Acc.Displayname + ")";
        }

        private void frmQuanLyGara_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;

            }          
        }
    }
}