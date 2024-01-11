#include <iostream>
#include "clsBankClient.cpp";
#include "clsInputValidate.cpp";
#include "clsUtility.cpp";
using namespace std;

// UI List Clients

void BalancesInfoHeader(short TotalClients)
{
    cout << endl
         << clsUtility::Space(5) << "Balances List (" << TotalClients << ") Client(s).\n";
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << " | Account Num " << clsUtility::Space(2);
    cout << " | Client Name" << clsUtility::Space(2);
    cout << " | Balance";
    cout << endl;
    cout << "---------------------------------------------------------------------------------------------\n";
}

void PrintBalanceInfo(vector<clsBankClient> vClients, clsBankClient Client)
{
    cout << " | " << Client.AccountNumber() << clsUtility::Space(3);
    cout << " | " << Client.FullName() << clsUtility::Space(2);
    cout << " | " << Client.AccountBalance() << endl;
}

void ShowBalanceList()
{
    vector<clsBankClient> vClients = clsBankClient::GetClients();
    int TotalBalances = 0;
    BalancesInfoHeader(vClients.size());
    for (clsBankClient Client : vClients)
    {
        TotalBalances += Client.AccountBalance();
        PrintBalanceInfo(vClients, Client);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << clsUtility::Space(4) << "Total Balances = " << TotalBalances;
    cout << endl;

    //
    cout << clsUtility::Space(3) << "(" << clsUtility::NumberToText(TotalBalances) << ")\n";
}

int main()
{
    ShowBalanceList();
    return 0;
}