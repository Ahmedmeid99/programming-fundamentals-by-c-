namespace DVLD_WindowsForm.Tests.StreetTest
{
    partial class ManageStreetTestForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lbAppointmentCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvAppointmentsList = new System.Windows.Forms.DataGridView();
            this.cmpTestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ucdlApplicationInfo = new DVLD_WindowsForm.Tests.UserControls.UCDLApplicationInfo();
            this.ucApplicationInfo = new DVLD_WindowsForm.Tests.UserControls.UCApplicationInfo();
            this.pbAddNewAppointment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).BeginInit();
            this.cmpTestAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(671, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 38;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbAppointmentCount
            // 
            this.lbAppointmentCount.AutoSize = true;
            this.lbAppointmentCount.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppointmentCount.Location = new System.Drawing.Point(123, 631);
            this.lbAppointmentCount.Name = "lbAppointmentCount";
            this.lbAppointmentCount.Size = new System.Drawing.Size(17, 17);
            this.lbAppointmentCount.TabIndex = 37;
            this.lbAppointmentCount.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 631);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "# Records : ";
            // 
            // dgvAppointmentsList
            // 
            this.dgvAppointmentsList.AllowUserToAddRows = false;
            this.dgvAppointmentsList.AllowUserToDeleteRows = false;
            this.dgvAppointmentsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointmentsList.ContextMenuStrip = this.cmpTestAppointment;
            this.dgvAppointmentsList.Location = new System.Drawing.Point(35, 505);
            this.dgvAppointmentsList.MultiSelect = false;
            this.dgvAppointmentsList.Name = "dgvAppointmentsList";
            this.dgvAppointmentsList.ReadOnly = true;
            this.dgvAppointmentsList.Size = new System.Drawing.Size(723, 108);
            this.dgvAppointmentsList.TabIndex = 35;
            // 
            // cmpTestAppointment
            // 
            this.cmpTestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmEdit,
            this.cmTakeTest});
            this.cmpTestAppointment.Name = "contextMenuStrip1";
            this.cmpTestAppointment.Size = new System.Drawing.Size(121, 48);
            // 
            // cmEdit
            // 
            this.cmEdit.Image = global::DVLD_WindowsForm.Properties.Resources.edit_32;
            this.cmEdit.Name = "cmEdit";
            this.cmEdit.Size = new System.Drawing.Size(120, 22);
            this.cmEdit.Text = "Edit";
            this.cmEdit.Click += new System.EventHandler(this.cmEdit_Click);
            // 
            // cmTakeTest
            // 
            this.cmTakeTest.Image = global::DVLD_WindowsForm.Properties.Resources.Test_32;
            this.cmTakeTest.Name = "cmTakeTest";
            this.cmTakeTest.Size = new System.Drawing.Size(120, 22);
            this.cmTakeTest.Text = "Take Test";
            this.cmTakeTest.Click += new System.EventHandler(this.cmTakeTest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Appontments :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(302, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "Street Test Application";
            // 
            // ucdlApplicationInfo
            // 
            this.ucdlApplicationInfo.DLAppID = 0;
            this.ucdlApplicationInfo.LicenseClass = null;
            this.ucdlApplicationInfo.Location = new System.Drawing.Point(22, 111);
            this.ucdlApplicationInfo.Name = "ucdlApplicationInfo";
            this.ucdlApplicationInfo.PassedTests = ((byte)(0));
            this.ucdlApplicationInfo.Size = new System.Drawing.Size(760, 123);
            this.ucdlApplicationInfo.TabIndex = 31;
            // 
            // ucApplicationInfo
            // 
            this.ucApplicationInfo.Applicant = null;
            this.ucApplicationInfo.CreatedBy = null;
            this.ucApplicationInfo.Date = new System.DateTime(((long)(0)));
            this.ucApplicationInfo.Fees = 0D;
            this.ucApplicationInfo.ID = 0;
            this.ucApplicationInfo.Location = new System.Drawing.Point(23, 223);
            this.ucApplicationInfo.Name = "ucApplicationInfo";
            this.ucApplicationInfo.Size = new System.Drawing.Size(759, 243);
            this.ucApplicationInfo.Status = null;
            this.ucApplicationInfo.StatusDate = new System.DateTime(((long)(0)));
            this.ucApplicationInfo.TabIndex = 30;
            this.ucApplicationInfo.Type = null;
            // 
            // pbAddNewAppointment
            // 
            this.pbAddNewAppointment.Image = global::DVLD_WindowsForm.Properties.Resources.AddAppointment_32;
            this.pbAddNewAppointment.Location = new System.Drawing.Point(719, 471);
            this.pbAddNewAppointment.Name = "pbAddNewAppointment";
            this.pbAddNewAppointment.Size = new System.Drawing.Size(39, 28);
            this.pbAddNewAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAddNewAppointment.TabIndex = 39;
            this.pbAddNewAppointment.TabStop = false;
            this.pbAddNewAppointment.Click += new System.EventHandler(this.pbAddNewAppointment_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.driving_test_512;
            this.pictureBox1.Location = new System.Drawing.Point(334, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ManageStreetTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 667);
            this.Controls.Add(this.pbAddNewAppointment);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lbAppointmentCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvAppointmentsList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ucdlApplicationInfo);
            this.Controls.Add(this.ucApplicationInfo);
            this.Name = "ManageStreetTestForm";
            this.Text = "ManageStreetTestForm";
            this.Load += new System.EventHandler(this.ManageStreetTestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentsList)).EndInit();
            this.cmpTestAppointment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbAddNewAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAddNewAppointment;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbAppointmentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvAppointmentsList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private UserControls.UCDLApplicationInfo ucdlApplicationInfo;
        private UserControls.UCApplicationInfo ucApplicationInfo;
        private System.Windows.Forms.ContextMenuStrip cmpTestAppointment;
        private System.Windows.Forms.ToolStripMenuItem cmEdit;
        private System.Windows.Forms.ToolStripMenuItem cmTakeTest;
    }
}