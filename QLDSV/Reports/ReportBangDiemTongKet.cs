using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QLDSV.Reports
{
    public partial class ReportBangDiemTongKet : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBangDiemTongKet(string maLop)
        {
            InitializeComponent();
            this.sP_BangDiem_TongKetTableAdapter.Connection = Program.KetNoiDB.SqlConnection;
            xrLabelTenLop.Text += maLop;
            sP_BangDiem_TongKetTableAdapter.Fill(qldsvDataSetKhoa.SP_BangDiem_TongKet, maLop);
            this.ShowPreview();
        }

    }
}
