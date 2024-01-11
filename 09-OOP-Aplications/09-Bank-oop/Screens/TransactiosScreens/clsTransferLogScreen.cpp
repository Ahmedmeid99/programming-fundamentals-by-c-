
#pragma once

#include <iostream>
#include <iomanip>
#include <vector>
#include "../../clsMainScreen.cpp";
#include "../../clsBankClient.cpp";
#include "../../clsUser.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsTransferLogScreen : protected clsMainScreen
{
private:
    static void _TransferLogHeader()
    {
        cout << "\n\t\t---------------------------------------------------------------------------------------------\n";
        cout << "\t\t | " << left << setw(20) << "Date-Time ";
        cout << " | " << left << setw(10) << "s. Acct ";
        cout << " | " << left << setw(10) << "d. Acct ";
        cout << " | " << left << setw(10) << "Amount ";
        cout << " | " << left << setw(10) << "s.Balance";
        cout << " | " << left << setw(10) << "d.Balance";
        cout << " | " << left << setw(10) << "User";
        cout << "\n\t\t---------------------------------------------------------------------------------------------\n";
    }

    static void _PrintTransferLogItem(clsUser::stTransferLog TransferLog)
    {
        cout << "\t\t | " << left << setw(20) << TransferLog._Date_Time;
        cout << " | " << left << setw(10) << TransferLog._CTransferFrom;
        cout << " | " << left << setw(10) << TransferLog._CTransferTo;
        cout << " | " << left << setw(10) << TransferLog._Amount;
        cout << " | " << left << setw(10) << TransferLog._SBalance;
        cout << " | " << left << setw(10) << TransferLog._DBalance;
        cout << " | " << left << setw(10) << TransferLog._UserName << endl;
    }

public:
    static void ShowTransferLogListScreen()
    {
        _DrawMainScreenHeader("\t Transfer Log List Screen");

        vector<clsUser::stTransferLog> vTransferLogs = clsUser::GetTransferLog();

        _TransferLogHeader();
        for (clsUser::stTransferLog TransferLog : vTransferLogs)
        {
            _PrintTransferLogItem(TransferLog);
        }
        cout << "\t\t---------------------------------------------------------------------------------------------\n";
        cout << endl;
    }
};
