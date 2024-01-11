#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsMainMenueScreen.cpp";
#include "../clsUtility.cpp";
#include "../clsInputValidate.cpp";
#include "./MangeUsersScreens/clsUsersListScreen.cpp";
#include "./MangeUsersScreens/clsAddNewUserScreen.cpp";
#include "./MangeUsersScreens/clsFindUserScreen.cpp";
#include "./MangeUsersScreens/clsDeleteUserScreen.cpp";
#include "./MangeUsersScreens/clsUpdateUserScreen.cpp";

using namespace std;

class clsMangeUsersScreen : protected clsMainScreen
{
private:
    enum enMangeUsersScreen
    {
        ListUsers = 1,
        AddNewUser = 2,
        DeleteUser = 3,
        UpdateUser = 4,
        FindUser = 5,
        MainMenue = 6
    };

    static void _GoBackToMangeUsersMenue()
    {
        cout << setw(37) << left << ""
             << "\n\t press any key to go back to Mange Users menue...\n";
        system("pause>0");
        ShowManageUsersMenue();
    }

    static void _ShowUsersListScreen()
    {
        clsUsersListScreen::ShowListUsers();
    }

    static void _ShowAddUserScreen()
    {
        clsAddNewUserScreen::ShowAddNewUserScreen();
    }

    static void _ShowDeleteUserScreen()
    {
        clsDeleteUserScreen::ShowDeleteUserScreen();
    }

    static void _ShowUpdateUserScreen()
    {
        clsUpdateUserScreen::ShowUpdateUserScreen();
    }

    static void _ShowFindUserScreen()
    {
        clsFindUserScreen::ShowFindUserScreen();
    }

    static void _PerformManageUsersScreen(enMangeUsersScreen ScreenNumber)
    {
        switch (ScreenNumber)
        {
        case enMangeUsersScreen::ListUsers:
            system("cls");
            _ShowUsersListScreen();
            _GoBackToMangeUsersMenue();
            break;
        case enMangeUsersScreen::AddNewUser:
            system("cls");
            _ShowAddUserScreen();
            _GoBackToMangeUsersMenue();
            break;
        case enMangeUsersScreen::DeleteUser:
            system("cls");
            _ShowDeleteUserScreen();
            _GoBackToMangeUsersMenue();
            break;
        case enMangeUsersScreen::UpdateUser:
            system("cls");
            _ShowUpdateUserScreen();
            _GoBackToMangeUsersMenue();
            break;
        case enMangeUsersScreen::FindUser:
            system("cls");
            _ShowFindUserScreen();
            _GoBackToMangeUsersMenue();
            break;
        case enMangeUsersScreen::MainMenue:
            // do nothing
            break;
        default:
            // do nothing
            break;
        }
    }

public:
    static void ShowManageUsersMenue()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pMangeUsers))
        {
            return; // this will exit function and it will not Screen
        }

        cout << "\n\n\t\t==================================================\n";
        cout << "\t\tMange Users Menue Screen\n";
        cout << "\t\t==================================================\n";
        cout << "\t\t[1] List Users. \n";
        cout << "\t\t[2] Add New User. \n";
        cout << "\t\t[3] Delete User. \n";
        cout << "\t\t[4] Update User. \n";
        cout << "\t\t[5] Find User. \n";
        cout << "\t\t[6] Main Menue. \n";
        cout << "\t\t==================================================\n";

        short UserChoose = clsInputValidate::ReadShortNumberBetween(1, 6, "Choose what do you want to do? [1 to 6]? ");
        _PerformManageUsersScreen((enMangeUsersScreen)UserChoose);
    }
};