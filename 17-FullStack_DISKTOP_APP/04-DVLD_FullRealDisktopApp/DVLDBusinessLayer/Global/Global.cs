using System;


namespace DVLDBusinessLayer
{
    public static class Global
    {
        public static string Path = @"C:\DVLD_People_Images\";
        public static string ImgExtintion = ".png";

        public enum enApplicationStatus : byte
        {
            NewApplication = 1,
            CancledApplication = 2
        }

        public enum enApplicationType : byte
        {
            NewLocalApp = 1
        }

    }
}
