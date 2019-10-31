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
using QLDSV.BatLoi;
using BatLoi;

namespace QLDSV.Component
{
    public partial class UserControlLopTC : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlLopTC()
        {
            InitializeComponent();
        }

        public void UserControlLopTC_Load()
        {
            khoaBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            giangVienBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            monHocBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void Layout_Setting(string status)
        {
            if (status == "editLopTC")
            {
                lopTinChiGridControl.Enabled = false;
                cTLopTCGridControl.Enabled = false;
                groupBoxLopTC.Visible = true;
                barSubItemThem.Enabled = false;
                barSubItemXoa.Enabled = false;
                barSubItemSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            if (status == "editCTLopTC")
            {
                lopTinChiGridControl.Enabled = false;
                cTLopTCGridControl.Enabled = false;
                groupBoxCTLopTC.Visible = true;
                barSubItemThem.Enabled = false;
                barSubItemXoa.Enabled = false;
                barSubItemSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                lopTinChiGridControl.Enabled = true;
                cTLopTCGridControl.Enabled = true;
                groupBoxLopTC.Visible = false;
                groupBoxCTLopTC.Visible = false;
                barSubItemThem.Enabled = true;
                barSubItemXoa.Enabled = true;
                barSubItemSua.Enabled = true;
                barbtnLuu.Enabled = true;
                barBtnRefresh.Enabled = true;
            }
        }

        private void ClearErrorLopTC()
        {
            maLopTCTextEdit.ErrorText = "";
        }
        private void ClearErrorCTLopTC()
        {
            thuTextEdit.ErrorText = "";
            buoiTextEdit.ErrorText = "";
        }
        private string AllErrorLop()
        {
            string error = "";
            maLopTCTextEdit.Focus();
            btnOkLopTC.Focus();
            if (maLopTCTextEdit.ErrorText != "") error += maLopTCTextEdit.ErrorText + "\n";
            return error;
        }

        private void barbtnThemLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editLopTC");
            maLopTCTextEdit.Focus();
            lopTinChiBindingSource.AddNew();
        }

        private void barbtnThemCTLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editLopTC");
            thuTextEdit.Focus();
            cTLopTCBindingSource.AddNew();
        }

        private void barbtnXoaLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangKyBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp này vì đã có sinh viên đăng ký.", "Thông báo",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lopTinChiBindingSource.RemoveCurrent();
        }

        private void barbtnSuaLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editLopTC");
        }

        private void barbtnSuaCTLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editCTLopTC");
        }

        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UpdateAll();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FillAllTable();
        }

        private void btnOkLopTC_Click(object sender, EventArgs e)
        {
            string errors = AllErrorLop();
            if (errors != "")
            {
                MessageBox.Show(errors, "Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            try
            {
                ((DataRowView)lopTinChiBindingSource.Current)["MaGV"] = ((DataRowView)giangVienBindingSource.Current)["MaGV"];
                ((DataRowView)lopTinChiBindingSource.Current)["MaMH"] = ((DataRowView)monHocBindingSource.Current)["MaMH"];
                ((DataRowView)lopTinChiBindingSource.Current)["SLDaDangKy"] = 0; 
                lopTinChiBindingSource.EndEdit();
                Layout_Setting("normal");
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(BindingSourceMessage.ToMessage(ex, "Lớp tín chỉ"));
            }
        }

        private void btnHuyLopTC_Click(object sender, EventArgs e)
        {
            lopTinChiBindingSource.CancelEdit();
            ClearErrorLopTC();
            Layout_Setting("normal");
        }

        private void btnOkCTLopTC_Click(object sender, EventArgs e)
        {
            string errors = AllErrorLop();
            if (errors != "")
            {
                MessageBox.Show(errors, "Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            try
            {
                cTLopTCBindingSource.EndEdit();
                Layout_Setting("normal");
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(BindingSourceMessage.ToMessage(ex, "Lớp tín chỉ"));
            }
        }

        private void btnHuyCTLopTC_Click(object sender, EventArgs e)
        {
            cTLopTCBindingSource.CancelEdit();
            ClearErrorCTLopTC();
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
    }
}
