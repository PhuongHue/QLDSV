namespace QLDSV
{
    partial class FormDangNhap
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
            this.Khoa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DangNhap = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.textBoxLoginName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).BeginInit();
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
            this.v_DSPMComboBox.Location = new System.Drawing.Point(201, 81);
            this.v_DSPMComboBox.Name = "v_DSPMComboBox";
            this.v_DSPMComboBox.Size = new System.Drawing.Size(199, 21);
            this.v_DSPMComboBox.TabIndex = 1;
            this.v_DSPMComboBox.ValueMember = "subscriber_server";
            // 
            // Khoa
            // 
            this.Khoa.AutoSize = true;
            this.Khoa.Location = new System.Drawing.Point(108, 84);
            this.Khoa.Name = "Khoa";
            this.Khoa.Size = new System.Drawing.Size(31, 13);
            this.Khoa.TabIndex = 2;
            this.Khoa.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // DangNhap
            // 
            this.DangNhap.Location = new System.Drawing.Point(201, 214);
            this.DangNhap.Name = "DangNhap";
            this.DangNhap.Size = new System.Drawing.Size(75, 23);
            this.DangNhap.TabIndex = 5;
            this.DangNhap.Text = "Đăng nhập";
            this.DangNhap.UseVisualStyleBackColor = true;
            this.DangNhap.Click += new System.EventHandler(this.DangNhap_Click);
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(322, 214);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(75, 23);
            this.Thoat.TabIndex = 6;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // textBoxLoginName
            // 
            this.textBoxLoginName.Location = new System.Drawing.Point(201, 117);
            this.textBoxLoginName.Name = "textBoxLoginName";
            this.textBoxLoginName.Size = new System.Drawing.Size(199, 21);
            this.textBoxLoginName.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(201, 150);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(199, 21);
            this.textBoxPassword.TabIndex = 7;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 319);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLoginName);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Khoa);
            this.Controls.Add(this.v_DSPMComboBox);
            this.Name = "FormDangNhap";
            this.Text = "FormDangNhap";
            this.Load += new System.EventHandler(this.FormDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSetMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v_DSPMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private QLDSVDataSetMaster qLDSVDataSetMaster;
        private System.Windows.Forms.BindingSource v_DSPMBindingSource;
        private QLDSVDataSetMasterTableAdapters.V_DSPMTableAdapter v_DSPMTableAdapter;
        private QLDSVDataSetMasterTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox v_DSPMComboBox;
        private System.Windows.Forms.Label Khoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DangNhap;
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.TextBox textBoxLoginName;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

