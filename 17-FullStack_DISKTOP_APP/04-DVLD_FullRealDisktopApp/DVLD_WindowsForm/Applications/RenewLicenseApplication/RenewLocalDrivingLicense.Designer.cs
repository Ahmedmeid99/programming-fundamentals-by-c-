namespace DVLD_WindowsForm.Applications.RenewLicenseApplication
{
    partial class RenewLocalDrivingLicense
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindLicense = new System.Windows.Forms.TextBox();
            this.ucRenewLicenseInfo = new DVLD_WindowsForm.Applications.RenewApplication.UserControls.UCRenewLicenseInfo();
            this.btnRenew = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnlinkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnlinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.ucShoLicenseInfo = new DVLD_WindowsForm.Licenses.UserControls.UC_ShoLicenseInfo();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(276, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Renew License Application";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtFindLicense);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 57);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "LicenseID  :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.pictureBox1.Location = new System.Drawing.Point(548, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtFindLicense
            // 
            this.txtFindLicense.Location = new System.Drawing.Point(158, 22);
            this.txtFindLicense.Name = "txtFindLicense";
            this.txtFindLicense.Size = new System.Drawing.Size(367, 29);
            this.txtFindLicense.TabIndex = 0;
            // 
            // ucRenewLicenseInfo
            // 
            this.ucRenewLicenseInfo.Location = new System.Drawing.Point(0, 370);
            this.ucRenewLicenseInfo.Name = "ucRenewLicenseInfo";
            this.ucRenewLicenseInfo.Size = new System.Drawing.Size(872, 281);
            this.ucRenewLicenseInfo.TabIndex = 7;
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(746, 648);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(117, 34);
            this.btnRenew.TabIndex = 8;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(623, 648);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 34);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnlinkShowLicenseInfo
            // 
            this.btnlinkShowLicenseInfo.AutoSize = true;
            this.btnlinkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseInfo.Location = new System.Drawing.Point(181, 660);
            this.btnlinkShowLicenseInfo.Name = "btnlinkShowLicenseInfo";
            this.btnlinkShowLicenseInfo.Size = new System.Drawing.Size(127, 19);
            this.btnlinkShowLicenseInfo.TabIndex = 11;
            this.btnlinkShowLicenseInfo.TabStop = true;
            this.btnlinkShowLicenseInfo.Text = "Show License Info";
            this.btnlinkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseInfo_LinkClicked);
            // 
            // btnlinkShowLicenseHistory
            // 
            this.btnlinkShowLicenseHistory.AutoSize = true;
            this.btnlinkShowLicenseHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseHistory.Location = new System.Drawing.Point(11, 660);
            this.btnlinkShowLicenseHistory.Name = "btnlinkShowLicenseHistory";
            this.btnlinkShowLicenseHistory.Size = new System.Drawing.Size(149, 19);
            this.btnlinkShowLicenseHistory.TabIndex = 10;
            this.btnlinkShowLicenseHistory.TabStop = true;
            this.btnlinkShowLicenseHistory.Text = "Show License History";
            this.btnlinkShowLicenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseHistory_LinkClicked);
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
            this.ucShoLicenseInfo.Location = new System.Drawing.Point(0, 89);
            this.ucShoLicenseInfo.Name = "ucShoLicenseInfo";
            this.ucShoLicenseInfo.NationalNo = null;
            this.ucShoLicenseInfo.Notes = null;
            this.ucShoLicenseInfo.PersonImagePath = null;
            this.ucShoLicenseInfo.Size = new System.Drawing.Size(874, 287);
            this.ucShoLicenseInfo.TabIndex = 12;
            // 
            // RenewLocalDrivingLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 688);
            this.Controls.Add(this.ucShoLicenseInfo);
            this.Controls.Add(this.btnlinkShowLicenseInfo);
            this.Controls.Add(this.btnlinkShowLicenseHistory);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ucRenewLicenseInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RenewLocalDrivingLicense";
            this.Text = "RenewLocalDrivingLicense";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFindLicense;
        private RenewApplication.UserControls.UCRenewLicenseInfo ucRenewLicenseInfo;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseHistory;
        private Licenses.UserControls.UC_ShoLicenseInfo ucShoLicenseInfo;
    }
}