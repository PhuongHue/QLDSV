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
using System.Data.SqlClient;

namespace QLDSV.Component
{
    public partial class FormChuyenLop : DevExpress.XtraEditors.XtraForm
    {
        string MaSV;
        public FormChuyenLop(string Ten, string MaSV)
        {
            InitializeComponent();
            labelTenSV.Text += Ten;
            labelMaSV.Text += MaSV;
            this.MaSV = MaSV;
        }



        private void FormChuyenLop_Load(object sender, EventArgs e)
        {

            lopBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void btnChuyenLop_Click(object sender, EventArgs e)
        {
            try
            {
                Program.KetNoiDB.ExcuteSP($"SP_Chuyen_SinhVien @MaSV = '{MaSV}' @MaLop = '{lopComboBox.SelectedItem.ToString()}'");
                Dispose();
            }
            catch (SqlException)
            {

            }
        }
    }
}