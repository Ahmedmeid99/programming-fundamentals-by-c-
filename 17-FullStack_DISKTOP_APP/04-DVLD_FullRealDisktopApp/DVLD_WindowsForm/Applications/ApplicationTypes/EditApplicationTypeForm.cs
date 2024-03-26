using DVLDBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public partial class EditApplicationTypeForm : Form
    {
        public enum enMode { Update = 1 };
        public enMode Mode = enMode.Update;

        private int _AppTypeID;
        private clsApplicationType _AppType;
        public EditApplicationTypeForm(int ApplicationTypeID)
        {
            InitializeComponent();


            _AppTypeID = ApplicationTypeID;

            _FillControlsWithData(ApplicationTypeID);

            if (_AppTypeID == -1)
                return;

            Mode = enMode.Update;
        }

        private void EditApplicationType_Load(object sender, EventArgs e)
        {

        }

        private void _FillControlsWithData(int AppTypeID)
        {
            _AppType = clsApplicationType.Find(AppTypeID);

            if (_AppType == null)
                return;

            AppTypeID = _AppType.ApplicationTypeID;
            lbApplicationTypeID.Text = AppTypeID.ToString();
            txtTitle.Text = _AppType.Title;
            txtDescription.Text = _AppType.Description;
            txtFees.Text = _AppType.Fees.ToString();
            // you need to validate inputs [Fees,...,...]

        }

        private void _FillAppTypeWithData(clsApplicationType _AppType)
        {

            _AppType.Title = txtTitle.Text;
            _AppType.Description = txtDescription.Text;
            _AppType.Fees =Convert.ToDouble(txtFees.Text);
        }

        private void _Save()
        {

            _FillAppTypeWithData(_AppType);

            // Check form is Valid if it is not valid go back  
           // if (!UC_Add_Edit.CheckFormIsValid())
           //     return;

            if (_AppType.Save())
                MessageBox.Show("Data Saved Successfuly");
               
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        //----------------------------------------
        //--------------[Validation]--------------
        //----------------------------------------

        private bool _CheckTextBox(TextBox textBox)
        {
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
            {
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");
                return false;
            }
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
            return true;
        }

        private void CheckIsEmpty(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");

            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }

        private void CheckNumField(object sender, KeyPressEventArgs e)
        {
            GlobalMethods.CheckNumField(sender, e);
        }

        public bool CheckFormIsValid()
        {
            bool txt1 = _CheckTextBox(txtTitle);
            bool txt2 = _CheckTextBox(txtDescription);
            bool txt3 = _CheckTextBox(txtFees);
            

            if (txt1 && txt2 && txt3)
                return true;
            else
                return false;

        }

        
    }
}
