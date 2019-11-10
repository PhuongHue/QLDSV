namespace QLDSV.Component
{
    partial class UserControlNhapDiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlNhapDiem));
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.sP_Fill_DiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_Fill_DiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewSP_Fill_Lop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemCK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sP_Fill_DiemTableAdapter = new QLDSV.QLDSVDataSetKhoaTableAdapters.SP_Fill_DiemTableAdapter();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemComboBoxLop = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.lopTinChiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchLookUpEditMaLop = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEditMaLopView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLopTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHocKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSvMax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSvMin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSLDaDangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Fill_DiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Fill_DiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_Fill_Lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLopView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_Fill_DiemBindingSource
            // 
            this.sP_Fill_DiemBindingSource.DataMember = "SP_Fill_Diem";
            this.sP_Fill_DiemBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // sP_Fill_DiemGridControl
            // 
            this.sP_Fill_DiemGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sP_Fill_DiemGridControl.DataSource = this.sP_Fill_DiemBindingSource;
            this.sP_Fill_DiemGridControl.Location = new System.Drawing.Point(0, 80);
            this.sP_Fill_DiemGridControl.MainView = this.gridViewSP_Fill_Lop;
            this.sP_Fill_DiemGridControl.Name = "sP_Fill_DiemGridControl";
            this.sP_Fill_DiemGridControl.Size = new System.Drawing.Size(927, 391);
            this.sP_Fill_DiemGridControl.TabIndex = 2;
            this.sP_Fill_DiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSP_Fill_Lop});
            // 
            // gridViewSP_Fill_Lop
            // 
            this.gridViewSP_Fill_Lop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSV,
            this.colHoTen,
            this.colDiemCC,
            this.colDiemGK,
            this.colDiemCK});
            this.gridViewSP_Fill_Lop.GridControl = this.sP_Fill_DiemGridControl;
            this.gridViewSP_Fill_Lop.Name = "gridViewSP_Fill_Lop";
            this.gridViewSP_Fill_Lop.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSP_Fill_Lop_CellValueChanged);
            this.gridViewSP_Fill_Lop.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewSP_Fill_Lop_ValidateRow);
            // 
            // colMaSV
            // 
            this.colMaSV.FieldName = "MaSV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.Visible = true;
            this.colMaSV.VisibleIndex = 0;
            // 
            // colHoTen
            // 
            this.colHoTen.FieldName = "HoTen";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Visible = true;
            this.colHoTen.VisibleIndex = 1;
            // 
            // colDiemCC
            // 
            this.colDiemCC.FieldName = "DiemCC";
            this.colDiemCC.Name = "colDiemCC";
            this.colDiemCC.Visible = true;
            this.colDiemCC.VisibleIndex = 2;
            // 
            // colDiemGK
            // 
            this.colDiemGK.FieldName = "DiemGK";
            this.colDiemGK.Name = "colDiemGK";
            this.colDiemGK.Visible = true;
            this.colDiemGK.VisibleIndex = 3;
            // 
            // colDiemCK
            // 
            this.colDiemCK.FieldName = "DiemCK";
            this.colDiemCK.Name = "colDiemCK";
            this.colDiemCK.Visible = true;
            this.colDiemCK.VisibleIndex = 4;
            // 
            // sP_Fill_DiemTableAdapter
            // 
            this.sP_Fill_DiemTableAdapter.ClearBeforeFill = true;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barbtnLuu,
            this.barBtnRefresh});
            this.barManager.MaxItemId = 7;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBoxLop});
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barbtnLuu
            // 
            this.barbtnLuu.Caption = "Lưu";
            this.barbtnLuu.Id = 3;
            this.barbtnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnLuu.ImageOptions.Image")));
            this.barbtnLuu.Name = "barbtnLuu";
            this.barbtnLuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnLuu_ItemClick);
            // 
            // barBtnRefresh
            // 
            this.barBtnRefresh.Caption = "Làm mới";
            this.barBtnRefresh.Id = 4;
            this.barBtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.Image")));
            this.barBtnRefresh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBtnRefresh.ImageOptions.LargeImage")));
            this.barBtnRefresh.Name = "barBtnRefresh";
            this.barBtnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRefresh_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(927, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 474);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(927, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(927, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
            // 
            // repositoryItemComboBoxLop
            // 
            this.repositoryItemComboBoxLop.AutoHeight = false;
            this.repositoryItemComboBoxLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxLop.Name = "repositoryItemComboBoxLop";
            // 
            // lopTinChiBindingSource
            // 
            this.lopTinChiBindingSource.DataMember = "LopTinChi";
            this.lopTinChiBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã lớp TC";
            // 
            // searchLookUpEditMaLop
            // 
            this.searchLookUpEditMaLop.EditValue = "Text";
            this.searchLookUpEditMaLop.Location = new System.Drawing.Point(63, 53);
            this.searchLookUpEditMaLop.MenuManager = this.barManager;
            this.searchLookUpEditMaLop.Name = "searchLookUpEditMaLop";
            this.searchLookUpEditMaLop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookUpEditMaLop.Properties.DataSource = this.lopTinChiBindingSource;
            this.searchLookUpEditMaLop.Properties.DisplayMember = "MaLopTC";
            this.searchLookUpEditMaLop.Properties.ValueMember = "MaLopTC";
            this.searchLookUpEditMaLop.Properties.View = this.searchLookUpEditMaLopView;
            this.searchLookUpEditMaLop.Size = new System.Drawing.Size(335, 20);
            this.searchLookUpEditMaLop.TabIndex = 11;
            this.searchLookUpEditMaLop.EditValueChanged += new System.EventHandler(this.searchLookUpEditMaLop_EditValueChanged);
            // 
            // searchLookUpEditMaLopView
            // 
            this.searchLookUpEditMaLopView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLopTC,
            this.colMaGV,
            this.colMaMH,
            this.colHocKy,
            this.colNam,
            this.colSoSvMax,
            this.colSoSvMin,
            this.colNhom,
            this.colSLDaDangKy});
            this.searchLookUpEditMaLopView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEditMaLopView.Name = "searchLookUpEditMaLopView";
            this.searchLookUpEditMaLopView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEditMaLopView.OptionsView.ShowGroupPanel = false;
            // 
            // colMaLopTC
            // 
            this.colMaLopTC.FieldName = "MaLopTC";
            this.colMaLopTC.MinWidth = 30;
            this.colMaLopTC.Name = "colMaLopTC";
            this.colMaLopTC.Visible = true;
            this.colMaLopTC.VisibleIndex = 0;
            this.colMaLopTC.Width = 30;
            // 
            // colMaGV
            // 
            this.colMaGV.FieldName = "MaGV";
            this.colMaGV.MinWidth = 30;
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 1;
            this.colMaGV.Width = 30;
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.MinWidth = 30;
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 2;
            this.colMaMH.Width = 30;
            // 
            // colHocKy
            // 
            this.colHocKy.FieldName = "HocKy";
            this.colHocKy.MinWidth = 30;
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.Visible = true;
            this.colHocKy.VisibleIndex = 3;
            this.colHocKy.Width = 30;
            // 
            // colNam
            // 
            this.colNam.FieldName = "Nam";
            this.colNam.MinWidth = 30;
            this.colNam.Name = "colNam";
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 4;
            this.colNam.Width = 30;
            // 
            // colSoSvMax
            // 
            this.colSoSvMax.FieldName = "SoSvMax";
            this.colSoSvMax.MinWidth = 30;
            this.colSoSvMax.Name = "colSoSvMax";
            this.colSoSvMax.Visible = true;
            this.colSoSvMax.VisibleIndex = 5;
            this.colSoSvMax.Width = 30;
            // 
            // colSoSvMin
            // 
            this.colSoSvMin.FieldName = "SoSvMin";
            this.colSoSvMin.MinWidth = 30;
            this.colSoSvMin.Name = "colSoSvMin";
            this.colSoSvMin.Visible = true;
            this.colSoSvMin.VisibleIndex = 6;
            this.colSoSvMin.Width = 30;
            // 
            // colNhom
            // 
            this.colNhom.FieldName = "Nhom";
            this.colNhom.MinWidth = 30;
            this.colNhom.Name = "colNhom";
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 7;
            this.colNhom.Width = 30;
            // 
            // colSLDaDangKy
            // 
            this.colSLDaDangKy.FieldName = "SLDaDangKy";
            this.colSLDaDangKy.MinWidth = 30;
            this.colSLDaDangKy.Name = "colSLDaDangKy";
            this.colSLDaDangKy.Visible = true;
            this.colSLDaDangKy.VisibleIndex = 8;
            this.colSLDaDangKy.Width = 30;
            // 
            // dangKyBindingSource
            // 
            this.dangKyBindingSource.AllowNew = true;
            this.dangKyBindingSource.DataMember = "FK_DangKy_LopTinChi";
            this.dangKyBindingSource.DataSource = this.lopTinChiBindingSource;
            // 
            // UserControlNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchLookUpEditMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sP_Fill_DiemGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlNhapDiem";
            this.Size = new System.Drawing.Size(927, 474);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Fill_DiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_Fill_DiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_Fill_Lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLopView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.BindingSource sP_Fill_DiemBindingSource;
        private DevExpress.XtraGrid.GridControl sP_Fill_DiemGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSP_Fill_Lop;
        private QLDSVDataSetKhoaTableAdapters.SP_Fill_DiemTableAdapter sP_Fill_DiemTableAdapter;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private System.Windows.Forms.BindingSource lopTinChiBindingSource;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxLop;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookUpEditMaLop;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEditMaLopView;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLopTC;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colHocKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNam;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSvMax;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSvMin;
        private DevExpress.XtraGrid.Columns.GridColumn colNhom;
        private DevExpress.XtraGrid.Columns.GridColumn colSLDaDangKy;
        private System.Windows.Forms.BindingSource dangKyBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHoTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemGK;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemCK;
    }
}
