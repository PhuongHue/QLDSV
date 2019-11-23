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
            this.v_NhapDiemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_NhapDiemGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewV_NhapDiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLopTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemGK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiemCK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLopView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_NhapDiemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_NhapDiemGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewV_NhapDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // v_NhapDiemBindingSource
            // 
            this.v_NhapDiemBindingSource.AllowNew = false;
            this.v_NhapDiemBindingSource.DataMember = "V_NhapDiem";
            this.v_NhapDiemBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // v_NhapDiemGridControl
            // 
            this.v_NhapDiemGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.v_NhapDiemGridControl.DataSource = this.v_NhapDiemBindingSource;
            this.v_NhapDiemGridControl.Location = new System.Drawing.Point(0, 79);
            this.v_NhapDiemGridControl.MainView = this.gridViewV_NhapDiem;
            this.v_NhapDiemGridControl.MenuManager = this.barManager;
            this.v_NhapDiemGridControl.Name = "v_NhapDiemGridControl";
            this.v_NhapDiemGridControl.Size = new System.Drawing.Size(927, 395);
            this.v_NhapDiemGridControl.TabIndex = 15;
            this.v_NhapDiemGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewV_NhapDiem});
            // 
            // gridViewV_NhapDiem
            // 
            this.gridViewV_NhapDiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLopTC1,
            this.colMaSV,
            this.colHo,
            this.colTen,
            this.colDiemCC,
            this.colDiemGK,
            this.colDiemCK});
            this.gridViewV_NhapDiem.GridControl = this.v_NhapDiemGridControl;
            this.gridViewV_NhapDiem.Name = "gridViewV_NhapDiem";
            this.gridViewV_NhapDiem.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewV_NhapDiem_CellValueChanged);
            this.gridViewV_NhapDiem.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridViewV_NhapDiem_ValidateRow);
            // 
            // colMaLopTC1
            // 
            this.colMaLopTC1.FieldName = "MaLopTC";
            this.colMaLopTC1.Name = "colMaLopTC1";
            this.colMaLopTC1.OptionsColumn.AllowEdit = false;
            this.colMaLopTC1.Visible = true;
            this.colMaLopTC1.VisibleIndex = 0;
            // 
            // colMaSV
            // 
            this.colMaSV.FieldName = "MaSV";
            this.colMaSV.Name = "colMaSV";
            this.colMaSV.OptionsColumn.AllowEdit = false;
            this.colMaSV.Visible = true;
            this.colMaSV.VisibleIndex = 1;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.AllowEdit = false;
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 2;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 3;
            // 
            // colDiemCC
            // 
            this.colDiemCC.FieldName = "DiemCC";
            this.colDiemCC.Name = "colDiemCC";
            this.colDiemCC.Visible = true;
            this.colDiemCC.VisibleIndex = 4;
            // 
            // colDiemGK
            // 
            this.colDiemGK.FieldName = "DiemGK";
            this.colDiemGK.Name = "colDiemGK";
            this.colDiemGK.Visible = true;
            this.colDiemGK.VisibleIndex = 5;
            // 
            // colDiemCK
            // 
            this.colDiemCK.FieldName = "DiemCK";
            this.colDiemCK.Name = "colDiemCK";
            this.colDiemCK.Visible = true;
            this.colDiemCK.VisibleIndex = 6;
            // 
            // UserControlNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.v_NhapDiemGridControl);
            this.Controls.Add(this.searchLookUpEditMaLop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlNhapDiem";
            this.Size = new System.Drawing.Size(927, 474);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopTinChiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEditMaLopView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_NhapDiemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_NhapDiemGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewV_NhapDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
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
        private DevExpress.XtraGrid.GridControl v_NhapDiemGridControl;
        private System.Windows.Forms.BindingSource v_NhapDiemBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewV_NhapDiem;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLopTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemCC;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemGK;
        private DevExpress.XtraGrid.Columns.GridColumn colDiemCK;
    }
}
