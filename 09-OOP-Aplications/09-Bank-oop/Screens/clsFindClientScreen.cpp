#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsUtility.cpp";
#include "../clsInputValidate.cpp";

using namespace std;

class clsFindClientScreen : protected clsMainScreen
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
    static void ShowFindClientScreen()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pFindClient))
        {
            return; // this will exit function and it will not Screen
        }

        _DrawMainScreenHeader("\tFind Client Screen");

        string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            AccountNumber = clsInputValidate::ReadString("This Acount Number is Not Exist, try again? ");
        }

        clsBankClient BankClient_1 = clsBankClient::Find(AccountNumber);

        _Print(BankClient_1);
    }
};