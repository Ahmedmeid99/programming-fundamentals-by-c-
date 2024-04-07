namespace DVLD_WindowsForm.Licenses
{
    partial class ShowLicenseForm
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
            this.ucShowLicenseInfo = new DVLD_WindowsForm.Licenses.UCShowLicenseInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucShowLicenseInfo
            // 
            this.ucShowLicenseInfo.ClassName = null;
            this.ucShowLicenseInfo.DateOfBirth = new System.DateTime(((long)(0)));
            this.ucShowLicenseInfo.DriverID = 0;
            this.ucShowLicenseInfo.ExpirationDate = new System.DateTime(((long)(0)));
            this.ucShowLicenseInfo.Gandor = null;
            this.ucShowLicenseInfo.IsActive = false;
            this.ucShowLicenseInfo.IsDetained = false;
            this.ucShowLicenseInfo.IssueDate = new System.DateTime(((long)(0)));
            this.ucShowLicenseInfo.IssueReson = null;
            this.ucShowLicenseInfo.LicenseID = 0;
            this.ucShowLicenseInfo.Location = new System.Drawing.Point(7, 141);
            this.ucShowLicenseInfo.Name = "ucShowLicenseInfo";
            this.ucShowLicenseInfo.NationalNo = null;
            this.ucShowLicenseInfo.Notes = null;
            this.ucShowLicenseInfo.PersonImagePath = null;
            this.ucShowLicenseInfo.Size = new System.Drawing.Size(787, 296);
            this.ucShowLicenseInfo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.LicenseView_400;
            this.pictureBox1.Location = new System.Drawing.Point(311, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(315, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 26);
            this.label4.TabIndex = 174;
            this.label4.Text = "Driver License Info";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(669, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 36);
            this.btnClose.TabIndex = 175;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ShowLicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 491);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucShowLicenseInfo);
            this.Name = "ShowLicenseForm";
            this.Text = "ShowLicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCShowLicenseInfo ucShowLicenseInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
    }
}