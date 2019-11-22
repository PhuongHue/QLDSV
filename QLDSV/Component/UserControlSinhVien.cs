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
using System.Data.SqlClient;
using QLDSV.Component;

namespace QLDSV
{
    public partial class UserControlSinhVien : DevExpress.XtraEditors.XtraUserControl
    {
        bool IsAddNew = false;
        public UserControlSinhVien()
        {
            InitializeComponent();
        }
        public void UserControlSinhVien_Load()
        {
            lopBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            chuyenNganhBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }
        private void Layout_Setting(string status)
        {
            if (status == "edit")
            {
                groupBoxLop.Enabled = false;
                sinhVienGridControl.Enabled = false;
                groupBoxSinhVien.Enabled = true;
                barBtnChuyenLop.Enabled = false;
                barbtnThem.Enabled = false;
                barbtnXoa.Enabled = false;
                barbtnSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                groupBoxLop.Enabled = true;
                sinhVienGridControl.Enabled = true;
                groupBoxSinhVien.Enabled = false;
                barBtnChuyenLop.Enabled = true;
                barbtnThem.Enabled = true;
                barbtnXoa.Enabled = true;
                barbtnSua.Enabled = true;
                barbtnLuu.Enabled = true;
                barBtnRefresh.Enabled = true;
            }
        }
        private void ClearErrorSinhVien()
        {
            maSVTextEdit.ErrorText = "";
            hoTextEdit.ErrorText = "";
            tenTextEdit.ErrorText = "";
            diaChiTextEdit.ErrorText = "";
        }
        private string AllErrorSinhVien()
        {
            string errors = "";
            maSVTextEdit.Focus();
            hoTextEdit.Focus();
            tenTextEdit.Focus();
            diaChiTextEdit.Focus();
            btnOkSinhVien.Focus();
            if (maSVTextEdit.ErrorText != "") errors += maSVTextEdit.ErrorText + "\n";
            if (hoTextEdit.ErrorText != "") errors += hoTextEdit.ErrorText + "\n";
            if (tenTextEdit.ErrorText != "") errors += tenTextEdit.ErrorText + "\n";
            if (diaChiTextEdit.ErrorText != "") errors += diaChiTextEdit.ErrorText + "\n";
            return errors;
        }
        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
            IsAddNew = true;
            maSVTextEdit.Focus();
            sinhVienBindingSource.AddNew();

        }

        private void barBtnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangKyBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì đã có đăng ký môn học.", "Thông báo",
                       MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                sinhVienBindingSource.RemoveCurrent();
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
            string errors = AllErrorSinhVien();
            if (errors != "")
            {
                MessageBox.Show(errors, "Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            ((DataRowView)sinhVienBindingSource.Current)["Phai"] = comboBoxPhai.SelectedItem.ToString();
            ((DataRowView)sinhVienBindingSource.Current)["MaCN"] = ((DataRowView)chuyenNganhBindingSource.Current)["MaCN"];
            try
            {
                sinhVienBindingSource.EndEdit();
                Layout_Setting("normal");
                if (IsAddNew == false) return;
                string MaSV = (string)((DataRowView)sinhVienBindingSource.Current)["MaSV"];
                string cmdString = $"SP_TaoLogin @LGNAME = N'{MaSV}', @PASS = NULL, @USERNAME = N'{MaSV}', @ROLE = N'SinhVien'";
                try
                {
                    var resReader = Program.KetNoiDB.ExcuteSP(cmdString);
                    resReader.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message + " Code: " + ex.Number);
                }
            }
            catch (ConstraintException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnSinhVienHuy_Click(object sender, EventArgs e)
        {
            sinhVienBindingSource.CancelEdit();
            ClearErrorSinhVien();
            Layout_Setting("normal");
            IsAddNew = false;
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

        private void barBtnChuyenLop_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maSV = (string)((DataRowView)sinhVienBindingSource.Current)["MaSV"];
            string ten = (string)((DataRowView)sinhVienBindingSource.Current)["Ten"];
            string currentMaLop = (string)((DataRowView)sinhVienBindingSource.Current)["MaLop"];
            FormChuyenLop form = new FormChuyenLop(ten, maSV, currentMaLop);
            form.Show();
            form.Disposed += Form_Disposed;
        }

        private void Form_Disposed(object sender, EventArgs e)
        {
            Program.UpdateAll();
            Program.FillAllTable();
        }

        private void sinhVienBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                var source = (BindingSource)sender;
                var row = (DataRowView)source.Current;
                int index = chuyenNganhBindingSource.Find("MaCN", row["MaCN"]);
                chuyenNganhBindingSource.Position = index;
            }
            catch (Exception)
            {

            }
        }
    }
}
