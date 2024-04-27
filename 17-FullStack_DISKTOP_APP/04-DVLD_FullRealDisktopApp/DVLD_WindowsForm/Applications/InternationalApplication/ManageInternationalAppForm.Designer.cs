namespace DVLD_WindowsForm.Applications.InternationalApplication
{
    partial class ManageInternationalAppForm
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
            this.cmShowPersonHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.cmShowLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmpApplication = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmShowPersonDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbIDLAppsCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvIDLApps = new System.Windows.Forms.DataGridView();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.cmpApplication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLApps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmShowPersonHistory
            // 
            this.cmShowPersonHistory.Image = global::DVLD_WindowsForm.Properties.Resources.PersonLicenseHistory_32;
            this.cmShowPersonHistory.Name = "cmShowPersonHistory";
            this.cmShowPersonHistory.Size = new System.Drawing.Size(225, 22);
            this.cmShowPersonHistory.Text = "Show Person License History";
            this.cmShowPersonHistory.Click += new System.EventHandler(this.cmShowPersonHistory_Click_1);
            // 
            // cmShowLicense
            // 
            this.cmShowLicense.Image = global::DVLD_WindowsForm.Properties.Resources.License_View_32;
            this.cmShowLicense.Name = "cmShowLicense";
            this.cmShowLicense.Size = new System.Drawing.Size(225, 22);
            this.cmShowLicense.Text = "Show License Details";
            this.cmShowLicense.Click += new System.EventHandler(this.cmShowLicense_Click_1);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(222, 6);
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(255, 183);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(153, 20);
            this.txtFilter.TabIndex = 29;
            this.txtFilter.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.New_Application_64;
            this.pictureBox2.Location = new System.Drawing.Point(990, 170);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 33);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Applications;
            this.pictureBox1.Location = new System.Drawing.Point(446, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // cmpApplication
            // 
            this.cmpApplication.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmShowPersonDetails,
            this.toolStripMenuItem4,
            this.cmShowLicense,
            this.toolStripMenuItem5,
            this.cmShowPersonHistory});
            this.cmpApplication.Name = "contextMenuStrip1";
            this.cmpApplication.Size = new System.Drawing.Size(226, 82);
            // 
            // cmShowPersonDetails
            // 
            this.cmShowPersonDetails.Image = global::DVLD_WindowsForm.Properties.Resources.PersonDetails_32;
            this.cmShowPersonDetails.Name = "cmShowPersonDetails";
            this.cmShowPersonDetails.Size = new System.Drawing.Size(225, 22);
            this.cmShowPersonDetails.Text = "Show Person Details";
            this.cmShowPersonDetails.Click += new System.EventHandler(this.cmShowPersonDetails_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(222, 6);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(90, 182);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(159, 21);
            this.cmbFilter.TabIndex = 28;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Filter By : ";
            // 
            // lbIDLAppsCount
            // 
            this.lbIDLAppsCount.AutoSize = true;
            this.lbIDLAppsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDLAppsCount.Location = new System.Drawing.Point(114, 454);
            this.lbIDLAppsCount.Name = "lbIDLAppsCount";
            this.lbIDLAppsCount.Size = new System.Drawing.Size(20, 17);
            this.lbIDLAppsCount.TabIndex = 26;
            this.lbIDLAppsCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 454);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(334, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "International Driving License Application";
            // 
            // dgvIDLApps
            // 
            this.dgvIDLApps.AllowUserToAddRows = false;
            this.dgvIDLApps.AllowUserToDeleteRows = false;
            this.dgvIDLApps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIDLApps.ContextMenuStrip = this.cmpApplication;
            this.dgvIDLApps.Location = new System.Drawing.Point(12, 209);
            this.dgvIDLApps.MultiSelect = false;
            this.dgvIDLApps.Name = "dgvIDLApps";
            this.dgvIDLApps.ReadOnly = true;
            this.dgvIDLApps.Size = new System.Drawing.Size(1043, 230);
            this.dgvIDLApps.TabIndex = 21;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::DVLD_WindowsForm.Properties.Resources.International_32;
            this.pictureBox3.Location = new System.Drawing.Point(619, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbActive.Location = new System.Drawing.Point(255, 183);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(153, 21);
            this.cmbActive.TabIndex = 31;
            this.cmbActive.SelectedIndexChanged += new System.EventHandler(this.cmbActive_SelectedIndexChanged);
            // 
            // ManageInternationalAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 499);
            this.Controls.Add(this.cmbActive);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbIDLAppsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvIDLApps);
            this.Name = "ManageInternationalAppForm";
            this.Text = "ManageInternationalAppForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.cmpApplication.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIDLApps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cmShowPersonHistory;
        private System.Windows.Forms.ToolStripMenuItem cmShowLicense;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip cmpApplication;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbIDLAppsCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIDLApps;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem cmShowPersonDetails;
        private System.Windows.Forms.ComboBox cmbActive;
    }
}