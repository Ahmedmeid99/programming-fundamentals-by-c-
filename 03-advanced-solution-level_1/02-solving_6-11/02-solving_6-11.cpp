#include <iostream>
using namespace std;


////////////////////////////////

struct stUserInfo
{
    string FirstName;
    string LastName;
};

stUserInfo ReadUserInfo()
{
    stUserInfo UserInfo;
    cout << "*******************************\n";
    cout << "please enter your first name : ";
    cin >> UserInfo.FirstName;
    cout << "please enter your lase name : ";
    cin >> UserInfo.LastName;
    cout << "*******************************\n";
    return UserInfo;
}

void PrintUserFullName (stUserInfo UserInfo)
{
    cout << "your FullName is \n";
    cout << UserInfo.FirstName + " " + UserInfo.LastName << endl;
}

////////////////////////////////

int ReadEnteredNumber()
{
    int number;
    cout << "You want to calculate the half of number so \n";
    cout << "Please enter Number : ";
    cin >> number;
    return number;
}

float CalcuHalfNumber(float Number)
{
    float result = Number / 2;
    return result ;
}

void PrintHalfNumber(float HalfNumber)
{
    cout << " the half of number is " << HalfNumber << endl;
}

////////////////////////////////

enum enExamResult {Pass=1,Fail=0};

int ReadExamResult()
{
    int ExamResult;
    cout << "--------------------\n";
    cout << "Enter your Exam Result : ";
    cin >> ExamResult ;
    return ExamResult;
};

enExamResult checkExamResult (int ExamResult)
{
    if (ExamResult >= 50)
        return enExamResult::Pass;
    else
        return enExamResult::Fail;
}

void PrintExamResult(enExamResult ExamResult)
{
    if(ExamResult == enExamResult::Pass)
        cout << "Pass the Exam\n";
    else
        cout << "Fail the Exam\n";
        
}

////////////////////////////////

struct stNums
{
    int Num1;
    int Num2;
    int Num3;
};

stNums ReadEnteredNums()
{
    stNums Nums;
    cout << "Please enter 3 numbers \n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    cin >> Nums.Num3;
    return Nums;
};

int CalcSum(stNums Nums)
{
    int Result = Nums.Num1 + Nums.Num2 + Nums.Num3;
    return Result;
}

void PrintResult(int SumResult)
{
    cout << "the result is " <<  SumResult << endl;
}

////////////////////////////////

int CalcAvarge (stNums Nums)
{
    return CalcSum(Nums) / 3;
}

////////////////////////////////


int main()
{
    // [6] print FullName from user_FirstName & user_FirstName
    PrintUserFullName(ReadUserInfo());

    // [7] Print Half of Entered Number
    PrintHalfNumber(CalcuHalfNumber(ReadEnteredNumber()));

    // [8] Pass of Fill
    PrintExamResult(checkExamResult(ReadExamResult()));

    // [9] Sum 3 Entered Numbers
    PrintResult(CalcSum(ReadEnteredNums()));

    // [10] calc the avarge of 3 grads
    PrintResult(CalcAvarge(ReadEnteredNums()));

    // [11] print Pass or fail => avarge
    PrintExamResult(checkExamResult(CalcAvarge(ReadEnteredNums())));
    return 0 ;
};