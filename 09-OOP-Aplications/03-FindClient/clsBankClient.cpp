#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "clsPerson.cpp";
#include "clsString.cpp";

using namespace std;

class clsBankClient : public clsPerson
{
private:
    enum enMode
    {
        EmptyMode = 0,
        UpdateMode = 1
    };

    enMode _Mode;
    string _AccountNumber;
    string _PinCode;
    float _AccountBalance;

    ////////////////////////
    //  Private Methods
    ////////////////////////
    static string ClientInfoToLine(clsBankClient Client, string Delime)
    {
        string LineOfData = Client.FirstName() + Delime +
                            Client.LastName() + Delime +
                            Client.Email() + Delime +
                            Client.Phone() + Delime +
                            Client._AccountNumber + Delime +
                            Client._PinCode + Delime +
                            to_string(Client._AccountBalance);
        return LineOfData;
    }

    static void _UpdateClientFile(vector<clsBankClient> &vClients)
    {
        fstream File;
        File.open("DataBase/clients.txt", ios::out);

        if (File.is_open())
        {
            // for loop (clients each client->line then append this line)
            for (clsBankClient &Client : vClients)
            {
                File << ClientInfoToLine(Client, "#//#") << endl;
            }

            File.close();
        }
    }

    static clsBankClient _ConvertLinetoClientObject(string Line)
    {
        // get each word in Line
        vector<string> vClient = clsString::SplitStringOn(Line, "#//#");
        return clsBankClient(enMode::UpdateMode, vClient[0], vClient[1], vClient[2], vClient[3], vClient[4], vClient[5], stod(vClient[6]));
    }

    static clsBankClient _GetEmptyClientObject()
    {
        return clsBankClient(enMode::EmptyMode, "", "", "", "", "", "", 0);
    }

    vector<clsBankClient> _LoadClientDataFromFile(string FileName)
    {
        vector<clsBankClient> vClients;
        clsBankClient Client = _GetEmptyClientObject();
        fstream File;
        File.open("DataBase/clients.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                vClients.push_back(_ConvertLinetoClientObject(Line));
            }
            File.close();
        }
        return vClients;
    }

public:
    clsBankClient(enMode Mode, string FirstName, string LastName, string Email,
                  string Phone, string AccountNumber, string PinCode, float AccountBalance)
        : clsPerson(FirstName, LastName, Email, Phone)
    {
        _Mode = Mode;
        _AccountNumber = AccountNumber;
        _PinCode = PinCode;
        _AccountBalance = AccountBalance;
    }

    bool IsEmpty()
    {
        return (_Mode == enMode::EmptyMode);
    }

    // read only
    string AccountNumber()
    {
        return _AccountNumber;
    }

    void SetPinCode(string PinCode)
    {
        _PinCode = PinCode;
    }

    string PinCode()
    {
        return _PinCode;
    }

    void SetAccountBalance(float AccountBalance)
    {
        _AccountBalance = AccountBalance;
    }

    float AccountBalance()
    {
        return _AccountBalance;
    }

    void Print()
    {
        cout << "Client Card\n\n";
        cout << "__________________________________\n";
        cout << "FirstName  : " << FirstName() << endl;
        cout << "LastName   : " << LastName() << endl;
        cout << "FullName   : " << FullName() << endl;
        cout << "Email      : " << Email() << endl;
        cout << "Phone      : " << Phone() << endl;
        cout << "Acc. Nomber: " << Phone() << endl;
        cout << "Password   : " << Phone() << endl;
        cout << "Balance    : " << Phone() << endl;
        cout << "\n__________________________________\n";
    }

    // find client in file
    static clsBankClient Find(string AccountNumber)
    {
        vector<clsBankClient> vClients;

        fstream File;
        File.open("DataBase/clients.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                // ConvertLineTO Object to check
                clsBankClient Client = _ConvertLinetoClientObject(Line);
                if (Client._AccountNumber == AccountNumber)
                {
                    File.close();
                    return Client;
                }
                vClients.push_back(Client); // ??
            }

            File.close();
        }
        return _GetEmptyClientObject();
    }

    static clsBankClient Find(string AccountNumber, string PinCode)
    {
        vector<clsBankClient> vClients;

        fstream File;
        File.open("DataBase/clients.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                // ConvertLineTO Object to check
                clsBankClient Client = _ConvertLinetoClientObject(Line);
                if (Client._AccountNumber == AccountNumber && Client._PinCode == PinCode)
                {
                    File.close();
                    return Client;
                }
                vClients.push_back(Client); // ??
            }

            File.close();
        }
        return _GetEmptyClientObject();
    }

    static bool IsClientExist(string AccountNumber)
    {
        clsBankClient Client_1 = clsBankClient::Find(AccountNumber);
        return (!Client_1.IsEmpty());
    }
};