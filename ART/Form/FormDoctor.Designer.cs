namespace ART.Form
{
    partial class FormDoctor
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
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tbsClear = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoctor = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.CboStatus = new DevExpress.XtraEditors.ComboBoxEdit();
            this.ToolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).BeginInit();
            this.SplitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoctor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tbsClear,
            this.ToolStripButton3,
            this.ToolStripSeparator2,
            this.tsbReload});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(298, 25);
            this.ToolStrip2.TabIndex = 12;
            this.ToolStrip2.Text = "ToolStrip2";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "Save";
            // 
            // tbsClear
            // 
            this.tbsClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbsClear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsClear.Name = "tbsClear";
            this.tbsClear.Size = new System.Drawing.Size(23, 22);
            this.tbsClear.Text = "New";
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
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(23, 22);
            this.tsbReload.Text = "Reload Data";
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            // 
            // SplitContainerControl1.Panel1
            // 
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl1);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtDoctor);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl3);
            this.SplitContainerControl1.Panel1.Controls.Add(this.CboStatus);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            // 
            // SplitContainerControl1.Panel2
            // 
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(298, 268);
            this.SplitContainerControl1.SplitterPosition = 264;
            this.SplitContainerControl1.TabIndex = 13;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(12, 21);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(69, 13);
            this.LabelControl1.TabIndex = 4;
            this.LabelControl1.Text = "Doctor Name :";
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(88, 18);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(164, 20);
            this.txtDoctor.TabIndex = 5;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(12, 60);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(38, 13);
            this.LabelControl3.TabIndex = 8;
            this.LabelControl3.Text = "Status :";
            // 
            // CboStatus
            // 
            this.CboStatus.Location = new System.Drawing.Point(88, 57);
            this.CboStatus.Name = "CboStatus";
            this.CboStatus.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CboStatus.Properties.Items.AddRange(new object[] {
            "Disactive",
            "Active"});
            this.CboStatus.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CboStatus.Size = new System.Drawing.Size(164, 20);
            this.CboStatus.TabIndex = 9;
            // 
            // FormDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.ToolStrip2);
            this.Controls.Add(this.SplitContainerControl1);
            this.Name = "FormDoctor";
            this.Text = "FormDoctor";
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).EndInit();
            this.SplitContainerControl1.Panel1.ResumeLayout(false);
            this.SplitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDoctor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboStatus.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStrip ToolStrip2;
        internal System.Windows.Forms.ToolStripButton tsbSave;
        internal System.Windows.Forms.ToolStripButton tbsClear;
        internal System.Windows.Forms.ToolStripButton ToolStripButton3;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton tsbReload;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.TextEdit txtDoctor;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.ComboBoxEdit CboStatus;
    }
}