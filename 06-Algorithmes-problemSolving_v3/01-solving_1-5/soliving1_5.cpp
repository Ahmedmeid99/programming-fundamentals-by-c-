#include <iostream>
#include "../00-MyLibrary/random.cpp"
using namespace std;

void FillMatrixArrayWithRandomNumber(int MatrixArray[3][3], short cols, short rows)
{
    for (short i = 0; i <= cols - 1; i++)
    {
        for (short j = 0; j <= rows - 1; j++)
        {
            MatrixArray[i][j] = random::RandomNumber(1, 100);
        }
    }
}

void PrintMatrixArray(int MatrixArray[3][3], short cols, short rows)
{
    for (short i = 0; i <= cols - 1; i++)
    {
        for (short j = 0; j <= rows - 1; j++)
        {
            cout << (MatrixArray[i][j]) << " ";
        }
        cout << endl;
    }
}

int SumRow(int Arr[3][3], short RowNumber, short Cols)
{
    short RowTotalSum = 0;
    for (short j = 0; j <= Cols - 1; j++)
    {
        RowTotalSum += Arr[RowNumber][j];
    }
    return RowTotalSum;
}

void PrintSumEachRowInMatrix(int MatrixArray[3][3], short rows, short cols)
{
    for (short i = 0; i <= rows - 1; i++)
    {

        cout << "Row " << i + 1 << " Sum = " << SumRow(MatrixArray, i, cols) << endl;
    }
}

void FillArrayofSumofEachRow(int MatrixArray[3][3], short rows, short cols, int *NewArray)
{
    for (short i = 0; i <= cols - 1; i++)
    {

        *(NewArray + i) = SumRow(MatrixArray, i, cols);
    }
}

void PrintArray(int *Array, int Length)
{
    for (int i = 0; i <= Length - 1; i++)
    {
        cout << "Row " << i + 1 << " Sum = " << *(Array + i) << endl;
    }
}

int SumCol(int Arr[3][3], short Row, short ColsNumber)
{
    short ColTotalSum = 0;
    for (short j = 0; j <= Row - 1; j++)
    {
        ColTotalSum += Arr[j][ColsNumber];
    }
    return ColTotalSum;
}

void PrintSumEachColInMatrix(int MatrixArray[3][3], short rows, short cols)
{
    for (short i = 0; i <= cols - 1; i++)
    {

        cout << "Col " << i + 1 << " Sum = " << SumCol(MatrixArray, rows, i) << endl;
    }
}

void FillArrayofSumofEachCol(int MatrixArray[3][3], short rows, short cols, int *NewArray)
{
    for (short i = 0; i <= cols - 1; i++)
    {

        *(NewArray + i) = SumCol(MatrixArray, rows, i);
    }
}

int main()
{
    // [1] 3*3 matrix with random numbers
    int MatrixArray[3][3];
    FillMatrixArrayWithRandomNumber(MatrixArray, 3, 3);
    PrintMatrixArray(MatrixArray, 3, 3);

    cout << "------------------------\n";
    // [2] sum Each row in 3*3 matrix and print its
    PrintSumEachRowInMatrix(MatrixArray, 3, 3);

    cout << "------------------------\n";
    // [3] new Array and fill it with sum of Each row in 3*3 matrix
    int *Array = new int[3];
    FillArrayofSumofEachRow(MatrixArray, 3, 3, Array);
    PrintArray(Array, 3);
    delete Array;

    cout << "------------------------\n";
    // [4] sum Each clo in 3*3 matrix and print its
    PrintSumEachColInMatrix(MatrixArray, 3, 3);

    cout << "------------------------\n";
    // [5] new Array and fill it with sum of Each col in 3*3 matrix
    int *Arr = new int[3];
    FillArrayofSumofEachCol(MatrixArray, 3, 3, Arr);
    PrintArray(Arr, 3);
    delete Arr;

    return 0;
}