#include <iostream>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

string DayName(short Year, short Month, short Day)
{
    string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

    short a = abs((14 - Month) / 12);
    short y = Year - a;
    short m = Month + (a * 12) - 2;
    short d = (Day + y + abs(y / 4) - abs(y / 100) + abs(y / 400) + abs((31 * m) / 12)) % 7;

    return DaysName[d];
}

string DayName(stDate Date)
{
    string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

    short a = abs((14 - Date.Month) / 12);
    short y = Date.Year - a;
    short m = Date.Month + (a * 12) - 2;
    short d = (Date.Day + y + abs(y / 4) - abs(y / 100) + abs(y / 400) + abs((31 * m) / 12)) % 7;

    return DaysName[d];
}

stDate ReadDate()
{
    stDate Date;
    Date.Day = nums::ReadPositveNumber("Enter Days: ");
    Date.Month = nums::ReadPositveNumber("Enter Month : ");
    Date.Year = nums::ReadPositveNumber("Enter Year : ");
    return Date;
}

void FormatDate(stDate Date)
{
    cout << Date.Day << "/" << Date.Month << "/" << Date.Year << endl;
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

bool LastMonthInYear(short MonthDays)
{
    return (MonthDays == 12);
}

//////////////////////////////

bool IsEndOfWeek(stDate Date)
{
    return (DayName(Date) == "Sat");
}

bool IsWeekEnd(stDate Date)
{
    return (DayName(Date) == "Sat" || DayName(Date) == "Fri");
}

bool IsBusinessDay(stDate Date)
{
    return (DayName(Date) != "Sat" && DayName(Date) != "Fri");
}

short DaysUntilTheEndOfWeek(stDate Date)
{
    short DaysUntilEndOfWeek = 0;
    while (!IsEndOfWeek(Date))
    {
        DaysUntilEndOfWeek++;
        Date.Day++;
    }
    return DaysUntilEndOfWeek;
}

short DaysUntilTheEndOfMonth(stDate Date)
{
    // [1] how many days in month
    // [2] DaysInMonth - Date.Day
    return CountOfDaysInMonth(Date.Year, Date.Month) - Date.Day;
}

short DaysUntilTheEndOfYear(stDate Date)
{
    // [1] how many year in this month
    // [2] DaysInMonth - Date.Day
    // [3] sum months days Until the end month in year + [2]
    short TotalDaysUnitEndOfYear = 0;
    short DaysInCurrentMonth = DaysUntilTheEndOfMonth(Date);
    while (!LastMonthInYear(Date.Month))
    {
        TotalDaysUnitEndOfYear += CountOfDaysInMonth(Date.Year, Date.Month++);
    }
    return TotalDaysUnitEndOfYear + DaysInCurrentMonth;
}

int main()
{
    // [47] : [53]
    stDate Date = ReadDate();
    cout << DayName(Date) << endl;                // Tue
    cout << IsEndOfWeek(Date) << endl;            // 0
    cout << IsWeekEnd(Date) << endl;              // 0
    cout << IsBusinessDay(Date) << endl;          // 1
    cout << DaysUntilTheEndOfWeek(Date) << endl;  // 4
    cout << DaysUntilTheEndOfMonth(Date) << endl; // 19
    cout << DaysUntilTheEndOfYear(Date) << endl;  // 19
    //
    return 0;
}
