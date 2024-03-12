using System;

using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using DVLDBusinessLayer;
namespace DVLD_WindowsForm
{
    public partial class UC_Add_Edite : UserControl
    {
        public UC_Add_Edite()
        {
            InitializeComponent();
            CountryID = -1;
            PersonID = -1;  
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        // get set properties
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Gandor { get; set; }
        public string NationalN { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }
       

        // set method properties
        public void SetUIPersonID(int PersonId)
        {
            // check if requird

            this.PersonID = PersonId;
            lbPersonID.Text = PersonID.ToString();
        }

        public void SetUIMode(enMode Mode)
        {
            this.Mode = Mode;
            switch (Mode)
            {
                case enMode.AddNew:
                    lbMode.Text = "Add New Person";
                    break;
                case enMode.Update:
                    lbMode.Text = "Update Person";
                    break;
                default:
                    lbMode.Text = "....";
                    break;
            }
        }

        public void SetCountriesInCompobox(DataTable Countries)
        {
                foreach (DataRow row in Countries.Rows)
                {
                    cmbCountries.Items.Add(row["CountryName"]);
                }
            if(Countries.Rows.Count > 0 )
                cmbCountries.SelectedIndex = 0;
            
        }

        public void SetUIFirstName(string firstName)
        {
            this.FirstName = firstName;
            txtFirstName.Text = FirstName;
        }

        public void SetUISecondName(string secondName)
        {
            this.SecondName = secondName;
            txtSecondName.Text = SecondName;
        }

        public void SetUIThirdName(string thirdName)
        {
            this.ThirdName = thirdName;
            txtThirdName.Text = ThirdName;
        }

        public void SetUILastName(string lastName)
        {
            this.LastName = lastName;
            txtLastName.Text = LastName;
        }

        public void SetUIPhone(string phone)
        {
            this.Phone = phone;
            txtPhone.Text = Phone;
        }

        public void SetUIEmail(string email)
        {
            this.Email = email;
            txtEmail.Text = Email;
        }

        public void SetUIAddress(string address)
        {
            this.Address = address;
            txtAddress.Text = Address;
        }
        public void SetUIImagePath(string imagePath)
        {
            try
            {

                this.ImagePath = imagePath;
                if (ImagePath != "" && ImagePath != null)
                    pbPersonImage.Load(imagePath);
                // pbPersonImage.ImageLocation = ImagePath;
            } catch (Exception Ex)
            {
                this.ImagePath = "";
                pbPersonImage.ImageLocation = "";
                MessageBox.Show("Error : " + Ex.Message);
            }
        }

        public void SetUIDateOfBirth(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            dtmDateOfBirth.Value = DateOfBirth;
        }

        public void SetUINationalN(string nationalN)
        {
            this.NationalN = nationalN;
            txtNationalN.Text = NationalN;
        }

        public void SetUIGandor(string gandor)
        {
            switch (gandor)
            {
                case "M":
                    rdMale.Checked = true;
                    this.Gandor = "Male";
                    break;
                case "m":
                    rdMale.Checked = true;
                    this.Gandor = "Male";
                    break;
                case "F":
                    rdFemale.Checked = true;
                    this.Gandor = "Female";
                    break;
                case "f":
                    rdFemale.Checked = true;
                    this.Gandor = "Female";
                    break;
                default:
                    break;
            }
        }

        public void SetCountryID(int countryID)
        {
            this.CountryID = countryID;
        }
        public void SetUICountryID(string countryName)
        {
            if (cmbCountries.Items.Count > 0)
            {
                int countryID = cmbCountries.FindString(countryName);
                  
                cmbCountries.SelectedIndex = countryID;
            }
        }

        public void SetCountryInCompobox(int selectedIndex)
        {
                cmbCountries.SelectedIndex = selectedIndex;
        } 
        public void SetCountryInCompobox(string selectedCountry)
        {
                cmbCountries.SelectedText = selectedCountry;
        }


        // get Mothods properties
        public int GetPersonID()
        {
            return this.PersonID;
            
        }

        public enMode GetMode()
        {
            return this.Mode;
            
        }
        
        public string GetUIFirstName()
        {
            return txtFirstName.Text;
        }

        public string GetUISecondName()
        {
           return  txtSecondName.Text ;
        }

        public string GetUIThirdName()
        {
           return txtThirdName.Text;
        }

        public string GetUILastName()
        {
            return txtLastName.Text;
        }

        public string GetUIPhone()
        {
            return txtPhone.Text;
        }

        public string GetUIEmail()
        {
            return txtEmail.Text;
        }

        public string GetUIAddress()
        {
            return txtAddress.Text;
        }
     
        public string GetUIImagePath()
        {
            if (pbPersonImage.ImageLocation != "" || pbPersonImage.ImageLocation != null)
                return pbPersonImage.ImageLocation;
            else
                return "";
        }

        public DateTime GetUIDateOfBirth()
        {
           return dtmDateOfBirth.Value;
        }

        public string GetUINationalN()
        {
           return txtNationalN.Text;
        }

        public string GetUIGandor()
        {
            if(rdMale.Checked)
            {
                return "M";
            }
            else if(rdFemale.Checked)
            {
                return "F";
            }

            return "M";; // as a default
        }

        public string GetUICountryName( )
        {
           return cmbCountries.Text;
        }

        private void rdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(pbPersonImage.ImageLocation == "" || pbPersonImage.ImageLocation == null)
                pbPersonImage.Image = Properties.Resources.Female_512;
        }

