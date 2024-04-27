using System;


namespace DVLDBusinessLayer
{
    public static class GlobalEnums
    {
        public enum enApplicationStatus : byte
        {
            NewApplication = 1,
            CancledApplication = 2 ,
            CompletedApplication = 3 
        } 
        public enum enUserPermission : int     // for just test
        {
            AllPermission   = -1,
            AddEditUsers    =  2,
            DeleteUsers     =  4,
            EditTestTypes   =  16,
            ManageDrivers   =  32,
            EditApplicationTypes = 8,
            ManageDetainedLicenses  = 64
        }   
        public enum enApplicationPassedTests : byte
        {
            NoTestsPassed = 0,
            PassedVissionTest = 1,
            PassedWrittenTest = 2 ,
            PassedStreetTest = 3 
        } 
        public enum enTestType : byte
        {
            VissionTest = 1,
            WrittenTest = 2 ,
            StreetTest = 3 
        }

        public enum enApplicationType : byte   // issuereson
        {
            NewDrivingLicense = 1 ,
            ReNewDrivingLicense = 2 ,
            ReplaceLostDrivingLicense = 3,
            ReplaceDamagedDrivingLicense = 4,
            ReleaseDetainedLicense = 5 ,
            NewInternationalLicense = 6 ,
            ReTakeTest= 7
        } 
        
        public enum enTestResult : byte
        {
            Faild = 0,
            Passed = 1
        }  
        
        public enum enLicenseClasses : byte
        {
            Class_1_SmallMotorcycle = 1,
            Class_2_HeavyMotorcycleLicense = 2,
            Class_3_OrdinaryDivingLicense  = 3,
            Class_4_Commerical   = 4,
            Class_5_Agricultural  = 5,
            Class_6_SmallandMediumbus  = 6,
            Class_7_TruckandHeavyVehicle = 7
        }

    }
}
