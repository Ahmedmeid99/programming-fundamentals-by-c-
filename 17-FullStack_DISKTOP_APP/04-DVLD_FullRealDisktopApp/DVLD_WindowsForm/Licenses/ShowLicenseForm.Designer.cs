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
            this.uC_ShoLicenseInfo = new DVLD_WindowsForm.Licenses.UserControls.UC_ShoLicenseInfo();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // uC_ShoLicenseInfo
            // 
            this.uC_ShoLicenseInfo.ClassName = null;
            this.uC_ShoLicenseInfo.DateOfBirth = new System.DateTime(((long)(0)));
            this.uC_ShoLicenseInfo.DriverID = 0;
            this.uC_ShoLicenseInfo.ExpirationDate = new System.DateTime(((long)(0)));
            this.uC_ShoLicenseInfo.Gandor = null;
            this.uC_ShoLicenseInfo.IsActive = false;
            this.uC_ShoLicenseInfo.IsDetained = false;
            this.uC_ShoLicenseInfo.IssueDate = new System.DateTime(((long)(0)));
            this.uC_ShoLicenseInfo.IssueReson = null;
            this.uC_ShoLicenseInfo.LicenseID = 0;
            this.uC_ShoLicenseInfo.Location = new System.Drawing.Point(15, 167);
            this.uC_ShoLicenseInfo.Name = "uC_ShoLicenseInfo";
            this.uC_ShoLicenseInfo.NationalNo = null;
            this.uC_ShoLicenseInfo.Notes = null;
            this.uC_ShoLicenseInfo.PersonImagePath = null;
            this.uC_ShoLicenseInfo.Size = new System.Drawing.Size(866, 332);
            this.uC_ShoLicenseInfo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 505);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.LicenseView_400;
            this.pictureBox2.Location = new System.Drawing.Point(341, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Driving License Info";
            // 
            // ShowLicenseForm
            // 
            this.ClientSize = new System.Drawing.Size(893, 556);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.uC_ShoLicenseInfo);
            this.Name = "ShowLicenseForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClose;
        private UserControls.UC_ShoLicenseInfo uC_ShoLicenseInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}