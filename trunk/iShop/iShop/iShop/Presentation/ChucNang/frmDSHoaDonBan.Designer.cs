namespace iShop.Presentation.ChucNang
{
    partial class frmDSHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDSHoaDonBan));
            this.gridDS_HoaDonBan = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaHoaDon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNgayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcChietKhau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtnIn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridDS_HoaDonBan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridDS_HoaDonBan
            // 
            this.gridDS_HoaDonBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDS_HoaDonBan.Location = new System.Drawing.Point(0, 24);
            this.gridDS_HoaDonBan.MainView = this.gridView1;
            this.gridDS_HoaDonBan.Name = "gridDS_HoaDonBan";
            this.gridDS_HoaDonBan.Size = new System.Drawing.Size(691, 407);
            this.gridDS_HoaDonBan.TabIndex = 0;
            this.gridDS_HoaDonBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridDS_HoaDonBan.DoubleClick += new System.EventHandler(this.gridDS_HoaDonBan_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaHoaDon,
            this.gcNgayLap,
            this.gcNhanVien,
            this.gcChietKhau,
            this.gcTongTien,
            this.gcKhachHang,
            this.gcGhiChu});
            this.gridView1.GridControl = this.gridDS_HoaDonBan;
            this.gridView1.GroupPanelText = "Kéo cột lên đây để nhóm";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gcMaHoaDon
            // 
            this.gcMaHoaDon.Caption = "Mã hóa đơn";
            this.gcMaHoaDon.FieldName = "ID";
            this.gcMaHoaDon.Name = "gcMaHoaDon";
            this.gcMaHoaDon.Visible = true;
            this.gcMaHoaDon.VisibleIndex = 0;
            // 
            // gcNgayLap
            // 
            this.gcNgayLap.Caption = "Ngày lập";
            this.gcNgayLap.FieldName = "NgayLap";
            this.gcNgayLap.Name = "gcNgayLap";
            this.gcNgayLap.Visible = true;
            this.gcNgayLap.VisibleIndex = 1;
            // 
            // gcNhanVien
            // 
            this.gcNhanVien.Caption = "Nhân viên bán";
            this.gcNhanVien.FieldName = "NhanVien";
            this.gcNhanVien.Name = "gcNhanVien";
            this.gcNhanVien.Visible = true;
            this.gcNhanVien.VisibleIndex = 2;
            // 
            // gcChietKhau
            // 
            this.gcChietKhau.Caption = "Chiết khấu";
            this.gcChietKhau.FieldName = "ChietKhau";
            this.gcChietKhau.Name = "gcChietKhau";
            this.gcChietKhau.Visible = true;
            this.gcChietKhau.VisibleIndex = 4;
            // 
            // gcTongTien
            // 
            this.gcTongTien.Caption = "Tổng tiền thu";
            this.gcTongTien.FieldName = "TongTien";
            this.gcTongTien.Name = "gcTongTien";
            this.gcTongTien.Visible = true;
            this.gcTongTien.VisibleIndex = 5;
            // 
            // gcKhachHang
            // 
            this.gcKhachHang.Caption = "Khách hàng mua";
            this.gcKhachHang.FieldName = "KhachHang";
            this.gcKhachHang.Name = "gcKhachHang";
            this.gcKhachHang.Visible = true;
            this.gcKhachHang.VisibleIndex = 3;
            // 
            // gcGhiChu
            // 
            this.gcGhiChu.Caption = "Ghi chú";
            this.gcGhiChu.FieldName = "GhiChu";
            this.gcGhiChu.Name = "gcGhiChu";
            this.gcGhiChu.Visible = true;
            this.gcGhiChu.VisibleIndex = 6;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnIn,
            this.bbtnXoa,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnIn, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnXoa, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtnIn
            // 
            this.bbtnIn.Caption = "In";
            this.bbtnIn.Id = 0;
            this.bbtnIn.ImageIndex = 1;
            this.bbtnIn.Name = "bbtnIn";
            this.bbtnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnIn_ItemClick);
            // 
            // bbtnXoa
            // 
            this.bbtnXoa.Caption = "Xóa";
            this.bbtnXoa.Id = 1;
            this.bbtnXoa.ImageIndex = 2;
            this.bbtnXoa.Name = "bbtnXoa";
            this.bbtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnXoa_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Đóng";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageIndex = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(691, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 431);
            this.barDockControlBottom.Size = new System.Drawing.Size(691, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 407);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(691, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 407);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Close.png");
            this.imageCollection1.Images.SetKeyName(1, "printer.png");
            this.imageCollection1.Images.SetKeyName(2, "delete-file-icon.png");
            // 
            // frmDSHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 431);
            this.Controls.Add(this.gridDS_HoaDonBan);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmDSHoaDonBan";
            this.Text = "Danh sách Hóa đơn bán";
            this.Load += new System.EventHandler(this.frmDSHoaDonBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDS_HoaDonBan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridDS_HoaDonBan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbtnIn;
        private DevExpress.XtraBars.BarButtonItem bbtnXoa;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaHoaDon;
        private DevExpress.XtraGrid.Columns.GridColumn gcNgayLap;
        private DevExpress.XtraGrid.Columns.GridColumn gcNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn gcKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gcChietKhau;
        private DevExpress.XtraGrid.Columns.GridColumn gcTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn gcGhiChu;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}