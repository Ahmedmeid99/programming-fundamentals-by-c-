﻿using System;
using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public partial class MainForm : Form
    {
        // forms will open once while click on its button many times

        public MainForm()
        {
            InitializeComponent();
        }
        


        
        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form frmPeople = new Manage_People();
                frmPeople.MdiParent = this;
                frmPeople.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}