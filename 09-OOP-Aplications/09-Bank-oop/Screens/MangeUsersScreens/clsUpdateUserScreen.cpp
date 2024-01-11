#pragma once

#include <iostream>
#include <iomanip>
#include "../../clsMainScreen.cpp";
#include "../../clsUser.cpp";
#include "../../clsUtility.cpp";
#include "../../Global.cpp";
#include "../../clsInputValidate.cpp";

using namespace std;

class clsUpdateUserScreen : protected clsMainScreen
{
private:
    static void _Print(clsUser User)
    {
        cout << "User Card\n\n";
        cout << "\t\t\t__________________________________\n";
        cout << "\t\t\tFirstName  : " << User.FirstName() << endl;
        cout << "\t\t\tLastName   : " << User.LastName() << endl;
        cout << "\t\t\tFullName   : " << User.FullName() << endl;
        cout << "\t\t\tEmail      : " << User.Email() << endl;
        cout << "\t\t\tPhone      : " << User.Phone() << endl;
        cout << "\t\t\tUserName   : " << User.UserName() << endl;
        cout << "\t\t\tPassword   : " << User.Password() << endl;
        cout << "\t\t\tPermissions: " << User.Permissions() << endl;
        cout << "\n\t\t\t__________________________________\n";
    }

    static int _ReadPermissionToSet()
    {
        int permission = 0;
        char Answer = 'n';

        Answer = clsInputValidate::ReadChar("\n Do you want to give full access? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            return -1;
        }

        cout << "\n Do you want to give access to : \n";

        Answer = clsInputValidate::ReadChar("\nShow Client List? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pListClients;
        }

        Answer = clsInputValidate::ReadChar("\nAdd New Clent? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pAddClient;
        }

        Answer = clsInputValidate::ReadChar("\nDelete Clent? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pDeleteClient;
        }

        Answer = clsInputValidate::ReadChar("\nUpdate Clent? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pUpdateClient;
        }

        Answer = clsInputValidate::ReadChar("\nFind Clent? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pFindClient;
        }

        Answer = clsInputValidate::ReadChar("\nDo Transactions? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pTransactions;
        }

        Answer = clsInputValidate::ReadChar("\nMange Users? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pMangeUsers;
        }

        Answer = clsInputValidate::ReadChar("\nShow Users Login List? Y/N ");
        if (Answer == 'y' || Answer == 'Y')
        {
            permission += clsUser::enPermissions::pLoginRegister;
        }

        return permission;
    }

    static void _ReadUserInfo(clsUser &User)
    {
        // Update object info by referance
        User.SetFirstName(clsInputValidate::ReadString("Enter User First Name? "));
        User.SetLastName(clsInputValidate::ReadString("Enter User Last Name? "));
        User.SetEmail(clsInputValidate::ReadString("Enter User Email? "));
        User.SetPhone(clsInputValidate::ReadString("Enter User Phone? "));
        User.SetUserName(clsInputValidate::ReadString("Enter User Name? "));

        string Password = clsInputValidate::ReadString("Enter User Password? ");
        string EnPassord = clsUtility::EncryptEnPassWard(Password, KEY);
        User.SetPassword(EnPassord);

        User.SetPermissions(_ReadPermissionToSet());
    }

public:
    static void ShowUpdateUserScreen()
    {
        _DrawMainScreenHeader("\tUpdate User Screen");

        string UserName = clsInputValidate::ReadString("Enter User Name? ");

        while (!clsUser::IsUserExist(UserName))
        {
            UserName = clsInputValidate::ReadString("Not Exist, Enter User Name again? ");
        }

        // Get User and set update mode
        clsUser User = clsUser::Find(UserName);

        // Print User
        _Print(User);

        _ReadUserInfo(User);

        clsUser::enSaveResults SaveResults;

        // save file after updating and return status
        SaveResults = User.Save();

        switch (SaveResults)
        {
        case clsUser::svSucceded:
            cout << "Account updated Successfuly :-)";
            break;
        case clsUser::svFaildEmbtyObject:
            cout << "Error account was not saved because it`s Empty ";
            break;
        }
    }
};