#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsUtility.cpp";
#include "../clsInputValidate.cpp";

using namespace std;

class clsUpdateClientScreen : protected clsMainScreen
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

    static void _ReadClientInfo(clsBankClient &Client)
    {
        // Update object info by referance
        Client.SetFirstName(clsInputValidate::ReadString("Enter Your First Name? "));
        Client.SetLastName(clsInputValidate::ReadString("Enter Your Last Name? "));
        Client.SetEmail(clsInputValidate::ReadString("Enter Your Email? "));
        Client.SetPhone(clsInputValidate::ReadString("Enter Your Phone? "));
        Client.SetPinCode(clsInputValidate::ReadString("Enter Your Acount Pin Code? "));
        // Client.SetAccountBalance(clsInputValidate::ReadFloatNumber("Enter Your Phone? "));
    }

public:
    static void ShowUpdateClientScreen()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pUpdateClient))
        {
            return; // this will exit function and it will not Screen
        }

        _DrawMainScreenHeader("\tUpdate Client Screen");

        string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

        while (!clsBankClient::IsClientExist(AccountNumber))
        {
            AccountNumber = clsInputValidate::ReadString("Not Exist, Enter Your Acount Number again? ");
        }

        // Get Client and set update mode
        clsBankClient Client = clsBankClient::Find(AccountNumber);

        // Print Client
        _Print(Client);

        _ReadClientInfo(Client);

        clsBankClient::enSaveResults SaveResults;

        // save file after updating and return status
        SaveResults = Client.Save();

        switch (SaveResults)
        {
        case clsBankClient::svSucceded:
            cout << "Account updated Successfuly :-)";
            break;
        case clsBankClient::svFaildEmbtyObject:
            cout << "Error account was not saved because it`s Empty ";
            break;
        }
    }
};