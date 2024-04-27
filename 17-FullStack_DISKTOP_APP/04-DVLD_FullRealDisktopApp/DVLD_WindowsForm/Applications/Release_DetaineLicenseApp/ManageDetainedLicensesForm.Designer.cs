namespace DVLD_WindowsForm.Applications.Release_DetaineLicenseApp
{
    partial class ManageDetainedLicensesForm
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
            this.dgvDetainedLicenses = new System.Windows.Forms.DataGridView();
            this.cmpDetainedLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.cmShowPersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmReleaseDetainedLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDetainedLicensesCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbtnRelease = new System.Windows.Forms.PictureBox();
            this.pbtnDetain = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).BeginInit();
            this.cmpDetainedLicense.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnRelease)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnDetain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetainedLicenses
            // 
            this.dgvDetainedLicenses.AllowUserToAddRows = false;
            this.dgvDetainedLicenses.AllowUserToDeleteRows = false;
            this.dgvDetainedLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetainedLicenses.ContextMenuStrip = this.cmpDetainedLicense;
            this.dgvDetainedLicenses.Location = new System.Drawing.Point(15, 189);
            this.dgvDetainedLicenses.MultiSelect = false;
            this.dgvDetainedLicenses.Name = "dgvDetainedLicenses";
            this.dgvDetainedLicenses.ReadOnly = true;
            this.dgvDetainedLicenses.Size = new System.Drawing.Size(1043, 230);
            this.dgvDetainedLicenses.TabIndex = 22;
            this.dgvDetainedLicenses.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetainedLicenses_CellMouseDown);
            // 
            // cmpDetainedLicense
            // 
            this.cmpDetainedLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowPersonDetails,
            this.toolStripMenuItem4,
            this.cmShowLicense,
            this.toolStripMenuItem5,
            this.cmShowPersonHistory,
            this.toolStripMenuItem1,
            this.cmReleaseDetainedLicense});
            this.cmpDetainedLicense.Name = "contextMenuStrip1";
            this.cmpDetainedLicense.Size = new System.Drawing.Size(226, 110);
            // 
            // cmShowPersonDetails
            // 
            this.cmShowPersonDetails.Image = global::DVLD_WindowsForm.Properties.Resources.PersonDetails_32;
            this.cmShowPersonDetails.Name = "cmShowPersonDetails";
            this.cmShowPersonDetails.Size = new System.Drawing.Size(225, 22);
            this.cmShowPersonDetails.Text = "Show Person Details";
            this.cmShowPersonDetails.Click += new System.EventHandler(this.cmShowPersonDetails_Click_1);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // cmShowLicense
            // 
            this.cmShowLicense.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.cmShowLicense.Name = "cmShowLicense";
            this.cmShowLicense.Size = new System.Drawing.Size(225, 22);
            this.cmShowLicense.Text = "Show License Details";
            this.cmShowLicense.Click += new System.EventHandler(this.cmShowLicense_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // cmShowPersonHistory
            // 
            this.cmShowPersonHistory.Image = global::DVLD_WindowsForm.Properties.Resources.PersonLicenseHistory_32;
            this.cmShowPersonHistory.Name = "cmShowPersonHistory";
            this.cmShowPersonHistory.Size = new System.Drawing.Size(225, 22);
            this.cmShowPersonHistory.Text = "Show Person License History";
            this.cmShowPersonHistory.Click += new System.EventHandler(this.cmShowPersonHistory_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(222, 6);
            // 
            // cmReleaseDetainedLicense
            // 
            this.cmReleaseDetainedLicense.Image = global::DVLD_WindowsForm.Properties.Resources.Release_Detained_License_32;
            this.cmReleaseDetainedLicense.Name = "cmReleaseDetainedLicense";
            this.cmReleaseDetainedLicense.Size = new System.Drawing.Size(225, 22);
            this.cmReleaseDetainedLicense.Text = "Release Detained License";
            this.cmReleaseDetainedLicense.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(264, 163);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 30;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(93, 162);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(165, 21);
            this.cmbFilter.TabIndex = 29;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter By : ";
            // 
            // lbDetainedLicensesCount
            // 
            this.lbDetainedLicensesCount.AutoSize = true;
            this.lbDetainedLicensesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetainedLicensesCount.Location = new System.Drawing.Point(103, 433);
            this.lbDetainedLicensesCount.Name = "lbDetainedLicensesCount";
            this.lbDetainedLicensesCount.Size = new System.Drawing.Size(20, 17);
            this.lbDetainedLicensesCount.TabIndex = 27;
            this.lbDetainedLicensesCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(434, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "List Detined Licenes";
            // 
            // pbtnRelease
            // 
            this.pbtnRelease.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbtnRelease.Image = global::DVLD_WindowsForm.Properties.Resources.Release_Detained_License_64;
            this.pbtnRelease.Location = new System.Drawing.Point(932, 138);
            this.pbtnRelease.Name = "pbtnRelease";
            this.pbtnRelease.Size = new System.Drawing.Size(55, 45);
            this.pbtnRelease.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtnRelease.TabIndex = 31;
            this.pbtnRelease.TabStop = false;
            this.pbtnRelease.Click += new System.EventHandler(this.pbtnRelease_Click);
            // 
            // pbtnDetain
            // 
            this.pbtnDetain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbtnDetain.Image = global::DVLD_WindowsForm.Properties.Resources.Detain_64;
            this.pbtnDetain.Location = new System.Drawing.Point(993, 138);
            this.pbtnDetain.Name = "pbtnDetain";
            this.pbtnDetain.Size = new System.Drawing.Size(55, 45);
            this.pbtnDetain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbtnDetain.TabIndex = 25;
            this.pbtnDetain.TabStop = false;
            this.pbtnDetain.Click += new System.EventHandler(this.pbtnDetain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Detain_512;
            this.pictureBox1.Location = new System.Drawing.Point(449, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbActive.Location = new System.Drawing.Point(264, 163);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(153, 21);
            this.cmbActive.TabIndex = 32;
            this.cmbActive.SelectedIndexChanged += new System.EventHandler(this.cmbActive_SelectedIndexChanged);
            // 
            // ManageDetainedLicensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 466);
            this.Controls.Add(this.cmbActive);
            this.Controls.Add(this.pbtnRelease);
            this.Controls.Add(this.pbtnDetain);
            this.Controls.Add(this.dgvDetainedLicenses);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDetainedLicensesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageDetainedLicensesForm";
            this.Text = "ManageDetainedLicensesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetainedLicenses)).EndInit();
            this.cmpDetainedLicense.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbtnRelease)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtnDetain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbtnDetain;
        private System.Windows.Forms.DataGridView dgvDetainedLicenses;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDetainedLicensesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbtnRelease;
        private System.Windows.Forms.ContextMenuStrip cmpDetainedLicense;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersonDetails;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersonHistory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmReleaseDetainedLicense;
        private System.Windows.Forms.ComboBox cmbActive;
    }
}