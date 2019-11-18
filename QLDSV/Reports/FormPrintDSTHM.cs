using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QLDSV.Reports
{
    public partial class FormPrintDSTHM : DevExpress.XtraEditors.XtraForm
    {
        string Lop;
        string MonHoc;
        public FormPrintDSTHM(string lop, string monHoc)
        {
            Lop = lop;
            MonHoc = monHoc;
            InitializeComponent();
            labelLop.Text += lop;
            labelMH.Text += monHoc;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            new Reports.ReportDSThiHetMon(Lop,MonHoc, dateEdit.Text);
        }
    }
}