using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iShop.DAL;
using iShop.BLL;
using iShop.DTO;

namespace iShop.Presentation.DanhMuc
{
    public partial class frmNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void cboBoPhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmBoPhan f = new frmBoPhan();
                f.ShowDialog();
            }
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridNhanVien.ShowPrintPreview();
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if ((txtMaNhanVien != null && txtTenNhanVien != null) && cboBoPhan.Text != null)
                {
                    NhanVien n = new NhanVien();
                    n.ID = txtMaNhanVien.Text.Trim();
                    n.TenNhanVien = txtTenNhanVien.Text.Trim();
                    if (rdogGioiTinh.SelectedIndex == 0)
                    {
                        n.GioiTinh = ((bool)this.rdogGioiTinh.Properties.Items[0].Value);
                    }
                    else
                    {
                        n.GioiTinh = ((bool)this.rdogGioiTinh.Properties.Items[1].Value);
                    }
                    n.NgaySinh = DateTime.Parse(txtNgaySinh.Text.Trim());
                    n.SoDienThoai = txtSoDienThoai.Text.Trim();
                    n.Email = txtEmail.Text.Trim();
                    n.DiaChi = txtDiaChi.Text.Trim();
                    n.BoPhanID = cboBoPhan.GetColumnValue("ID").ToString();

                    NhanVienBLL nBLL = new NhanVienBLL();
                    nBLL.InsertNhanVien_BLL(n);

                    frmNhanVien_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Thêm thành công nhân viên \"" + txtTenNhanVien.Text + "\".";
                }
            }
            catch (Exception)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Thêm thất bại.";
                MessageBox.Show("Trường bắt buộc chưa có giá trị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lblStatus.Visible = false;

            //bibding cho BoPhan
            BoPhanBLL bpBLL = new BoPhanBLL();
            cboBoPhan.Properties.DisplayMember = "TenBoPhan";
            cboBoPhan.Properties.ValueMember = "ID";
            cboBoPhan.Properties.DataSource = bpBLL.SelectAllBoPhan_BLL();

            //Binding cho Grid
            NhanVienBLL nvBLL = new NhanVienBLL();
            gridNhanVien.DataSource = nvBLL.SelectNhanVienBLL();
        }

        //Double Click Grid
        private void gridNhanVien_DoubleClick(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = false;
            txtMaNhanVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcMaNhanVien).ToString();
            txtTenNhanVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcTenNhanVien).ToString();
            cboBoPhan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcBoPhan).ToString();
            txtSoDienThoai.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcSoDienThoai).ToString();
            txtNgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcNgaySinh).ToString();
            txtEmail.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcEmail).ToString();
            txtDiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcDiaChi).ToString();
            rdogGioiTinh.EditValue = bool.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcGioiTinh).ToString());
        }

        //Double Click Panel
        private void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            txtMaNhanVien.Enabled = true;
            txtMaNhanVien.Text = "";
            txtTenNhanVien.Text = "";
            cboBoPhan.Text = "";
            txtSoDienThoai.Text = "";
            txtNgaySinh.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            rdogGioiTinh.Name = "";
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string id = txtMaNhanVien.Text.Trim();


            try
            {
                if (txtMaNhanVien != null)
                {
                    HangHoaBLL hBLL = new HangHoaBLL();
                    if (MessageBox.Show("Bạn muốn xóa nhân viên \"" + txtTenNhanVien.Text + "\" ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        NhanVienBLL nvBLL = new NhanVienBLL();
                        nvBLL.DeteleNhanVien_BLL(id);
                        frmNhanVien_Load(sender, e);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Xoá thành công nhân viên \"" + txtTenNhanVien.Text + "\".";
                    }
                }
            }
            catch (Exception)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Xóa thất bại";
                MessageBox.Show("Xin chọn nhân viên cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            try
            {
                NhanVienDto nvDto = new NhanVienDto();
                nvDto.id = txtMaNhanVien.Text.Trim();
                nvDto.tenNhanVien = txtTenNhanVien.Text.Trim();
                nvDto.ngaySinh = DateTime.Parse(txtNgaySinh.Text.Trim());
                nvDto.soDienThoai = txtSoDienThoai.Text.Trim();
                nvDto.email = txtEmail.Text.Trim();
                nvDto.diaChi = txtDiaChi.Text.Trim();
                nvDto.boPhan = cboBoPhan.GetColumnValue("ID").ToString();
                nvDto.gioiTinh = Convert.ToBoolean(rdogGioiTinh.Text);

                NhanVienBLL nvBLL = new NhanVienBLL();
                nvBLL.UpdateNhanVien_BLL(nvDto);

                frmNhanVien_Load(sender, e);
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thành công.";
            }
            catch (Exception)
            {
                
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thất bại";
                MessageBox.Show("Chưa chọn nhân viên cập nhật.", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}