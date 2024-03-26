using System;

using DVLDBusinessLayer;
using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public static class GlobalMethods
    {
        public static clsUser CurrentUser { get; set; }

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
