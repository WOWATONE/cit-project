using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;
using iShop.Presentation;
using iShop.Presentation.DanhMuc;
using iShop.Presentation.HeThong;
using iShop.Presentation.ChucNang;

namespace iShop
{
    public partial class frmMain : RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        //Ham kiem tra ton tai Form
        public bool KtraForm_TonTai(string frmName)
        {

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    return true;
                }
            }
            return false;
        }

        //HAM ADD FORM VAO TAB
        public void AddForm(Form f, string fName)
        {
            if (KtraForm_TonTai(fName) == true)
            {
                f.Activate();
            }
            else
            {
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
        }


        private void iThoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có muốn đóng ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void bbtnKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKhachHang k = new frmKhachHang();
            AddForm(k,"frmKhachHang");
        }

        private void bbtnNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            AddForm(f,"frmNhanVien");
        }

        private void bbtnNhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhaCungCap f = new frmNhaCungCap();
            AddForm(f,"frmNhaCungCap");
        }

        private void bbtnDonViTinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDonViTinh dvt = new frmDonViTinh();
            AddForm(dvt,"frmDonViTinh");
        }

        private void bbtnNhomHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNhomHangHoa f = new frmNhomHangHoa();
            AddForm(f,"frmNhomHangHoa");
        }

        private void bbtnHangHoa_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmHangHoa f = new frmHangHoa();
            AddForm(f,"frmHangHoa");
        }

        private void bbtnBoPhan_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBoPhan f = new frmBoPhan();
            AddForm(f,"frmBoPhan");
        }

        private void bbtnBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBanHang f = new frmBanHang();
            AddForm(f,"frmBanHang");
        }

        private void bbtnDoanhThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBaoCao f = new frmBaoCao();
            AddForm(f,"frmBaoCao");
        }

        private void bbtnNguoiDung_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmNguoiDung f = new frmNguoiDung();
            AddForm(f, "frmNguoiDung");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmBanHang f = new frmBanHang();
            AddForm(f, "frmBanHang");
        }

        private void bbtnHoaDon_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDSHoaDonBan f = new frmDSHoaDonBan();
            AddForm(f, "frmDSHoaDonBan");
        }
    }
}