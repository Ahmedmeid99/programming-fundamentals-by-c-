#pragma once
#include <iostream>
using namespace std;

class clsTime
{
private:
    struct stTime
    {
        short Hour;
        short Minute;
        short Second;
    };
    stTime _Time;

public:
    void SetTime(short Hour, short Minute, short Second)
    {
        _Time.Hour = Hour;
        _Time.Minute = Minute;
        _Time.Second = Second;
    }

    void SetTime(stTime Time)
    {
        _Time.Hour = Time.Hour;
        _Time.Minute = Time.Minute;
        _Time.Second = Time.Second;
    }

    void SetTime()
    {
        // Current Time
        time_t t = time(0);
        tm *now = localtime(&t);

        _Time.Hour = now->tm_hour;
        _Time.Minute = now->tm_min;
        _Time.Second = now->tm_sec;
    }

    stTime GetTime()
    {
        return _Time;
    }
};