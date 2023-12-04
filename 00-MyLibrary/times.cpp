#pragma once

#include <iostream>
#include "numbers.cpp"
using namespace std;
namespace times
{
    // [1]

    float HoursToDays(float NumberOfHours)
    {
        int HoursInDay = 24;
        float Result = NumberOfHours / HoursInDay;
        return Result;
    }

    float HoursToWeeks(float NumberOfHours)
    {
        int HoursInWeek = 24 * 7;
        float Result = NumberOfHours / HoursInWeek;
        return Result;
    }

    float DaysToWeeks(float NumberOfDays)
    {
        int DaysInWeek = 7;
        float Result = NumberOfDays / DaysInWeek;
        return Result;
    }

    void PrintResults(string Message, float Value)
    {
        cout << Message << Value << endl;
    }

    // [2]
    struct stWorkTime
    {
        int Days;
        int Hours;
        int Minutes;
        int Seconds;
    };

    stWorkTime ReadWorkTime()
    {

        stWorkTime WorkTime;
        cout << "************************************************\n";
        cout << "Enter you work tim in Days Hours Minutes Seconds \n";
        WorkTime.Days = nums::ReadPositveNumber("Enter Days : ");
        WorkTime.Hours = nums::ReadPositveNumber("Enter Hours : ");
        WorkTime.Minutes = nums::ReadPositveNumber("Enter Minutes : ");
        WorkTime.Seconds = nums::ReadPositveNumber("Enter Seconds : ");
        cout << "************************************************\n";

        return WorkTime;
    }

    int MinutestoSeconds(int Minutes)
    {
        int SecondInMinutes = 60;

        return Minutes * SecondInMinutes;
    }

    int HourstoSeconds(int Hours)
    {
        int SecondInHours = 60 * 60;

        return Hours * SecondInHours;
    }

    int DaystoSeconds(int Days)
    {
        int SecondInDay = 24 * 60 * 60;

        return Days * SecondInDay;
    }

    int CalcTimeInSecond(stWorkTime WorkTime)
    {
        int MtoSeconds = MinutestoSeconds(WorkTime.Minutes);
        int HtoSeconds = HourstoSeconds(WorkTime.Hours);
        int DtoSeconds = DaystoSeconds(WorkTime.Days);
        int TotalSeconds = WorkTime.Seconds + MtoSeconds + HtoSeconds + DtoSeconds;
        return TotalSeconds;
    }

    // [3]
    enum enDays
    {
        Sat = 1,
        Sun = 2,
        Mo = 3,
        Tue = 4,
        Wes = 5,
        Thu = 6,
        Fr = 7
    };

    enDays NumberToDay(int Number)
    {
        switch (Number)
        {
        case enDays::Sat:
            return enDays::Sat;
            break;
        case enDays::Sun:
            return enDays::Sun;
            break;
        case enDays::Mo:
            return enDays::Mo;
            break;
        case enDays::Tue:
            return enDays::Tue;
            break;
        case enDays::Wes:
            return enDays::Wes;
            break;
        case enDays::Thu:
            return enDays::Thu;
            break;
        case enDays::Fr:
            return enDays::Fr;
            break;

        default:
            return enDays::Sat;
            break;
        }
    }

    string GetDay(enDays Day)
    {
        switch (Day)
        {
        case enDays::Sat:
            return "Sat";
            break;
        case enDays::Sun:
            return "Sun";
            break;
        case enDays::Mo:
            return "Mo";
            break;
        case enDays::Tue:
            return "Tue";
            break;
        case enDays::Wes:
            return "Wes";
            break;
        case enDays::Thu:
            return "Thu";
            break;
        case enDays::Fr:
            return "Fr";
            break;

        default:
            return "Sat";
            break;
        }
    }

}