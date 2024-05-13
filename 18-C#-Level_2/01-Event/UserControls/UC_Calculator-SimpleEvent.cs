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
    public partial class UC_Calculator_SimpleEvent : UserControl
    {
        public UC_Calculator_SimpleEvent()
        {
            InitializeComponent();
        }

        // create Event 
        public event Action<int> OnCalCulationCompleted;

        // Create Protected Method to raise Data
        protected void CalCulationCompleted(int Result)
        {
            Action<int> handler = OnCalCulationCompleted;

            if(handler != null)
            {
                handler(Result);
            }

        }

        private void btnCalcu_Click(object sender, EventArgs e)
        {
            int Val1 = Convert.ToInt32(txtVal1.Text);
            int Val2 = Convert.ToInt32(txtVal2.Text);
            int Result = Val1 + Val2;

            lbResult.Text = Result.ToString();

            // Raise Data on OnCalCulationCompleted Event
            if (OnCalCulationCompleted != null)
            {
                OnCalCulationCompleted(Result);
            }
        }
    }
}
