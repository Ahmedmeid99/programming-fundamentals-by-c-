#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "clsPerson.cpp";
#include "clsBankClient.cpp";
#include "clasDate.cpp";
#include "clsTime.cpp";
#include "clsString.cpp";
#include "clsInputValidate.cpp";

using namespace std;

class clsUser : public clsPerson
{
public:
    struct stLoginRegister
    {
        string _Date_Time;
        string _UserName;
        string _Password;
        int _Permissions;
    };

    struct stTransferLog
    {
        string _Date_Time = "";
        string _UserName;
        string _CTransferFrom;
        string _CTransferTo;
        float _SBalance;
        float _DBalance;
        float _Amount;
    };

private:
    enum enMode
    {
        EmptyMode = 0,
        UpdateMode = 1,
        AddNewMode = 2,
    };

    enMode _Mode;
    string _UserName;
    string _Password;
    int _Permissions;

    bool _MarkForDelete = false;

    static string _ConvertUserObjectToLine(clsUser User, string Delime = "#//#")
    {
        string LineOfData = User.FirstName() + Delime +
                            User.LastName() + Delime +
                            User.Email() + Delime +
                            User.Phone() + Delime +
                            User.UserName() + Delime +
                            User.Password() + Delime + to_string(User.Permissions());
        return LineOfData;
    }

    static string _ConvertUserLoginToLine(clsUser User, string Delime = "#//#")
    {
        string Date_Time = clasDate::FormateDate(clasDate(), "/") + " - " + clsTime::FormateTime(clsTime(), ":");
        string LineOfData = Date_Time + Delime +
                            User.UserName() + Delime +
                            User.Password() + Delime + to_string(User.Permissions());
        return LineOfData;
    }

    static string _ConvertTransferLogToLine(stTransferLog TransferLog, string Delime = "#//#")
    {
        string Date_Time = clasDate::FormateDate(clasDate(), "/") + " - " + clsTime::FormateTime(clsTime(), ":");

        string LineOfData = Date_Time + Delime +
                            TransferLog._CTransferFrom + Delime +
                            TransferLog._CTransferTo + Delime +
                            to_string(TransferLog._Amount) + Delime +
                            to_string(TransferLog._SBalance) + Delime +
                            to_string(TransferLog._DBalance) + Delime +
                            TransferLog._UserName;
        return LineOfData;
    }

    static clsUser _ConvertLinetoUserObject(string Line)
    {
        // get each word in Line
        vector<string> vUser = clsString::SplitStringOn(Line, "#//#");
        return clsUser(enMode::UpdateMode, vUser[0], vUser[1], vUser[2], vUser[3], vUser[4], vUser[5], stoi(vUser[6]));
    }

    static stLoginRegister _ConvertLinetoUserStruct(string Line)
    {
        // get each word in Line
        vector<string> vUserLoginInfo = clsString::SplitStringOn(Line, "#//#");
        stLoginRegister LoginRegister;
        LoginRegister._Date_Time = vUserLoginInfo[0];
        LoginRegister._UserName = vUserLoginInfo[1];
        LoginRegister._Password = vUserLoginInfo[2];
        LoginRegister._Permissions = stoi(vUserLoginInfo[3]);

        return LoginRegister;
    }

    static stTransferLog _ConvertLinetoTransferStruct(string Line)
    {
        // get each word in Line
        vector<string> vTransferInfo = clsString::SplitStringOn(Line, "#//#");
        stTransferLog LoginRegister;
        LoginRegister._Date_Time = vTransferInfo[0];
        LoginRegister._CTransferFrom = vTransferInfo[1];
        LoginRegister._CTransferTo = vTransferInfo[2];
        LoginRegister._Amount = stof(vTransferInfo[3]);
        LoginRegister._SBalance = stof(vTransferInfo[4]);
        LoginRegister._DBalance = stof(vTransferInfo[5]);
        LoginRegister._UserName = vTransferInfo[6];

        return LoginRegister;
    }

    static clsUser _GetEmptyUserObject()
    {
        return clsUser(enMode::EmptyMode, "", "", "", "", "", "", 0);
    }

    static void _SaveUsersDatetoFile(vector<clsUser> &vUsers)
    {
        fstream File;
        File.open("DataBase/users.txt", ios::out);

        if (File.is_open())
        {
            // for loop (Users each User->line then append this line)
            for (clsUser &User : vUsers)
            {
                if (User.MarkForDelete() == true)
                    continue;
                else
                    File << _ConvertUserObjectToLine(User, "#//#") << endl;
            }

            File.close();
        }
    }

    static void _AddDataLineToFile(string LineOfDate)
    {
        fstream File;
        File.open("DataBase/users.txt", ios::out | ios::app);

        if (File.is_open())
        {
            File << LineOfDate << endl;

            File.close();
        }
    }

