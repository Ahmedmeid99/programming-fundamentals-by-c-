#include <iostream>
using namespace std;
void PrintArrayByPointer(int *p, int Length)
{
    for (int i = 0; i <= Length - 1; i++)
    {
        cout << *p + i << " ";
    }
}
int main()
{

    int array[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};

    int *p;
    p = array;

    cout << p << endl;      // 0x27413ff730
    cout << *p << endl;     // 1 array[0]
    cout << *p + 1 << endl; // 1 array[2]

    PrintArrayByPointer(p, 10); // 1 2 3 4 5 6 7 8 9 10
    return 0;
}