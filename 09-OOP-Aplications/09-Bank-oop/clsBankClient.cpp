#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "clsPerson.cpp";
#include "clsString.cpp";
#include "clsInputValidate.cpp";

using namespace std;

class clsBankClient : public clsPerson
{
private:
    enum enMode
    {
        EmptyMode = 0,
        UpdateMode = 1,
        AddNewMode = 2,
    };

    enMode _Mode;
    string _AccountNumber;
    string _PinCode;
    float _AccountBalance;
    bool _MarkForDelete = false;

    static string _ConvertClientObjectToLine(clsBankClient Client, string Delime)
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

    static void _SaveClientsDatetoFile(vector<clsBankClient> &vClients)
    {
        fstream File;
        File.open("DataBase/clients.txt", ios::out);

        if (File.is_open())
        {
            // for loop (clients each client->line then append this line)
            for (clsBankClient &Client : vClients)
            {
                if (Client.MarkForDelete() == true)
                    continue;
                else
                    File << _ConvertClientObjectToLine(Client, "#//#") << endl;
            }

            File.close();
        }
    }

    static void _AddDataLineToFile(string LineOfDate)
    {
        fstream File;
        File.open("DataBase/clients.txt", ios::out | ios::app);

        if (File.is_open())
        {
            File << LineOfDate << endl;

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

    static vector<clsBankClient> _LoadClientsDataFromFile()
    {
        vector<clsBankClient> vClients;

        fstream File;
        File.open("DataBase/clients.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                clsBankClient Client = _ConvertLinetoClientObject(Line);
                vClients.push_back(Client);
            }
            File.close();
        }
        return vClients;
    }

    void _Update()
    {
        vector<clsBankClient> _vClients;
        _vClients = _LoadClientsDataFromFile();

        for (clsBankClient &C : _vClients)
        {
            if (C.AccountNumber() == AccountNumber())
            {
                C = *this;
                break;
            }
        }

        // save file after updating
        _SaveClientsDatetoFile(_vClients);
    }

    void _AddNew()
    {
        _AddDataLineToFile(_ConvertClientObjectToLine(*this, "#//#"));
    }

    void _Delete()
    {
        // [2] Delete mark
        vector<clsBankClient> _vClients;
        _vClients = _LoadClientsDataFromFile();

        for (clsBankClient &C : _vClients)
        {
            if (C.AccountNumber() == AccountNumber())
            {
                C._MarkForDelete = true;
                break;
            }
        }

        // save file after updating
        _SaveClientsDatetoFile(_vClients);
        *this = _GetEmptyClientObject();
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

    // read only
    bool MarkForDelete()
    {
        return _MarkForDelete;
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

    enum enSaveResults
    {
        svFaildEmbtyObject = 0,
        svSucceded = 1,
        svFaildExistObject = 2
    };

    enSaveResults Save()
    {
        // if this object is full by data so save it
        // and return svSucceded enum => Succeded Message show it in UI
        // else return svEmbtyObject enum, and dont save it
        switch (_Mode)
        {
        case enMode::EmptyMode:
            return enSaveResults::svFaildEmbtyObject;
            break;
        case enMode::UpdateMode:
            // update file after update this obejct
            _Update();
            return enSaveResults::svSucceded;
            break;
        case enMode::AddNewMode:
            // Add New Client to file
            if (IsClientExist(_AccountNumber))
            {
                return enSaveResults::svFaildExistObject;
            }
            else
            {
                _AddNew();
                _Mode = enMode::UpdateMode;
                return enSaveResults::svSucceded;
            }
            break;
        default:
            return enSaveResults::svFaildEmbtyObject;
            break;
        }
    }

    static clsBankClient GetAddNewClient(string AccountNumber)
    {
        // set Add mode
        return clsBankClient(enMode::AddNewMode, "", "", "", "", AccountNumber, "", 0);
    }

    bool Delete()
    {
        if (_Mode == enMode::EmptyMode)
        {
            return false;
        }
        else
        {
            _Delete();
            return true;
        }
    }

    static vector<clsBankClient> GetClients()
    {
        return _LoadClientsDataFromFile();
    }

    void Deposit(float amount)
    {
        _AccountBalance += amount;
        Save();
    }

    bool IsValidWithdrew(float amount)
    {
        if (amount > _AccountBalance)
        {
            return false;
        }
        return true;
    }

    void Withdrew(float amount)
    {
        if (amount > _AccountBalance)
        {
            return;
        }
        _AccountBalance -= amount;
        Save();
    }

    bool Transfer(float Amount, clsBankClient & Client_TransferTo)
    {
        if (Amount > AccountBalance())
        {
            return false;
        }
        Withdrew(Amount);
        Client_TransferTo.Deposit(Amount);
        return true;
    }
};