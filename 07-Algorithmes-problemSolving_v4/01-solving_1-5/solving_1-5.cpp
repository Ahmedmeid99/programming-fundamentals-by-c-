#include <iostream>
#include <ctime>
#include "../../00-MyLibrary/numbers.cpp"
using namespace std;

string NumberToText(int Number)
{
    if (Number == 0)
    {
        return "";
    }
    else if (Number > 0 && Number <= 19)
    {

        string Array1[20] =
            {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

        return Array1[Number] + " ";
    }
    else if (Number >= 20 && Number <= 99)
    {
        string Array2[10] =
            {"", "", "twenty", "thirty", "forty", "fifty", "sisty", "seventy", "eighty", "ninety"};

        return Array2[Number / 10] + " " + NumberToText(Number % 10);
    }
    else if (Number >= 100 && Number <= 199)
    {
        // 199 => 1 99
        return "One hundred " + NumberToText(Number % 100);
    }
    else if (Number >= 200 && Number <= 999)
    {
        // 220 = > 2 20
        return NumberToText(Number / 100) + "hundred " + NumberToText(Number % 100);
    }
    else if (Number >= 1000 && Number <= 1999)
    {
        // 199 => 1 999
        return "One thousand " + NumberToText(Number % 1000);
    }
    else if (Number >= 2000 && Number <= 999999)
    {
        // 999999 =>999 999
        return NumberToText(Number / 1000) + "thousand " + NumberToText(Number % 1000);
    }
    else if (Number >= 1000000 && Number <= 1999999)
    {
        // 1999999 => 1 999999
        return "One Million " + NumberToText(Number % 1000000);
    }
    else if (Number >= 2000000 && Number <= 999999999)
    {
        // 999999999 =>999 999999
        return NumberToText(Number / 1000000) + "thousand " + NumberToText(Number % 1000000);
    }
    else if (Number >= 1000000000 && Number <= 1999999999)
    {
        // 1999999999 => 1 999999999
        return "One Billion " + NumberToText(Number % 1000000000);
    }
    else
    {
        // 999999999 =>999 999999
        return NumberToText(Number / 1000000000) + "Billion " + NumberToText(Number % 1000000000);
    }
}

bool IsLeapYear_v1(int Year)
{
    if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
    {
        return true;
    }
    return false;
}

bool IsLeapYear(int Year)
{
    return (Year % 4 == 0 && Year % 100 != 0) || (Year % 400 == 0);
}
////////////////////////////
short NumberOfDayInYaers(short Year)
{
    return (IsLeapYear(Year)) ? 366 : 365;
}

short NumberOfHoursInYaers(short Year)
{
    return NumberOfDayInYaers(Year) * 24;
}

int NumberOfMinutesInYaers(short Year)
{
    return NumberOfHoursInYaers(Year) * 60;
}

int NumberOfSecondsInYaers(short Year)
{
    return NumberOfMinutesInYaers(Year) * 60;
}

void PrintYearInfo(short Year)
{
    cout << "Number of Days in Year is : " << NumberOfDayInYaers(Year) << " Days" << endl;
    cout << "Number of Hours in Year is : " << NumberOfHoursInYaers(Year) << " Hours" << endl;
    cout << "Number of Minutes in Year is : " << NumberOfMinutesInYaers(Year) << " Minutes" << endl;
    cout << "Number of Seconds in Year is : " << NumberOfSecondsInYaers(Year) << " Seconds" << endl;
}
///////////////////////////////

int NumberOfHoursInMonth(short NumberOfDays)
{
    return NumberOfDays * 24;
}

int NumberOfMinutesInMonth(short NumberOfDays)
{
    return NumberOfHoursInMonth(NumberOfDays) * 60;
}

int NumberOfSecondsInMonth(short NumberOfDays)
{
    return NumberOfMinutesInMonth(NumberOfDays) * 60;
}

short NumberOfDaysInMonth(short Year, short M)
{
    return (M == 4 || M == 6 || M == 9 || M == 11) ? 30
           : (M != 2)                              ? 31
           : (M == 2 && IsLeapYear(Year))          ? 29
                                                   : 28;
}

void MonthInfo(short Year, short M)
{
    cout << "Date : " << M << "/" << Year << endl;
    cout << "Number of Days in Month is : " << NumberOfDaysInMonth(Year, M) << " Days" << endl;
    cout << "Number of Hours in Month is : " << NumberOfHoursInMonth(Year) << " Hours" << endl;
    cout << "Number of Minutes in Month is : " << NumberOfMinutesInMonth(Year) << " Minutes" << endl;
    cout << "Number of Seconds in Month is : " << NumberOfSecondsInMonth(Year) << " Seconds" << endl;
}
int main()
{
    // [1] Number to text
    cout << NumberToText(12126811) << endl;
    cout << NumberToText(102424424) << endl;

    // [2] Check Is Leap Year
    string IsLeap = IsLeapYear_v1(1971) ? "Is Leap Year" : "Is Not Leap Year";
    cout << IsLeap << endl;

    // [3] Check Is Leap Year
    string IsLeap2 = IsLeapYear(2012) ? "Is Leap Year" : "Is Not Leap Year";
    cout << IsLeap2 << endl;

    // [4]
    short ReadYear = nums::ReadPositveNumber("Enter Year : ");
    PrintYearInfo(ReadYear);

    // [5] [6]enter Year and month and get info about this month
    short Year = nums::ReadPositveNumber("Enter Year : ");
    short Month = nums::ReadPositveNumber("Enter Year : ");
    MonthInfo(Year, Month);

    return 0;
}