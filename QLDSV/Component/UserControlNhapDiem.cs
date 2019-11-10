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

namespace QLDSV.Component
{
    public partial class UserControlNhapDiem : DevExpress.XtraEditors.XtraUserControl
    {
        public UserControlNhapDiem()
        {
            InitializeComponent();
        }

        public void UserControlNhapDiem_Load()
        {
            lopTinChiBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            sP_Fill_DiemBindingSource.DataSource = Program.QLDSVDataSetKhoa.SP_Fill_Diem;
            sP_Fill_DiemTableAdapter.Connection = Program.KetNoiDB.SqlConnection;
        }

        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UpdateAll();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.FillAllTable();
        }

        private void searchLookUpEditMaLop_EditValueChanged(object sender, EventArgs e)
        {
            string MaLopTC = (string)searchLookUpEditMaLop.EditValue;
            lopTinChiBindingSource.Position = lopTinChiBindingSource.Find("MaLopTC", MaLopTC);
            sP_Fill_DiemTableAdapter.Fill(Program.QLDSVDataSetKhoa.SP_Fill_Diem, MaLopTC);
        }

        private void gridViewSP_Fill_Lop_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            string MaSV = ((DataRowView)sP_Fill_DiemBindingSource[e.RowHandle])["MaSV"].ToString();
            int postion = dangKyBindingSource.Find("MaSV", MaSV);
            bool isNew = false;
            if (postion == -1)
            {
                isNew = true;
                dangKyBindingSource.AddNew();
                postion = dangKyBindingSource.Position;
                ((DataRowView)dangKyBindingSource[postion])["MaSV"] = ((DataRowView)sP_Fill_DiemBindingSource[e.RowHandle])["MaSV"];
                ((DataRowView)dangKyBindingSource[postion])["MaLopTC"] = searchLookUpEditMaLop.EditValue;
            };
            ((DataRowView)dangKyBindingSource[postion])["DiemCC"] = (double)((DataRowView)sP_Fill_DiemBindingSource[e.RowHandle])["DiemCC"];
            ((DataRowView)dangKyBindingSource[postion])["DiemGK"] = (double)((DataRowView)sP_Fill_DiemBindingSource[e.RowHandle])["DiemGK"];
            ((DataRowView)dangKyBindingSource[postion])["DiemCK"] = (double)((DataRowView)sP_Fill_DiemBindingSource[e.RowHandle])["DiemCK"];
            if (isNew) dangKyBindingSource.EndEdit();
        }

        private void gridViewSP_Fill_Lop_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = (GridView)sender;
            string error ="";
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
    }
}
