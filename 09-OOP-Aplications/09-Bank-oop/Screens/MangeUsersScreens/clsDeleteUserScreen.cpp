#pragma once

#include <iostream>
#include <iomanip>
#include "../../clsMainScreen.cpp";
#include "../../clsUser.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsDeleteUserScreen : protected clsMainScreen
{
private:
    static void _Print(clsUser User)
    {
        cout << "User Card\n\n";
        cout << "\t\t\t__________________________________\n";
        cout << "\t\t\tFirstName  : " << User.FirstName() << endl;
        cout << "\t\t\tLastName   : " << User.LastName() << endl;
        cout << "\t\t\tFullName   : " << User.FullName() << endl;
        cout << "\t\t\tEmail      : " << User.Email() << endl;
        cout << "\t\t\tPhone      : " << User.Phone() << endl;
        cout << "\t\t\tUserName   : " << User.UserName() << endl;
        cout << "\t\t\tPassword   : " << User.Password() << endl;
        cout << "\t\t\tPermissions: " << User.Permissions() << endl;
        cout << "\n\t\t\t__________________________________\n";
    }

public:
    static void ShowDeleteUserScreen()
    {
        _DrawMainScreenHeader("\tDelete User Screen");

        string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

        while (!clsUser::IsUserExist(AccountNumber))
        {
            AccountNumber = clsInputValidate::ReadString("This Acount Number is Not Exist, try again? ");
        }

        // Get User and set update mode
        clsUser User = clsUser::Find(AccountNumber);

        // Print User
        _Print(User);

        clsUser::enSaveResults SaveResults;
        char Anwser = clsInputValidate::ReadChar("Do you want to delete this account Y/N? ");
        if (Anwser == 'Y' || Anwser == 'y')
        {
            // delete and return state
            if (User.Delete())
            {
                _Print(User);
                cout << "deleted Scuessfully" << endl;
            }
            else
            {
                cout << "Error User was not deleted?\n";
            }
        }
    }
};