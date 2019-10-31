namespace QLDSV
{
    partial class FormMain
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
            this.qLDSVDataSetMaster = new QLDSV.QLDSVDataSetMaster();
            this.v_DSPMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_DSPMTableAdapter = new QLDSV.QLDSVDataSetMasterTableAdapters.V_DSPMTableAdapter();
            this.tableAdapterManager = new QLDSV.QLDSVDataSetMasterTableAdapters.TableAdapterManager();
            this.v_DSPMComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.xtraTabControlMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabLop = new DevExpress.XtraTab.XtraTabPage();
            this.userControlLop = new QLDSV.Component.UserControlLop();
            this.tabSinhVien = new DevExpress.XtraTab.XtraTabPage();
            this.userControlSinhVien = new QLDSV.UserControlSinhVien();
            this.tabGiangVien = new DevExpress.XtraTab.XtraTabPage();
            this.userControlGiangVien = new QLDSV.Component.UserControlGiangVien();
            this.tabMonHoc = new DevExpress.XtraTab.XtraTabPage();
            this.userControlMonHoc = new QLDSV.Component.UserControlMonHoc();
            this.tabLopTinChi = new DevExpress.XtraTab.XtraTabPage();
            this.tabDiem = new DevExpress.XtraTab.XtraTabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStripLoginName = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStripMaGV = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStripHoTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtStripNhom = new System.Windows.Forms.ToolStripStatusLabel();
            this.userControlLopTC = new QLDSV.Component.UserControlLopTC();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).BeginInit();
            this.xtraTabControlMain.SuspendLayout();
            this.tabLop.SuspendLayout();
            this.tabSinhVien.SuspendLayout();
            this.tabGiangVien.SuspendLayout();
            this.tabMonHoc.SuspendLayout();
            this.tabLopTinChi.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // qLDSVDataSetMaster
            // 
            this.qLDSVDataSetMaster.DataSetName = "QLDSVDataSetMaster";
            this.qLDSVDataSetMaster.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // v_DSPMBindingSource
            // 
            this.v_DSPMBindingSource.DataMember = "V_DSPM";
            this.v_DSPMBindingSource.DataSource = this.qLDSVDataSetMaster;
            // 
            // v_DSPMTableAdapter
            // 
            this.v_DSPMTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = QLDSV.QLDSVDataSetMasterTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // v_DSPMComboBox
            // 
            this.v_DSPMComboBox.DataSource = this.v_DSPMBindingSource;
            this.v_DSPMComboBox.DisplayMember = "description";
            this.v_DSPMComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v_DSPMComboBox.FormattingEnabled = true;
            this.v_DSPMComboBox.Location = new System.Drawing.Point(50, 6);
            this.v_DSPMComboBox.Name = "v_DSPMComboBox";
            this.v_DSPMComboBox.Size = new System.Drawing.Size(186, 21);
            this.v_DSPMComboBox.TabIndex = 1;
            this.v_DSPMComboBox.ValueMember = "subscriber_server";
            this.v_DSPMComboBox.SelectedIndexChanged += new System.EventHandler(this.v_DSPMComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa";
            // 
            // xtraTabControlMain
            // 
            this.xtraTabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControlMain.Location = new System.Drawing.Point(0, 33);
            this.xtraTabControlMain.Name = "xtraTabControlMain";
            this.xtraTabControlMain.SelectedTabPage = this.tabLop;
            this.xtraTabControlMain.Size = new System.Drawing.Size(879, 396);
            this.xtraTabControlMain.TabIndex = 3;
            this.xtraTabControlMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabLop,
            this.tabSinhVien,
            this.tabGiangVien,
            this.tabMonHoc,
            this.tabLopTinChi,
            this.tabDiem});
            // 
            // tabLop
            // 
            this.tabLop.Controls.Add(this.userControlLop);
            this.tabLop.Name = "tabLop";
            this.tabLop.Size = new System.Drawing.Size(873, 368);
            this.tabLop.Text = "Lớp";
            // 
            // userControlLop
            // 
            this.userControlLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLop.Location = new System.Drawing.Point(0, 0);
            this.userControlLop.Name = "userControlLop";
            this.userControlLop.Size = new System.Drawing.Size(873, 368);
            this.userControlLop.TabIndex = 0;
            // 
            // tabSinhVien
            // 
            this.tabSinhVien.Controls.Add(this.userControlSinhVien);
            this.tabSinhVien.Name = "tabSinhVien";
            this.tabSinhVien.Size = new System.Drawing.Size(873, 368);
            this.tabSinhVien.Text = "Sinh viên";
            // 
            // userControlSinhVien
            // 
            this.userControlSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSinhVien.Location = new System.Drawing.Point(0, 0);
            this.userControlSinhVien.Name = "userControlSinhVien";
            this.userControlSinhVien.Size = new System.Drawing.Size(873, 368);
            this.userControlSinhVien.TabIndex = 0;
            // 
            // tabGiangVien
            // 
            this.tabGiangVien.Controls.Add(this.userControlGiangVien);
            this.tabGiangVien.Name = "tabGiangVien";
            this.tabGiangVien.Size = new System.Drawing.Size(873, 368);
            this.tabGiangVien.Text = "Giảng viên";
            // 
            // userControlGiangVien
            // 
            this.userControlGiangVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlGiangVien.Location = new System.Drawing.Point(0, 0);
            this.userControlGiangVien.Name = "userControlGiangVien";
            this.userControlGiangVien.Size = new System.Drawing.Size(873, 368);
            this.userControlGiangVien.TabIndex = 0;
            // 
            // tabMonHoc
            // 
            this.tabMonHoc.Controls.Add(this.userControlMonHoc);
            this.tabMonHoc.Name = "tabMonHoc";
            this.tabMonHoc.Size = new System.Drawing.Size(873, 368);
            this.tabMonHoc.Text = "Môn học";
            // 
            // userControlMonHoc
            // 
            this.userControlMonHoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlMonHoc.Location = new System.Drawing.Point(0, 0);
            this.userControlMonHoc.Name = "userControlMonHoc";
            this.userControlMonHoc.Size = new System.Drawing.Size(873, 368);
            this.userControlMonHoc.TabIndex = 0;
            // 
            // tabLopTinChi
            // 
            this.tabLopTinChi.Controls.Add(this.userControlLopTC);
            this.tabLopTinChi.Name = "tabLopTinChi";
            this.tabLopTinChi.Size = new System.Drawing.Size(873, 368);
            this.tabLopTinChi.Text = "Lớp tín chỉ";
            // 
            // tabDiem
            // 
            this.tabDiem.Name = "tabDiem";
            this.tabDiem.Size = new System.Drawing.Size(873, 368);
            this.tabDiem.Text = "Nhập Điểm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStripLoginName,
            this.txtStripMaGV,
            this.txtStripHoTen,
            this.txtStripNhom});
            this.statusStrip1.Location = new System.Drawing.Point(0, 429);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(879, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStripLoginName
            // 
            this.txtStripLoginName.Margin = new System.Windows.Forms.Padding(5);
            this.txtStripLoginName.Name = "txtStripLoginName";
            this.txtStripLoginName.Size = new System.Drawing.Size(78, 15);
            this.txtStripLoginName.Text = "Login Name: ";
            // 
            // txtStripMaGV
            // 
            this.txtStripMaGV.Margin = new System.Windows.Forms.Padding(5);
            this.txtStripMaGV.Name = "txtStripMaGV";
            this.txtStripMaGV.Size = new System.Drawing.Size(48, 15);
            this.txtStripMaGV.Text = "Mã GV: ";
            // 
            // txtStripHoTen
            // 
            this.txtStripHoTen.Margin = new System.Windows.Forms.Padding(5);
            this.txtStripHoTen.Name = "txtStripHoTen";
            this.txtStripHoTen.Size = new System.Drawing.Size(49, 15);
            this.txtStripHoTen.Text = "Họ tên: ";
            // 
            // txtStripNhom
            // 
            this.txtStripNhom.ForeColor = System.Drawing.Color.Red;
            this.txtStripNhom.Margin = new System.Windows.Forms.Padding(5);
            this.txtStripNhom.Name = "txtStripNhom";
            this.txtStripNhom.Size = new System.Drawing.Size(57, 15);
            this.txtStripNhom.Text = "Chức vụ: ";
            // 
            // userControlLopTC
            // 
            this.userControlLopTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlLopTC.Location = new System.Drawing.Point(0, 0);
            this.userControlLopTC.Name = "userControlLopTC";
            this.userControlLopTC.Size = new System.Drawing.Size(873, 368);
            this.userControlLopTC.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 454);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.xtraTabControlMain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v_DSPMComboBox);
            this.Name = "FormMain";
            this.Text = "Quản lý điểm sinh viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlMain)).EndInit();
            this.xtraTabControlMain.ResumeLayout(false);
            this.tabLop.ResumeLayout(false);
            this.tabSinhVien.ResumeLayout(false);
            this.tabGiangVien.ResumeLayout(false);
            this.tabMonHoc.ResumeLayout(false);
            this.tabLopTinChi.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetMaster qLDSVDataSetMaster;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLDSVDataSetMasterTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLDSVDataSetMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox v_DSPMComboBox;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControlMain;
        private DevExpress.XtraTab.XtraTabPage tabSinhVien;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStripLoginName;
        private System.Windows.Forms.ToolStripStatusLabel txtStripHoTen;
        private System.Windows.Forms.ToolStripStatusLabel txtStripNhom;
        private System.Windows.Forms.ToolStripStatusLabel txtStripMaGV;
        private DevExpress.XtraTab.XtraTabPage tabGiangVien;
        private DevExpress.XtraTab.XtraTabPage tabMonHoc;
        private DevExpress.XtraTab.XtraTabPage tabLopTinChi;
        private DevExpress.XtraTab.XtraTabPage tabDiem;
        private UserControlSinhVien userControlSinhVien;
        private DevExpress.XtraTab.XtraTabPage tabLop;
        private Component.UserControlLop userControlLop;
        private Component.UserControlGiangVien userControlGiangVien;
        private Component.UserControlMonHoc userControlMonHoc;
        private Component.UserControlLopTC userControlLopTC;
    }
}