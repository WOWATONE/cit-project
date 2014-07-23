using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iShop.BLL;
using iShop.DAL;

namespace iShop.Presentation.DanhMuc
{
    public partial class frmBoPhan : Form
    {
        public frmBoPhan()
        {
            InitializeComponent();
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            BoPhanBLL bpBLL = new BoPhanBLL();
            lblStatus.Visible = false;
            gridBoPhan.DataSource = bpBLL.SelectAllBoPhan_BLL();
        }

        private void gridBoPhan_DoubleClick(object sender, EventArgs e)
        {
            txtMaBoPhan.Enabled = false;
            txtMaBoPhan.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcMaBoPhan).ToString();
            txtTenBoPhan.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,gcTenBoPhan).ToString();
            txtGhiChu.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcGhiChu).ToString();
        }

        private void groupControl2_DoubleClick(object sender, EventArgs e)
        {
            txtMaBoPhan.Enabled = true;
            txtMaBoPhan.Text = "";
            txtTenBoPhan.Text = "";
            txtGhiChu.Text = "";
        }

        private void bbtnInBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridBoPhan.ShowPrintPreview();
        }

        private void bbtnThemBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                BoPhanBLL bpBLL = new BoPhanBLL();
                BoPhan bp = new BoPhan();
                bp.ID = txtMaBoPhan.Text.Trim();
                bp.TenBoPhan = txtTenBoPhan.Text.Trim();
                bp.GhiChu = txtGhiChu.Text.Trim();

                bpBLL.InsertBoPhan_BLL(bp);
                frmBoPhan_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thành công bộ phận: "+bp.TenBoPhan+".";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }

        private void bbtnBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string id = txtMaBoPhan.Text.Trim();
                string ten = txtTenBoPhan.Text.Trim();
                string ghichu = txtGhiChu.Text.Trim();

                BoPhanBLL bpBLL = new BoPhanBLL();
                bpBLL.UpdateBoPhan_BLL(id,ten,ghichu);
                frmBoPhan_Load(sender, e);
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thành công.";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }

        private void bbtnXoaBP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string id = txtMaBoPhan.Text.Trim();
                if (MessageBox.Show("Bạn muốn xóa bộ phận \""+txtTenBoPhan.Text+"\" ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    BoPhanBLL bpBLL = new BoPhanBLL();
                    bpBLL.DeleteBoPhan_BLL(id);
                    frmBoPhan_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Xóa thành công bộ phận: \"" + txtTenBoPhan.Text + "\".";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Xóa thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }
    }
}
