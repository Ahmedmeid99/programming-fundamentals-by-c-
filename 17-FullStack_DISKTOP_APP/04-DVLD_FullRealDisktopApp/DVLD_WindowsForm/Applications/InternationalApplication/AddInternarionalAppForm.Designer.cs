namespace DVLD_WindowsForm.Applications.InternationalApplication
{
    partial class AddInternarionalAppForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindLicense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ucInterApplicationInfo = new DVLD_WindowsForm.Applications.InternationalApplication.UserControls.UCInterApplicationInfo();
            this.ucShoLicenseInfo = new DVLD_WindowsForm.Licenses.UserControls.UC_ShoLicenseInfo();
            this.btnlinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.btnlinkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFindLicense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 71);
            this.groupBox1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(288, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "International License Application";
            // 
            // ucInterApplicationInfo
            // 
            this.ucInterApplicationInfo.Location = new System.Drawing.Point(18, 461);
            this.ucInterApplicationInfo.Name = "ucInterApplicationInfo";
            this.ucInterApplicationInfo.Size = new System.Drawing.Size(864, 201);
            this.ucInterApplicationInfo.TabIndex = 4;
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
            this.ucShoLicenseInfo.Location = new System.Drawing.Point(12, 121);
            this.ucShoLicenseInfo.Name = "ucShoLicenseInfo";
            this.ucShoLicenseInfo.NationalNo = null;
            this.ucShoLicenseInfo.Notes = null;
            this.ucShoLicenseInfo.PersonImagePath = null;
            this.ucShoLicenseInfo.Size = new System.Drawing.Size(870, 343);
            this.ucShoLicenseInfo.TabIndex = 0;
            // 
            // btnlinkShowLicenseHistory
            // 
            this.btnlinkShowLicenseHistory.AutoSize = true;
            this.btnlinkShowLicenseHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseHistory.Location = new System.Drawing.Point(19, 675);
            this.btnlinkShowLicenseHistory.Name = "btnlinkShowLicenseHistory";
            this.btnlinkShowLicenseHistory.Size = new System.Drawing.Size(149, 19);
            this.btnlinkShowLicenseHistory.TabIndex = 5;
            this.btnlinkShowLicenseHistory.TabStop = true;
            this.btnlinkShowLicenseHistory.Text = "Show License History";
            this.btnlinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseHistory_LinkClicked);
            // 
            // btnlinkShowLicenseInfo
            // 
            this.btnlinkShowLicenseInfo.AutoSize = true;
            this.btnlinkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseInfo.Location = new System.Drawing.Point(189, 675);
            this.btnlinkShowLicenseInfo.Name = "btnlinkShowLicenseInfo";
            this.btnlinkShowLicenseInfo.Size = new System.Drawing.Size(127, 19);
            this.btnlinkShowLicenseInfo.TabIndex = 6;
            this.btnlinkShowLicenseInfo.TabStop = true;
            this.btnlinkShowLicenseInfo.Text = "Show License Info";
            this.btnlinkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseInfo_LinkClicked);
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(771, 668);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(111, 34);
            this.btnIssue.TabIndex = 7;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(654, 668);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // AddInternarionalAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 717);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.btnlinkShowLicenseInfo);
            this.Controls.Add(this.btnlinkShowLicenseHistory);
            this.Controls.Add(this.ucInterApplicationInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucShoLicenseInfo);
            this.Name = "AddInternarionalAppForm";
            this.Text = "AddInternarionalAppForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Licenses.UserControls.UC_ShoLicenseInfo ucShoLicenseInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFindLicense;
        private System.Windows.Forms.Label label2;
        private UserControls.UCInterApplicationInfo ucInterApplicationInfo;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseHistory;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseInfo;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
    }
}