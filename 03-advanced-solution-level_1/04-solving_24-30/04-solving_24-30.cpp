#include <iostream>
using namespace std;

/////////////////////////////////////

enum enAgeState { Valid = 1 , Unvalid = 0 };

void ReadAge(int &Age)
{
    cout << "enter your age : ";
    cin >> Age;
}

enAgeState CheckAge(int &Age)
{
    if(Age < 18 || Age > 45)
        return enAgeState::Unvalid;
    else
        return enAgeState::Valid;
}

void PrintAgeState(enAgeState AgeState)
{
    if(AgeState == enAgeState::Valid)
        cout << "The Entered Age is Valid \n";
    else
        cout << "The Entered Age is Unvalid \n";
}

/////////////////////////////////////
// ReadValidAge while CheckAge(ReadAge) != enAgeState::Valid ReadAge

// enAgeState ReadValidAge(int &Age)
// {
//     ReadAge(Age);
//     while(CheckAge(Age) != enAgeState::Valid){
//         ReadAge(Age);
//     }
//     return enAgeState::Valid;
// }

enAgeState ReadValidAge(int &Age)
{
    do{
        ReadAge(Age);
    }while(CheckAge(Age) != enAgeState::Valid);

    return enAgeState::Valid;
}

/////////////////////////////////////

int ReadEnteredN()
{
    int Num;
    cout << "Enter a Number you want to print from 1 to its\n";
    cin >> Num;
    return Num;
}

void PrintFromOneTo(int Length)
{
    for(int i=1; i<=Length; i++){
        cout << i << endl;
    }
}

/////////////////////////////////////

void PrintFromNumtoOne(int num)
{
    for(int i=num; i>=1; i--){
        cout << i << endl;
    }
}

/////////////////////////////////////

int ReadEnteredNum()
{
    int Num;
    cout << "Enter a Number you want to stop on it\n";
    cin >> Num;
    return Num;
}

bool checkOddNumber(int Num)
{
    return Num%2 !=0;
}

int calcOddSum(int Length)
{
    int SumResult = 0;
    for(int i=1; i<=Length; i++){
       if( checkOddNumber(i))
            SumResult += i;
        else
            continue;
    }
    return SumResult ;
}

void PrintSumofOddNums( int SumResult)
{
    cout << "the Sum Result of Odd Nums is : " << SumResult << endl ;
}

/////////////////////////////////////

int calcEvenSum(int Length)
{
    int SumResult = 0;
    for(int i=1; i<=Length; i++){
       if( checkOddNumber(i))
            continue;
        else
            SumResult += i;
    }
    return SumResult ;
}

void PrintSumofEvenNums( int SumResult)
{
    cout << "the Sum Result of Even Nums is : " << SumResult << endl ;
}

/////////////////////////////////////

int ReadN()
{
    int Num;
    cout << "enter Number to return Factorial of it : ";
    cin >> Num;
    return Num;
}

int CalcFactorialN(int Num)
{
    int Result = 1;
    for(int i=1; i<=Num;i++){
        Result *= i;
    }
    return Result;

}

void PrintFactorialN(int Result)
{
    cout << "the Factorial of Number is : " << Result << endl;
}

/////////////////////////////////////


/////////////////////////////////////

int main ()
{
    // [24] check if Age is Vaild or Not
    int Age;
    ReadAge(Age);
    PrintAgeState(CheckAge(Age));

    // [25] check if Age is Vaild or Not and enter only a valid Age
    PrintAgeState(ReadValidAge(Age));

    // [26] print from 1 to n
    PrintFromOneTo(ReadEnteredN());

    // [27] print from n to 1
    PrintFromNumtoOne(ReadEnteredN());

    // [28] Print The Sum of odd NumbersFrom 1 to n 
    PrintSumofOddNums(calcOddSum(ReadEnteredNum()));

    // [29] Print The Sum of Even NumbersFrom 1 to n 
    PrintSumofEvenNums(calcEvenSum(ReadEnteredNum()));

    // [30] Print Factorial of Entered Number
    PrintFactorialN(CalcFactorialN(ReadN()));



    return 0;
}