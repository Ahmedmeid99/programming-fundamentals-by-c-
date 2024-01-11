#pragma once

#include <iostream>
#include <iomanip>
#include "../clsUser.cpp";
#include "../clsBankClient.cpp";
#include "../clsUtility.cpp";

using namespace std;

class clsLoginRegisterScreen : protected clsMainScreen
{
private:
    static void _LoginRegisterInfoHeader()
    {
        cout << endl;
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
        cout << "\t\t | Date - time " << clsUtility::Space(2);
        cout << " | UserName" << clsUtility::Space(1);
        cout << " | Password" << clsUtility::Space(1);
        cout << " | Permessions" << clsUtility::Space(1);
        cout << endl;
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
    }

    static void _PrintLoginRegisterInfo(clsUser::stLoginRegister UserLogin)
    {
        cout << "\t\t | " << UserLogin._Date_Time << clsUtility::Space(1);
        cout << " | " << UserLogin._UserName << clsUtility::Space(1);
        cout << " | " << UserLogin._Password << clsUtility::Space(2);
        cout << " | " << UserLogin._Permissions << endl;
    }

public:
    static void ShowListOfLoginRegister()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pLoginRegister))
        {
            return; // this will exit function and it will not Screen
        }

        vector<clsUser::stLoginRegister> vUsersLogin;
        vUsersLogin = clsUser::GetUsersLogin();
        string Title = "\t Users Login List Screen";
        string SubTitle = "\t    (" + to_string(vUsersLogin.size()) + ")User Login";
        _DrawMainScreenHeader(Title, SubTitle);
        _LoginRegisterInfoHeader();
        if (vUsersLogin.size() == 0)
        {
            cout << "\t\t\t No Clints in System\n";
            return;
        }
        for (clsUser::stLoginRegister UserLogin : vUsersLogin)
        {
            _PrintLoginRegisterInfo(UserLogin);
        }
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
        cout << endl;
    }
};