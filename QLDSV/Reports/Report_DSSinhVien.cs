using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class Report_DSSinhVien : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DSSinhVien(string MaLop, string TenLop)
        {
            InitializeComponent();
            this.FilterString = $"[MaLop] = '{MaLop}'";
            this.xrLabelMaLop.Text += MaLop;
            this.xrLabelTenLop.Text += TenLop;
            this.sinhVienTableAdapter.Connection = Program.KetNoiDB.SqlConnection;
            sinhVienTableAdapter.Fill(qldsvDataSetKhoa1.SinhVien);
            this.ShowPreview();
        }

    }
}
