#include <iostream>
#include <iomanip>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

string DayName(short Year, short Month, short Day)
{
    string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

    short a = abs((14 - Month) / 12);
    short y = Year - a;
    short m = Month + (a * 12) - 2;
    short d = (Day + y + abs(y / 4) - abs(y / 100) + abs(y / 400) + abs((31 * m) / 12)) % 7;

    return DaysName[d];
}

void CalanderHeader(string Month)
{
    cout << "\n_______________" << Month << "_______________\n";
    cout << "Sun  "
         << "Mon  "
         << "Tue  "
         << "Wed  "
         << "Thu  "
         << "Fri  "
         << "Sat  ";
    cout << endl;
}

bool IsLeapYear(int Year)
{
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
 
short CountOfDaysInMonth(short Year, short M)
{
    return (M == 4 || M == 6 || M == 9 || M == 11) ? 30
           : (M != 2)                              ? 31
           : (M == 2 && IsLeapYear(Year))          ? 29
                                                   : 28;
}
 
void DaySpace(short Num)
{
    for (short i = 1; i <= Num; i++)
    {
        cout << " ";
    }
}

short firstSpace(string Days[7], string FirstDay)
{
    for (short i = 0; i <= 6; i++)
    {
        if (FirstDay == Days[i])
        {
            DaySpace(i * 5);
            return i;
        }
    }
}

void MonthCalander(short Year, short Month)
{
    // Calander Header
    string MonthsName[13] = {"", "Jan", "Feb", "Mar", "Apr", "May", "July", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
    CalanderHeader(MonthsName[Month]);

    // First Day in Month
    string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};
    string FirstDayInMonth = DayName(Year, Month, 1); // 2023/12/1 "Fri"

    // How Many Day in entered Month
    short NumberOfDays = CountOfDaysInMonth(Year, Month); // 31

    // Position Where we find day
    short DayPosition = firstSpace(DaysName, FirstDayInMonth);

    // Calander Body
    for (short i = 1; i <= NumberOfDays; i++)
    {
        if ((i + DayPosition) % 7 == 0)
            cout << "" << setw(2) << i << "\n";
        else
            cout << "" << setw(2) << i << "   ";
    }
    cout << endl;
}

void YearCalander(short Year)
{
    for (short m = 1; m <= 12; m++)
    {
        MonthCalander(Year, m);
        // cout << endl;
    }
}

int CountOfDays(short Year, short Month, short Day)
{
    // if you know day in month CountOfDays = total days in Months
    short TotalDays = Day;
    for (short i = 1; i <= Month - 1; i++)
    {
        TotalDays += CountOfDaysInMonth(Year, i);
    }
    return TotalDays;
}

int main()
{
    // [7] day name 6/3/1999
    short Year = nums::ReadPositveNumber("Enter Year : ");
    short Month = nums::ReadPositveNumber("Enter Month : ");
    short Day = nums::ReadPositveNumber("Enter Day : ");
    cout << DayName(Year, Month, Day) << endl;

    // [8] Month Calander
    MonthCalander(2023, 1);

    // [9] Year Calander
    YearCalander(2023);

    // [10] count of days from 1/1 to the endPoint 2023/12/7
    cout << CountOfDays(2023, 12, 7) << endl; // 341

    return 0;
}