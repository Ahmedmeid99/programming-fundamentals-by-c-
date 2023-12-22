#include <iostream>
#include <string>
#include <vector>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

struct stDate
{
    short Day;
    short Month;
    short Year;
};

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

bool DateIsEqual(stDate Date_1, stDate Date_2)
{
    return ((Date_1.Year == Date_2.Year) && (Date_1.Month == Date_2.Month) && (Date_1.Day == Date_2.Day));
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

enum enDateSate
{
    FirstDateComeBefore = -1,
    FirstDateEqualSecondDate = 0,
    FirstDateComeAfter = 1
};

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

enDateSate ComparDate(stDate SecondDate, stDate FirstDate)
{
    if (FirstDateIsAfterSecondDate(SecondDate, FirstDate))
        return enDateSate::FirstDateComeAfter;
    else if (DateIsEqual(SecondDate, FirstDate))
        return enDateSate::FirstDateEqualSecondDate;
    else
        return enDateSate::FirstDateComeBefore;
}

/////////////////////////////

short PeriodLengthInDays(stDate startDate, stDate EndDate, bool includeEndDay = false)
{
    short DaysLength = 0;
    while (!DateIsEqual(startDate, EndDate))
    {
        startDate = DateAddDays(startDate, 1);
        DaysLength++;
    }
    return (includeEndDay) ? DaysLength + 1 : DaysLength;
}

bool IsDateWithin(stDate StartDate, stDate EndDate, stDate Date)
{
    // date after StartDate and before EndDate
    if (ComparDate(StartDate, Date) == enDateSate::FirstDateComeAfter)
    {
        if (ComparDate(EndDate, Date) == enDateSate::FirstDateComeBefore)
        {
            return true;
        }
    }

    return false;
}

short CountOverlapDays(stDate StartDate_1, stDate EndDate_1, stDate StartDate_2, stDate EndDate_2)
{
    short TotalCountOfOverlapDays = 0;

    while (!DateIsEqual(StartDate_2, EndDate_2))
    {
        if (IsDateWithin(StartDate_1, EndDate_1, StartDate_2))
        {
            TotalCountOfOverlapDays++;
        }
        StartDate_2 = DateAddDays(StartDate_2, 1);
    }

    return TotalCountOfOverlapDays;
}

bool IsValidDate(stDate Date)
{
    if (Date.Month <= 12)
    {
        return Date.Day <= CountOfDaysInMonth(Date.Year, Date.Month);
    }
    return false;
}

/////////////////////////////

string DateToString(stDate Date)
{
    return to_string(Date.Day) + "/" + to_string(Date.Month) + "/" + to_string(Date.Year);
}

vector<string> SplitString(string LineOfstring, char beakPoint)
{
    // 12/2/2020
    string Word = "";
    vector<string> vWords;
    for (short i = 0; i <= LineOfstring.length(); i++)
    {
        if (LineOfstring[i] != beakPoint)
        {
            Word.push_back(LineOfstring[i]);
        }
        else
        {
            if (Word != "")
            {
                vWords.push_back(Word);
                Word.clear();
            }
        }
    }
    vWords.push_back(Word);
    return vWords;
}

stDate StringToDate(string StringDate)
{
    // 22/3/2020 split in "/"
    stDate Date;
    vector<string> vDate = SplitString(StringDate, '/');
    Date.Day = stoi(vDate[0]);
    Date.Month = stoi(vDate[1]);
    Date.Year = stoi(vDate[2]);
    return Date;
}

void PrintDateInCard(stDate Date)
{
    cout << "\n------------------------------------\n";
    cout << "Date Day : " << Date.Day << endl;
    cout << "Date Month : " << Date.Month << endl;
    cout << "Date Year : " << Date.Year << endl;
    cout << "------------------------------------\n";
}

void SwapDate(short &First, short &Second)
{
    short Temp = 0;
    Temp = First;
    First = Second;
    Second = Temp;
}

string FormateDate(stDate Date, string JoinBy, bool Reverse = false)
{
    if (Reverse)
    {
        // swap year day
        SwapDate(Date.Day, Date.Year);
    }
    return to_string(Date.Day) + JoinBy + to_string(Date.Month) + JoinBy + to_string(Date.Year);
}

int main()
{
    // [59] calculate period length in days
    stDate StartDate = ReadDate("enter start Date: ");
    stDate EndDate = ReadDate("enter end Date: ");
    cout << "Period Length In Days = " << PeriodLengthInDays(StartDate, EndDate) << endl;
    cout << "Period Length In Days (include end)= " << PeriodLengthInDays(StartDate, EndDate, true) << endl;

    // [60] is Date within this period or not
    stDate StDate = ReadDate("enter start Date: ");
    stDate EnDate = ReadDate("enter end Date: ");
    stDate Date = ReadDate("chick Date: ");
    string Result = (IsDateWithin(StDate, EnDate, Date)) ? "Yes, Date is within" : "No, Date isn`t within";
    cout << Result << endl;

    // [61] Count of overlap days
    stDate StDate_1 = ReadDate("enter start Date: ");
    stDate EnDate_1 = ReadDate("enter end Date: ");
    stDate StDate_2 = ReadDate("\nenter start Date: ");
    stDate EnDate_2 = ReadDate("enter end Date: ");
    cout << "Count of overlap days : " << CountOverlapDays(StDate_1, EnDate_1, StDate_2, EnDate_2) << endl;

    // [62] Valid Date
    cout << IsValidDate(ReadDate("")) << endl; // 29/2/2020  => true
    cout << IsValidDate(ReadDate("")) << endl; // 29/2/2021  => false

    // [63] string to date && date to string
    cout << DateToString(ReadDate("enter date : ")) << endl; // 12/12/2020
    stDate ReternedDate1 = StringToDate("12/3/2020");
    PrintDateInCard(ReternedDate1);

    // [64]
    cout << FormateDate(ReadDate("enter date : "), "/") << endl;       // 20/1/2020
    cout << FormateDate(ReadDate("enter date : "), "-") << endl;       // 20-1-2020
    cout << FormateDate(ReadDate("enter date : "), " ") << endl;       // 20 1 2020
    cout << FormateDate(ReadDate("enter date : "), "/", true) << endl; // 2020/1/20
    cout << FormateDate(ReadDate("enter date : "), "-", true) << endl; // 2020-1-20

    return 0;
}