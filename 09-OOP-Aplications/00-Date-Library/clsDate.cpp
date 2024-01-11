#pragma once
#include <iostream>
#include <string>
#include <vector>
#include <iomanip>
#include <ctime>
#include "../001-String-Library/clsString.cpp";

using namespace std;

class clsDate
{

private:
    clsString String;

    /////////////////////////
    short _Day;
    short _Month;
    short _Year;

    static void SwapDate(short &First, short &Second)
    {
        short Temp = 0;
        Temp = First;
        First = Second;
        Second = Temp;
    }

    static void DaySpace(short Num)
    {
        for (short i = 1; i <= Num; i++)
        {
            cout << " ";
        }
    }

    static short firstSpace(string Days[7], string FirstDay)
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

    static void CalanderHeader(short Month)
    {
        string MonthsName[13] = {"", "Jan", "Feb", "Mar", "Apr", "May", "July", "July", "Aug", "Sept", "Oct", "Nov", "Dec"};
        cout << "\n_______________" << MonthsName[Month] << "_______________\n";
        cout << "Sun  "
             << "Mon  "
             << "Tue  "
             << "Wed  "
             << "Thu  "
             << "Fri  "
             << "Sat  ";
        cout << endl;
    }

    static int ReadPositveNumber(string Message)
    {

        int Number;
        cout << Message;
        cin >> Number;
        while (cin.fail() || Number < 0)
        {
            cin.clear();
            cin.ignore(10000, '\n');
            cout << "UnValid Tray again : \n";
            cin >> Number;
        }
        return Number;
    }

public:
    enum enDateSate
    {
        Before = -1,
        Equal = 0,
        After = 1
    };
    // polymorphisem constractor
    clsDate()
    {
        // Current Date
        time_t t = time(0);
        tm *now = localtime(&t);

        _Year = now->tm_year + 1900; // 2023
        _Month = now->tm_mon + 1;    // 11 the month Nov
        _Day = now->tm_mday;         // 26 day at month
    }

    clsDate(string StringDate)
    {
        // SetDate from string to date
        vector<string> vDate = String.SplitStringOn(StringDate, "/");
        _Day = stoi(vDate[0]);
        _Month = stoi(vDate[1]);
        _Year = stoi(vDate[2]);
    }

    clsDate(short Day, short Month, short Year)
    {
        _Day = Day;
        _Month = Month;
        _Year = Year;
    }

    clsDate(int Days, short Year)
    {
        ////
    }

    //////////////////////////////////

    void SetDay(short Day)
    {
        _Day = Day;
    }

    short Day()
    {
        return _Day;
    }

    void SetMonth(short Month)
    {
        _Month = Month;
    }

    short Month()
    {
        return _Month;
    }

    void SetYear(short Year)
    {
        _Year = Year;
    }

    short Year()
    {
        return _Year;
    }

    static void SetDateNow(clsDate &Date)
    {
        // Current Date
        time_t t = time(0);
        tm *now = localtime(&t);

        Date._Year = now->tm_year + 1900; // 2023
        Date._Month = now->tm_mon + 1;    // 11 the month Nov
        Date._Day = now->tm_mday;         // 26 day at month
    }

    void SetDateNow()
    {
        SetDateNow(*this);
    }

    static string Print(clsDate Date)
    {
        return to_string(Date._Day) + "/" + to_string(Date._Month) + "/" + to_string(Date._Year);
    }

    string Print()
    {
        return Print(*this);
    }

    static bool IsLeapYear(short Year)
    {
        return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
    }

    bool IsLeapYear()
    {
        return IsLeapYear(_Year);
    }

    static short CountOfDaysInMonth(short Year, short M)
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

    short CountOfDaysInMonth()
    {
        return CountOfDaysInMonth(_Year, _Month);
    }

    static bool IsValidDate(clsDate Date)
    {
        if (Date._Month <= 12)
        {
            return Date._Day <= CountOfDaysInMonth(Date._Year, Date._Month);
        }
        return false;
    }

