#include <iostream>
#include "./clsDate.cpp"
#include "./clsPeriod.cpp"

using namespace std;

int main()
{
    clsDate Date_1;
    clsDate Date_2("1/1/2022");
    clsDate Date_3(1, 1, 2023);

    Date_1.SetDateNow();
    cout << Date_1.DaysUntilTheEndOfYear() << endl;

    Date_1.MonthCalander();
    cout << Date_1.DayName(25, 12, 2023) << endl;
    cout << Date_1.Print() << endl;
    cout << Date_2.Print() << endl;
    cout << Date_3.Print() << endl;

    ///////////////////////////////////
    clsPeriod Period_1(Date_2, Date_1);
    clsPeriod Period_2(Date_2, Date_3);
    cout << Period_1.CountOverlapDays(Period_2) << endl;
    return 0;
}