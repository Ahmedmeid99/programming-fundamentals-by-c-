#pragma once

#include <iostream>
#include <iomanip>
#include "../../clsMainScreen.cpp";
#include "../../clsUtility.cpp";
#include "../../clsUser.cpp";

using namespace std;

class clsUsersListScreen : protected clsMainScreen
{
private:
    static void _UsersInfoHeader()
    {
        cout << endl;
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
        cout << "\t\t | First N.";
        cout << " | Last N. ";
        cout << " | Email.             ";
        cout << " | Phone" << clsUtility::Space(1);
        cout << " | UserName" << clsUtility::Space(1);
        cout << " | Password" << clsUtility::Space(1);
        cout << " | Permissions" << clsUtility::Space(1);
        cout << endl;
        cout << "\t\t-------------------------------------------------------------------------------------------------------\n";
    }

    static void _PrintUserInfo(clsUser User)
    {
        string DePassord = clsUtility::DecryptEnPassWard(User.Password(), KEY);

        cout << "\t\t | " << User.FirstName() << "  ";
        cout << " | " << User.LastName() << "     ";
        cout << " | " << User.Email() << "   ";
        cout << " | " << User.Phone() << clsUtility::Space(1);
        cout << " | " << User.UserName() << clsUtility::Space(1);
        // cout << " | " << User.Password() << clsUtility::Space(2);
        cout << " | " << DePassord << clsUtility::Space(2);
        cout << " | " << User.Permissions() << endl;
    }

public:
    static void ShowListUsers()
    {
        vector<clsUser> vUsers;
        vUsers = clsUser::GetUsers();
        string Title = "\t Users List Screen";
        string SubTitle = "\t    (" + to_string(vUsers.size()) + ")Clint";
        _DrawMainScreenHeader(Title, SubTitle);
        _UsersInfoHeader();
        if (vUsers.size() == 0)
        {
            cout << "\t\t\t No Users in System\n";
            return;
        }
        for (clsUser User : vUsers)
        {
            _PrintUserInfo(User);
        }
        cout << "\t\t-------------------------------------------------------------------------------------------------------\n";
        cout << endl;
    }
};