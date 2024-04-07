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
        public enum enUserStatus : byte     // for just test
        {
            NotActive = 0,
            Active = 1 
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

        public enum enApplicationType : byte
        {
            NewLocalApp = 1 ,
            ReTakeTest= 6
        } 
        
        public enum enTestResult : byte
        {
            Faild = 0,
            Passed = 1
        }

    }
}
