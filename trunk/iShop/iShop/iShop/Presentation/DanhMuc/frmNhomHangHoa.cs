using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iShop.BLL;
using iShop.DAL;

namespace iShop.Presentation.DanhMuc
{
    public partial class frmNhomHangHoa : DevExpress.XtraEditors.XtraForm
    {
        //NhomHangHoaBLL nBLL = new NhomHangHoaBLL();
        //NhomHangHoa nhom = new NhomHangHoa();

        public frmNhomHangHoa()
        {
            InitializeComponent();
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnInNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNhomHangHoa.ShowPrintPreview();
        }

        private void frmNhomHangHoa_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;
            NhomHangHoaBLL nBLL = new NhomHangHoaBLL();
            gridNhomHangHoa.DataSource = nBLL.SelectNhomHH_BLL();
        }

        private void bbtnThemNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhomHangHoa nhom = new NhomHangHoa();
            NhomHangHoaBLL nBLL = new NhomHangHoaBLL();
            try
            {
                nhom.ID = txtMaNhomHH.Text.Trim();
                nhom.TenNhomHang = txtTenNhomHH.Text.Trim();
                nhom.GhiChu = txtGhiChuNHH.Text.Trim();

                nBLL.InsertNhomHH_BLL(nhom);
                frmNhomHangHoa_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thành công nhóm hàng: "+nhom.TenNhomHang+".";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }

        private void gridNhomHangHoa_DoubleClick(object sender, EventArgs e)
        {
            txtMaNhomHH.Enabled = false;
            txtMaNhomHH.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcMaNhomHH).ToString();
            txtTenNhomHH.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,gcTenNhomHH).ToString();
            txtGhiChuNHH.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcGhiChuNHH).ToString();
        }

        private void groupControl2_DoubleClick(object sender, EventArgs e)
        {
            txtMaNhomHH.Enabled = true;
            txtMaNhomHH.Text = "";
            txtTenNhomHH.Text = "";
            txtGhiChuNHH.Text = "";
        }

        private void bbtnSuaNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = txtMaNhomHH.Text.Trim();
            string ten = txtTenNhomHH.Text.Trim();
            string ghichu = txtGhiChuNHH.Text.Trim();
            try
            {
                NhomHangHoaBLL nBLL = new NhomHangHoaBLL();
                nBLL.UpdateNhomHH_BLL(id,ten,ghichu);
                frmNhomHangHoa_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thành công.";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thất bại.";
                MessageBox.Show("Lỗi: " + ex);
            }
        }

        private void bbtnXoaNhom_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn muốn xóa nhóm hàng hóa: "+txtMaNhomHH.Text+" ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    NhomHangHoaBLL nBLL = new NhomHangHoaBLL();
                    nBLL.DeleteNhomHH_BLL(txtMaNhomHH.Text.Trim());
                    frmNhomHangHoa_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Xóa thành công nhóm hàng: " + txtTenNhomHH.Text + ".";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Xóa thất bại.";
                MessageBox.Show("Lỗi: " + ex);
            }
        }
    }
}