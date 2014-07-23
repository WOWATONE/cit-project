using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace iShop.Presentation.HeThong
{
    public partial class frmNguoiDung : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            
            dt.Columns.Add(new DataColumn("MaSV"));
            dt.Columns.Add(new DataColumn("TenSV"));
            dt.Columns.Add(new DataColumn("SDT"));
            //Add du lieu

            DataRow dr = dt.NewRow();
            dr.BeginEdit();
            dr["MaSV"] = "1";
            dr["TenSV"] = "SV 1";
            dr["SDT"] = "11";
            dr.EndEdit();
            dt.Rows.Add(dr);
            //
            //DataRow dr = dt.NewRow();
            //dr.BeginEdit();
            //dr["MaSV"] = "1";
            //dr["TenSV"] = "SV 1";
            //dr["SDT"] = "11";
            //dr.EndEdit();
            //dt.Rows.Add(dr);
            ////
            //DataRow dr = dt.NewRow();
            //dr.BeginEdit();
            //dr["MaSV"] = "1";
            //dr["TenSV"] = "SV 1";
            //dr["SDT"] = "11";
            //dr.EndEdit();
            //dt.Rows.Add(dr);

            //Gan vao Grid
            gridControl1.DataSource = dt;
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            // Sự kiện này để người ta không chuyển qua dòng khác được khi có lỗi xảy ra nè
            // Nó nhận giá trị e.Valid của gridView1_ValidateRow để ứng xử
            // neu e,Valid =True thì nó cho chuyển qua dòng khác hoặc làm tác vụ khác
            // và ngược lại
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string sErr = "";
            bool bVali = true;
            // kiem tra 3 cell cua mot dong dang Edit xem co rong ko?
            // minh quen mat kí tự xuống dòng trong C# rồi:D bên VB là VbnewLine
            if (gridView1.GetRowCellValue(e.RowHandle, "MaSV").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Vui long dien Ma SV";
            }
            if (gridView1.GetRowCellValue(e.RowHandle, "TenSV").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Vui long dien Ten Sinh Vien";
            }
            if (gridView1.GetRowCellValue(e.RowHandle, "SDT").ToString() == "")
            {
                bVali = false;
                sErr = sErr + "Vui long dien So dien thoai";
            }
            if (bVali)
            {
                // neu khong rỗng thì bụp cái này ra màn hình
                if (e.RowHandle < 0)// Đây là thêm mới nè:D
                {
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "MaSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "TenSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "SDT").ToString(), "");
                    XtraMessageBox.Show("Day la them moi nhe");
                    // Insert to DB
                }
                else
                {
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "MaSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "TenSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(e.RowHandle, "SDT").ToString(), "");
                    XtraMessageBox.Show("Day la Update nhe");
                    // Update to DB
                }
            }
            else
            {

                e.Valid = false;
                // coi như valid không qua được. bạn sẽ không làm được gì trừ khi
                //điền thêm thông tin hoặc bấm nút ESC trên bàn phím
                XtraMessageBox.Show(sErr, "Error!!!");
            }
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            // kiểm tra xem có phải người dùng bấm nút xóa trên bàn phím
            // Và trạng thái của Gridcontrol có không phải là đang edit không (tránh
            // tình trạng người dùng đang focus để sửa 1 cell nào trong Grid view )
            if (e.KeyCode == Keys.Delete && gridView1.State != DevExpress.XtraGrid.Views.Grid.GridState.Editing)
            {
                if (XtraMessageBox.Show("Are you sure?", "Quest", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XtraMessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenSV").ToString(), "");
                    XtraMessageBox.Show(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString(), "");
                    dt.Rows.RemoveAt(gridView1.FocusedRowHandle);
                }
            }
        }
    }
}