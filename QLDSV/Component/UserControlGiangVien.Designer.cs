namespace QLDSV.Component
{
    partial class UserControlGiangVien
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
            System.Windows.Forms.Label maGVLabel;
            System.Windows.Forms.Label hoLabel;
            System.Windows.Forms.Label tenLabel;
            System.Windows.Forms.Label hocViLabel;
            System.Windows.Forms.Label hocHamLabel;
            System.Windows.Forms.Label chuyenMonLabel;
            System.Windows.Forms.Label chucVuLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlGiangVien));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.giangVienGridControl = new DevExpress.XtraGrid.GridControl();
            this.giangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewGiangVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHocVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHocHam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChuyenMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxGiangVien = new System.Windows.Forms.GroupBox();
            this.btnOkGiangVien = new System.Windows.Forms.Button();
            this.btnGiangVienHuy = new System.Windows.Forms.Button();
            this.chucVuTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.chuyenMonTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hocHamTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hocViTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.tenTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.hoTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maGVTextEdit = new DevExpress.XtraEditors.TextEdit();
            maGVLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            hocViLabel = new System.Windows.Forms.Label();
            hocHamLabel = new System.Windows.Forms.Label();
            chuyenMonLabel = new System.Windows.Forms.Label();
            chucVuLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).BeginInit();
            this.groupBoxGiangVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenMonTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocHamTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocViTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGVTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maGVLabel
            // 
            maGVLabel.AutoSize = true;
            maGVLabel.Location = new System.Drawing.Point(6, 17);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(41, 13);
            maGVLabel.TabIndex = 0;
            maGVLabel.Text = "Ma GV:";
            // 
            // hoLabel
            // 
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(159, 17);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(24, 13);
            hoLabel.TabIndex = 2;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(295, 17);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 4;
            tenLabel.Text = "Ten:";
            // 
            // hocViLabel
            // 
            hocViLabel.AutoSize = true;
            hocViLabel.Location = new System.Drawing.Point(436, 17);
            hocViLabel.Name = "hocViLabel";
            hocViLabel.Size = new System.Drawing.Size(40, 13);
            hocViLabel.TabIndex = 6;
            hocViLabel.Text = "Hoc Vi:";
            // 
            // hocHamLabel
            // 
            hocHamLabel.AutoSize = true;
            hocHamLabel.Location = new System.Drawing.Point(588, 17);
            hocHamLabel.Name = "hocHamLabel";
            hocHamLabel.Size = new System.Drawing.Size(53, 13);
            hocHamLabel.TabIndex = 8;
            hocHamLabel.Text = "Hoc Ham:";
            // 
            // chuyenMonLabel
            // 
            chuyenMonLabel.AutoSize = true;
            chuyenMonLabel.Location = new System.Drawing.Point(6, 59);
            chuyenMonLabel.Name = "chuyenMonLabel";
            chuyenMonLabel.Size = new System.Drawing.Size(71, 13);
            chuyenMonLabel.TabIndex = 10;
            chuyenMonLabel.Text = "Chuyen Mon:";
            // 
            // chucVuLabel
            // 
            chucVuLabel.AutoSize = true;
            chucVuLabel.Location = new System.Drawing.Point(189, 59);
            chucVuLabel.Name = "chucVuLabel";
            chucVuLabel.Size = new System.Drawing.Size(50, 13);
            chucVuLabel.TabIndex = 12;
            chucVuLabel.Text = "Chuc Vu:";
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
            this.barbtnThem,
            this.barbtnXoa,
            this.barbtnSua,
            this.barbtnLuu,
            this.barBtnRefresh});
            this.barManager.MaxItemId = 5;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnThem, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnXoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnSua, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barbtnLuu, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barbtnThem
            // 
            this.barbtnThem.Caption = "Thêm";
            this.barbtnThem.Id = 0;
            this.barbtnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnThem.ImageOptions.Image")));
            this.barbtnThem.Name = "barbtnThem";
            this.barbtnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnThem_ItemClick);
            // 
            // barbtnXoa
            // 
            this.barbtnXoa.Caption = "Xóa";
            this.barbtnXoa.Id = 1;
            this.barbtnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnXoa.ImageOptions.Image")));
            this.barbtnXoa.Name = "barbtnXoa";
            this.barbtnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnXoa_ItemClick);
            // 
            // barbtnSua
            // 
            this.barbtnSua.Caption = "Sửa";
            this.barbtnSua.Id = 2;
            this.barbtnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barbtnSua.ImageOptions.Image")));
            this.barbtnSua.Name = "barbtnSua";
            this.barbtnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barbtnSua_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(881, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 443);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(881, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 396);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(881, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 396);
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // giangVienGridControl
            // 
            this.giangVienGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.giangVienGridControl.DataSource = this.giangVienBindingSource;
            this.giangVienGridControl.Location = new System.Drawing.Point(0, 53);
            this.giangVienGridControl.MainView = this.gridViewGiangVien;
            this.giangVienGridControl.MenuManager = this.barManager;
            this.giangVienGridControl.Name = "giangVienGridControl";
            this.giangVienGridControl.Size = new System.Drawing.Size(881, 292);
            this.giangVienGridControl.TabIndex = 5;
            this.giangVienGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewGiangVien});
            // 
            // giangVienBindingSource
            // 
            this.giangVienBindingSource.DataMember = "FK_GiangVien_Khoa";
            this.giangVienBindingSource.DataSource = this.khoaBindingSource;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // gridViewGiangVien
            // 
            this.gridViewGiangVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colHocVi,
            this.colHocHam,
            this.colChuyenMon,
            this.colMaKhoa,
            this.colChucVu});
            this.gridViewGiangVien.GridControl = this.giangVienGridControl;
            this.gridViewGiangVien.Name = "gridViewGiangVien";
            // 
            // colMaGV
            // 
            this.colMaGV.FieldName = "MaGV";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.OptionsColumn.AllowEdit = false;
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 0;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.OptionsColumn.AllowEdit = false;
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.OptionsColumn.AllowEdit = false;
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            // 
            // colHocVi
            // 
            this.colHocVi.FieldName = "HocVi";
            this.colHocVi.Name = "colHocVi";
            this.colHocVi.OptionsColumn.AllowEdit = false;
            this.colHocVi.Visible = true;
            this.colHocVi.VisibleIndex = 3;
            // 
            // colHocHam
            // 
            this.colHocHam.FieldName = "HocHam";
            this.colHocHam.Name = "colHocHam";
            this.colHocHam.OptionsColumn.AllowEdit = false;
            this.colHocHam.Visible = true;
            this.colHocHam.VisibleIndex = 4;
            // 
            // colChuyenMon
            // 
            this.colChuyenMon.FieldName = "ChuyenMon";
            this.colChuyenMon.Name = "colChuyenMon";
            this.colChuyenMon.OptionsColumn.AllowEdit = false;
            this.colChuyenMon.Visible = true;
            this.colChuyenMon.VisibleIndex = 5;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.OptionsColumn.AllowEdit = false;
            this.colMaKhoa.OptionsColumn.AllowFocus = false;
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 6;
            // 
            // colChucVu
            // 
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.OptionsColumn.AllowEdit = false;
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 7;
            // 
            // groupBoxGiangVien
            // 
            this.groupBoxGiangVien.Controls.Add(this.btnOkGiangVien);
            this.groupBoxGiangVien.Controls.Add(this.btnGiangVienHuy);
            this.groupBoxGiangVien.Controls.Add(chucVuLabel);
            this.groupBoxGiangVien.Controls.Add(this.chucVuTextEdit);
            this.groupBoxGiangVien.Controls.Add(chuyenMonLabel);
            this.groupBoxGiangVien.Controls.Add(this.chuyenMonTextEdit);
            this.groupBoxGiangVien.Controls.Add(hocHamLabel);
            this.groupBoxGiangVien.Controls.Add(this.hocHamTextEdit);
            this.groupBoxGiangVien.Controls.Add(hocViLabel);
            this.groupBoxGiangVien.Controls.Add(this.hocViTextEdit);
            this.groupBoxGiangVien.Controls.Add(tenLabel);
            this.groupBoxGiangVien.Controls.Add(this.tenTextEdit);
            this.groupBoxGiangVien.Controls.Add(hoLabel);
            this.groupBoxGiangVien.Controls.Add(this.hoTextEdit);
            this.groupBoxGiangVien.Controls.Add(maGVLabel);
            this.groupBoxGiangVien.Controls.Add(this.maGVTextEdit);
            this.groupBoxGiangVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxGiangVien.Enabled = false;
            this.groupBoxGiangVien.Location = new System.Drawing.Point(0, 351);
            this.groupBoxGiangVien.Name = "groupBoxGiangVien";
            this.groupBoxGiangVien.Size = new System.Drawing.Size(881, 92);
            this.groupBoxGiangVien.TabIndex = 6;
            this.groupBoxGiangVien.TabStop = false;
            // 
            // btnOkGiangVien
            // 
            this.btnOkGiangVien.Location = new System.Drawing.Point(591, 54);
            this.btnOkGiangVien.Name = "btnOkGiangVien";
            this.btnOkGiangVien.Size = new System.Drawing.Size(75, 23);
            this.btnOkGiangVien.TabIndex = 24;
            this.btnOkGiangVien.Text = "OK";
            this.btnOkGiangVien.UseVisualStyleBackColor = true;
            this.btnOkGiangVien.Click += new System.EventHandler(this.btnOkGiangVien_Click);
            // 
            // btnGiangVienHuy
            // 
            this.btnGiangVienHuy.Location = new System.Drawing.Point(672, 54);
            this.btnGiangVienHuy.Name = "btnGiangVienHuy";
            this.btnGiangVienHuy.Size = new System.Drawing.Size(75, 23);
            this.btnGiangVienHuy.TabIndex = 25;
            this.btnGiangVienHuy.Text = "Hủy";
            this.btnGiangVienHuy.UseVisualStyleBackColor = true;
            this.btnGiangVienHuy.Click += new System.EventHandler(this.btnGiangVienHuy_Click);
            // 
            // chucVuTextEdit
            // 
            this.chucVuTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "ChucVu", true));
            this.chucVuTextEdit.Location = new System.Drawing.Point(245, 56);
            this.chucVuTextEdit.MenuManager = this.barManager;
            this.chucVuTextEdit.Name = "chucVuTextEdit";
            this.chucVuTextEdit.Properties.AccessibleName = "Chức vụ";
            this.chucVuTextEdit.Size = new System.Drawing.Size(100, 20);
            this.chucVuTextEdit.TabIndex = 13;
            this.chucVuTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.commonTextEdit_Validating);
            // 
            // chuyenMonTextEdit
            // 
            this.chuyenMonTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "ChuyenMon", true));
            this.chuyenMonTextEdit.Location = new System.Drawing.Point(83, 56);
            this.chuyenMonTextEdit.MenuManager = this.barManager;
            this.chuyenMonTextEdit.Name = "chuyenMonTextEdit";
            this.chuyenMonTextEdit.Properties.AccessibleName = "Chuyên môn";
            this.chuyenMonTextEdit.Size = new System.Drawing.Size(100, 20);
            this.chuyenMonTextEdit.TabIndex = 11;
            this.chuyenMonTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.commonTextEdit_Validating);
            // 
            // hocHamTextEdit
            // 
            this.hocHamTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "HocHam", true));
            this.hocHamTextEdit.Location = new System.Drawing.Point(647, 14);
            this.hocHamTextEdit.MenuManager = this.barManager;
            this.hocHamTextEdit.Name = "hocHamTextEdit";
            this.hocHamTextEdit.Properties.AccessibleName = "Học hàm";
            this.hocHamTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hocHamTextEdit.TabIndex = 9;
            this.hocHamTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.commonTextEdit_Validating);
            // 
            // hocViTextEdit
            // 
            this.hocViTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "HocVi", true));
            this.hocViTextEdit.Location = new System.Drawing.Point(482, 14);
            this.hocViTextEdit.MenuManager = this.barManager;
            this.hocViTextEdit.Name = "hocViTextEdit";
            this.hocViTextEdit.Properties.AccessibleName = "Học vị";
            this.hocViTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hocViTextEdit.TabIndex = 7;
            this.hocViTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.commonTextEdit_Validating);
            // 
            // tenTextEdit
            // 
            this.tenTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "Ten", true));
            this.tenTextEdit.Location = new System.Drawing.Point(330, 14);
            this.tenTextEdit.MenuManager = this.barManager;
            this.tenTextEdit.Name = "tenTextEdit";
            this.tenTextEdit.Properties.AccessibleName = "Tên";
            this.tenTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenTextEdit.TabIndex = 5;
            this.tenTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextEdit_Validating);
            // 
            // hoTextEdit
            // 
            this.hoTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "Ho", true));
            this.hoTextEdit.Location = new System.Drawing.Point(189, 14);
            this.hoTextEdit.MenuManager = this.barManager;
            this.hoTextEdit.Name = "hoTextEdit";
            this.hoTextEdit.Properties.AccessibleName = "Họ";
            this.hoTextEdit.Size = new System.Drawing.Size(100, 20);
            this.hoTextEdit.TabIndex = 3;
            this.hoTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextEdit_Validating);
            // 
            // maGVTextEdit
            // 
            this.maGVTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.giangVienBindingSource, "MaGV", true));
            this.maGVTextEdit.Location = new System.Drawing.Point(53, 14);
            this.maGVTextEdit.MenuManager = this.barManager;
            this.maGVTextEdit.Name = "maGVTextEdit";
            this.maGVTextEdit.Properties.AccessibleName = "Mã GV";
            this.maGVTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maGVTextEdit.TabIndex = 1;
            this.maGVTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.codeTextEdit_Validating);
            // 
            // UserControlGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxGiangVien);
            this.Controls.Add(this.giangVienGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlGiangVien";
            this.Size = new System.Drawing.Size(881, 443);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewGiangVien)).EndInit();
            this.groupBoxGiangVien.ResumeLayout(false);
            this.groupBoxGiangVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chucVuTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chuyenMonTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocHamTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocViTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maGVTextEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barbtnThem;
        private DevExpress.XtraBars.BarButtonItem barbtnXoa;
        private DevExpress.XtraBars.BarButtonItem barbtnSua;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private DevExpress.XtraGrid.GridControl giangVienGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewGiangVien;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colHocVi;
        private DevExpress.XtraGrid.Columns.GridColumn colHocHam;
        private DevExpress.XtraGrid.Columns.GridColumn colChuyenMon;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private System.Windows.Forms.GroupBox groupBoxGiangVien;
        private DevExpress.XtraEditors.TextEdit chucVuTextEdit;
        private DevExpress.XtraEditors.TextEdit chuyenMonTextEdit;
        private DevExpress.XtraEditors.TextEdit hocHamTextEdit;
        private DevExpress.XtraEditors.TextEdit hocViTextEdit;
        private DevExpress.XtraEditors.TextEdit tenTextEdit;
        private DevExpress.XtraEditors.TextEdit hoTextEdit;
        private DevExpress.XtraEditors.TextEdit maGVTextEdit;
        private System.Windows.Forms.Button btnOkGiangVien;
        private System.Windows.Forms.Button btnGiangVienHuy;
        private System.Windows.Forms.BindingSource giangVienBindingSource;
    }
}
