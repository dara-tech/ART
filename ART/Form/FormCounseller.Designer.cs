namespace ART.Form
{
    partial class FormCounselor
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
            this.RdCounsellorSex = new DevExpress.XtraEditors.RadioGroup();
            this.DaCounsellor = new DevExpress.XtraEditors.DateEdit();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCounsellorPhone = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCounsellorName = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CboCounsellorStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tbsClear = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.RdCounsellorSex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaCounsellor.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaCounsellor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).BeginInit();
            this.SplitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounsellorPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounsellorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboCounsellorStatus.Properties)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdCounsellorSex
            // 
            this.RdCounsellorSex.Location = new System.Drawing.Point(105, 46);
            this.RdCounsellorSex.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RdCounsellorSex.Name = "RdCounsellorSex";
            this.RdCounsellorSex.Properties.AllowMouseWheel = false;
            this.RdCounsellorSex.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.RdCounsellorSex.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCounsellorSex.Properties.Appearance.Options.UseBackColor = true;
            this.RdCounsellorSex.Properties.Appearance.Options.UseFont = true;
            this.RdCounsellorSex.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.RdCounsellorSex.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("1", "Male"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("0", "Female")});
            this.RdCounsellorSex.Size = new System.Drawing.Size(164, 29);
            this.RdCounsellorSex.TabIndex = 2;
            // 
            // DaCounsellor
            // 
            this.DaCounsellor.EditValue = "01/01/1900";
            this.DaCounsellor.Location = new System.Drawing.Point(105, 121);
            this.DaCounsellor.Margin = new System.Windows.Forms.Padding(2);
            this.DaCounsellor.Name = "DaCounsellor";
            this.DaCounsellor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DaCounsellor.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DaCounsellor.Properties.MaskSettings.Set("mask", "d");
            this.DaCounsellor.Size = new System.Drawing.Size(164, 20);
            this.DaCounsellor.TabIndex = 4;
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 25);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            // 
            // SplitContainerControl1.Panel1
            // 
            this.SplitContainerControl1.Panel1.Controls.Add(this.RdCounsellorSex);
            this.SplitContainerControl1.Panel1.Controls.Add(this.DaCounsellor);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl5);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtCounsellorPhone);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl4);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl2);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl1);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtCounsellorName);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl3);
            this.SplitContainerControl1.Panel1.Controls.Add(this.CboCounsellorStatus);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            // 
            // SplitContainerControl1.Panel2
            // 
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(298, 243);
            this.SplitContainerControl1.SplitterPosition = 289;
            this.SplitContainerControl1.TabIndex = 5;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Location = new System.Drawing.Point(12, 124);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(27, 13);
            this.LabelControl5.TabIndex = 14;
            this.LabelControl5.Text = "Date:";
            // 
            // txtCounsellorPhone
            // 
            this.txtCounsellorPhone.EditValue = "0";
            this.txtCounsellorPhone.Location = new System.Drawing.Point(105, 90);
            this.txtCounsellorPhone.Name = "txtCounsellorPhone";
            this.txtCounsellorPhone.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.txtCounsellorPhone.Properties.MaskSettings.Set("mask", "\\d+");
            this.txtCounsellorPhone.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.txtCounsellorPhone.Size = new System.Drawing.Size(164, 20);
            this.txtCounsellorPhone.TabIndex = 3;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Location = new System.Drawing.Point(12, 92);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(34, 13);
            this.LabelControl4.TabIndex = 12;
            this.LabelControl4.Text = "Phone:";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(12, 54);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(22, 13);
            this.LabelControl2.TabIndex = 10;
            this.LabelControl2.Text = "Sex:";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(12, 21);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(34, 13);
            this.LabelControl1.TabIndex = 4;
            this.LabelControl1.Text = "Name :";
            // 
            // txtCounsellorName
            // 
            this.txtCounsellorName.Location = new System.Drawing.Point(105, 20);
            this.txtCounsellorName.Name = "txtCounsellorName";
            this.txtCounsellorName.Size = new System.Drawing.Size(164, 20);
            this.txtCounsellorName.TabIndex = 1;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(12, 156);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(38, 13);
            this.LabelControl3.TabIndex = 8;
            this.LabelControl3.Text = "Status :";
            // 
            // CboCounsellorStatus
            // 
            this.CboCounsellorStatus.Location = new System.Drawing.Point(105, 154);
            this.CboCounsellorStatus.Name = "CboCounsellorStatus";
            this.CboCounsellorStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboCounsellorStatus.Properties.Items.AddRange(new object[] {
            "Disactive",
            "Active"});
            this.CboCounsellorStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CboCounsellorStatus.Size = new System.Drawing.Size(164, 20);
            this.CboCounsellorStatus.TabIndex = 5;
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton3
            // 
            this.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton3.Name = "ToolStripButton3";
            this.ToolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton3.Text = "Delete";
            this.ToolStripButton3.Visible = false;
            // 
            // tbsClear
            // 
            this.tbsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsClear.Name = "tbsClear";
            this.tbsClear.Size = new System.Drawing.Size(23, 22);
            this.tbsClear.Text = "New";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Text = "Reload Data";
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tbsClear,
            this.ToolStripButton3,
            this.ToolStripSeparator2,
            this.tsbReload});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.ToolStrip2.Size = new System.Drawing.Size(298, 25);
            this.ToolStrip2.TabIndex = 6;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // FormCounseller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.ToolStrip2);
            this.Name = "FormCounseller";
            this.Text = "FormCounseller";
            ((System.ComponentModel.ISupportInitialize)(this.RdCounsellorSex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaCounsellor.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DaCounsellor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).EndInit();
            this.SplitContainerControl1.Panel1.ResumeLayout(false);
            this.SplitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtCounsellorPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCounsellorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboCounsellorStatus.Properties)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.RadioGroup RdCounsellorSex;
        internal DevExpress.XtraEditors.DateEdit DaCounsellor;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.TextEdit txtCounsellorPhone;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtCounsellorName;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.ComboBoxEdit CboCounsellorStatus;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripButton tbsClear;
        internal System.Windows.Forms.ToolStripButton tsbSave;
        internal System.Windows.Forms.ToolStripButton tsbReload;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
    }
}