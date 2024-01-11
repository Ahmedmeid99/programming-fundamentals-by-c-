#pragma once

#include <iostream>
#include <iomanip>
#include "clsLogin.cpp";
#include "Global.cpp";
#include "clsMainScreen.cpp";
#include "clsInputValidate.cpp";
#include "Screens/clsClintListScreen.cpp";
#include "Screens/clsAddNewClientScreen.cpp";
#include "Screens/clsDeleteClientScreen.cpp";
#include "Screens/clsUpdateClientScreen.cpp";
#include "Screens/clsFindClientScreen.cpp";
#include "Screens/clsTransactionsScreen.cpp";
#include "Screens/clsMangeUsersScreen.cpp";
#include "Screens/clsLoginRegisterScreen.cpp";
using namespace std;

class clsMainMenueScreen : protected clsMainScreen
{
private:
     enum enMainScreen
     {
          ShowClients = 1,
          AddClient = 2,
          DeleteClient = 3,
          UpdateClient = 4,
          FindClient = 5,
          Transactions = 6,
          ManageUsers = 7,
          LoginRegister = 8,
          Logout = 9
     };

     static void _GoBackToMainMenue()
     {
          cout << setw(37) << left << ""
               << "\n\t press any key to go back to main menue...\n";
          system("pause>0");
          ShowMainMenueScreen();
     }

     static short _ReadMainMenueOption()
     {
          // take input number
          cout << setw(37) << left << "";
          short choice = clsInputValidate::ReadShortNumberBetween(1, 9, "Choose what do you want to do [1 to 8] ?");
          return choice;
     }

     static void _ShowAllClientsScreen()
     {
          clsClintListScreen::ShowListClients();
     }

     static void _ShowAddNewClientScreen()
     {
          clsAddNewClientScreen::ShowAddNewClientScreen();
     }

     static void _ShowDeleteClientScreen()
     {
          clsDeleteClientScreen::ShowDeleteClientScreen();
     }

     static void _ShowUpdateClientScreen()
     {
          clsUpdateClientScreen::ShowUpdateClientScreen();
     }

     static void _ShowFindClientScreen()
     {
          clsFindClientScreen::ShowFindClientScreen();
     }

     static void _ShowTransactionsMenue()
     {
          clsTransactionsScreen::ShowTransactionMenue();
     }

     static void _ShowMangeUsersMenue()
     {
          clsMangeUsersScreen::ShowManageUsersMenue();
     }

     static void _ShowLoginRegisterMenue()
     {
          clsLoginRegisterScreen::ShowListOfLoginRegister();
     }

     static void _Logout()
     {
          CurrentUser = clsUser::Find("", ""); // EMPTY USER
          // do no thing to go back to Log in
          // clsLogin::ShowLoginScreen();
     }

     static void _PerformMainMenueOption(enMainScreen MainMenueOpthion)
     {
          switch (MainMenueOpthion)
          {
          case enMainScreen::ShowClients:
               system("cls");
               _ShowAllClientsScreen();
               _GoBackToMainMenue();
               break;
          case enMainScreen::AddClient:
               system("cls");
               _ShowAddNewClientScreen();
               _GoBackToMainMenue();
               break;
          case enMainScreen::DeleteClient:
               system("cls");
               _ShowDeleteClientScreen();
               _GoBackToMainMenue();
               break;
          case enMainScreen::UpdateClient:
               system("cls");
               _ShowUpdateClientScreen();
               _GoBackToMainMenue();
               break;
          case enMainScreen::FindClient:
               system("cls");
               _ShowFindClientScreen();
               _GoBackToMainMenue();
               break;
          case enMainScreen::Transactions:
               system("cls");
               _ShowTransactionsMenue();
               _GoBackToMainMenue();
               break;
          case enMainScreen::ManageUsers:
               system("cls");
               _ShowMangeUsersMenue();
               _GoBackToMainMenue();
               break;
          case enMainScreen::LoginRegister:
               system("cls");
               _ShowLoginRegisterMenue();
               _GoBackToMainMenue();
               break;
          case enMainScreen::Logout:
               system("cls");
               _Logout();
               break;
          }
     }

public:
     static void ShowMainMenueScreen()
     {
          system("cls");
          _DrawMainScreenHeader("\t\tMain Screen");

          cout << setw(37) << left << ""
               << "=======================================\n";
          cout << setw(37) << left << ""
               << "\t\t Main Menu\n";
          cout << setw(37) << left << ""
               << "=======================================\n";
          cout << setw(37) << left << ""
               << "\t[1] Show Client List\n";
          cout << setw(37) << left << ""
               << "\t[2] Add New Client\n";
          cout << setw(37) << left << ""
               << "\t[3] Delete Client\n";
          cout << setw(37) << left << ""
               << "\t[4] Update Client\n";
          cout << setw(37) << left << ""
               << "\t[5] Find Client\n";
          cout << setw(37) << left << ""
               << "\t[6] Transactions\n";
          cout << setw(37) << left << ""
               << "\t[7] Mange Users\n";
          cout << setw(37) << left << ""
               << "\t[8] Login Register\n";
          cout << setw(37) << left << ""
               << "\t[9] Logout\n";
          cout << setw(37) << left << ""
               << "=======================================\n";

          _PerformMainMenueOption((enMainScreen)_ReadMainMenueOption());
     }
};