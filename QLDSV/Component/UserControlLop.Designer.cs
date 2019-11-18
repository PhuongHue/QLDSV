namespace QLDSV.Component
{
    partial class UserControlLop
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
            System.Windows.Forms.Label maLopLabel;
            System.Windows.Forms.Label tenLopLabel;
            System.Windows.Forms.Label maKhoaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLop));
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barbtnThem = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnXoa = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnSua = new DevExpress.XtraBars.BarButtonItem();
            this.barbtnLuu = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.khoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewLop = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLop = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxLop = new System.Windows.Forms.GroupBox();
            this.maKhoaTextBox = new System.Windows.Forms.TextBox();
            this.tenLopTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maLopTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barBtnPrintDS = new DevExpress.XtraBars.BarButtonItem();
            maLopLabel = new System.Windows.Forms.Label();
            tenLopLabel = new System.Windows.Forms.Label();
            maKhoaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).BeginInit();
            this.groupBoxLop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenLopTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(21, 41);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(45, 13);
            maLopLabel.TabIndex = 23;
            maLopLabel.Text = "Ma Lop:";
            // 
            // tenLopLabel
            // 
            tenLopLabel.AutoSize = true;
            tenLopLabel.Location = new System.Drawing.Point(208, 41);
            tenLopLabel.Name = "tenLopLabel";
            tenLopLabel.Size = new System.Drawing.Size(49, 13);
            tenLopLabel.TabIndex = 24;
            tenLopLabel.Text = "Ten Lop:";
            // 
            // maKhoaLabel
            // 
            maKhoaLabel.AutoSize = true;
            maKhoaLabel.Enabled = false;
            maKhoaLabel.Location = new System.Drawing.Point(387, 41);
            maKhoaLabel.Name = "maKhoaLabel";
            maKhoaLabel.Size = new System.Drawing.Size(52, 13);
            maKhoaLabel.TabIndex = 25;
            maKhoaLabel.Text = "Ma Khoa:";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(895, 47);
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
            this.barBtnRefresh,
            this.barBtnPrintDS});
            this.barManager.MaxItemId = 6;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnPrintDS, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 561);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(895, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 514);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(895, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 514);
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.AllowNew = true;
            this.lopBindingSource.DataMember = "FK_Lop_Khoa";
            this.lopBindingSource.DataSource = this.khoaBindingSource;
            // 
            // khoaBindingSource
            // 
            this.khoaBindingSource.DataMember = "Khoa";
            this.khoaBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // lopGridControl
            // 
            this.lopGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lopGridControl.DataSource = this.lopBindingSource;
            this.lopGridControl.Location = new System.Drawing.Point(0, 53);
            this.lopGridControl.MainView = this.gridViewLop;
            this.lopGridControl.MenuManager = this.barManager;
            this.lopGridControl.Name = "lopGridControl";
            this.lopGridControl.Size = new System.Drawing.Size(895, 410);
            this.lopGridControl.TabIndex = 5;
            this.lopGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLop});
            // 
            // gridViewLop
            // 
            this.gridViewLop.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colMaKhoa});
            this.gridViewLop.GridControl = this.lopGridControl;
            this.gridViewLop.Name = "gridViewLop";
            // 
            // colMaLop
            // 
            this.colMaLop.FieldName = "MaLop";
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.OptionsColumn.AllowEdit = false;
            this.colMaLop.OptionsColumn.AllowFocus = false;
            this.colMaLop.Visible = true;
            this.colMaLop.VisibleIndex = 0;
            // 
            // colTenLop
            // 
            this.colTenLop.FieldName = "TenLop";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.OptionsColumn.AllowEdit = false;
            this.colTenLop.OptionsColumn.AllowFocus = false;
            this.colTenLop.Visible = true;
            this.colTenLop.VisibleIndex = 1;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.OptionsColumn.AllowEdit = false;
            this.colMaKhoa.OptionsColumn.AllowFocus = false;
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 2;
            // 
            // groupBoxLop
            // 
            this.groupBoxLop.Controls.Add(maKhoaLabel);
            this.groupBoxLop.Controls.Add(this.maKhoaTextBox);
            this.groupBoxLop.Controls.Add(tenLopLabel);
            this.groupBoxLop.Controls.Add(this.tenLopTextEdit);
            this.groupBoxLop.Controls.Add(maLopLabel);
            this.groupBoxLop.Controls.Add(this.maLopTextEdit);
            this.groupBoxLop.Controls.Add(this.btnOk);
            this.groupBoxLop.Controls.Add(this.btnHuy);
            this.groupBoxLop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxLop.Enabled = false;
            this.groupBoxLop.Location = new System.Drawing.Point(0, 469);
            this.groupBoxLop.Name = "groupBoxLop";
            this.groupBoxLop.Size = new System.Drawing.Size(895, 92);
            this.groupBoxLop.TabIndex = 6;
            this.groupBoxLop.TabStop = false;
            // 
            // maKhoaTextBox
            // 
            this.maKhoaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopBindingSource, "MaKhoa", true));
            this.maKhoaTextBox.Location = new System.Drawing.Point(445, 38);
            this.maKhoaTextBox.Name = "maKhoaTextBox";
            this.maKhoaTextBox.ReadOnly = true;
            this.maKhoaTextBox.Size = new System.Drawing.Size(100, 21);
            this.maKhoaTextBox.TabIndex = 26;
            // 
            // tenLopTextEdit
            // 
            this.tenLopTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopBindingSource, "TenLop", true));
            this.tenLopTextEdit.Location = new System.Drawing.Point(263, 38);
            this.tenLopTextEdit.MenuManager = this.barManager;
            this.tenLopTextEdit.Name = "tenLopTextEdit";
            this.tenLopTextEdit.Properties.AccessibleName = "Tên lớp";
            this.tenLopTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenLopTextEdit.TabIndex = 25;
            this.tenLopTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextEdit_Validating);
            // 
            // maLopTextEdit
            // 
            this.maLopTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lopBindingSource, "MaLop", true));
            this.maLopTextEdit.Location = new System.Drawing.Point(72, 38);
            this.maLopTextEdit.MenuManager = this.barManager;
            this.maLopTextEdit.Name = "maLopTextEdit";
            this.maLopTextEdit.Properties.AccessibleName = "Mã lớp";
            this.maLopTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maLopTextEdit.TabIndex = 24;
            this.maLopTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.codeTextEdit_Validating);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(589, 36);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 22;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(670, 36);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 23;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "FK_SinhVien_Lop";
            this.sinhVienBindingSource.DataSource = this.lopBindingSource;
            // 
            // barBtnPrintDS
            // 
            this.barBtnPrintDS.Caption = "In Danh sách";
            this.barBtnPrintDS.Id = 5;
            this.barBtnPrintDS.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barBtnPrintDS.Name = "barBtnPrintDS";
            this.barBtnPrintDS.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPrintDS_ItemClick);
            // 
            // UserControlLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxLop);
            this.Controls.Add(this.lopGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlLop";
            this.Size = new System.Drawing.Size(895, 561);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLop)).EndInit();
            this.groupBoxLop.ResumeLayout(false);
            this.groupBoxLop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tenLopTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maLopTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barbtnThem;
        private DevExpress.XtraBars.BarButtonItem barbtnXoa;
        private DevExpress.XtraBars.BarButtonItem barbtnSua;
        private DevExpress.XtraBars.BarButtonItem barbtnLuu;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.GroupBox groupBoxLop;
        private DevExpress.XtraGrid.GridControl lopGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLop;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLop;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox maKhoaTextBox;
        private System.Windows.Forms.BindingSource khoaBindingSource;
        private DevExpress.XtraEditors.TextEdit tenLopTextEdit;
        private DevExpress.XtraEditors.TextEdit maLopTextEdit;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private DevExpress.XtraBars.BarButtonItem barBtnPrintDS;
    }
}
