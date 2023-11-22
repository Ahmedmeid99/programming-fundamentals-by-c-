#include <iostream>
#include "../MyLibrary/arrays.cpp"
using namespace std;

int main()
{
    srand((unsigned)time(NULL));
    int array1[10], length = 10;
    arrays::CreatRandomArray(array1, length);

    // loop on colection
    for (int number : array1)
    {
        cout << number << " ";
    }
    cout << "\n";

    //////////////////////////////////
    for (int number : {1, 2, 3, 4, 5, 6, 7, 8, 9, 0})
    {
        cout << number << " ";
    }
    cout << "\n";

    //////////////////////////////////
    char name[] = "ahmed mohamed eid";

    for (char Mychar : name)
    {
        cout << Mychar << " ";
    }

    return 0;
}