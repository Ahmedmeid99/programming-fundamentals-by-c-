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

stDate ReadDate(string Message)
{
    stDate Date;
    cout << Message << endl;
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

bool DateIsEqual(stDate Date_1, stDate Date_2)
{
    return ((Date_1.Year == Date_2.Year) && (Date_1.Month == Date_2.Month) && (Date_1.Day == Date_2.Day));
}

bool IsWeekEnd(stDate Date)
{
    return (DayName(Date) == "Sat" || DayName(Date) == "Fri");
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

stDate DateAddDays(stDate &Date, short Days)
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

//////////////////////////////

short VacationDays(stDate EndDate, stDate StartDate)
{
    // total days from start date to end date (not weekend days)
    short TotalDays = 0;
    while (!DateIsEqual(EndDate, StartDate))
    {
        // add days to start date unital (start date == end date)
        StartDate = DateAddDays(StartDate, 1);
        if (!IsWeekEnd(StartDate))
        {
            TotalDays++;
        }
        else
            continue;
    };
    return TotalDays;
}

stDate EndDateOfVacation(stDate StartDate, short VacationDays)
{
    short TotalDays = 0;
    stDate EndDate;
    // startDate++ (VacationDays times) then endDate =  startDate;
    for (short i = 0; i < VacationDays; i++)
    {
        if (IsWeekEnd(StartDate))
        {
            i--;
        }

        EndDate = DateAddDays(StartDate, 1);
    }
    return EndDate;
}

bool FirstDateIsAfterSecondDate(stDate LastDate, stDate FirstDate)
{
    if (FirstDate.Year > LastDate.Year)
        return true;

    else if (FirstDate.Year == LastDate.Year)
    {
        if (FirstDate.Month > LastDate.Month)
            return true;

        else if (FirstDate.Month == LastDate.Month)
            return (FirstDate.Day > LastDate.Day);

        else
            return false;
    }
    else
        return false;
}

///////////////////////////

enum enDateSate
{
    FirstDateComeBefore = -1,
    FirstDateEqualSecondDate = 0,
    FirstDateComeAfter = 1
};

enDateSate ComparDate(stDate SecondDate, stDate FirstDate)
{
    if (FirstDateIsAfterSecondDate(SecondDate, FirstDate))
        return enDateSate::FirstDateComeAfter;
    else if (DateIsEqual(SecondDate, FirstDate))
        return enDateSate::FirstDateEqualSecondDate;
    else
        return enDateSate::FirstDateComeBefore;
}

///////////////////////////

bool IsOverlapPeriods(stDate FirstDate_1, stDate SecondDate_1, stDate FirstDate_2, stDate SecondDate_2)
{
    if (ComparDate(FirstDate_2, FirstDate_1) == enDateSate::FirstDateComeAfter)
    {
        if (ComparDate(SecondDate_2, FirstDate_1) == enDateSate::FirstDateComeBefore)
        {
            return true;
        }
    }
    else if (ComparDate(FirstDate_1, FirstDate_2) == enDateSate::FirstDateComeAfter)
    {
        if (ComparDate(SecondDate_1, FirstDate_2) == enDateSate::FirstDateComeBefore)
        {
            return true;
        }
    }

    return false;
}

int main()
{
    // [54] Vacation Days
    cout << VacationDays(ReadDate("end date: "), ReadDate("start date:")) << endl; // 12/11/2023 : 12/12/2023 = 22 day

    // [55] (startDate , Vacation Days) return EndDate
    short VacationDays = nums::ReadPositveNumber("Enter Vacation Days");
    cout << "Enter Start Date of Vacation" << endl;
    FormatDate(EndDateOfVacation(ReadDate("start date: "), VacationDays)); // 22 + 12/11/2023 = 12/12/2023

    // [56] Date_1 is after Date_2
    cout << "is first Date is after second Date? \n"
         << FirstDateIsAfterSecondDate(ReadDate("second date: "), ReadDate("first date: ")) << endl;

    // [57] compar Date Function -1 0 1 (-1 => is before Date) (0 => same Date) ( 1 => is after Date)
    cout << ComparDate(ReadDate("end date: "), ReadDate("start date: ")) << endl;
    cout << "Compare Result= \n";

    // [58] is overlap periods
    stDate StartDate_1 = ReadDate("enter start date [1]: ");
    stDate EendDate_1 = ReadDate("enter end date [1]: ");
    stDate StartDate_2 = ReadDate("enter start date[ 2]: ");
    stDate EendDate_2 = ReadDate("enter end date [2]: ");
    cout << IsOverlapPeriods(StartDate_1, EendDate_1, StartDate_2, EendDate_2) << endl;

    return 0;
}