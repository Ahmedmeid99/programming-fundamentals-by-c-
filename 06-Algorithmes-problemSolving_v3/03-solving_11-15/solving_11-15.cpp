#include <iostream>
#include "../00-MyLibrary/random.cpp"
#include "../00-MyLibrary/numbers.cpp"
using namespace std;

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

bool IsSumEqual(int arr_1[3][3], int arr_2[3][3], short Cols, short Rows)
{
    return SumMatrixNums(arr_1, Cols, Rows) == SumMatrixNums(arr_2, Cols, Rows);
}

bool IsTypicalMatrixs(int arr_1[3][3], int arr_2[3][3], short Cols, short Rows)
{
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (arr_1[i][j] != arr_2[i][j])
            {
                return false;
            }
        }
    }
    return true;
}

bool IsIdentityMatrix(int arr[3][3], short Cols, short Rows)
{
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (i != j)
            {
                if (arr[i][j] != 0)
                    return false;
                else
                    continue;
            }
            else
            {
                if (arr[i][j] != 1)
                    return false;
                else
                    continue;
            }
        }
    }
    return true;
}

bool IsScalarMatrix(int arr[3][3], short Cols, short Rows)
{
    short ScalNumber = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (i != j)
            {
                if (arr[i][j] != 0)
                    return false;
                else
                    continue;
            }
            else
            {

                ScalNumber = (ScalNumber == 0) ? ScalNumber = arr[i][j] : ScalNumber;
                if (arr[i][j] != ScalNumber)
                    return false;
                else
                    continue;
            }
        }
    }
    return true;
}

int CountOfNumberInMatrix(int arr[3][3], short Cols, short Rows, short Number)
{
    short RepetedTimes = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (arr[i][j] == Number)
                RepetedTimes++;
            else
                continue;
        }
    }
    return RepetedTimes;
}

int main()
{
    // [11] comper 2 matrix array
    int arr_1[3][3], arr_2[3][3];
    FillMatrixArrayWithRandomNumber(arr_1, 3, 3);
    PrintMatrixArray(arr_1, 3, 3);
    cout << "-----------\n";
    FillMatrixArrayWithRandomNumber(arr_2, 3, 3);
    PrintMatrixArray(arr_2, 3, 3);
    string chickEqual = IsSumEqual(arr_1, arr_2, 3, 3) ? "Yes That is Equal" : "No That isnt Equal";
    cout << "-----------\n";
    cout << chickEqual << endl;

    // [12] is Typical or Not
    string ChickTypical = IsTypicalMatrixs(arr_2, arr_2, 3, 3) ? "Yes That is Typical" : "No That isnt Typical";
    cout << ChickTypical << endl;
    cout << "-----------\n";

    //[13] is identity
    int IdentityMatrix[3][3] = {
        {1, 0, 0},
        {0, 1, 0},
        {0, 0, 1}};

    string ChickIdentity = IsIdentityMatrix(IdentityMatrix, 3, 3) ? "Yes That is Identity" : "No That isnt Identity";
    cout << ChickIdentity << endl;

    // [14] is Scalar
    int ScalarMatrix[3][3] = {
        {5, 0, 0},
        {0, 5, 0},
        {0, 0, 5}};

    string ChickScalar = IsScalarMatrix(ScalarMatrix, 3, 3) ? "Yes That is Scalar" : "No That isnt Scalar";
    cout << ChickScalar << endl;

    // [15] count of repeted number in Matrix
    int Array[3][3] = {
        {1, 2, 3},
        {1, 3, 1},
        {4, 4, 5}};

    short num = nums::ReadPositveNumber("Enter the number you want to get how many times it is repeted? : ");
    cout << num << " is repeted : " << CountOfNumberInMatrix(Array, 3, 3, num) << " times\n";
    return 0;
}