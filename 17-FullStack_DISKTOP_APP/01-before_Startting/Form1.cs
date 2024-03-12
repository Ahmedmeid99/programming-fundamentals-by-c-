using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_before_Startting
{
    public partial class Form1 : Form
    {
        public event Action<string> OnAddressSelected;

        protected virtual void AddressSelected(string Address)
        {
            Action<string> handler = OnAddressSelected;

            if (handler != null )
            {
                handler(Address);
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void login_SignUp1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();

            // create connection detween DataBack and function hold data
            frm3.DataBack += FormDataBack; 

            frm3.Show();
        }

        private void FormDataBack(object sender,string Address)
        {
            txtAddress.Text = Address;
            
            // this place when the event will happen
            if(OnAddressSelected != null)
            {
                AddressSelected(Address);
            }
            
        }

      

        private void btnEvent_OnAddressSelected(string Address)
        {
            lbGetAddress.Text = Address;
        }
    }
}
