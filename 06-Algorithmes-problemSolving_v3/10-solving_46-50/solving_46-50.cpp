#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "../00-MyLibrary/strings.cpp"
#include "../00-MyLibrary/numbers.cpp"
using namespace std;

struct stClientData
{
    string AccontNumber;
    int PinCode;
    string FullName;
    int Phone;
    int Balance;
};

stClientData ReadClientData()
{
    stClientData ClientData;
    cout << "Add Your data Plase...\n";
    ClientData.AccontNumber = strings::ReadInputString("Enter Your Acount Number? ");
    ClientData.PinCode = nums::ReadPositveNumber("Enter Your Acount Pin Code? ");
    ClientData.FullName = strings::ReadInputString("Enter Your Name? ");
    ClientData.Phone = nums::ReadPositveNumber("Enter Your Phone? ");
    ClientData.Balance = nums::ReadPositveNumber("Enter Your Acount Balance? ");
    return ClientData;
}

string ClientDataToLine(stClientData ClientData, string Delime)
{
    string LineOfData = ClientData.AccontNumber + Delime +
                        to_string(ClientData.PinCode) + Delime +
                        ClientData.FullName + Delime +
                        to_string(ClientData.Phone) + Delime +
                        to_string(ClientData.Balance);
    return LineOfData;
}

vector<string> SplitStringOn(string Line, string Delim)
{
    vector<string> vString;
    short Pos = 0;
    string Word;

    while ((Pos = Line.find(Delim)) != std::string::npos)
    {
        Word = Line.substr(0, Pos);

        if (Word != "")
        {
            vString.push_back(Word);
        }

        Line.erase(0, Pos + Delim.length());
    }

    // get lasr word in string
    if (Line != "")
    {
        vString.push_back(Line);
    }
    return vString;
}

stClientData LineToRecord(string Line, stClientData &ClientData)
{
    // get each word in Line
    vector<string> vClientData = SplitStringOn(Line, "#//#");

    ClientData.AccontNumber = vClientData[0];
    ClientData.PinCode = stoi(vClientData[1]);
    ClientData.FullName = vClientData[2];
    ClientData.Phone = stoi(vClientData[3]);
    ClientData.Balance = stoi(vClientData[4]);

    return ClientData;
}

void StoreClientData(string ClientData, string FileName)
{
    fstream File;
    File.open(FileName, ios::out | ios::app);

    if (File.is_open())
    {
        File << ClientData << endl;

        File.close();
    }
}

void AddClients(stClientData ClientData, string FileName)
{
    string Answer = "Y";
    do
    {
        ClientData = ReadClientData();
        StoreClientData(ClientDataToLine(ClientData, "#//#"), FileName);

        Answer = strings::ReadInputString("Do you want to add new account? Y/N? ");

    } while (Answer == "Y" || Answer == "y");
}

vector<stClientData> GetCients(vector<stClientData> &vClientsData, string FileName)
{
    stClientData ClientData;
    fstream File;
    File.open(FileName, ios::in);

    if (File.is_open())
    {
        string Line;
        while (getline(File, Line))
        {
            vClientsData.push_back(LineToRecord(Line, ClientData));
        }
        File.close();
    }
    return vClientsData;
}

string Space(short Number)
{
    string SpaceLong;
    for (short i = 1; i <= Number; i++)
    {
        SpaceLong += "\t";
    }
    return SpaceLong;
}

void ClientsDataHeader(short TotalClients)
{
    cout << endl
         << Space(5) << "Client List (" << TotalClients << ") Client(s).\n";
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << " | Account Num  ";
    cout << " | Pin Code" << Space(1);
    cout << " | Client Name" << Space(2);
    cout << " | Phone" << Space(2);
    cout << " | Balance" << Space(1);
    cout << endl;
    cout << "---------------------------------------------------------------------------------------------\n";
}

