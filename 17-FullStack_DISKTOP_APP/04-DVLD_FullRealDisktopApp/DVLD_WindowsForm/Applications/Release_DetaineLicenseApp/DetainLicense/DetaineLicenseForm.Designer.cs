namespace DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.DetainLicense
{
    partial class DetainLicenseForm
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
            this.label11 = new System.Windows.Forms.Label();
            this.gbFilterBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindLicense = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDetain = new System.Windows.Forms.Button();
            this.btnlinkShowLicenseInfo = new System.Windows.Forms.LinkLabel();
            this.btnlinkShowLicenseHistory = new System.Windows.Forms.LinkLabel();
            this.lbCreatedBy = new System.Windows.Forms.Label();
            this.lbLicenseID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lbDetainID = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDetainDate = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFineFees = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ucShoLicenseInfo = new DVLD_WindowsForm.Licenses.UserControls.UC_ShoLicenseInfo();
            this.gbFilterBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(360, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "Detain License";
            // 
            // gbFilterBox
            // 
            this.gbFilterBox.Controls.Add(this.label1);
            this.gbFilterBox.Controls.Add(this.pictureBox1);
            this.gbFilterBox.Controls.Add(this.txtFindLicense);
            this.gbFilterBox.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilterBox.Location = new System.Drawing.Point(18, 38);
            this.gbFilterBox.Name = "gbFilterBox";
            this.gbFilterBox.Size = new System.Drawing.Size(857, 71);
            this.gbFilterBox.TabIndex = 14;
            this.gbFilterBox.TabStop = false;
            this.gbFilterBox.Text = "Filter";
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(647, 536);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 34);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Location = new System.Drawing.Point(764, 536);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.Size = new System.Drawing.Size(111, 34);
            this.btnDetain.TabIndex = 20;
            this.btnDetain.Text = "Detain";
            this.btnDetain.UseVisualStyleBackColor = true;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // btnlinkShowLicenseInfo
            // 
            this.btnlinkShowLicenseInfo.AutoSize = true;
            this.btnlinkShowLicenseInfo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseInfo.Location = new System.Drawing.Point(182, 543);
            this.btnlinkShowLicenseInfo.Name = "btnlinkShowLicenseInfo";
            this.btnlinkShowLicenseInfo.Size = new System.Drawing.Size(127, 19);
            this.btnlinkShowLicenseInfo.TabIndex = 19;
            this.btnlinkShowLicenseInfo.TabStop = true;
            this.btnlinkShowLicenseInfo.Text = "Show License Info";
            this.btnlinkShowLicenseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnlinkShowLicenseInfo_LinkClicked);
            // 
            // btnlinkShowLicenseHistory
            // 
            this.btnlinkShowLicenseHistory.AutoSize = true;
            this.btnlinkShowLicenseHistory.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlinkShowLicenseHistory.Location = new System.Drawing.Point(12, 543);
            this.btnlinkShowLicenseHistory.Name = "btnlinkShowLicenseHistory";
            this.btnlinkShowLicenseHistory.Size = new System.Drawing.Size(149, 19);
            this.btnlinkShowLicenseHistory.TabIndex = 18;
            this.btnlinkShowLicenseHistory.TabStop = true;
            this.btnlinkShowLicenseHistory.Text = "Show License History";
            this.btnlinkShowLicenseHistory.Click += new System.EventHandler(this.btnlinkShowLicenseHistory_LinkClicked);
            // 
            // lbCreatedBy
            // 
            this.lbCreatedBy.AutoSize = true;
            this.lbCreatedBy.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCreatedBy.Location = new System.Drawing.Point(635, 49);
            this.lbCreatedBy.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCreatedBy.Name = "lbCreatedBy";
            this.lbCreatedBy.Size = new System.Drawing.Size(21, 19);
            this.lbCreatedBy.TabIndex = 225;
            this.lbCreatedBy.Text = "...";
            // 
            // lbLicenseID
            // 
            this.lbLicenseID.AutoSize = true;
            this.lbLicenseID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLicenseID.Location = new System.Drawing.Point(635, 16);
            this.lbLicenseID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbLicenseID.Name = "lbLicenseID";
            this.lbLicenseID.Size = new System.Drawing.Size(21, 19);
            this.lbLicenseID.TabIndex = 223;
            this.lbLicenseID.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 19);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 222;
            this.label7.Text = "License ID :";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(13, 19);
            this.label22.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 19);
            this.label22.TabIndex = 213;
            this.label22.Text = "Detain ID  :";
            // 
            // lbDetainID
            // 
            this.lbDetainID.AutoSize = true;
            this.lbDetainID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainID.Location = new System.Drawing.Point(186, 19);
            this.lbDetainID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDetainID.Name = "lbDetainID";
            this.lbDetainID.Size = new System.Drawing.Size(21, 19);
            this.lbDetainID.TabIndex = 214;
            this.lbDetainID.Text = "...";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(447, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(130, 19);
            this.label15.TabIndex = 210;
            this.label15.Text = "Created By           :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 207;
            this.label2.Text = "Fine Fees  :";
            // 
            // lbDetainDate
            // 
            this.lbDetainDate.AutoSize = true;
            this.lbDetainDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainDate.Location = new System.Drawing.Point(186, 53);
            this.lbDetainDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbDetainDate.Name = "lbDetainDate";
            this.lbDetainDate.Size = new System.Drawing.Size(21, 19);
            this.lbDetainDate.TabIndex = 205;
            this.lbDetainDate.Text = "...";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(12, 53);
            this.lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(99, 19);
            this.lb.TabIndex = 204;
            this.lb.Text = "Detain Date  :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFineFees);
            this.groupBox2.Controls.Add(this.lbCreatedBy);
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.lbLicenseID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.lbDetainID);
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.pictureBox8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.pictureBox3);
            this.groupBox2.Controls.Add(this.lbDetainDate);
            this.groupBox2.Controls.Add(this.lb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(860, 127);
            this.groupBox2.TabIndex = 207;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detain Info";
            // 
            // txtFineFees
            // 
            this.txtFineFees.Location = new System.Drawing.Point(190, 85);
            this.txtFineFees.Name = "txtFineFees";
            this.txtFineFees.Size = new System.Drawing.Size(94, 22);
            this.txtFineFees.TabIndex = 3;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DVLD_WindowsForm.Properties.Resources.Renew_Driving_License_321;
            this.pictureBox6.Location = new System.Drawing.Point(588, 19);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(31, 26);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 224;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(147, 19);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 215;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DVLD_WindowsForm.Properties.Resources.User_32__2;
            this.pictureBox4.Location = new System.Drawing.Point(590, 49);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(29, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 212;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::DVLD_WindowsForm.Properties.Resources.money_32;
            this.pictureBox8.Location = new System.Drawing.Point(145, 83);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(31, 26);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 209;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WindowsForm.Properties.Resources.Calendar_32;
            this.pictureBox3.Location = new System.Drawing.Point(146, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 206;
            this.pictureBox3.TabStop = false;
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
            this.ucShoLicenseInfo.Location = new System.Drawing.Point(7, 104);
            this.ucShoLicenseInfo.Name = "ucShoLicenseInfo";
            this.ucShoLicenseInfo.NationalNo = null;
            this.ucShoLicenseInfo.Notes = null;
            this.ucShoLicenseInfo.PersonImagePath = null;
            this.ucShoLicenseInfo.Size = new System.Drawing.Size(870, 280);
            this.ucShoLicenseInfo.TabIndex = 13;
            // 
            // DetainLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gbFilterBox);
            this.Controls.Add(this.ucShoLicenseInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.btnlinkShowLicenseInfo);
            this.Controls.Add(this.btnlinkShowLicenseHistory);
            this.Name = "DetainLicenseForm";
            this.Text = "DetaineLicenseForm";
            this.gbFilterBox.ResumeLayout(false);
            this.gbFilterBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gbFilterBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFindLicense;
        private Licenses.UserControls.UC_ShoLicenseInfo ucShoLicenseInfo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDetain;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseInfo;
        private System.Windows.Forms.LinkLabel btnlinkShowLicenseHistory;
        private System.Windows.Forms.Label lbCreatedBy;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbLicenseID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lbDetainID;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbDetainDate;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtFineFees;
    }
}