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

namespace QLDSV
{
    public partial class FormDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        public FormDangKyLTC()
        {
            InitializeComponent();
        }

        private void FormDangKyLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetKhoa.SP_List_SV_DangKy_LopTC' table. You can move, or remove it, as needed.
            this.sP_List_SV_DangKy_LopTCTableAdapter.Fill(this.qLDSVDataSetKhoa.SP_List_SV_DangKy_LopTC);

        }

        private void repositoryItemCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}