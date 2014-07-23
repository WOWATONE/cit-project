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
    public partial class frmDonViTinh : DevExpress.XtraEditors.XtraForm
    {
        public frmDonViTinh()
        {
            InitializeComponent();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmDonViTinh_Load(object sender, EventArgs e)
        {
            DonViTinhBLL dvBLL = new DonViTinhBLL();
            lblStatus.Visible = false;      
            gridDonViTinh.DataSource = dvBLL.SelectAll_DVT_BLL();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //In-xuat
            gridDonViTinh.ShowPrintPreview();
        }

        private void bbThemDVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                DonViTinhBLL dvBLL = new DonViTinhBLL();
                DonViTinh dvt = new DonViTinh();
                dvt.ID = txtMaDVT.Text.Trim();
                dvt.TenDonViTinh = txtTenDVT.Text.Trim();
                dvt.GhiChu = txtGhiChu.Text.Trim();

                dvBLL.InsertDVT_BLL(dvt);
                
                frmDonViTinh_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thành công Đơn vị tính: \"" + dvt.TenDonViTinh + "\".";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }

        private void bbtnXoaDVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonViTinhBLL dvBLL = new DonViTinhBLL();
            try
            {
                if ((txtMaDVT.Text != null) || (txtTenDVT.Text != null))
                {
                    string id = txtMaDVT.Text.Trim();
                    if (MessageBox.Show("Bạn có muốn xóa đơn vị tính: " + txtTenDVT.Text + " ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        dvBLL.DeleteDVT_BLL(id);

                        frmDonViTinh_Load(sender, e);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Xóa thành công Đơn vị tính: \"" + txtTenDVT.Text + "\".";
                    }
                }
                
            }
            catch (Exception)
            {
                
                lblStatus.Visible = true;
                lblStatus.Text = "Xóa thất bại.";
                MessageBox.Show("Mã đơn vị tính và Tên đơn vị tính bị trùng hoặc chưa có giá trị.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gridDonViTinh_DoubleClick(object sender, EventArgs e)
        {
            txtMaDVT.Enabled = false;
            txtMaDVT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcMaNHH).ToString();
            txtTenDVT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcTenNHH).ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcGhiChu).ToString();
        }


        private void bbtnSuaDVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DonViTinhBLL dvBLL = new DonViTinhBLL();
            string id = txtMaDVT.Text.Trim();
            string ten = txtTenDVT.Text.Trim();
            string ghichu = txtGhiChu.Text.Trim();
            try
            {
                dvBLL.UpdateDVT_BLL(id,ten,ghichu);
                frmDonViTinh_Load(sender,e);
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

        private void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            txtMaDVT.Enabled = true;
            txtMaDVT.Text = "";
            txtTenDVT.Text = "";
            txtGhiChu.Text = "";
        }
    }
}