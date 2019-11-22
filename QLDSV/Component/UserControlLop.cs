using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BatLoi;
using QLDSV.BatLoi;
using QLDSV.Reports;

namespace QLDSV.Component
{
    public partial class UserControlLop : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlLop()
        {
            InitializeComponent();
        }

        public void UserControlLop_Load()
        {
            khoaBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void Layout_Setting(string status)
        {
            if (status == "edit")
            {
                groupBoxLop.Enabled = false;
                lopGridControl.Enabled = false;
                groupBoxLop.Enabled = true;
                barbtnThem.Enabled = false;
                barbtnXoa.Enabled = false;
                barbtnSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                groupBoxLop.Enabled = true;
                lopGridControl.Enabled = true;
                groupBoxLop.Enabled = false;
                barbtnThem.Enabled = true;
                barbtnXoa.Enabled = true;
                barbtnSua.Enabled = true;
                barbtnLuu.Enabled = true;
                barBtnRefresh.Enabled = true;
            }
        }

        private void ClearErrorLop()
        {
            maLopTextEdit.ErrorText = "";
            tenLopTextEdit.ErrorText = "";
        }

        private string AllErrorLop()
        {
            string error = "";
            maLopTextEdit.Focus();
            tenLopTextEdit.Focus();
            btnOk.Focus();
            if (maLopTextEdit.ErrorText != "") error += maLopTextEdit.ErrorText + "\n";
            if (tenLopTextEdit.ErrorText != "") error += tenLopTextEdit.ErrorText + "\n";
            return error;
        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
            maLopTextEdit.Focus();
            lopBindingSource.AddNew();
        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sinhVienBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên.", "Thông báo",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lopBindingSource.RemoveCurrent();
        }

        private void barbtnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
        }

        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UpdateAll();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FillAllTable();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string errors = AllErrorLop();
            if (errors != "")
            {
                MessageBox.Show(errors, "Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            try
            {
                lopBindingSource.EndEdit();
                Layout_Setting("normal");
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(BindingSourceMessage.ToMessage(ex, "Lớp"));
            }
            
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            lopBindingSource.CancelEdit();
            ClearErrorLop();
            Layout_Setting("normal");
        }

        private void codeTextEdit_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            string error = Validation.ValidateCode(textEdit.Properties.AccessibleName, textEdit.Text);
            if (error != "")
            {
                textEdit.ErrorText = error;
            }
        }

        private void commonTextEdit_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            string error = Validation.ValidateCommonText(textEdit.Properties.AccessibleName, textEdit.Text);
            if (error != "")
            {
                textEdit.ErrorText = error;
            }
        }

        private void barBtnPrintDS_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maLop = (string)((DataRowView)lopBindingSource.Current)["MaLop"];
            string tenLop = (string)((DataRowView)lopBindingSource.Current)["TenLop"];
            new ReportDSSV(maLop, tenLop);
        }
    }
}
