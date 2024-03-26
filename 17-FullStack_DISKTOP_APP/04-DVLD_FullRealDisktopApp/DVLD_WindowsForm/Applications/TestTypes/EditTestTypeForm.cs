using System;

using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class EditTestTypeForm : Form
    {
        public EditTestTypeForm()
        {
            InitializeComponent();
        }

      
        public enum enMode { Update = 1 };
        public enMode Mode = enMode.Update;

        private int _TestTypeID;
        private clsTestType _TestType;   
        public EditTestTypeForm(int TestTypeID)
        {
            InitializeComponent();


            _TestTypeID = TestTypeID;

            _FillControlsWithData(TestTypeID);

            if (_TestTypeID == -1)
                return;

            Mode = enMode.Update;
        }

        private void EditTestType_Load(object sender, EventArgs e)
        {

        }

        private void _FillControlsWithData(int TestTypeID)
        {
            _TestType = clsTestType.Find(TestTypeID);

            if (_TestType == null)
                return;

            TestTypeID = _TestType.TestTypeID;
            lbTestTypeID.Text = TestTypeID.ToString();
            txtTitle.Text = _TestType.Title;
            txtDescription.Text = _TestType.Description;
            txtFees.Text = _TestType.Fees.ToString();
            // you need to validate inputs [Fees,...,...]

        }

        private void _FillTestTypeWithData(clsTestType _TestType)
        {

            _TestType.Title = txtTitle.Text;
            _TestType.Description = txtDescription.Text;
            _TestType.Fees = Convert.ToDouble(txtFees.Text);
        }

        private void _Save()
        {

            _FillTestTypeWithData(_TestType);

            // Check form is Valid if it is not valid go back  
            // if (!UC_Add_Edit.CheckFormIsValid())
            //     return;

            if (_TestType.Save())
                MessageBox.Show("Data Saved Successfuly");

            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
