#include <iostream>
using namespace std;

void swapNums(int *a, int *b)
{
    int temp;
    temp = *a;
    *a = *b;
    *b = temp;
}
int main()
{
    int a = 10, b = 20;
    cout << "a = " << a << endl;
    cout << "b = " << b << endl;

    swapNums(&a, &b);

    cout << "a = " << a << endl;
    cout << "b = " << b << endl;
    return 0;
}