#include <iostream>
using namespace std;

// we use & (referece) to get Length fast
void ReadItems(int *ptr, int &Length)
{
    for (int i = 0; i <= Length - 1; i++)
    {
        cout << "Student Average " << i + 1 << ": ";
        cin >> *(ptr + i);
    }
}

void PrintItems(int *ptr, int &Length)
{
    for (int i = 0; i <= Length - 1; i++)
    {
        cout << "Student " << i + 1 << ": ";
        cout << *(ptr + i) << endl;
    }
}

int main()
{
    int Number;

    cout << "Enter number of students you want to add their average : ";
    cin >> Number;

    int *ptr;
    ptr = new int[Number];

    ReadItems(ptr, Number);
    PrintItems(ptr, Number);

    delete[] ptr;

    return 0;
}