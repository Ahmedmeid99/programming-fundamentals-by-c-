#include <iostream>
#include "../00-MyLibrary/random.cpp"
using namespace std;

void FillMatrixArrayWithRandomNumber(int MatrixArray[3][3], short cols, short rows)
{
    for (short i = 0; i <= cols - 1; i++)
    {
        for (short j = 0; j <= rows - 1; j++)
        {
            MatrixArray[i][j] = random::RandomNumber(1, 10);
        }
    }
}

///////////////////////////////////
void CreatOrderedMatrixArray(int Array[3][3], short Cols, short Rows)
{
    short counter = 1;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            Array[i][j] = counter;
            counter++;
        }
    }
}

void PrintMatrixArray(int MatrixArray[3][3], short Cols, short Rows)
{
    for (short i = 0; i <= Cols - 1; i++)
    {
        for (short j = 0; j <= Rows - 1; j++)
        {
            cout << (MatrixArray[i][j]) << " ";
        }
        cout << endl;
    }
}
///////////////////////////////////

void CreatTransposeOrderedMatrixArray(int Array[3][3], short Cols, short Rows)
{
    short counter = 1;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            Array[j][i] = counter;
            counter++;
        }
    }
}
///////////////////////////////////

void MultyTwoMatrixArray(int MArray1[3][3], short Cols, short Rows, int MArray2[3][3], int MultyArray[3][3])
{
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            MultyArray[i][j] = MArray1[i][j] * MArray2[i][j];
        }
    }
}

void PrintMiddleRow(int Array[3][3], short Rows, short Row)
{
    for (short i = 0; i <= Rows - 1; i++)
    {

        cout << Array[Row][i] << " ";
    }
    cout << endl;
}

void PrintMiddleClo(int Array[3][3], short Cols, short Col)
{
    for (short j = 0; j <= Cols - 1; j++)
    {
        cout << Array[j][Col] << " ";
    }
    cout << endl;
}

int SumMatrixNums(int MArray[3][3], short Cols, short Rows)
{
    short Sum = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            Sum += MArray[i][j];
        }
    }
    return Sum;
}

int main()
{
    // [6] 3*3 ordered number 1 : 10
    int Numbers[3][3];
    CreatOrderedMatrixArray(Numbers, 3, 3);
    PrintMatrixArray(Numbers, 3, 3);

    cout << "-----------------------\n";
    // [7] 3*3 ordered number 1 : 10
    int Numbers_2[3][3];
    CreatTransposeOrderedMatrixArray(Numbers_2, 3, 3);
    PrintMatrixArray(Numbers_2, 3, 3);

    cout << "-----------------------\n";
    // [8] Mulity 2 matrix array
    int Numbers_3[3][3];
    int Numbers_4[3][3];
    int MultyArray[3][3];
    FillMatrixArrayWithRandomNumber(Numbers_3, 3, 3);
    cout << "----------[1]-----------\n";
    PrintMatrixArray(Numbers_3, 3, 3);
    FillMatrixArrayWithRandomNumber(Numbers_4, 3, 3);
    cout << "----------[2]-----------\n";
    PrintMatrixArray(Numbers_4, 3, 3);
    MultyTwoMatrixArray(Numbers_3, 3, 3, Numbers_4, MultyArray);
    cout << "--------[Result]--------\n";
    PrintMatrixArray(MultyArray, 3, 3);

    cout << "-----------------------\n";
    // [9] Print Middle Row ,and Colun
    cout << "Middle Row : ";
    PrintMiddleRow(MultyArray, 3, 1);
    cout << "Middle Col : ";
    PrintMiddleClo(MultyArray, 3, 1);

    cout << "-----------------------\n";
    // [10] Sum of Matrix numbers
    int Numbers_5[3][3];
    CreatOrderedMatrixArray(Numbers_5, 3, 3);
    cout << "Result is : " << SumMatrixNums(Numbers_5, 3, 3); // 45
    return 0;
}