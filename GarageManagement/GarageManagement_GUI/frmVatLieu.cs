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
using GarageManagement.GarageManagement_DAL;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmVatLieu : DevExpress.XtraEditors.XtraForm
    {
        BindingSource khoList = new BindingSource();
        public frmVatLieu()
        {

            InitializeComponent();
            dgvKho.DataSource = khoList;
            LoadKho();
            AddBindingKho();
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

        void LoadKho()
        {
            khoList.DataSource = VatLieuDAL.Instance.GetListKho();

        }

        void AddBindingKho()
        {

            txtMaSoVatLieu.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "iditem", true, DataSourceUpdateMode.Never));
            txtVatLieu.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "item", true, DataSourceUpdateMode.Never));
            nmSoLuongVatLieu.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "slitem", true, DataSourceUpdateMode.Never));
            dtpNgayNhap.DataBindings.Add(new Binding("Value", dgvKho.DataSource, "importeddate", true, DataSourceUpdateMode.Never));
            txtDonGia.DataBindings.Add(new Binding("Text", dgvKho.DataSource, "dongia", true, DataSourceUpdateMode.Never));
        }

        private void btnThemKho_Click(object sender, EventArgs e)
        {
            
               //try
               // {                  
                    string item = txtVatLieu.Text;
                    int slitem = Convert.ToInt32(nmSoLuongVatLieu.Text);
                    DateTime? importteddate = dtpNgayNhap.Value;
                    float dongia = (float)Convert.ToDouble(txtDonGia.Text);
                    if (VatLieuDAL.Instance.InsertVatLieu(item, slitem, importteddate, dongia))
                    {
                        MessageBox.Show("Thêm vào kho thành công");
                        LoadKho();

                    }
                    else
                    {
                        MessageBox.Show("Thêm vào kho lỗi !!");
                    }
                //}
                //catch (Exception ex) { MessageBox.Show("Thêm vào kho lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            
        }

        private void btnXoaKho_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtMaSoVatLieu.Text) == true)
            {
                try
                {
                    int iditem = Convert.ToInt32(txtMaSoVatLieu.Text);

                    if (VatLieuDAL.Instance.DeleteVatLieu(iditem))
                    {
                        MessageBox.Show("Xóa vật liệu kho thành công");
                        LoadKho();

                    }
                    else
                    {
                        MessageBox.Show("Xóa vật liệu kho kho lỗi !!");
                    }
                }
                catch (Exception ex) { MessageBox.Show(" Xóa vật liệu trong kho lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }



        private void btnSuaKho_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtMaSoVatLieu.Text) == true)
            {
                try
                {
                    int iditem = Convert.ToInt32(txtMaSoVatLieu.Text);
                    string item = txtVatLieu.Text;
                    int slitem = Convert.ToInt32(nmSoLuongVatLieu.Text);
                    DateTime? importteddate = dtpNgayNhap.Value;
                    float dongia = (float)Convert.ToDouble(txtDonGia.Text);
                    if (VatLieuDAL.Instance.UpdateVatLieu(iditem, item, slitem, importteddate, dongia))
                    {
                        MessageBox.Show("Cập nhật kho thành công");
                        LoadKho();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật kho lỗi !!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Cập nhật vật liệu kho lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnTimKho_Click(object sender, EventArgs e)
        {
            khoList.DataSource = VatLieuDAL.Instance.SearchVatLieuByNameAndID(txtTimKho.Text);
        }

        private void btnXemKho_Click(object sender, EventArgs e)
        {
            LoadKho();
        }
    }
}