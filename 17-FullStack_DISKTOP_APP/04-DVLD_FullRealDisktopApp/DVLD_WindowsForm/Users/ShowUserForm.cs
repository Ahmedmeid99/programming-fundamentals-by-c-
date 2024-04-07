using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class ShowUserForm : Form
    {
        private int _UserID;
        private int _PersonID;
        private clsUser _User;
        private clsPerson _Person;

        public ShowUserForm(int UserID)
        {
            InitializeComponent();

            if (UserID <= 0)
                return;

            this._UserID = UserID;

            _FillControlsWithData();
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
            lbCountry.Text = clsCountry.Find(CountryID).CountryName;
        }


        private void _FillPersonControls(clsPerson Person)
        {
            if (Person == null)
                return;

            lbPersonID.Text = _PersonID.ToString();
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

        private void _FillUserControls(clsUser User)
        {
            lbUserID.Text = User.UserID.ToString();
            lbUserName.Text = User.UserName;
            lbIsActive.Text = (User.Active == true) ? "Yes" : "No";
        }

        private void _FillControlsWithData()
        {
            //--------------------------------
            // if use edit button
            //-------------------------------- 

            //--------------------------------
            // if use filter
            // person = PersonDataView[0] 
            //--------------------------------
            // this will work onle in Update mode
            _User = clsUser.Find(_UserID);

            // Fill ather data if you need
            _PersonID = _User.PersonID;
            _Person = clsPerson.Find(_PersonID);

            _FillPersonControls(_Person);
            _FillUserControls(_User);


        }

        private void ShowUserForm_Load(object sender, EventArgs e)
        {
           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(_PersonID);
            frmAdd_Update.PersonAdded += People_PersonAdded;
            frmAdd_Update.Show();
        }

        private void FrmAdd_Update_PersonAdded(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void People_PersonAdded(object sender, EventArgs e)
        {
            _FillControlsWithData();
        }
    }
}
