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
    public partial class frmAccountChange : DevExpress.XtraEditors.XtraForm
    {
        private AccountDTO loginAccount;

        public AccountDTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public frmAccountChange(AccountDTO acc)
        {
            InitializeComponent();
            LoginAccount = acc;
            ChangeAccount(LoginAccount);
        }

        void UpdateAccount()
        {
            string displayName = txtTenHienThi.Text;
            string password = txtMatKhau.Text;
            string newpass = txtMatKhauMoi.Text;
            string reenterpass = txtNhapLai.Text;
            string username = txtTenDangNhap.Text;

            if (!newpass.Equals(reenterpass))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới!");
            }
            else
            {
                if (AccountDAL.Instance.UpdateAccount(username, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAL.Instance.GetAccountByUserName(username)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
                }
            }

        }

        private void btnCapNhatMK_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        void ChangeAccount(AccountDTO acc)
        {
            txtTenDangNhap.Text = LoginAccount.UserName;
            txtTenHienThi.Text = LoginAccount.Displayname;
        }

        private EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdatingAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
    }
    public class AccountEvent : EventArgs
    {
        private AccountDTO acc;

        public AccountDTO Acc
        {
            get { return acc; }
            set { acc = value; }
        }

        public AccountEvent(AccountDTO acc)
        {
            this.Acc = acc;
        }
    }
}