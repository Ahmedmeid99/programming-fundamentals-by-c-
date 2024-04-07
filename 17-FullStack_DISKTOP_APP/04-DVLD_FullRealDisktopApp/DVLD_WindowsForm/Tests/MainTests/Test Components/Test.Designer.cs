namespace DVLD_WindowsForm.Tests.MainTests.Test
{
    partial class TakeTestForm
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ucAddEidTestAppointment = new DVLD_WindowsForm.Tests.UC_TestAppointment.UCAddEidTestAppointment();
            this.lbMessageError = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtnPass = new System.Windows.Forms.RadioButton();
            this.rdbtnFail = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureTestType = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTestType)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(368, 525);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 30);
            this.btnClose.TabIndex = 31;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(479, 525);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 30);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ucAddEidTestAppointment
            // 
            this.ucAddEidTestAppointment.ClassTypeID = ((byte)(0));
            this.ucAddEidTestAppointment.Date = new System.DateTime(2024, 4, 3, 23, 51, 26, 215);
            this.ucAddEidTestAppointment.DLAppID = 0;
            this.ucAddEidTestAppointment.Fees = 0D;
            this.ucAddEidTestAppointment.Location = new System.Drawing.Point(-5, 142);
            this.ucAddEidTestAppointment.Name = "ucAddEidTestAppointment";
            this.ucAddEidTestAppointment.Size = new System.Drawing.Size(607, 243);
            this.ucAddEidTestAppointment.TabIndex = 28;
            this.ucAddEidTestAppointment.TrialCount = ((byte)(0));
            // 
            // lbMessageError
            // 
            this.lbMessageError.AutoSize = true;
            this.lbMessageError.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessageError.ForeColor = System.Drawing.Color.Red;
            this.lbMessageError.Location = new System.Drawing.Point(136, 121);
            this.lbMessageError.Name = "lbMessageError";
            this.lbMessageError.Size = new System.Drawing.Size(347, 19);
            this.lbMessageError.TabIndex = 27;
            this.lbMessageError.Text = "Person already sat the test , appointment locked";
            this.lbMessageError.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(150, 434);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(434, 85);
            this.txtDescription.TabIndex = 165;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 166;
            this.label2.Text = "Result         : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 434);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 169;
            this.label3.Text = "Notes          : ";
            // 
            // rdbtnPass
            // 
            this.rdbtnPass.AutoSize = true;
            this.rdbtnPass.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnPass.Location = new System.Drawing.Point(150, 391);
            this.rdbtnPass.Name = "rdbtnPass";
            this.rdbtnPass.Size = new System.Drawing.Size(53, 21);
            this.rdbtnPass.TabIndex = 170;
            this.rdbtnPass.TabStop = true;
            this.rdbtnPass.Text = "Pass";
            this.rdbtnPass.UseVisualStyleBackColor = true;
            // 
            // rdbtnFail
            // 
            this.rdbtnFail.AutoSize = true;
            this.rdbtnFail.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnFail.Location = new System.Drawing.Point(224, 391);
            this.rdbtnFail.Name = "rdbtnFail";
            this.rdbtnFail.Size = new System.Drawing.Size(48, 21);
            this.rdbtnFail.TabIndex = 171;
            this.rdbtnFail.TabStop = true;
            this.rdbtnFail.Text = "Fail";
            this.rdbtnFail.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DVLD_WindowsForm.Properties.Resources.Notes_32;
            this.pictureBox3.Location = new System.Drawing.Point(111, 434);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(24, 17);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 172;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.Number_32;
            this.pictureBox2.Location = new System.Drawing.Point(111, 391);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 17);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 168;
            this.pictureBox2.TabStop = false;
            // 
            // pictureTestType
            // 
            this.pictureTestType.Image = global::DVLD_WindowsForm.Properties.Resources.Written_Test_512;
            this.pictureTestType.Location = new System.Drawing.Point(224, 2);
            this.pictureTestType.Name = "pictureTestType";
            this.pictureTestType.Size = new System.Drawing.Size(156, 94);
            this.pictureTestType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureTestType.TabIndex = 26;
            this.pictureTestType.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Brown;
            this.label4.Location = new System.Drawing.Point(235, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 173;
            this.label4.Text = "Scheduled Test";
            // 
            // TakeTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 564);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.rdbtnFail);
            this.Controls.Add(this.rdbtnPass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.ucAddEidTestAppointment);
            this.Controls.Add(this.lbMessageError);
            this.Controls.Add(this.pictureTestType);
            this.Name = "TakeTestForm";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTestType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private UC_TestAppointment.UCAddEidTestAppointment ucAddEidTestAppointment;
        private System.Windows.Forms.Label lbMessageError;
        private System.Windows.Forms.PictureBox pictureTestType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtnPass;
        private System.Windows.Forms.RadioButton rdbtnFail;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
    }
}