using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLDSV.QLDSVDataSetKhoaTableAdapters;
using System.Data.SqlClient;

namespace QLDSV.Component
{
    public partial class UserControlTaiKhoan : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlTaiKhoan()
        {
            InitializeComponent();
        }

        private void UserControlTaiKhoan_Fill()
        {
            Program.SP_List_LOGINTableAdapter.Fill(Program.QLDSVDataSetKhoa.SP_List_LOGIN);
        }

        public void UserControlTaiKhoan_Load()
        {
            sP_List_LOGINBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            UserControlTaiKhoan_Fill();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UserControlTaiKhoan_Fill();
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            string cmdString = $"SP_TaoLogin @LGNAME = N'{textEditLoginName.Text}', @PASS = N'{textEditPassword.Text}', @USERNAME = N'{labelMaGV.Text}', @ROLE = N'{comboBoxRole.SelectedItem.ToString()}'";
            try
            {
                var resReader = Program.KetNoiDB.ExcuteSP(cmdString);
                resReader.Read();
                int res = resReader.GetInt32(0);
                string error = "";
                switch (res)
                {
                    case 1:
                        error = $"Tên đăng nhập \"{textEditLoginName.Text}\" đã tồn tại";
                        break;
                    case 2:
                        string ho = (string)((DataRowView)sP_List_LOGINBindingSource.Current)["Ho"];
                        string ten = (string)((DataRowView)sP_List_LOGINBindingSource.Current)["Ten"];
                        string maGV = (string)((DataRowView)sP_List_LOGINBindingSource.Current)["MaGV"];
                        error = $"Giảng viên {ho} {ten} với Mã GV {maGV} đã có tài khoản";
                        break;
                }
                if (error != "") MessageBox.Show(error, "Thống báo");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + " Code: " + ex.Number);
            }
        }
    }
}