void PrintClientData(stClientData ClientData)
{
    if (ClientData.AccontNumber != "")
    {
        cout << " | " << ClientData.AccontNumber << Space(2);
        cout << " | " << ClientData.PinCode << Space(2);
        cout << " | " << ClientData.FullName << Space(2);
        cout << " | " << ClientData.Phone << Space(2);
        cout << " | " << ClientData.Balance << Space(1) << endl;
    }
    else
    {
        // empty account send because can not find it
        cout << "NOT FOUND !!!\n";
    }
}

void PrintClientsData(vector<stClientData> vClientsData)
{
    ClientsDataHeader(vClientsData.size());
    for (stClientData ClientData : vClientsData)
    {
        PrintClientData(ClientData);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << endl;
}

void UpdateFile(vector<stClientData> &vClientsData, string FileName)
{
    fstream File;
    File.open(FileName, ios::out);

    if (File.is_open())
    { // for loop (clients each client->line then append this line)
        for (stClientData &ClientData : vClientsData)
        {
            File << ClientDataToLine(ClientData, "#//#") << endl;
        }

        File.close();
    }
}

stClientData FindClientData(vector<stClientData> vClientsData, string AccontNumber)
{
    stClientData EmptyClientData;
    for (stClientData ClientData : vClientsData)
    {
        if (AccontNumber == ClientData.AccontNumber)
        {
            return ClientData;
        }
    }
    // send empty account because it is not find
    return EmptyClientData;
}

void deleteClientData(vector<stClientData> &vClientsData, string AccountNumber, string FileName)
{

    PrintClientData(FindClientData(vClientsData, AccountNumber));
    for (auto it = vClientsData.begin(); it != vClientsData.end();)
    {
        if (it->AccontNumber == AccountNumber)
        {
            it = vClientsData.erase(it);
            break;
        }
        else
        {
            ++it;
        }
    }
    UpdateFile(vClientsData, FileName);
    cout << "Deleted Successfly\n";
}

stClientData ReadUpdateedClientData(string AccountNumber)
{
    stClientData ClientData;
    cout << "Update Your data ...\n";
    ClientData.AccontNumber = AccountNumber;
    ClientData.PinCode = nums::ReadPositveNumber("Enter Your Acount Pin Code? ");
    ClientData.FullName = strings::ReadInputString("Enter Your Name? ");
    ClientData.Phone = nums::ReadPositveNumber("Enter Your Phone? ");
    ClientData.Balance = nums::ReadPositveNumber("Enter Your Acount Balance? ");
    return ClientData;
}

void UpdateClientData(vector<stClientData> &vClientsData, string AccountNumber, string FileName)
{
    PrintClientData(FindClientData(vClientsData, AccountNumber));
    for (stClientData &ClientData : vClientsData)
    {
        if (ClientData.AccontNumber == AccountNumber)
        {
            ClientData = ReadUpdateedClientData(AccountNumber);
            cout << ClientData.FullName;
            break;
        }
    }
    UpdateFile(vClientsData, FileName);
    cout << "Updated Successfly\n";
}

int main()
{
    // [45] add Data Clint to one Line
    stClientData ClientData = ReadClientData();
    // cout << ClientDataToLine(ClientData, "#//#") << endl;

    // [46] from Line to Record (structure)
    stClientData GetClientData;
    // cout << ClientDataToLine(LineToRecord("p1#//#1234#//#ahmed mo#//#109581441#//#12000", GetClientData), "#//#") << endl;

    // [47] add client data to file
    string FileName = "MyInfo.txt";
    AddClients(ClientData, FileName);

    // [48] show all clients
    vector<stClientData> vClientsData;
    PrintClientsData(GetCients(vClientsData, FileName));

    // [49] Find
    // string AccountNumber1 = strings::ReadInputString("Enter Account Number You Search on? ");
    // PrintClientData(FindClientData(vClientsData1, AccountNumber));

    // [50] delete
    // string AccountNumber2 = strings::ReadInputString("Enter Account Number You want to delete? ");
    // deleteClientData(vClientsData, AccountNumber2, FileName);

    // [51] update
    // string AccountNumber3 = strings::ReadInputString("Enter Account Number You want to update? ");
    // UpdateClientData(vClientsData, AccountNumber3, FileName);
    return 0;
}