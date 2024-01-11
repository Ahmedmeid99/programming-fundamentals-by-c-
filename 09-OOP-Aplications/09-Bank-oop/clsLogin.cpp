#pragma once

#include <iostream>
#include <iomanip>
#include "clsUser.cpp";
#include "Global.cpp";
#include "clsMainScreen.cpp";
#include "./clsMainMenueScreen.cpp";
#include "clsInputValidate.cpp";
using namespace std;

class clsLogin : protected clsMainScreen
{

private:
    static bool _Login()
    {
        bool LoginFalid = false;
        short Counter = 3;
        string UserName, Password;
        do
        {
            if (LoginFalid)
            {
                Counter--;
                cout << "Invalid username/password.\n";
                cout << "\nYou have " << Counter << " to try\n";
            }
            UserName = clsInputValidate::ReadString("\nEnter UserName: ");
            Password = clsInputValidate::ReadString("\nEnter Password: ");
            // EncryptEn PassWard  to GER-safa7sd
            string EnPassword = clsUtility::EncryptEnPassWard(Password, KEY);
            cout << EnPassword << endl;
            CurrentUser = clsUser::Find(UserName, EnPassword);
            LoginFalid = CurrentUser.IsEmpty();

            if (Counter == 1)
            {
                cout << "\nYou falid 3 times \n";
                return false;
            }

        } while (LoginFalid);

        // Register Login CurrentUser
        CurrentUser.RegisterLogin();

        clsMainMenueScreen::ShowMainMenueScreen();

        return true;
    }

public:
    static bool ShowLoginScreen()
    {
        system("cls");
        _DrawMainScreenHeader("\t Login Screen");
        return _Login();
    }
};
