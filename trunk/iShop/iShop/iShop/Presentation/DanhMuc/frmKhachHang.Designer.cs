namespace iShop.Presentation.DanhMuc
{
    partial class frmKhachHang
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
            DevExpress.XtraBars.Bar bar;
            DevExpress.XtraBars.Bar bar1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            this.NHO_imageCollection = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.gridKhachHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumn_Ten = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumn_SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumn_Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumn_DiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gColumn_GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnIn = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnNhap = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.txtSoDienThoai = new DevExpress.XtraEditors.TextEdit();
            this.txtTenKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaKhachHang = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            bar = new DevExpress.XtraBars.Bar();
            bar1 = new DevExpress.XtraBars.Bar();
            ((System.ComponentModel.ISupportInitialize)(this.NHO_imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar
            // 
            bar.BarName = "Main menu";
            bar.DockCol = 0;
            bar.DockRow = 0;
            bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar.OptionsBar.MultiLine = true;
            bar.OptionsBar.UseWholeRow = true;
            bar.Text = "Main menu";
            // 
            // bar1
            // 
            bar1.BarName = "Main menu";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.OptionsBar.MultiLine = true;
            bar1.OptionsBar.UseWholeRow = true;
            bar1.Text = "Main menu";
            // 
            // NHO_imageCollection
            // 
            this.NHO_imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("NHO_imageCollection.ImageStream")));
            this.NHO_imageCollection.Images.SetKeyName(0, "delete-file-icon.png");
            this.NHO_imageCollection.Images.SetKeyName(1, "edit-file-icon.png");
            this.NHO_imageCollection.Images.SetKeyName(2, "new-file-icon.png");
            this.NHO_imageCollection.Images.SetKeyName(3, "cancel-icon.png");
            this.NHO_imageCollection.Images.SetKeyName(4, "printer.png");
            this.NHO_imageCollection.Images.SetKeyName(5, "excel.png");
            this.NHO_imageCollection.Images.SetKeyName(6, "export_excel.png");
            this.NHO_imageCollection.Images.SetKeyName(7, "Search-icon.png");
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Close.png");
            this.imageCollection1.Images.SetKeyName(1, "delete-file-icon.png");
            this.imageCollection1.Images.SetKeyName(2, "edit-file-icon.png");
            this.imageCollection1.Images.SetKeyName(3, "excel.png");
            this.imageCollection1.Images.SetKeyName(4, "export_excel.png");
            this.imageCollection1.Images.SetKeyName(5, "new-file-icon.png");
            this.imageCollection1.Images.SetKeyName(6, "printer.png");
            // 
            // gridKhachHang
            // 
            this.gridKhachHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridKhachHang.Location = new System.Drawing.Point(0, 149);
            this.gridKhachHang.MainView = this.gridView1;
            this.gridKhachHang.MenuManager = this.barManager1;
            this.gridKhachHang.Name = "gridKhachHang";
            this.gridKhachHang.Size = new System.Drawing.Size(917, 269);
            this.gridKhachHang.TabIndex = 6;
            this.gridKhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridKhachHang.DoubleClick += new System.EventHandler(this.gridKhachHang_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaKhachHang,
            this.gColumn_Ten,
            this.gColumn_SDT,
            this.gColumn_Email,
            this.gColumn_DiaChi,
            this.gColumn_GhiChu});
            this.gridView1.GridControl = this.gridKhachHang;
            this.gridView1.GroupPanelText = "Kéo tên cột lên vùng này để nhóm";
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // gcMaKhachHang
            // 
            this.gcMaKhachHang.Caption = "Mã khách hàng";
            this.gcMaKhachHang.FieldName = "ID";
            this.gcMaKhachHang.Name = "gcMaKhachHang";
            this.gcMaKhachHang.Visible = true;
            this.gcMaKhachHang.VisibleIndex = 0;
            // 
            // gColumn_Ten
            // 
            this.gColumn_Ten.Caption = "Tên khách hàng";
            this.gColumn_Ten.FieldName = "TenKhachHang";
            this.gColumn_Ten.Name = "gColumn_Ten";
            this.gColumn_Ten.Visible = true;
            this.gColumn_Ten.VisibleIndex = 1;
            // 
            // gColumn_SDT
            // 
            this.gColumn_SDT.Caption = "Số điện thoại";
            this.gColumn_SDT.FieldName = "SoDienThoai";
            this.gColumn_SDT.Name = "gColumn_SDT";
            this.gColumn_SDT.Visible = true;
            this.gColumn_SDT.VisibleIndex = 2;
            // 
            // gColumn_Email
            // 
            this.gColumn_Email.Caption = "Email";
            this.gColumn_Email.FieldName = "Email";
            this.gColumn_Email.Name = "gColumn_Email";
            this.gColumn_Email.Visible = true;
            this.gColumn_Email.VisibleIndex = 3;
            // 
            // gColumn_DiaChi
            // 
            this.gColumn_DiaChi.Caption = "Địa chỉ";
            this.gColumn_DiaChi.FieldName = "DiaChi";
            this.gColumn_DiaChi.Name = "gColumn_DiaChi";
            this.gColumn_DiaChi.Visible = true;
            this.gColumn_DiaChi.VisibleIndex = 4;
            // 
            // gColumn_GhiChu
            // 
            this.gColumn_GhiChu.Caption = "Ghi chú";
            this.gColumn_GhiChu.FieldName = "GhiChu";
            this.gColumn_GhiChu.Name = "gColumn_GhiChu";
            this.gColumn_GhiChu.Visible = true;
            this.gColumn_GhiChu.VisibleIndex = 5;
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnThem,
            this.bbtnSua,
            this.bbtnXoa,
            this.bbtnIn,
            this.bbtnNhap,
            this.bbtnDong});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnIn, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnNhap, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bbtnThem
            // 
            this.bbtnThem.Caption = "Thêm";
            this.bbtnThem.Id = 0;
            this.bbtnThem.ImageIndex = 5;
            this.bbtnThem.Name = "bbtnThem";
            this.bbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnThem_ItemClick_1);
            // 
            // bbtnSua
            // 
            this.bbtnSua.Caption = "Sửa";
            this.bbtnSua.Id = 1;
            this.bbtnSua.ImageIndex = 2;
            this.bbtnSua.Name = "bbtnSua";
            this.bbtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnSua_ItemClick);
            // 
            // bbtnXoa
            // 
            this.bbtnXoa.Caption = "Xóa";
            this.bbtnXoa.Id = 2;
            this.bbtnXoa.ImageIndex = 1;
            this.bbtnXoa.Name = "bbtnXoa";
            this.bbtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnXoa_ItemClick);
            // 
            // bbtnIn
            // 
            this.bbtnIn.Caption = "In - Xuất";
            this.bbtnIn.Id = 3;
            this.bbtnIn.ImageIndex = 6;
            this.bbtnIn.Name = "bbtnIn";
            this.bbtnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnIn_ItemClick);
            // 
            // bbtnNhap
            // 
            this.bbtnNhap.Caption = "Nhập";
            this.bbtnNhap.Id = 4;
            this.bbtnNhap.ImageIndex = 3;
            this.bbtnNhap.Name = "bbtnNhap";
            // 
            // bbtnDong
            // 
            this.bbtnDong.Caption = "Đóng";
            this.bbtnDong.Id = 6;
            this.bbtnDong.ImageIndex = 0;
            this.bbtnDong.Name = "bbtnDong";
            this.bbtnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDong_ItemClick_1);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(917, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 418);
            this.barDockControlBottom.Size = new System.Drawing.Size(917, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 394);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(917, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 394);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(467, 33);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(348, 20);
            this.txtDiaChi.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(429, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(32, 13);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(278, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.MaxLength = 100;
            this.txtEmail.Size = new System.Drawing.Size(134, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(210, 62);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(24, 13);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Email";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl5.Location = new System.Drawing.Point(44, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(14, 13);
            this.labelControl5.TabIndex = 41;
            this.labelControl5.Text = "(*)";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Location = new System.Drawing.Point(25, 36);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(14, 13);
            this.labelControl4.TabIndex = 40;
            this.labelControl4.Text = "(*)";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(467, 59);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.MaxLength = 200;
            this.txtGhiChu.Size = new System.Drawing.Size(348, 20);
            this.txtGhiChu.TabIndex = 5;
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new System.Drawing.Point(278, 33);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Properties.MaxLength = 11;
            this.txtSoDienThoai.Size = new System.Drawing.Size(134, 20);
            this.txtSoDienThoai.TabIndex = 2;
            // 
            // txtTenKhachHang
            // 
            this.txtTenKhachHang.Location = new System.Drawing.Point(62, 59);
            this.txtTenKhachHang.Name = "txtTenKhachHang";
            this.txtTenKhachHang.Properties.MaxLength = 150;
            this.txtTenKhachHang.Size = new System.Drawing.Size(134, 20);
            this.txtTenKhachHang.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(429, 62);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(35, 13);
            this.labelControl9.TabIndex = 22;
            this.labelControl9.Text = "Ghi chú";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.EditValue = "";
            this.txtMaKhachHang.Location = new System.Drawing.Point(62, 33);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Properties.MaxLength = 10;
            this.txtMaKhachHang.Size = new System.Drawing.Size(134, 20);
            this.txtMaKhachHang.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(210, 36);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 13);
            this.labelControl3.TabIndex = 26;
            this.labelControl3.Text = "Số điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Họ tên";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(7, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Mã";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.txtTenKhachHang);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtGhiChu);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.txtSoDienThoai);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtMaKhachHang);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Location = new System.Drawing.Point(0, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(917, 91);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin cập nhật";
            this.groupControl1.DoubleClick += new System.EventHandler(this.groupControl1_DoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(9, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 16);
            this.lblStatus.TabIndex = 55;
            this.lblStatus.Text = "Status";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 418);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridKhachHang);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmKhachHang";
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NHO_imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDienThoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhachHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection NHO_imageCollection;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraGrid.GridControl gridKhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bbtnThem;
        private DevExpress.XtraBars.BarButtonItem bbtnSua;
        private DevExpress.XtraBars.BarButtonItem bbtnXoa;
        private DevExpress.XtraBars.BarButtonItem bbtnIn;
        private DevExpress.XtraBars.BarButtonItem bbtnNhap;
        private DevExpress.XtraBars.BarButtonItem bbtnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gColumn_Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gColumn_SDT;
        private DevExpress.XtraGrid.Columns.GridColumn gColumn_Email;
        private DevExpress.XtraGrid.Columns.GridColumn gColumn_DiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn gColumn_GhiChu;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.TextEdit txtMaKhachHang;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSoDienThoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTenKhachHang;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblStatus;
    }
}