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

bool IsLastDayInMonth(short Year, short Month, short MonthDays)
{
    return MonthDays == CountOfDaysInMonth(Year, Month);
}

////////////////////////////////

stDate AddXdaysToDate(stDate &Date, short Days)
{
    Date = DateAddDays(Date, Days);
    return Date;
}

stDate AddOneWeekToDate(stDate &Date)
{
    short WeekDays = 7;
    Date = DateAddDays(Date, WeekDays);
    return Date;
}

stDate AddXWeeksToDate(stDate &Date, short Weeks)
{
    short WeekDays = 7;
    int TotalDays = WeekDays * Weeks;
    Date = DateAddDays(Date, TotalDays);
    return Date;
}

stDate AddOneMonthToDate(stDate &Date)
{
    if (Date.Month < 12)
    {
        Date.Month += 1;
    }
    else
    {
        Date.Year++;
        Date.Month = 1;
    };

    if (!IsLastDayInMonth(Date.Year, Date.Month, Date.Day))
    {
        Date.Day = CountOfDaysInMonth(Date.Year, Date.Month);
    }

    return Date;
}

stDate AddXMonthToDate(stDate &Date, short Monthes)
{
    int TotalDays = 0;
    for (short i = 1; i <= Monthes; i++)
    {
        TotalDays += CountOfDaysInMonth(Date.Year, Date.Month + i);
    }
    Date = DateAddDays(Date, TotalDays);
    return Date;
}

stDate AddOneYearToDate(stDate &Date)
{
    Date.Year++;
    return Date;
}

stDate AddXYearToDate(stDate &Date, short Years)
{
    Date.Year += Years;
    return Date;
}

stDate AddOneDecadeToDate(stDate &Date)
{
    short DecadeToYears = 10;
    Date.Year += DecadeToYears;
    return Date;
}

stDate AddXDecadeToDate(stDate &Date, short Decade)
{
    short DecadeToYears = 10 * Decade;
    Date.Year += DecadeToYears;
    return Date;
}

stDate AddOneCenturyToDate(stDate &Date)
{
    short CenturyToYears = 100;
    Date.Year += CenturyToYears;
    return Date;
}

stDate AddXCenturyToDate(stDate &Date, short Century)
{
    short CenturyToYears = 100 * Century;
    Date.Year += CenturyToYears;
    return Date;
}

stDate AddOneMillenniumToDate(stDate &Date)
{
    short MillenniumToYears = 1000;
    Date.Year += MillenniumToYears;
    return Date;
}

int main()
{
    stDate Date = ReadDate();

    // [20] : [32] ADD X Days
    FormatDate(AddXdaysToDate(Date, 5));
    FormatDate(AddOneWeekToDate(Date));
    FormatDate(AddXWeeksToDate(Date, 15));
    FormatDate(AddOneMonthToDate(Date));
    FormatDate(AddXMonthToDate(Date, 10));
    FormatDate(AddOneYearToDate(Date));
    FormatDate(AddXYearToDate(Date, 10));
    FormatDate(AddOneDecadeToDate(Date));
    FormatDate(AddXDecadeToDate(Date, 10));
    FormatDate(AddOneCenturyToDate(Date));
    FormatDate(AddXCenturyToDate(Date, 10));
    FormatDate(AddOneMillenniumToDate(Date));

    return 0;
}