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
using GarageManagement_DTO;
using GarageManagement_DAL;
using GarageManagement.GarageManagement_DAL;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmXe : DevExpress.XtraEditors.XtraForm
    {
        BindingSource xeList = new BindingSource();
        public frmXe()
        {
            InitializeComponent();
            dgvXe.DataSource = xeList;
            LoadListXe();
            AddBindingXe();
            LoadKH_Xe();

        }

        void LoadListXe()
        {
            xeList.DataSource = XeDAL.Instance.GetListXe();
        }

        void LoadKH_Xe()
        {
            dgvKH_Xe.DataSource = KhachHangDAL.Instance.GetListKhachHang();
        }
        void AddBindingXe()
        {
            txtMaXe.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "carnumber", true, DataSourceUpdateMode.Never));
            txtHieuXe.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "carbrand", true, DataSourceUpdateMode.Never));
            txtIDKH_XE.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "idkh", true, DataSourceUpdateMode.Never));
            txtStatus.DataBindings.Add(new Binding("Text", dgvXe.DataSource, "status", true, DataSourceUpdateMode.Never));
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

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtMaXe.Text) == true)
            {
                try
                {
                    int maxe = Convert.ToInt32(txtMaXe.Text);
                    string hieuxe = txtHieuXe.Text;
                    int idkh = Convert.ToInt32(txtIDKH_XE.Text);
                    string status = txtStatus.Text;
                    if (XeDAL.Instance.InsertXe(maxe, hieuxe, idkh, status))
                    {
                        MessageBox.Show("Thêm xe thành công");
                        LoadListXe();

                    }
                    else
                    {
                        MessageBox.Show("Thêm xe lỗi !!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Thêm xe lỗi !!  " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnXoaXe_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtMaXe.Text) == true)
            {
                try
                {
                    int maxe = Convert.ToInt32(txtMaXe.Text);
                    if (XeDAL.Instance.DeleteXe(maxe))
                    {
                        MessageBox.Show("Xóa xe thành công");
                        LoadListXe();

                    }
                    else
                    {
                        MessageBox.Show("xóa xe lỗi !!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("xóa xe lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btxSuaXe_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtMaXe.Text) == true)
            {
                try
                {
                    int maxe = Convert.ToInt32(txtMaXe.Text);
                    string hieuxe = txtHieuXe.Text;
                    int idkh = Convert.ToInt32(txtIDKH_XE.Text);
                    string status = txtStatus.Text;
                    if (XeDAL.Instance.UpdateXe(hieuxe, maxe, idkh, status))
                    {
                        MessageBox.Show("Cập nhật xe thành công");
                        LoadListXe();

                    }
                    else
                    {
                        MessageBox.Show("Cập nhật xe lỗi !!");
                    }
                }
                catch (Exception ex) { MessageBox.Show("Cập nhật xe lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
         }

        List<KhachHangDTO> SearchKhachHang(string text)
        {
            List<KhachHangDTO> list = KhachHangDAL.Instance.SearchKhachHangByNameAndID(text);
            return list;
        }
        private void btnTimKH_Xe_Click(object sender, EventArgs e)
        {
            dgvKH_Xe.DataSource = SearchKhachHang(txtTimKH_Xe.Text);
            int currentRowindex = this.dgvKH_Xe.CurrentCellAddress.Y;
            if (-1 < currentRowindex && currentRowindex < dgvKH_Xe.RowCount)
            {
                KhachHangDTO obj = (KhachHangDTO)dgvKH_Xe.Rows[currentRowindex].DataBoundItem;
                this.txtIDKH_XE.Text = obj.Id.ToString();
            }
        }

        private void btnXemXe_Click(object sender, EventArgs e)
        {
            LoadListXe();
            LoadKH_Xe();
        }

        private void dgvKH_Xe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvKH_Xe.CurrentCell.RowIndex;
            txtIDKH_XE.Text = dgvKH_Xe.Rows[t].Cells[0].Value.ToString();
        }
    }
}