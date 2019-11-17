using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class Report_DSSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DSSinhVien(string MaLop)
        {
            InitializeComponent();
            this.FilterString = $"[MaLop] = '{MaLop}'";
            this.ShowPreview();
        }

    }
}
