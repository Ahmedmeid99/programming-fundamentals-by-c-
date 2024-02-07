using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_DateTimePicker_MonthCalander_Timer_NotifIcon
{
    public partial class Form1 : Form
    {
        private string n = Environment.NewLine;
        private int Counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // set short date in label
            lbDateTime.Text = dateTime1.Text;
            lbMonthDate.Text = monthCalendar1.SelectionRange.Start.ToString();
        }

        private void btnShowFormatedDate_Click(object sender, EventArgs e)
        {
            string FormatedDate =
                dateTime1.Value.ToLongDateString() + n +
                dateTime1.Value.ToLongTimeString() + n +
                dateTime1.Value.ToString("dd-mm-yyyy") + n +
                dateTime1.Value.ToString("dd/mm/yyyy") + n +
                dateTime1.Value.ToString("dd mm yyyy") + n +
                dateTime1.Value.ToString("dd-mmm-yyyy");


            MessageBox.Show(FormatedDate);
        }

        private void btnFormateMonth_Click(object sender, EventArgs e)
        {
            string FormatedDate =
                "Start at : "  +
                monthCalendar1.SelectionRange.Start.ToString() + n + n +
                "End at : " +
                monthCalendar1.SelectionRange.End.ToString();
            MessageBox.Show(FormatedDate);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Counter++;
            lbCounter.Text = Counter.ToString();
        }

        private void btnShowNotifyIcon_Click(object sender, EventArgs e)
        {
            notifyIcon1.Icon = SystemIcons.Application;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            notifyIcon1.BalloonTipTitle = "From Facebok";
            notifyIcon1.BalloonTipText = "your post have 12000000 like";
            notifyIcon1.ShowBalloonTip(5000);
        }

    }
}
