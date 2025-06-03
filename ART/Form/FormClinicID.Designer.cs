namespace ART.Form
{
    partial class FormClinicID
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
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.txtClinicID = new System.Windows.Forms.TextBox();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(188, 149);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(67, 22);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // BtnOk
            // 
            this.BtnOk.Location = new System.Drawing.Point(81, 149);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(67, 22);
            this.BtnOk.TabIndex = 6;
            this.BtnOk.Text = "Ok";
            // 
            // txtClinicID
            // 
            this.txtClinicID.Location = new System.Drawing.Point(81, 97);
            this.txtClinicID.Name = "txtClinicID";
            this.txtClinicID.Size = new System.Drawing.Size(184, 21);
            this.txtClinicID.TabIndex = 5;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(33, 100);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(42, 13);
            this.LabelControl1.TabIndex = 4;
            this.LabelControl1.Text = "ClinicID :";
            // 
            // FormClinicID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOk);
            this.Controls.Add(this.txtClinicID);
            this.Controls.Add(this.LabelControl1);
            this.Name = "FormClinicID";
            this.Text = "FormClinicID";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton BtnOk;
        internal System.Windows.Forms.TextBox txtClinicID;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
    }
}