        private void rdMale_CheckedChanged(object sender, EventArgs e)
        {
            if (pbPersonImage.ImageLocation == "" || pbPersonImage.ImageLocation == null)  
                pbPersonImage.Image = Properties.Resources.Male_512;
           

        }

        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            saveFileDialog.InitialDirectory = @"E:\Test\images\";
            saveFileDialog.DefaultExt = ".png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImagePath = saveFileDialog.FileName;
                pbPersonImage.ImageLocation = ImagePath;
            }
           
        }

        // btn to remove image...

        private void UC_Add_Edite_Load(object sender, EventArgs e)
        {
            dtmDateOfBirth.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);

            // select Country Name
            if(cmbCountries.SelectedText != "")
                cmbCountries.SelectedText = clsCountry.Find(CountryID).CountryName;
        }

        private bool _CheckTextBox(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");
                return false;
            }
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
            return true;
        }

        private bool _CheckPersonImage(PictureBox PersonImage)
        {
            if(string.IsNullOrEmpty(PersonImage.ImageLocation))
            {
                txtErrorProvider.SetError(PersonImage, "Set image to this Person !!!");
                return false;
            }

            txtErrorProvider.SetError(PersonImage, "");
            return true;

        }
        public bool CheckFormIsValid()
        {
            bool txt1 = _CheckTextBox(txtFirstName);
            bool txt2 = _CheckTextBox(txtSecondName);
            bool txt3 = _CheckTextBox(txtThirdName);
            bool txt4 = _CheckTextBox(txtLastName);
            bool txt5 = _CheckTextBox(txtPhone);
            bool txt6 = _CheckTextBox(txtNationalN);
            bool txt7 = _CheckTextBox(txtAddress);
            bool img8 = _CheckPersonImage(pbPersonImage);

            // Country Gander DateOfBirth having default value
            // Email may be null 

            if (txt1 && txt2 && txt3 && txt4 && txt5 && txt6 && txt7 && img8)
                return true;
            else 
                return false;

        }

        private void _CheckNotEmpty(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");
            
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }
        

        private bool _CheckIsDigit(KeyPressEventArgs e)
        {
            if (!(e is KeyPressEventArgs KeyPressEventArgs))
                return false;

            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '(' &&
                e.KeyChar != ')' &&
                e.KeyChar != '{' &&
                e.KeyChar != '}' &&
                e.KeyChar != '-' &&
                e.KeyChar != ' '
                )
            {
                return false;
            }
                return true;
        }

        private void _CheckStringField(object sender, KeyPressEventArgs e)
        {
            if (_CheckIsDigit(e))
                e.Handled = true; // ignore the input char;

        }  
        private void _CheckNumField(object sender, KeyPressEventArgs e)
        {
            if (!_CheckIsDigit(e))
                e.Handled = true; // ignore the input char;

        }
       

        private bool _CheckEmailIsValid(string EmailText)
        {
            return (EmailText.Contains("@gmail.com"));
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (string.IsNullOrEmpty(textBox.Text))
                txtErrorProvider.SetError(textBox, ""); // remove the error
            else
            {

                // check Email is valid or not
                if (!_CheckEmailIsValid(textBox.Text))
                    txtErrorProvider.SetError(textBox, "Enter valid Email must have (@gmail.com)");
                else
                    txtErrorProvider.SetError(textBox, "");
            }
        }
    }


}
