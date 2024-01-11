#pragma once

#include <iostream>
#include <iomanip>
#include "clsScreen.cpp"
#include "../Helpers/clsInputValidate.cpp"
#include "../clsCurrency.cpp"

using namespace std;

class clsScreen
{
protected:
    enum enFindOption
    {
        ByCode = 1,
        ByCountry = 2
    };

    static void _DrawMainScreenHeader(string Title, string SubTitle = "")
    {
        cout << "\t\t\t\t\t_________________________________\n";
        cout << "\n\t\t\t\t\t" << Title;
        if (SubTitle != "")
        {
            cout << "\n\t\t\t\t\t" << SubTitle;
        }
        cout << "\n\t\t\t\t\t_________________________________\n";
    }

    static void _Print(clsCurrency C)
    {
        cout << "\n______________________________________\n";
        cout << "\n___________[Currency Data]____________\n";
        cout << "______________________________________\n";
        cout << "Country      :" << C.Country() << endl;
        cout << "CurrencyCode :" << C.CurrencyCode() << endl;
        cout << "CurrencyName :" << C.CurrencyName() << endl;
        cout << "Rate(1$)=    :" << C.Rate() << endl;
        cout << "\n______________________________________\n";
    }

    static enFindOption _ReadFindCurrencyOption()
    {
        return (enFindOption)clsInputValidate::ReadShortNumberBetween(1, 2, "Find By [1] Code or [2] Country? : ");
    }

    static string _ReadEnteredString(string FindeType)
    {
        string Message = "Please Enter " + FindeType;
        return clsInputValidate::ReadString(Message);
    }

    static clsCurrency _FindCurrency(enFindOption FindOption)
    {
        switch (FindOption)
        {
        case enFindOption::ByCode:
            return clsCurrency::FindByCode(_ReadEnteredString("CurrencyCode : "));
            break;
        case enFindOption::ByCountry:
            return clsCurrency::FindByCountry(_ReadEnteredString("CurrencyCountry : "));
            break;
        default:
            return clsCurrency::EmptyCurrency();
            break;
        }
    }
};