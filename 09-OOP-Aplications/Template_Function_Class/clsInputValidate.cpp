#pragma once
#include <iostream>
#include <string>

using namespace std;

class clsInputValidate
{
    // after using template function
    // 160 => 65
public:
    template <typename T>
    static bool IsNumberBetween(T Number, T From, T To)
    {
        return Number >= From && Number <= To;
    }

    template <typename T>
    static T ReadNumber(string Message)
    {
        T Number;
        cout << Message;
        cin >> Number;
        while (cin.fail() || Number < 0)
        {
            cin.clear();
            cin.ignore(10000, '\n');
            cout << "UnValid Number Tray again : \n";
            cin >> Number;
        }
        return Number;
    }

    template <typename T>
    static T ReadNumberBetween(T From, T To, string Message)
    {
        T Num = 0;
        do
        {
            Num = ReadNumber<T>(Message);
        } while (Num < From || Num > To);
        return Num;
    }

    static string ReadString(string Message)
    {
        string InputString;

        cout << Message;
        getline(cin >> ws, InputString);

        return InputString;
    }

    static char ReadChar(string Message)
    {
        char InputChar;

        cout << Message;
        cin >> InputChar;

        return InputChar;
    }

    // static bool IsValidDate(clsDate Date)
    // {
    //     return clsDate::IsValidDate(Date);
    // }

    // static bool IsDateBetween(clsDate FirstDate, clsDate SecondDate, clsDate Date)
    // {
    //     if (!clsDate::IsLessthan(FirstDate, SecondDate))
    //         return clsPeriod::IsDateWithin(FirstDate, SecondDate, Date);
    //     else
    //         return clsPeriod::IsDateWithin(SecondDate, FirstDate, Date);
    // }
};