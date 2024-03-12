using ContactBusinessLayer;
using ContactsBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsWinFormApp
{
    public partial class frmAddEdit : Form
    {
        public enum enMode { Addnew = 0, Update = 1 }

        private enMode _Mode;

        private int _ContactID;
        private clsContact _Contact;
        // constractor 
        public frmAddEdit(int ContactID)
        {
            InitializeComponent();

            _ContactID = ContactID;

            if (_ContactID == -1)
                _Mode = enMode.Addnew;
            else
                _Mode = enMode.Update;
        }

        private void _FillCountriesInCompobox()
        {
            // save coountries from database in datatable
            DataTable dataTable = clsCountry.GetAllCountries();

            // loop on compobox to insert in it countryName
            foreach (DataRow row in dataTable.Rows)
            {
                cbCountries.Items.Add(row["CountryName"]);
            }


        }
        private void _LoadData()
        {

            _FillCountriesInCompobox();
            cbCountries.SelectedIndex = 0;

            if (_Mode == enMode.Addnew)
            {
                lblMode.Text = "Add New Contact";
                _Contact = new clsContact();
                btnRemoveImage.Visible = false;
                return;
            }

            _Contact = clsContact.Find(_ContactID);

            // fix error if anther user delete the contact you want to update in same time
            if (_Contact == null)
            {
                MessageBox.Show("This form will be closed because no Contact in it");

                this.Close();
                return;
            }

            // full inputs with contact info
            lblMode.Text = "Edit Contact ID = " + _ContactID;
            lblContactID.Text = _ContactID.ToString();
            txtFirstName.Text = _Contact.FirstName;
            txtLastName.Text = _Contact.LastName;
            txtEmali.Text = _Contact.Email;
            txtPhone.Text = _Contact.Phone;
            txtAddress.Text = _Contact.Address;
            dtbDateOfBirth.Value = _Contact.DateOfBirth;

            if (_Contact.ImagePath != "" && _Contact.ImagePath != null)
            {
                pictureBox.Load(_Contact.ImagePath);
            }

            btnRemoveImage.Visible = (_Contact.ImagePath != "");

            // select country in Compobox
            cbCountries.SelectedIndex = cbCountries.FindString(clsCountry.FindByID(_Contact.CountryID).CountryName); ;

        }

        private void frm_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        private void _Save()
        {
            // mode add new
            // load data to Countact
            int CountryID = clsCountry.FindByName(cbCountries.Text).CountryID;

            _Contact.FirstName = txtFirstName.Text;
            _Contact.LastName = txtLastName.Text;
            _Contact.Phone = txtPhone.Text;
            _Contact.Email = txtEmali.Text;
            _Contact.Address = txtAddress.Text;
            _Contact.DateOfBirth = dtbDateOfBirth.Value;
            _Contact.CountryID = CountryID;

            if (pictureBox.ImageLocation != null)
                _Contact.ImagePath = pictureBox.ImageLocation;
            else
                _Contact.ImagePath = ""; // empty string will be solve in DataAccessLayer

            if (_Contact.Save())
                MessageBox.Show("Data Saved Successfuly");
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

            _Mode = enMode.Update;
            lblMode.Text = "Edit Contact ID = " + _Contact.ID;
            lblContactID.Text = _Contact.ID.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetImage_Click(object sender, EventArgs e)
        {
            saveFileDialog.InitialDirectory = @"E:\";
            saveFileDialog.DefaultExt = ".png";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _Contact.ImagePath = saveFileDialog.FileName;
                pictureBox.ImageLocation = _Contact.ImagePath;
            }
        }

        private void btnRemoveImage_Click(object sender, EventArgs e)
        {
            pictureBox.ImageLocation = null;
            _Save();

        }
    }

}
