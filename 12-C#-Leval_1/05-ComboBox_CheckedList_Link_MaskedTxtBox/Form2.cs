using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ComboBox_CheckedList_Link_MaskedTxtBox
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void frm2_Load(object sender, EventArgs e)
        {
            cbItems.SelectedIndex = 0;
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbSeletedItem.Text = cbItems.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbNewItem.Text != "" )
            {
                cbItems.Items.Add(tbNewItem.Text);
            }
        }

        private void btnDeleteLastItem_Click(object sender, EventArgs e)
        {
            cbItems.Items.RemoveAt(cbItems.Items.Count -1); // Last Item
        }

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string Items = "";
            for (short i=0;i< cbItems.Items.Count; i++)
            {
                Items += cbItems.Items[i].ToString() +"\n";
            }
            MessageBox.Show(Items, "List of Items");
        }
    }
}
