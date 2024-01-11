#pragma once
#include <iostream>
#include "./clsDate.cpp"

using namespace std;

class clsPeriod
{
private:
    clsDate _FirstDate;
    clsDate _SecondDate;

public:
    clsPeriod()
    {
        _FirstDate.SetDateNow();
        _SecondDate.SetDateNow();
    }

    clsPeriod(clsDate FirstDate, clsDate SecondDate)
    {
        _FirstDate = FirstDate;
        _SecondDate = SecondDate;
    }

    void FirstDate(clsDate FirstDate)
    {
        _FirstDate = FirstDate;
    }

    clsDate FirstDate()
    {
        return _FirstDate;
    }

    void SecondDate(clsDate SecondDate)
    {
        _SecondDate = SecondDate;
    }

    clsDate SecondDate()
    {
        return _SecondDate;
    }

    static bool IsOverlapPeriods(clsPeriod Period_1, clsPeriod Period_2)
    {
        if (clsDate::ComparDate(Period_2._SecondDate, Period_1._FirstDate) == clsDate::enDateSate::Before || clsDate::ComparDate(Period_2._FirstDate, Period_1._SecondDate) == clsDate::enDateSate::After)
        {
            return false;
        }
        return true;
    }

    bool IsOverlapPeriods(clsPeriod Period_2)
    {
        return IsOverlapPeriods(*this, Period_2);
    }

    static short PeriodLengthInDays(clsPeriod Period, bool includeEndDay = false)
    {
        short DaysLength = 0;
        while (!clsDate::IsEqual(Period._FirstDate, Period._SecondDate))
        {
            clsDate::DateAddDays(Period._FirstDate, 1);
            DaysLength++;
        }
        return (includeEndDay) ? DaysLength + 1 : DaysLength;
    }

    short PeriodLengthInDays(bool includeEndDay = false)
    {
        return PeriodLengthInDays(*this, includeEndDay);
    }

    static bool IsDateWithin(clsPeriod Period, clsDate Date)
    {
        // date after StartDate and before EndDate
        if (clsDate::ComparDate(Period._FirstDate, Date) == clsDate::enDateSate::After)
        {
            if (clsDate::ComparDate(Period._SecondDate, Date) == clsDate::enDateSate::Before)
            {
                return true;
            }
        }
        return false;
    }
    static bool IsDateWithin(clsDate FirstDate, clsDate SecondDate, clsDate Date)
    {
        // date after StartDate and before EndDate
        if (clsDate::ComparDate(FirstDate, Date) == clsDate::enDateSate::After)
        {
            if (clsDate::ComparDate(SecondDate, Date) == clsDate::enDateSate::Before)
            {
                return true;
            }
        }
        return false;
    }

    bool IsDateWithin(clsDate Date)
    {
        return IsDateWithin(*this, Date);
    }

    static short CountOverlapDays(clsPeriod Period_1, clsPeriod Period_2)
    {
        short TotalCountOfOverlapDays = 0;
        while (!clsDate::IsEqual(Period_2._FirstDate, Period_2._SecondDate))
        {
            if (IsDateWithin(Period_1, Period_2._FirstDate))
            {
                TotalCountOfOverlapDays++;
            }
            clsDate::DateAddDays(Period_2._FirstDate, 1);
        }
        return TotalCountOfOverlapDays;
    }

    short CountOverlapDays(clsPeriod Period_2)
    {
        return CountOverlapDays(*this, Period_2);
    }
    // ////////////////////////////
};