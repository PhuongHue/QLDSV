namespace QLDSV.Component
{
    partial class UserControlMonHoc
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
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label sTLTLabel;
            System.Windows.Forms.Label sTTHLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlMonHoc));
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
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewMonHoc = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTLT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTTH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxMonHoc = new System.Windows.Forms.GroupBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.sTTHSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.sTLTSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.tenMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.maMHTextEdit = new DevExpress.XtraEditors.TextEdit();
            maMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            sTLTLabel = new System.Windows.Forms.Label();
            sTTHLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).BeginInit();
            this.groupBoxMonHoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTTHSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTLTSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMHTextEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(6, 17);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(43, 13);
            maMHLabel.TabIndex = 0;
            maMHLabel.Text = "Ma MH:";
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(161, 17);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(47, 13);
            tenMHLabel.TabIndex = 2;
            tenMHLabel.Text = "Ten MH:";
            // 
            // sTLTLabel
            // 
            sTLTLabel.AutoSize = true;
            sTLTLabel.Location = new System.Drawing.Point(320, 17);
            sTLTLabel.Name = "sTLTLabel";
            sTLTLabel.Size = new System.Drawing.Size(34, 13);
            sTLTLabel.TabIndex = 4;
            sTLTLabel.Text = "STLT:";
            // 
            // sTTHLabel
            // 
            sTTHLabel.AutoSize = true;
            sTTHLabel.Location = new System.Drawing.Point(466, 17);
            sTTHLabel.Name = "sTTHLabel";
            sTTHLabel.Size = new System.Drawing.Size(36, 13);
            sTTHLabel.TabIndex = 6;
            sTTHLabel.Text = "STTH:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(893, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 508);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(893, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 461);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(893, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 461);
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // monHocGridControl
            // 
            this.monHocGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.monHocGridControl.DataSource = this.monHocBindingSource;
            this.monHocGridControl.Location = new System.Drawing.Point(0, 53);
            this.monHocGridControl.MainView = this.gridViewMonHoc;
            this.monHocGridControl.MenuManager = this.barManager;
            this.monHocGridControl.Name = "monHocGridControl";
            this.monHocGridControl.Size = new System.Drawing.Size(893, 352);
            this.monHocGridControl.TabIndex = 5;
            this.monHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMonHoc});
            // 
            // gridViewMonHoc
            // 
            this.gridViewMonHoc.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaMH,
            this.colTenMH,
            this.colSTLT,
            this.colSTTH});
            this.gridViewMonHoc.GridControl = this.monHocGridControl;
            this.gridViewMonHoc.Name = "gridViewMonHoc";
            // 
            // colMaMH
            // 
            this.colMaMH.FieldName = "MaMH";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.OptionsColumn.AllowEdit = false;
            this.colMaMH.Visible = true;
            this.colMaMH.VisibleIndex = 0;
            // 
            // colTenMH
            // 
            this.colTenMH.FieldName = "TenMH";
            this.colTenMH.Name = "colTenMH";
            this.colTenMH.OptionsColumn.AllowEdit = false;
            this.colTenMH.Visible = true;
            this.colTenMH.VisibleIndex = 1;
            // 
            // colSTLT
            // 
            this.colSTLT.FieldName = "STLT";
            this.colSTLT.Name = "colSTLT";
            this.colSTLT.OptionsColumn.AllowEdit = false;
            this.colSTLT.Visible = true;
            this.colSTLT.VisibleIndex = 2;
            // 
            // colSTTH
            // 
            this.colSTTH.FieldName = "STTH";
            this.colSTTH.Name = "colSTTH";
            this.colSTTH.OptionsColumn.AllowEdit = false;
            this.colSTTH.Visible = true;
            this.colSTTH.VisibleIndex = 3;
            // 
            // groupBoxMonHoc
            // 
            this.groupBoxMonHoc.Controls.Add(this.btnOk);
            this.groupBoxMonHoc.Controls.Add(this.btnHuy);
            this.groupBoxMonHoc.Controls.Add(sTTHLabel);
            this.groupBoxMonHoc.Controls.Add(this.sTTHSpinEdit);
            this.groupBoxMonHoc.Controls.Add(sTLTLabel);
            this.groupBoxMonHoc.Controls.Add(this.sTLTSpinEdit);
            this.groupBoxMonHoc.Controls.Add(tenMHLabel);
            this.groupBoxMonHoc.Controls.Add(this.tenMHTextEdit);
            this.groupBoxMonHoc.Controls.Add(maMHLabel);
            this.groupBoxMonHoc.Controls.Add(this.maMHTextEdit);
            this.groupBoxMonHoc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxMonHoc.Enabled = false;
            this.groupBoxMonHoc.Location = new System.Drawing.Point(0, 411);
            this.groupBoxMonHoc.Name = "groupBoxMonHoc";
            this.groupBoxMonHoc.Size = new System.Drawing.Size(893, 97);
            this.groupBoxMonHoc.TabIndex = 6;
            this.groupBoxMonHoc.TabStop = false;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(625, 52);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 24;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(706, 52);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 25;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // sTTHSpinEdit
            // 
            this.sTTHSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBindingSource, "STTH", true));
            this.sTTHSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sTTHSpinEdit.Location = new System.Drawing.Point(508, 14);
            this.sTTHSpinEdit.MenuManager = this.barManager;
            this.sTTHSpinEdit.Name = "sTTHSpinEdit";
            this.sTTHSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sTTHSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.sTTHSpinEdit.Properties.MaxValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sTTHSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sTTHSpinEdit.TabIndex = 7;
            // 
            // sTLTSpinEdit
            // 
            this.sTLTSpinEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBindingSource, "STLT", true));
            this.sTLTSpinEdit.EditValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sTLTSpinEdit.Location = new System.Drawing.Point(360, 14);
            this.sTLTSpinEdit.MenuManager = this.barManager;
            this.sTLTSpinEdit.Name = "sTLTSpinEdit";
            this.sTLTSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sTLTSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.sTLTSpinEdit.Properties.MaxValue = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sTLTSpinEdit.Properties.MinValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.sTLTSpinEdit.Size = new System.Drawing.Size(100, 20);
            this.sTLTSpinEdit.TabIndex = 5;
            // 
            // tenMHTextEdit
            // 
            this.tenMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBindingSource, "TenMH", true));
            this.tenMHTextEdit.Location = new System.Drawing.Point(214, 14);
            this.tenMHTextEdit.MenuManager = this.barManager;
            this.tenMHTextEdit.Name = "tenMHTextEdit";
            this.tenMHTextEdit.Properties.AccessibleName = "Tên MH";
            this.tenMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.tenMHTextEdit.TabIndex = 3;
            this.tenMHTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.nameTextEdit_Validating);
            // 
            // maMHTextEdit
            // 
            this.maMHTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.monHocBindingSource, "MaMH", true));
            this.maMHTextEdit.Location = new System.Drawing.Point(55, 14);
            this.maMHTextEdit.MenuManager = this.barManager;
            this.maMHTextEdit.Name = "maMHTextEdit";
            this.maMHTextEdit.Properties.AccessibleName = "Mã MH";
            this.maMHTextEdit.Size = new System.Drawing.Size(100, 20);
            this.maMHTextEdit.TabIndex = 1;
            this.maMHTextEdit.Validating += new System.ComponentModel.CancelEventHandler(this.codeTextEdit_Validating);
            // 
            // UserControlMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMonHoc);
            this.Controls.Add(this.monHocGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlMonHoc";
            this.Size = new System.Drawing.Size(893, 508);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMonHoc)).EndInit();
            this.groupBoxMonHoc.ResumeLayout(false);
            this.groupBoxMonHoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTTHSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTLTSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenMHTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maMHTextEdit.Properties)).EndInit();
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
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.GroupBox groupBoxMonHoc;
        private DevExpress.XtraGrid.GridControl monHocGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMonHoc;
        private DevExpress.XtraGrid.Columns.GridColumn colMaMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenMH;
        private DevExpress.XtraGrid.Columns.GridColumn colSTLT;
        private DevExpress.XtraGrid.Columns.GridColumn colSTTH;
        private DevExpress.XtraEditors.SpinEdit sTTHSpinEdit;
        private DevExpress.XtraEditors.SpinEdit sTLTSpinEdit;
        private DevExpress.XtraEditors.TextEdit tenMHTextEdit;
        private DevExpress.XtraEditors.TextEdit maMHTextEdit;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnHuy;
    }
}
