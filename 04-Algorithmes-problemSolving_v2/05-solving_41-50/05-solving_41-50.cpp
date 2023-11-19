#include <iostream>
#include <cstdlib>
#include <cmath>
using namespace std;

int RandomNumber(int From,int To)
{
    return (rand() % (To - From + 1) + From );
}

void FillArrayWithRandomNums(int Nums[100],int Length)
{
    for(int i = 0 ;i <= Length-1; i++)
    {
        Nums[i] = RandomNumber(-100,100);
    }
}

void PrintArry(int nums[100],int length)
{
    for(int i = 0;i <= length-1; i++)
    {
        cout << nums[i] << " ";
    }
    cout << endl;
}
/////////////////////////////////////////
// Hard Code
void FillArray_1(int Array[100],int &Length)
{
    Length = 10;
    Array[0] = 10; 
    Array[1] = 20; 
    Array[2] = 7; 
    Array[3] = 70; 
    Array[4] = 12; 
    Array[5] = 12; 
    Array[6] = 70; 
    Array[7] = 7; 
    Array[8] = 20; 
    Array[9] = 10; 
}
void FillArray_2(int Array[100],int &Length)
{
    Length = 9;
    Array[0] = 10; 
    Array[1] = 20; 
    Array[2] = 7; 
    Array[3] = 70; 
    Array[4] = 12; 
    Array[5] = 70; 
    Array[6] = 7; 
    Array[7] = 20; 
    Array[8] = 10; 
}

bool IsPalindromeArray(int Array[100],int Length)
{
    bool IsPalindrome = true;
    // Length = floor(Length/2);
    for(int i = 0; i <= floor(Length/2) - 1; i++)
    {
        // ex: 10 / 2
        // start from Begining [i] 0
        // start from the End [Length- 1 -i] 9 8 7 6 5 4 3 2 1 0
        if(Array[i] == Array[Length- 1 -i])
            continue;
        else
            IsPalindrome = false;

    }
    return IsPalindrome;
}

/////////////////////////////////////////
bool IsOod(int Digit)
{
    return (Digit % 2 !=0);
}
bool IsEven(int Digit)
{
    return (Digit % 2 ==0);
}

int CountOodNums(int Array[100],int Length)
{
    int OodCount = 0;
    for(int i = 0; i<= Length -1; i++)
    {
        if(IsOod(Array[i]))
            OodCount++;
        else
            continue;
    }
    return OodCount;

}
int CountEvenNums(int Array[100],int Length)
{
    int EvenCount = 0;
    for(int i = 0; i<= Length -1; i++)
    {
        if(IsEven(Array[i]))
            EvenCount++;
        else
            continue;
    }
    return EvenCount;

}
/////////////////////////////////////////
bool IsPositive(int Number)
{
    return Number > 0;
}
bool IsNegative(int Number)
{
    return Number < 0;
}

int CountPositiveNums(int Array[100],int Length)
{
    int PositiveCount = 0;
    for(int i = 0; i <=Length - 1; i++)
    {
        if(IsPositive(Array[i]))
            PositiveCount++;
        else
            continue;
    }

    return PositiveCount;
}
int CountNegativeNums(int Array[100],int Length)
{
    int NegativeCount = 0;
    for(int i = 0; i <=Length - 1; i++)
    {
        if(IsNegative(Array[i]))
            NegativeCount++;
        else
            continue;
    }

    return NegativeCount;
}
/////////////////////////////////////////

float MyAbs(int Number)
{
    if(Number >= 0 )
        return Number;
    else 
        return Number * -1;
}

float GetFractionNumber(float Number)
{
    // 
    return Number - (int) Number ;
}

int MyRound(float Number)
{
    int IntNumber = int(Number);
    float FractionNumber = GetFractionNumber(Number);
    if(abs(FractionNumber) >= .5)
    {
        if(Number >= 0)
            return IntNumber +=1;
        else
            return IntNumber -=1;
    }
    else
        return IntNumber;
}

int MyFloor(float Number)
{
    // to Smallest Number
    int IntNumber = int(Number);
    float FractionNumber = GetFractionNumber(Number);

    if(Number >= 0)
        return IntNumber;
    else
        return IntNumber -=1;
    
}

