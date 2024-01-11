#include <iostream>
#include "clsBankClient.cpp";
using namespace std;

// UI AddNew Client
void ReadEnteredClientInfo(clsBankClient &Client)
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

void AddNewClient()
{

    string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

    while (clsBankClient::IsClientExist(AccountNumber))
    {
        AccountNumber = clsInputValidate::ReadString("This Acount Number is Exist, try again? ");
    }

    // Update Client
    cout << "---------------------- \n";
    cout << "\n Add Client Info \n";
    cout << "---------------------- \n";

    clsBankClient NewClient = clsBankClient::GetAddNewClient(AccountNumber);

    ReadEnteredClientInfo(NewClient);

    clsBankClient::enSaveResults SaveResults;

    // save file after updating and return status
    SaveResults = NewClient.Save();

    switch (SaveResults)
    {
    case clsBankClient::svSucceded:
        cout << "Account updated Successfuly :-)";
        break;
    case clsBankClient::svFaildEmbtyObject:
        cout << "Error account was not saved because it`s Empty ";
        break;
    case clsBankClient::svFaildExistObject:
        cout << "Error This Acount Number is Exist ";
        break;
    }
}

int main()
{
    AddNewClient();

    return 0;
}