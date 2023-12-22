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

void FormatDate(stDate Date)
{
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
}

bool IsLastDayInMonth(short Year, short Month, short MonthDays)
{
    return MonthDays == CountOfDaysInMonth(Year, Month);
}

////////////////////////////////

stDate SubstracDateByOneDay(stDate &Date)
{
    if (Date.Day == 1)
    {
        if (Date.Month == 1)
        {
            Date.Year--;
            Date.Month = 12;
            Date.Day = CountOfDaysInMonth(Date.Year, Date.Month);
        }
        else
        {
            Date.Month--;
            Date.Day = CountOfDaysInMonth(Date.Year, Date.Month);
        }
    }
    else
    {
        Date.Day--;
    }
    return Date;
}

stDate SubstracDateByXDay(stDate &Date, short Days)
{
    for (short i = 0; i < Days; i++)
    {
        SubstracDateByOneDay(Date);
    }
    return Date;
}

stDate SubstracDateByOneWeek(stDate &Date)
{
    for (short i = 0; i < 7; i++)
    {
        SubstracDateByOneDay(Date);
    }
    return Date;
}

stDate SubstracDateByXWeek(stDate &Date, short Weeks)
{
    for (short i = 0; i < Weeks; i++)
    {
        SubstracDateByOneWeek(Date);
    }
    return Date;
}

stDate SubstracDateByOneMonth(stDate &Date)
{
    if (Date.Month == 1)
    {
        Date.Month = 12;
        Date.Year--;
    }
    else
    {
        Date.Month--;
    }

    // update end of the month
    short NumberOfDayInCurrentMonth = CountOfDaysInMonth(Date.Year, Date.Month);

    if (Date.Day > NumberOfDayInCurrentMonth)
    {
        Date.Day = NumberOfDayInCurrentMonth;
    }

    return Date;
}

stDate SubstracDateByXMonth(stDate &Date, short Months)
{
    for (short i = 0; i < Months; i++)
    {
        SubstracDateByOneMonth(Date);
    }
    return Date;
}

stDate SubstracDateByOneYear(stDate &Date)
{
    Date.Year--;
    return Date;
}

stDate SubstracDateByXYear(stDate &Date, short Years)
{
    Date.Year -= Years;
    return Date;
}

stDate SubstracDateByOneDecade(stDate &Date)
{
    Date.Year -= 10;
    return Date;
}

stDate SubstracDateByXDecade(stDate &Date, short Decade)
{
    Date.Year -= 10 * Decade;
    return Date;
}

stDate SubstracDateByOneCentury(stDate &Date)
{
    Date.Year -= 100;
    return Date;
}

stDate SubstracDateByXCentury(stDate &Date, short Century)
{
    Date.Year -= 100 * Century;
    return Date;
}

stDate SubstracDateByOnemillennium(stDate &Date)
{
    Date.Year -= 1000;
    return Date;
}

int main()
{
    stDate Date = ReadDate();
    FormatDate(SubstracDateByOneDay(Date));
    FormatDate(SubstracDateByXDay(Date, 5));
    FormatDate(SubstracDateByOneWeek(Date));
    FormatDate(SubstracDateByXWeek(Date, 3));
    FormatDate(SubstracDateByOneMonth(Date));
    FormatDate(SubstracDateByXMonth(Date, 10));
    FormatDate(SubstracDateByOneYear(Date));
    FormatDate(SubstracDateByXYear(Date, 10));
    FormatDate(SubstracDateByOneDecade(Date));
    FormatDate(SubstracDateByXDecade(Date, 10));
    FormatDate(SubstracDateByOneCentury(Date));
    FormatDate(SubstracDateByXCentury(Date, 10));
    FormatDate(SubstracDateByOnemillennium(Date));

    return 0;
}