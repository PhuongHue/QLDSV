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

namespace QLDSV
{
    public partial class UserControlSinhVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlSinhVien()
        {
            InitializeComponent();
        }
        public void UserControlSinhVien_Load()
        {
            lopBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }
        private void Layout_Setting(string status)
        {
            if (status == "edit")
            {
                groupBoxLop.Enabled = false;
                sinhVienGridControl.Enabled = false;
                groupBoxSinhVien.Enabled = true;
            }
            else if (status == "normal")
            {
                groupBoxLop.Enabled = true;
                sinhVienGridControl.Enabled = true;
                groupBoxSinhVien.Enabled = false;
            }
   
        }
        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
            sinhVienBindingSource.AddNew();
        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa?","Xóa",MessageBoxButtons.YesNo) == DialogResult.Yes)
            sinhVienBindingSource.RemoveCurrent();
        }

        private void barbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
        }

        private void btnOkSinhVien_Click(object sender, EventArgs e)
        {
            Layout_Setting("normal");
        }

        private void btnSinhVienHuy_Click(object sender, EventArgs e)
        {
            Layout_Setting("normal");
        }
    }
}
