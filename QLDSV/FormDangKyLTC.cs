using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace QLDSV
{
    public partial class FormDangKyLTC : DevExpress.XtraEditors.XtraForm
    {
        bool Flag_Load = false;
        public FormDangKyLTC()
        {
            InitializeComponent();
            sP_List_SV_DangKy_LopTCBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            dangKyBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            cTLopTCBindingSource.DataSource = Program.QLDSVDataSetKhoa;
        }

        private void FormDangKyLTC_Load(object sender, EventArgs e)
        {

        }
        private void Fill_Data()
        {
            Flag_Load = true;
            DateTime now = DateTime.Now;
            int hocKy;
            if (now.Month < 6) hocKy = 2;
            else if (now.Month > 8) hocKy = 1;
            else hocKy = 3;
            Program.SP_List_SV_DangKy_LopTCTableAdapter.Fill(Program.QLDSVDataSetKhoa.SP_List_SV_DangKy_LopTC, now.Year, hocKy);
            dangKyBindingSource.Filter = $"MaSV = '{Program.KetNoiDB.UserName}'";
            foreach (object row in dangKyBindingSource)
            {
                var maLop = ((DataRowView)row)["MaLopTC"];
                int rowHandle = sP_List_SV_DangKy_LopTCBindingSource.Find("MaLopTC", maLop);
                if (rowHandle < 0) continue;
                ((DataRowView)sP_List_SV_DangKy_LopTCBindingSource[rowHandle])["selected"] = true;
            }
        }
        private void sP_List_SV_DangKy_LopTCGridControl_Load(object sender, EventArgs e)
        {
            Fill_Data();
        }

        private void barBtnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Fill_Data();
        }
        private void barbtnLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UpdateAll();
        }
        private void gridViewSP_List_SV_DangKy_LopTC_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var view = (GridView)sender;
                DataRowView row = (DataRowView)view.GetRow(e.RowHandle);
                if ((int)row["SoSvMax"] == (int)row["SLDaDangKy"]) e.Appearance.BackColor = Color.LightGray;
            }
            catch (Exception) { }
        }
        private void gridViewSP_List_SV_DangKy_LopTC_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "selected")
            {
                if ((bool)e.Value == true) SelectDangKy(e.RowHandle);
                else UnselectDangKy(e.RowHandle);
            }
        }
        private void SelectDangKy(int rowHandler)
        {
            var maLopTC = ((DataRowView)sP_List_SV_DangKy_LopTCBindingSource[rowHandler])["MaLopTC"];
            if (dangKyBindingSource.Find("MaLopTC", maLopTC) != -1) return;
            dangKyBindingSource.AddNew();
            ((DataRowView)dangKyBindingSource.Current)["MaLopTC"] = maLopTC;
            ((DataRowView)dangKyBindingSource.Current)["MaSV"] = Program.KetNoiDB.UserName;
            ((DataRowView)dangKyBindingSource.Current)["DiemCC"] = 0;
            ((DataRowView)dangKyBindingSource.Current)["DiemGK"] = 0;
            ((DataRowView)dangKyBindingSource.Current)["DiemCK"] = 0;
            dangKyBindingSource.EndEdit();
        }
        private void UnselectDangKy(int rowHandler)
        {
            var maLopTC = ((DataRowView)sP_List_SV_DangKy_LopTCBindingSource[rowHandler])["MaLopTC"];
            int index = dangKyBindingSource.Find("MaLopTC", maLopTC);
            if (index == -1) return;
            dangKyBindingSource.RemoveAt(index);
        }


        private void sP_List_SV_DangKy_LopTCBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                var row = (DataRowView)((BindingSource)sender).Current;
                cTLopTCBindingSource.Filter = $"MaLopTC = '{row["MaLopTC"].ToString()}'";
            }
            catch (Exception) { }
        }
    }
}
