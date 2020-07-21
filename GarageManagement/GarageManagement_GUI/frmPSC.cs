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
using GarageManagement.GarageManagement_DTO;
using GarageManagement.GarageManagement_DAL;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmPSC : DevExpress.XtraEditors.XtraForm
    {
        BindingSource pscList = new BindingSource();
        public frmPSC()
        {
            InitializeComponent();
            dgvPSC.DataSource = pscList;
            LoadListPSC();
            LoadXe_PSC();
            LoadComboboxVatLieu(cbVatLieu);       
            AddBindingPSC();

        }

        void LoadListPSC()
        {
            pscList.DataSource = PhieuSuaChuaDAL.Instance.GetListPhieuSuaChua();
        }

        void LoadXe_PSC()
        {
            dgvXe_PSC.DataSource = XeDAL.Instance.GetListXe();
        }

        void LoadComboboxVatLieu(System.Windows.Forms.ComboBox cb)
        {
            cb.DataSource = VatLieuDAL.Instance.GetListKho();
            cb.DisplayMember = "item";
        }



        void AddBindingPSC()
        {
            txtIDPSC.DataBindings.Add(new Binding("Text", dgvPSC.DataSource, "idpsc", true, DataSourceUpdateMode.Never));
            txtCarnumber_PSC.DataBindings.Add(new Binding("Text", dgvPSC.DataSource, "carnumber", true, DataSourceUpdateMode.Never));
            txtNoiDungPSC.DataBindings.Add(new Binding("Text", dgvPSC.DataSource, "detail", true, DataSourceUpdateMode.Never));
            dtpNgayTaoPSC.DataBindings.Add(new Binding("Value", dgvPSC.DataSource, "createddate", true, DataSourceUpdateMode.Never));
            txtDonGiaPSC.DataBindings.Add(new Binding("text", dgvPSC.DataSource, "dongia", true, DataSourceUpdateMode.Never));
            txtTienCongPSC.DataBindings.Add(new Binding("Text", dgvPSC.DataSource, "tiencong", true, DataSourceUpdateMode.Never));
            txtTotalPricePSC.DataBindings.Add(new Binding("Text", dgvPSC.DataSource, "totalprice", true, DataSourceUpdateMode.Never));
        }


        bool CheckIntValue(string id)
        {
            int parsedValue;
            if (!int.TryParse(id, out parsedValue))
            {
                MessageBox.Show("Id sai, xin vui lòng nhập lại");
                return false;
            }
            return true;
        }

        private void btnThemPSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckIntValue(txtCarnumber_PSC.Text) == true)
                {
                    int carnumber = Convert.ToInt32(txtCarnumber_PSC.Text);
                    int iditem = (cbVatLieu.SelectedItem as VatLieuDTO).Iditem;
                    string detail = txtNoiDungPSC.Text;
                    DateTime? createddate = dtpNgayTaoPSC.Value;
                    float dongia = (float)Convert.ToDouble(txtDonGiaPSC.Text);
                    float tiencong = (float)Convert.ToDouble(txtTienCongPSC.Text);
                    float totalprice = dongia + tiencong;
                    if (PhieuSuaChuaDAL.Instance.InsertPhieuSuaChua(carnumber, iditem, detail, createddate, dongia, tiencong, totalprice))
                    {
                        MessageBox.Show("Thêm phiếu sửa chữa thành công");
                        LoadListPSC();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vào phiếu lỗi");
                    }
                }
            }catch (Exception ex) { MessageBox.Show("Thêm vào phiếu lỗi" + ex.Message + "\n" + ex.StackTrace); }

        }

        private void btnXoaPSC_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDPSC.Text))
            {
                try
                {
                    int idpsc = Convert.ToInt32(txtIDPSC.Text);
                    if (PhieuSuaChuaDAL.Instance.DeletePhieuSuaChua(idpsc))
                    {
                        MessageBox.Show("Xóa phiếu sửa chữa thành công");
                        LoadListPSC();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu lỗi");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Xóa phiếu lỗi" + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnSuaPSC_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDPSC.Text) && CheckIntValue(txtCarnumber_PSC.Text) == true)
            {
                try
                {
                    int idpsc = Convert.ToInt32(txtIDPSC.Text);
                    int carnumber = Convert.ToInt32(txtCarnumber_PSC.Text);
                    int iditem = (cbVatLieu.SelectedItem as VatLieuDTO).Iditem;
                    string detail = txtNoiDungPSC.Text;
                    DateTime? createddate = dtpNgayTaoPSC.Value;
                    float dongia = (float)Convert.ToDouble(txtDonGiaPSC.Text);
                    float tiencong = (float)Convert.ToDouble(txtTienCongPSC.Text);
                    float totalprice = dongia + tiencong;
                    if (PhieuSuaChuaDAL.Instance.UpdatePhieuSuaChua(idpsc, carnumber, iditem, detail, createddate, dongia, tiencong, totalprice))
                    {
                        MessageBox.Show("Cập nhật phiếu sửa chữa thành công");
                        LoadListPSC();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật phiếu lỗi");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Cập nhật phiếu lỗi" + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnXemPSC_Click(object sender, EventArgs e)
        {
            LoadListPSC();
            LoadXe_PSC();
            LoadComboboxVatLieu(cbVatLieu);
        }

        private void btnTimXe_PSC_Click(object sender, EventArgs e)
        {
            dgvXe_PSC.DataSource = XeDAL.Instance.SearchXe(txtXe_PSC.Text);
            int currentRowindex = this.dgvXe_PSC.CurrentCellAddress.Y;
            if (-1 < currentRowindex && currentRowindex < dgvXe_PSC.RowCount)
            {
                XeDTO obj = (XeDTO)dgvXe_PSC.Rows[currentRowindex].DataBoundItem;
                this.txtCarnumber_PSC.Text = obj.Carnumber.ToString();
            }
        }

        private void txtIDPSC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPSC.SelectedCells.Count > 0)
                {
                    int iditem = (int)dgvPSC.SelectedCells[0].OwningRow.Cells["iditem"].Value;

                    VatLieuDTO kho = VatLieuDAL.Instance.GetListKhoById(iditem);
                    cbVatLieu.SelectedItem = kho;
                    int indexkho = -1;
                    int i2 = 0;

                    foreach (VatLieuDTO item in cbVatLieu.Items)
                    {
                        if (item.Iditem == kho.Iditem)
                        {
                            indexkho = i2;
                            break;
                        }
                        i2++;
                    }
                    cbVatLieu.SelectedIndex = indexkho;
                    
                }
            }
            catch { }
        }

        private void dgvXe_PSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvXe_PSC.CurrentCell.RowIndex;
            txtCarnumber_PSC.Text = dgvXe_PSC.Rows[t].Cells[0].Value.ToString();
        }

        private void dgvPSC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}