    static vector<clsUser> _LoadUsersDataFromFile()
    {
        vector<clsUser> vUsers;

        fstream File;
        File.open("DataBase/users.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                clsUser User = _ConvertLinetoUserObject(Line);
                vUsers.push_back(User);
            }
            File.close();
        }
        return vUsers;
    }

    static vector<stLoginRegister> _LoadUsersLoginFromFile()
    {

        vector<stLoginRegister> UsersLogin;

        fstream File;
        File.open("DataBase/LoginRegister.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                stLoginRegister User = _ConvertLinetoUserStruct(Line);
                UsersLogin.push_back(User);
            }
            File.close();
        }
        return UsersLogin;
    }

    static vector<stTransferLog> _LoadTransferLogFromFile()
    {

        vector<stTransferLog> TransferLog;

        fstream File;
        File.open("DataBase/TransferLog.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                stTransferLog User = _ConvertLinetoTransferStruct(Line);
                TransferLog.push_back(User);
            }
            File.close();
        }
        return TransferLog;
    }

    static void _RegisterLogin(clsUser CurrentUser)
    {
        fstream File;
        string DataLine = _ConvertUserLoginToLine(CurrentUser, "#//#");

        File.open("DataBase/LoginRegister.txt", ios::out | ios::app); // creat or append

        if (File.is_open())
        {
            File << DataLine << endl;

            File.close();
        }
    }

    static void _RegisterTransferLog(stTransferLog TransferLog)
    {
        fstream File;
        string DataLine = _ConvertTransferLogToLine(TransferLog, "#//#");

        File.open("DataBase/TransferLog.txt", ios::out | ios::app); // creat or append

        if (File.is_open())
        {
            File << DataLine << endl;

            File.close();
        }
    }

    void _Update()
    {
        vector<clsUser> _vUsers;
        _vUsers = _LoadUsersDataFromFile();

        for (clsUser &C : _vUsers)
        {
            if (C.UserName() == UserName() && C.Password() == Password())
            {
                C = *this;
                break;
            }
        }

        // save file after updating
        _SaveUsersDatetoFile(_vUsers);
    }

    void _AddNew()
    {
        _AddDataLineToFile(_ConvertUserObjectToLine(*this, "#//#"));
    }

    void _Delete()
    {
        // [2] Delete mark
        vector<clsUser> _vUsers;
        _vUsers = _LoadUsersDataFromFile();

        for (clsUser &C : _vUsers)
        {
            if (C.UserName() == UserName() && C.Password() == Password())
            {
                C._MarkForDelete = true;
                break;
            }
        }

        // save file after updating
        _SaveUsersDatetoFile(_vUsers);
        *this = _GetEmptyUserObject();
    }

public:
    clsUser(enMode Mode, string FirstName, string LastName, string Email,
            string Phone, string UserName, string Password, int Permissions)
        : clsPerson(FirstName, LastName, Email, Phone)
    {
        _Mode = Mode;
        _UserName = UserName;
        _Password = Password;
        _Permissions = Permissions;
    }

    bool IsEmpty()
    {
        return (_Mode == enMode::EmptyMode);
    }

    // read only
    bool MarkForDelete()
    {
        return _MarkForDelete;
    }

    void SetUserName(string UserName)
    {
        _UserName = UserName;
    }

    string UserName()
    {
        return _UserName;
    }

    void SetPassword(string Password)
    {
        _Password = Password;
    }

    string Password()
    {
        return _Password;
    }

    void SetPermissions(int Permissions)
    {
        _Permissions = Permissions;
    }

    int Permissions()
    {
        return _Permissions;
    }

    // find User in file
    static clsUser Find(string UserName)
    {
        vector<clsUser> vUsers;

        fstream File;
        File.open("DataBase/users.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                // ConvertLineTO Object to check
                clsUser User = _ConvertLinetoUserObject(Line);
                if (User._UserName == UserName)
                {
                    File.close();
                    return User;
                }
                vUsers.push_back(User); // ??
            }

            File.close();
        }
        return _GetEmptyUserObject();
    }

    static clsUser Find(string UserName, string Password)
    {
        vector<clsUser> vUsers;

        fstream File;
        File.open("DataBase/users.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                // ConvertLineTO Object to check
                clsUser User = _ConvertLinetoUserObject(Line);
                if (User._UserName == UserName && User._Password == Password)
                {
                    File.close();
                    return User;
                }
                vUsers.push_back(User); // ??
            }

            File.close();
        }
        return _GetEmptyUserObject();
    }

    static bool IsUserExist(string UserName)
    {
        clsUser User_1 = clsUser::Find(UserName);
        return (!User_1.IsEmpty());
    }

    static bool IsUserExist(string UserName, string Password)
    {
        clsUser User_1 = clsUser::Find(UserName, Password);
        return (!User_1.IsEmpty());
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
            // Add New User to file
            if (IsUserExist(_UserName))
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

    static clsUser GetAddNewUser(string UserName)
    {
        // set Add mode
        return clsUser(enMode::AddNewMode, "", "", "", "", UserName, "", 0);
    }

    static clsUser GetAddNewUser(string UserName, string Password)
    {
        // set Add mode
        return clsUser(enMode::AddNewMode, "", "", "", "", UserName, Password, 0);
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

    static vector<clsUser> GetUsers()
    {
        return _LoadUsersDataFromFile();
    }

    enum enPermissions
    {
        eAll = -1,
        pListClients = 1,
        pAddClient = 2,
        pDeleteClient = 4,
        pUpdateClient = 8,
        pFindClient = 16,
        pTransactions = 31,
        pMangeUsers = 64,
        pLoginRegister = 128
    };

    bool CheckAccessPermission(enPermissions Permissions)
    {
        // CheckAccessPermission if true Show Screen else Show not access messsage
        if (this->Permissions() == enPermissions::eAll)
            return true;

        if ((Permissions & this->Permissions()) == Permissions)
            return true;
        else
            return false;
    }

    static void RegisterLogin(clsUser CurrentUser)
    {
        _RegisterLogin(CurrentUser);
    }

    void RegisterLogin()
    {
        RegisterLogin(*this);
    }

    static void RegisterTransferLog(stTransferLog TransferLog)
    {
        _RegisterTransferLog(TransferLog);
    }

    static vector<stLoginRegister> GetUsersLogin()
    {
        return _LoadUsersLoginFromFile();
    }

    static vector<stTransferLog> GetTransferLog()
    {
        return _LoadTransferLogFromFile();
    }
};