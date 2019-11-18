using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class ReportDSThiHetMon : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDSThiHetMon(string maLop, string tenMH, string ngay)
        {
            InitializeComponent();
            sP_DanhSach_ThiHetMonTableAdapter.Connection = Program.KetNoiDB.SqlConnection;
            xrLabelLop.Text += maLop;
            xrLabelMH.Text += tenMH;
            xrLabelNgayThi.Text += ngay;
            sP_DanhSach_ThiHetMonTableAdapter.Fill(qldsvDataSetKhoa.SP_DanhSach_ThiHetMon, maLop);
            this.ShowPreview();
        }

    }
}
