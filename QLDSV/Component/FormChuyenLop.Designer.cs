namespace QLDSV.Component
{
    partial class FormChuyenLop
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
            System.Windows.Forms.Label maLopLabel;
            this.qLDSVDataSetKhoa = new QLDSV.QLDSVDataSetKhoa();
            this.lopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lopComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.maLopLabel1 = new System.Windows.Forms.Label();
            this.btnChuyenLop = new System.Windows.Forms.Button();
            this.labelTenSV = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            maLopLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // maLopLabel
            // 
            maLopLabel.AutoSize = true;
            maLopLabel.Location = new System.Drawing.Point(23, 135);
            maLopLabel.Name = "maLopLabel";
            maLopLabel.Size = new System.Drawing.Size(38, 13);
            maLopLabel.TabIndex = 2;
            maLopLabel.Text = "Mã lớp";
            // 
            // qLDSVDataSetKhoa
            // 
            this.qLDSVDataSetKhoa.DataSetName = "QLDSVDataSetKhoa";
            this.qLDSVDataSetKhoa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lopBindingSource
            // 
            this.lopBindingSource.DataMember = "Lop";
            this.lopBindingSource.DataSource = this.qLDSVDataSetKhoa;
            // 
            // lopComboBox
            // 
            this.lopComboBox.DataSource = this.lopBindingSource;
            this.lopComboBox.DisplayMember = "TenLop";
            this.lopComboBox.FormattingEnabled = true;
            this.lopComboBox.Location = new System.Drawing.Point(78, 102);
            this.lopComboBox.Name = "lopComboBox";
            this.lopComboBox.Size = new System.Drawing.Size(213, 21);
            this.lopComboBox.TabIndex = 1;
            this.lopComboBox.ValueMember = "MaLop";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn lớp";
            // 
            // maLopLabel1
            // 
            this.maLopLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lopBindingSource, "MaLop", true));
            this.maLopLabel1.Location = new System.Drawing.Point(75, 135);
            this.maLopLabel1.Name = "maLopLabel1";
            this.maLopLabel1.Size = new System.Drawing.Size(216, 13);
            this.maLopLabel1.TabIndex = 3;
            this.maLopLabel1.Text = "label2";
            // 
            // btnChuyenLop
            // 
            this.btnChuyenLop.Location = new System.Drawing.Point(124, 177);
            this.btnChuyenLop.Name = "btnChuyenLop";
            this.btnChuyenLop.Size = new System.Drawing.Size(84, 34);
            this.btnChuyenLop.TabIndex = 4;
            this.btnChuyenLop.Text = "Chuyển lớp";
            this.btnChuyenLop.UseVisualStyleBackColor = true;
            this.btnChuyenLop.Click += new System.EventHandler(this.btnChuyenLop_Click);
            // 
            // labelTenSV
            // 
            this.labelTenSV.AutoSize = true;
            this.labelTenSV.Location = new System.Drawing.Point(23, 30);
            this.labelTenSV.Name = "labelTenSV";
            this.labelTenSV.Size = new System.Drawing.Size(32, 13);
            this.labelTenSV.TabIndex = 5;
            this.labelTenSV.Text = "Tên: ";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Location = new System.Drawing.Point(23, 64);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(43, 13);
            this.labelMaSV.TabIndex = 5;
            this.labelMaSV.Text = "Mã SV: ";
            // 
            // FormChuyenLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 239);
            this.Controls.Add(this.labelMaSV);
            this.Controls.Add(this.labelTenSV);
            this.Controls.Add(this.btnChuyenLop);
            this.Controls.Add(maLopLabel);
            this.Controls.Add(this.maLopLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lopComboBox);
            this.Name = "FormChuyenLop";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 30);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChuyenLop";
            this.Load += new System.EventHandler(this.FormChuyenLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetKhoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lopBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetKhoa qLDSVDataSetKhoa;
        private System.Windows.Forms.BindingSource lopBindingSource;
        private System.Windows.Forms.ComboBox lopComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maLopLabel1;
        private System.Windows.Forms.Button btnChuyenLop;
        private System.Windows.Forms.Label labelTenSV;
        private System.Windows.Forms.Label labelMaSV;
    }
}