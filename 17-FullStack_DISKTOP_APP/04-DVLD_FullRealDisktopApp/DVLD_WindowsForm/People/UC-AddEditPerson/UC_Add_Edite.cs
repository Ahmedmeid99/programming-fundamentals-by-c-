using System;

using System.Data;
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
        public string Gendor { get; set; }
        public string NationalNo { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryID { get; set; }

        

        // set method properties
        public void SetUIPersonID(int PersonId)
        {
            // check if requird
            if (PersonId <= 0)
                return;

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

            if (cmbCountries.Items.Count > 0)
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
                // on save
                // delete prev img from app folder

                this.ImagePath = imagePath;
                string FullImgPath = Global.GlobalVars.Path + imagePath + Global.GlobalVars.ImgExtintion;

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(FullImgPath))
                    pbPersonImage.ImageLocation = FullImgPath;
                else
                    pbPersonImage.Image = Properties.Resources.Male_512;


            } catch (Exception Ex)
            {
                this.ImagePath = "";
                pbPersonImage.ImageLocation = "";
                
                MessageBox.Show("Error : " + Ex.Message);
            }
        }
        public void SetUIImage(string GendorChar)
        {
            if (GendorChar == "M")
                pbPersonImage.Image = Properties.Resources.Male_512;
            else
                pbPersonImage.Image = Properties.Resources.Female_512;
        }
        public void SetUIDateOfBirth(DateTime dateOfBirth)
        {
            this.DateOfBirth = dateOfBirth;
            dtmDateOfBirth.Value = DateOfBirth;
        }

        public void SetUINationalNo(string NationalNo)
        {
            this.NationalNo = NationalNo;
            txtNationalN.Text = NationalNo;
        }

        public void SetUIGendor(string Gendor)
        {
            switch (Gendor)
            {
                case "M":
                    rdMale.Checked = true;
                    this.Gendor = "Male";
                    break;
                case "m":
                    rdMale.Checked = true;
                    this.Gendor = "Male";
                    break;
                case "F":
                    rdFemale.Checked = true;
                    this.Gendor = "Female";
                    break;
                case "f":
                    rdFemale.Checked = true;
                    this.Gendor = "Female";
                    break;
                default:
                    break;
            }
        }

        public void SetCountryID(int countryID)
        {
            this.CountryID = countryID;
        }
        
        public void SetCountryInCompobox(int selectedIndex)
        {
            if(cmbCountries.Items.Count > 0)
            {
                cmbCountries.Text = "";
                cmbCountries.SelectedIndex = -1;
                cmbCountries.SelectedIndex = selectedIndex;

            }
        } 
        
        public void SetCountryInCompobox(string selectedCountry)
        {
            if (cmbCountries.Items.Count > 0)
            {
                cmbCountries.Text = "";
                cmbCountries.SelectedIndex = -1;
                cmbCountries.SelectedText = selectedCountry;
            }
        }


        //---------------------------------
       
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
            if (pbPersonImage.ImageLocation != "" || pbPersonImage.ImageLocation != null || ImagePath != "")
                return ImagePath;
            else
                return "";
        }

        public DateTime GetUIDateOfBirth()
        {
           return dtmDateOfBirth.Value;
        }

        public string GetUINationalNo()
        {
           return txtNationalN.Text;
        }

        public string GetUIGendor()
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
           return (cmbCountries.Text == "")?"Egypt" : cmbCountries.Text;
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

        private bool _TryDeleteImage(string ImagePath)
        {
            bool IsDeleted = false;
            try
            {
                if (string.IsNullOrEmpty(ImagePath))
                    return IsDeleted;

                File.Delete(ImagePath);
                IsDeleted = true;
            }
            catch (IOException Error)
            {
                IsDeleted = false;
                MessageBox.Show("Error " + Error);
            }
            catch (UnauthorizedAccessException Error)
            {
                IsDeleted = false;
                MessageBox.Show("Error " + Error);
            }

            return IsDeleted;
        }
       
        private void _DeletePrevImage()
        {
            _TryDeleteImage(this.ImagePath);
        }
        
        private void _SaveImage(string OldImgPath)
        {
            

            if (!Directory.Exists(Global.GlobalVars.Path))
                Directory.CreateDirectory(Global.GlobalVars.Path);

            Guid guid =Guid.NewGuid();
            string ImgGuidName = guid.ToString();
            string NewImagePath = Global.GlobalVars.Path + ImgGuidName + Global.GlobalVars.ImgExtintion;

            File.Copy(OldImgPath, NewImagePath);

            pbPersonImage.ImageLocation = NewImagePath;
            ImagePath = ImgGuidName;

        }
        
        private void linkSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            saveFileDialog.InitialDirectory = @"E:\Test\images\";
            saveFileDialog.DefaultExt = Global.GlobalVars.ImgExtintion;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = saveFileDialog.FileName;
                _DeletePrevImage();
                _SaveImage(imagePath);
            }
           
        }

        private void linkRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(_TryDeleteImage(this.ImagePath))
            {
                this.ImagePath = "";
               pbPersonImage.ImageLocation = null;
                linkRemoveImage.Visible = false;
                
            }
            else
                linkRemoveImage.Visible = true;
        }

        // On Form Load
        private void UC_Add_Edite_Load(object sender, EventArgs e)
        {
            dtmDateOfBirth.MaxDate = new DateTime(DateTime.Now.Year - 18, DateTime.Now.Month, DateTime.Now.Day);

            linkRemoveImage.Visible = !string.IsNullOrEmpty(this.ImagePath);
        }

        // --------------------
        // Validate the Form
        // --------------------
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
        private bool _CheckCmbBox(ComboBox cmbBox)
        {
            if (cmbBox.SelectedItem == null)
            {
                txtErrorProvider.SetError(cmbBox, "Enter Value in this Field !!!");
                return false;
            }
            else
                txtErrorProvider.SetError(cmbBox, ""); // remove the error
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
        private bool _CheckEmailIsValid(string EmailText)
        {
            return (EmailText.Contains("@gmail.com"));
        }

        private void CheckIsEmpty(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");
        
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }
       
        // provide insert wrong inputs
        private void CheckTxtField(object sender, KeyPressEventArgs e)
        {
            GlobalMethods.CheckStringField(sender,e);
        }  
       
        private void CheckNumField(object sender, KeyPressEventArgs e)
        {
            GlobalMethods.CheckNumField(sender, e);
        }
       
        private bool IsUniqueNationalNo(TextBox txtBox)
        {
            if(Mode == enMode.Update)
            {
                return (clsPerson.IsExists(txtBox.Text));
            }
            if(clsPerson.IsExists(txtBox.Text))
            {
                txtErrorProvider.SetError(txtBox, "This ( National Number ) is Exists in System ( The Person is Exists )");
                return false;
            }
            else
            {
                txtErrorProvider.SetError(txtBox, "");
                return true;
            }
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
           // bool txt8 = _CheckCmbBox(cmbCountries);
            bool img9 = _CheckPersonImage(pbPersonImage);
            bool IsUnique = IsUniqueNationalNo(txtNationalN);

            // Country Gendor DateOfBirth having default value
            // Email may be null 

            if (txt1 && txt2 && txt3 && txt4 && txt5 && txt6 && txt7  && IsUnique && img9)
                return true;
            else 
                return false;

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
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
