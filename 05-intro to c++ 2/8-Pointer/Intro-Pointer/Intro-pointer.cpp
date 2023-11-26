#include <iostream>
using namespace std;

int main()
{

    int a = 10;
    int *p;

    p = &a;
    cout << "a " << a << endl;     // 10
    cout << "p = " << p << endl;   // 0xc0dd3ff774
    cout << "*p = " << *p << endl; // 10

    *p = 20;
    int b = 30;
    p = &b;

    cout << "p = " << p << endl;   // 0xab429ffe90
    cout << "*p = " << *p << endl; // 30
    cout << "a " << a << endl;     // 20
    ////////////////////////

    return 0;
}