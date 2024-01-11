#include <iostream>
#include "clsUtility.cpp"

using namespace std;

int main()
{
    int a, b;
    a = 10;
    b = 20;
    clsUtility::Swap(a, b);
    cout << "a = " << a << ", b =" << b << endl;

    return 0;
}