    bool IsValidDate()
    {
        return IsValidDate(*this);
    }

    static string FormateDate(clsDate Date, string JoinBy, bool Reverse = false)
    {
        if (Reverse)
        {
            // swap year day
            SwapDate(Date._Day, Date._Year);
        }
        return to_string(Date._Day) + JoinBy + to_string(Date._Month) + JoinBy + to_string(Date._Year);
    }

    string FormateDate(string JoinBy, bool Reverse = false)
    {
        return FormateDate(*this, JoinBy, Reverse);
    }
    ////////////////////

    ////////////////////

    static short NumberOfDaysInYaer(short Year)
    {
        return IsLeapYear(Year) ? 366 : 365;
    }

    short NumberOfDaysInYaer()
    {
        return NumberOfDaysInYaer(_Year);
    }

    static short NumberOfHoursInYaer(short Year)
    {
        return NumberOfDaysInYaer(Year) * 24;
    }

    int NumberOfHoursInYaer()
    {
        return NumberOfHoursInYaer(_Year);
    }

    static int NumberOfMinutesInYaer(short Year)
    {
        return NumberOfHoursInYaer(Year) * 60;
    }

    int NumberOfMinutesInYaer()
    {
        return NumberOfMinutesInYaer(_Year);
    }

    static int NumberOfSecondsInYaer(short Year)
    {
        return NumberOfMinutesInYaer(Year) * 60;
    }

    int NumberOfSecondsInYaer()
    {
        return NumberOfSecondsInYaer(_Year);
    }

    void PrintYearInfo()
    {
        cout << "Number of Days in Year is : " << NumberOfDaysInYaer() << " Days" << endl;
        cout << "Number of Hours in Year is : " << NumberOfHoursInYaer() << " Hours" << endl;
        cout << "Number of Minutes in Year is : " << NumberOfMinutesInYaer() << " Minutes" << endl;
        cout << "Number of Seconds in Year is : " << NumberOfSecondsInYaer() << " Seconds" << endl;
    }

    static short CountDaysInMonth(short Year, short Month)
    {
        return (Month == 4 || Month == 6 || Month == 9 || Month == 11) ? 30
               : (Month != 2)                                          ? 31
               : (Month == 2 && IsLeapYear(Year))                      ? 29
                                                                       : 28;
    }

    short CountDaysInMonth()
    {
        return CountDaysInMonth(_Year, _Month);
    }

    static int NumberOfHoursInMonth(short CountDaysInMonth)
    {
        return CountDaysInMonth * 24;
    }

    int NumberOfHoursInMonth()
    {
        return NumberOfHoursInMonth(_Day) * 24;
    }

    int NumberOfMinutesInMonth()
    {
        return NumberOfHoursInMonth() * 60;
    }

    int NumberOfSecondsInMonth()
    {
        return NumberOfMinutesInMonth() * 60;
    }

    void MonthInfo()
    {
        cout << "Date : " << _Month << "/" << _Year << endl;
        cout << "Number of Days in Month is : " << CountDaysInMonth() << " Days" << endl;
        cout << "Number of Hours in Month is : " << NumberOfHoursInMonth() << " Hours" << endl;
        cout << "Number of Minutes in Month is : " << NumberOfMinutesInMonth() << " Minutes" << endl;
        cout << "Number of Seconds in Month is : " << NumberOfSecondsInMonth() << " Seconds" << endl;
    }

    static string DayName(clsDate Date)
    {
        string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

        short a = abs((14 - Date._Month) / 12);
        short y = Date._Year - a;
        short m = Date._Month + (a * 12) - 2;
        short d = (Date._Day + y + abs(y / 4) - abs(y / 100) + abs(y / 400) + abs((31 * m) / 12)) % 7;

        return DaysName[d];
    }

    static string DayName(short Day, short Month, short Year)
    {
        string DaysName[7] = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"};

        short a = abs((14 - Month) / 12);
        short y = Year - a;
        short m = Month + (a * 12) - 2;
        short d = (Day + y + abs(y / 4) - abs(y / 100) + abs(y / 400) + abs((31 * m) / 12)) % 7;

        return DaysName[d];
    }

