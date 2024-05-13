using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Event.UserControls
{
    public partial class UC_Calculator_StanderedEvent : UserControl
    {
        public UC_Calculator_StanderedEvent()
        {
            InitializeComponent();
        }

        // create Event
        public event EventHandler <CalculationCompletEventArgs> OnCalculationCompleted;

        // create EventArgs class
        public class CalculationCompletEventArgs:EventArgs
        {
            public int Result {get;}
            public int Val1 {get;}
            public int Val2 {get;}

            // Constractor
            public CalculationCompletEventArgs(int Result,int Val1, int Val2)
            {
                this.Result = Result;
                this.Val1 = Val1;
                this.Val2 = Val2;
            }
        }

        // Create Protected Method to Raise Data
        protected virtual void RaiseOnCalculationComplet (CalculationCompletEventArgs e)
        {
            OnCalculationCompleted?.Invoke(this, e);
        }

        public void RaiseOnCalculationComplet(int Result, int Val1, int Val2)
        {
            RaiseOnCalculationComplet(new CalculationCompletEventArgs(Result, Val1, Val2));
        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int Val1 = Convert.ToInt32(txtVal1.Text);
            int Val2 = Convert.ToInt32(txtVal2.Text);
            int Result = Val1 + Val2;

            lbResult.Text = Result.ToString();

            // Raise Data on OnCalCulationCompleted Event
            RaiseOnCalculationComplet(Result, Val1, Val2);
        }
    }
}
