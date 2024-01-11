#pragma once
#include <iostream>
#include "clsScreen.cpp"
#include "../Helpers/clsInputValidate.cpp"
#include "../clsCurrency.cpp"
class clsUpdateCurrencyScreen : protected clsScreen
{
private:
    static void _UpdateRate(clsCurrency &Currency)
    {
        char Answer = clsInputValidate::ReadChar("Are you sure you want to updae this rate? Y/N : ");
        if (Answer == 'Y' || Answer == 'y')
        {
            float NewRate = clsInputValidate::ReadFloatNumber("Enter New Rate : ");
            Currency.UpdateRate(NewRate);
            cout << "\n Currency Updated :)\n";
        }
    }

public:
    static void ShowUpdateCurrencyScreen()
    {
        string Title = "      Update Currency Screency";
        _DrawMainScreenHeader(Title);

        enFindOption FindCurrencyOption = _ReadFindCurrencyOption();

        clsCurrency Currency = _FindCurrency(FindCurrencyOption);

        if (!Currency.IsEmpty())
        {
            cout << "\n Currency Found :)\n";
            _Print(Currency);
            _UpdateRate(Currency);
            _Print(Currency);
        }
        else
        {
            cout << "\n Currency Not Found :)\n";
        }
    }
};
