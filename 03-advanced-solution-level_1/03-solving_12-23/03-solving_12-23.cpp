#include <iostream>
using namespace std;

///////////////////////////////////////

struct stNums
{
    int Num1;
    int Num2;
    int Num3;
};

stNums ReadEnteredNums()
{
    stNums Nums;
    cout << "Please Enter Numbers and we will tell you the biggest Number\n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    return Nums;
}

int CheckBiggestNumber(stNums Nums)
{
    if(Nums.Num1 > Nums.Num2)
        return Nums.Num1;
    else 
        return Nums.Num2;
}

void PrintBiggestNumber(int Num)
{
    cout << "The Biggest Number is : " << Num << endl;
}

///////////////////////////////////////

stNums ReadEnteredNums_v2()
{
    stNums Nums;
    cout << "Please Enter Numbers and we will tell you the biggest Number\n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    cin >> Nums.Num3;
    return Nums;
}

int CheckBiggestNumber_v2(stNums Nums){
    if (Nums.Num1 > Nums.Num2 ) {
        if (Nums.Num3 > Nums.Num1 ) 
            return Nums.Num3;
        else 
            return Nums.Num1;
   }else
    {
        if (Nums.Num3 > Nums.Num2) 
            return Nums.Num3;
        else 
            return Nums.Num2;
    }
}

///////////////////////////////////////

stNums ReadNumbers()
{
    stNums Nums;
    cout << "enter 2 Numbers to Swap it\n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    return Nums;
}

stNums SwapNumbers(stNums Nums)
{
    int temp;
    temp = Nums.Num1;
    Nums.Num1 = Nums.Num2;
    Nums.Num2 = temp;
    return Nums;
}

void PrintSwapResult(stNums Nums)
{
    cout << "the Result of Swap is \n";
    cout << Nums.Num1 << " " << Nums.Num2 << endl;
}

///////////////////////////////////////
stNums ReadSqNums()
{
    stNums Nums;
    cout << "Please Enter 2 Numbers to calcuate the Square area \n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    return Nums;
}

float CalcRectangular_area(stNums Nums)
{
    float Result =  Nums.Num1 * Nums.Num2;
    return Result;
}

void PrintResult(float Number)
{
    cout << "the Result of The Last Calculation is : " << Number <<endl;
}

///////////////////////////////////////

stNums ReadTrNums()
{
    stNums Nums;
    cout << "Please Enter 2 Numbers to calcuate the Triangle area \n";
    cin >> Nums.Num1;
    cin >> Nums.Num2;
    return Nums;
}

float CalcTriangle_area(stNums Nums)
{
    float Result = (.5 * Nums.Num1) * Nums.Num2;
    return Result;
} 

int main()
{
    // [12] print the bigest number of 2 numbers
    PrintBiggestNumber(CheckBiggestNumber(ReadEnteredNums()));

    // [13] print the bigest number of 3 numbers
    PrintBiggestNumber(CheckBiggestNumber_v2(ReadEnteredNums_v2()));
    
    // [14] swap Nums
    PrintSwapResult(SwapNumbers(ReadNumbers()));
    
    // [15] calcu square area   = a * b
    PrintResult(CalcRectangular_area(ReadSqNums()));

    // [16] calcu triangle area = (.5 * a) * h
    PrintResult(CalcTriangle_area(ReadTrNums()));

    // [18 : 23 ] folow the same pattern as 15,16 => calculating the area of Circle ...,ect 

    return 0;
}