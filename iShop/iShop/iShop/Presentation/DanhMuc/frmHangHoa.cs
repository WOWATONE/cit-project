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
using iShop.DTO;
using DevExpress.XtraEditors;

namespace iShop.Presentation.DanhMuc
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa()
        {
            InitializeComponent();
        }

        private void LoadForm()
        {
            lblStatus.Visible = false;
            
            //Binding cho cboNhomHang
            NhomHangHoaBLL nh = new NhomHangHoaBLL();
            cboNhomHang.Properties.DisplayMember = "TenNhomHang";
            cboNhomHang.Properties.ValueMember = "ID";
            cboNhomHang.Properties.DataSource = nh.SelectNhomHH_BLL();

            //Binding cho cboDonViTinh
            DonViTinhBLL dv = new DonViTinhBLL();
            cboDonViTinh.Properties.DisplayMember = "TenDonViTinh";
            cboDonViTinh.Properties.ValueMember = "ID";
            cboDonViTinh.Properties.DataSource = dv.SelectAll_DVT_BLL();

            //Binding cho Grid
            HangHoaBLL hBLL = new HangHoaBLL();
            gridHangHoa.DataSource = hBLL.SelectAllHangHoa_BLL();
            
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void cboDonViTinh_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmDonViTinh f = new frmDonViTinh();
                f.ShowDialog();
            }
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridHangHoa.ShowPrintPreview();
        }

        private void cboNhomHang_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Kind == DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)
            {
                frmNhomHangHoa f = new frmNhomHangHoa();
                f.ShowDialog();
            }
        }

        private void bbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool kt = true;
                #region KIEM TRA NULL
                    if (txtMaHangHoa.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa nhập Mã mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                    if (txtTenHangHoa.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa nhập Tên mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                    if (cboDonViTinh.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa chọn Đơn vị tính.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                    //if (txtSoLuong.Text == "")
                    //{
                    //    kt = false;
                    //    XtraMessageBox.Show("Bạn chưa nhập Số lượng mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    lblStatus.Visible = true;
                    //    lblStatus.Text = "Thêm thất bại";
                    //}
                    if (cboNhomHang.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa chọn Nhóm mặt hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                    if (txtDonGiaNhap.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa nhập Đơn giá nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                    if (txtDonGiaBan.Text == "")
                    {
                        kt = false;
                        XtraMessageBox.Show("Bạn chưa nhập Đơn giá bán.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Thêm thất bại";
                    }
                #endregion

                if (kt)
                {
                    HangHoa h = new HangHoa();
                    h.ID = txtMaHangHoa.Text.Trim();
                    h.TenHangHoa = txtTenHangHoa.Text.Trim();
                    h.DonViTinhID = cboDonViTinh.GetColumnValue("ID").ToString();
                    h.NhomHangHoaID = cboNhomHang.GetColumnValue("ID").ToString();
                    h.DonGiaNhap = Convert.ToDouble(txtDonGiaNhap.Text.Trim());
                    h.DonGiaBan = Convert.ToDouble(txtDonGiaBan.Text.Trim());
                    h.SoLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                    h.KichCo = txtKichCo.Text.Trim();
                    h.ChatLieu = txtChatLieu.Text.Trim();
                    h.MauSac = txtMauSac.Text.Trim();
                    h.XuatXu = txtXuatXu.Text.Trim();
                    h.GhiChu = txtGhiChu.Text.Trim();

                    HangHoaBLL hBLL = new HangHoaBLL();
                    hBLL.InsertHangHoa_BLL(h);

                    frmHangHoa_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Thêm thành công mặt hàng \"" + h.TenHangHoa + "\".";
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi: \n"+ex.Message);
            }
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool kt = true;
                if (txtMaHangHoa.Text == "")
                {
                    kt = false;
                    XtraMessageBox.Show("Bạn chưa chọn mặt hàng cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Xóa thất bại";
                }
                if (kt)
                {
                    HangHoaBLL hBLL = new HangHoaBLL();
                    if (XtraMessageBox.Show("Bạn muốn xóa mặt hàng \"" + txtTenHangHoa.Text + "\" ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        hBLL.DeleteHangHoa_BLL(txtMaHangHoa.Text.Trim());

                        frmHangHoa_Load(sender, e);
                        lblStatus.Visible = true;
                        lblStatus.Text = "Xoá thành công mặt hàng \"" + txtTenHangHoa.Text + "\".";
                    }
                }
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi: \n"+ex.Message);
            }
        }

        private void gridHangHoa_DoubleClick(object sender, EventArgs e)
        {
            txtMaHangHoa.Enabled = false;
            txtMaHangHoa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcMaHangHoa).ToString();
            txtTenHangHoa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcTenHangHoa).ToString();
            cboDonViTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcDonViTinh).ToString();
            cboDonViTinh.ClosePopup();
            cboNhomHang.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcNhomHangHoa).ToString();
            cboNhomHang.ClosePopup();
            txtDonGiaNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcDonGiaNhap).ToString();
            txtDonGiaBan.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcDonGiaBan).ToString();
            txtSoLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcSoLuong).ToString();
            txtKichCo.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcKichCo).ToString();
            txtMauSac.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcMauSac).ToString();
            txtXuatXu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcXuatXu).ToString();
            txtChatLieu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcChatLieu).ToString();
            txtGhiChu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gcGhiChu).ToString();
        }

        private void bbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                bool kt = true;
                if (txtMaHangHoa.Text == "")
                {
                    kt = false;
                    XtraMessageBox.Show("Bạn chưa chọn mặt hàng cần cập nhật.","Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Cập nhật thất bại";
                }
                if (kt)
                {
                    HangHoaDto hDto = new HangHoaDto();
                    hDto.id = txtMaHangHoa.Text.Trim();
                    hDto.tenHangHoa = txtTenHangHoa.Text.Trim();
                    hDto.donViTinh = cboDonViTinh.GetColumnValue("ID").ToString();
                    hDto.nhomHangHoa = cboNhomHang.GetColumnValue("ID").ToString();
                    hDto.donGiaNhap = Convert.ToDouble(txtDonGiaNhap.Text.Trim());
                    hDto.donGiaBan = Convert.ToDouble(txtDonGiaBan.Text.Trim());
                    hDto.soLuong = Convert.ToInt32(txtSoLuong.Text.Trim());
                    hDto.kichCo = txtKichCo.Text.Trim();
                    hDto.chatLieu = txtChatLieu.Text.Trim();
                    hDto.mauSac = txtMauSac.Text.Trim();
                    hDto.xuatXu = txtXuatXu.Text.Trim();
                    hDto.ghiChu = txtGhiChu.Text.Trim();

                    HangHoaBLL hBLL = new HangHoaBLL();
                    hBLL.UpdateHangHoa_BLL(hDto);

                    frmHangHoa_Load(sender, e);
                    lblStatus.Visible = true;
                    lblStatus.Text = "Cập nhật thành công.";
                }
            }
            catch (Exception)
            {
                lblStatus.Visible = true;
                lblStatus.Text = "Cập nhật thất bại";
                XtraMessageBox.Show("Xin chọn mặt hàng cần cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //DUA CAC CONTROL VE NULL
        private void groupControl1_DoubleClick(object sender, EventArgs e)
        {
            txtMaHangHoa.Enabled = true;
            txtMaHangHoa.Text = "";
            txtTenHangHoa.Text = "";
            cboDonViTinh.Text = "";
            cboNhomHang.Text = "";
            txtDonGiaNhap.Text = "";
            txtDonGiaBan.Text = "";
            txtSoLuong.Text = "";
            txtKichCo.Text = "";
            txtMauSac.Text = "";
            txtXuatXu.Text = "";
            txtChatLieu.Text = "";
            txtGhiChu.Text = "";
        }
    }
}
