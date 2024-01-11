#pragma once
#include <iostream>
#include <iomanip>
#include "clsScreen.cpp"
#include "../Helpers/clsInputValidate.cpp"
#include "../clsCurrency.cpp"
class clsCurrencyExchangeScreen : protected clsScreen
{
private:
    static void _ExchangeCurrency(clsCurrency Currency_1, clsCurrency Currency_2, float Amount)
    {
        // if Currency_1 or Currency_2 = USD  :- One operation
        float FinalResult = 0;
        if (Currency_1.CurrencyCode() == "USD" || Currency_2.CurrencyCode() == "USD")
        {
            FinalResult = Currency_2.Rate() * Amount;

            cout << Amount << " " << Currency_1.CurrencyCode()
                 << " = " << FinalResult << " " << Currency_2.CurrencyCode() << endl;
        }
        else
        {
            float C1ToDoller;
            C1ToDoller = Currency_1.Rate() * Amount;
            FinalResult = Currency_2.Rate() * C1ToDoller;

            cout << Amount << " " << Currency_1.CurrencyCode()
                 << " = " << C1ToDoller << " USD\n";

            cout << C1ToDoller << " "
                 << "USD"
                 << " = " << FinalResult << " " << Currency_2.CurrencyCode() << endl;
        }
        // else   :- Two operation
    }

public:
    static void ShowCurrencyExchangeScreen()
    {
        string Title = "      Currency Exchange Screency";
        _DrawMainScreenHeader(Title);
        clsCurrency Currency_1, Currency_2;

        enFindOption FindCurrencyOption_1 = _ReadFindCurrencyOption();
        do
        {
            Currency_1 = _FindCurrency(FindCurrencyOption_1);
        } while (Currency_1.IsEmpty());

        enFindOption FindCurrencyOption_2 = _ReadFindCurrencyOption();
        do
        {
            Currency_2 = _FindCurrency(FindCurrencyOption_2);
        } while (Currency_2.IsEmpty());

        float Amount = clsInputValidate::ReadFloatNumber("Enter Amount to Exchange : ");
        _ExchangeCurrency(Currency_1, Currency_2, Amount);
    }
};
