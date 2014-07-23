using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.Data.Access;
using System.Data.SqlClient;
using iShop.BLL;
using iShop.DAL;
using iShop.DTO;

namespace iShop.Presentation.DanhMuc

{
    public partial class frmNhaCungCap : DevExpress.XtraEditors.XtraForm
    {
        //Ham load Form
        public void LoadForm()
        {
            lblStatus.Visible = false;
            NhaCungCapBLL nn = new NhaCungCapBLL();
            gridNhaCungCap.DataSource = nn.SelectAll_NCC_Bll();
        }

        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNhaCungCap.ShowPrintPreview();
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                NhaCungCap n = new NhaCungCap();
                n.ID = txtMaNCC.Text.Trim();
                n.TenNhaCungCap = txtTenNCC.Text.Trim();
                n.SoDienThoai = txtSoDienThoai.Text.Trim();
                n.Email = txtEmail.Text.Trim();
                n.DiaChi = txtDiaChi.Text.Trim();
                n.NguoiDaiDien = txtEmail.Text.Trim();
                n.SoTaiKhoan = txtSoTaiKhoan.Text.Trim();
                n.NganHang = txtNganHang.Text.Trim();
                n.GhiChu = txtGhiChu.Text.Trim();

                NhaCungCapBLL nBLL = new NhaCungCapBLL();
                nBLL.InsertNCC_BLL(n);
                frmNhaCungCap_Load(sender,e);
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thành công Nhà sản xuất \""+txtTenNCC.Text+"\"";
            }
            catch (Exception ex)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại.";
                MessageBox.Show("Lỗi: "+ex);
            }
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string id = txtMaNCC.Text.Trim();
                string name = txtTenNCC.Text.Trim();
                NhaCungCapBLL ncc = new NhaCungCapBLL();
                if (MessageBox.Show("Bạn muốn xóa nhà cung cấp \"" + name + "\" ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ncc.DeleteNCC_BLL(id);
                    frmNhaCungCap_Load(sender,e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Xóa thành công Nhà sản xuất \"" + name + "\".";
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Xóa thất bại.";
                MessageBox.Show("Lỗi: "+ ex);
            }
        }

        private void gridNhaCungCap_DoubleClick(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            txtMaNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcMaNCC).ToString();
            txtTenNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcTenNCC).ToString();
            txtSoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcSDT).ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcEmail).ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcDiaChi).ToString();
            txtSoTaiKhoan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcSoTaiKhoan).ToString();
            txtNganHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcNganHang).ToString();
            txtNguoiDaiDien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcNguoiDaiDien).ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcGhiChu).ToString();
        }

        private void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtSoDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            txtSoTaiKhoan.Text = "";
            txtNganHang.Text = "";
            txtNguoiDaiDien.Text = "";
            txtGhiChu.Text = "";
        }

        private void bbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            NhaCungCapDto nDto = new NhaCungCapDto();
            nDto.id = txtMaNCC.Text.Trim();
            nDto.tenNhaCungCap = txtTenNCC.Text.Trim();
            nDto.soDienThoai = txtSoDienThoai.Text.Trim();
            nDto.email = txtEmail.Text.Trim();
            nDto.diaChi = txtDiaChi.Text.Trim();
            nDto.soTaiKhoan = txtSoTaiKhoan.Text.Trim();
            nDto.nganHang = txtNganHang.Text.Trim();
            nDto.nguoiDaiDien = txtNguoiDaiDien.Text.Trim();
            nDto.ghiChu = txtGhiChu.Text.Trim();

            try
            {
                NhaCungCapBLL ncc = new NhaCungCapBLL();
                ncc.UpdateNCC_BLL(nDto);
                frmNhaCungCap_Load(sender,e);
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
    }
}