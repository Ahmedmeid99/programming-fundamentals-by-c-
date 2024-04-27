﻿namespace DVLD_WindowsForm.Applications.LocalApplication
{
    partial class ManageLocalDLApplication
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
            this.components = new System.ComponentModel.Container();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbLDLAppsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmpApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvLDLApps = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmShowApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmEditApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmDeleteApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmCancelApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.cmSechduleTests = new System.Windows.Forms.ToolStripMenuItem();
            this.cmVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmIssueDriving = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowPersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmpApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(265, 174);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 20;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(94, 173);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(165, 21);
            this.cmbFilter.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filter By : ";
            // 
            // lbLDLAppsCount
            // 
            this.lbLDLAppsCount.AutoSize = true;
            this.lbLDLAppsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLDLAppsCount.Location = new System.Drawing.Point(104, 444);
            this.lbLDLAppsCount.Name = "lbLDLAppsCount";
            this.lbLDLAppsCount.Size = new System.Drawing.Size(20, 17);
            this.lbLDLAppsCount.TabIndex = 16;
            this.lbLDLAppsCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(355, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Local Driving License Application";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(242, 6);
            // 
            // cmpApplication
            // 
            this.cmpApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowApplication,
            this.toolStripMenuItem2,
            this.cmEditApplication,
            this.cmDeleteApplication,
            this.toolStripMenuItem6,
            this.cmCancelApplication,
            this.toolStripMenuItem1,
            this.cmSechduleTests,
            this.toolStripMenuItem3,
            this.cmIssueDriving,
            this.toolStripMenuItem4,
            this.cmShowLicense,
            this.toolStripMenuItem5,
            this.cmShowPersonHistory});
            this.cmpApplication.Name = "contextMenuStrip1";
            this.cmpApplication.Size = new System.Drawing.Size(246, 216);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(242, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(242, 6);
            // 
            // dgvLDLApps
            // 
            this.dgvLDLApps.AllowUserToAddRows = false;
            this.dgvLDLApps.AllowUserToDeleteRows = false;
            this.dgvLDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLDLApps.ContextMenuStrip = this.cmpApplication;
            this.dgvLDLApps.Location = new System.Drawing.Point(16, 200);
            this.dgvLDLApps.MultiSelect = false;
            this.dgvLDLApps.Name = "dgvLDLApps";
            this.dgvLDLApps.ReadOnly = true;
            this.dgvLDLApps.Size = new System.Drawing.Size(1043, 230);
            this.dgvLDLApps.TabIndex = 11;
            this.dgvLDLApps.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLDLApps_CellMouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.New_Application_64;
            this.pictureBox2.Location = new System.Drawing.Point(994, 161);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(450, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // cmShowApplication
            // 
            this.cmShowApplication.Image = global::DVLD_WindowsForm.Properties.Resources.PersonDetails_321;
            this.cmShowApplication.Name = "cmShowApplication";
            this.cmShowApplication.Size = new System.Drawing.Size(245, 22);
            this.cmShowApplication.Text = "Show Application Details";
            // 
            // cmEditApplication
            // 
            this.cmEditApplication.Image = global::DVLD_WindowsForm.Properties.Resources.edit_32;
            this.cmEditApplication.Name = "cmEditApplication";
            this.cmEditApplication.Size = new System.Drawing.Size(245, 22);
            this.cmEditApplication.Text = "Edit Application";
            this.cmEditApplication.Click += new System.EventHandler(this.cmEditApplication_Click);
            // 
            // cmDeleteApplication
            // 
            this.cmDeleteApplication.Image = global::DVLD_WindowsForm.Properties.Resources.Delete_32_21;
            this.cmDeleteApplication.Name = "cmDeleteApplication";
            this.cmDeleteApplication.Size = new System.Drawing.Size(245, 22);
            this.cmDeleteApplication.Text = "Delete Application";
            this.cmDeleteApplication.Click += new System.EventHandler(this.cmDeleteApplication_Click);
            // 
            // cmCancelApplication
            // 
            this.cmCancelApplication.Image = global::DVLD_WindowsForm.Properties.Resources.Delete_32;
            this.cmCancelApplication.Name = "cmCancelApplication";
            this.cmCancelApplication.Size = new System.Drawing.Size(245, 22);
            this.cmCancelApplication.Text = "Cancel Application";
            this.cmCancelApplication.Click += new System.EventHandler(this.cmCancelApplication_Click);
            // 
            // cmSechduleTests
            // 
            this.cmSechduleTests.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmVisionTest,
            this.cmWrittenTest,
            this.cmStreetTest});
            this.cmSechduleTests.Image = global::DVLD_WindowsForm.Properties.Resources.TestType_32;
            this.cmSechduleTests.Name = "cmSechduleTests";
            this.cmSechduleTests.Size = new System.Drawing.Size(245, 22);
            this.cmSechduleTests.Text = "Sechdule Tests";
            // 
            // cmVisionTest
            // 
            this.cmVisionTest.Image = global::DVLD_WindowsForm.Properties.Resources.Vision_Test_32;
            this.cmVisionTest.Name = "cmVisionTest";
            this.cmVisionTest.Size = new System.Drawing.Size(187, 22);
            this.cmVisionTest.Text = "Schedule Vision Test";
            this.cmVisionTest.Click += new System.EventHandler(this.cmVisionTest_Click);
            // 
            // cmWrittenTest
            // 
            this.cmWrittenTest.Image = global::DVLD_WindowsForm.Properties.Resources.Written_Test_32;
            this.cmWrittenTest.Name = "cmWrittenTest";
            this.cmWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.cmWrittenTest.Text = "Schedule Written Test";
            this.cmWrittenTest.Click += new System.EventHandler(this.cmWrittenTest_Click);
            // 
            // cmStreetTest
            // 
            this.cmStreetTest.Image = global::DVLD_WindowsForm.Properties.Resources.Street_Test_32;
            this.cmStreetTest.Name = "cmStreetTest";
            this.cmStreetTest.Size = new System.Drawing.Size(187, 22);
            this.cmStreetTest.Text = "Schedule Street Test";
            this.cmStreetTest.Click += new System.EventHandler(this.cmStreetTest_Click);
            // 
            // cmIssueDriving
            // 
            this.cmIssueDriving.Image = global::DVLD_WindowsForm.Properties.Resources.IssueDrivingLicense_321;
            this.cmIssueDriving.Name = "cmIssueDriving";
            this.cmIssueDriving.Size = new System.Drawing.Size(245, 22);
            this.cmIssueDriving.Text = "Issue Driving License (First Time)";
            this.cmIssueDriving.Click += new System.EventHandler(this.cmIssueDriving_Click);
            // 
            // cmShowLicense
            // 
            this.cmShowLicense.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.cmShowLicense.Name = "cmShowLicense";
            this.cmShowLicense.Size = new System.Drawing.Size(245, 22);
            this.cmShowLicense.Text = "Show License";
            this.cmShowLicense.Click += new System.EventHandler(this.cmShowLicense_Click);
            // 
            // cmShowPersonHistory
            // 
            this.cmShowPersonHistory.Image = global::DVLD_WindowsForm.Properties.Resources.PersonLicenseHistory_32;
            this.cmShowPersonHistory.Name = "cmShowPersonHistory";
            this.cmShowPersonHistory.Size = new System.Drawing.Size(245, 22);
            this.cmShowPersonHistory.Text = "Show Person License History";
            this.cmShowPersonHistory.Click += new System.EventHandler(this.cmShowPersonHistory_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DVLD_WindowsForm.Properties.Resources.Local_32;
            this.pictureBox3.Location = new System.Drawing.Point(624, 35);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // ManageLocalDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 484);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLDLAppsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvLDLApps);
            this.Name = "ManageLocalDLApplication";
            this.Text = "ManageLocalDLApplication";
            this.Load += new System.EventHandler(this.ManageLocalDLApplication_Load_1);
            this.cmpApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cmIssueDriving;
        private System.Windows.Forms.ToolStripMenuItem cmCancelApplication;
        private System.Windows.Forms.ToolStripMenuItem cmDeleteApplication;
        private System.Windows.Forms.ToolStripMenuItem cmEditApplication;
        private System.Windows.Forms.ToolStripMenuItem cmShowApplication;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ToolStripMenuItem cmSechduleTests;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbLDLAppsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip cmpApplication;
        private System.Windows.Forms.DataGridView dgvLDLApps;
        private System.Windows.Forms.ToolStripMenuItem cmShowLicense;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersonHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmVisionTest;
        private System.Windows.Forms.ToolStripMenuItem cmWrittenTest;
        private System.Windows.Forms.ToolStripMenuItem cmStreetTest;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}