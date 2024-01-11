#include <iostream>
#include "clsInputValidate.cpp";
using namespace std;

int main()
{
    int a = clsInputValidate::ReadPositveNumber("Enter Int Number : ");
    short b = clsInputValidate::ReadShortNumber("Enter Int Number : ");
    double c = clsInputValidate::ReadDoubletNumber("Enter Int Number : ");
    double e = clsInputValidate::ReadIntNumberBetween(1, 10, "Enter Int Number : ");
    cout << a << endl;
    cout << b << endl;
    cout << c << endl;
    cout << e << endl;
    cout << clsInputValidate::IsNumberBetween(5,1,10) << endl;
    cout << clsInputValidate::IsNumberBetween(5.2, 1.2, 10.0) << endl;
    return 0;
}