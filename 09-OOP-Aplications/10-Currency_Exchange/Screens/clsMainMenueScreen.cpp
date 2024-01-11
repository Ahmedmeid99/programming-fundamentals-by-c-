#pragma once
#include <iostream>
#include <iomanip>
#include "clsScreen.cpp";
#include "clsListCurrenciesScreen.cpp";
#include "clsFindCurrencyScreen.cpp";
#include "clsUpdateCurrencyScreen.cpp";
#include "clsCurrencyExchangeScreen.cpp";
#include "../Helpers/clsInputValidate.cpp";

class clsMainMenueScreen : protected clsScreen
{
private:
    enum enMainScreen
    {
        ListCurrencies = 1,
        FindCurrency = 2,
        UpdateRate = 3,
        CurrencyExchange = 4
    };

    static void _ShowListCurrencies()
    {
        clsListCurrenciesScreen::ShowListCurrencies();
    }

    static void _ShowFindCurrency()
    {
        clsFindCurrencyScreen::ShowFindCurrencyScreen();
    }

    static void _ShowUpdateRate()
    {
        clsUpdateCurrencyScreen::ShowUpdateCurrencyScreen();
    }

    static void _ShowCurrencyExchange()
    {
        clsCurrencyExchangeScreen::ShowCurrencyExchangeScreen();
    }

    static void _GoBackToMainMenue()
    {
        cout << setw(37) << left << ""
             << "\n\t press any key to go back to Main Menue ...\n";
        system("pause>0");
        ShowMainMenueScreen();
    }

    static short _ReadMainMenueOption()
    {
        // take input number
        cout << setw(37) << left << "";
        short choice = clsInputValidate::ReadShortNumberBetween(1, 4, "Choose what do you want to do [1 to 4] ?");
        return choice;
    }

    static void _PerformMainMenueOption(enMainScreen MainMenueOpthion)
    {
        switch (MainMenueOpthion)
        {
        case enMainScreen::ListCurrencies:
            system("cls");
            _ShowListCurrencies();
            _GoBackToMainMenue();
            break;
        case enMainScreen::FindCurrency:
            system("cls");
            _ShowFindCurrency();
            _GoBackToMainMenue();
            break;
        case enMainScreen::UpdateRate:
            system("cls");
            _ShowUpdateRate();
            _GoBackToMainMenue();
            break;
        case enMainScreen::CurrencyExchange:
            system("cls");
            _ShowCurrencyExchange();
            _GoBackToMainMenue();
            break;
        }
    }

public:
    static void ShowMainMenueScreen()
    {
        system("cls");
        _DrawMainScreenHeader("\t\tMain Screen");

        cout << setw(37) << left << ""
             << "=======================================\n";
        cout << setw(37) << left << ""
             << "\t\t Currency Exchange Menu\n";
        cout << setw(37) << left << ""
             << "=======================================\n";
        cout << setw(37) << left << ""
             << "\t[1] List Currencies\n";
        cout << setw(37) << left << ""
             << "\t[2] Find Currency\n";
        cout << setw(37) << left << ""
             << "\t[3] Update Rate\n";
        cout << setw(37) << left << ""
             << "\t[4] Currency Exchange\n";
        cout << setw(37) << left << ""
             << "=======================================\n";

        _PerformMainMenueOption((enMainScreen)_ReadMainMenueOption());
    }
};