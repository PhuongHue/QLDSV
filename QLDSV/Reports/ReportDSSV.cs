using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class ReportDSSV : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSSV(string MaLop, string TenLop)
        {
            InitializeComponent();
            qldsvDataSetKhoa.EnforceConstraints = false;
            this.FilterString = $"[MaLop] = '{MaLop}'";
            this.xrLabelMaLop.Text += MaLop;
            this.xrLabelTenLop.Text += TenLop;
            this.sinhVienTableAdapter.Connection = Program.KetNoiDB.SqlConnection;
            sinhVienTableAdapter.Fill(qldsvDataSetKhoa.SinhVien);
            this.ShowPreview();
        }

    }
}
