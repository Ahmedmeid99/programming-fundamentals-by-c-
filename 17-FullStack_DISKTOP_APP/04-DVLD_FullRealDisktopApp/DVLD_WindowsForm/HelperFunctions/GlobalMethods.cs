using DVLDBusinessLayer;
using System;

using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public static class GlobalMethods
    {

        public static string GetIssueReason(byte AppTypeID)
        {
            switch (AppTypeID)
            {
                case (byte)GlobalEnums.enApplicationType.NewDrivingLicense:
                    return "First Time";  
                case (byte)GlobalEnums.enApplicationType.ReNewDrivingLicense:
                    return "ReNew"; 
                case (byte)GlobalEnums.enApplicationType.NewInternationalLicense:
                    return "First Time";       
                case (byte)GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense:
                    return "Replacement for Damage";       
                case (byte)GlobalEnums.enApplicationType.ReplaceLostDrivingLicense:
                    return "Replacement for Lost";
                case (byte)GlobalEnums.enApplicationType.ReTakeTest:
                    return "ReTake Test";
                default:
                    break;
            }
            return "";

        }



        //----------------------------
        //----[Vlidation Methods]-----
        //----------------------------
        public static bool CheckTxtBoxIsEmpty(TextBox textBox)
        {
            if (string.IsNullOrEmpty(textBox.Text))
                return true;
            else
                return false;

        }
        
        public static bool CheckIsDigit(KeyPressEventArgs e)
        {
            if (!(e is KeyPressEventArgs KeyPressEventArgs))
                return false;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return true;
            }
            return false;
        }

        public static bool CheckIsChar(KeyPressEventArgs e)
        {
            if (!(e is KeyPressEventArgs KeyPressEventArgs))
                return false;

            if (!char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                return true;
            }
            return false;
        }

        public static void CheckStringField(object sender, KeyPressEventArgs e)
        {
            if (!CheckIsChar(e))
                e.Handled = true; // ignore the input char;

        }

        public static void CheckNumField(object sender, KeyPressEventArgs e)
        {
            if (!CheckIsDigit(e))
                e.Handled = true; // ignore the input char;

        }






    }
}