int MyCeil(float Number)
{
    // to Smallest Number
    int IntNumber = int(Number);
    float FractionNumber = GetFractionNumber(Number);

    if(Number >= 0)
        return ++IntNumber;
    else
        return IntNumber;
    
}

int MySqrt(int Number)
{
    return pow(Number , .5);
}
/////////////////////////////////////////
int main()
{
    srand((unsigned)time(NULL));
    // [41] Check if Array is Palindrome or Not
    int Array_1[100],Array_2[100],LengthOfArray_1,LengthOfArray_2;
    FillArray_1(Array_1,LengthOfArray_1);
    FillArray_2(Array_2,LengthOfArray_2);
    PrintArry(Array_1,LengthOfArray_1);
    if(IsPalindromeArray(Array_1,LengthOfArray_1)) // ==><==
        cout << "Yes, Array is Palindrome\n";
    else
        cout << "No, Array is Not Palindrome\n";

    PrintArry(Array_2,LengthOfArray_2);
    if(IsPalindromeArray(Array_2,LengthOfArray_2)) // ==><==
        cout << "Yes, Array is Palindrome\n";
    else
        cout << "No, Array is Not Palindrome\n";


    // [42-43] Count ood and Even Numbers in Array
    int Array_3[10]={12,3,4,52,55,1,80,32,23,6}; // ood = 4
    int LengthOfArray_3 = 10;
    PrintArry(Array_3,LengthOfArray_3);
    cout << "The Count of ood Numbers is : " <<CountOodNums(Array_3,LengthOfArray_3) <<endl;
    cout << "The Count of Even Numbers is : " <<CountEvenNums(Array_3,LengthOfArray_3) <<endl;

    // [44,45] Count Positive and Negative Numbers in Random Array
    int Array_4[100],LengthOfArray_4 = 10;
    FillArrayWithRandomNums(Array_4,LengthOfArray_4);
    PrintArry(Array_4,LengthOfArray_4);
    cout << "The Count of Positive Numbers is : " <<CountPositiveNums(Array_4,LengthOfArray_4) <<endl;
    cout << "The Count of Negative Numbers is : " <<CountNegativeNums(Array_4,LengthOfArray_4) <<endl;

    // [46] Ads function -10 => 10
    cout <<"C++ abs Function " << abs(-10) << endl;
    cout <<"My abs Function  " << MyAbs(-10) << endl;
    
    // [47] round function 10,7 => 11 , -10,7 => -11
    cout <<"C++ round Function " ;
    cout << round(10.3) <<" "<< round(-10.3) <<" " << round(10.7) <<" " << round(-10.7)<< endl;
    cout <<"My round Function  " ;
    cout << MyRound(10.3) <<" " << MyRound(-10.3) <<" " << MyRound(10.7) <<" " << MyRound(-10.7)<< endl;

    // [48] floor function 10,7 => 10 , -10,7 => -11 (the Smallest N)
    cout <<"C++ floor Function " ;
    cout << floor(10.3) <<" "<< floor(-10.3) <<" " << floor(10.7) <<" " << floor(-10.7)<< endl;
    cout <<"My floor Function  " ;
    cout << MyFloor(10.3) <<" " << MyFloor(-10.3) <<" " << MyFloor(10.7) <<" " << MyFloor(-10.7)<< endl;

    // [49] ceil function 10,7 => 11 , -10,7 => -10  (the bigest N)
    cout <<"C++ ceil Function " ;
    cout << ceil(10.3) <<" "<< ceil(-10.3) <<" " << ceil(10.7) <<" " << ceil(-10.7)<< endl;
    cout <<"My ceil Function  " ;
    cout << MyCeil(10.3) <<" " << MyCeil(-10.3) <<" " << MyCeil(10.7) <<" " << MyCeil(-10.7)<< endl;

    // [50] sqrt function 25 => 5
    cout <<"C++ sqrt Function " ;
    cout << sqrt(25) <<" "<< sqrt(16) <<" " << sqrt(9) <<" " << sqrt(4)<< endl;
    cout <<"My sqrt Function  " ;
    cout << MySqrt(25) <<" " << MySqrt(16) <<" " << MySqrt(9) <<" " << MySqrt(4)<< endl;

    return 0;
}