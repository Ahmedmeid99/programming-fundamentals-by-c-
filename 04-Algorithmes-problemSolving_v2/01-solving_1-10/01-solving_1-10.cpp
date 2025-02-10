#include <iostream>
#include <string>
#include <cmath>
using namespace std;

/////////////////////////////////////
//         Helpers Functions
int ReadInputNumber(string Message)
{
    int Number;
    do{
        cout << Message << endl;
        cin >> Number;
    }while(Number < 0);
    
    return Number;
}

string ReadInputString(string Message)
{
    string String;
    cout << Message << endl;
    cin >> String;
    return String;
}

void PrintResult(int Result )
{
    cout << "The Result is :" << Result  << endl;
}

/////////////////////////////////////

void PrintMultiplicationTableHeader()
{
    cout << "\n\t\t\tMultiplication Table from 1 to 10 \n\n"; 
    cout << "\t" ;
    for(int i = 1 ; i <= 10 ; i++)
    {
        cout << i << "\t";
    }
    cout <<"\n-----------------------------------------------------------------------------------\n";
}

void PrintMultiplicationTableBody()
{
    for(int i = 1 ; i <= 10 ; i++)
    {
        if (i<10)
            cout << i << "  |\t";
        else
            cout << i << " |\t";
        for(int j = 1 ; j <= 10 ; j++)
        {
            cout << i*j << "\t" ;
        }
        cout << endl;

    }
}

void PrintMultiplicationTable()
{
    PrintMultiplicationTableHeader();
    PrintMultiplicationTableBody();
}

/////////////////////////////////////

bool IsPrim(int Number)
{
    int M = round(Number / 2);
    for(int Counter = 2; Counter <= M; Counter++)
    {
        if(Number % Counter == 0)
            return 0;
    }
        return 1;
}

void PrintPrim(int Number)
{
    for(int i = 1; i<=Number; i++ )
    if(IsPrim(i))
        cout << i << endl;
    else
        continue;
}

/////////////////////////////////////

bool ISPerfect(int N)
{
    int EndPoint = N-1;
    int Total = 0;
    for (int i = 1; i <= EndPoint ;i++)
    {
        if((N % i) == 0)
            Total += i;
        else
            continue;
    }
    return Total == N;
}

void PrintISPerfectResult(int N,bool isPerfect)
{
    if(isPerfect)
        cout << N << " is Perfect Number\n";
    else
        cout << N << " is Not Perfect Number \n";
}

/////////////////////////////////////

void PrintAllPerfectNumbers(int EndPoint)
{
    for (int i = 1; i<= EndPoint;i++ )
    {
        if(ISPerfect(i))
        {
            cout << i << endl;
        }
        
    }
}

/////////////////////////////////////
int ReverseNumber_v1(int Number)
{
    string stNumber = to_string(Number);
    string ReversedNumber = "";
    for(int i= stNumber.length()-1; i>=0; i--)
    {
        ReversedNumber += stNumber[i];
    }   
    return stoi(ReversedNumber) ;
}

/////////////////////////////////////
int ReverseNumber(int Number)
{ // 1234
    int Remainder = 0, Number2 = 0;
    while(Number > 0)
    {
        Remainder = Number % 10;             // 4      3    2    1
        Number = Number / 10;                // 123    12   1    0
        Number2 = Number2 * 10 + Remainder;  // 4      43   432  4321
    }
    return Number2;
}
/////////////////////////////////////
void PrintNumberInReversedOrder(int Number)
{
    int Remainder = 0, Result = 0;
    while(Number > 0)
    {
    Remainder = Number % 10; // 4   => 3  => 2 => 1
    Number = Number / 10;   // 123 => 12 => 1 => 0
    cout << Remainder << endl;
    };

}

void PrintNumberDigitsInOrder_v1(int Number)
{
    string stNumber = to_string(Number);
    for(int i=0; i<= stNumber.length()-1;  i++)
    {
        cout << stNumber[i] << endl;
    }
}

/////////////////////////////////////

int CalcSumDigits(int Number)
{
    int Remainder = 0, Result = 0;
    while(Number > 0)
    {
    Remainder = Number % 10; // 4   => 3  => 2 => 1
    Number = Number / 10;   // 123 => 12 => 1 => 0
    Result +=Remainder;
    };
    return Result;
}

/////////////////////////////////////

int DigitFrequency(int Number ,int  Digit)
{
    int DigitIteration = 0;
    int Remainder = 0;
    while(Number >0)
    {
        Remainder = Number % 10;
        Number = Number / 10;

        if(Remainder == Digit)
            DigitIteration++;
        else
            continue;

    }
    return DigitIteration;
}

/////////////////////////////////////

void PrintAllDigitFrequency(int Number)
{
     int DigitIteration = 0;
    for(int i = 0 ; i <= 10; i++)
    {
        DigitIteration =DigitFrequency(Number,i);
        if(DigitIteration > 0)
            cout << "Digit " << i << " Frequency is : "<< DigitIteration <<" Time(s)\n";

    }
    
}

/////////////////////////////////////

void PrintNumberDigitsInOrder(int EnNumber)
{   //ex : 1234

    int Number = ReverseNumber(EnNumber);
    int Remainder=0;
    while(Number > 0)
    {
    Remainder = Number % 10; // 4   => 3  => 2 => 1
    Number = Number / 10;   // 123 => 12 => 1 => 0
    cout << Remainder << endl;
    };
}

int main()
{
    // [1] Print The Multiplication Table from 1 to 10
    PrintMultiplicationTable();

    // [2] Print all prim number from 1 to N 
    PrintPrim(ReadInputNumber("enter a positve number and we will return all prim number under it"));

    // [3] return Number is  Perfect or Not 6 = 1 + 2 + 3
    int N = ReadInputNumber("Enter Positeve Number to get if it was Perfect or Not");
    PrintISPerfectResult(N,ISPerfect(N));
    
    // [4] return all  Perfect Number betwen 1 to n
    int NumberOfPerfect = ReadInputNumber("Enter Positeve Number to get all Perfect Number to this Number ");;
    PrintAllPerfectNumbers(NumberOfPerfect);
    
    // [5] Print Number in a reversed order
    int Number = ReadInputNumber("Enter Number to Print it in a reversed order");
    PrintNumberInReversedOrder(Number);

    // [6] Print Sum of Number digits 
    int Num = ReadInputNumber("Enter Number to Sum its digits");
    int Sum = CalcSumDigits(Num);
    PrintResult(Sum);

    // [7] Enter Number and Print it reversed 
    int EnNumber = ReadInputNumber("Enter Number to Print it reversed");
    int ReversedNumber = ReverseNumber(EnNumber);
    PrintResult(ReversedNumber);

    // [8] Digit Frequency 122322 (2)=>Digit 2 Frequency is 4 Time(s)
    int Numbers = ReadInputNumber("Enter Number to Calculate Digit Frequency");
    int NumberFrequency = ReadInputNumber("How Many is this Number repeted? Enter Number : ");
    int NumberOfDigitFrequency = DigitFrequency(Numbers,NumberFrequency);
    PrintResult(NumberOfDigitFrequency);

    // [9] Digit Frequency from 1 to N
    int EnNumbers = ReadInputNumber("Enter Number to Calculate All Digit Frequency");
    PrintAllDigitFrequency(EnNumbers);

    // [10] Print Number Digits in order 
    int Number2 = ReadInputNumber("Enter Number to Print its Digits in order");
    PrintNumberDigitsInOrder(Number2);

    return 0;
}