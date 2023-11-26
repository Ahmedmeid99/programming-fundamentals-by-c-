#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    time_t t = time(0);
    cout << t << endl; // 1700952152

    // Local Time
    char *dt = ctime(&t); // from 1700952152 to string
    cout << dt << endl;   // Sun Nov 26 00:44:16 2023

    // UTC Time
    // tm is bulid in structure type of date
    tm *gm_time = gmtime(&t); // struct

    dt = asctime(gm_time); // from structure to string
    cout << dt << endl;    // Sat Nov 25 22:53:01 2023

    /* in tm structure in UTC*/
    cout << gm_time->tm_year + 1900 << endl; // 2023
    cout << gm_time->tm_mon + 1 << endl;     // 11
    cout << gm_time->tm_hour << endl;        // 23

    /* in tm structure in local time*/
    tm *now = localtime(&t);
    cout << now->tm_year + 1900 << endl; // 2023
    cout << now->tm_mon + 1 << endl;     // 11 the month Nov
    cout << now->tm_hour << endl;        // 1
    cout << now->tm_min << endl;         // 6
    cout << now->tm_sec << endl;         // 10
    cout << now->tm_mday << endl;        // 26 day at month
    cout << now->tm_wday << endl;        // 0 because he are in Sun
    cout << now->tm_yday << endl;        // 329 form 365 day in year
    cout << now->tm_isdst << endl;       // 0

    return 0;
}