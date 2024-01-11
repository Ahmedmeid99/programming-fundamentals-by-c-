#pragma once
#include <iostream>
#include <vector>
#include <string>
#include <fstream>
#include "Helpers/clsString.cpp";
using namespace std;
class clsCurrency
{
private:
    enum enMode
    {
        EmptyMode = 0,
        UpdateMode = 1
    };
    enMode _Mode;

    string _Country;
    string _CurrencyCode;
    string _CurrencyName;
    float _Rate;

    static string _ConvertCurrencyObjectToLine(clsCurrency CurrencyObject, string Delime = "#//#")
    {
        string LineOfData = "";
        LineOfData += CurrencyObject.Country() + Delime;
        LineOfData += CurrencyObject.CurrencyCode() + Delime;
        LineOfData += CurrencyObject.CurrencyName() + Delime;
        LineOfData += to_string(CurrencyObject.Rate());

        return LineOfData;
    }

    static clsCurrency _ConvertCurrencyLineToObject(string LineOfData)
    {
        // vector of strings of splite line (Slices)
        vector<string> vCurrencyData = clsString::SplitStringOn(LineOfData, "#//#");
        return clsCurrency(enMode::UpdateMode, vCurrencyData[0], vCurrencyData[1], vCurrencyData[2], stof(vCurrencyData[3]));
    }

    static void _SaveCurrencyDataToFile(vector<clsCurrency> &vCurrencies)
    {
        fstream File;
        File.open("Currencies.txt", ios::out); // Write Mode

        if (File.is_open())
        {
            // for loop (Currencys each Currency->line then append this line)
            for (clsCurrency &Currency : vCurrencies)
            {
                File << _ConvertCurrencyObjectToLine(Currency, "#//#") << endl;
            }

            File.close();
        }
    }

    static vector<clsCurrency> _LoadCruuencyDateFromFile()
    {
        /* Function Design */
        /* Loob on each line in file and convert it to clsCurrency and add it to vactor*/
        vector<clsCurrency> vCurrencies;

        fstream File;
        File.open("Currencies.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                clsCurrency Currency = _ConvertCurrencyLineToObject(Line);
                vCurrencies.push_back(Currency);
            }
            File.close();
        }
        return vCurrencies;
    }

    void _Update()
    {
        /* Function Design */
        // parameter: CurrencyName CurrencyCode
        // search about  CurrencyName CurrencyCode and set new object
        // add , Udate this object to vector
        // result   : Vector
        // convert each record to line

        vector<clsCurrency> vCurrencies; // Empty
        vCurrencies = _LoadCruuencyDateFromFile();
        for (clsCurrency &Currency : vCurrencies)
        {
            if (Currency.CurrencyCode() == CurrencyCode())
            {
                Currency = *this;
                break;
            }
        }

        // update File with new data (write mode)
        _SaveCurrencyDataToFile(vCurrencies);
    }

public:
    // Constactor
    clsCurrency(enMode Mode, string Country, string CurrencyCode, string CurrencyName, float Rate)
    {

        _Mode = Mode;
        _Country = Country;
        _CurrencyCode = CurrencyCode;
        _CurrencyName = CurrencyName;
        _Rate = Rate;
    }
    clsCurrency()
    {
        EmptyCurrency();
    }
    // Read Only Mothods
    string Country()
    {
        return _Country;
    }

    string CurrencyCode()
    {
        return _CurrencyCode;
    }

    string CurrencyName()
    {
        return _CurrencyName;
    }

    // Get Rate
    float Rate()
    {
        return _Rate;
    }

    // set Rate
    void SetRate(float Rate)
    {
        _Rate = Rate;
    }

    bool IsEmpty()
    {
        return _Mode == enMode::EmptyMode;
    }

    static clsCurrency EmptyCurrency()
    {
        return clsCurrency(enMode::EmptyMode, "", "", "", 0);
    }

    void UpdateRate(float Rate)
    {
        _Rate = Rate;
        _Update();
    }

    static clsCurrency FindByCode(string CurrencyCode)
    {
        /*Function Design*/
        // loop in each clsCurrency in vector of Currencys

        CurrencyCode = clsString::ToUpperCase(CurrencyCode);

        vector<clsCurrency> vCurrencies;
        fstream File;
        File.open("Currencies.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {

                clsCurrency Currency = _ConvertCurrencyLineToObject(Line);
                if (clsString::ToUpperCase(Currency.CurrencyCode()) == CurrencyCode)
                {
                    File.close();
                    return Currency;
                }
            }
        }
        // else
        return EmptyCurrency();
    }

    static clsCurrency FindByCountry(string Country)
    {
        Country = clsString::ToUpperCase(Country);

        vector<clsCurrency> vCurrencies;
        fstream File;
        File.open("Currencies.txt", ios::in); // read

        if (File.is_open())
        {
            string Line;
            while (getline(File, Line))
            {
                clsCurrency Currency = _ConvertCurrencyLineToObject(Line);
                if (clsString::ToUpperCase(Currency.Country()) == Country)
                {
                    File.close();
                    return Currency;
                }
            }
        }

        // else
        return EmptyCurrency();
    }

    static bool IsCurrencyExist(string CurrencyCode)
    {
        clsCurrency C1 = FindByCode(CurrencyCode);
        return (!C1.IsEmpty());
    }

    static vector<clsCurrency> GetCurrenciesList()
    {
        return _LoadCruuencyDateFromFile();
    }
};