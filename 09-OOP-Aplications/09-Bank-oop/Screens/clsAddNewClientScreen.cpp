#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsUtility.cpp";
#include "../clsInputValidate.cpp";

using namespace std;

class clsAddNewClientScreen : protected clsMainScreen
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

    static void _ReadEnteredClientInfo(clsBankClient &Client)
    {
        // Update object info by referance
        Client.SetFirstName(clsInputValidate::ReadString("Enter Your First Name? "));
        Client.SetLastName(clsInputValidate::ReadString("Enter Your Last Name? "));
        Client.SetEmail(clsInputValidate::ReadString("Enter Your Email? "));
        Client.SetPhone(clsInputValidate::ReadString("Enter Your Phone? "));
        Client.SetPinCode(clsInputValidate::ReadString("Enter Your Acount Pin Code? "));
        Client.SetAccountBalance(clsInputValidate::ReadFloatNumber("Enter Your Account Balance? "));
        // Account number will added inside class
    }

public:
    static void ShowAddNewClientScreen()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pAddClient))
        {
            return; // this will exit function and it will not Screen
        }

        _DrawMainScreenHeader("\tAdd Client Screen");

        string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

        while (clsBankClient::IsClientExist(AccountNumber))
        {
            AccountNumber = clsInputValidate::ReadString("This Acount Number is Exist, try again? ");
        }

        clsBankClient NewClient = clsBankClient::GetAddNewClient(AccountNumber);

        _ReadEnteredClientInfo(NewClient);

        clsBankClient::enSaveResults SaveResults;

        // save file after updating and return status
        SaveResults = NewClient.Save();

        switch (SaveResults)
        {
        case clsBankClient::svSucceded:
            cout << "Account updated Successfuly :-)";
            _Print(NewClient);
            break;
        case clsBankClient::svFaildEmbtyObject:
            cout << "Error account was not saved because it`s Empty ";
            break;
        case clsBankClient::svFaildExistObject:
            cout << "Error This Acount Number is Exist ";
            break;
        }
    }
};