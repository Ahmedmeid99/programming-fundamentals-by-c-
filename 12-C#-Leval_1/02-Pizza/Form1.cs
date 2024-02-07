using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        
        // CalculateTotalPrice
        //      CalculateSizePrice
        //      CalculateToppingsPrice
        //      CalculateToCrustPrice
        
        // [] updateTotalPrice UI
        // [] updateSize       UI
        // [] updateToppings   UI
        // [] updateCrust      UI
        // [] updateWhereToEat UI
       






        public Form1()
        {
            InitializeComponent();

        }

        float CalculateSizePrice()
        {
            if(rdSmall.Checked)
            {
                return Convert.ToSingle(rdSmall.Tag);
            }
            else if(rdMeduim.Checked)
            {
                return Convert.ToSingle(rdMeduim.Tag);
            }
            else
            {
                return Convert.ToSingle(rdLarg.Tag);
            }
        }
        float CalculateToppingsPrice()
        {
            float Total = 0;
            if(chkChees.Checked)
            {
                Total = Convert.ToSingle(chkChees.Tag);

            }
             if(chkMushrooms.Checked)
            {
                Total += Convert.ToSingle(chkMushrooms.Tag);

            } if(chkTomatoes.Checked)
            {
                Total += Convert.ToSingle(chkTomatoes.Tag);

            }
             if(chkOnion.Checked)
            {
                Total += Convert.ToSingle(chkOnion.Tag);

            } if(chkOlives.Checked)
            {
                Total += Convert.ToSingle(chkOlives.Tag);

            } if(chkGreenPeppers.Checked)
            {
                Total += Convert.ToSingle(chkGreenPeppers.Tag);

            }
            return Total;

        }

        float CalculateToCrustPrice()
        {
            if(rdThinkCrust.Checked)
            {
                return Convert.ToSingle(rdThinkCrust.Tag);
            }

            return 0;
        }
       
        float CalculateTotalPrice()
        {
            return CalculateSizePrice() + CalculateToppingsPrice() + CalculateToCrustPrice();
        }

        void EnableChanges(bool Enable)
        {
            // Size
            rdMeduim.Enabled = Enable;
            rdSmall.Enabled = Enable;
            rdLarg.Enabled = Enable;

            // Crest type
            rdThinCrust.Enabled = Enable;
            rdThinkCrust.Enabled = Enable;

            // Where
            rdEatin.Enabled = Enable;
            rdTakeOut.Enabled = Enable;

            // toppings
            chkChees.Enabled = Enable;
            chkMushrooms.Enabled = Enable;
            chkTomatoes.Enabled = Enable;
            chkOlives.Enabled = Enable;
            chkOnion.Enabled = Enable;
            chkGreenPeppers.Enabled = Enable;

            // 
            btnOrderPizza.Enabled = Enable;
        }

        void updateTotalPrice()
        {
            lbTotalPrice.Text = "$" + Convert.ToString(CalculateTotalPrice());
        }
        
        void updateSize()
        {
            updateTotalPrice();

            if(rdSmall.Checked)
            {
                lbSise.Text = "Small";
            }
            else if (rdMeduim.Checked)
            {
                lbSise.Text = "Meduim";
            }
            else
            {
                lbSise.Text = "Larg";
            }
        }

        void updateToppings()
        {
            updateTotalPrice();

            string Toppings = "";

            if(chkChees.Checked)
            {
                Toppings += chkChees.Text + " ,";
            }
             if(chkMushrooms.Checked)
            {
                Toppings += chkMushrooms.Text + " ,";
            }
             if (chkTomatoes.Checked)
            {
                Toppings += chkTomatoes.Text + " ,";
            }
             if (chkOnion.Checked)
            {
                Toppings += chkOnion.Text + " ,";
            }
             if (chkOlives.Checked)
            {
                Toppings += chkOlives.Text + " ,";
            }
             if (chkGreenPeppers.Checked)
            {
                Toppings += chkGreenPeppers.Text;
            }
             if(Toppings == "")
            {
                lbToppings.Text = "No Toppings";

            }
            else
            {
                lbToppings.Text = Toppings;
            }

        }

        void updateCrust()
        {
            updateTotalPrice();

            if(rdThinkCrust.Checked)
            {
                lbCrustType.Text = rdThinkCrust.Text;
            }
            else
            {
                lbCrustType.Text = rdThinCrust.Text;
            }
        }

        void updateWhereToEat()
        {
            updateTotalPrice();
            
            if(rdEatin.Checked)
            {
                lbCrustType.Text = rdEatin.Text;
            }
            else
            {
                lbCrustType.Text = rdTakeOut.Text;
            }
        }

        void ResetOrderConfigration()
        {
            rdMeduim.Checked = true;
            rdThinCrust.Checked = true;
            rdEatin.Checked = true;

            // toppings
            chkChees.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOlives.Checked = false;
            chkOnion.Checked = false;
            chkGreenPeppers.Checked = false;

            // Reset Ui
            updateSize();
            updateToppings();
            updateWhereToEat();
            updateCrust();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ResetOrderConfigration();
        }


        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void rdThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rdThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rdEatin_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rdTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEat();
        }

        private void rdSmall_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rdMeduim_CheckedChanged(object sender, EventArgs e)
        {
            updateSize(); ;
        }

        private void rdLarg_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            ResetOrderConfigration();

            EnableChanges(true);


        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("click ok to save order","Pizza order",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) ==DialogResult.OK)
            {
                EnableChanges(false);
            }
        }
    }
}
