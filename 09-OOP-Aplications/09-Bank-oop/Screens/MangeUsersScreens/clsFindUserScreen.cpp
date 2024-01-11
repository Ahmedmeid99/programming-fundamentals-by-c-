#pragma once

#include <iostream>
#include <iomanip>
#include "../../clsMainScreen.cpp";
#include "../../clsUser.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsFindUserScreen : protected clsMainScreen
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
    static void ShowFindUserScreen()
    {
        _DrawMainScreenHeader("\tFind User Screen");

        string UserName = clsInputValidate::ReadString("Enter Your Acount Number? ");

        while (!clsUser::IsUserExist(UserName))
        {
            UserName = clsInputValidate::ReadString("This Acount Number is Not Exist, try again? ");
        }

        clsUser BankUser_1 = clsUser::Find(UserName);

        _Print(BankUser_1);
    }
};