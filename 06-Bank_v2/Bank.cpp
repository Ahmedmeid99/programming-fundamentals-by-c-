#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "../00-MyLibrary/strings.cpp"
#include "../00-MyLibrary/numbers.cpp"
using namespace std;

enum enMainScreen
{
    ShowClients = 1,
    AddClient = 2,
    DeleteClient = 3,
    UpdateClient = 4,
    FindClient = 5,
    Transactions = 6,
    Exit = 7
};
enum enTransactionsScreen
{
    Deposit = 1,
    Withdeaw = 2,
    TotalBalances = 3,
    MainMenue = 4

};

struct stClient
{
    string AccountNumber;
    int PinCode;
    string FullName;
    int Phone;
    int Balance;
};

///////////////////////////////////////////
////////////[ Helper Functions ]///////////

enMainScreen ReadEnteredMainChoise(string Message)
{
    short EnteredNumber;

    cout << Message;
    cin >> EnteredNumber;

    return (enMainScreen)EnteredNumber;
}

enTransactionsScreen ReadEnteredTransChoise(string Message)
{
    short EnteredNumber;

    cout << Message;
    cin >> EnteredNumber;

    return (enTransactionsScreen)EnteredNumber;
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

///////////////////////////////////////////
void DisplayTransMenue(vector<stClient> vClients, string FileName);
void DisplayMainScreen(enMainScreen ScreenNumber);
void DisplayMainMenue()
{
    cout << "\n\n==================================================\n";
    cout << Space(2) << "Main Menue Screen\n";
    cout << "==================================================\n";
    cout << Space(1) << "[1] Show Client List. \n";
    cout << Space(1) << "[2] Add New Client. \n";
    cout << Space(1) << "[3] Delete Client. \n";
    cout << Space(1) << "[4] Update Client Info. \n";
    cout << Space(1) << "[5] Find Client. \n";
    cout << Space(1) << "[6] Transactions. \n";
    cout << Space(1) << "[7] Exit. \n";
    cout << "==================================================\n";

    enMainScreen UserChoose = ReadEnteredMainChoise("Choose what do you want to do? [1 to 7]? ");
    DisplayMainScreen(UserChoose);
}

///////////////////////////////////////////
/////////////[ Add Client]/////////////////

stClient ReadClientInfo()
{
    stClient Client;
    cout << "Adding New Client:\n\n";
    Client.AccountNumber = strings::ReadInputString("Enter Your Acount Number? ");
    Client.PinCode = nums::ReadPositveNumber("Enter Your Acount Pin Code? ");
    Client.FullName = strings::ReadInputString("Enter Your Name? ");
    Client.Phone = nums::ReadPositveNumber("Enter Your Phone? ");
    Client.Balance = nums::ReadPositveNumber("Enter Your Acount Balance? ");
    return Client;
}

string ClientInfoToLine(stClient Client, string Delime)
{
    string LineOfData = Client.AccountNumber + Delime +
                        to_string(Client.PinCode) + Delime +
                        Client.FullName + Delime +
                        to_string(Client.Phone) + Delime +
                        to_string(Client.Balance);
    return LineOfData;
}

void StoreClient(string LineOfClient, string FileName)
{
    fstream File;
    File.open(FileName, ios::out | ios::app);

    if (File.is_open())
    {
        File << LineOfClient << endl;

        File.close();
    }
}

void ScreenHeader(string Title)
{
    cout << "\n----------------------------------------\n";
    cout << Space(1) << Title << endl;
    cout << "----------------------------------------\n";
}

void AddScreen(string FileName)
{
    string Answer = "Y";
    while (Answer == "Y" || Answer == "y")
    {
        ScreenHeader("Add New Clients Screen");
        stClient Client = ReadClientInfo();
        StoreClient(ClientInfoToLine(Client, "#//#"), FileName);
        cout << "Client Added Successfully, Do you want to add new account? Y/N?  ";
        cin >> Answer;
    };
}

///////////////////////////////////////////
///////////////[ Find Screen ]/////////////

void UpdateFile(vector<stClient> &vClients, string FileName)
{
    fstream File;
    File.open(FileName, ios::out);

    if (File.is_open())
    { // for loop (clients each client->line then append this line)
        for (stClient &Client : vClients)
        {
            File << ClientInfoToLine(Client, "#//#") << endl;
        }

        File.close();
    }
}

void PrintClientInfo(vector<stClient> vClients, stClient Client)
{
    cout << " | " << Client.AccountNumber << Space(2);
    cout << " | " << Client.PinCode << Space(2);
    cout << " | " << Client.FullName << Space(2);
    cout << " | " << Client.Phone << Space(2);
    cout << " | " << Client.Balance << endl;
}

bool IsFoundClient(vector<stClient> vClients, string AccountNumber)
{
    for (stClient Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber)
        {
            return true;
        }
    }
    return false;
}

