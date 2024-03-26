namespace DVLD_WindowsForm
{
    partial class Manage_Users
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbUsersCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.cmpUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnShowUserInfo = new System.Windows.Forms.ToolStripSeparator();
            this.mbtnAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mbtnSendEmail = new System.Windows.Forms.ToolStripMenuItem();
            this.mbtnPhoneCall = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbActive = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.cmpUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(237, 169);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(121, 20);
            this.txtFilter.TabIndex = 19;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            this.txtFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            // 
            // cmbFilter
            // 
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(101, 169);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(130, 21);
            this.cmbFilter.TabIndex = 18;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.cmbFilter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-123, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Filter By : ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(364, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(57, 21);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lbUsersCount
            // 
            this.lbUsersCount.AutoSize = true;
            this.lbUsersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsersCount.Location = new System.Drawing.Point(101, 444);
            this.lbUsersCount.Name = "lbUsersCount";
            this.lbUsersCount.Size = new System.Drawing.Size(20, 17);
            this.lbUsersCount.TabIndex = 15;
            this.lbUsersCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "# Records : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(458, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Manage Users";
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.ContextMenuStrip = this.cmpUser;
            this.dgvUsers.Location = new System.Drawing.Point(13, 200);
            this.dgvUsers.MultiSelect = false;
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(1043, 230);
            this.dgvUsers.TabIndex = 11;
            // 
            // cmpUser
            // 
            this.cmpUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sToolStripMenuItem,
            this.mbtnShowUserInfo,
            this.mbtnAddNewUser,
            this.mbtnEdit,
            this.mbtnDelete,
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.mbtnSendEmail,
            this.mbtnPhoneCall});
            this.cmpUser.Name = "contextMenuStrip1";
            this.cmpUser.Size = new System.Drawing.Size(169, 170);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.PersonDetails_321;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.sToolStripMenuItem.Text = "Show Details";
            this.sToolStripMenuItem.Click += new System.EventHandler(this.sToolStripMenuItem_Click);
            // 
            // mbtnShowUserInfo
            // 
            this.mbtnShowUserInfo.Name = "mbtnShowUserInfo";
            this.mbtnShowUserInfo.Size = new System.Drawing.Size(165, 6);
            // 
            // mbtnAddNewUser
            // 
            this.mbtnAddNewUser.Image = global::DVLD_WindowsForm.Properties.Resources.Add_Person_40;
            this.mbtnAddNewUser.Name = "mbtnAddNewUser";
            this.mbtnAddNewUser.Size = new System.Drawing.Size(168, 22);
            this.mbtnAddNewUser.Text = "Add New User";
            this.mbtnAddNewUser.Click += new System.EventHandler(this.mbtnAddNewUser_Click);
            // 
            // mbtnEdit
            // 
            this.mbtnEdit.Image = global::DVLD_WindowsForm.Properties.Resources.edit_32;
            this.mbtnEdit.Name = "mbtnEdit";
            this.mbtnEdit.Size = new System.Drawing.Size(168, 22);
            this.mbtnEdit.Text = "Edit";
            this.mbtnEdit.Click += new System.EventHandler(this.mbtnEdit_Click);
            // 
            // mbtnDelete
            // 
            this.mbtnDelete.Image = global::DVLD_WindowsForm.Properties.Resources.Delete_32;
            this.mbtnDelete.Name = "mbtnDelete";
            this.mbtnDelete.Size = new System.Drawing.Size(168, 22);
            this.mbtnDelete.Text = "Delete";
            this.mbtnDelete.Click += new System.EventHandler(this.mbtnDelete_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Image = global::DVLD_WindowsForm.Properties.Resources.Password_32;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(168, 22);
            this.toolStripMenuItem2.Text = "Change Password";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // mbtnSendEmail
            // 
            this.mbtnSendEmail.Image = global::DVLD_WindowsForm.Properties.Resources.send_email_32;
            this.mbtnSendEmail.Name = "mbtnSendEmail";
            this.mbtnSendEmail.Size = new System.Drawing.Size(168, 22);
            this.mbtnSendEmail.Text = "Send Email";
            this.mbtnSendEmail.Click += new System.EventHandler(this.mbtnSendEmail_Click);
            // 
            // mbtnPhoneCall
            // 
            this.mbtnPhoneCall.Image = global::DVLD_WindowsForm.Properties.Resources.call_32;
            this.mbtnPhoneCall.Name = "mbtnPhoneCall";
            this.mbtnPhoneCall.Size = new System.Drawing.Size(168, 22);
            this.mbtnPhoneCall.Text = "Phone Call";
            this.mbtnPhoneCall.Click += new System.EventHandler(this.mbtnPhoneCall_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Filter By : ";
            // 
            // cmbActive
            // 
            this.cmbActive.FormattingEnabled = true;
            this.cmbActive.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.cmbActive.Location = new System.Drawing.Point(237, 168);
            this.cmbActive.Name = "cmbActive";
            this.cmbActive.Size = new System.Drawing.Size(121, 21);
            this.cmbActive.TabIndex = 23;
            this.cmbActive.SelectedIndexChanged += new System.EventHandler(this.cmbActive_SelectedIndexChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::DVLD_WindowsForm.Properties.Resources.Add_New_User_32;
            this.pictureBox2.Location = new System.Drawing.Point(995, 159);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Users_2_4001;
            this.pictureBox1.Location = new System.Drawing.Point(450, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Manage_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 473);
            this.Controls.Add(this.cmbActive);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbUsersCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvUsers);
            this.Name = "Manage_Users";
            this.Text = "UsersManagementFrm";
            this.Load += new System.EventHandler(this.Manage_Users_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilter_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.cmpUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lbUsersCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip cmpUser;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator mbtnShowUserInfo;
        private System.Windows.Forms.ToolStripMenuItem mbtnAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem mbtnEdit;
        private System.Windows.Forms.ToolStripMenuItem mbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mbtnSendEmail;
        private System.Windows.Forms.ToolStripMenuItem mbtnPhoneCall;
        private System.Windows.Forms.ComboBox cmbActive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}