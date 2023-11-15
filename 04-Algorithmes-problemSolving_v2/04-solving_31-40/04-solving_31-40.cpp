#include <iostream>
#include <cstdlib>
using namespace std;

/////////////////////////////////
int ReadInputNumber(string Message)
{
    int Number;
    do{
        cout << Message ;
        cin >> Number;
    }while(Number < 0);
    
    return Number;
}
/////////////////////////////////

enum enCharType {SmallLetter = 1,CapitalLetter = 2,SpecialCharacter = 3,Digit = 4};

int RandomNumber(int From,int To)
{
    return (rand() % (To - From + 1) + From );
}

char Random_of(enCharType CharType)
{
    switch (CharType)
    {
    case enCharType::SmallLetter :
        return char(RandomNumber(97,122));
        break;
    case enCharType::CapitalLetter :
        return char(RandomNumber(65,90));
        break;
    case enCharType::SpecialCharacter :
        return char(RandomNumber(33,47));
        break;
    case enCharType::Digit :
        return char(RandomNumber(48,57));
        break;
    
    default:
        break;
    }
}

string GenerateKey()
{
    string Key= "";
    for(int i = 1;i <= 16; i++)
    {
        //  Key [1] : YZER-GBDD-LSIF-BSRV
        if(i % 4 == 0 && i != 16)
        { 
            Key+= Random_of(enCharType::CapitalLetter);
            Key+="-";
        }
        else
        {
            Key+= Random_of(enCharType::CapitalLetter);
        }

    }
    return Key;
}

/////////////////////////////////

void CreatRandomArray(int Nums[100],int Length)
{
    for(int i = 0 ;i <= Length-1; i++)
    {
        Nums[i] = RandomNumber(1,100);
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

void PrintStArry(string nums[100],int length)
{
    for(int i = 0;i <= length-1; i++)
    {
        cout << nums[i] << " ";
    }
    cout << endl;
}

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

int ArrayofNumbertoNumber(int nums[100],int length)
{
    int Number=0;
    for(int i =length-1 ;i >= 0; i--)
    {
        Number =( Number * 10 ) + nums[i];
    }
    return Number;
}

int CheckItemInArray(int Nums[100],int Length,int Digit)
{
    int Number = ArrayofNumbertoNumber(Nums,Length);
    return DigitFrequency(Number,Digit) ;
}

void CreateOrderedArry(int arr[100],int Length)
{
    for (int i = 0; i <= Length; i++)
    {
        arr[i] = i+1;
    }
}
bool SearchIn(int arr[100],int Length,int Digit)
{
    for(int i = 0; i <= Length; i++)
    {
        if(arr[i] == Digit)
        {
            return 1;
        }
    }
    return 0;
}
void SuffleArray(int SuffleArray[100],int arr[100],int Length)
{
    int coutOfArray = 0;
    while(coutOfArray <= Length)
    {
        int RandN = RandomNumber(1,Length);
        if(SearchIn(SuffleArray,Length,RandN) == 0)
        {
            SuffleArray[coutOfArray] = RandN;
            coutOfArray++;
        }
        else
            continue;
    }
}
////////////////////////////////////////////
void ReverseArray(int arr2[100],int Length2,int ReversedArray[100])
{
    int LengthOfReArray = 0;
    for(int i = Length2-1; i >= 0; i--)
    {
        ReversedArray[LengthOfReArray] = arr2[i];
        LengthOfReArray++;
    }
}
////////////////////////////////////////////
void CreateArrayofKeys(string arr2[100],int Length2)
{
    for(int i = 0; i <= Length2 -1; i++)
    {
        arr2[i] = GenerateKey();
        cout << "Array [" << i+1 << "] : " ;
        cout <<  GenerateKey();
        cout << endl;
    }
}
///////////////////////////////////////////
int PositionSearchIn(int arr[100],int Length,int Digit)
{
    for(int i = 0; i <= Length; i++)
    {
        if(arr[i] == Digit)
        {
            return i;
        }
    }
    return -1;
}

void PrintResultOfSearch(int arr[100],int Length)
{
    CreatRandomArray(arr,Length);
    PrintArry(arr,Length);
    int Digit = ReadInputNumber("Enter A Number to Search for in Array : ");
    int position = PositionSearchIn(arr,Length,Digit);
    cout << " The Number You Looking for is : "<< Digit <<"\n";
    if (position >= 0)
    {
        cout << " The Number Found at Position : "<< position <<"\n";
        cout << " The Number Found its Order : "<< position + 1 <<"\n";
    }
    else
        cout << "The Numberis Not Found :( \n";
}

void PrintResultOfSearchfor(int arr[100],int Length)
{
    CreatRandomArray(arr,Length);
    PrintArry(arr,Length);
    int Digit = ReadInputNumber("Enter A Number to Search for in Array : ");
    int position = PositionSearchIn(arr,Length,Digit);
    cout << " The Number You Looking for is : "<< Digit <<"\n";
    if (position >= 0)
        cout << "The Number is Found :) \n";
    else
        cout << "The Number is Not Found :( \n";
}

int main()
{   
    srand((unsigned)time(NULL));
    // [31] Print array has orderes number from 1 to N and print it after Suffle
    int arr1[100] ,SuffleArr[100];
    // int Length1 = ReadInputNumber("Enter Length of Array You want to create : ");
    // CreateOrderedArry(arr1,Length1);
    // PrintArry(arr1,Length1);
    // SuffleArray(SuffleArr,arr1,Length1);
    // PrintArry(SuffleArr,Length1);

    // [32] Copy  Reversed order  Array from anther array
    int arr2[100], ReversedArray[100];
    // int Length2 = ReadInputNumber("Enter Length of Array You want to create : ");
    // CreatRandomArray(arr2,Length2);
    // PrintArry(arr2,Length2);
    // ReverseArray(arr2,Length2,ReversedArray);
    // PrintArry(ReversedArray,Length2);

    // [33] Read How Many Keys to generate and fill them in Array then print them on the screen
    string arr3[100];
    int Length3 = ReadInputNumber("Enter Length of Keys Array You want to create : ");
    cout << " The Array of Keys You Create is : \n";
    CreateArrayofKeys(arr3,Length3);

    // [34] 
    int arr4[100];
    int Length4 = ReadInputNumber("Enter Length of Array You want to create : ");
    PrintResultOfSearch(arr4,Length4);

    // [35]
    int arr5[100];
    int Length5 = ReadInputNumber("Enter Length of Array You want to create : ");
    PrintResultOfSearchfor(arr5,Length5);



    return 0;
}