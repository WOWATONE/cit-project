using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iShop.BLL;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;
using DevExpress.ExpressApp.Win.Editors;
using iShop.DAL;
using iShop.Presentation.DanhMuc;

namespace iShop.Presentation.ChucNang
{
    public partial class frmBanHang : Form
    {
        DataTable dt = new DataTable();

        public frmBanHang()
        {
            InitializeComponent();
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("ID");
            dt.Columns.Add("TenHangHoa");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DonGia");
            dt.Columns.Add("TongTien");


            HangHoaBLL hhBLL = new HangHoaBLL();
            KhachHangBLL khBLL = new KhachHangBLL();
            NhanVienBLL nvBLL = new NhanVienBLL();

            //bibinding cho TenHang
            txtTenHang.Properties.DisplayMember = "TenHangHoa";
            txtTenHang.Properties.ValueMember = "ID";
            txtTenHang.Properties.DataSource = hhBLL.SelectAllHangHoa_BLL();

            //binding cho TenKhachHang
            txtTenKhachHang.Properties.DisplayMember = "TenKhachHang";
            txtTenKhachHang.Properties.ValueMember = "ID";
            txtTenKhachHang.Properties.DataSource = khBLL.SelectAllKhachHangBLL();

            //binding cho NhanVien
            txtNhanVien.Properties.DataSource = nvBLL.SelectNhanVienBLL();
            txtNhanVien.Properties.DisplayMember = "TenNhanVien";
            txtNhanVien.Properties.ValueMember = "ID";
        }

        private void txtTenHang_EditValueChanged(object sender, EventArgs e)
        {
            HangHoaBLL hhBLL = new HangHoaBLL();
            txtSoLuong.Text = "1";
            string tenHang = txtTenHang.Text;
            HangHoaBLL hh = new HangHoaBLL();
            txtDonGia.Text = Convert.ToString(hh.SelectDonGiaByTenHangHoa_BLL(tenHang));
            //txtDonViTinh.Text = Convert.ToString(hh.SelectDVTByTenHang_BLL(tenHang.Trim()));
            txtMaHang.Text = Convert.ToString(hhBLL.SelectIDByTenHang_BLL(tenHang));

            //Binding SoLuongTon
            txtSoLuongTon.Text = Convert.ToString(hhBLL.SelectSoLuongTonByTenHH_BLL(tenHang));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMaHang.Text;
            string ten = txtTenHang.Text;
            string soluong = txtSoLuong.Text;
            string dongia = txtDonGia.Text;
            string tongtien = txtTongTien.Text;


            int kt = 0;
            #region KTRA Ten, DVTinh, SoLuong co NULL hay ko
                if (ten == "")
                {
                    XtraMessageBox.Show("Chưa chọn tên mặt hàng cần bán.", "Thông báo");
                    kt = 1;
                }
                if (soluong == "")
                {
                    kt = 1;
                    XtraMessageBox.Show("Chưa nhập số lượng cần bán.", "Thông báo");
                }
            #endregion

                #region KIEM TRA CON HANG KO
                int sl = Convert.ToInt32(txtSoLuong.Text);
                int slton = Convert.ToInt32(txtSoLuongTon.Text);
                
                    if (slton == 0)
                    {
                        XtraMessageBox.Show("Mặt hàng đã hết, xin nhập thêm.", "Thông báo");
                        kt = 1;
                    }
                    if (sl > slton)
                    {
                        XtraMessageBox.Show("Số lượng bán phải nhỏ hơn hoặc bằng số lượng tồn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        kt = 1;
                    }
                    
                #endregion

                //Kiem tra mat hang da ton tai.
            #region KTRA MAT HANG DA TON TAI
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    string hanghoa = gridView2.GetRowCellValue(i, gcTenHangHD).ToString();
                    if (txtTenHang.Text == hanghoa)
                    {
                        kt = 1;
                        XtraMessageBox.Show("Đã có mặt hàng \"" + txtTenHang.Text + "\" trong hóa đơn.");
                    }
                    else
                    {
                        kt = 0;
                    }
                }
            #endregion
            

            #region KIEM TRA SOLUONG > 0
                if (Convert.ToInt32(soluong) == 0)
                {
                    kt = 1;
                    XtraMessageBox.Show("Số lượng mặt hàng cần bán phải lớn hơn 0.");
                }
            #endregion

            if (kt == 0)
            {
                DataRow dr;
                HangHoaBLL hh = new HangHoaBLL();
                dr = dt.NewRow();
                dr.BeginEdit();
                dr["ID"] = ma;
                dr["TenHangHoa"] = ten;
                dr["SoLuong"] = soluong;
                dr["DonGia"] = dongia;
                dr["TongTien"] = tongtien;
                dr.EndEdit();
                dt.Rows.Add(dr);

                //Gan vao Grid
                gridHoaDonBan.DataSource = dt;
            }

            #region TU DONG TINH TIEN HANG
                double tien = 0;
                for (int i = 0; i < gridView2.RowCount; i++)
                {
                    tien = tien + Convert.ToDouble(gridView2.GetRowCellValue(i, gcTongTienHD).ToString());
                }
                txtTienHang.Text = Convert.ToString(tien);
            #endregion
            
        }

