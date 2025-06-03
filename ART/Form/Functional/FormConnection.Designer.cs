namespace ART.Form.Functional
{
    partial class FormConnection
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
            this.tbnTest = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.MarqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.LabelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.LabelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.MarqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(249, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(83, 28);
            this.btnCancel.TabIndex = 59;
            this.btnCancel.Text = "Cancel";
            // 
            // tbnTest
            // 
            this.tbnTest.Location = new System.Drawing.Point(249, 106);
            this.tbnTest.Name = "tbnTest";
            this.tbnTest.Size = new System.Drawing.Size(83, 28);
            this.tbnTest.TabIndex = 58;
            this.tbnTest.Text = "Test";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(249, 71);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 28);
            this.btnConnect.TabIndex = 57;
            this.btnConnect.Text = "Connect";
            // 
            // MarqueeProgressBarControl1
            // 
            this.MarqueeProgressBarControl1.EditValue = "Connecting to Server";
            this.MarqueeProgressBarControl1.Location = new System.Drawing.Point(-33, 178);
            this.MarqueeProgressBarControl1.Name = "MarqueeProgressBarControl1";
            this.MarqueeProgressBarControl1.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.Cycle;
            this.MarqueeProgressBarControl1.Properties.ReadOnly = true;
            this.MarqueeProgressBarControl1.Properties.ShowTitle = true;
            this.MarqueeProgressBarControl1.Size = new System.Drawing.Size(365, 19);
            this.MarqueeProgressBarControl1.TabIndex = 56;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(50, 146);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '#';
            this.txtPassword.Size = new System.Drawing.Size(167, 20);
            this.txtPassword.TabIndex = 55;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(50, 114);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(167, 20);
            this.txtUserName.TabIndex = 54;
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(50, 79);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(168, 20);
            this.txtServerName.TabIndex = 53;
            // 
            // LabelControl3
            // 
            this.LabelControl3.Location = new System.Drawing.Point(-33, 143);
            this.LabelControl3.Name = "LabelControl3";
            this.LabelControl3.Size = new System.Drawing.Size(53, 13);
            this.LabelControl3.TabIndex = 52;
            this.LabelControl3.Text = "Password :";
            // 
            // LabelControl2
            // 
            this.LabelControl2.Location = new System.Drawing.Point(-33, 115);
            this.LabelControl2.Name = "LabelControl2";
            this.LabelControl2.Size = new System.Drawing.Size(56, 13);
            this.LabelControl2.TabIndex = 51;
            this.LabelControl2.Text = "User Name:";
            // 
            // LabelControl1
            // 
            this.LabelControl1.Location = new System.Drawing.Point(-33, 85);
            this.LabelControl1.Name = "LabelControl1";
            this.LabelControl1.Size = new System.Drawing.Size(69, 13);
            this.LabelControl1.TabIndex = 50;
            this.LabelControl1.Text = "Server Name :";
            // 
            // FormConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.tbnTest);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.MarqueeProgressBarControl1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.LabelControl3);
            this.Controls.Add(this.LabelControl2);
            this.Controls.Add(this.LabelControl1);
            this.Name = "FormConnection";
            this.Text = "FormConnection";
            ((System.ComponentModel.ISupportInitialize)(this.MarqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.SimpleButton btnCancel;
        internal DevExpress.XtraEditors.SimpleButton tbnTest;
        internal DevExpress.XtraEditors.SimpleButton btnConnect;
        internal DevExpress.XtraEditors.MarqueeProgressBarControl MarqueeProgressBarControl1;
        internal DevExpress.XtraEditors.TextEdit txtPassword;
        internal DevExpress.XtraEditors.TextEdit txtUserName;
        internal DevExpress.XtraEditors.TextEdit txtServerName;
        internal DevExpress.XtraEditors.LabelControl LabelControl3;
        internal DevExpress.XtraEditors.LabelControl LabelControl2;
        internal DevExpress.XtraEditors.LabelControl LabelControl1;
    }
}