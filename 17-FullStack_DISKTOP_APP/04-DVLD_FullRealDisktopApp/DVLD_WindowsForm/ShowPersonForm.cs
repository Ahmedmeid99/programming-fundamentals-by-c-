using System;

using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class ShowPersonForm : Form
    {
        private void _HandelImage(string ImagePath,string GandorChar)
        {
            try
            {
                if(ImagePath != "")
                    pbPersonImage.Load(ImagePath);

            }catch(Exception Ex)
            {
                if (GandorChar == "M")
                    pbPersonImage.Image = Properties.Resources.Male_512;
                else
                    pbPersonImage.Image = Properties.Resources.Female_512;
            }
        }
        private void _HandelGendor(string GandorChar)
        {
            if (GandorChar == "M" || GandorChar == "M")
            {
                lbGandor.Text = "Male";
                pbManIcon.Visible = true; 
                pbWomanIcon.Visible = false;
            }
            else
            {
                lbGandor.Text = "Female";
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

            clsPersonBusiness Person = clsPersonBusiness.Find(PersonID);

            if (Person == null)
                return;

            lbPersonID.Text = PersonID.ToString();
            lbFirstName.Text = Person.FirstName;
            lbLastName.Text = Person.LastName;
            lbThirdName.Text = Person.ThirdName;
            lbSecondName.Text = Person.SecondName;
            lbEmail.Text = Person.Email;
            lbAddress.Text = Person.Address;
            lbDateOfBirth.Text = Person.DateOfBirth.ToString();
            lbPhone.Text = Person.Phone;
            lbNationalN.Text = Person.NationalID;

            // handel Gerder
            _HandelGendor(Person.Gander);

            // handel Image
            string _Path = @"C:\DVLD_People_Images\";
            string ImgExtintion = ".png";
            string ImagePath = _Path + Person.ImagePath + ImgExtintion;
            _HandelImage(ImagePath, Person.Gander);


            // handel country selected
            _HandleCountry(Person.CountryID);

        }

        private void ShowPersonForm_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
