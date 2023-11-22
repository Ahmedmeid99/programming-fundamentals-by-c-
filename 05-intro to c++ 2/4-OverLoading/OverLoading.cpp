#include <iostream>
using namespace std;

// int sum_2_int(int a, int b)
// {
//     return a + b;
// }

// double sum_2_double(double a, double b)
// {
//     return a + b;
// }

// int sum_3_int(int a, int b, int c)
// {
//     return a + b + c;
// }

double Mysum(double a, double b)
{
    return a + b;
}

int Mysum(int a, int b = 0, int c = 0)
{
    return a + b + c;
}

int main()
{
    // sum_2_int(2,3);
    // sum_2_double(1.2,2.5);
    // sum_3_int(2,3,4);

    cout << Mysum(2.3, 1.5) << endl; // 3.8
    cout << Mysum(2, 3) << endl;     // 5
    return 0;
}