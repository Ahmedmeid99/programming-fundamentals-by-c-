namespace DVLD_WindowsForm.Applications.LocalApplication
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
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtnShowUserInfo = new System.Windows.Forms.ToolStripSeparator();
            this.cmpApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mbtnShowApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.sechduleTestsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbLocalDLAppsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLocalDLApps = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAddNewApp = new System.Windows.Forms.PictureBox();
            this.cmpApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDLApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Filter By : ";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // mbtnShowUserInfo
            // 
            this.mbtnShowUserInfo.Name = "mbtnShowUserInfo";
            this.mbtnShowUserInfo.Size = new System.Drawing.Size(242, 6);
            // 
            // cmpApplication
            // 
            this.cmpApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtnShowApplication,
            this.mbtnShowUserInfo,
            this.mbtnEdit,
            this.mbtnDelete,
            this.toolStripMenuItem1,
            this.cancelApplicationToolStripMenuItem,
            this.toolStripMenuItem2,
            this.sechduleTestsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.toolStripMenuItem4,
            this.showLicenseToolStripMenuItem,
            this.toolStripMenuItem5,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.cmpApplication.Name = "contextMenuStrip1";
            this.cmpApplication.Size = new System.Drawing.Size(246, 216);
            // 
            // mbtnShowApplication
            // 
            this.mbtnShowApplication.Image = global::DVLD_WindowsForm.Properties.Resources.PersonDetails_321;
            this.mbtnShowApplication.Name = "mbtnShowApplication";
            this.mbtnShowApplication.Size = new System.Drawing.Size(245, 22);
            this.mbtnShowApplication.Text = "Show Application Details";
            this.mbtnShowApplication.Click += new System.EventHandler(this.mbtnShowApplication_Click);
            // 
            // mbtnEdit
            // 
            this.mbtnEdit.Image = global::DVLD_WindowsForm.Properties.Resources.edit_32;
            this.mbtnEdit.Name = "mbtnEdit";
            this.mbtnEdit.Size = new System.Drawing.Size(245, 22);
            this.mbtnEdit.Text = "Edit Application";
            this.mbtnEdit.Click += new System.EventHandler(this.mbtnEdit_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Image = global::DVLD_WindowsForm.Properties.Resources.Delete_32_21;
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(245, 22);
            this.mbtnDelete.Text = "Delete Application";
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click_1);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.Delete_32;
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(242, 6);
            // 
            // sechduleTestsToolStripMenuItem
            // 
            this.sechduleTestsToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.Schedule_Test_32;
            this.sechduleTestsToolStripMenuItem.Name = "sechduleTestsToolStripMenuItem";
            this.sechduleTestsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.sechduleTestsToolStripMenuItem.Text = "Sechdule Tests";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(242, 6);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.IssueDrivingLicense_321;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(242, 6);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(242, 6);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.PersonLicenseHistory_32;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(281, 181);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(135, 20);
            this.txtFilter.TabIndex = 32;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(100, 180);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(175, 21);
            this.cmbFilter.TabIndex = 31;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(422, 180);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 21);
            this.btnRefresh.TabIndex = 29;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // lbLocalDLAppsCount
            // 
            this.lbLocalDLAppsCount.AutoSize = true;
            this.lbLocalDLAppsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLocalDLAppsCount.Location = new System.Drawing.Point(100, 455);
            this.lbLocalDLAppsCount.Name = "lbLocalDLAppsCount";
            this.lbLocalDLAppsCount.Size = new System.Drawing.Size(20, 17);
            this.lbLocalDLAppsCount.TabIndex = 28;
            this.lbLocalDLAppsCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 455);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(358, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Local Driving Licenses Application";
            // 
            // dgvLocalDLApps
            // 
            this.dgvLocalDLApps.AllowUserToAddRows = false;
            this.dgvLocalDLApps.AllowUserToDeleteRows = false;
            this.dgvLocalDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalDLApps.ContextMenuStrip = this.cmpApplication;
            this.dgvLocalDLApps.Location = new System.Drawing.Point(12, 211);
            this.dgvLocalDLApps.MultiSelect = false;
            this.dgvLocalDLApps.Name = "dgvLocalDLApps";
            this.dgvLocalDLApps.ReadOnly = true;
            this.dgvLocalDLApps.Size = new System.Drawing.Size(1043, 230);
            this.dgvLocalDLApps.TabIndex = 24;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DVLD_WindowsForm.Properties.Resources.Local_32;
            this.pictureBox3.Location = new System.Drawing.Point(618, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(447, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // btnAddNewApp
            // 
            this.btnAddNewApp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAddNewApp.Image = global::DVLD_WindowsForm.Properties.Resources.New_Application_64;
            this.btnAddNewApp.Location = new System.Drawing.Point(994, 170);
            this.btnAddNewApp.Name = "btnAddNewApp";
            this.btnAddNewApp.Size = new System.Drawing.Size(55, 35);
            this.btnAddNewApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddNewApp.TabIndex = 34;
            this.btnAddNewApp.TabStop = false;
            this.btnAddNewApp.Click += new System.EventHandler(this.btnAddNewApp_Click);
            // 
            // ManageLocalDLApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 485);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddNewApp);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbLocalDLAppsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLocalDLApps);
            this.Name = "ManageLocalDLApplication";
            this.Text = "ManageLocalDLApplication";
            this.Load += new System.EventHandler(this.ManageLocalDLApplication_Load);
            this.cmpApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalDLApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddNewApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbtnDelete;
        private System.Windows.Forms.ToolStripMenuItem mbtnEdit;
        private System.Windows.Forms.ToolStripSeparator mbtnShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem mbtnShowApplication;
        private System.Windows.Forms.ContextMenuStrip cmpApplication;
        private System.Windows.Forms.PictureBox btnAddNewApp;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbLocalDLAppsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLocalDLApps;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem sechduleTestsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
    }
}