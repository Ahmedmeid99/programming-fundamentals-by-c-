#pragma once
#include <iostream>
#include <iomanip>
#include "clsScreen.cpp";
#include "../Helpers/clsInputValidate.cpp";
#include "../clsCurrency.cpp";
class clsListCurrenciesScreen : protected clsScreen
{
private:
    static void _CurrencyTableHeader()
    {
        cout << "\n\t----------------------------------------------------------------------------------------------------\n";
        cout << "\t | " << left << setw(30) << "Country";
        cout << " | " << left << setw(7) << "Code";
        cout << " | " << left << setw(40) << "Name";
        cout << " | " << left << setw(15) << "Rate/(1$)";
        cout << "\n\t----------------------------------------------------------------------------------------------------\n";
    }

    static void _PrintCurrencyTableItem(clsCurrency Currency)
    {
        cout << "\t | " << left << setw(30) << Currency.Country();
        cout << " | " << left << setw(7) << Currency.CurrencyCode();
        cout << " | " << left << setw(40) << Currency.CurrencyName();
        cout << " | " << left << setw(15) << Currency.Rate();
        cout << endl;
    }

public:
    static void ShowListCurrencies()
    {
        // print table of Currency recordes
        vector<clsCurrency> vCurrencies = clsCurrency::GetCurrenciesList();

        string Title = "       List Currencies Screen";
        string SubTitle = "          (" + to_string(vCurrencies.size()) + ") Currency.";

        _DrawMainScreenHeader(Title, SubTitle);

        _CurrencyTableHeader();
        // loop on LoadedData and print each row
        for (clsCurrency &C : vCurrencies)
        {
            _PrintCurrencyTableItem(C);
        }
    }
};