using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iShop.BLL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;
using iShop.DAL;
using iShop.DTO;

namespace iShop.Presentation.DanhMuc
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        //Form load
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;

            KhachHangBLL k = new KhachHangBLL();
            gridKhachHang.DataSource = k.SelectAllKhachHangBLL();
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnXem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmKhachHang_Load(null,null);
        }

        private void bbtnDong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KhachHang k = new KhachHang();
                KhachHangBLL kh = new KhachHangBLL();
                k.ID = txtMaKhachHang.Text.Trim();
                k.TenKhachHang = txtTenKhachHang.Text.Trim();
                k.SoDienThoai = txtSoDienThoai.Text.Trim();
                k.DiaChi = txtDiaChi.Text.Trim();
                k.Email = txtEmail.Text.Trim();
                k.GhiChu = txtGhiChu.Text.Trim();

                kh.InsertKhachHangBLL(k);
                frmKhachHang_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thành công khách hàng: \"" + txtTenKhachHang.Text + "\"."; 
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại."; 
                XtraMessageBox.Show("Lỗi: " + ex);
            }
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString();
                //string name = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKhachHang").ToString();
                string id = txtMaKhachHang.Text.Trim();
                string name = txtTenKhachHang.Text.Trim();
                KhachHangBLL k = new KhachHangBLL();
                if (XtraMessageBox.Show("Bạn muốn xóa khách hàng: \"" + name + "\" ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    k.DeleteKhachHangBLL(id);
                    frmKhachHang_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Xóa thành công khách hàng \"" + txtTenKhachHang.Text + "\"";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Xóa thất bại."; 
                XtraMessageBox.Show("Lỗi: " + ex);
            }           
        }


        private void bbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                KhachHangDto k = new KhachHangDto();
                k.id = txtMaKhachHang.Text;
                k.tenKhachHang = txtTenKhachHang.Text;
                k.soDienThoai = txtSoDienThoai.Text;
                k.email = txtEmail.Text;
                k.diaChi = txtDiaChi.Text;
                k.ghiChu = txtGhiChu.Text;

                KhachHangBLL khBLL = new KhachHangBLL();
                khBLL.UpdateKhachHangBLL(k);
                frmKhachHang_Load(sender, e);
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thành công.";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thất bại."; 
                XtraMessageBox.Show("Lỗi: " + ex);
            }
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridKhachHang.ShowPrintPreview();
        }

        //Binding len grid
        private void gridKhachHang_DoubleClick(object sender, EventArgs e)
        {
            txtMaKhachHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcMaKhachHang).ToString();
            txtTenKhachHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gColumn_Ten).ToString();
            txtSoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gColumn_SDT).ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gColumn_Email).ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gColumn_DiaChi).ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gColumn_GhiChu).ToString();
            txtMaKhachHang.Enabled = false;
        }

        //Tra focus lai cho o MaKhachHang
        private void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            txtMaKhachHang.Enabled = true;
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtGhiChu.Text = "";
        }

    }
}