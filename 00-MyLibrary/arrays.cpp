#pragma once
#include <cstdlib>
#include <iostream>
#include "random.cpp"
#include "numbers.cpp"
using namespace std;

namespace arrays
{
    // add this line in main function
    // srand((unsigned)time(NULL));
    // Functions declaration

    // [1]
    void addNewElementToArray(int Element, int array[100], int &Length)
    {
        Length++;
        array[Length - 1] = Element;
    }

    // [2]
    void CreatRandomArray(int Nums[100], int Length)
    {
        for (int i = 0; i <= Length - 1; i++)
        {
            Nums[i] = random::RandomNumber(1, 100);
        }
    }

    // [3]
    void CreateOrderedArry(int arr[100], int Length)
    {
        for (int i = 0; i <= Length; i++)
        {
            arr[i] = i + 1;
        }
    }

    // []
    int PositionSearchIn(int arr[100], int Length, int Digit)
    {
        for (int i = 0; i <= Length - 1; i++)
        {
            if (arr[i] == Digit)
            {
                return i;
            }
        }
        return -1;
    }

    // [4]
    void PrintArry(int nums[100], int length)
    {
        for (int i = 0; i <= length - 1; i++)
        {
            cout << nums[i] << " ";
        }
        cout << endl;
    }

    // [5]
    void PrintStArry(string nums[100], int length)
    {
        for (int i = 0; i <= length - 1; i++)
        {
            cout << nums[i] << " ";
        }
        cout << endl;
    }

    // [6]
    int MaxItemInArray(int Nums[100], int Length)
    {
        int MaxNumer = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            if (MaxNumer < Nums[i])
                MaxNumer = Nums[i];
            else
                continue;
        }
        return MaxNumer;
    }

    // [7]
    int MinItemInArray(int Nums[100], int Length)
    {
        int MinNumer = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            MinNumer = Nums[i];
            if (MinNumer > Nums[i])
                MinNumer = Nums[i];
            else
                continue;
        }
        return MinNumer;
    }

    // [8]
    int SumOfArrayNumbers(int Nums[100], int Length)
    {
        int Sum = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            Sum += Nums[i];
        }
        return Sum;
    }

    // [9]
    int AverageOfArrayNumbers(int Nums[100], int Length)
    {
        int Sum = SumOfArrayNumbers(Nums, Length);
        return Sum / Length;
    }

    // [10]
    void CopyedArray(int arr1[100], int &Length1, int arr2[100], int Length2)
    {
        for (int i = 0; i <= Length2 - 1; i++)
        {
            arr1[i] = arr2[i];
        }
        Length1 = Length2;
    }

    // [11]
    void CreatDistinictArray(int DistinictArray[100], int &DisLength, int OldArray[100], int OldLength)
    {
        for (int i = 0; i <= OldLength - 1; i++)
        {
            if (PositionSearchIn(DistinictArray, DisLength, OldArray[i]) == -1)
            {
                addNewElementToArray(OldArray[i], DistinictArray, DisLength);
            }
            else
                continue;
        }
    }

    // [12]
    bool IsPalindromeArray(int Array[100], int Length)
    {
        bool IsPalindrome = true;
        // Length = floor(Length/2);
        for (int i = 0; i <= floor(Length / 2) - 1; i++)
        {
            // ex: 10 / 2
            // start from Begining [i] 0
            // start from the End [Length- 1 -i] 9 8 7 6 5 4 3 2 1 0
            if (Array[i] == Array[Length - 1 - i])
                continue;
            else
                IsPalindrome = false;
        }
        return IsPalindrome;
    }

    // [13]
    int CountOodNums(int Array[100], int Length)
    {
        int OodCount = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            if (nums::IsOod(nums::CheckNumberType(Array[i])))
                OodCount++;
            else
                continue;
        }
        return OodCount;
    }

    // [14]
    int CountEvenNums(int Array[100], int Length)
    {
        int EvenCount = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            if (nums::IsEven(nums::CheckNumberType(Array[i])))
                EvenCount++;
            else
                continue;
        }
        return EvenCount;
    }

    // [15]
    int CountPositiveNums(int Array[100], int Length)
    {
        int PositiveCount = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            if (nums::IsPositive(Array[i]))
                PositiveCount++;
            else
                continue;
        }

        return PositiveCount;
    }

    // [16]
    int CountNegativeNums(int Array[100], int Length)
    {
        int NegativeCount = 0;
        for (int i = 0; i <= Length - 1; i++)
        {
            if (nums::IsNegative(Array[i]))
                NegativeCount++;
            else
                continue;
        }

        return NegativeCount;
    }

    // [17]
    void CopyedPrimeArray(int arr1[100], int &Length1, int arr2[100], int Length2)
    {
        int CountItems = 0;
        for (int i = 0; i <= Length2 - 1; i++)
        {
            if (nums::IsPrime(arr2[i]))
            {
                arr1[CountItems] = arr2[i];
                CountItems++;
            }
            else
                continue;
        }
        Length1 = CountItems;
    }

    // [18]
    void ReverseArray(int arr2[100], int Length2, int ReversedArray[100])
    {
        // length ex: 10
        for (int i = 0; i <= Length2 - 1; i++)
        {
            ReversedArray[i] = arr2[Length2 - 1 - i]; // [9] [8] [7] [6] [5] [4] [3] [2] [1] [0]
        }
    }

    // [19]
    void SuffleArray(int arr[100], int Length)
    {
        // swap rabdom 2 Numbers in array
        for (int i = 0; i <= Length - 1; i++)
        {
            int index1 = random::RandomNumber(0, Length - 1);
            int index2 = random::RandomNumber(0, Length - 1);

            nums::swap_numbers(arr[index1], arr[index2]);
        }
    }

}
