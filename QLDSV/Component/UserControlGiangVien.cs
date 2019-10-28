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

namespace QLDSV.Component
{
    public partial class UserControlGiangVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlGiangVien()
        {
            InitializeComponent();
        }

        public void UserControlGiangVien_Load()
        {
            khoaBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void Layout_Setting(string status)
        {
            if (status == "edit")
            {
                groupBoxGiangVien.Enabled = false;
                giangVienGridControl.Enabled = false;
                barbtnThem.Enabled = false;
                barbtnXoa.Enabled = false;
                barbtnSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                groupBoxGiangVien.Enabled = true;
                giangVienGridControl.Enabled = true;
                barbtnThem.Enabled = true;
                barbtnXoa.Enabled = true;
                barbtnSua.Enabled = true;
                barbtnLuu.Enabled = true;
                barBtnRefresh.Enabled = true;
            }
        }

        private void ClearErrorGiangVien()
        {
            maGVTextEdit.ErrorText = "";
            hoTextEdit.ErrorText = "";
            tenTextEdit.ErrorText = "";
            hocViTextEdit.ErrorText = "";
            hocHamTextEdit.ErrorText = "";
            chuyenMonTextEdit.ErrorText = "";
            chucVuTextEdit.ErrorText = "";
        }

        private string AllErrorGiangVien()
        {
            string error = "";
            maGVTextEdit.Focus();
            hoTextEdit.Focus();
            tenTextEdit.Focus();
            hocViTextEdit.Focus();
            hocHamTextEdit.Focus();
            chuyenMonTextEdit.Focus();
            chucVuTextEdit.Focus();
            btnOkGiangVien.Focus();
            if (maGVTextEdit.ErrorText != "") error += maGVTextEdit.ErrorText + "\n";
            if (hoTextEdit.ErrorText != "") error += hoTextEdit.ErrorText + "\n";
            if (tenTextEdit.ErrorText != "") error += tenTextEdit.ErrorText + "\n";
            if (hocViTextEdit.ErrorText != "") error += hocViTextEdit.ErrorText + "\n";
            if (hocHamTextEdit.ErrorText != "") error += hocHamTextEdit.ErrorText + "\n";
            if (chuyenMonTextEdit.ErrorText != "") error += chuyenMonTextEdit.ErrorText + "\n";
            if (chucVuTextEdit.ErrorText != "") error += chucVuTextEdit.ErrorText + "\n";
            return error;
        }

        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
            maGVTextEdit.Focus();
            giangVienBindingSource.AddNew();
        }

        private void barbtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                giangVienBindingSource.RemoveCurrent();
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

        private void btnOkSinhVien_Click(object sender, EventArgs e)
        {
            string errors = AllErrorGiangVien();
            if (errors != "")
            {
                MessageBox.Show(errors, "Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            giangVienBindingSource.EndEdit();
            Layout_Setting("normal");
        }

        private void btnSinhVienHuy_Click(object sender, EventArgs e)
        {
            giangVienBindingSource.CancelEdit();
            ClearErrorGiangVien();
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
        
        private void commonTextEdit_Validating(object sender, CancelEventArgs e)
        {
            TextEdit textEdit = (TextEdit)sender;
            string error = Validation.ValidateCommonText(textEdit.Properties.AccessibleName, textEdit.Text);
            if (error != "")
            {
                textEdit.ErrorText = error;
            }
        }
    }
}
