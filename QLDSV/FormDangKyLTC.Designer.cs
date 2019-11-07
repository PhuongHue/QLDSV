namespace QLDSV
{
    partial class FormDangKyLTC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.sP_List_SV_DangKy_LopTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_SV_DangKy_LopTCTableAdapter = new QLDSV.QLDSVDataSetKhoaTableAdapters.SP_List_SV_DangKy_LopTCTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetKhoaTableAdapters.TableAdapterManager();
            this.sP_List_SV_DangKy_LopTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewSP_List_SV_DangKy_LopTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLopTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSvMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSvMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDaDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSelect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_List_SV_DangKy_LopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_List_SV_DangKy_LopTCBindingSource
            // 
            this.sP_List_SV_DangKy_LopTCBindingSource.DataMember = "SP_List_SV_DangKy_LopTC";
            this.sP_List_SV_DangKy_LopTCBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // sP_List_SV_DangKy_LopTCTableAdapter
            // 
            this.sP_List_SV_DangKy_LopTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChuyenNganhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CTLopTCTableAdapter = null;
            this.tableAdapterManager.CTTruongKhoaTableAdapter = null;
            this.tableAdapterManager.DangKyTableAdapter = null;
            this.tableAdapterManager.GiangVienTableAdapter = null;
            this.tableAdapterManager.KeHoachGiangTableAdapter = null;
            this.tableAdapterManager.KhaNangDayTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.LopTableAdapter = null;
            this.tableAdapterManager.LopTinChiTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = null;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetKhoaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sP_List_SV_DangKy_LopTCGridControl
            // 
            this.sP_List_SV_DangKy_LopTCGridControl.DataSource = this.sP_List_SV_DangKy_LopTCBindingSource;
            this.sP_List_SV_DangKy_LopTCGridControl.Location = new System.Drawing.Point(12, 12);
            this.sP_List_SV_DangKy_LopTCGridControl.MainView = this.gridViewSP_List_SV_DangKy_LopTC;
            this.sP_List_SV_DangKy_LopTCGridControl.Name = "sP_List_SV_DangKy_LopTCGridControl";
            this.sP_List_SV_DangKy_LopTCGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit});
            this.sP_List_SV_DangKy_LopTCGridControl.Size = new System.Drawing.Size(890, 261);
            this.sP_List_SV_DangKy_LopTCGridControl.TabIndex = 1;
            this.sP_List_SV_DangKy_LopTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSP_List_SV_DangKy_LopTC});
            // 
            // gridViewSP_List_SV_DangKy_LopTC
            // 
            this.gridViewSP_List_SV_DangKy_LopTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLopTC,
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colMaMH,
            this.colTenMH,
            this.colHocKy,
            this.colNam,
            this.colSoSvMax,
            this.colSoSvMin,
            this.colNhom,
            this.colSLDaDangKy,
            this.colSelect});
            this.gridViewSP_List_SV_DangKy_LopTC.GridControl = this.sP_List_SV_DangKy_LopTCGridControl;
            this.gridViewSP_List_SV_DangKy_LopTC.Name = "gridViewSP_List_SV_DangKy_LopTC";
            // 
            // colMaLopTC
            // 
            this.colMaLopTC.FieldName = "MaLopTC";
            this.colMaLopTC.Name = "colMaLopTC";
            this.colMaLopTC.Visible = true;
            this.colMaLopTC.VisibleIndex = 0;
            // 
            // colMaGV
            // 
            this.colMaGV.FieldName = "MaGV";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 1;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 2;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 4;
            // 
            // colTenMH
            // 
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 5;
            // 
            // colHocKy
            // 
            this.colHocKy.FieldName = "HocKy";
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.Visible = true;
            this.colHocKy.VisibleIndex = 6;
            // 
            // colNam
            // 
            this.colNam.FieldName = "Nam";
            this.colNam.Name = "colNam";
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 7;
            // 
            // colSoSvMax
            // 
            this.colSoSvMax.FieldName = "SoSvMax";
            this.colSoSvMax.Name = "colSoSvMax";
            this.colSoSvMax.Visible = true;
            this.colSoSvMax.VisibleIndex = 8;
            // 
            // colSoSvMin
            // 
            this.colSoSvMin.FieldName = "SoSvMin";
            this.colSoSvMin.Name = "colSoSvMin";
            this.colSoSvMin.Visible = true;
            this.colSoSvMin.VisibleIndex = 9;
            // 
            // colNhom
            // 
            this.colNhom.FieldName = "Nhom";
            this.colNhom.Name = "colNhom";
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 10;
            // 
            // colSLDaDangKy
            // 
            this.colSLDaDangKy.FieldName = "SLDaDangKy";
            this.colSLDaDangKy.Name = "colSLDaDangKy";
            this.colSLDaDangKy.Visible = true;
            this.colSLDaDangKy.VisibleIndex = 11;
            // 
            // colSelect
            // 
            this.colSelect.Caption = "Chọn";
            this.colSelect.ColumnEdit = this.repositoryItemCheckEdit;
            this.colSelect.Name = "colSelect";
            this.colSelect.Visible = true;
            this.colSelect.VisibleIndex = 12;
            // 
            // repositoryItemCheckEdit
            // 
            this.repositoryItemCheckEdit.AutoHeight = false;
            this.repositoryItemCheckEdit.Name = "repositoryItemCheckEdit";
            this.repositoryItemCheckEdit.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEdit_CheckedChanged);
            // 
            // FormDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 481);
            this.Controls.Add(this.sP_List_SV_DangKy_LopTCGridControl);
            this.Name = "FormDangKyLTC";
            this.Text = "FormDangKyLTC";
            this.Load += new System.EventHandler(this.FormDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_List_SV_DangKy_LopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.BindingSource sP_List_SV_DangKy_LopTCBindingSource;
        private QLDSVDataSetKhoaTableAdapters.SP_List_SV_DangKy_LopTCTableAdapter sP_List_SV_DangKy_LopTCTableAdapter;
        private QLDSVDataSetKhoaTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sP_List_SV_DangKy_LopTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSP_List_SV_DangKy_LopTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLopTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSvMax;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSvMin;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDaDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colSelect;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit;
    }
}