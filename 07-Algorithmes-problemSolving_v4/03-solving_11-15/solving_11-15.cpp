#include <iostream>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

bool IsLeapYear(short Year)
{
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}

short CountOfDaysInMonth(short Year, short M)
{
    if (M < 0 || M > 12)
    {
        return 0;
    }
    return (M == 4 || M == 6 || M == 9 || M == 11) ? 30
           : (M != 2)                              ? 31
           : (M == 2 && IsLeapYear(Year))          ? 29
                                                   : 28;
}

int CountOfDays(short Year, short Month, short Day)
{
    // if you know day in month CountOfDays = total days in Months + DayOfDay
    short TotalDays = Day;

    for (short i = 1; i < Month; i++)
    {
        TotalDays += CountOfDaysInMonth(Year, i);
    }
    return TotalDays;
}

void FormatDate(stDate Date)
{
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
}

stDate DateFromDay(short Year, short Days)
{
    stDate Date;
    short MonthDays = 0;
    Date.Month = 1;
    Date.Year = Year;
    short RemenderDays = Days;

    while (true)
    {
        MonthDays = CountOfDaysInMonth(Year, Date.Month);

        if (RemenderDays > MonthDays)
        {
            RemenderDays = RemenderDays - MonthDays; // 59
            Date.Month++;
        }
        else
        {
            Date.Day = RemenderDays;
            break;
        }
    }

    return Date;
}

stDate ReadDate()
{
    stDate Date;
    Date.Day = nums::ReadPositveNumber("Enter Days");
    Date.Month = nums::ReadPositveNumber("Enter Month");
    Date.Year = nums::ReadPositveNumber("Enter Year");
    return Date;
}

stDate DateAddDays(stDate Date, short Days)
{
    // Date Days)=>Date
    short RemainingDays = Days + CountOfDays(Date.Year, Date.Month, Date.Day);
    short MonthDays = 0;
    Date.Month = 1;
    while (true)
    {
        MonthDays = CountOfDaysInMonth(Date.Year, Date.Month);
        if (RemainingDays > MonthDays)
        {
            RemainingDays -= MonthDays;
            Date.Month++;
            if (Date.Month > 12)
            {
                Date.Month = 1;
                Date.Year++;
            }
        }
        else
        {
            Date.Day = RemainingDays;
            break;
        }
    }
    return Date;
}

bool DateIsLess(short Year1, short Month1, short Day1, short Year2, short Month2, short Day2)
{
    if (Year1 <= Year2)
        return (CountOfDays(Year1, Month1, Day1) < CountOfDays(Year2, Month2, Day2));
    else
        return false;
}

bool DateIsEqual(short Year1, short Month1, short Day1, short Year2, short Month2, short Day2)
{
    if (Year1 == Year2)
        return (CountOfDays(Year1, Month1, Day1) == CountOfDays(Year2, Month2, Day2));
    else
        return false;
}

bool LastDayInMonth(short Year, short Month, short MonthDays)
{
    return MonthDays == CountOfDaysInMonth(Year, Month);
}

bool LastMonthInYear(short MonthDays)
{
    return (MonthDays == 12);
}

int main()
{
    // [11] date from day order in year
    cout << CountOfDays(2023, 1, 18) << endl; // 18
    FormatDate(DateFromDay(2023, 18));        // 18/1/2023
    cout << "----------------------------------\n";
    cout << CountOfDays(2023, 12, 31) << endl; // 365
    FormatDate(DateFromDay(2023, 365));        // 31/12/2023
    cout << "----------------------------------\n";

    // [12] enter date and days => new date
    FormatDate(DateAddDays(ReadDate(), 12)); // 24/1/2023

    // [13] Date_1 is less than Date_2
    cout << DateIsLess(2020, 2, 2, 2020, 2, 3) << endl; // 1
    cout << DateIsLess(2022, 2, 2, 2021, 5, 3) << endl; // 0

    // [14]
    cout << DateIsEqual(2022, 2, 2, 2022, 2, 2) << endl; // 1
    cout << DateIsEqual(2022, 2, 2, 2021, 2, 2) << endl; // 0

    // [15]
    cout << LastDayInMonth(2023, 12, 31) << endl; // 1
    cout << LastDayInMonth(2023, 12, 30) << endl; // 0
    cout << LastDayInMonth(2023, 2, 28) << endl;  // 1
    cout << LastDayInMonth(2023, 2, 27) << endl;  // 0
    cout << LastMonthInYear(12) << endl;          // 1
    cout << LastMonthInYear(11) << endl;          // 0
    return 0;
}