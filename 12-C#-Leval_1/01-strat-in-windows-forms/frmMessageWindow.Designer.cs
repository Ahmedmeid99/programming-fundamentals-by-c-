namespace strat_in_windows_forms
{
    partial class frmMessageWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkReact = new System.Windows.Forms.CheckBox();
            this.checkcs = new System.Windows.Forms.CheckBox();
            this.checkAngular = new System.Windows.Forms.CheckBox();
            this.btnCheckReactOption = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.txtboxTotalPoints = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "this is massage window";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 62);
            this.button1.TabIndex = 1;
            this.button1.Text = "showHelloMessage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkReact
            // 
            this.checkReact.AutoSize = true;
            this.checkReact.Location = new System.Drawing.Point(86, 142);
            this.checkReact.Name = "checkReact";
            this.checkReact.Size = new System.Drawing.Size(50, 17);
            this.checkReact.TabIndex = 2;
            this.checkReact.Text = "react";
            this.checkReact.UseVisualStyleBackColor = true;
            this.checkReact.CheckedChanged += new System.EventHandler(this.checkReact_CheckedChanged);
            // 
            // checkcs
            // 
            this.checkcs.AutoSize = true;
            this.checkcs.Location = new System.Drawing.Point(86, 188);
            this.checkcs.Name = "checkcs";
            this.checkcs.Size = new System.Drawing.Size(39, 17);
            this.checkcs.TabIndex = 3;
            this.checkcs.Text = "c#";
            this.checkcs.UseVisualStyleBackColor = true;
            // 
            // checkAngular
            // 
            this.checkAngular.AutoSize = true;
            this.checkAngular.Location = new System.Drawing.Point(86, 165);
            this.checkAngular.Name = "checkAngular";
            this.checkAngular.Size = new System.Drawing.Size(61, 17);
            this.checkAngular.TabIndex = 4;
            this.checkAngular.Text = "angular";
            this.checkAngular.UseVisualStyleBackColor = true;
            // 
            // btnCheckReactOption
            // 
            this.btnCheckReactOption.Location = new System.Drawing.Point(86, 225);
            this.btnCheckReactOption.Name = "btnCheckReactOption";
            this.btnCheckReactOption.Size = new System.Drawing.Size(85, 28);
            this.btnCheckReactOption.TabIndex = 8;
            this.btnCheckReactOption.Text = "check react";
            this.btnCheckReactOption.UseVisualStyleBackColor = true;
            this.btnCheckReactOption.Click += new System.EventHandler(this.btnCheckReactOption_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(420, 387);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "check react";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(38, 72);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "50";
            this.radioButton2.Text = "desktop";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(38, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "100";
            this.radioButton1.Text = "web";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(38, 49);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(55, 17);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "75";
            this.radioButton3.Text = "mobile";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(86, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "programing filed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(305, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "main language";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(38, 44);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 17);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "english";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(38, 21);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(34, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "ar";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(38, 72);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(55, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "france";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // txtboxTotalPoints
            // 
            this.txtboxTotalPoints.Enabled = false;
            this.txtboxTotalPoints.Location = new System.Drawing.Point(87, 387);
            this.txtboxTotalPoints.Name = "txtboxTotalPoints";
            this.txtboxTotalPoints.Size = new System.Drawing.Size(100, 20);
            this.txtboxTotalPoints.TabIndex = 12;
            // 
            // frmMessageWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 464);
            this.Controls.Add(this.txtboxTotalPoints);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCheckReactOption);
            this.Controls.Add(this.checkAngular);
            this.Controls.Add(this.checkcs);
            this.Controls.Add(this.checkReact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmMessageWindow";
            this.Text = "frmMessageWindow";
            this.Load += new System.EventHandler(this.frmMessageWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkReact;
        private System.Windows.Forms.CheckBox checkcs;
        private System.Windows.Forms.CheckBox checkAngular;
        private System.Windows.Forms.Button btnCheckReactOption;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.TextBox txtboxTotalPoints;
    }
}