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
    ManageUsers = 7,
    Logout = 8
};

enum enTransactionsScreen
{
    Deposit = 1,
    Withdeaw = 2,
    TotalBalances = 3,
    MainMenue = 4

};

enum enMangeUsersScreen
{
    ListUsers = 1,
    AddNewUser = 2,
    DeleteUser = 3,
    UpdateUser = 4,
    FindUser = 5,
    Main_Menue = 6
};

enum enMainMenuePermissions
{
    eAll = -1,
    pListClients = 1,
    pAddClient = 2,
    pDeleteClient = 4,
    pUpdateClient = 8,
    pFindClient = 16,
    pTransactions = 31,
    pMangeUsers = 64
};

struct stClient
{
    string AccountNumber;
    int PinCode;
    string FullName;
    int Phone;
    int Balance;
};

struct stUser
{
    string UserName;
    string Password;
    int Permissions;
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

enMangeUsersScreen ReadEnteredMangeUsersChoise(string Message)
{
    short EnteredNumber;

    cout << Message;
    cin >> EnteredNumber;

    return (enMangeUsersScreen)EnteredNumber;
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

void StoreLineOfDate(string LineOfDate, string FileName)
{
    fstream File;
    File.open(FileName, ios::out | ios::app);

    if (File.is_open())
    {
        File << LineOfDate << endl;

        File.close();
    }
}

stUser CurrentUser;

///////////////////////////////////////////
//////////[Funs Declaration]///////////////
void DisplayTransMenue(vector<stClient> vClients, string FileName);
void DisplayMainScreen(enMainScreen ScreenNumber);
void DisplayMainMenue();
void ManageUsersMenue();

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

void ShowAccessDeniedMessage()
{
    cout << "\n------------------------------------\n";
    cout << "Access Denied, \nYou dont Have Perission To Dothis\n";
    cout << "\n------------------------------------\n";
}

bool CheckAccessPermission(enMainMenuePermissions Permissions)
{
    if (CurrentUser.Permissions == enMainMenuePermissions::eAll)
    {
        return true;
    }

    if ((Permissions & CurrentUser.Permissions) == Permissions)
        return true;
    else
        return false;
}

/******************************************/
//        [ Manage Client Screen ]        //
/******************************************/
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

void AddClientScreen(string FileName)
{
    if (!CheckAccessPermission(enMainMenuePermissions::pAddClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

    string Answer = "Y";
    while (Answer == "Y" || Answer == "y")
    {
        ScreenHeader("Add New Clients Screen");
        stClient Client = ReadClientInfo();
        StoreLineOfDate(ClientInfoToLine(Client, "#//#"), FileName);
        cout << "Client Added Successfully, Do you want to add new account? Y/N?  ";
        cin >> Answer;
    };
}

///////////////////////////////////////////
///////////[ Find Client Screen ]//////////

void PrintClientInfo(stClient Client)
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
            PrintClientInfo(Client);
            break;
        }
    }
}

void FindClientScreen(vector<stClient> vClients, string FileName)
{
    if (!CheckAccessPermission(enMainMenuePermissions::pFindClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

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
    UpdateClientFile(vClients, FileName);
}

///////////////////////////////////////////
///////////[ clients List Screen ]/////////

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
            vClients.push_back(ClientLineToRecord(Line, Client));
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
    if (!CheckAccessPermission(enMainMenuePermissions::pListClients))
    {
        ShowAccessDeniedMessage();
        return;
    }

    ClientsInfoHeader(vClients.size());
    for (stClient Client : vClients)
    {
        PrintClientInfo(Client);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << endl;
}

///////////////////////////////////////////
/////////[ Update Client Screen ]//////////

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

void UpdateClientScreen(vector<stClient> &vClients, string FileName)
{
    if (!CheckAccessPermission(enMainMenuePermissions::pUpdateClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

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
    UpdateClientFile(vClients, FileName);
}

///////////////////////////////////////////
//////////[ Delete Client Screen ]/////////

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

void DeleteClientScreen(vector<stClient> &vClients, string FileName)
{
    if (!CheckAccessPermission(enMainMenuePermissions::pDeleteClient))
    {
        ShowAccessDeniedMessage();
        return;
    }

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
    UpdateClientFile(vClients, FileName);
}

/******************************************/
//        [ Manage User Screen ]          //
/******************************************/

///////////////////////////////////////////
////////[Helper Client functions]//////////

string UserInfoToLine(stUser User, string Delime)
{
    string LineOfData = User.UserName + Delime +
                        User.Password + Delime +
                        to_string(User.Permissions);
    return LineOfData;
}

void UpdateUsersFile(vector<stUser> &vUsers, string FileName)
{
    fstream File;
    File.open(FileName, ios::out);

    if (File.is_open())
    { // for loop (clients each client->line then append this line)
        for (stUser &User : vUsers)
        {
            File << UserInfoToLine(User, "#//#") << endl;
        }

        File.close();
    }
}

///////////////////////////////////////////
//////////////[ Add User]//////////////////

char ReadAnswer(string Message)
{
    char Answer = 'n';
    cout << Message << endl;
    cin >> Answer;
    return Answer;
}

int ReadPermissionToSet()
{
    int permission = 0;
    char Answer = 'n';

    Answer = ReadAnswer("\n Do you want to give full access? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        return -1;
    }

    cout << "\n Do you want to give access to : \n";

    Answer = ReadAnswer("\nShow Client List? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pListClients;
    }

    Answer = ReadAnswer("\nAdd New Clent? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pAddClient;
    }

    Answer = ReadAnswer("\nDelete Clent? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pDeleteClient;
    }

    Answer = ReadAnswer("\nUpdate Clent? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pUpdateClient;
    }

    Answer = ReadAnswer("\nFind Clent? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pFindClient;
    }

    Answer = ReadAnswer("\nDo Transactions? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pTransactions;
    }

    Answer = ReadAnswer("\nMange Users? Y/N ");
    if (Answer == 'y' || Answer == 'Y')
    {
        permission += enMainMenuePermissions::pMangeUsers;
    }
    return permission;
}

stUser ReadUserInfo()
{
    stUser User;
    cout << "Adding New User:\n\n";
    User.UserName = strings::ReadInputString("Enter Your Name? ");
    User.Password = strings::ReadInputString("Enter Your Password? ");
    User.Permissions = ReadPermissionToSet();
    return User;
}

void AddUserScreen(string FileName)
{
    string Answer = "Y";
    while (Answer == "Y" || Answer == "y")
    {
        ScreenHeader("Add New User Screen");
        stUser User = ReadUserInfo();
        StoreLineOfDate(UserInfoToLine(User, "#//#"), FileName);
        cout << "User Added Successfully, Do you want to add new User? Y/N?  ";
        cin >> Answer;
    };
}

///////////////////////////////////////////
///////////////[ Find User Screen ]/////////////

void PrintUserInfo(stUser User)
{
    cout << " | " << User.UserName << Space(2);
    cout << " | " << User.Password << Space(2);
    cout << " | " << User.Permissions << endl;
}

bool IsFoundUser(vector<stUser> vUsers, string UserName)
{
    for (stUser User : vUsers)
    {
        if (User.UserName == UserName)
        {
            return true;
        }
    }
    return false;
}

void FindUserInfo(vector<stUser> vUsers, string UserName)
{
    for (stUser User : vUsers)
    {
        if (User.UserName == UserName)
        {
            PrintUserInfo(User);
            break;
        }
    }
}

void FindUserScreen(vector<stUser> vUsers, string FileName)
{
    ScreenHeader("Find User");
    string UserName = strings::ReadInputString("Enter User Name You want to find? ");

    if (IsFoundUser(vUsers, UserName))
    {
        // Print Client Info
        FindUserInfo(vUsers, UserName);
        cout << "Found Successfly\n";
    }
    else
    {
        cout << "\nUser with [" << UserName << "] does not exist.\n";
    }
    UpdateUsersFile(vUsers, FileName);
}

///////////////////////////////////////////
///////////[ Users List Screen ]/////////

stUser UserLineToRecord(string Line, stUser &User)
{
    // get each word in Line
    vector<string> vUsers = SplitStringOn(Line, "#//#");

    User.UserName = vUsers[0];
    User.Password = vUsers[1];
    User.Permissions = stoi(vUsers[2]);

    return User;
}

vector<stUser> GetUsers(string FileName)
{
    vector<stUser> vUsers;
    stUser User;
    fstream File;
    File.open(FileName, ios::in);

    if (File.is_open())
    {
        string Line;
        while (getline(File, Line))
        {
            vUsers.push_back(UserLineToRecord(Line, User));
        }
        File.close();
    }
    return vUsers;
}

void UsersInfoHeader(short TotalUsers)
{
    cout << endl
         << Space(5) << "User List (" << TotalUsers << ") User(s).\n";
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << " | User Name  ";
    cout << " | Password" << Space(1);
    cout << " | User Access" << Space(2);
    cout << endl;
    cout << "---------------------------------------------------------------------------------------------\n";
}

void UsersListScreen(vector<stUser> vUsers)
{
    UsersInfoHeader(vUsers.size());
    for (stUser User : vUsers)
    {
        PrintUserInfo(User);
    }
    cout << "---------------------------------------------------------------------------------------------\n";
    cout << endl;
}

///////////////////////////////////////////
/////////////[ Update User Screen ]/////////////

stUser ReadUpdatedUserInfo(string UserName)
{
    stUser User;
    cout << "Update Your data ...\n";
    User.UserName = UserName;
    User.Password = strings::ReadInputString("Enter User Password? ");
    User.Permissions = nums::ReadPositveNumber("Enter Permissions? ");
    return User;
}

void UpdateUserInfo(vector<stUser> vUsers, string UserName)
{
    for (stUser &User : vUsers)
    {
        if (User.UserName == UserName)
        {
            User = ReadUpdatedUserInfo(UserName);
            break;
        }
    }
}

void UpdateUserScreen(vector<stUser> vUsers, string FileName)
{
    ScreenHeader("Update User Screen");

    string UserName = strings::ReadInputString("Enter User Name You want to Update? ");

    if (IsFoundUser(vUsers, UserName))
    {
        // Print Client Info
        FindUserInfo(vUsers, UserName);

        // Want to Update
        string UpdateClient = strings::ReadInputString("Do you want to Update this User? Y/N? ");
        if (UpdateClient == "Y" || UpdateClient == "y")
        {
            UpdateUserInfo(vUsers, UserName);
            cout << "Updated Successfly\n";
        }
        else
        {
            cout << "did not Updated this User. \n";
        }
    }
    else
    {
        cout << "\nClient with [" << UserName << "] does not exist.\n";
    }
    UpdateUsersFile(vUsers, FileName);
}

///////////////////////////////////////////
///////////[ Delete User Screen ]//////////

void DeleteUserInfo(vector<stUser> &vUsers, string UserName)
{

    for (auto it = vUsers.begin(); it != vUsers.end();)
    {
        if (it->UserName == UserName)
        {
            it = vUsers.erase(it);
            // break;
        }
        else
        {
            ++it;
        }
    }
}

void DeleteUserScreen(vector<stUser> &vUsers, string FileName)
{
    ScreenHeader("Delete User Screen");

    string UserName = strings::ReadInputString("Enter User Name You want to delete? ");

    if (IsFoundUser(vUsers, UserName))
    {
        // Print Client Info
        FindUserInfo(vUsers, UserName);

        // Want to Delete
        string deleteUser = strings::ReadInputString("Do you want to delete this User? Y/N? ");
        if (deleteUser == "Y" || deleteUser == "y")
        {
            DeleteUserInfo(vUsers, UserName);
            cout << "Deleted Successfly\n";
        }
        else
        {
            cout << "did not Delete this User. \n";
        }
    }
    else
    {
        cout << "\nUser with [" << UserName << "] does not exist.\n";
    }
    UpdateUsersFile(vUsers, FileName);
}

///////////////////////////////////////////
/////////[ ManageUsers Screen ]////////////

void LoginScreen()
{
    string FileName = "users.txt";
    vector<stUser> vUsers = GetUsers(FileName);
    do
    {

        string UserName = strings::ReadInputString("Enter Your Name? ");
        string Password = strings::ReadInputString("Enter Your Password? ");

        for (stUser User : vUsers)
        {
            if (User.UserName == UserName && User.Password == Password)
            {
                system("cls");
                // set CurrentUser
                CurrentUser = User;
                DisplayMainMenue();
                break;
            }
        }
        cout << "\nthis user acount was not found try again ...\n\n";
    } while (true);
}

void Bank()
{
    ScreenHeader("Login Screen");
    LoginScreen();
}

void DisplayManageUsersScreen(enMangeUsersScreen ScreenNumber)
{
    string FileName = "users.txt";
    vector<stUser> vUsers = GetUsers(FileName);

    switch (ScreenNumber)
    {
    case enMangeUsersScreen::ListUsers:
        UsersListScreen(vUsers);
        break;
    case enMangeUsersScreen::AddNewUser:
        AddUserScreen(FileName);
        break;
    case enMangeUsersScreen::DeleteUser:
        DeleteUserScreen(vUsers, FileName);
        break;
    case enMangeUsersScreen::UpdateUser:
        UpdateUserScreen(vUsers, FileName);
        break;
    case enMangeUsersScreen::FindUser:
        FindUserScreen(vUsers, FileName);
        break;
    case enMangeUsersScreen::Main_Menue:
        DisplayMainMenue();
        break;
    default:
        DisplayMainMenue();
        break;
    }
    if (ScreenNumber != enMangeUsersScreen::Main_Menue)
    {
        string back = strings::ReadInputString("<-- Mange Users Screen Y/N?");
        if (back == "Y" || back == "y")
        {
            system("cls");
            ManageUsersMenue();
        }
        else
        {
            ExitFromProgram();
        }
    }
}

void ManageUsersMenue()
{
    if (!CheckAccessPermission(enMainMenuePermissions::pMangeUsers))
    {
        ShowAccessDeniedMessage();
        return;
    }

    system("cls");
    cout << "\n\n==================================================\n";
    cout << Space(2) << "Mange Users Menue Screen\n";
    cout << "==================================================\n";
    cout << Space(1) << "[1] List Users. \n";
    cout << Space(1) << "[2] Add New User. \n";
    cout << Space(1) << "[3] Delete User. \n";
    cout << Space(1) << "[4] Update User. \n";
    cout << Space(1) << "[5] Find User. \n";
    cout << Space(1) << "[6] Main Menue. \n";
    cout << "==================================================\n";

    enMangeUsersScreen UserChoose = ReadEnteredMangeUsersChoise("Choose what do you want to do? [1 to 6]? ");
    DisplayManageUsersScreen(UserChoose);
    // system("cls");
    system("pause>0");
}

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
        AddClientScreen(FileName);
        break;
    case enMainScreen::DeleteClient:
        DeleteClientScreen(vClients, FileName);
        break;
    case enMainScreen::UpdateClient:
        UpdateClientScreen(vClients, FileName);
        break;
    case enMainScreen::FindClient:
        FindClientScreen(vClients, FileName);
        break;
    case enMainScreen::Transactions:
        DisplayTransMenue(vClients, FileName);
        break;
    case enMainScreen::ManageUsers:
        ManageUsersMenue();
        break;
    case enMainScreen::Logout:
        system("cls");
        LoginScreen();
        break;
    default:
        LoginScreen();
        break;
    }
    if (ScreenNumber != enMainScreen::Logout && ScreenNumber != enMainScreen::ManageUsers && ScreenNumber != enMainScreen::Transactions)
    {
        string back = strings::ReadInputString("<-- Main Screen Y/N?");
        if (back == "Y" || back == "y")
        {
            system("cls");
            DisplayMainMenue();
        }
        else
        {
            LoginScreen();
        }
    }
}

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
    cout << Space(1) << "[7] Mange Users. \n";
    cout << Space(1) << "[8] Logout. \n";
    cout << "==================================================\n";

    enMainScreen UserChoose = ReadEnteredMainChoise("Choose what do you want to do? [1 to 8]? ");
    DisplayMainScreen(UserChoose);
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

//-----------------------------------------//

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
    UpdateClientFile(vClients, FileName);
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
    UpdateClientFile(vClients, FileName);
}

//-----------------------------------------//

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

    if (TransactionsScreen != enTransactionsScreen::MainMenue)
    {
        string back = strings::ReadInputString("<-- Transactions Screen Y/N?");
        if (back == "Y" || back == "y")
        {
            system("cls");
            DisplayTransMenue(vClients, FileName);
        }
        else
        {
            system("cls");
            ExitFromProgram();
        }
    }
}

void DisplayTransMenue(vector<stClient> vClients, string FileName)
{
    if (!CheckAccessPermission(enMainMenuePermissions::pTransactions))
    {
        ShowAccessDeniedMessage();
        return;
    }
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

///////////////////////////////////////////

int main()
{

    Bank();

    return 0;
}