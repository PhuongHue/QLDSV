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
        bool newLTC = false;
        
        public UserControlLopTC()
        {
            InitializeComponent();
        }

        public void UserControlLopTC_Load()
        {
            khoaBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            giangVienBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            monHocBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            comboBoxThu.SelectedItem = comboBoxThu.Items[0];
            comboBoxBuoi.SelectedItem = comboBoxBuoi.Items[0];
        }

        private void Layout_Setting(string status)
        {
            if (status == "editLopTC")
            {
                lopTinChiGridControl.Enabled = false;
                lichHocGridControl.Enabled = false;
                groupBoxLopTC.Visible = true;
                barSubItemThem.Enabled = false;
                barSubItemXoa.Enabled = false;
                barSubItemSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
                newLTC = false;
            }
            if (status == "editCTLopTC")
            {
                lopTinChiGridControl.Enabled = false;
                lichHocGridControl.Enabled = false;
                groupBoxLichHoc.Visible = true;
                barSubItemThem.Enabled = false;
                barSubItemXoa.Enabled = false;
                barSubItemSua.Enabled = false;
                barbtnLuu.Enabled = false;
                barBtnRefresh.Enabled = false;
            }
            else if (status == "normal")
            {
                lopTinChiGridControl.Enabled = true;
                lichHocGridControl.Enabled = true;
                groupBoxLopTC.Visible = false;
                groupBoxLichHoc.Visible = false;
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
            soSvMaxSpinEdit.ErrorText = "";
        }
        private void ClearErrorCTLopTC()
        {

        }
        private string AllErrorLop()
        {
            string error = "";
            maLopTCTextEdit.Focus();
            btnOkLopTC.Focus();
            if (maLopTCTextEdit.ErrorText != "") error += maLopTCTextEdit.ErrorText + "\n";
            if (soSvMaxSpinEdit.ErrorText != "") error += soSvMaxSpinEdit.ErrorText + "\n";
            return error;
        }

        private void barbtnThemLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editLopTC");
            newLTC = true;
            maLopTCTextEdit.Focus();
            lopTinChiBindingSource.AddNew();
        }

        private void barbtnThemLichHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editCTLopTC");
            comboBoxThu.Focus();
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

        private void barbtnXoaLichHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                cTLopTCBindingSource.RemoveCurrent();
        }

        private void barbtnSuaLopTC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Layout_Setting("editLopTC");
        }

        private void barbtnSuaLichHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
                if(newLTC) ((DataRowView)lopTinChiBindingSource.Current)["SLDaDangKy"] = 0;
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

        private void btnOkLichHoc_Click(object sender, EventArgs e)
        {
            ((DataRowView)cTLopTCBindingSource.Current)["Thu"] = comboBoxThu.SelectedItem.ToString();
            ((DataRowView)cTLopTCBindingSource.Current)["Buoi"] = comboBoxBuoi.SelectedItem.ToString();
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

        private void btnHuyLichHoc_Click(object sender, EventArgs e)
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

        private void soSvMaxSpinEdit_Validating(object sender, CancelEventArgs e)
        {
            if(soSvMinSpinEdit.Value> soSvMaxSpinEdit.Value)
            {
                soSvMaxSpinEdit.ErrorText = "Số sinh viên tối thiểu không được lớn hơn số sinh viên tối đa";
            }
        }

        private void barBtnPrintBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maLop = (string)((DataRowView)lopTinChiBindingSource.Current)["MaLopTC"];
            new Reports.ReportBangDiemTongKet(maLop);
        }

        private void barBtnPrintDSTHM_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string maLop = (string)((DataRowView)lopTinChiBindingSource.Current)["MaLopTC"];
            string maMH = (string)((DataRowView)lopTinChiBindingSource.Current)["MaMH"];
            int indexMH = monHocBindingSource.Find("MaMH",maMH);
            string tenMH = (string)((DataRowView)monHocBindingSource[indexMH])["TenMH"];
            new Reports.FormPrintDSTHM(maLop,tenMH).Show();
        }

    }
}
