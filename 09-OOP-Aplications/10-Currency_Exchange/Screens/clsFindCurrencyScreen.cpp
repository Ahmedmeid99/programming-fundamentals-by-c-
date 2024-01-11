#pragma once
#include <iostream>
#include "clsScreen.cpp"
#include "../clsCurrency.cpp"
class clsFindCurrencyScreen : protected clsScreen
{
public:
    static void ShowFindCurrencyScreen()
    {
        string Title = "      Find Currency Screency";
        _DrawMainScreenHeader(Title);

        enFindOption FindCurrencyOption = _ReadFindCurrencyOption();

        clsCurrency Currency = _FindCurrency(FindCurrencyOption);

        if (!Currency.IsEmpty())
        {
            cout << "\n Currency Found :)\n";
            _Print(Currency);
        }
        else
        {
            cout << "\n Currency Not Found :)\n";
        }
    }
};