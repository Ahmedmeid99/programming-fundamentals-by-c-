namespace DVLD_WindowsForm
{
    partial class AddEditPersonForm
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.UC_Add_Edit = new DVLD_WindowsForm.UC_Add_Edite();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(547, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 33);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(459, 377);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 33);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // UC_Add_Edit
            // 
            this.UC_Add_Edit.Address = null;
            this.UC_Add_Edit.CountryID = 0;
            this.UC_Add_Edit.DateOfBirth = new System.DateTime(((long)(0)));
            this.UC_Add_Edit.Email = null;
            this.UC_Add_Edit.FirstName = null;
            this.UC_Add_Edit.Gendor = null;
            this.UC_Add_Edit.ImagePath = null;
            this.UC_Add_Edit.LastName = null;
            this.UC_Add_Edit.Location = new System.Drawing.Point(6, 6);
            this.UC_Add_Edit.Name = "UC_Add_Edit";
            this.UC_Add_Edit.NationalNo = null;
            this.UC_Add_Edit.PersonID = 0;
            this.UC_Add_Edit.Phone = null;
            this.UC_Add_Edit.SecondName = null;
            this.UC_Add_Edit.Size = new System.Drawing.Size(915, 365);
            this.UC_Add_Edit.TabIndex = 0;
            this.UC_Add_Edit.ThirdName = null;
            // 
            // AddEditPersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 422);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.UC_Add_Edit);
            this.Name = "AddEditPersonForm";
            this.Text = "AddEditPersonForm";
            this.Load += new System.EventHandler(this.AddEditPersonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UC_Add_Edite UC_Add_Edit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}