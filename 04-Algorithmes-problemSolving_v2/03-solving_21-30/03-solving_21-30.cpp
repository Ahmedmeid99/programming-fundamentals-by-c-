#include <iostream>
#include <string>
#include <cmath>
#include <cstdlib>
using namespace std;

////////////////////////////////////
int ReadInputNumber(string Message)
{
    int Number;
    do{
        cout << Message ;
        cin >> Number;
    }while(Number < 0);
    
    return Number;
}

int ReverseNumber(int Number)
{
    int Remainder = 0, Number2 = 0;
    while(Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        Number2 = Number2 * 10 + Remainder;
    }
    return Number2;
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
////////////////////////////////////
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

void GenerateKeys(int Number)
{
    for(int i = 1;i <= Number; i++)
    {
        cout << "Key ["<<i<<"] : ";
        cout << GenerateKey();
        cout << endl;
        
    }
}
////////////////////////////////////

void EnterArrayItems(int nums[100],int length)
{
    for(int i = 0 ;i <= length-1; i++)
    {
        string Message = ("Element [" +to_string(i+1) +"] : ");
        nums[i] = ReadInputNumber(Message);
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

///////////////////////////////////

void CreatRandomArray(int Nums[100],int Length)
{
    for(int i = 0 ;i <= Length-1; i++)
    {
        Nums[i] = RandomNumber(1,100);
    }
}

int MaxItemInArray(int Nums[100],int Length)
{
    int MaxNumer = 0;
    for(int i = 0 ;i <= Length-1; i++)
    {
        if(MaxNumer < Nums[i])
            MaxNumer = Nums[i];
        else
            continue;
    }
    return MaxNumer;
}

int MinItemInArray(int Nums[100],int Length)
{
    int MinNumer = 0;
    for(int i = 0 ;i <= Length-1; i++)
    {
        MinNumer = Nums[i];
        if(MinNumer > Nums[i])
            MinNumer = Nums[i];
        else
            continue;
    }
    return MinNumer;
}

int SumOfArrayNumbers(int Nums[100],int Length)
{
    int Sum = 0;
    for(int i = 0 ;i <= Length-1; i++)
    {
        Sum += Nums[i];
    }
    return Sum;
}

int AverageOfArrayNumbers(int Nums[100],int Length)
{
    int Sum = SumOfArrayNumbers(Nums,Length);
    return Sum / Length;
}

void CopyedArray(int arr1[100],int &Length1,int arr2[100],int Length2)
{
    for(int i = 0 ;i <= Length2-1; i++)
    {
        arr1[i]= arr2[i];
    }
    Length1 = Length2;
}

void CopyedPrimeArray(int arr1[100],int &Length1,int arr2[100],int Length2)
{
    int CountItems = 0;
    for(int i = 0 ;i <= Length2-1; i++)
    {
        if (IsPrim(arr2[i]))
        {    
            arr1[CountItems]= arr2[i];
            CountItems++;
        }
        else
            continue;
    }
    Length1 = CountItems;
}

void CreatArrayofSum2Arrayelement(int ArrayofSum[100])
{
    int arr1[100],arr2[100];
    int arraySize= ReadInputNumber("Enter the Size of Arrays you want to create ");
    CreatRandomArray(arr1,arraySize);
    CreatRandomArray(arr2,arraySize);
    cout << "Array 1 elements : ";
    PrintArry(arr1,arraySize);
    cout << "Array 2 elements : ";
    PrintArry(arr2,arraySize);

    for(int i = 0 ;i <= arraySize-1; i++)
    {
        ArrayofSum[i]= arr1[i] + arr2[i];
    }
    cout << "Sum of Array1 and Array2 elements : ";
    PrintArry(ArrayofSum,arraySize);
}


int main()
{
    srand((unsigned)time(NULL));
    // [21] Creat Number of Keys like Key [1] : YZER-GBDD-LSIF-BSRV
    GenerateKeys(5);

    /* [22] Program Read N element and stroe them in array and print array elements 
       and ask user to enter number to check how many times is this number is repeted? */
    int array[100];
    int arraySize= ReadInputNumber("Enter Size of Array you want to create ");
    EnterArrayItems(array,arraySize);
    cout << "Original array : " ;
    PrintArry(array,arraySize);
    int NumberCheck= ReadInputNumber("how many times is this number is repeted? ");
    cout << NumberCheck<< " is Repeted "<<CheckItemInArray(array,arraySize,NumberCheck) << " Time(s)\n";
    
    // [23] Enter Length and Create array of Random Numbers
    int array2[100];
    int array2Size= ReadInputNumber("Enter Size of Array you want to create ");
    CreatRandomArray(array2,array2Size);
    cout << "Array Elements : ";
    PrintArry(array2,array2Size);

    // [24] Max Element in Array
    cout << "Max Number is : " << MaxItemInArray(array2,array2Size) << endl;
    
    // [25] Min Element in Array
    cout << "Min Number is : " << MinItemInArray(array2,array2Size) << endl;

    // [26] Sum of Array Element
    cout << "Sum is : " << SumOfArrayNumbers(array2,array2Size) << endl;

    // [27] Average of Array
    cout << "Average of Array is : " << AverageOfArrayNumbers(array2,array2Size) << endl;

    // [28] Copy the array
    int array1[100];
    int array1Size;
    CopyedArray(array1,array1Size,array2,array2Size);
    cout << "Copyed Array is ";
    PrintArry(array1,array1Size);

    // [29] copy only Prime Number in Anther Array
    int PrimeArray[100];
    int PrimeArraySize;
    CopyedPrimeArray(PrimeArray,PrimeArraySize,array2,array2Size);
    cout << "Copyed Prime Array is ";
    PrintArry(PrimeArray,PrimeArraySize);

    // [30] Create 2  Random Arrays and Sum their element in third Array and print the results
    int ArrayofSum[100];
    CreatArrayofSum2Arrayelement(ArrayofSum);
    return 0;
}