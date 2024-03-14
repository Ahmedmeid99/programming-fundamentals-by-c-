using System;
using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace DVLD_WindowsForm
{
    public partial class AddEditPersonForm : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _PersonID;
        private clsPersonBusiness _Person;
       
        
        public AddEditPersonForm(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;

            if (_PersonID == -1)
            {
                // Create Person 
                _Person = new clsPersonBusiness();

                // in Add new Mode
                UC_Add_Edit.SetUIMode(UC_Add_Edite.enMode.AddNew);
                

                // when save data will use AddNewMethod in BusinessLayer
                Mode = enMode.AddNew;

                return;
            }

            // else in Update Mode
            _FillControlsWithData( _PersonID);

            // handle Header
            UC_Add_Edit.SetUIMode(UC_Add_Edite.enMode.Update);
            UC_Add_Edit.SetUIPersonID(_PersonID);

            // when save data will use UpdateMethod in BusinessLayer
            Mode = enMode.Update;


        }

        private void _FillCountriesInCompobox()
        {
            // save coountries from database in datatable
            DataTable dataTable = clsCountry.GetAllCountries();

            // loop on compobox to insert in it countryName
            UC_Add_Edit.SetCountriesInCompobox(dataTable);


        }
        private void _FillControlsWithData( int PersonID)
        {
            _Person = clsPersonBusiness.Find(PersonID);

            if (_Person == null)
            {
                UC_Add_Edit.SetCountryID(0);
                return;
            }

            PersonID = _Person.PersonID;
            UC_Add_Edit.SetUIPersonID(_PersonID);
            UC_Add_Edit.SetUIFirstName(_Person.FirstName);
            UC_Add_Edit.SetUISecondName(_Person.SecondName);
            UC_Add_Edit.SetUIThirdName(_Person.ThirdName);
            UC_Add_Edit.SetUILastName(_Person.LastName);

            UC_Add_Edit.SetUIEmail(_Person.Email);
            UC_Add_Edit.SetUIPhone(_Person.Phone);
            UC_Add_Edit.SetUIAddress(_Person.Address);
            UC_Add_Edit.SetUINationalN(_Person.NationalID);
            UC_Add_Edit.SetUIDateOfBirth(_Person.DateOfBirth);
            UC_Add_Edit.SetUIImagePath(_Person.ImagePath);

            // handel Gerder
            UC_Add_Edit.SetUIGandor(_Person.Gander);


            // handel country selected
            // on AddEditPersonForm Load
            UC_Add_Edit.SetCountryID(_Person.CountryID);

        }

        private bool _CheckIsDigit(KeyPressEventArgs e)
        {
            if (!(e is KeyPressEventArgs KeyPressEventArgs))
                return false;

            if (!char.IsDigit(e.KeyChar) &&
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
        private void _FillPersonWithData( clsPersonBusiness _Person)
        {
            clsCountry countryobj = clsCountry.Find(UC_Add_Edit.GetUICountryName());

            if (countryobj != null)
                _Person.CountryID = countryobj.CountryID;
            else
                _Person.CountryID = 1;

            // in Update Mode
            if (UC_Add_Edit.GetPersonID() != -1 && UC_Add_Edit.GetPersonID() != 0)
            {
                 _Person.PersonID = UC_Add_Edit.GetPersonID();   // error her !?
                 _PersonID = _Person.PersonID;
            }
            

            _Person.FirstName = UC_Add_Edit.GetUIFirstName();
            _Person.SecondName = UC_Add_Edit.GetUISecondName();
            _Person.ThirdName = UC_Add_Edit.GetUIThirdName();
            _Person.LastName = UC_Add_Edit.GetUILastName();

            _Person.Email = UC_Add_Edit.GetUIEmail();
            _Person.Phone = UC_Add_Edit.GetUIPhone();
            _Person.Address = UC_Add_Edit.GetUIAddress();
            _Person.NationalID = UC_Add_Edit.GetUINationalN();
            _Person.DateOfBirth = UC_Add_Edit.GetUIDateOfBirth();

            _Person.ImagePath = UC_Add_Edit.GetUIImagePath();
            _Person.Gander = UC_Add_Edit.GetUIGandor();


        }

        private void _Save()
        {
            // create person 
            // -- by default Constractor
            // -- by Private Constractor => Find


            _FillPersonWithData( _Person);

            // Check form is Valid if it is not valid go back  
            if (!UC_Add_Edit.CheckFormIsValid())
                return;

            if (_Person.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                if(_PersonID <= 0)
                {
                    _PersonID = clsPersonBusiness.Find(_Person.NationalID).PersonID;
                    UC_Add_Edit.SetUIPersonID(_PersonID);
                }
            }
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

            // handle Header
            UC_Add_Edit.SetUIMode(UC_Add_Edite.enMode.Update);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            _Save(); 
        }

        private void SetPersonCountryInCompoBox(int CountryID)
        {
            
            clsCountry country1 = clsCountry.Find(CountryID);
            if (country1 != null)
            {
                // Set Cmb Country name
                string countryName = country1.CountryName;
                UC_Add_Edit.SetCountryInCompobox(countryName);

            }
        }
        private void AddEditPersonForm_Load(object sender, EventArgs e)
        {

            UC_Add_Edit.SetUIGandor("M");
          
            _FillCountriesInCompobox();

            if (_Person != null)
            { 
                // delete prev selected item
                SetPersonCountryInCompoBox(_Person.CountryID);
                UC_Add_Edit.SetUIPersonID(_PersonID);
            }
            

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
