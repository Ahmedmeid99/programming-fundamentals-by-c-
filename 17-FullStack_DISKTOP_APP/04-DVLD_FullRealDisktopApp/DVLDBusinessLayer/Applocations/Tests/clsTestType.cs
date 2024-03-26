using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsTestType
    {
        public enum enMode { Update = 1 };
        public enMode Mode = enMode.Update;

        public int TestTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Fees { get; set; }



        // Default Constractor for AddNew Mode 
        public clsTestType(int TestTypeID, string Title, string Description, double Fees)
        {

            this.TestTypeID = TestTypeID;
            this.Title = Title;
            this.Description = Description;
            this.Fees = Fees;

            Mode = enMode.Update;

        }

        // Private Constractor for Update Mode 

        private bool _UpdateTestType()
        {
            // add this object to database
            return TestTypeDataAccess.UpdateTestType(TestTypeID, Title, Description, Fees);
        }
        // find by ID , NationalNo
        public static clsTestType Find(int TestTypeID)
        {
            string Description = "", Title = "";

            double Fees = -1;

            if (TestTypeDataAccess.GetTestTypeID(TestTypeID, ref Title, ref Description, ref Fees))
            {
                return new clsTestType(TestTypeID, Title, Description, Fees);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Update:

                    return this._UpdateTestType();

            }

            return false;
        }

        public static DataTable GetAllTestTypes()
        {
            return TestTypeDataAccess.GetAllTestTypes();
        }

    }
}
