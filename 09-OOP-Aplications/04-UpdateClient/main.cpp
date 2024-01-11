#include <iostream>
#include "clsBankClient.cpp";
using namespace std;

// UI
void ReadClientInfo(clsBankClient &Client)
{
    // Update object info by referance
    Client.SetFirstName(clsInputValidate::ReadString("Enter Your First Name? "));
    Client.SetLastName(clsInputValidate::ReadString("Enter Your Last Name? "));
    Client.SetEmail(clsInputValidate::ReadString("Enter Your Email? "));
    Client.SetPhone(clsInputValidate::ReadString("Enter Your Phone? "));
    Client.SetPinCode(clsInputValidate::ReadString("Enter Your Acount Pin Code? "));
    // Client.SetAccountBalance(clsInputValidate::ReadFloatNumber("Enter Your Phone? "));
}

void UpdateClient()
{

    string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

    while (!clsBankClient::IsClientExist(AccountNumber))
    {
        AccountNumber = clsInputValidate::ReadString("Not Exist, Enter Your Acount Number again? ");
    }

    // Get Client and set update mode
    clsBankClient Client = clsBankClient::Find(AccountNumber);

    // Print Client
    Client.Print();

    // Update Client
    cout << "---------------------- \n";
    cout << "\n Update Client Info \n";
    cout << "---------------------- \n";

    ReadClientInfo(Client);

    clsBankClient::enSaveResults SaveResults;

    // save file after updating and return status
    SaveResults = Client.Save();

    switch (SaveResults)
    {
    case clsBankClient::svSucceded:
        cout << "Account updated Successfuly :-)";
        break;
    case clsBankClient::svEmbtyObject:
        cout << "Error account was not saved because it`s Empty ";
        break;
    }
}

int main()
{
    UpdateClient();

    return 0;
}