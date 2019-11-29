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
        bool[] HetSoLuong;
        public FormDangKyLTC()
        {
            InitializeComponent();
            sP_List_SV_DangKy_LopTCBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            dangKyBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            cTLopTCBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            sinhVienBindingSource.DataSource = Program.QLDSVDataSetKhoa;
            dangKyBindingSource.Filter = $"MaSV = '{Program.KetNoiDB.UserName}' ";
            txtStripMaSV.Text += Program.KetNoiDB.UserName;
            int index = sinhVienBindingSource.Find("MaSV", Program.KetNoiDB.UserName);
            if(index != -1)
            {
                string ho = (string)((DataRowView)sinhVienBindingSource[index])["Ho"];
                string ten = (string)((DataRowView)sinhVienBindingSource[index])["Ten"];
                txtStripHoTen.Text += $"{ho} {ten}";
            }

        }

        private void FormDangKyLTC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSVDataSetKhoa.SinhVien' table. You can move, or remove it, as needed.
            this.sinhVienTableAdapter.Fill(this.qLDSVDataSetKhoa.SinhVien);

        }

        private void Fill_Data()
        {
            DateTime now = DateTime.Now;
            int hocKy;
            if (now.Month < 6) hocKy = 2;
            else if (now.Month > 8) hocKy = 1;
            else hocKy = 3;
            string listLTC = "and MaLopTC in (";

            Program.SP_List_SV_DangKy_LopTCTableAdapter.Fill(Program.QLDSVDataSetKhoa.SP_List_SV_DangKy_LopTC, now.Year, hocKy);
            HetSoLuong = new bool[sP_List_SV_DangKy_LopTCBindingSource.Count];
            for (int i = 0; i < HetSoLuong.Length; i++)
            {
                HetSoLuong[i] = false;
            }
            foreach (object row in sP_List_SV_DangKy_LopTCBindingSource)
            {
                string maLop = ((DataRowView)row)["MaLopTC"].ToString();
                listLTC += $"'{maLop}', ";

            }
            listLTC = listLTC.TrimEnd(new char[] { ',', ' ' });
            listLTC += ")";
            string filter = $"MaSV = '{Program.KetNoiDB.UserName}' ";
            if (sP_List_SV_DangKy_LopTCBindingSource.Count > 0) filter += listLTC;
            dangKyBindingSource.Filter = filter;

            foreach (object row in dangKyBindingSource)
            {
                string maLop = ((DataRowView)row)["MaLopTC"].ToString();
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

        private void gridViewSP_List_SV_DangKy_LopTC_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            var view = (GridView)sender;
            if (e.Column.FieldName == "selected")
            {
                if (HetSoLuong[e.RowHandle])
                {
                    view.SetRowCellValue(e.RowHandle, "selected", false);
                }
                else
                {
                    if ((bool)e.Value == true) SelectDangKy(e.RowHandle);
                    else UnselectDangKy(e.RowHandle);
                }

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
            try { dangKyBindingSource.EndEdit(); }
            catch (Exception) { }
        }

        private void UnselectDangKy(int rowHandler)
        {
            var maLopTC = ((DataRowView)sP_List_SV_DangKy_LopTCBindingSource[rowHandler])["MaLopTC"];
            int index = dangKyBindingSource.Find("MaLopTC", maLopTC);
            if (index == -1) return;
            if ((double)((DataRowView)dangKyBindingSource[index])["DiemCC"] != 0
                || (double)((DataRowView)dangKyBindingSource[index])["DiemGK"] != 0
                || (double)((DataRowView)dangKyBindingSource[index])["DiemCK"] != 0)
                MessageBox.Show("Không thể hủy đăng ký vì đã bắt đầu học.", "Thông báo");
            else
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

        private void gridViewSP_List_SV_DangKy_LopTC_RowStyle(object sender, RowStyleEventArgs e)
        {
            try
            {
                var view = (GridView)sender;
                DataRowView row = (DataRowView)view.GetRow(e.RowHandle);
                if ((int)row["SoSvMax"] == (int)row["SLDaDangKy"])
                {
                    HetSoLuong[e.RowHandle] = true;
                    e.Appearance.BackColor = Color.LightGray;
                }
            }
            catch (Exception) { }
        }
    }
}