        private void bbtnDong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void txtTenHang_BindingContextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            txtDonGia.Text = null;
            txtTongTien.Text = null;
        }

        private void txtSoLuong_Click(object sender, EventArgs e)
        {
            try
            {
                 txtTongTien.Text = Convert.ToString(Convert.ToDouble(txtDonGia.Text) * Convert.ToInt32(txtSoLuong.Text));
            }
            catch (Exception ex)
            {

                XtraMessageBox.Show("Lỗi: \n"+ex.Message);
            }
        }

        private void txtDonGia_EditValueChanged(object sender, EventArgs e)
        {
            txtTongTien.Text = txtDonGia.Text;
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridHoaDonBan.ShowPrintPreview();
        }

        //btn Tạo mới hóa đơn
        private void bbtnTaoMoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            txtTenHang.ClosePopup();
            txtSoLuong.Text = "";
            txtDonGia.Text = "";
            txtSoLuongTon.Text = "";
            txtMaHang.Text = "";
            txtTongTien.Text = "";
            gridHoaDonBan.DataSource = null;
            txtMaHoaDon.Text = "";
            txtTenKhachHang.ClosePopup();
            txtNhanVien.ClosePopup();
            txtNgay.Text = "";
            txtGhiChu.Text = "";
            txtTienHang.Text = "";
            txtChietKhau_Percent.Text = "";
            txtChietKhau.Text = "";
            txtTongCong.Text = "";
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            #region KIEM TRA NULL
            if (txtTenKhachHang.Text == "")
            {
                XtraMessageBox.Show("Chưa chọn tên khách hàng mua.", "Thông báo");
            }
            if (txtNhanVien.Text == "")
            {
                XtraMessageBox.Show("Chưa có nhân viên bán.", "Thông báo");
            }
            if (txtNgay.Text == "")
            {
                XtraMessageBox.Show("Chưa có ngày lập hóa đơn.", "Thông báo");
            }
            #endregion

            try
            {
                HoaDonBanBLL hdBLL = new HoaDonBanBLL();
                HoaDonBan hdb = new HoaDonBan();
                
                hdb.ID = txtMaHoaDon.Text;
                hdb.NgayLap = Convert.ToDateTime(txtNgay.Text.Trim());
                if (txtChietKhau.Text.Trim() == "")
                {
                    hdb.ChietKhau = 0;
                }
                else 
                {
                    hdb.ChietKhau = Convert.ToDouble(txtChietKhau.Text);
                }
                
                hdb.TongTien = Convert.ToDouble(txtTongCong.Text.Trim());
                hdb.KhachHangID = txtTenKhachHang.GetColumnValue("ID").ToString();
                hdb.NhanVienID = txtNhanVien.GetColumnValue("ID").ToString();
                hdb.GhiChu = txtGhiChu.Text.Trim();
                hdBLL.InsertHoaDonBan_BLL(hdb);
                for (int i = 0; i < gridView2.RowCount;i++ )
                {
                    HoaDonBanBLL hd = new HoaDonBanBLL();
                    ChiTietHoaDon ct = new ChiTietHoaDon();
                    ct.SoLuong = Convert.ToInt32(gridView2.GetRowCellValue(i,gcSoLuongHD).ToString());
                    ct.HoaDonBanID = hdb.ID;
                    ct.HangHoaID = gridView2.GetRowCellValue(i,gcMaHang).ToString();
                    hd.InsertChiTietHoaDon_BLL(ct);

                    //Cap nhat lai SoLuongTon
                    hd.UpdateSoLuongTon_BLL(ct);
                }
                
                XtraMessageBox.Show("Đã bán hàng thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: " + ex);
            }
        }

        private void txtChietKhau_Percent_EditValueChanged(object sender, EventArgs e)
        {
            double per = Convert.ToDouble(txtChietKhau_Percent.Text);
            txtChietKhau.Text = Convert.ToString((per / 100) * Convert.ToDouble(txtTienHang.Text));
            txtTongCong.Text = Convert.ToString(Convert.ToDouble(txtTienHang.Text) - (Convert.ToDouble(txtChietKhau.Text)));
        }

        private void gridHoaDonBan_DoubleClick(object sender, EventArgs e)
        {
            txtMaHang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,gcMaHang).ToString();
            txtTenHang.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle,gcTenHangHD).ToString();
            txtTenHang.ClosePopup();
            txtSoLuong.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcSoLuongHD).ToString();
            txtDonGia.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcDonGiaHD).ToString();
            txtTongTien.Text = gridView2.GetRowCellValue(gridView2.FocusedRowHandle, gcTongTienHD).ToString();
        }

        private void btnReMove_Click(object sender, EventArgs e)
        {
            DataRow dr;
            dr = dt.Rows[gridView2.FocusedRowHandle]; // Lay dong hien tai
            dt.Rows.Remove(dr);
        }
    }
}
