#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsMainMenueScreen.cpp";
#include "../clsUtility.cpp";
#include "../clsInputValidate.cpp";
#include "TransactiosScreens/clsDepositScreen.cpp";
#include "TransactiosScreens/clsWithdrewScreen.cpp";
#include "TransactiosScreens/clsBalanceListScreen.cpp";
#include "TransactiosScreens/clsTransferScreen.cpp";
#include "TransactiosScreens/clsTransferLogScreen.cpp";

using namespace std;

class clsTransactionsScreen : protected clsMainScreen
{
private:
    enum enTransactionsScreen
    {
        Deposit = 1,
        Withdeaw = 2,
        TotalBalances = 3,
        Transfer = 4,
        TransferLog = 5,
        MainMenue = 6

    };

    static void _GoBackToTransactiosMenue()
    {
        cout << setw(37) << left << ""
             << "\n\t press any key to go back to Transactios menue...\n";
        system("pause>0");
        clsTransactionsScreen::ShowTransactionMenue();
    }

    static void _ShowDepositScreen()
    {
        clsDepositScreen::ShowDepositScreen();
    }

    static void _ShowWithdrawScreen()
    {
        clsWithdrewScreen::ShowWithdrawScreen();
    }

    static void _ShowBalanceListScreen()
    {
        clsBalanceListScreen::ShowBalanceListScreen();
    }

    static void _ShowTransferScreen()
    {
        clsTransferScreen::ShowTransferScreen();
    }

    static void _ShowTransferLogScreen()
    {
        clsTransferLogScreen::ShowTransferLogListScreen();
    }

    static void _ShowMainMenue()
    {
        // Do nothing to go to Main menue
    }

    static void _PrefromTransScreen(enTransactionsScreen TransactionsScreen)
    {
        switch (TransactionsScreen)
        {
        case enTransactionsScreen::Deposit:
            system("cls");
            _ShowDepositScreen();
            _GoBackToTransactiosMenue();
            break;
        case enTransactionsScreen::Withdeaw:
            system("cls");
            _ShowWithdrawScreen();
            _GoBackToTransactiosMenue();
            break;
        case enTransactionsScreen::TotalBalances:
            system("cls");
            _ShowBalanceListScreen();
            _GoBackToTransactiosMenue();
            break;
        case enTransactionsScreen::Transfer:
            system("cls");
            _ShowTransferScreen();
            _GoBackToTransactiosMenue();
            break;
        case enTransactionsScreen::TransferLog:
            system("cls");
            _ShowTransferLogScreen();
            _GoBackToTransactiosMenue();
            break;
        case enTransactionsScreen::MainMenue:
            system("cls");
            _ShowMainMenue();
            break;
        default:
            clsTransactionsScreen::ShowTransactionMenue();
            break;
        }
    }

public:
    static void ShowTransactionMenue()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pTransactions))
        {
            return; // this will exit function and it will not Screen
        }

        system("cls");
        cout << "\n\n\t\t==================================================\n";
        cout << "\t\tTransactions Menue Screen\n";
        cout << "\t\t==================================================\n";
        cout << "\t\t[1] Deposit. \n";
        cout << "\t\t[2] Withdeaw. \n";
        cout << "\t\t[3] Total Balances. \n";
        cout << "\t\t[4] Transfer. \n";
        cout << "\t\t[5] Transfer Log. \n";
        cout << "\t\t[6] Main Menue. \n";
        cout << "\t\t==================================================\n";

        short UserChoose = clsInputValidate::ReadShortNumberBetween(1, 6, "\t\tChoose what do you want to do? [1 to 4]? ");
        _PrefromTransScreen((enTransactionsScreen)UserChoose);
    }
};
