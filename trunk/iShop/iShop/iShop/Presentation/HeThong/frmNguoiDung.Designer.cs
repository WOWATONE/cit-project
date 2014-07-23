namespace iShop.Presentation.HeThong
{
    partial class frmNguoiDung
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenSV_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colSDT_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colMaSV_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenSV_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSDT_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaSV_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 80);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.colTenSV_Edit,
            this.colSDT_Edit,
            this.colMaSV_Edit});
            this.gridControl1.Size = new System.Drawing.Size(529, 247);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.ProcessGridKey += new System.Windows.Forms.KeyEventHandler(this.gridControl1_ProcessGridKey);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSV,
            this.colTenSV,
            this.colSDT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm mới";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // colMaSV
            // 
            this.colMaSV.Caption = "Mã";
            this.colMaSV.ColumnEdit = this.colMaSV_Edit;
            this.colMaSV.FieldName = "MaSV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.Visible = true;
            this.colMaSV.VisibleIndex = 0;
            // 
            // colTenSV
            // 
            this.colTenSV.Caption = "Tên Sinh viên";
            this.colTenSV.ColumnEdit = this.colTenSV_Edit;
            this.colTenSV.FieldName = "TenSV";
            this.colTenSV.Name = "colTenSV";
            this.colTenSV.Visible = true;
            this.colTenSV.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SDT";
            this.colSDT.ColumnEdit = this.colSDT_Edit;
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            // 
            // colTenSV_Edit
            // 
            this.colTenSV_Edit.AutoHeight = false;
            this.colTenSV_Edit.Name = "colTenSV_Edit";
            // 
            // colSDT_Edit
            // 
            this.colSDT_Edit.AutoHeight = false;
            this.colSDT_Edit.Name = "colSDT_Edit";
            // 
            // colMaSV_Edit
            // 
            this.colMaSV_Edit.AutoHeight = false;
            this.colMaSV_Edit.Name = "colMaSV_Edit";
            // 
            // frmNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 328);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmNguoiDung";
            this.Text = "frmNguoiDung";
            this.Load += new System.EventHandler(this.frmNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colTenSV_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colSDT_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colMaSV_Edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colMaSV_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn colTenSV;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colTenSV_Edit;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit colSDT_Edit;
    }
}