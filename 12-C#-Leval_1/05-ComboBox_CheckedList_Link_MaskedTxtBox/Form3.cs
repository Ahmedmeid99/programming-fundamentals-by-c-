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
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        private void frm3_Load(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            cbCardItems.Items.Add(tbAddNewItem.Text);
        }

        private void cbCardItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCount.Text = cbCardItems.SelectedItems.Count.ToString();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
        }
    }
}