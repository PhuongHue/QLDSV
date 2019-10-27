﻿using System;
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

namespace QLDSV
{
    public partial class UserControlSinhVien : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlSinhVien()
        {
            InitializeComponent();
            comboBoxPhai.SelectedItem = comboBoxPhai.Items[0];
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
            maCNTextEdit.ErrorText = "";
            diaChiTextEdit.ErrorText = "";
        }
        private bool HasErrorSinhVien()
        {
            if (maSVTextEdit.ErrorText != "") return true;
            if (hoTextEdit.ErrorText != "") return true;
            if (tenTextEdit.ErrorText != "") return true;
            if (maCNTextEdit.ErrorText != "") return true;
            if (diaChiTextEdit.ErrorText != "") return true;
            return false;
        }
        private void barbtnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("edit");
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

        private void btnOkSinhVien_Click(object sender, EventArgs e)
        {
            hoTextEdit.Focus();
            tenTextEdit.Focus();
            maCNTextEdit.Focus();
            maSVTextEdit.Focus();
            diaChiTextEdit.Focus();
            if (HasErrorSinhVien())
            {
                MessageBox.Show("Lỗi nhập liệu, vui lòng sửa lại");
                return;
            }
            ((DataRowView)sinhVienBindingSource.Current)["Phai"] = comboBoxPhai.SelectedItem.ToString();
            try
            {
                sinhVienBindingSource.EndEdit();
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

        }

        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UpdateAll();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FillAllTable();
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