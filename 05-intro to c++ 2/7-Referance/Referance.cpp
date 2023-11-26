#include <iostream>
using namespace std;

void Function_1(int n)
{
    n++;
}
void Function_2(int &x)
{
    x++;
}
int main()
{
    int a = 10;
    Function_1(a);
    cout << "The Value of (a) after call Function_1 is : " << a << "\n";

    int b = 10;
    Function_2(b);
    cout << "The Value of (b) after call Function_1 is : " << b << "\n";

    cout << "b = " << b << endl;
    cout << "Address of b in memory is = " << &b << endl;
    return 0;
}