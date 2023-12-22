#include <iostream>
#include <string>
#include <fstream>
#include <vector>
#include "../00-MyLibrary/strings.cpp"
#include "../00-MyLibrary/numbers.cpp"
using namespace std;

enum enTransactions
{
    Quick_Withdraw = 1,
    Normal_Withdraw = 2,
    Deposit = 3,
    Chick_Balance = 4,
    Logout = 5

};

enum enQuick_Withdraw
{
    Twenty = 1,
    Fifty = 2,
    One_Hundred = 3,
    Two_Hundred = 4,
    Four_Hundred = 5,
    Six_Hundred = 6,
    Eight_Hundred = 7,
    One_Thousand = 8,
    Exit = 9
};

struct stClient
{
    string AccountNumber;
    int PinCode;
    string FullName;
    int Phone;
    int Balance;
};

stClient CurrentClient;

///////////////////////////////////////////
////////////[ Helper Functions ]///////////

enTransactions ReadEnteredTransChoise(string Message)
{
    short EnteredNumber;

    cout << Message;
    cin >> EnteredNumber;

    return (enTransactions)EnteredNumber;
}

enQuick_Withdraw ReadEnteredQuickWithdrawChoise(string Message)
{
    short EnteredNumber;

    cout << Message;
    cin >> EnteredNumber;

    return (enQuick_Withdraw)EnteredNumber;
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

void ScreenHeader(string Title)
{
    cout << "\n----------------------------------------\n";
    cout << Space(1) << Title << endl;
    cout << "----------------------------------------\n";
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

void ExitFromProgram()
{
    // system("cls");
    cout << "Enter to exit...\n";
    system("pause>0");
}

vector<stClient> GetClients(string FileName);

///////////////////////////////////////////
////////////[ Global variabls ]////////////
string FileName = "clients.txt";
vector<stClient> vClients = GetClients(FileName);
stClient Client;

///////////////////////////////////////////
////////[Helper Client functions]//////////

string ClientInfoToLine(stClient Client, string Delime)
{
    string LineOfData = Client.AccountNumber + Delime +
                        to_string(Client.PinCode) + Delime +
                        Client.FullName + Delime +
                        to_string(Client.Phone) + Delime +
                        to_string(Client.Balance);
    return LineOfData;
}

void UpdateClientFile(vector<stClient> &vClients, string FileName)
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

///////////////////////////////////////////

void StoreLineOfDate(string LineOfDate)
{
    fstream File;
    File.open(FileName, ios::out | ios::app);

    if (File.is_open())
    {
        File << LineOfDate << endl;

        File.close();
    }
}

stClient ClientLineToRecord(string Line, stClient &Client)
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

vector<stClient> GetClients(string FileName)
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
            vClients.push_back(ClientLineToRecord(Line, Client));
        }
        File.close();
    }
    return vClients;
}

///////////////////////////////////////////
///////////[ Find Client Screen ]//////////

void ShowMainMenue();

void PrintClientInfo(stClient Client)
{
    cout << "\n--------------------------------------\n";
    cout << " AccountNumber: " << Client.AccountNumber << endl;
    cout << " PinCode      : " << Client.PinCode << endl;
    cout << " FullName     : " << Client.FullName << endl;
    cout << " Phone        : " << Client.Phone << endl;
    cout << " Balance      : " << Client.Balance << endl;
    cout << "--------------------------------------\n";
}

void FindClientInfo(vector<stClient> vClients, string AccountNumber)
{
    for (stClient Client : vClients)
    {
        if (AccountNumber == Client.AccountNumber)
        {
            PrintClientInfo(Client);
            break;
        }
    }
}

bool IsFindClient(vector<stClient> vClients, string AccountNumber, int PinCode)
{
    for (stClient Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber && Client.PinCode == PinCode)
        {
            CurrentClient = Client;
            return true;
        }
    }
    return false;
}

