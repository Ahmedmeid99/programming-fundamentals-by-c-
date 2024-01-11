#pragma once

#include <iostream>
#include <iomanip>
#include <vector>
#include "../../clsMainScreen.cpp";
#include "../../clsBankClient.cpp";
#include "../../clsUtility.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsDepositScreen : protected clsMainScreen
{
private:
    static void _Print(clsBankClient Client)
    {
        cout << "Client Card\n\n";
        cout << "\t\t\t__________________________________\n";
        cout << "\t\t\tFirstName  : " << Client.FirstName() << endl;
        cout << "\t\t\tLastName   : " << Client.LastName() << endl;
        cout << "\t\t\tFullName   : " << Client.FullName() << endl;
        cout << "\t\t\tEmail      : " << Client.Email() << endl;
        cout << "\t\t\tPhone      : " << Client.Phone() << endl;
        cout << "\t\t\tAcc. Nomber: " << Client.AccountNumber() << endl;
        cout << "\t\t\tPassword   : " << Client.PinCode() << endl;
        cout << "\t\t\tBalance    : " << Client.AccountBalance() << endl;
        cout << "\n\t\t\t__________________________________\n";
    }

public:
    static void ShowDepositScreen()
    {
        // ("Deposit Screen");
        string AccountNumber = clsInputValidate::ReadString("Please enter AccountNumber? ");
        clsBankClient Client = clsBankClient::Find(AccountNumber);
        if (clsBankClient::IsClientExist(AccountNumber))
        {
            // Print Client Info
            cout << "Your Account details is : \n";
            _Print(Client);
            // Want to update  Balance +Deposit
            float DepositAmount = clsInputValidate::ReadFloatNumber("Please enter your Deposit amount : ");

            Client.Deposit(DepositAmount);

            cout << "Your Balance become = " << Client.AccountBalance() << endl;
        }
        else
        {
            cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
        }
        Client.Save();
    }
};
