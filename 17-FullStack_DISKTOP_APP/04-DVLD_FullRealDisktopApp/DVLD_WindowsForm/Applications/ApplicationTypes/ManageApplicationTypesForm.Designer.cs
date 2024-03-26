namespace DVLD_WindowsForm
{
    partial class ManageApplicationTypesForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManageAppTypes = new System.Windows.Forms.DataGridView();
            this.lbAppTypesCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.imgManageApptypes = new System.Windows.Forms.ImageList(this.components);
            this.cmpAppType = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppTypes)).BeginInit();
            this.cmpAppType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(349, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Application Types";
            // 
            // dgvManageAppTypes
            // 
            this.dgvManageAppTypes.AllowUserToAddRows = false;
            this.dgvManageAppTypes.AllowUserToDeleteRows = false;
            this.dgvManageAppTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvManageAppTypes.ContextMenuStrip = this.cmpAppType;
            this.dgvManageAppTypes.Location = new System.Drawing.Point(12, 198);
            this.dgvManageAppTypes.MultiSelect = false;
            this.dgvManageAppTypes.Name = "dgvManageAppTypes";
            this.dgvManageAppTypes.ReadOnly = true;
            this.dgvManageAppTypes.Size = new System.Drawing.Size(859, 230);
            this.dgvManageAppTypes.TabIndex = 14;
            // 
            // lbAppTypesCount
            // 
            this.lbAppTypesCount.AutoSize = true;
            this.lbAppTypesCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAppTypesCount.Location = new System.Drawing.Point(103, 443);
            this.lbAppTypesCount.Name = "lbAppTypesCount";
            this.lbAppTypesCount.Size = new System.Drawing.Size(20, 17);
            this.lbAppTypesCount.TabIndex = 18;
            this.lbAppTypesCount.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 443);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "# Records : ";
            // 
            // imgManageApptypes
            // 
            this.imgManageApptypes.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgManageApptypes.ImageSize = new System.Drawing.Size(16, 16);
            this.imgManageApptypes.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmpAppType
            // 
            this.cmpAppType.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.cmpAppType.Name = "contextMenuStrip1";
            this.cmpAppType.Size = new System.Drawing.Size(185, 26);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DVLD_WindowsForm.Properties.Resources.Application_Types_512;
            this.pictureBox1.Location = new System.Drawing.Point(378, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::DVLD_WindowsForm.Properties.Resources.edit_32;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.editToolStripMenuItem.Text = "Edit Application type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(15, 160);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 32);
            this.btnRefresh.TabIndex = 160;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ManageApplicationTypesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 484);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lbAppTypesCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvManageAppTypes);
            this.Name = "ManageApplicationTypesForm";
            this.Text = "ManageApplicationTypes";
            this.Load += new System.EventHandler(this.ManageApplicationTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageAppTypes)).EndInit();
            this.cmpAppType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvManageAppTypes;
        private System.Windows.Forms.Label lbAppTypesCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imgManageApptypes;
        private System.Windows.Forms.ContextMenuStrip cmpAppType;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button btnRefresh;
    }
}