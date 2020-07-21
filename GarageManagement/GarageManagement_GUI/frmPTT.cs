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
using GarageManagement.GarageManagement_DTO;
using GarageManagement_DAL;
using System.IO;
using System.Diagnostics;
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace GarageManagement.GarageManagement_GUI
{
    public partial class frmPTT : DevExpress.XtraEditors.XtraForm
    {
        BindingSource pttList = new BindingSource();
   
        public frmPTT()
        {
            InitializeComponent();
            dgvPTT.DataSource = pttList;
            LoadListPTT();
            LoadXe_PTT();
            AddBindingPTT();
        }
        void LoadListPTT()
        {
            pttList.DataSource = PhieuThuTienDAL.Instance.GetListPhieuThuTien();
        }
        void LoadXe_PTT()
        {
            dgvXe_PTT.DataSource = XeDAL.Instance.GetListXe();
        }

        void AddBindingPTT()
        {
            txtIDPTT.DataBindings.Add(new Binding("Text", dgvPTT.DataSource, "idptt", true, DataSourceUpdateMode.Never));
            txtMaKH_PTT.DataBindings.Add(new Binding("Text", dgvPTT.DataSource, "idkhachhang", true, DataSourceUpdateMode.Never));
            txtBienSo_PTT.DataBindings.Add(new Binding("Text", dgvPTT.DataSource, "carnumber", true, DataSourceUpdateMode.Never));
            dtpNgayTao_PTT.DataBindings.Add(new Binding("Value", dgvPTT.DataSource, "createddate", true, DataSourceUpdateMode.Never));
            txtSoTienThu.DataBindings.Add(new Binding("Text", dgvPTT.DataSource, "sotienthu", true, DataSourceUpdateMode.Never));
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
        private void btnXemPhieuThuTien_Click(object sender, EventArgs e)
        {
            LoadListPTT();
            LoadXe_PTT();
        }


        private void btnTimKH_PTT_Click(object sender, EventArgs e)
        {
            dgvXe_PTT.DataSource = XeDAL.Instance.SearchXe(txtXe_PTT.Text);
            int currentRowindex = this.dgvXe_PTT.CurrentCellAddress.Y;
            if (-1 < currentRowindex && currentRowindex < dgvXe_PTT.RowCount)
            {
                XeDTO obj = (XeDTO)dgvXe_PTT.Rows[currentRowindex].DataBoundItem;
                this.txtMaKH_PTT.Text = obj.IdKH.ToString();
                this.txtBienSo_PTT.Text = obj.Carnumber.ToString();
            }
        }

        private void btnThemPhieuThuTien_Click(object sender, EventArgs e)
        {
            if ( CheckIntValue(txtMaKH_PTT.Text) && CheckIntValue(txtBienSo_PTT.Text))
            {
                try
                {

                    int idkhachhang = Convert.ToInt32(txtMaKH_PTT.Text);
                    int carnumber = Convert.ToInt32(txtBienSo_PTT.Text);
                    DateTime? createddate = dtpNgayTao_PTT.Value;
                    float sotienthu = (float)Convert.ToDouble(txtSoTienThu.Text);
                    if (PhieuThuTienDAL.Instance.InsertPhieuThuTien( idkhachhang, carnumber, createddate, sotienthu))
                    {
                        MessageBox.Show("Thêm vào phiếu thu tiền thành công");
                        LoadListPTT();
                    }
                    else
                    {
                        MessageBox.Show("Thêm vào phiếu lỗi !!");
                    }

                }
                catch (Exception ex) { MessageBox.Show("Thêm vào phiếu lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnXoaPhieuThuTien_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDPTT.Text))
            {
                try
                {
                    int idptt = Convert.ToInt32(txtIDPTT.Text);

                    if (PhieuThuTienDAL.Instance.DeletePhieuThuTien(idptt))
                    {
                        MessageBox.Show("Xóa phiếu thu tiền thành công");
                        LoadListPTT();
                    }
                    else
                    {
                        MessageBox.Show("Xóa phiếu lỗi !!");
                    }

                }
                catch (Exception ex) { MessageBox.Show("Xóa phiếu lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void btnSuaPhieuThuTien_Click(object sender, EventArgs e)
        {
            if (CheckIntValue(txtIDPTT.Text) && CheckIntValue(txtMaKH_PTT.Text) && CheckIntValue(txtBienSo_PTT.Text))
            {
                try
                {
                    int idptt = Convert.ToInt32(txtIDPTT.Text);
                    int idkhachhang = Convert.ToInt32(txtMaKH_PTT.Text);
                    int carnumber = Convert.ToInt32(txtBienSo_PTT.Text);
                    DateTime? createddate = dtpNgayTao_PTT.Value;
                    float sotienthu = (float)Convert.ToDouble(txtSoTienThu.Text);
                    if (PhieuThuTienDAL.Instance.UpdatePhieuThuTien(idptt, idkhachhang, carnumber, createddate, sotienthu))
                    {
                        MessageBox.Show("Sửa phiếu thu tiền thành công");
                        LoadListPTT();
                    }
                    else
                    {
                        MessageBox.Show("Sửa phiếu lỗi !!");
                    }

                }
                catch (Exception ex) { MessageBox.Show("Sửa phiếu lỗi !! " + ex.Message + "\n" + ex.StackTrace); }
            }
        }

        private void dgvXe_PTT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dgvXe_PTT.CurrentCell.RowIndex;
            txtBienSo_PTT.Text = dgvXe_PTT.Rows[t].Cells[0].Value.ToString();
            txtMaKH_PTT.Text = dgvXe_PTT.Rows[t].Cells[2].Value.ToString();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Xác nhận in báo cáo", "Notice", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // Khai báo file pdf
                PdfDocument newReportFile = new PdfDocument();
                PdfPage newReportPage = newReportFile.AddPage();
                XGraphics graph = XGraphics.FromPdfPage(newReportPage);
                XFont pageFont = new XFont("Arial", 25, XFontStyle.Regular, new XPdfFontOptions(PdfFontEncoding.Unicode));

                // Vẽ các thông tin cần thiết vào file pdf báo cáo
               
                graph.DrawString("------------ ", pageFont, XBrushes.Black, new XRect(0, 30, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("PHIẾU THU TIỀN", pageFont, XBrushes.Black, new XRect(0, 80, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Ngày in: " + DateTime.Today.ToString(), pageFont, XBrushes.Black, new XRect(0, 130, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Mã phiếu: " + this.txtIDPTT.Text.ToString(), pageFont, XBrushes.Black, new XRect(0, 180, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("------------ ", pageFont, XBrushes.Black, new XRect(0, 230, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter); 
                graph.DrawString("ID khách hàng: " + this.txtMaKH_PTT.Text.ToString(), pageFont, XBrushes.Black, new XRect(0, 280, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Tên khách hàng:........................................................." , pageFont, XBrushes.Black, new XRect(0, 330, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Số điện thoại:............................................................." , pageFont, XBrushes.Black, new XRect(0, 380, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Biển số xe: " + this.txtBienSo_PTT.Text.ToString()+"                                                         ", pageFont, XBrushes.Black, new XRect(0, 430, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("Chi tiết sửa chữa:.......................................................", pageFont, XBrushes.Black, new XRect(0,480, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("..................................................................................", pageFont, XBrushes.Black, new XRect(0,530, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("..................................................................................", pageFont, XBrushes.Black, new XRect(0, 580, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("                Tổng số tiền thanh toán: " + this.txtSoTienThu.Text.ToString() + " VNĐ", pageFont, XBrushes.Black, new XRect(0, 630, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("-------------", pageFont, XBrushes.Black, new XRect(0, 690, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);
                graph.DrawString("-- Hẹn gặp lại -- ", pageFont, XBrushes.Black, new XRect(0, 730, newReportPage.Width.Point, newReportPage.Height.Point), XStringFormats.TopCenter);

                string fileName = @"D:\Folder Hoá đơn\" + "Ngày  " + DateTime.Now.Day.ToString() + "." + DateTime.Now.Month.ToString() + "." + DateTime.Now.Year.ToString() + "." + DateTime.Now.Second.ToString() + ".pdf";

                CheckDirectory(); // Gọi hàm để check xem thư mục đã tồn tại hay chưa, nếu chưa thì ta tạo thư mục để lưu trữ

                newReportFile.Save(fileName);

                Process.Start(fileName);

            }

            else
            {
                return;
            }

        }
        
        private void CheckDirectory()
        {
            foreach (var drive in DriveInfo.GetDrives())
            {
                MessageBox.Show(drive.Name);

                if (drive.DriveType == DriveType.Fixed && string.Equals(drive.Name.ToLower(), @"C:\".ToLower()) == false)
                {
                    if (!Directory.Exists(drive.Name + @"Folder Hoá đơn\"))
                    {
                        Directory.CreateDirectory(drive.Name + @"Folder Hoá đơn\");

                        break;
                    }
                }
            }
        }
        private void frmPTT_Load(object sender, EventArgs e)
        {

       
        }


    }
}