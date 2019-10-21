using KetNoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormDangNhap : DevExpress.XtraEditors.XtraForm
    {
        private KetNoiDB KetNoiDB = Program.KetNoiDB;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSetMaster.V_DSPM);
        }

        private void DangNhap_Click(object sender, EventArgs e)
        {
            KetNoiDB.Server = v_DSPMComboBox.SelectedValue.ToString();
            KetNoiDB.LoginName = textBoxLoginName.Text;
            KetNoiDB.Password = textBoxPassword.Text;
            KetNoiDB.NewSqlConnection();
            MessageBox.Show(KetNoiDB.ConnectServer());
            Dispose();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            Program.running = false;
            KetNoiDB.Ready = false;
            Dispose();
        }
    }
}
