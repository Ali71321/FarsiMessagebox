namespace System.Windows.Forms
{
    partial class FarsiMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarsiMessage));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnOk = new DevExpress.XtraEditors.SimpleButton();
            this.btnYes = new DevExpress.XtraEditors.SimpleButton();
            this.btnNo = new DevExpress.XtraEditors.SimpleButton();
            this.lblText = new DevExpress.XtraEditors.LabelControl();
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.Controls.Add(this.btnOk);
            this.groupControl1.Controls.Add(this.btnYes);
            this.groupControl1.Controls.Add(this.btnNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 94);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(374, 34);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "groupControl1";
            // 
            // btnOk
            // 
            this.btnOk.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOk.ImageOptions.Image")));
            this.btnOk.Location = new System.Drawing.Point(5, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 24);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "تایید";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnYes
            // 
            this.btnYes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.ImageOptions.Image")));
            this.btnYes.Location = new System.Drawing.Point(101, 5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(90, 24);
            this.btnYes.TabIndex = 5;
            this.btnYes.Text = "بله";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.ImageOptions.Image")));
            this.btnNo.Location = new System.Drawing.Point(5, 5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(90, 24);
            this.btnNo.TabIndex = 5;
            this.btnNo.Text = "خیر";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblText
            // 
            this.lblText.Appearance.Options.UseTextOptions = true;
            this.lblText.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.lblText.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblText.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblText.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblText.Location = new System.Drawing.Point(90, -25);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(279, 113);
            this.lblText.TabIndex = 9;
            this.lblText.Text = "labelControl1";
            this.lblText.Click += new System.EventHandler(this.lblText_Click);
            // 
            // pbxIcon
            // 
            this.pbxIcon.Location = new System.Drawing.Point(20, 0);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(64, 64);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcon.TabIndex = 10;
            this.pbxIcon.TabStop = false;
            // 
            // FarsiMessage
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(374, 128);
            this.ControlBox = false;
            this.Controls.Add(this.pbxIcon);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.groupControl1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FarsiMessage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.ShowMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnOk;
        private DevExpress.XtraEditors.SimpleButton btnNo;
        private DevExpress.XtraEditors.SimpleButton btnYes;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblText;
        private System.Windows.Forms.PictureBox pbxIcon;
    }
}

