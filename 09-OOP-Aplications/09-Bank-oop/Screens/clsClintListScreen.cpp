#pragma once

#include <iostream>
#include <iomanip>
#include "../clsMainScreen.cpp";
#include "../clsBankClient.cpp";
#include "../clsUtility.cpp";

using namespace std;

class clsClintListScreen : protected clsMainScreen
{
private:
    static void _ClientsInfoHeader()
    {
        cout << endl;
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
        cout << "\t\t | First N.";
        cout << " | Last N. ";
        cout << " | Email.             ";
        cout << " | Phone" << clsUtility::Space(1);
        cout << " | Account N." << clsUtility::Space(1);
        cout << " | Pin Code" << clsUtility::Space(1);
        cout << " | Balance" << clsUtility::Space(1);
        cout << endl;
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
    }

    static void _PrintClientInfo(clsBankClient Client)
    {
        cout << "\t\t | " << Client.FirstName() << "  ";
        cout << " | " << Client.LastName() << "     ";
        cout << " | " << Client.Email() << "   ";
        cout << " | " << Client.Phone() << clsUtility::Space(1);
        cout << " | " << Client.AccountNumber() << clsUtility::Space(2);
        cout << " | " << Client.PinCode() << clsUtility::Space(2);
        cout << " | " << Client.AccountBalance() << endl;
    }

public:
    static void ShowListClients()
    {

        if (!CheckAccessRights(clsUser::enPermissions::pListClients))
        {
            return; // this will exit function and it will not Screen
        }

        vector<clsBankClient> vClients;
        vClients = clsBankClient::GetClients();
        string Title = "\t Clint List Screen";
        string SubTitle = "\t    (" + to_string(vClients.size()) + ")Clint";
        _DrawMainScreenHeader(Title, SubTitle);
        _ClientsInfoHeader();
        if (vClients.size() == 0)
        {
            cout << "\t\t\t No Clints in System\n";
            return;
        }
        for (clsBankClient Client : vClients)
        {
            _PrintClientInfo(Client);
        }
        cout << "\t\t--------------------------------------------------------------------------------------------------\n";
        cout << endl;
    }
};