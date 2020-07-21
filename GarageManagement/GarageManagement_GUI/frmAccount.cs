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
using GarageManagement_DAL;
using GarageManagement_DTO;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmAccount : DevExpress.XtraEditors.XtraForm
    {
        BindingSource accountList = new BindingSource();

        private AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public frmAccount(AccountDTO acc)
        {
            InitializeComponent();
            this.loginAccount = acc;
            dgvTaiKhoan.DataSource = accountList;
            LoadListAccout();
            AddAccountBinding();

        }

        void LoadListAccout()
        {
            accountList.DataSource = AccountDAL.Instance.GetListAccount();
        }

        void AddAccountBinding()
        {
            txtTenTK.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "username", true, DataSourceUpdateMode.Never));
            txtTenHienThi.DataBindings.Add(new Binding("Text", dgvTaiKhoan.DataSource, "displayname", true, DataSourceUpdateMode.Never));
           
        }

        private void btnDatLaiMK_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            if (AccountDAL.Instance.ResetPassword(username))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Lỗi khi đặt lại mật khẩu");
            }
        }

        private void btnThemAcc_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            string displayname = txtTenHienThi.Text;
            int type = 0;
            if(cbLoaiTK.Text == "Admin")
            {
                type = 1;
            }
            else if(cbLoaiTK.Text == "Staff")
            {
                type = 0;
            }
            if (AccountDAL.Instance.InsertAccount(username, displayname, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
                LoadListAccout();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm tài khoản");
            }
        }

        private void btnXoaAcc_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            if (loginAccount.UserName.Equals(username))
            {
                MessageBox.Show("Không thể xoá tài khoản hiện tại!");
                return;
            }
            if (AccountDAL.Instance.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadListAccout();
            }
            else
            {
                MessageBox.Show("Lỗi khi xóa tài khoản");
            }
        }

        private void btnSuaAcc_Click(object sender, EventArgs e)
        {
            string username = txtTenTK.Text;
            string displayname = txtTenHienThi.Text;
            int type = 0;
            if (cbLoaiTK.Text == "Admin")
            {
                type = 1;
            }
            else if (cbLoaiTK.Text == "Staff")
            {
                type = 0;
            }
            if (AccountDAL.Instance.UpdateAccount(username, displayname, type))
            {
                MessageBox.Show("Thay đổi tài khoản thành công");
                LoadListAccout();
                if (updateAccount != null)
                    updateAccount(this, new AccountEvent(AccountDAL.Instance.GetAccountByUserName(username)));
            }
            else
            {
                MessageBox.Show("Lỗi khi thay đổi tài khoản");
            }
        }

        private void btnXemAcc_Click(object sender, EventArgs e)
        {
            LoadListAccout();
        }

        private event EventHandler<AccountEvent> updateAccount;

        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }
}