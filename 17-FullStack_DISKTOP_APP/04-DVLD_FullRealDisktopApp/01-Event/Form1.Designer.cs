namespace _01_Event
{
    partial class Form1
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
            this.uC_Calculator_SimpleEvent1 = new _01_Event.UserControls.UC_Calculator_SimpleEvent();
            this.label1 = new System.Windows.Forms.Label();
            this.uC_Calculator_StanderedEvent1 = new _01_Event.UserControls.UC_Calculator_StanderedEvent();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uC_Calculator_SimpleEvent1
            // 
            this.uC_Calculator_SimpleEvent1.Location = new System.Drawing.Point(30, 31);
            this.uC_Calculator_SimpleEvent1.Name = "uC_Calculator_SimpleEvent1";
            this.uC_Calculator_SimpleEvent1.Size = new System.Drawing.Size(390, 185);
            this.uC_Calculator_SimpleEvent1.TabIndex = 0;
            this.uC_Calculator_SimpleEvent1.OnCalCulationCompleted += new System.Action<int>(this.uC_Calculator_SimpleEvent1_OnCalCulationCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(51, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Simple Event";
            // 
            // uC_Calculator_StanderedEvent1
            // 
            this.uC_Calculator_StanderedEvent1.Location = new System.Drawing.Point(403, 248);
            this.uC_Calculator_StanderedEvent1.Name = "uC_Calculator_StanderedEvent1";
            this.uC_Calculator_StanderedEvent1.Size = new System.Drawing.Size(385, 190);
            this.uC_Calculator_StanderedEvent1.TabIndex = 2;
            this.uC_Calculator_StanderedEvent1.OnCalculationCompleted += new System.EventHandler<_01_Event.UserControls.UC_Calculator_StanderedEvent.CalculationCompletEventArgs>(this.uC_Calculator_StanderedEvent1_OnCalculationCompleted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(431, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Standered Event";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uC_Calculator_StanderedEvent1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uC_Calculator_SimpleEvent1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UC_Calculator_SimpleEvent uC_Calculator_SimpleEvent1;
        private System.Windows.Forms.Label label1;
        private UserControls.UC_Calculator_StanderedEvent uC_Calculator_StanderedEvent1;
        private System.Windows.Forms.Label label2;
    }
}

