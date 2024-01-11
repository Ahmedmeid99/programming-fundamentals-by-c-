#include <iostream>
#include "clsBankClient.cpp";
#include "clsInputValidate.cpp";
using namespace std;

// UI Update Client

void DeleteClient()
{

    string AccountNumber = clsInputValidate::ReadString("Enter Your Acount Number? ");

    while (!clsBankClient::IsClientExist(AccountNumber))
    {
        AccountNumber = clsInputValidate::ReadString("This Acount Number is Not Exist, try again? ");
    }

    // Get Client and set update mode
    clsBankClient Client = clsBankClient::Find(AccountNumber);

    // Print Client
    Client.Print();

    // Delete Client
    cout << "---------------------- \n";
    cout << "\n Delete Client Info \n";
    cout << "---------------------- \n";

    clsBankClient::enSaveResults SaveResults;
    char Anwser = clsInputValidate::ReadChar("Do you want to delete this account Y/N? ");
    if (Anwser == 'Y' || Anwser == 'y')
    {
        cout << "work 1 \n";
        // delete and return state
        if (Client.Delete())
        {
            cout << "work 1/2 \n";
            Client.Print();
            cout << "deleted Scuessfully" << endl;
        }
        else
        {
            cout << "work 2/2 \n";
            cout << "Error Client was not deleted?\n";
        }
    }
}

int main()
{
    DeleteClient();

    return 0;
}