void FindClientInfo(vector<stClient> vClients, string AccountNumber)
{
    for (stClient Client : vClients)
    {
        if (AccountNumber == Client.AccountNumber)
        {
            PrintClientInfo(vClients, Client);
            break;
        }
    }
}

void FindClientScreen(vector<stClient> vClients, string FileName)
{
    ScreenHeader("Update Client");
    string AccountNumber = strings::ReadInputString("Enter Account Number You want to find? ");

    if (IsFoundClient(vClients, AccountNumber))
    {
        // Print Client Info
        FindClientInfo(vClients, AccountNumber);
        cout << "Found Successfly\n";
    }
    else
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    }
    UpdateFile(vClients, FileName);
}

///////////////////////////////////////////
///////////[ clients List Screen ]/////////

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

stClient LineToRecord(string Line, stClient &Client)
{
    // get each word in Line
    vector<string> vClient = SplitStringOn(Line, "#//#");

    Client.AccountNumber = vClient[0];
    Client.PinCode = stoi(vClient[1]);
    Client.FullName = vClient[2];
    Client.Phone = stoi(vClient[3]);
    Client.Balance = stoi(vClient[4]);

    return Client;
}

vector<stClient> GetCients(string FileName)
{
    vector<stClient> vClients;
    stClient Client;
    fstream File;
    File.open(FileName, ios::in);

    if (File.is_open())
    {
        string Line;
        while (getline(File, Line))
        {
            vClients.push_back(LineToRecord(Line, Client));
        }
        File.close();
    }
    return vClients;
}

void ClientsInfoHeader(short TotalClients)
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

void ClientListScreen(vector<stClient> vClients)
{
    ClientsInfoHeader(vClients.size());
    for (stClient Client : vClients)
    {
        PrintClientInfo(vClients, Client);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << endl;
}

///////////////////////////////////////////
/////////////[ Update Screen ]/////////////

stClient ReadUpdateedClientInfo(string AccountNumber)
{
    stClient Client;
    cout << "Update Your data ...\n";
    Client.AccountNumber = AccountNumber;
    Client.PinCode = nums::ReadPositveNumber("Enter Your Acount Pin Code? ");
    Client.FullName = strings::ReadInputString("Enter Your Name? ");
    Client.Phone = nums::ReadPositveNumber("Enter Your Phone? ");
    Client.Balance = nums::ReadPositveNumber("Enter Your Acount Balance? ");
    return Client;
}

void UpdateClientInfo(vector<stClient> &vClients, string AccountNumber)
{
    for (stClient &Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber)
        {
            Client = ReadUpdateedClientInfo(AccountNumber);
            break;
        }
    }
}

void UpdateScreen(vector<stClient> &vClients, string FileName)
{
    ScreenHeader("Update Client Screen");

    string AccountNumber = strings::ReadInputString("Enter Account Number You want to Update? ");

    if (IsFoundClient(vClients, AccountNumber))
    {
        // Print Client Info
        FindClientInfo(vClients, AccountNumber);

        // Want to Update
        string UpdateClient = strings::ReadInputString("Do you want to Update this client? Y/N? ");
        if (UpdateClient == "Y" || UpdateClient == "y")
        {
            UpdateClientInfo(vClients, AccountNumber);
            cout << "Updated Successfly\n";
        }
        else
        {
            cout << "did not Updated this client. \n";
        }
    }
    else
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    }
    UpdateFile(vClients, FileName);
}

