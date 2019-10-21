using KetNoi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV
{
    public partial class FormMain : Form
    {
        private KetNoiDB KetNoiDB = Program.KetNoiDB;
        public FormMain()
        {
            InitializeComponent();

        }
        public void ChangeServer()
        {

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            txtStripLoginName.Text += KetNoiDB.LoginName;
            txtStripMaGV.Text += KetNoiDB.UserName;
            txtStripHoTen.Text += KetNoiDB.FullName;
            txtStripNhom.Text += KetNoiDB.GroupId;
            // TODO: This line of code loads data into the 'qLDSVDataSetMaster.V_DSPM' table. You can move, or remove it, as needed.
            this.v_DSPMTableAdapter.Fill(this.qLDSVDataSetMaster.V_DSPM);
            while (((DataRowView)v_DSPMBindingSource.Current)["subscriber_server"].ToString() != KetNoiDB.Server)
            {
                    v_DSPMBindingSource.MoveNext();
            }
            v_DSPMComboBox.Enabled = KetNoiDB.GroupId == "PGV";
            userControlLop_SinhVien.UserControlSinhVien_Load();
        }
    }
}
