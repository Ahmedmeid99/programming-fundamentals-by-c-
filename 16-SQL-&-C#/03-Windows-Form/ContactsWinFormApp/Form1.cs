using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsBusinessLayer;

namespace ContactsWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _RefreshContactList();
        }

        private void _RefreshContactList()
        {
           dgvAllContacts.DataSource = clsContact.GetAllContacts();
        }

        private void btnAddNewContact_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit(-1);
            frm.ShowDialog();
            _RefreshContactList();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEdit frm = new frmAddEdit((int)dgvAllContacts.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshContactList();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int  ConatctID = (int)dgvAllContacts.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + ConatctID + " ]", "delete contact", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if(clsContact.DeleteContact(ConatctID))
                {
                    MessageBox.Show("Contatct Deleted Succesfuly");
                    _RefreshContactList();
                }
                else
                {
                    MessageBox.Show("Contatct is not Deleted");
                }
            }
            
            
        }
    }
}
