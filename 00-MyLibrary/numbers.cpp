#pragma once
#include <iostream>
#include <cmath>
using namespace std;

namespace nums
{
    // Functions declaration
    int ReverseNumber(int);

    // [1]
    int GetIntegerNumber(float Number)
    {
        return (int)Number;
    }

    // [2]
    float GetFractionNumber(float Number)
    {
        return Number - (int)Number;
    }

    // [3] swap numbers
    void swap_numbers(int &num1, int &num2)
    {
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
        // cout << num1 << " " << num2 << endl;
    }

    // [4] print the bigest number of 2 numbers
    int the_bigest_number_2(int A, int B)
    {
        return (A > B) ? A : B;
    }

    // [5] print the bigest number of 3 numbers
    int the_bigest_number_3(int A, int B, int C)
    {
        if (A > B)
        {
            if (C > A)
            {
                return C;
            }
            else
            {
                return A;
            }
        }
        else
        {
            if (C > B)
            {
                return C;
            }
            else
            {
                return B;
            }
        }
    }

    // [6]
    enum enNumberType
    {
        odd = 1,
        Even = 2
    };

    enNumberType CheckNumberType(int Number)
    {
        int Result = Number % 2;
        if (Result == 0)
            return enNumberType::Even; // 2 label to EvenNumber
        else
            return enNumberType::odd; // 1 label to OddNumber
    }

    // [7]
    bool IsPositive(int Number)
    {
        return Number > 0;
    }

    // [8]
    bool IsNegative(int Number)
    {
        return Number < 0;
    }

    // [9]
    bool IsEven(enNumberType NumberType)
    {
        return (NumberType == enNumberType::Even);
    }

    // [10]
    bool IsOod(enNumberType NumberType)
    {
        return (NumberType == enNumberType::odd);
    }

    // [11]
    bool IsPrime(int Number)
    {
        int M = round(Number / 2);
        for (int Counter = 2; Counter <= M; Counter++)
        {
            if (Number % Counter == 0)
            {
                return false;
            }
        }
        return true;
    }

    // [12]
    bool ISPerfect(int N)
    {
        int EndPoint = N - 1;
        int Total = 0;
        for (int i = 1; i <= EndPoint; i++)
        {
            if ((N % i) == 0)
                Total += i;
            else
                continue;
        }
        return Total == N;
    }

    // [13]
    bool isPalindrome(int Number)
    {
        return Number == ReverseNumber(Number);
    }

    // [14]
    enum enExamResult
    {
        Pass = 1,
        Fail = 0
    };

    enExamResult checkExamResult(int ExamResult)
    {
        if (ExamResult >= 50)
            return enExamResult::Pass;
        else
            return enExamResult::Fail;
    }

    // [15]
    string ExamResult(enExamResult ExamResult)
    {
        if (ExamResult == enExamResult::Pass)
            return "Pass\n";
        else
            return "Fail\n";
    }

    // [16]
    float CalcuHalfNumber(float Number)
    {
        float result = Number / 2;
        return result;
    }

    // [17]
    int CalcFactorialN(int Num)
    {
        int Result = 1;
        for (int i = 1; i <= Num; i++)
        {
            Result *= i;
        }
        return Result;
    }

    // [18]
    void PrintFromNumtoOne(int num)
    {
        for (int i = num; i >= 1; i--)
        {
            cout << i << endl;
        }
    }

    // [19]
    void PrintFromOneTo(int Length)
    {
        for (int i = 1; i <= Length; i++)
        {
            cout << i << endl;
        }
    }

    // [20]
    int ReadPositveNumber(string Message)
    {

        int Number;
        cout << Message;
        cin >> Number;
        while (cin.fail() || Number < 0)
        {
            cin.clear();
            cin.ignore(10000, '\n');
            cout << "UnValid Tray again : \n";
            cin >> Number;
        }
        return Number;
    }

    // [21]
    int PowofNumber(int N, int M)
    {
        int Result = 1;
        for (int i = 1; i <= M; i++)
        {
            Result *= N;
        }
        return Result;
    }

    // [22]
    enum enMark
    {
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 0
    };

    enMark MarkofGrade(int Grade)
    {
        if (Grade >= 90)
            return enMark::A;
        else if (Grade >= 80)
            return enMark::B;
        else if (Grade >= 70)
            return enMark::C;
        else if (Grade >= 60)
            return enMark::D;
        else if (Grade >= 50)
            return enMark::E;
        else
            return enMark::F;
    }

    string GettMark(enMark Mark)
    {
        switch (Mark)
        {
        case enMark::A:
            return "A";
            break;
        case enMark::B:
            return "B";
            break;
        case enMark::C:
            return "C";
            break;
        case enMark::D:
            return "D";
            break;
        case enMark::E:
            return "E";
            break;
        default:
            return "ERROR!";
            break;
        }
    }

    // [23]
    int ReverseNumber(int Number)
    {
        int Remainder = 0, Number2 = 0;
        while (Number > 0)
        {
            Remainder = Number % 10;
            Number = Number / 10;
            Number2 = Number2 * 10 + Remainder;
        }
        return Number2;
    }

    // [24]
    int CalcSumDigits(int Number)
    {
        int Remainder = 0, Result = 0;
        while (Number > 0)
        {
            Remainder = Number % 10; // 4   => 3  => 2 => 1
            Number = Number / 10;    // 123 => 12 => 1 => 0
            Result += Remainder;
        };
        return Result;
    }

    //[25]
    int DigitFrequency(int Number, int Digit)
    {
        int DigitIteration = 0;
        int Remainder = 0;
        while (Number > 0)
        {
            Remainder = Number % 10;
            Number = Number / 10;

            if (Remainder == Digit)
                DigitIteration++;
            else
                continue;
        }
        return DigitIteration;
    }

    // [26]
    void PrintNumberDigitsInOrder(int EnNumber)
    { // ex : 1234

        int Number = ReverseNumber(EnNumber);
        int Remainder = 0;
        while (Number > 0)
        {
            Remainder = Number % 10; // 4   => 3  => 2 => 1
            Number = Number / 10;    // 123 => 12 => 1 => 0
            cout << Remainder << endl;
        };
    }

    // [27]
    void PrintNumberInReversedOrder(int Number)
    {
        int Remainder = 0, Result = 0;
        while (Number > 0)
        {
            Remainder = Number % 10; // 4   => 3  => 2 => 1
            Number = Number / 10;    // 123 => 12 => 1 => 0
            cout << Remainder << endl;
        };
    }
}