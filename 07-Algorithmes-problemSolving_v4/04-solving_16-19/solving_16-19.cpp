#include <iostream>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

stDate ReadDate()
{
    stDate Date;
    Date.Day = nums::ReadPositveNumber("Enter Days: ");
    Date.Month = nums::ReadPositveNumber("Enter Month : ");
    Date.Year = nums::ReadPositveNumber("Enter Year : ");
    return Date;
}

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

stDate IncressDateByOneDay(stDate Date)
{
    return DateAddDays(Date, 1);
}

void FormatDate(stDate Date)
{
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
}

int DateDiffInDays(stDate Date_2, stDate Date_1)
{
    int TotlaDays = 0;
    // deff days
    TotlaDays = CountOfDays(Date_1.Year, Date_1.Month, Date_1.Day) - CountOfDays(Date_2.Year, Date_2.Month, Date_2.Day);

    // deff years
    while (true)
    {
        if (Date_2.Year > Date_1.Year)
        {
            TotlaDays += IsLeapYear(Date_2.Year) ? 366 : 365;
            Date_2.Year--;
        }
        else if (Date_1.Year > Date_2.Year)
        {
            TotlaDays -= (IsLeapYear(Date_1.Year) ? 366 : 365);
            Date_2.Year++;
        }
        else if (Date_1.Year == Date_2.Year)
        {
            break;
        }
    }

    return TotlaDays;
}

short AgeToDays(short Age)
{
    stDate Date_1, Date_2;
    // start Date
    Date_1.Day = 1;
    Date_1.Month = 1;
    Date_1.Year = 2024 - Age; // 2024 (Must be dynamic)

    // Date of Now (Must be dynamic)
    Date_2.Day = 1;
    Date_2.Month = 1;
    Date_2.Year = 2024;
    return DateDiffInDays(Date_2, Date_1);
}

int main()
{
    // [16] incress Date By one Day
    FormatDate(IncressDateByOneDay(ReadDate()));

    // [17] [18]  Deff inDay between Date_1 Date_2
    cout << DateDiffInDays(ReadDate(), ReadDate()) << endl;

    //[19] Your Age In Days
    cout << AgeToDays(25) << endl;

    return 0;
}