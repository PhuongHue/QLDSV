namespace QLDSV.Reports
{
    partial class FormPrintDSTHM
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
            this.labelLop = new System.Windows.Forms.Label();
            this.labelMH = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Location = new System.Drawing.Point(43, 30);
            this.labelLop.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(31, 13);
            this.labelLop.TabIndex = 0;
            this.labelLop.Text = "Lớp: ";
            // 
            // labelMH
            // 
            this.labelMH.AutoSize = true;
            this.labelMH.Location = new System.Drawing.Point(43, 63);
            this.labelMH.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelMH.Name = "labelMH";
            this.labelMH.Size = new System.Drawing.Size(54, 13);
            this.labelMH.TabIndex = 0;
            this.labelMH.Text = "Môn học: ";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Location = new System.Drawing.Point(43, 96);
            this.labelNgay.Margin = new System.Windows.Forms.Padding(3, 0, 3, 20);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(32, 13);
            this.labelNgay.TabIndex = 0;
            this.labelNgay.Text = "Ngày";
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(81, 93);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.Mask.BeepOnError = true;
            this.dateEdit.Properties.Mask.EditMask = "D/M/yyy";
            this.dateEdit.Size = new System.Drawing.Size(182, 20);
            this.dateEdit.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(132, 144);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormPrintDSTHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 200);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.labelMH);
            this.Controls.Add(this.labelLop);
            this.Name = "FormPrintDSTHM";
            this.Padding = new System.Windows.Forms.Padding(40, 30, 40, 30);
            this.Text = "FormPrintDSTHM";
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.Label labelMH;
        private System.Windows.Forms.Label labelNgay;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}