    string DayName()
    {
        return DayName(*this);
    }

    static void MonthCalander(short Year, short Month)
    {
        // Calander Header
        CalanderHeader(Month);

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

    void MonthCalander()
    {
        MonthCalander(_Year, _Month);
    }

    static void YearCalander(short Year)
    {
        for (short m = 1; m <= 12; m++)
        {
            MonthCalander(Year, m);
            // cout << endl;
        }
    }

    void YearCalander()
    {
        YearCalander(_Year);
    }

    static int CountOfDays(clsDate Date)
    {
        // if you know day in month CountOfDays = total days in Months
        short TotalDays = Date._Day;
        for (short i = 1; i <= Date._Month - 1; i++)
        {
            TotalDays += CountDaysInMonth(Date._Year, i);
        }
        return TotalDays;
    }

    int CountOfDays()
    {
        return CountOfDays(*this);
    }

    void ReadDate(string Message)
    {
        cout << Message << endl;
        _Day = ReadPositveNumber("Enter Days: ");
        _Month = ReadPositveNumber("Enter Month: ");
        _Year = ReadPositveNumber("Enter Year: ");
    }

    static void DateAddDays(clsDate &Date, int Days)
    {
        // Date Days)=>Date
        int RemainingDays = Days + CountOfDays(Date);
        short MonthDays = 0;
        Date._Month = 1;
        while (true)
        {
            MonthDays = CountOfDaysInMonth(Date._Year, Date._Month);
            if (RemainingDays > MonthDays)
            {
                RemainingDays -= MonthDays;
                Date._Month++;
                if (Date._Month > 12)
                {
                    Date._Month = 1;
                    Date._Year++;
                }
            }
            else
            {
                Date._Day = RemainingDays;
                break;
            }
        }
    }
    // add days to current date
    void DateAddDays(int Days)
    {
        DateAddDays(*this, Days);
    }

    static bool IsLessthan(clsDate Date_1, clsDate Date_2)
    {
        if (Date_1._Year <= Date_2._Year)
            return (CountOfDays(Date_1) < CountOfDays(Date_2));
        else
            return false;
    }

    bool IsLess(clsDate Date_2)
    {
        return IsLessthan(*this, Date_2);
    }

    static bool IsEqual(clsDate Date_1, clsDate Date_2)
    {
        if (Date_1._Year == Date_2._Year)
            return (CountOfDays(Date_1) == CountOfDays(Date_2));
        else
            return false;
    }

    bool IsEqual(clsDate Date_2)
    {
        return IsEqual(*this, Date_2);
    }

    static bool IsLastDayInMonth(clsDate Date)
    {
        return Date._Day == CountDaysInMonth(Date._Year, Date._Month);
    }

    bool IsLastDayInMonth()
    {
        return IsLastDayInMonth(*this);
    }

    static bool IsLastMonthInYear(short Month)
    {
        return (Month == 12);
    }

    bool IsLastMonthInYear()
    {
        return IsLastMonthInYear(_Month);
    }

    static void IncressDateByOneDay(clsDate &Date)
    {
        DateAddDays(Date, 1);
    }

    void IncressDateByOneDay()
    {
        IncressDateByOneDay(*this);
    }

    static int DateDiffInDays(clsDate Date_1, clsDate Date_2)
    {
        int TotlaDays = 0;
        // deff days
        TotlaDays = CountOfDays(Date_1) - CountOfDays(Date_2);

        // deff years
        while (true)
        {
            if (Date_2._Year > Date_1._Year)
            {
                TotlaDays += IsLeapYear(Date_2._Year) ? 366 : 365;
                Date_2._Year--;
            }
            else if (Date_1._Year > Date_2._Year)
            {
                TotlaDays -= (IsLeapYear(Date_1._Year) ? 366 : 365);
                Date_2._Year++;
            }
            else if (Date_1._Year == Date_2._Year)
            {
                break;
            }
        }

        return TotlaDays;
    }

    int DateDiffInDays(clsDate Date_2)
    {
        return DateDiffInDays(*this, Date_2);
    }

    static short AgeToDays(short Age)
    {
        clsDate Date_1, Date_2;
        // Date of Now
        SetDateNow(Date_1);

        // start Date
        SetDateNow(Date_2);
        Date_2.SetYear(Date_2._Year - Age);

        return DateDiffInDays(Date_2, Date_1);
    }

    // ////////////////////////////////

    static void AddXdaysToDate(clsDate &Date, int Days)
    {
        DateAddDays(Date, Days);
    }

    void AddXdaysToDate(int Days)
    {
        AddXdaysToDate(*this, Days);
    }

    static void AddOneWeekToDate(clsDate &Date)
    {
        short WeekDays = 7;
        return DateAddDays(Date, WeekDays);
    }

    void AddOneWeekToDate()
    {
        AddOneWeekToDate(*this);
    }

    static void AddXWeeksToDate(clsDate &Date, short Weeks)
    {
        short WeekDays = 7;
        short TotalDays = WeekDays * Weeks;
        return DateAddDays(Date, TotalDays);
    }

    void AddXWeeksToDate(short Weeks)
    {
        AddXWeeksToDate(*this, Weeks);
    }

    static void AddOneMonthToDate(clsDate &Date)
    {
        if (Date._Month < 12)
        {
            Date._Month += 1;
        }
        else
        {
            Date._Year++;
            Date._Month = 1;
        };

        if (!IsLastDayInMonth(Date))
        {
            Date._Day = CountOfDaysInMonth(Date._Year, Date._Month);
        }
    }

    void AddOneMonthToDate()
    {
        AddOneMonthToDate(*this);
    }

    static void AddXMonthToDate(clsDate &Date, short Monthes)
    {
        int TotalDays = 0;
        for (short i = 1; i <= Monthes; i++)
        {
            TotalDays += CountOfDaysInMonth(Date._Year, Date._Month + i);
        }

        return DateAddDays(Date, TotalDays);
    }

    void AddXMonthToDate(short Monthes)
    {
        AddXMonthToDate(*this, Monthes);
    }

    static void AddOneYearToDate(clsDate &Date)
    {
        Date._Year++;
    }

    void AddOneYearToDate()
    {
        AddOneYearToDate(*this);
    }

    static void AddXYearToDate(clsDate &Date, short Years)
    {
        Date._Year += Years;
    }

    void AddXYearToDate(short Years)
    {
        AddXYearToDate(*this, Years);
    }

    static void AddOneDecadeToDate(clsDate &Date)
    {
        short DecadeToYears = 10;
        Date._Year += DecadeToYears;
    }

    void AddOneDecadeToDate()
    {
        AddOneDecadeToDate(*this);
    }

    static void AddXDecadeToDate(clsDate &Date, short Decade)
    {
        short DecadeToYears = 10 * Decade;
        Date._Year += DecadeToYears;
    }

    void AddXDecadeToDate(short Decade)
    {
        AddXDecadeToDate(*this, Decade);
    }

    static void AddOneCenturyToDate(clsDate &Date)
    {
        short CenturyToYears = 100;
        Date._Year += CenturyToYears;
    }

    void AddOneCenturyToDate()
    {
        AddOneCenturyToDate(*this);
    }

    static void AddXCenturyToDate(clsDate &Date, short Century)
    {
        short CenturyToYears = 100 * Century;
        Date._Year += CenturyToYears;
    }

    void AddXCenturyToDate(short Century)
    {
        AddXCenturyToDate(*this, Century);
    }

    static void AddOneMillenniumToDate(clsDate &Date)
    {
        short MillenniumToYears = 1000;
        Date._Year += MillenniumToYears;
    }

    void AddOneMillenniumToDate()
    {
        AddOneMillenniumToDate(*this);
    }

    ////////////////////////////////

    static void SubstracDateByOneDay(clsDate &Date)
    {
        if (Date._Day == 1)
        {
            if (Date._Month == 1)
            {
                Date._Year--;
                Date._Month = 12;
                Date._Day = CountOfDaysInMonth(Date._Year, Date._Month);
            }
            else
            {
                Date._Month--;
                Date._Day = CountOfDaysInMonth(Date._Year, Date._Month);
            }
        }
        else
        {
            Date._Day--;
        }
    }

    void SubstracDateByOneDay()
    {
        SubstracDateByOneDay(*this);
    }

    static void SubstracDateByXDay(clsDate &Date, short Days)
    {
        for (short i = 0; i < Days; i++)
        {
            SubstracDateByOneDay(Date);
        }
    }

    void SubstracDateByXDay(short Days)
    {
        SubstracDateByXDay(*this, Days);
    }

    static void SubstracDateByOneWeek(clsDate &Date)
    {
        for (short i = 0; i < 7; i++)
        {
            SubstracDateByOneDay(Date);
        }
    }

    void SubstracDateByOneWeek()
    {
        SubstracDateByOneWeek(*this);
    }

    static void SubstracDateByXWeek(clsDate &Date, short Weeks)
    {
        for (short i = 0; i < Weeks; i++)
        {
            SubstracDateByOneWeek(Date);
        }
    }

    void SubstracDateByXWeek(short Weeks)
    {
        SubstracDateByXWeek(*this, Weeks);
    }

    static void SubstracDateByOneMonth(clsDate &Date)
    {
        if (Date._Month == 1)
        {
            Date._Month = 12;
            Date._Year--;
        }
        else
        {
            Date._Month--;
        }

        // update end of the month
        short NumberOfDayInCurrentMonth = CountOfDaysInMonth(Date._Year, Date._Month);

        if (Date._Day > NumberOfDayInCurrentMonth)
        {
            Date._Day = NumberOfDayInCurrentMonth;
        }
    }

    void SubstracDateByOneMonth()
    {
        SubstracDateByOneMonth(*this);
    }

    static void SubstracDateByXMonth(clsDate &Date, short Months)
    {
        for (short i = 0; i < Months; i++)
        {
            SubstracDateByOneMonth(Date);
        }
    }

    void SubstracDateByXMonth(short Months)
    {
        SubstracDateByXMonth(*this, Months);
    }

    static void SubstracDateByOneYear(clsDate &Date)
    {
        Date._Year--;
    }

    void SubstracDateByOneYear()
    {
        SubstracDateByOneYear(*this);
    }

    static void SubstracDateByXYear(clsDate &Date, short Years)
    {
        Date._Year -= Years;
    }

    void SubstracDateByXYear(short Years)
    {
        SubstracDateByXYear(*this, Years);
    }

    static void SubstracDateByOneDecade(clsDate &Date)
    {
        Date._Year -= 10;
    }

    void SubstracDateByOneDecade()
    {
        SubstracDateByOneDecade(*this);
    }

    static void SubstracDateByXDecade(clsDate &Date, short Decade)
    {
        Date._Year -= 10 * Decade;
    }

    void SubstracDateByXDecade(short Decade)
    {
        SubstracDateByXDecade(*this, Decade);
    }

    static void SubstracDateByOneCentury(clsDate &Date)
    {
        Date._Year -= 100;
    }

    void SubstracDateByOneCentury()
    {
        SubstracDateByOneCentury(*this);
    }

    static void SubstracDateByXCentury(clsDate &Date, short Century)
    {
        Date._Year -= 100 * Century;
    }

    void SubstracDateByXCentury(short Century)
    {
        SubstracDateByXCentury(*this, Century);
    }

    static void SubstracDateByOnemillennium(clsDate &Date)
    {
        Date._Year -= 1000;
    }

    void SubstracDateByOnemillennium()
    {
        SubstracDateByOnemillennium(*this);
    }

    static bool IsEndOfWeek(clsDate Date)
    {
        return (DayName(Date) == "Sat");
    }

    bool IsEndOfWeek()
    {
        return IsEndOfWeek(*this);
    }

    static bool IsWeekEnd(clsDate Date)
    {
        return (DayName(Date) == "Sat" || DayName(Date) == "Fri");
    }

    bool IsWeekEnd()
    {
        return IsWeekEnd(*this);
    }

    static bool IsBusinessDay(clsDate Date)
    {
        return (!IsWeekEnd(Date));
    }

    bool IsBusinessDay()
    {
        return IsBusinessDay(*this);
    }

    static short DaysUntilTheEndOfWeek(clsDate Date)
    {
        short DaysUntilEndOfWeek = 0;
        while (!IsEndOfWeek(Date))
        {
            DaysUntilEndOfWeek++;
            Date._Day++;
        }
        return DaysUntilEndOfWeek;
    }

    short DaysUntilTheEndOfWeek()
    {
        return DaysUntilTheEndOfWeek(*this);
    }

    static short DaysUntilTheEndOfMonth(clsDate Date)
    {
        // [1] how many days in month
        // [2] DaysInMonth - Date.Day
        return CountOfDaysInMonth(Date._Year, Date._Month) - Date._Day;
    }

    short DaysUntilTheEndOfMonth()
    {
        return DaysUntilTheEndOfMonth(*this);
    }

    static short DaysUntilTheEndOfYear(clsDate Date)
    {
        // [1] how many year in this month
        // [2] DaysInMonth - Date.Day
        // [3] sum months days Until the end month in year + [2]
        short TotalDaysUnitEndOfYear = 0;
        short DaysInCurrentMonth = DaysUntilTheEndOfMonth(Date);
        while (!IsLastMonthInYear(Date._Month))
        {
            TotalDaysUnitEndOfYear += CountOfDaysInMonth(Date._Year, Date._Month++);
        }
        return TotalDaysUnitEndOfYear + DaysInCurrentMonth;
    }

    short DaysUntilTheEndOfYear()
    {
        return DaysUntilTheEndOfYear(*this);
    }

    // /////////////////////////////////////////////////
    static short VacationDays(clsDate EndDate, clsDate StartDate)
    {
        // total days from start date to end date (not weekend days)
        short TotalDays = 0;
        while (!IsEqual(EndDate, StartDate))
        {
            // add days to start date unital (start date == end date)
            DateAddDays(StartDate, 1);
            if (!IsWeekEnd(StartDate))
            {
                TotalDays++;
            }
            else
                continue;
        };
        return TotalDays;
    }

    static clsDate EndDateOfVacation(clsDate StartDate, short VacationDays)
    {
        short TotalDays = 0;
        clsDate EndDate;
        // startDate++ (VacationDays times) then endDate =  startDate;
        for (short i = 0; i < VacationDays; i++)
        {
            if (IsWeekEnd(StartDate))
            {
                i--;
            }

            DateAddDays(StartDate, 1);
        }
        return EndDate;
    }

    static bool FirstDateIsAfterSecondDate(clsDate FirstDate, clsDate LastDate)
    {

        if (IsLessthan(FirstDate, LastDate) ||
            IsEqual(FirstDate, LastDate))
        {
            return false;
        }
        return true;
    }

    // /////////////////////////////////////////////////

    static enDateSate ComparDate(clsDate FirstDate, clsDate SecondDate)
    {
        if (FirstDateIsAfterSecondDate(FirstDate, SecondDate))
            return enDateSate::Before;
        else if (IsEqual(FirstDate, SecondDate))
            return enDateSate::Equal;
        else
            return enDateSate::After;
    }

    enDateSate ComparDate(clsDate SecondDate)
    {
        return ComparDate(*this, SecondDate);
    }

    static void PrintDateInCard(clsDate Date)
    {
        cout << "\n------------------------------------\n";
        cout << "Date Day : " << Date._Day << endl;
        cout << "Date Month : " << Date._Month << endl;
        cout << "Date Year : " << Date._Year << endl;
        cout << "------------------------------------\n";
    }

    void PrintDateInCard()
    {
        PrintDateInCard(*this);
    }
};