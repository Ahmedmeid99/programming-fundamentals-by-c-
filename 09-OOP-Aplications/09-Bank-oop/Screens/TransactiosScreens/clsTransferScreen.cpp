#pragma once

#include <iostream>
#include <iomanip>
#include <vector>
#include "../../clsMainScreen.cpp";
#include "../../clsBankClient.cpp";
#include "../../clsUser.cpp";
#include "../../Global.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsTransferScreen : protected clsMainScreen
{
private:
    static void _Print(clsBankClient Client)
    {
        cout << "\n_________________________________\n\n";
        cout << "Full Name   : " << Client.FullName() << endl;
        cout << "Acc. Number : " << Client.AccountNumber() << endl;
        cout << "Balance     : " << Client.AccountBalance() << endl;
        cout << "\n_________________________________\n";
    }

    static void _SetTransferLogstruct(clsUser::stTransferLog &TransferLog, clsBankClient SClient, clsBankClient DClient, float Amount)
    {
        // from Global.cpp
        TransferLog._UserName = CurrentUser.UserName();

        TransferLog._CTransferFrom = SClient.AccountNumber();
        TransferLog._CTransferTo = DClient.AccountNumber();
        TransferLog._Amount = Amount;
        TransferLog._SBalance = SClient.AccountBalance();
        TransferLog._DBalance = DClient.AccountBalance();

        /* TransferLog._Date_Time added inclsUser
        by defult in_ConvertTransferLogToLine */
    }
    static clsBankClient _ReadClient(string Message)
    {
        string AccountNumber = "";
        do
        {
            AccountNumber = clsInputValidate::ReadString(Message);
        } while (!clsBankClient::IsClientExist(AccountNumber));
        return clsBankClient::Find(AccountNumber);
    }

public:
    static void ShowTransferScreen()
    {
        _DrawMainScreenHeader("\t\t Transfer Screen");

        // read valid acount to Transfer From
        clsBankClient TransferFrom = _ReadClient("Please Enter Account Number to Transfar From:");
        _Print(TransferFrom);

        // read valid acount to Transfer to
        clsBankClient TransferTo = _ReadClient("Please Enter Account Number to Transfar To:");
        _Print(TransferTo);

        // read Transfer Amount
        float TransferAmount = clsInputValidate::ReadFloatNumber("Enter Transfer Amount: ");

        // Transfer
        char Answer = clsInputValidate::ReadChar("Are you sure you want to perform this operation? y/n : ");

        if (Answer == 'y' || Answer == 'Y')
        {

            // Transfer Operation
            if (TransferFrom.Transfer(TransferAmount, TransferTo))
                cout << "\n Transfer done Sccuessfuly\n";
            else
                cout << "\n Transfer Falid\n";

            // Register Transfer operation
            clsUser::stTransferLog TransferLog;
            _SetTransferLogstruct(TransferLog, TransferFrom, TransferTo, TransferAmount);
            clsUser::RegisterTransferLog(TransferLog);

            // Print Client info after update
            _Print(TransferFrom);
            _Print(TransferTo);
        }
    }
};
