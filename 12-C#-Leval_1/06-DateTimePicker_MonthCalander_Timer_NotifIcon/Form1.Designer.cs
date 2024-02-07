namespace _06_DateTimePicker_MonthCalander_Timer_NotifIcon
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
            this.components = new System.ComponentModel.Container();
            this.btnShowFormatedDate = new System.Windows.Forms.Button();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.dateTime1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbMonthDate = new System.Windows.Forms.Label();
            this.btnFormateMonth = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbCounter = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnShowNotifyIcon = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowFormatedDate
            // 
            this.btnShowFormatedDate.Location = new System.Drawing.Point(18, 61);
            this.btnShowFormatedDate.Name = "btnShowFormatedDate";
            this.btnShowFormatedDate.Size = new System.Drawing.Size(117, 23);
            this.btnShowFormatedDate.TabIndex = 1;
            this.btnShowFormatedDate.Text = "Formated Date";
            this.btnShowFormatedDate.UseVisualStyleBackColor = true;
            this.btnShowFormatedDate.Click += new System.EventHandler(this.btnShowFormatedDate_Click);
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Location = new System.Drawing.Point(161, 66);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(59, 13);
            this.lbDateTime.TabIndex = 2;
            this.lbDateTime.Text = "Date_Time";
            // 
            // dateTime1
            // 
            this.dateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTime1.Location = new System.Drawing.Point(18, 19);
            this.dateTime1.Name = "dateTime1";
            this.dateTime1.Size = new System.Drawing.Size(224, 20);
            this.dateTime1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTime1);
            this.groupBox1.Controls.Add(this.lbDateTime);
            this.groupBox1.Controls.Add(this.btnShowFormatedDate);
            this.groupBox1.Location = new System.Drawing.Point(280, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Date Time";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Controls.Add(this.lbMonthDate);
            this.groupBox2.Controls.Add(this.btnFormateMonth);
            this.groupBox2.Location = new System.Drawing.Point(280, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 226);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Month Calander";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 23);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.SelectionRange = new System.Windows.Forms.SelectionRange(new System.DateTime(2024, 1, 23, 0, 0, 0, 0), new System.DateTime(2024, 1, 29, 0, 0, 0, 0));
            this.monthCalendar1.TabIndex = 3;
            // 
            // lbMonthDate
            // 
            this.lbMonthDate.AutoSize = true;
            this.lbMonthDate.Location = new System.Drawing.Point(152, 202);
            this.lbMonthDate.Name = "lbMonthDate";
            this.lbMonthDate.Size = new System.Drawing.Size(66, 13);
            this.lbMonthDate.TabIndex = 2;
            this.lbMonthDate.Text = "Month_Date";
            // 
            // btnFormateMonth
            // 
            this.btnFormateMonth.Location = new System.Drawing.Point(6, 197);
            this.btnFormateMonth.Name = "btnFormateMonth";
            this.btnFormateMonth.Size = new System.Drawing.Size(117, 23);
            this.btnFormateMonth.TabIndex = 1;
            this.btnFormateMonth.Text = "Formated Month";
            this.btnFormateMonth.UseVisualStyleBackColor = true;
            this.btnFormateMonth.Click += new System.EventHandler(this.btnFormateMonth_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbCounter);
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.btnStart);
            this.groupBox3.Location = new System.Drawing.Point(280, 350);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(261, 73);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(179, 33);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(63, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(18, 33);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(63, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbCounter
            // 
            this.lbCounter.AutoSize = true;
            this.lbCounter.Location = new System.Drawing.Point(122, 38);
            this.lbCounter.Name = "lbCounter";
            this.lbCounter.Size = new System.Drawing.Size(13, 13);
            this.lbCounter.TabIndex = 4;
            this.lbCounter.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // btnShowNotifyIcon
            // 
            this.btnShowNotifyIcon.Location = new System.Drawing.Point(340, 435);
            this.btnShowNotifyIcon.Name = "btnShowNotifyIcon";
            this.btnShowNotifyIcon.Size = new System.Drawing.Size(126, 23);
            this.btnShowNotifyIcon.TabIndex = 6;
            this.btnShowNotifyIcon.Text = "Show Notify Icon";
            this.btnShowNotifyIcon.UseVisualStyleBackColor = true;
            this.btnShowNotifyIcon.Click += new System.EventHandler(this.btnShowNotifyIcon_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.btnShowNotifyIcon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowFormatedDate;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.DateTimePicker dateTime1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbMonthDate;
        private System.Windows.Forms.Button btnFormateMonth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbCounter;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btnShowNotifyIcon;
    }
}

