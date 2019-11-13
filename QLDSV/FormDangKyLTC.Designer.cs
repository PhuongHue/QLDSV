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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangKyLTC));
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.sP_List_SV_DangKy_LopTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_SV_DangKy_LopTCTableAdapter = new QLDSV.QLDSVDataSetKhoaTableAdapters.SP_List_SV_DangKy_LopTCTableAdapter();
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
            this.colselected = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cTLopTCGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTLopTCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewCTLopTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLopTC2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLopTC1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dangKyTableAdapter = new QLDSV.QLDSVDataSetKhoaTableAdapters.DangKyTableAdapter();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemComboBoxLop = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_List_SV_DangKy_LopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBindingSource)).BeginInit();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTLopTCGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTLopTCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTLopTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).BeginInit();
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
            this.sP_List_SV_DangKy_LopTCBindingSource.CurrentChanged += new System.EventHandler(this.sP_List_SV_DangKy_LopTCBindingSource_CurrentChanged);
            // 
            // sP_List_SV_DangKy_LopTCTableAdapter
            // 
            this.sP_List_SV_DangKy_LopTCTableAdapter.ClearBeforeFill = true;
            // 
            // sP_List_SV_DangKy_LopTCGridControl
            // 
            this.sP_List_SV_DangKy_LopTCGridControl.DataSource = this.sP_List_SV_DangKy_LopTCBindingSource;
            this.sP_List_SV_DangKy_LopTCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_List_SV_DangKy_LopTCGridControl.Location = new System.Drawing.Point(3, 3);
            this.sP_List_SV_DangKy_LopTCGridControl.MainView = this.gridViewSP_List_SV_DangKy_LopTC;
            this.sP_List_SV_DangKy_LopTCGridControl.Name = "sP_List_SV_DangKy_LopTCGridControl";
            this.sP_List_SV_DangKy_LopTCGridControl.Size = new System.Drawing.Size(916, 222);
            this.sP_List_SV_DangKy_LopTCGridControl.TabIndex = 1;
            this.sP_List_SV_DangKy_LopTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSP_List_SV_DangKy_LopTC});
            this.sP_List_SV_DangKy_LopTCGridControl.Load += new System.EventHandler(this.sP_List_SV_DangKy_LopTCGridControl_Load);
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
            this.colselected});
            this.gridViewSP_List_SV_DangKy_LopTC.GridControl = this.sP_List_SV_DangKy_LopTCGridControl;
            this.gridViewSP_List_SV_DangKy_LopTC.Name = "gridViewSP_List_SV_DangKy_LopTC";
            this.gridViewSP_List_SV_DangKy_LopTC.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridViewSP_List_SV_DangKy_LopTC_RowStyle);
            this.gridViewSP_List_SV_DangKy_LopTC.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewSP_List_SV_DangKy_LopTC_CellValueChanging);
            // 
            // colMaLopTC
            // 
            this.colMaLopTC.FieldName = "MaLopTC";
            this.colMaLopTC.Name = "colMaLopTC";
            this.colMaLopTC.OptionsColumn.AllowEdit = false;
            this.colMaLopTC.Visible = true;
            this.colMaLopTC.VisibleIndex = 0;
            // 
            // colMaGV
            // 
            this.colMaGV.FieldName = "MaGV";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.OptionsColumn.AllowEdit = false;
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 1;
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
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.OptionsColumn.AllowEdit = false;
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 4;
            // 
            // colTenMH
            // 
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.OptionsColumn.AllowEdit = false;
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 5;
            // 
            // colHocKy
            // 
            this.colHocKy.FieldName = "HocKy";
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.OptionsColumn.AllowEdit = false;
            this.colHocKy.Visible = true;
            this.colHocKy.VisibleIndex = 6;
            // 
            // colNam
            // 
            this.colNam.FieldName = "Nam";
            this.colNam.Name = "colNam";
            this.colNam.OptionsColumn.AllowEdit = false;
            this.colNam.Visible = true;
            this.colNam.VisibleIndex = 7;
            // 
            // colSoSvMax
            // 
            this.colSoSvMax.FieldName = "SoSvMax";
            this.colSoSvMax.Name = "colSoSvMax";
            this.colSoSvMax.OptionsColumn.AllowEdit = false;
            this.colSoSvMax.Visible = true;
            this.colSoSvMax.VisibleIndex = 8;
            // 
            // colSoSvMin
            // 
            this.colSoSvMin.FieldName = "SoSvMin";
            this.colSoSvMin.Name = "colSoSvMin";
            this.colSoSvMin.OptionsColumn.AllowEdit = false;
            this.colSoSvMin.Visible = true;
            this.colSoSvMin.VisibleIndex = 9;
            // 
            // colNhom
            // 
            this.colNhom.FieldName = "Nhom";
            this.colNhom.Name = "colNhom";
            this.colNhom.OptionsColumn.AllowEdit = false;
            this.colNhom.Visible = true;
            this.colNhom.VisibleIndex = 10;
            // 
            // colSLDaDangKy
            // 
            this.colSLDaDangKy.FieldName = "SLDaDangKy";
            this.colSLDaDangKy.Name = "colSLDaDangKy";
            this.colSLDaDangKy.OptionsColumn.AllowEdit = false;
            this.colSLDaDangKy.Visible = true;
            this.colSLDaDangKy.VisibleIndex = 11;
            // 
            // colselected
            // 
            this.colselected.FieldName = "selected";
            this.colselected.Name = "colselected";
            this.colselected.Visible = true;
            this.colselected.VisibleIndex = 12;
            // 
            // dangKyBindingSource
            // 
            this.dangKyBindingSource.DataMember = "DangKy";
            this.dangKyBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.cTLopTCGridControl, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dangKyGridControl, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.sP_List_SV_DangKy_LopTCGridControl, 0, 0);
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 47);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(922, 572);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // cTLopTCGridControl
            // 
            this.cTLopTCGridControl.DataSource = this.cTLopTCBindingSource;
            this.cTLopTCGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTLopTCGridControl.Location = new System.Drawing.Point(3, 231);
            this.cTLopTCGridControl.MainView = this.gridViewCTLopTC;
            this.cTLopTCGridControl.Name = "cTLopTCGridControl";
            this.cTLopTCGridControl.Size = new System.Drawing.Size(916, 108);
            this.cTLopTCGridControl.TabIndex = 3;
            this.cTLopTCGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTLopTC});
            // 
            // cTLopTCBindingSource
            // 
            this.cTLopTCBindingSource.DataMember = "CTLopTC";
            this.cTLopTCBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // gridViewCTLopTC
            // 
            this.gridViewCTLopTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLopTC2,
            this.colThu,
            this.colBuoi});
            this.gridViewCTLopTC.GridControl = this.cTLopTCGridControl;
            this.gridViewCTLopTC.Name = "gridViewCTLopTC";
            this.gridViewCTLopTC.OptionsView.ShowGroupPanel = false;
            // 
            // colMaLopTC2
            // 
            this.colMaLopTC2.FieldName = "MaLopTC";
            this.colMaLopTC2.Name = "colMaLopTC2";
            this.colMaLopTC2.OptionsColumn.AllowEdit = false;
            this.colMaLopTC2.Visible = true;
            this.colMaLopTC2.VisibleIndex = 0;
            // 
            // colThu
            // 
            this.colThu.FieldName = "Thu";
            this.colThu.Name = "colThu";
            this.colThu.OptionsColumn.AllowEdit = false;
            this.colThu.Visible = true;
            this.colThu.VisibleIndex = 1;
            // 
            // colBuoi
            // 
            this.colBuoi.FieldName = "Buoi";
            this.colBuoi.Name = "colBuoi";
            this.colBuoi.OptionsColumn.AllowEdit = false;
            this.colBuoi.Visible = true;
            this.colBuoi.VisibleIndex = 2;
            // 
            // dangKyGridControl
            // 
            this.dangKyGridControl.DataSource = this.dangKyBindingSource;
            this.dangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dangKyGridControl.Location = new System.Drawing.Point(3, 345);
            this.dangKyGridControl.MainView = this.gridView1;
            this.dangKyGridControl.Name = "dangKyGridControl";
            this.dangKyGridControl.Size = new System.Drawing.Size(916, 224);
            this.dangKyGridControl.TabIndex = 2;
            this.dangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLopTC1,
            this.colMaSV});
            this.gridView1.GridControl = this.dangKyGridControl;
            this.gridView1.Name = "gridView1";
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
            // dangKyTableAdapter
            // 
            this.dangKyTableAdapter.ClearBeforeFill = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 47);
            this.barDockControlTop.Manager = null;
            this.barDockControlTop.Size = new System.Drawing.Size(922, 0);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControl1);
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
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Size = new System.Drawing.Size(922, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 620);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(922, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 573);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(922, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 573);
            // 
            // repositoryItemComboBoxLop
            // 
            this.repositoryItemComboBoxLop.AutoHeight = false;
            this.repositoryItemComboBoxLop.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBoxLop.Name = "repositoryItemComboBoxLop";
            // 
            // FormDangKyLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 620);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControl1);
            this.Name = "FormDangKyLTC";
            this.Text = "FormDangKyLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDangKyLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_SV_DangKy_LopTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewSP_List_SV_DangKy_LopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyBindingSource)).EndInit();
            this.tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTLopTCGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTLopTCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTLopTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBoxLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.BindingSource sP_List_SV_DangKy_LopTCBindingSource;
        private QLDSVDataSetKhoaTableAdapters.SP_List_SV_DangKy_LopTCTableAdapter sP_List_SV_DangKy_LopTCTableAdapter;
        private DevExpress.XtraGrid.GridControl sP_List_SV_DangKy_LopTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewSP_List_SV_DangKy_LopTC;
        private System.Windows.Forms.BindingSource dangKyBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private DevExpress.XtraGrid.GridControl dangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLopTC1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSV;
        private QLDSVDataSetKhoaTableAdapters.DangKyTableAdapter dangKyTableAdapter;
        private System.Windows.Forms.BindingSource cTLopTCBindingSource;
        private DevExpress.XtraGrid.GridControl cTLopTCGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTLopTC;
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
        private DevExpress.XtraGrid.Columns.GridColumn colselected;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLopTC2;
        private DevExpress.XtraGrid.Columns.GridColumn colThu;
        private DevExpress.XtraGrid.Columns.GridColumn colBuoi;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBoxLop;
    }
}