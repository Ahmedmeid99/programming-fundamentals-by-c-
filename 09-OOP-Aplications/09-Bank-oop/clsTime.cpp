#pragma once
#include <iostream>
#include <string>
using namespace std;

class clsTime
{
private:
    short _Hour;
    short _Minute;
    short _Second;

public:
    clsTime(short Hour, short Minute, short Second)
    {
        _Hour = Hour;
        _Minute = Minute;
        _Second = Second;
    }

    clsTime()
    {
        // Current Time
        time_t t = time(0);
        tm *now = localtime(&t);

        _Hour = now->tm_hour;
        _Minute = now->tm_min;
        _Second = now->tm_sec;
    }
    void SetTime(short Hour, short Minute, short Second)
    {
        _Hour = Hour;
        _Minute = Minute;
        _Second = Second;
    }

    void SetTime(clsTime Time)
    {
        _Hour = Time._Hour;
        _Minute = Time._Minute;
        _Second = Time._Second;
    }

    void SetTime()
    {
        // Current Time
        time_t t = time(0);
        tm *now = localtime(&t);

        _Hour = now->tm_hour;
        _Minute = now->tm_min;
        _Second = now->tm_sec;
    }

    clsTime GetTime()
    {
        return *this;
    }

    static string FormateTime(clsTime Time, string Seperator)
    {
        return to_string(Time._Hour) + Seperator + to_string(Time._Minute) + Seperator + to_string(Time._Second);
    }

    string FormateTime(string Seperator)
    {
        return FormateTime(*this, Seperator);
    }
};