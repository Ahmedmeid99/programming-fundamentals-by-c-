namespace DVLD_WindowsForm.Applications.ReplaceLicenseApp
{
    partial class ReplacementLicenseForm
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
            this.lbReplacementTypeTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindLicense = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdLostLicense = new System.Windows.Forms.RadioButton();
            this.rdDamageLicense = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnlinkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnlinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ucReplacementApplication = new DVLD_WindowsForm.Applications.ReplaceLicenseApp.UCReplacementApplication();
            this.ucShoLicenseInfo = new DVLD_WindowsForm.Licenses.UserControls.UC_ShoLicenseInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbReplacementTypeTitle
            // 
            this.lbReplacementTypeTitle.AutoSize = true;
            this.lbReplacementTypeTitle.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReplacementTypeTitle.ForeColor = System.Drawing.Color.Red;
            this.lbReplacementTypeTitle.Location = new System.Drawing.Point(287, 6);
            this.lbReplacementTypeTitle.Name = "lbReplacementTypeTitle";
            this.lbReplacementTypeTitle.Size = new System.Drawing.Size(345, 26);
            this.lbReplacementTypeTitle.TabIndex = 6;
            this.lbReplacementTypeTitle.Text = "Replacement for Damaged License";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFindLicense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 71);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "LicenseID  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.pictureBox1.Location = new System.Drawing.Point(544, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFindLicense
            // 
            this.txtFindLicense.Location = new System.Drawing.Point(154, 28);
            this.txtFindLicense.Name = "txtFindLicense";
            this.txtFindLicense.Size = new System.Drawing.Size(367, 29);
            this.txtFindLicense.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdLostLicense);
            this.groupBox2.Controls.Add(this.rdDamageLicense);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(633, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 71);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replacement For";
            // 
            // rdLostLicense
            // 
            this.rdLostLicense.AutoSize = true;
            this.rdLostLicense.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdLostLicense.Location = new System.Drawing.Point(18, 38);
            this.rdLostLicense.Name = "rdLostLicense";
            this.rdLostLicense.Size = new System.Drawing.Size(101, 21);
            this.rdLostLicense.TabIndex = 1;
            this.rdLostLicense.TabStop = true;
            this.rdLostLicense.Text = "Lost License";
            this.rdLostLicense.UseVisualStyleBackColor = true;
            this.rdLostLicense.CheckedChanged += new System.EventHandler(this.UpdateReplacementType);
            // 
            // rdDamageLicense
            // 
            this.rdDamageLicense.AutoSize = true;
            this.rdDamageLicense.Font = new System.Drawing.Font("Microsoft PhagsPa", 9.7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdDamageLicense.Location = new System.Drawing.Point(18, 17);
            this.rdDamageLicense.Name = "rdDamageLicense";
            this.rdDamageLicense.Size = new System.Drawing.Size(126, 21);
            this.rdDamageLicense.TabIndex = 0;
            this.rdDamageLicense.TabStop = true;
            this.rdDamageLicense.Text = "Damage License";
            this.rdDamageLicense.UseVisualStyleBackColor = true;
            this.rdDamageLicense.CheckedChanged += new System.EventHandler(this.UpdateReplacementType);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(651, 533);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 34);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(768, 533);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(111, 34);
            this.btnReplace.TabIndex = 11;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnlinkShowLicenseInfo
            // 
            this.btnlinkShowLicenseInfo.AutoSize = true;
            this.btnlinkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseInfo.Location = new System.Drawing.Point(186, 540);
            this.btnlinkShowLicenseInfo.Name = "btnlinkShowLicenseInfo";
            this.btnlinkShowLicenseInfo.Size = new System.Drawing.Size(127, 19);
            this.btnlinkShowLicenseInfo.TabIndex = 10;
            this.btnlinkShowLicenseInfo.TabStop = true;
            this.btnlinkShowLicenseInfo.Text = "Show License Info";
            this.btnlinkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseInfo_LinkClicked);
            // 
            // btnlinkShowLicenseHistory
            // 
            this.btnlinkShowLicenseHistory.AutoSize = true;
            this.btnlinkShowLicenseHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseHistory.Location = new System.Drawing.Point(16, 540);
            this.btnlinkShowLicenseHistory.Name = "btnlinkShowLicenseHistory";
            this.btnlinkShowLicenseHistory.Size = new System.Drawing.Size(149, 19);
            this.btnlinkShowLicenseHistory.TabIndex = 9;
            this.btnlinkShowLicenseHistory.TabStop = true;
            this.btnlinkShowLicenseHistory.Text = "Show License History";
            this.btnlinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseHistory_LinkClicked);
            // 
            // ucReplacementApplication
            // 
            this.ucReplacementApplication.Location = new System.Drawing.Point(12, 387);
            this.ucReplacementApplication.Name = "ucReplacementApplication";
            this.ucReplacementApplication.Size = new System.Drawing.Size(875, 141);
            this.ucReplacementApplication.TabIndex = 7;
            // 
            // ucShoLicenseInfo
            // 
            this.ucShoLicenseInfo.ClassName = null;
            this.ucShoLicenseInfo.DateOfBirth = new System.DateTime(((long)(0)));
            this.ucShoLicenseInfo.DriverID = 0;
            this.ucShoLicenseInfo.ExpirationDate = new System.DateTime(((long)(0)));
            this.ucShoLicenseInfo.Gandor = null;
            this.ucShoLicenseInfo.IsActive = false;
            this.ucShoLicenseInfo.IsDetained = false;
            this.ucShoLicenseInfo.IssueDate = new System.DateTime(((long)(0)));
            this.ucShoLicenseInfo.IssueReson = null;
            this.ucShoLicenseInfo.LicenseID = 0;
            this.ucShoLicenseInfo.Location = new System.Drawing.Point(11, 101);
            this.ucShoLicenseInfo.Name = "ucShoLicenseInfo";
            this.ucShoLicenseInfo.NationalNo = null;
            this.ucShoLicenseInfo.Notes = null;
            this.ucShoLicenseInfo.PersonImagePath = null;
            this.ucShoLicenseInfo.Size = new System.Drawing.Size(870, 280);
            this.ucShoLicenseInfo.TabIndex = 4;
            // 
            // ReplacementLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 580);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnlinkShowLicenseInfo);
            this.Controls.Add(this.btnlinkShowLicenseHistory);
            this.Controls.Add(this.ucReplacementApplication);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbReplacementTypeTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucShoLicenseInfo);
            this.Name = "ReplacementLicenseForm";
            this.Text = "Replacement License for Damage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbReplacementTypeTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFindLicense;
        private Licenses.UserControls.UC_ShoLicenseInfo ucShoLicenseInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private UCReplacementApplication ucReplacementApplication;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseHistory;
        private System.Windows.Forms.RadioButton rdLostLicense;
        private System.Windows.Forms.RadioButton rdDamageLicense;
    }
}