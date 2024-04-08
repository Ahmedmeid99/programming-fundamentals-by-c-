using System;
using System.Drawing;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class ShowPersonForm : Form
    {
       private int PersonID ;
       private clsPerson Person = null;
        private void _HandelImage(string ImagePath,string GendorChar)
        {
            try
            {
                if(ImagePath != "")
                    pbPersonImage.Load(ImagePath);

            }catch(Exception Ex)
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
                pbWomanIcon.Visible = false;
            }
            else
            {
                lbGendor.Text = "Female";
                pbManIcon.Visible = false;
                pbWomanIcon.Visible = true;
            }
        }
        
        private void _HandleCountry(int CountryID)
        {
             lbCountry.Text =clsCountry.Find(CountryID).CountryName; 
        }
        
        public ShowPersonForm(int PersonID)
        {
            InitializeComponent();

            Person = clsPerson.Find(PersonID);
            this.PersonID = PersonID;

            _RefreshPersonInformation();

        }
        private void _RefreshPersonInformation()
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
        // On Form Load
        private void ShowPersonForm_Load(object sender, EventArgs e)
        {            
        }

       

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(Person.PersonID);
            frmAdd_Update.PersonAdded += People_PersonAdded;
            frmAdd_Update.Show();
        }
        private void People_PersonAdded(object sender, EventArgs e)
        {
            _RefreshPersonInformation();
        }

       
    }
}
