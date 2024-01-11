#pragma once

#include <iostream>
#include <iomanip>
#include <vector>
#include "../../clsMainScreen.cpp";
#include "../../clsBankClient.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsBalanceListScreen : protected clsMainScreen
{
private:
    static void _BalancesInfoHeader(short TotalClients)
    {
        cout << endl
             << "\t\t\t\t\tBalances List (" << TotalClients << ") Client(s).\n";
        cout << "\t\t---------------------------------------------------------------------------------------------\n";
        cout << "\t\t | Account Num \t\t";
        cout << " | Client Name \t\t";
        cout << " | Balance";
        cout << endl;
        cout << "\t\t---------------------------------------------------------------------------------------------\n";
    }

    static void _PrintBalanceInfo(clsBankClient Client)
    {
        cout << "\t\t | " << Client.AccountNumber() << clsUtility::Space(3);
        cout << " | " << Client.FullName() << clsUtility::Space(2);
        cout << " | " << Client.AccountBalance() << endl;
    }

public:
    static void ShowBalanceListScreen()
    {
        _DrawMainScreenHeader("\tBalance List Screen");

        vector<clsBankClient> vClients = clsBankClient::GetClients();
        int TotalBalances = 0;
        _BalancesInfoHeader(vClients.size());
        for (clsBankClient Client : vClients)
        {
            TotalBalances += Client.AccountBalance();
            _PrintBalanceInfo(Client);
        }
        cout << "\t\t---------------------------------------------------------------------------------------------\n";
        cout << clsUtility::Space(4) << "Total Balances = " << TotalBalances; // TotalBalances method must be in Client Object
        cout << endl;

        //
        cout << clsUtility::Space(3) << "(" << clsUtility::NumberToText(TotalBalances) << ")\n";
    }
};