///////////////////////////////////////////
/////////////[ Delete Screen ]/////////////

void DeleteClientInfo(vector<stClient> &vClients, string AccountNumber)
{

    for (auto it = vClients.begin(); it != vClients.end();)
    {
        if (it->AccountNumber == AccountNumber)
        {
            it = vClients.erase(it);
            // break;
        }
        else
        {
            ++it;
        }
    }
}

void DeleteScreen(vector<stClient> &vClients, string FileName)
{
    ScreenHeader("Delete Client Screen");

    string AccountNumber = strings::ReadInputString("Enter Account Number You want to delete? ");

    if (IsFoundClient(vClients, AccountNumber))
    {
        // Print Client Info
        FindClientInfo(vClients, AccountNumber);

        // Want to Delete
        string deleteClient = strings::ReadInputString("Do you want to delete this client? Y/N? ");
        if (deleteClient == "Y" || deleteClient == "y")
        {
            DeleteClientInfo(vClients, AccountNumber);
            cout << "Deleted Successfly\n";
        }
        else
        {
            cout << "did not Delete this client. \n";
        }
    }
    else
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    }
    UpdateFile(vClients, FileName);
}

///////////////////////////////////////////
void ExitFromProgram()
{
    // system("cls");
    cout << "Enter to exit...\n";
    system("pause>0");
}
///////////////////////////////////////////

///////////////////////////////////////////
/////////////[ Main Screen ]///////////////

void DisplayMainScreen(enMainScreen ScreenNumber)
{
    string FileName = "clients.txt";
    vector<stClient> vClients = GetCients(FileName);

    switch (ScreenNumber)
    {
    case enMainScreen::ShowClients:
        ClientListScreen(vClients);
        break;
    case enMainScreen::AddClient:
        AddScreen(FileName);
        break;
    case enMainScreen::DeleteClient:
        DeleteScreen(vClients, FileName);
        break;
    case enMainScreen::UpdateClient:
        UpdateScreen(vClients, FileName);
        break;
    case enMainScreen::FindClient:
        FindClientScreen(vClients, FileName);
        break;
    case enMainScreen::Transactions:
        DisplayTransMenue(vClients, FileName);
        break;
    case enMainScreen::Exit:
        ExitFromProgram();
        break;
    default:
        ExitFromProgram();
        break;
    }
    if (ScreenNumber != enMainScreen::Exit)
    {
        string back = strings::ReadInputString("<-- Main Screen Y/N?");
        if (back == "Y" || back == "y")
        {
            system("cls");
            DisplayMainMenue();
        }
        else
        {
            ExitFromProgram();
        }
    }
}

///////////////////////////////////////////
//////////[ Transactions Screen ]//////////

void PrintBalanceInfo(vector<stClient> vClients, stClient Client)
{
    cout << " | " << Client.AccountNumber << Space(3);
    cout << " | " << Client.FullName << Space(2);
    cout << " | " << Client.Balance << endl;
}

void BalancesInfoHeader(short TotalClients)
{
    cout << endl
         << Space(5) << "Balances List (" << TotalClients << ") Client(s).\n";
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << " | Account Num " << Space(2);
    cout << " | Client Name" << Space(2);
    cout << " | Balance";
    cout << endl;
    cout << "---------------------------------------------------------------------------------------------\n";
}

void BalanceListScreen(vector<stClient> vClients)
{
    int TotalBalances = 0;
    BalancesInfoHeader(vClients.size());
    for (stClient Client : vClients)
    {
        TotalBalances += Client.Balance;
        PrintBalanceInfo(vClients, Client);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << Space(4) << "Total Balances = " << TotalBalances;
    cout << endl;
}

///////////////////////////////////////////
int GetBalanceAmount(vector<stClient> &vClients, string AccountNumber)
{
    for (stClient &Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber)
        {
            return Client.Balance;
            break;
        }
    }
    return 0;
}

