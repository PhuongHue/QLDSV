namespace QLDSV.Component
{
    partial class UserControlTaiKhoan
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
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlTaiKhoan));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barBtnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.sP_List_LOGINBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_List_LOGINGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewListLogin = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKhoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditLoginName = new DevExpress.XtraEditors.TextEdit();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMaGV = new System.Windows.Forms.Label();
            this.hoLabel1 = new System.Windows.Forms.Label();
            this.tenLabel1 = new System.Windows.Forms.Label();
            this.btnTaoTK = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            maGVLabel = new System.Windows.Forms.Label();
            hoLabel = new System.Windows.Forms.Label();
            tenLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListLogin)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // maGVLabel
            // 
            maGVLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            maGVLabel.AutoSize = true;
            maGVLabel.Location = new System.Drawing.Point(525, 205);
            maGVLabel.Name = "maGVLabel";
            maGVLabel.Size = new System.Drawing.Size(41, 13);
            maGVLabel.TabIndex = 9;
            maGVLabel.Text = "Ma GV:";
            // 
            // hoLabel
            // 
            hoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            hoLabel.AutoSize = true;
            hoLabel.Location = new System.Drawing.Point(525, 237);
            hoLabel.Name = "hoLabel";
            hoLabel.Size = new System.Drawing.Size(24, 13);
            hoLabel.TabIndex = 11;
            hoLabel.Text = "Ho:";
            // 
            // tenLabel
            // 
            tenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            tenLabel.AutoSize = true;
            tenLabel.Location = new System.Drawing.Point(525, 270);
            tenLabel.Name = "tenLabel";
            tenLabel.Size = new System.Drawing.Size(29, 13);
            tenLabel.TabIndex = 13;
            tenLabel.Text = "Ten:";
            // 
            // label5
            // 
            label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(525, 309);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 13);
            label5.TabIndex = 13;
            label5.Text = "Quyền";
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBtnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
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
            this.barDockControlTop.Size = new System.Drawing.Size(864, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 529);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(864, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 482);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(864, 47);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 482);
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sP_List_LOGINBindingSource
            // 
            this.sP_List_LOGINBindingSource.DataMember = "SP_List_LOGIN";
            this.sP_List_LOGINBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // sP_List_LOGINGridControl
            // 
            this.sP_List_LOGINGridControl.DataSource = this.sP_List_LOGINBindingSource;
            this.sP_List_LOGINGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sP_List_LOGINGridControl.Location = new System.Drawing.Point(3, 28);
            this.sP_List_LOGINGridControl.MainView = this.gridViewListLogin;
            this.sP_List_LOGINGridControl.MenuManager = this.barManager;
            this.sP_List_LOGINGridControl.Name = "sP_List_LOGINGridControl";
            this.sP_List_LOGINGridControl.Size = new System.Drawing.Size(436, 445);
            this.sP_List_LOGINGridControl.TabIndex = 5;
            this.sP_List_LOGINGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewListLogin});
            // 
            // gridViewListLogin
            // 
            this.gridViewListLogin.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaGV,
            this.colHo,
            this.colTen,
            this.colMaKhoa});
            this.gridViewListLogin.GridControl = this.sP_List_LOGINGridControl;
            this.gridViewListLogin.Name = "gridViewListLogin";
            // 
            // colMaGV
            // 
            this.colMaGV.FieldName = "MaGV";
            this.colMaGV.Name = "colMaGV";
            this.colMaGV.Visible = true;
            this.colMaGV.VisibleIndex = 0;
            // 
            // colHo
            // 
            this.colHo.FieldName = "Ho";
            this.colHo.Name = "colHo";
            this.colHo.Visible = true;
            this.colHo.VisibleIndex = 1;
            // 
            // colTen
            // 
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 2;
            // 
            // colMaKhoa
            // 
            this.colMaKhoa.FieldName = "MaKhoa";
            this.colMaKhoa.Name = "colMaKhoa";
            this.colMaKhoa.Visible = true;
            this.colMaKhoa.VisibleIndex = 3;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.sP_List_LOGINGridControl, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 53);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(442, 476);
            this.tableLayoutPanelMain.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Danh sách chưa có tài khoản";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tạo mới";
            // 
            // textEditLoginName
            // 
            this.textEditLoginName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditLoginName.Location = new System.Drawing.Point(581, 122);
            this.textEditLoginName.MenuManager = this.barManager;
            this.textEditLoginName.Name = "textEditLoginName";
            this.textEditLoginName.Size = new System.Drawing.Size(150, 20);
            this.textEditLoginName.TabIndex = 7;
            // 
            // textEditPassword
            // 
            this.textEditPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textEditPassword.Location = new System.Drawing.Point(581, 164);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(150, 20);
            this.textEditPassword.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tên login";
            // 
            // labelMaGV
            // 
            this.labelMaGV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMaGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_List_LOGINBindingSource, "MaGV", true));
            this.labelMaGV.Location = new System.Drawing.Point(578, 205);
            this.labelMaGV.Name = "labelMaGV";
            this.labelMaGV.Size = new System.Drawing.Size(153, 17);
            this.labelMaGV.TabIndex = 10;
            this.labelMaGV.Text = "...";
            // 
            // hoLabel1
            // 
            this.hoLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_List_LOGINBindingSource, "Ho", true));
            this.hoLabel1.Location = new System.Drawing.Point(578, 237);
            this.hoLabel1.Name = "hoLabel1";
            this.hoLabel1.Size = new System.Drawing.Size(153, 17);
            this.hoLabel1.TabIndex = 12;
            this.hoLabel1.Text = "...";
            // 
            // tenLabel1
            // 
            this.tenLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tenLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_List_LOGINBindingSource, "Ten", true));
            this.tenLabel1.Location = new System.Drawing.Point(578, 270);
            this.tenLabel1.Name = "tenLabel1";
            this.tenLabel1.Size = new System.Drawing.Size(153, 17);
            this.tenLabel1.TabIndex = 14;
            this.tenLabel1.Text = "...";
            // 
            // btnTaoTK
            // 
            this.btnTaoTK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaoTK.Location = new System.Drawing.Point(613, 362);
            this.btnTaoTK.Name = "btnTaoTK";
            this.btnTaoTK.Size = new System.Drawing.Size(100, 34);
            this.btnTaoTK.TabIndex = 15;
            this.btnTaoTK.Text = "Tạo tài khoản";
            this.btnTaoTK.Click += new System.EventHandler(this.btnTaoTK_Click);
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Items.AddRange(new object[] {
            "Phòng giáo vụ",
            "Khoa",
            "Sinh viên"});
            this.comboBoxRole.Location = new System.Drawing.Point(581, 306);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(150, 21);
            this.comboBoxRole.TabIndex = 20;
            // 
            // UserControlTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxRole);
            this.Controls.Add(this.btnTaoTK);
            this.Controls.Add(this.label1);
            this.Controls.Add(label5);
            this.Controls.Add(tenLabel);
            this.Controls.Add(this.tenLabel1);
            this.Controls.Add(hoLabel);
            this.Controls.Add(this.hoLabel1);
            this.Controls.Add(maGVLabel);
            this.Controls.Add(this.labelMaGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.textEditLoginName);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UserControlTaiKhoan";
            this.Size = new System.Drawing.Size(864, 529);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_List_LOGINGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewListLogin)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditLoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barBtnRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private DevExpress.XtraGrid.GridControl sP_List_LOGINGridControl;
        private System.Windows.Forms.BindingSource sP_List_LOGINBindingSource;
        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewListLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tenLabel1;
        private System.Windows.Forms.Label hoLabel1;
        private System.Windows.Forms.Label labelMaGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.TextEdit textEditLoginName;
        private DevExpress.XtraEditors.SimpleButton btnTaoTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private DevExpress.XtraGrid.Columns.GridColumn colMaGV;
        private DevExpress.XtraGrid.Columns.GridColumn colHo;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKhoa;
    }
}