void SetCurrentClient(vector<stClient> vClients, string AccountNumber, int PinCode)
{
    for (stClient Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber && Client.PinCode == PinCode)
        {
            CurrentClient = Client;
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

int UpdateBalanceBy(vector<stClient> &vClients, string AccountNumber, int updateBy)
{
    for (stClient &Client : vClients)
    {
        if (Client.AccountNumber == AccountNumber)
        {
            return Client.Balance += updateBy;
            // Update CurrentClient Balance
            break;
        }
    }
    return 0;
}

//-----------------------------------------//
bool IsValidWithdraw(int Withdraw, int Balance)
{
    if (Withdraw < Balance)
    {
        return true;
    }
    return false;
}

void Quick_WithdrawMenu()
{
    cout << "\n\n==================================================\n";
    cout << Space(2) << "ATM Main Menue Screen\n";
    cout << "==================================================\n";
    cout << Space(1) << "[1] 20            [2] 50\n";
    cout << Space(1) << "[3] 100           [4] 200 \n";
    cout << Space(1) << "[5] 400           [6] 600 \n";
    cout << Space(1) << "[7] 800           [8] 1000 \n";
    cout << Space(1) << "[9] Exit \n";
    cout << "==================================================\n";
}

void ChooseWithdraw(enQuick_Withdraw UserChoose, string AccountNumber)
{
    int Withdraw = 0;
    switch (UserChoose)
    {
    case enQuick_Withdraw::Twenty:
        Withdraw = 20;
        break;
    case enQuick_Withdraw::Fifty:
        Withdraw = 50;
        break;
    case enQuick_Withdraw::One_Hundred:
        Withdraw = 100;
        break;
    case enQuick_Withdraw::Two_Hundred:
        Withdraw = 200;
        break;
    case enQuick_Withdraw::Four_Hundred:
        Withdraw = 400;
        break;
    case enQuick_Withdraw::Six_Hundred:
        Withdraw = 600;
        break;
    case enQuick_Withdraw::Eight_Hundred:
        Withdraw = 800;
        break;
    case enQuick_Withdraw::One_Thousand:
        Withdraw = 1000;
        break;
    default:
        break;
    }
    if (UserChoose != enQuick_Withdraw::Exit)
    {
        if (IsValidWithdraw(Withdraw, CurrentClient.Balance))
        {
            CurrentClient.Balance = UpdateBalanceBy(vClients, AccountNumber, (Withdraw * -1));
            cout << "Now, Your Balance is " << CurrentClient.Balance << endl;
        }
        else
            cout << "Amount Exceeds the balance, you can withdrow up to : " << CurrentClient.Balance << endl;
    }
    else
        ExitFromProgram();
}

void Quick_WithdrawScreen(vector<stClient> &vClients, string AccountNumber)
{
    // Menu
    Quick_WithdrawMenu();

    cout << "Your Balance is " << CurrentClient.Balance << endl;

    enQuick_Withdraw UserChoose = ReadEnteredQuickWithdrawChoise("Choose what do you want to do? [1 to 9]? ");

    ChooseWithdraw(UserChoose, AccountNumber);

    UpdateClientFile(vClients, FileName);
}

void Normal_WithdrawScreen(vector<stClient> &vClients, string AccountNumber)
{
    ScreenHeader("Withdraw Screen");

    cout << "\nYour Balance is : " << CurrentClient.Balance << endl;

    int Withdraw = nums::ReadPositveNumber("Please enter your Withdraw amount : ");

    // Check if Withdraw less than the Balance
    if (Withdraw < CurrentClient.Balance)
    {
        // reset Balance of CurrentClient
        CurrentClient.Balance = UpdateBalanceBy(vClients, AccountNumber, (Withdraw * -1));
    }
    else
    {
        cout << "Amount Exceeds the balance, you can withdrow up to : " << CurrentClient.Balance << endl;
    }

    cout << "Your Balance become = " << CurrentClient.Balance << endl;

    UpdateClientFile(vClients, FileName);
}

void DepositScreen(vector<stClient> &vClients, string AccountNumber)
{
    ScreenHeader("Deposit Screen");

    cout << "\nYour Balance is : " << CurrentClient.Balance << endl;

    int Deposit = nums::ReadPositveNumber("Please enter your Deposit amount : ");

    // reset Balance of CurrentClient
    CurrentClient.Balance = UpdateBalanceBy(vClients, CurrentClient.AccountNumber, Deposit);

    cout << "Your Balance become = " << CurrentClient.Balance << endl;

    UpdateClientFile(vClients, FileName);
}

void Chick_BalanceScreen(vector<stClient> &vClients, string AccountNumber)
{
    ScreenHeader("Check Balance Screen");

    cout << " Your Balance is " << CurrentClient.Balance << endl;
}

void LoginScreen()
{
    do
    {
        system("cls");
        ScreenHeader("Login Screen");

        string AccountNumber = strings::ReadInputString("Enter Your Account Number? ");
        int PinCode = nums::ReadPositveNumber("Enter Your PinCode? ");

        if (IsFindClient(vClients, AccountNumber, PinCode))
        {

            // set CurrentUser
            SetCurrentClient(vClients, AccountNumber, PinCode);
            ShowMainMenue();
            break;
        }
        else
        {
            cout << "\nthis user acount was not found try again ...\n\n";
        }
    } while (true);
}

//-----------------------------------------//
///////////////////////////////////////////
/////////////[ Main Screen ]///////////////

void ChooseMainScreen(enTransactions ScreenNumber)
{
    switch (ScreenNumber)
    {
    case enTransactions::Quick_Withdraw:
        Quick_WithdrawScreen(vClients, CurrentClient.AccountNumber);
        break;
    case enTransactions::Normal_Withdraw:
        Normal_WithdrawScreen(vClients, CurrentClient.AccountNumber);
        break;
    case enTransactions::Deposit:
        DepositScreen(vClients, CurrentClient.AccountNumber);
        break;
    case enTransactions::Chick_Balance:
        Chick_BalanceScreen(vClients, CurrentClient.AccountNumber);
        break;
    case enTransactions::Logout:
        LoginScreen();
        break;
    default:
        break;
    }
    if (ScreenNumber != enTransactions::Logout)
    {
        string back = strings::ReadInputString("<-- ATM main menue Screen Y/N?");
        if (back == "Y" || back == "y")
        {
            system("cls");
            ShowMainMenue();
        }
    }
}

void ShowMainMenue()
{
    cout << "\n\n==================================================\n";
    cout << Space(2) << "ATM Main Menue Screen\n";
    cout << "==================================================\n";
    cout << Space(1) << "[1] Quick withdraw. \n";
    cout << Space(1) << "[2] Normal withdraw. \n";
    cout << Space(1) << "[3] Deposit. \n";
    cout << Space(1) << "[4] Check Balance. \n";
    cout << Space(1) << "[5] Logout. \n";
    cout << "==================================================\n";

    enTransactions UserChoose = ReadEnteredTransChoise("Choose what do you want to do? [1 to 5]? ");
    system("cls");
    ChooseMainScreen(UserChoose);
}

int main()
{
    LoginScreen();

    return 0;
}