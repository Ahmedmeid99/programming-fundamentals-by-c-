#include <iostream>
#include "../00-MyLibrary/numbers.cpp"
#include "../00-MyLibrary/arrays.cpp"
using namespace std;

bool SparceMatrixArray(int arr[3][3], short Cols, short Rows)
{
    short ZeroRepetedTimes = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (arr[i][j] == 0)
                ZeroRepetedTimes++;
            else
                continue;
        }
    }
    return ZeroRepetedTimes > (Cols * Rows) / 2;
}

bool IsExistMatrixArray(int arr[3][3], short Cols, short Rows, short Number)
{
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (arr[i][j] == Number)
                return true;
        }
    }
    return false;
}

short CountOfNumberInMatrix(int arr[3][3], short Cols, short Rows, short Number)
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

void ArrayOfRepetedNumsIntwoMatrixArrays(int arr_1[3][3], int arr_2[3][3], int NewArrray[9], short &NewArrrayLength, short Cols, short Rows)
{
    short counter = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            // or use IsExistMatrixArray()
            if (CountOfNumberInMatrix(arr_1, Cols, Rows, arr_2[i][j]) > 0)
            {
                NewArrray[counter] = arr_2[i][j];
                counter++;
            }
            else
                continue;
        }
    }
    NewArrrayLength = counter;
}

short MaxNumberinMatrixArray(int array[3][3], short Cols, short Rows)
{
    short MaxNumber = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (array[i][j] > MaxNumber)
                MaxNumber = array[i][j];
            else
                continue;
        }
    }
    return MaxNumber;
}

short MinNumberinMatrixArray(int array[3][3], short Cols, short Rows)
{
    short MinNumber = 0;
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= Cols - 1; j++)
        {
            if (array[i][j] < MinNumber)
                MinNumber = array[i][j];
            else
                continue;
        }
    }
    return MinNumber;
}

bool IsPalindromMatrixArray(int array[3][3], short Cols, short Rows)
{
    for (short i = 0; i <= Rows - 1; i++)
    {
        for (short j = 0; j <= (Cols / 2) - 1; j++)
        {
            if (array[i][j] != array[i][Rows - j - 1])
                return false;
        }
    }
    return true;
}

int main()
{

    // [16] Sparce Matrix (count of Zero > ather numbers in matrix array)
    int SparceMatrix[3][3] = {
        {9, 0, 0},
        {1, 5, 0},
        {0, 0, 2}};

    string ChickScalar = SparceMatrixArray(SparceMatrix, 3, 3) ? "Yes That is Sparce" : "No That isnt Sparce";
    cout << ChickScalar << endl;

    // [17] is Exist or not
    int Array_1[3][3] = {
        {9, 2, 1},
        {1, 5, 8},
        {0, 7, 2}};

    short num = nums::ReadPositveNumber("Enter the number you want to check it it is Exist or Not? : ");
    string ChickExist = IsExistMatrixArray(Array_1, 3, 3, num) ? "Yes That is Exist" : "No That isnt Exist";
    cout << ChickExist << endl;

    // [18] Print repeted nums from array 1 in array 2
    int arr_1[3][3] = {
        {9, 21, 1},
        {0, 51, 8},
        {0, 7, 22}};

    int arr_2[3][3] = {
        {9, 2, 1},
        {1, 5, 8},
        {0, 7, 2}};
    int NewArrray[9];
    short NewArrrayLength = 0;
    ArrayOfRepetedNumsIntwoMatrixArrays(arr_1, arr_2, NewArrray, NewArrrayLength, 3, 3);
    arrays::PrintArry(NewArrray, NewArrrayLength);

    // [19] Min/Max number in array
    short Min = MinNumberinMatrixArray(arr_2, 3, 3);
    short Max = MaxNumberinMatrixArray(arr_2, 3, 3);
    printf(" %d : is the Min Number in Matrix Array \n", Min);
    printf(" %d : is the Max Number in Matrix Array \n", Max);

    // [20] check if the matrix array is Palindrom or Not
    int PalindromMatrixArray[3][3] = {
        {1, 3, 1},
        {3, 3, 3},
        {3, 0, 3}};
    string IsPalindrom = IsPalindromMatrixArray(PalindromMatrixArray, 3, 3) ? "Yes, it is Palindrom" : "No, it isnt Palindrom";
    cout << IsPalindrom << endl;
    return 0;
}