void UpdateBalanceBy(vector<stClient> &vClients, string AccountNumber, int updateBy)
{
    for (stClient &Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber)
        {
            Client.Balance += updateBy;
            break;
        }
    }
}

void DepositScreen(vector<stClient> &vClients, string FileName)
{
    ScreenHeader("Deposit Screen");
    string AccountNumber = strings::ReadInputString("Please enter AccountNumber? ");
    if (IsFoundClient(vClients, AccountNumber))
    {
        // Print Client Info
        cout << "Your Account details is : \n";
        FindClientInfo(vClients, AccountNumber);

        // Want to update  Balance +Deposit
        int Deposit = nums::ReadPositveNumber("Please enter your Deposit amount : ");
        UpdateBalanceBy(vClients, AccountNumber, Deposit);

        cout << "Your Balance become = " << GetBalanceAmount(vClients, AccountNumber) << endl;
    }
    else
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    }
    UpdateFile(vClients, FileName);
}

void WithdrawScreen(vector<stClient> &vClients, string FileName)
{
    ScreenHeader("Withdraw Screen");
    string AccountNumber = strings::ReadInputString("Please enter AccountNumber? ");
    if (IsFoundClient(vClients, AccountNumber))
    {
        // Print Client Info
        cout << "Your Account details is : \n";
        FindClientInfo(vClients, AccountNumber);

        int TotalBalance = GetBalanceAmount(vClients, AccountNumber);
        int Withdraw = nums::ReadPositveNumber("Please enter your Withdraw amount : ");

        // Want to update  Balance - Withdraw
        if (Withdraw < TotalBalance)
        {
            UpdateBalanceBy(vClients, AccountNumber, (Withdraw * -1));
        }
        else
        {
            cout << "Amount Exceeds the balance, you can withdrow up to : " << TotalBalance << endl;
        }
        int UdatedBalance = GetBalanceAmount(vClients, AccountNumber);

        cout << "Your Balance become = " << UdatedBalance << endl;
    }
    else
    {
        cout << "\nClient with [" << AccountNumber << "] does not exist.\n";
    }
    UpdateFile(vClients, FileName);
}

///////////////////////////////////////////

void DisplayTransScreen(vector<stClient> vClients, string FileName, enTransactionsScreen TransactionsScreen)
{
    switch (TransactionsScreen)
    {
    case enTransactionsScreen::Deposit:
        DepositScreen(vClients, FileName);
        break;
    case enTransactionsScreen::Withdeaw:
        WithdrawScreen(vClients, FileName);
        break;
    case enTransactionsScreen::TotalBalances:
        BalanceListScreen(vClients);
        break;
    case enTransactionsScreen::MainMenue:
        DisplayMainMenue();
        break;
    default:
        DisplayMainMenue();
        break;
    }
}

void DisplayTransMenue(vector<stClient> vClients, string FileName)
{
    system("cls");
    cout << "\n\n==================================================\n";
    cout << Space(2) << "Transactions Menue Screen\n";
    cout << "==================================================\n";
    cout << Space(1) << "[1] Deposit. \n";
    cout << Space(1) << "[2] Withdeaw. \n";
    cout << Space(1) << "[3] Total Balances. \n";
    cout << Space(1) << "[4] Main Menue. \n";
    cout << "==================================================\n";

    enTransactionsScreen UserChoose = ReadEnteredTransChoise("Choose what do you want to do? [1 to 4]? ");
    DisplayTransScreen(vClients, FileName, UserChoose);
    // system("cls");
    system("pause>0");
}

int main()
{
    // Display Main menu and read entered choise 1 2 3 4 5 6
    system("cls");
    DisplayMainMenue();
    return 0;
}