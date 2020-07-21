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
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
           
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            if (Login(userName, passWord))
            {
                try
                {

                    AccountDTO loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                    txbUsername.Text = "";
                    txbPassword.Text = "";
                    frmQuanLyGara adminFrom = new frmQuanLyGara(loginAccount);
                    this.Hide();
                    adminFrom.ShowDialog();
                    this.Show();                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã có lỗi xảy ra!" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string userName, string passWord)
        {

            return AccountDAL.Instance.Login(userName, passWord);
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Information) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void txbUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string userName = txbUsername.Text;
                string passWord = txbPassword.Text;
                if (Login(userName, passWord))
                {
                    try
                    {

                        AccountDTO loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                        txbUsername.Text = "";
                        txbPassword.Text = "";
                        frmQuanLyGara adminFrom = new frmQuanLyGara(loginAccount);
                        this.Hide();
                        adminFrom.ShowDialog();
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void txbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string userName = txbUsername.Text;
                string passWord = txbPassword.Text;
                if (Login(userName, passWord))
                {
                    try
                    {

                        AccountDTO loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                        txbUsername.Text = "";
                        txbPassword.Text = "";
                        frmQuanLyGara adminFrom = new frmQuanLyGara(loginAccount);
                        this.Hide();
                        adminFrom.ShowDialog();
                        this.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã có lỗi xảy ra" + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
