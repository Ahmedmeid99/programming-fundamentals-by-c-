namespace DVLD_WindowsForm.Tests.MainTests.Test
{
    partial class AddEditTestAppointment
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
            this.lbMessageError = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucRetakeTest = new DVLD_WindowsForm.Tests.UC_TestAppointment.UCRetakeTest();
            this.ucAddEidTestAppointment = new DVLD_WindowsForm.Tests.UC_TestAppointment.UCAddEidTestAppointment();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureTestType = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageError.ForeColor = System.Drawing.Color.Red;
            this.lbMessageError.Location = new System.Drawing.Point(142, 128);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(347, 19);
            this.lbMessageError.TabIndex = 35;
            this.lbMessageError.Text = "Person already sat the test , appointment locked";
            this.lbMessageError.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(368, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 30);
            this.btnClose.TabIndex = 34;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucRetakeTest
            // 
            this.ucRetakeTest.Location = new System.Drawing.Point(-4, 381);
            this.ucRetakeTest.Name = "ucRetakeTest";
            this.ucRetakeTest.ReTestAppID = 0;
            this.ucRetakeTest.ReTestFees = 0D;
            this.ucRetakeTest.Size = new System.Drawing.Size(608, 129);
            this.ucRetakeTest.TabIndex = 32;
            this.ucRetakeTest.TotalFees = 0D;
            // 
            // ucAddEidTestAppointment
            // 
            this.ucAddEidTestAppointment.ClassTypeID = ((byte)(0));
            this.ucAddEidTestAppointment.Date = new System.DateTime(2024, 4, 3, 23, 51, 6, 403);
            this.ucAddEidTestAppointment.DLAppID = 0;
            this.ucAddEidTestAppointment.Fees = 0D;
            this.ucAddEidTestAppointment.Location = new System.Drawing.Point(-4, 141);
            this.ucAddEidTestAppointment.Name = "ucAddEidTestAppointment";
            this.ucAddEidTestAppointment.Size = new System.Drawing.Size(607, 243);
            this.ucAddEidTestAppointment.TabIndex = 31;
            this.ucAddEidTestAppointment.TrialCount = ((byte)(0));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(247, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 22);
            this.label1.TabIndex = 30;
            this.label1.Text = "Scheduled Test";
            // 
            // pictureTestType
            // 
            this.pictureTestType.Image = global::DVLD_WindowsForm.Properties.Resources.Vision_512;
            this.pictureTestType.Location = new System.Drawing.Point(234, 9);
            this.pictureTestType.Name = "pictureTestType";
            this.pictureTestType.Size = new System.Drawing.Size(156, 94);
            this.pictureTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTestType.TabIndex = 29;
            this.pictureTestType.TabStop = false;
            // 
            // AddEditTestAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 559);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucRetakeTest);
            this.Controls.Add(this.ucAddEidTestAppointment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureTestType);
            this.Name = "AddEditTestAppointment";
            this.Text = "AddEditTestAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.pictureTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private UC_TestAppointment.UCRetakeTest ucRetakeTest;
        private UC_TestAppointment.UCAddEidTestAppointment ucAddEidTestAppointment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureTestType;
    }
}