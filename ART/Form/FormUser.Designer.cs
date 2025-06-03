namespace ART.Form
{
    partial class FormUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.rdStatus = new DevExpress.XtraEditors.RadioGroup();
            this.SplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.LabelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtOldPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtRepassword = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtFullName = new DevExpress.XtraEditors.TextEdit();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbLoadData = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStrip2 = new System.Windows.Forms.ToolStrip();
            ((System.ComponentModel.ISupportInitialize)(this.rdStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).BeginInit();
            this.SplitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).BeginInit();
            this.SplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            this.ToolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdStatus
            // 
            this.rdStatus.Location = new System.Drawing.Point(110, 175);
            this.rdStatus.Name = "rdStatus";
            this.rdStatus.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdStatus.Properties.Appearance.Options.UseBackColor = true;
            this.rdStatus.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdStatus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.rdStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Active"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "DisActive")});
            this.rdStatus.Size = new System.Drawing.Size(274, 32);
            this.rdStatus.TabIndex = 6;
            // 
            // SplitContainerControl1
            // 
            this.SplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitContainerControl1.Location = new System.Drawing.Point(0, 27);
            this.SplitContainerControl1.Name = "SplitContainerControl1";
            // 
            // SplitContainerControl1.Panel1
            // 
            this.SplitContainerControl1.Panel1.Controls.Add(this.rdStatus);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl5);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtOldPassword);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtRepassword);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl4);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl2);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtPassword);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl1);
            this.SplitContainerControl1.Panel1.Controls.Add(this.LabelControl3);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtUserName);
            this.SplitContainerControl1.Panel1.Controls.Add(this.txtFullName);
            this.SplitContainerControl1.Panel1.Text = "Panel1";
            // 
            // SplitContainerControl1.Panel2
            // 
            this.SplitContainerControl1.Panel2.Text = "Panel2";
            this.SplitContainerControl1.Size = new System.Drawing.Size(298, 241);
            this.SplitContainerControl1.SplitterPosition = 288;
            this.SplitContainerControl1.TabIndex = 10;
            this.SplitContainerControl1.Text = "SplitContainerControl1";
            // 
            // LabelControl5
            // 
            this.LabelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelControl5.Appearance.Options.UseFont = true;
            this.LabelControl5.Location = new System.Drawing.Point(14, 75);
            this.LabelControl5.Name = "LabelControl5";
            this.LabelControl5.Size = new System.Drawing.Size(87, 16);
            this.LabelControl5.TabIndex = 8;
            this.LabelControl5.Text = "Old Password :";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Enabled = false;
            this.txtOldPassword.Location = new System.Drawing.Point(110, 72);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtOldPassword.Properties.Appearance.Options.UseFont = true;
            this.txtOldPassword.Properties.MaxLength = 20;
            this.txtOldPassword.Properties.PasswordChar = '*';
            this.txtOldPassword.Size = new System.Drawing.Size(274, 22);
            this.txtOldPassword.TabIndex = 3;
            // 
            // txtRepassword
            // 
            this.txtRepassword.Location = new System.Drawing.Point(110, 138);
            this.txtRepassword.Name = "txtRepassword";
            this.txtRepassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtRepassword.Properties.Appearance.Options.UseFont = true;
            this.txtRepassword.Properties.MaxLength = 20;
            this.txtRepassword.Properties.PasswordChar = '*';
            this.txtRepassword.Size = new System.Drawing.Size(274, 22);
            this.txtRepassword.TabIndex = 5;
            // 
            // LabelControl4
            // 
            this.LabelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelControl4.Appearance.Options.UseFont = true;
            this.LabelControl4.Location = new System.Drawing.Point(14, 141);
            this.LabelControl4.Name = "LabelControl4";
            this.LabelControl4.Size = new System.Drawing.Size(80, 16);
            this.LabelControl4.TabIndex = 6;
            this.LabelControl4.Text = "Re-Password:";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelControl2.Appearance.Options.UseFont = true;
            this.LabelControl2.Location = new System.Drawing.Point(14, 47);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(66, 16);
            this.LabelControl2.TabIndex = 2;
            this.LabelControl2.Text = "Full Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(110, 105);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.MaxLength = 20;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(274, 22);
            this.txtPassword.TabIndex = 4;
            // 
            // LabelControl1
            // 
            this.LabelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelControl1.Appearance.Options.UseFont = true;
            this.LabelControl1.Location = new System.Drawing.Point(14, 17);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(72, 16);
            this.LabelControl1.TabIndex = 0;
            this.LabelControl1.Text = "User Name :";
            // 
            // LabelControl3
            // 
            this.LabelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.LabelControl3.Appearance.Options.UseFont = true;
            this.LabelControl3.Location = new System.Drawing.Point(14, 108);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(64, 16);
            this.LabelControl3.TabIndex = 4;
            this.LabelControl3.Text = "Password :";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(110, 14);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.MaxLength = 15;
            this.txtUserName.Size = new System.Drawing.Size(274, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(110, 44);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Properties.MaxLength = 20;
            this.txtFullName.Size = new System.Drawing.Size(274, 22);
            this.txtFullName.TabIndex = 2;
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            this.ToolStripSeparator5.Visible = false;
            // 
            // ToolStripButton2
            // 
            this.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton2.Name = "ToolStripButton2";
            this.ToolStripButton2.Size = new System.Drawing.Size(47, 24);
            this.ToolStripButton2.Text = "Reload";
            this.ToolStripButton2.Visible = false;
            // 
            // tsbLoadData
            // 
            this.tsbLoadData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadData.Name = "tsbLoadData";
            this.tsbLoadData.Size = new System.Drawing.Size(64, 24);
            this.tsbLoadData.Text = "Load Data";
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(24, 24);
            this.tsbNew.Text = "&New";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(24, 24);
            this.tsbSave.Text = "&Save";
            // 
            // ToolStripSeparator4
            // 
            this.ToolStripSeparator4.Name = "ToolStripSeparator4";
            this.ToolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            this.ToolStripSeparator4.Visible = false;
            // 
            // ToolStrip2
            // 
            this.ToolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbNew,
            this.ToolStripSeparator1,
            this.tsbLoadData,
            this.ToolStripSeparator4,
            this.ToolStripButton2,
            this.ToolStripSeparator5});
            this.ToolStrip2.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip2.Name = "ToolStrip2";
            this.ToolStrip2.Size = new System.Drawing.Size(298, 27);
            this.ToolStrip2.TabIndex = 9;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.SplitContainerControl1);
            this.Controls.Add(this.ToolStrip2);
            this.Name = "FormUser";
            this.Text = "FormUser";
            ((System.ComponentModel.ISupportInitialize)(this.rdStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel1)).EndInit();
            this.SplitContainerControl1.Panel1.ResumeLayout(false);
            this.SplitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainerControl1)).EndInit();
            this.SplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtOldPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRepassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            this.ToolStrip2.ResumeLayout(false);
            this.ToolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.RadioGroup rdStatus;
        internal DevExpress.XtraEditors.SplitContainerControl SplitContainerControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl5;
        internal DevExpress.XtraEditors.TextEdit txtOldPassword;
        internal DevExpress.XtraEditors.TextEdit txtRepassword;
        internal DevExpress.XtraEditors.LabelControl LabelControl4;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.TextEdit txtPassword;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.TextEdit txtUserName;
        internal DevExpress.XtraEditors.TextEdit txtFullName;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        internal System.Windows.Forms.ToolStripButton ToolStripButton2;
        internal System.Windows.Forms.ToolStripButton tsbLoadData;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton tsbNew;
        internal System.Windows.Forms.ToolStripButton tsbSave;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator4;
        internal System.Windows.Forms.ToolStrip ToolStrip2;
    }
}