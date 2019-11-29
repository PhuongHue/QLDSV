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
using DevExpress.XtraGrid.Views.Grid;
using BatLoi;
using System.Data.SqlClient;

namespace QLDSV.Component
{
    public partial class UserControlNhapDiem : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlNhapDiem()
        {
            InitializeComponent();
            if (Program.KetNoiDB.GroupId == "PGV")
            {
                colDiemCC.OptionsColumn.ReadOnly = colDiemGK.OptionsColumn.ReadOnly = colDiemCK.OptionsColumn.ReadOnly = true;
            }
        }

        public void UserControlNhapDiem_Load()
        {
            lopTinChiBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            v_NhapDiemBindingSource.DataSource = Program.QLDSVDataSetKhoa;
           
            if(Program.KetNoiDB.GroupId == "Khoa")
            {
                lopTinChiBindingSource.Filter = $"MaGV = '{Program.KetNoiDB.UserName}'";
                string MaLopTC = (string)searchLookUpEditMaLop.EditValue;
                v_NhapDiemBindingSource.Filter = $"MaLopTC = '{MaLopTC}'";
            }
           
        }

        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                Program.TableAdapterManager.V_NhapDiemTableAdapter.Update(Program.QLDSVDataSetKhoa.V_NhapDiem);
                MessageBox.Show("Nhập điểm thành công", "Thông báo");
            } catch (SqlException ex)
            {

            }
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FillAllTable();
        }

        private void searchLookUpEditMaLop_EditValueChanged(object sender, EventArgs e)
        {
            string MaLopTC = (string)searchLookUpEditMaLop.EditValue;
            v_NhapDiemBindingSource.Filter = $"MaLopTC = '{MaLopTC}'";
        }

        private void gridViewV_NhapDiem_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = (GridView)sender;
            string error = "";
            switch (e.Column.FieldName)
            {
                case "DiemCC":
                    error = Validation.ValidateScore("Điểm chuyên cần", (Double)e.Value);
                    break;
                case "DiemGK":
                    error = Validation.ValidateScore("Điểm giữa kỳ", (Double)e.Value);
                    break;
                case "DiemCK":
                    error = Validation.ValidateScore("Điểm cuối kỳ", (Double)e.Value);
                    break;
            }
            view.SetColumnError(view.Columns[e.Column.FieldName], error);
        }

        private void gridViewV_NhapDiem_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            var view = (GridView)sender;
            if (view.HasColumnErrors)
            {
                string errors = "";
                if (view.GetColumnError(colDiemCC) != "") errors += view.GetColumnError(colDiemCC) + '\n';
                if (view.GetColumnError(colDiemGK) != "") errors += view.GetColumnError(colDiemGK) + '\n';
                if (view.GetColumnError(colDiemCK) != "") errors += view.GetColumnError(colDiemCK);
                MessageBox.Show(errors);
                e.Valid = false;
            }
        }
    }
}
