#include <iostream>

using namespace std;

void PrintDiArray(int arr[4][3])
{
    for (int i = 0; i <= 4 - 1; i++)
    {
        for (int j = 0; j <= 3 - 1; j++)
        {
            cout << arr[i][j] << " ";
        }
        cout << "\n";
    }
}

void PrintTable()
{
    for (int i = 1; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            printf("%0*d ", 2, i * j);
        }
        cout << "\n";
    }
}

int main()
{

    int arr[4][3] =
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}

        };

    PrintDiArray(arr);
    PrintTable();
    return 0;
}