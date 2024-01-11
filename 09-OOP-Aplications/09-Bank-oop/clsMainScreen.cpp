#pragma once

#include <iostream>
#include "clsUser.cpp";
#include "Global.cpp";
#include "./clasDate.cpp";
// #include "clsTime.cpp";
using namespace std;

class clsMainScreen
{

protected:
    static void _DrawMainScreenHeader(string Title, string SubTitle = "")
    {
        cout << "\t\t\t\t\t_________________________________\n";
        cout << "\n\t\t\t\t\t" << Title;
        if (SubTitle != "")
        {
            cout << "\n\t\t\t\t\t" << SubTitle;
        }
        cout << "\n\t\t\t\t\t_________________________________\n";
        // Date Time
        cout << "\n\t\t\t\t\t User: " << CurrentUser.UserName() << endl;
        cout << "\t\t\t\t\t Date: " << clasDate::FormateDate(clasDate(), "/") << "\n\n";
    }
    // Main Screen must have CheckAccessRights for all inherits screens
    static bool CheckAccessRights(clsUser::enPermissions Permissions) // User _Permission ex: -1
    {
        if (!CurrentUser.CheckAccessPermission(Permissions))
        {
            cout << "\n\t\t\t\t\t_________________________________\n";
            cout << "\n\t\t\t\t\t  Access Denied ! contact your Account \n";
            cout << "\n\t\t\t\t\t_________________________________\n";
            return false;
        }
        else
        {
            return true;
        }
    }
};