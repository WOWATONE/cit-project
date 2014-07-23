using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace iShop.Presentation.ChucNang
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            ReportDocument rptDoc = new ReportDocument();
            rptDoc.Load(@"E:\SHOP\a\iShop\iShop\Report\rptDoanhThu_NhanVien.rpt");
            crystalReportViewer1.ReportSource = rptDoc;
            crystalReportViewer1.Refresh();
        }
    }
}
