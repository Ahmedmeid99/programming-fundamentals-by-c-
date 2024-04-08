﻿using DVLDBusinessLayer;
using DVLDBusinessLayer.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm.Licenses
{
    public partial class LicensesHistoryForm : Form
    {

        private int PersonID;
        private clsPerson Person = null;
        private int LicenseID ;
        private clsLicense License = null;

        public LicensesHistoryForm(clsLicense License)
        {
            InitializeComponent();

            if(License == null)
                return;

            this.License = License;
            this.LicenseID = License.LicenseID;

            this.Person = License.DriverInfo.PersonInfo;
            this.PersonID = Person.PersonID;

            _SetPersonInformation();
            _SetLocalLicensesList();

        }
        private void _SetPersonInformation()
        {
            if (Person == null)
                return;

            lbPersonID.Text = PersonID.ToString();
            lbName.Text = Person.FullName;
            lbEmail.Text = Person.Email;
            lbAddress.Text = Person.Address;
            lbDateOfBirth.Text = Person.DateOfBirth.ToString();
            lbPhone.Text = Person.Phone;
            lbNationalNo.Text = Person.NationalNo;

            // Change color of label name to red
            lbName.ForeColor = Color.Red;

            // handel Gerder
            _HandelGendor(Person.Gendor);

            // handel Image

            string ImagePath = Global.GlobalVars.Path + Person.ImagePath + Global.GlobalVars.ImgExtintion;
            _HandelImage(ImagePath, Person.Gendor);


            // handel country selected
            _HandleCountry(Person.CountryID);
        }
       
        private void _SetLocalLicensesList()
        {
            dgvLocalLicenses.DataSource = clsLicense.GetAllDriverLicenses(License.DriverInfo.DriverID);
            lbLocslLicenseCount.Text = dgvLocalLicenses.RowCount.ToString();
        }
        private void _HandelImage(string ImagePath, string GendorChar)
        {
            try
            {
                if (ImagePath != "")
                    pbPersonImage.Load(ImagePath);

            }
            catch (Exception Ex)
            {
                if (GendorChar == "M")
                    pbPersonImage.Image = Properties.Resources.Male_512;
                else
                    pbPersonImage.Image = Properties.Resources.Female_512;
            }
        }

        private void _HandelGendor(string GendorChar)
        {
            if (GendorChar == "M" || GendorChar == "M")
            {
                lbGendor.Text = "Male";
                pbManIcon.Visible = true;
                //pbWomanIcon.Visible = false;
            }
            else
            {
                lbGendor.Text = "Female";
                pbManIcon.Visible = false;
                //pbWomanIcon.Visible = true;
            }
        }

        private void _HandleCountry(int CountryID)
        {
            lbCountry.Text = clsCountry.Find(CountryID).CountryName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}