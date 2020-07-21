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
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        BindingSource khachhangList = new BindingSource();

        public frmKhachHang()
        {
            InitializeComponent();
            LoadMethod();
        }

        void LoadMethod()
        {
            dgvKhachHang.DataSource = khachhangList;
            LoadListKhachHang();
            AddBindingKhachHang();

        }

        void LoadListKhachHang()
        {
            khachhangList.DataSource = KhachHangDAL.Instance.GetListKhachHang();
        }

        bool CheckIntValue(string id)
        {
            int parsedValue;
            if (!int.TryParse(id, out parsedValue))
            {
                MessageBox.Show("Id sai số , xin vui lòng nhập lại !");
                return false;
            }
            return true;
        }

        List<KhachHangDTO> SearchKhachHang(string text)
        {
            List<KhachHangDTO> list = KhachHangDAL.Instance.SearchKhachHangByNameAndID(text);
            return list;
        }

        void AddBindingKhachHang()
        {
            txtIDKhachHang.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtTenKhachHang.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "customername", true, DataSourceUpdateMode.Never));
            txtDiaChi.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "Address", true, DataSourceUpdateMode.Never));
            txtDienThoai.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "PHONE", true, DataSourceUpdateMode.Never));
            dtpNgayGui.DataBindings.Add(new Binding("Value", dgvKhachHang.DataSource, "CREATEDDATE", true, DataSourceUpdateMode.Never));
            txtTienNo.DataBindings.Add(new Binding("Text", dgvKhachHang.DataSource, "DEBT", true, DataSourceUpdateMode.Never));
        }

        private void btnSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDKhachHang.Text) == true)
            {
                try
                {
                    int id = Convert.ToInt32(txtIDKhachHang.Text);
                    string name = txtTenKhachHang.Text;
                    string DiaChi = txtDiaChi.Text;
                    int DienThoai = Convert.ToInt32(txtDienThoai.Text);
                    DateTime? Ngaygui = dtpNgayGui.Value;
                    float Tienno = (float)Convert.ToDouble(txtTienNo.Text);
                    if (KhachHangDAL.Instance.UpdateKhachHang(name, DiaChi, DienThoai, Ngaygui, Tienno, id))
                    {
                        MessageBox.Show("Sửa Khách Hàng thành công");
                        LoadListKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Khách Hàng lỗi!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Sửa khách hàng lỗi! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDKhachHang.Text) == true)
            {
                try
                {
                    int id = Convert.ToInt32(txtIDKhachHang.Text);
                    if (KhachHangDAL.Instance.DeleteKhachHang(id))
                    {
                        MessageBox.Show("Xóa Khách Hàng thành công");
                        LoadListKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Khách Hàng lỗi");
                    }

                }
                catch (Exception ex) { MessageBox.Show("Xóa khách hàng lỗi" + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {         
                try
                {
                    string name = txtTenKhachHang.Text;
                    string DiaChi = txtDiaChi.Text;
                    int DienThoai = Convert.ToInt32(txtDienThoai.Text);
                    DateTime? Ngaygui = dtpNgayGui.Value;
                    float Tienno = (float)Convert.ToDouble(txtTienNo.Text);
                    if (KhachHangDAL.Instance.InsertKhachHang(name, DiaChi, DienThoai, Ngaygui, Tienno))
                    {
                        MessageBox.Show("Thêm Khách Hàng thành công");
                        LoadListKhachHang();
                    
                    }
                    else
                    {
                        MessageBox.Show("Thêm Khách Hàng lỗi");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Thêm khách hàng lỗi" + ex.Message + "\n" + ex.StackTrace); }
            
        }

        private void btnXemKhachHang_Click(object sender, EventArgs e)
        {
            LoadListKhachHang();
        }

        private void btnTimKhachHang_Click(object sender, EventArgs e)
        {
            khachhangList.DataSource = SearchKhachHang(txtTimKhachHang.Text);
        }

        private void txtTenKhachHang_Validating(object sender, CancelEventArgs e)
        {
            if (txtTenKhachHang.Text == string.Empty)
            {
                errorProvider1.SetError(txtTenKhachHang, "Please Enter Name");
            }
            else
            {
                errorProvider1.SetError(txtTenKhachHang, "");

            }
        }

        private void txtDienThoai_Validating(object sender, CancelEventArgs e)
        {
            if (txtDienThoai.Text == string.Empty)
            {
                errorProvider1.SetError(txtDienThoai, "Please Enter Phone number");
            }
            else
            {
                errorProvider1.SetError(txtDienThoai, "");

            }
        }

        private void txtTienNo_Validating(object sender, CancelEventArgs e)
        {
            if (txtTienNo.Text == string.Empty)
            {
                errorProvider1.SetError(txtTienNo, "Please Enter Debt");
            }
            else
            {
                errorProvider1.SetError(txtTienNo, "");

            }
        }

        private void txtDiaChi_Validating(object sender, CancelEventArgs e)
        {
            if (txtDiaChi.Text == string.Empty)
            {
                errorProvider1.SetError(txtDiaChi, "Please Enter Address");
            }
            else
            {
                errorProvider1.SetError(txtDiaChi, "");

            }
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}