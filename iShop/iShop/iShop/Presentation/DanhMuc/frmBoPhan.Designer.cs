namespace iShop.Presentation.DanhMuc
{
    partial class frmBoPhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBoPhan));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bbtnThemBP = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnBP = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnXoaBP = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnInBP = new DevExpress.XtraBars.BarButtonItem();
            this.bbtnDong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtGhiChu = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTenBoPhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtMaBoPhan = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.gridBoPhan = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcMaBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTenBoPhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcGhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBoPhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoPhan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.AllowQuickCustomization = false;
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar4});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControl3);
            this.barManager1.DockControls.Add(this.barDockControl4);
            this.barManager1.Form = this;
            this.barManager1.Images = this.imageCollection1;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbtnThemBP,
            this.bbtnBP,
            this.bbtnXoaBP,
            this.bbtnInBP,
            this.barButtonItem8,
            this.bbtnDong});
            this.barManager1.MainMenu = this.bar4;
            this.barManager1.MaxItemId = 7;
            // 
            // bar4
            // 
            this.bar4.BarName = "Main menu";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnThemBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnXoaBP, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnInBP, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbtnDong, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar4.OptionsBar.MultiLine = true;
            this.bar4.OptionsBar.UseWholeRow = true;
            this.bar4.Text = "Main menu";
            // 
            // bbtnThemBP
            // 
            this.bbtnThemBP.Caption = "Thêm";
            this.bbtnThemBP.Id = 0;
            this.bbtnThemBP.ImageIndex = 5;
            this.bbtnThemBP.Name = "bbtnThemBP";
            this.bbtnThemBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnThemBP_ItemClick);
            // 
            // bbtnBP
            // 
            this.bbtnBP.Caption = "Sửa";
            this.bbtnBP.Id = 1;
            this.bbtnBP.ImageIndex = 2;
            this.bbtnBP.Name = "bbtnBP";
            this.bbtnBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnBP_ItemClick);
            // 
            // bbtnXoaBP
            // 
            this.bbtnXoaBP.Caption = "Xóa";
            this.bbtnXoaBP.Id = 2;
            this.bbtnXoaBP.ImageIndex = 1;
            this.bbtnXoaBP.Name = "bbtnXoaBP";
            this.bbtnXoaBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnXoaBP_ItemClick);
            // 
            // bbtnInBP
            // 
            this.bbtnInBP.Caption = "In - Xuất";
            this.bbtnInBP.Id = 3;
            this.bbtnInBP.ImageIndex = 6;
            this.bbtnInBP.Name = "bbtnInBP";
            this.bbtnInBP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnInBP_ItemClick);
            // 
            // bbtnDong
            // 
            this.bbtnDong.Caption = "Đóng";
            this.bbtnDong.Id = 6;
            this.bbtnDong.ImageIndex = 0;
            this.bbtnDong.Name = "bbtnDong";
            this.bbtnDong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbtnDong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(625, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 356);
            this.barDockControlBottom.Size = new System.Drawing.Size(625, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 24);
            this.barDockControl3.Size = new System.Drawing.Size(0, 332);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(625, 24);
            this.barDockControl4.Size = new System.Drawing.Size(0, 332);
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
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Xuất";
            this.barButtonItem8.Id = 5;
            this.barButtonItem8.ImageIndex = 4;
            this.barButtonItem8.Name = "barButtonItem8";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.txtGhiChu);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.txtTenBoPhan);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.txtMaBoPhan);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Location = new System.Drawing.Point(12, 30);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(601, 73);
            this.groupControl2.TabIndex = 10;
            this.groupControl2.Text = "Chi tiết bộ phận";
            this.groupControl2.DoubleClick += new System.EventHandler(this.groupControl2_DoubleClick);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(391, 33);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Properties.MaxLength = 150;
            this.txtGhiChu.Size = new System.Drawing.Size(201, 20);
            this.txtGhiChu.TabIndex = 48;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(349, 36);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(35, 13);
            this.labelControl6.TabIndex = 49;
            this.labelControl6.Text = "Ghi chú";
            // 
            // txtTenBoPhan
            // 
            this.txtTenBoPhan.Location = new System.Drawing.Point(194, 33);
            this.txtTenBoPhan.Name = "txtTenBoPhan";
            this.txtTenBoPhan.Properties.MaxLength = 50;
            this.txtTenBoPhan.Size = new System.Drawing.Size(138, 20);
            this.txtTenBoPhan.TabIndex = 43;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl7.Location = new System.Drawing.Point(23, 36);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(14, 13);
            this.labelControl7.TabIndex = 46;
            this.labelControl7.Text = "(*)";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(155, 36);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(18, 13);
            this.labelControl8.TabIndex = 45;
            this.labelControl8.Text = "Tên";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl9.Location = new System.Drawing.Point(174, 36);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(14, 13);
            this.labelControl9.TabIndex = 47;
            this.labelControl9.Text = "(*)";
            // 
            // txtMaBoPhan
            // 
            this.txtMaBoPhan.EditValue = "";
            this.txtMaBoPhan.Location = new System.Drawing.Point(43, 33);
            this.txtMaBoPhan.Name = "txtMaBoPhan";
            this.txtMaBoPhan.Properties.MaxLength = 10;
            this.txtMaBoPhan.Size = new System.Drawing.Size(97, 20);
            this.txtMaBoPhan.TabIndex = 42;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(8, 36);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(14, 13);
            this.labelControl10.TabIndex = 44;
            this.labelControl10.Text = "Mã";
            // 
            // gridBoPhan
            // 
            this.gridBoPhan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridBoPhan.Location = new System.Drawing.Point(0, 131);
            this.gridBoPhan.MainView = this.gridView2;
            this.gridBoPhan.MenuManager = this.barManager1;
            this.gridBoPhan.Name = "gridBoPhan";
            this.gridBoPhan.Size = new System.Drawing.Size(625, 224);
            this.gridBoPhan.TabIndex = 59;
            this.gridBoPhan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridBoPhan.DoubleClick += new System.EventHandler(this.gridBoPhan_DoubleClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcMaBoPhan,
            this.gcTenBoPhan,
            this.gcGhiChu});
            this.gridView2.GridControl = this.gridBoPhan;
            this.gridView2.GroupPanelText = "Kéo tên cột lên vùng này để nhóm";
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowAutoFilterRow = true;
            // 
            // gcMaBoPhan
            // 
            this.gcMaBoPhan.Caption = "Mã bộ phận";
            this.gcMaBoPhan.FieldName = "ID";
            this.gcMaBoPhan.Name = "gcMaBoPhan";
            this.gcMaBoPhan.Visible = true;
            this.gcMaBoPhan.VisibleIndex = 0;
            // 
            // gcTenBoPhan
            // 
            this.gcTenBoPhan.Caption = "Tên bộ phận";
            this.gcTenBoPhan.FieldName = "TenBoPhan";
            this.gcTenBoPhan.Name = "gcTenBoPhan";
            this.gcTenBoPhan.Visible = true;
            this.gcTenBoPhan.VisibleIndex = 1;
            // 
            // gcGhiChu
            // 
            this.gcGhiChu.Caption = "Ghi chú";
            this.gcGhiChu.FieldName = "GhiChu";
            this.gcGhiChu.Name = "gcGhiChu";
            this.gcGhiChu.Visible = true;
            this.gcGhiChu.VisibleIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblStatus.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(13, 109);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(36, 16);
            this.lblStatus.TabIndex = 60;
            this.lblStatus.Text = "Status";
            // 
            // frmBoPhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 356);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.gridBoPhan);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmBoPhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bộ phận nhân viên";
            this.Load += new System.EventHandler(this.frmBoPhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGhiChu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTenBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaBoPhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBoPhan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.BarButtonItem bbtnThemBP;
        private DevExpress.XtraBars.BarButtonItem bbtnBP;
        private DevExpress.XtraBars.BarButtonItem bbtnXoaBP;
        private DevExpress.XtraBars.BarButtonItem bbtnInBP;
        private DevExpress.XtraBars.BarButtonItem bbtnDong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txtGhiChu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtTenBoPhan;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtMaBoPhan;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gridBoPhan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraGrid.Columns.GridColumn gcMaBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn gcTenBoPhan;
        private DevExpress.XtraGrid.Columns.GridColumn gcGhiChu;
    }
}