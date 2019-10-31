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
using BatLoi;
using QLDSV.BatLoi;

namespace QLDSV.Component
{
    public partial class UserControlMonHoc : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlMonHoc()
        {
            InitializeComponent();
        }
        public void UserControlMonHoc_Load()
        {
            monHocBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void Layout_Setting(string status)
        {
            if (status == "edit")
            {
                groupBoxMonHoc.Enabled = true;
                monHocGridControl.Enabled = false;
                barbtnThem.Enabled = false;
                barbtnXoa.Enabled = false;
                barbtnSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                groupBoxMonHoc.Enabled = false;
                monHocGridControl.Enabled = true;
                barbtnThem.Enabled = true;
                barbtnXoa.Enabled = true;
                barbtnSua.Enabled = true;
                barbtnLuu.Enabled = true;
                barBtnRefresh.Enabled = true;
            }
        }

        private void ClearErrorLop()
        {
            maMHTextEdit.ErrorText = "";
            tenMHTextEdit.ErrorText = "";
            sTLTSpinEdit.ErrorText = "";
            sTTHSpinEdit.ErrorText = "";
        }

        private string AllErrorLop()
        {
            string error = "";
            maMHTextEdit.Focus();
            tenMHTextEdit.Focus();
            btnOk.Focus();
            if (maMHTextEdit.ErrorText != "") error += maMHTextEdit.ErrorText + "\n";
            if (tenMHTextEdit.ErrorText != "") error += tenMHTextEdit.ErrorText + "\n";
            return error;
        }
        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
            maMHTextEdit.Focus();
            monHocBindingSource.AddNew();
        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                monHocBindingSource.RemoveCurrent();
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
                monHocBindingSource.EndEdit();
                Layout_Setting("normal");
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(BindingSourceMessage.ToMessage(ex, "Môn học"));
            }
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            monHocBindingSource.CancelEdit();
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

        private void nameTextEdit_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            string error = Validation.ValidateName(textEdit.Properties.AccessibleName, textEdit.Text);
            if (error != "")
            {
                textEdit.ErrorText = error;
            }
        }
    }
}
