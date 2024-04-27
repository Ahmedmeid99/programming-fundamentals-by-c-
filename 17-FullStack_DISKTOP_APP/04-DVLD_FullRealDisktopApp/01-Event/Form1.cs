using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Event
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void uC_Calculator_SimpleEvent1_OnCalCulationCompleted(int obj)
        {
            string Result = obj.ToString();
            MessageBox.Show("The Result of this Calculation is " + Result);
        }

        private void uC_Calculator_StanderedEvent1_OnCalculationCompleted(object sender, UserControls.UC_Calculator_StanderedEvent.CalculationCompletEventArgs e)
        {
            MessageBox.Show("The Result of " + e.Val1.ToString() + " + " + e.Val2.ToString() + "this Calculation is " + e.Result.ToString());
        }
    }
}
