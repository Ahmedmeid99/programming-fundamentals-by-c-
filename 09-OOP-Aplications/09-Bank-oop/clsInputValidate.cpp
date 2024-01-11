#pragma once
#include <iostream>
#include <string>
// #include "../00-Date-Library/clsDate.cpp";
// #include "../00-Date-Library/clsPeriod.cpp";
using namespace std;

class clsInputValidate
{
public:
    static bool IsNumberBetween(short Number, short From, short To)
    {
        return Number >= From && Number <= To;
    }

    static bool IsNumberBetween(int Number, int From, int To)
    {
        return Number >= From && Number <= To;
    }

    static bool IsNumberBetween(float Number, float From, float To)
    {
        return Number >= From && Number <= To;
    }

    static bool IsNumberBetween(double Number, double From, double To)
    {
        return Number >= From && Number <= To;
    }

    static unsigned ReadPositveNumber(string Message)
    {

        unsigned Number;
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
    static unsigned ReadIntNumber(string Message)
    {

        int Number;
        cout << Message;
        cin >> Number;
        while (cin.fail())
        {
            cin.clear();
            cin.ignore(10000, '\n');
            cout << "UnValid Number Tray again : \n";
            cin >> Number;
        }
        return Number;
    }

    static float ReadFloatNumber(string Message)
    {

        float Number;
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

    static int ReadIntNumberBetween(int From, int To, string Message)
    {
        int Num = 0;
        do
        {
            Num = ReadPositveNumber(Message);
        } while (Num < From || Num > To);
        return Num;
    }

    static short ReadShortNumber(string Message)
    {

        short Number;
        cout << Message;
        cin >> Number;
        while (cin.fail())
        {
            cin.clear();
            cin.ignore(10000, '\n');
            cout << "UnValid Number Tray again : \n";
            cin >> Number;
        }
        return Number;
    }

    static short ReadShortNumberBetween(short From, short To, string Message)
    {
        short Num = 0;
        do
        {
            Num = ReadShortNumber(Message);
        } while (Num < From || Num > To);
        return Num;
    }

    static double ReadDoubletNumber(string Message)
    {

        double Number;
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

    static double ReadDoubleNumberBetween(double From, double To, string Message)
    {
        double Num = 0;
        do
        {
            Num = ReadDoubletNumber(Message);
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