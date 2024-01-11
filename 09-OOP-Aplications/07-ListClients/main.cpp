#include <iostream>
#include "clsBankClient.cpp";
#include "clsInputValidate.cpp";
#include "clsUtility.cpp";
using namespace std;

// UI List Clients
void ClientsInfoHeader(short TotalClients)
{
    cout << endl
         << clsUtility::Space(5) << "Client List (" << TotalClients << ") Client(s).\n";
    cout << "--------------------------------------------------------------------------------------------------\n";
    cout << " | First N.";
    cout << " | Last N. ";
    cout << " | Email.             ";
    cout << " | Phone" << clsUtility::Space(1);
    cout << " | Account N." << clsUtility::Space(1);
    cout << " | Pin Code" << clsUtility::Space(1);
    cout << " | Balance" << clsUtility::Space(1);
    cout << endl;
    cout << "--------------------------------------------------------------------------------------------------\n";
}

void PrintClientInfo(clsBankClient Client)
{
    cout << " | " << Client.FirstName() << "  ";
    cout << " | " << Client.LastName() << "     ";
    cout << " | " << Client.Email() << "   ";
    cout << " | " << Client.Phone() << clsUtility::Space(1);
    cout << " | " << Client.AccountNumber() << clsUtility::Space(2);
    cout << " | " << Client.PinCode() << clsUtility::Space(2);
    cout << " | " << Client.AccountBalance() << endl;
}

void ShowListClients()
{
    vector<clsBankClient> vClients;
    vClients = clsBankClient::GetClients();
    ClientsInfoHeader(vClients.size());
    if (vClients.size() == 0)
    {
        cout << "\t\t\t No Clints in System\n";
        return;
    }
    for (clsBankClient Client : vClients)
    {
        PrintClientInfo(Client);
    }
    cout << "--------------------------------------------------------------------------------------------------\n";
    cout << endl;
}

int main()
{
    ShowListClients();

    return 0;
}