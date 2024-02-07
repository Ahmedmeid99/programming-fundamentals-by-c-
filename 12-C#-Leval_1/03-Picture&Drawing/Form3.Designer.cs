namespace _03_Picture_Drawing
{
    partial class frm3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbNon = new System.Windows.Forms.RadioButton();
            this.rbGirl = new System.Windows.Forms.RadioButton();
            this.rbBoy = new System.Windows.Forms.RadioButton();
            this.lbTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_03_Picture_Drawing.Properties.Resources.friend_05;
            this.pictureBox1.Location = new System.Drawing.Point(289, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Photo Changer";
            // 
            // rbNon
            // 
            this.rbNon.AutoSize = true;
            this.rbNon.Location = new System.Drawing.Point(359, 359);
            this.rbNon.Name = "rbNon";
            this.rbNon.Size = new System.Drawing.Size(45, 17);
            this.rbNon.TabIndex = 2;
            this.rbNon.TabStop = true;
            this.rbNon.Text = "Non";
            this.rbNon.UseVisualStyleBackColor = true;
            this.rbNon.CheckedChanged += new System.EventHandler(this.rbNon_CheckedChanged);
            // 
            // rbGirl
            // 
            this.rbGirl.AutoSize = true;
            this.rbGirl.Location = new System.Drawing.Point(435, 359);
            this.rbGirl.Name = "rbGirl";
            this.rbGirl.Size = new System.Drawing.Size(38, 17);
            this.rbGirl.TabIndex = 3;
            this.rbGirl.TabStop = true;
            this.rbGirl.Text = "gril";
            this.rbGirl.UseVisualStyleBackColor = true;
            this.rbGirl.CheckedChanged += new System.EventHandler(this.rbGirl_CheckedChanged);
            // 
            // rbBoy
            // 
            this.rbBoy.AutoSize = true;
            this.rbBoy.Location = new System.Drawing.Point(289, 359);
            this.rbBoy.Name = "rbBoy";
            this.rbBoy.Size = new System.Drawing.Size(42, 17);
            this.rbBoy.TabIndex = 4;
            this.rbBoy.TabStop = true;
            this.rbBoy.Text = "boy";
            this.rbBoy.UseVisualStyleBackColor = true;
            this.rbBoy.CheckedChanged += new System.EventHandler(this.rbBoy_CheckedChanged);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(369, 78);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(27, 13);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Non";
            // 
            // frm3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.rbBoy);
            this.Controls.Add(this.rbGirl);
            this.Controls.Add(this.rbNon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frm3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Frm3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNon;
        private System.Windows.Forms.RadioButton rbGirl;
        private System.Windows.Forms.RadioButton rbBoy;
        private System.Windows.Forms.Label lbTitle;
    }
}