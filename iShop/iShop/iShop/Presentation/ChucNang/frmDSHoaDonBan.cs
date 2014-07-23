using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using iShop.BLL;

namespace iShop.Presentation.ChucNang
{
    public partial class frmDSHoaDonBan : DevExpress.XtraEditors.XtraForm
    {
        public frmDSHoaDonBan()
        {
            InitializeComponent();
        }

        private void bbtnIn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridDS_HoaDonBan.ShowPrintPreview();
        }

        private void frmDSHoaDonBan_Load(object sender, EventArgs e)
        {
            //Load Grid
            DS_HoaDonBanBLL ds = new DS_HoaDonBanBLL();
            gridDS_HoaDonBan.DataSource = ds.SelectAll_HoaDonBanBLL();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                string id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gcMaHoaDon).ToString();
                if (XtraMessageBox.Show("Bạn xóa muốn xóa hóa đơn có mã \"" + id + "\"?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    DS_HoaDonBanBLL ds = new DS_HoaDonBanBLL();
                    ds.Delete_DSHoaDon_BLL(id);
                    frmDSHoaDonBan_Load(null,null);
                    XtraMessageBox.Show("Xóa thành công.");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Lỗi: \n"+ex.Message);
            }
            
        }

        private void gridDS_HoaDonBan_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}