#include <iostream>
using namespace std;

// folowing the SOLID
void Print_name1()
{
    cout << "ahmed\n";
}

string ReadEnteredName()
{
    string name ;
    cout << "please enter your name ... \n";
    // getline(cin,name);
    cin >> name;
    return name;
}

void PrintEnteredName(string enteredName)
{
    cout << "your name is " << enteredName << endl;
}

////////////////////////////

enum enNumberType {odd=1,Even=2};
int ReadEnteredNumber()
{
    int number;
    cout << "please enter a number to check. is it Even or odd? \n";
    cin >> number;
    return number;
}

enNumberType CheckNumberType(int Number)
{
    int Result = Number % 2;
    if (Result == 0)
        return enNumberType::Even; // 2 label to EvenNumber
    else 
        return enNumberType::odd; // 1 label to OddNumber
}

void PrintResults (enNumberType NumberType)
{
    if (NumberType == enNumberType::Even)
        cout << "the entered number is Even \n";
    else 
        cout <<"the entered number is odd \n";
}

///////////////////////////

struct stDriverInfo
{
    int Age;
    bool hasDriverLicense;
};

stDriverInfo ReadDriverInfo ()
{
    stDriverInfo DriverInfo;
    cout << "************************ \n\n";
    cout << "Welcome to our System\n";
    cout << "Please enter your Age : ";
    cin >> DriverInfo.Age;
    cout << "Please enter your DriverLicense : ";
    cin >> DriverInfo.hasDriverLicense;
    cout << "************************ \n\n";
    return DriverInfo;
}

bool CheckDriver(stDriverInfo DriverInfo)
{
    return (DriverInfo.Age >= 21 && DriverInfo.hasDriverLicense);
}

void PrintDriverResult(stDriverInfo DriverInfo)
{
    if(CheckDriver (DriverInfo))
        cout << "Hired\n";
    else
        cout << "Rejected\n";
}

///////////////////////////

struct stDriverInfo_v2
{
    int Age;
    bool hasDriverLicense;
    bool hasRecommendtion;
};

stDriverInfo_v2 ReadDriverInfo_v2 ()
{
    stDriverInfo_v2 DriverInfo;
    cout << "************************ \n\n";
    cout << "Welcome to our System version 2 \n";
    cout << "Please enter your Age : ";
    cin >> DriverInfo.Age;
    cout << "Please enter your DriverLicense : ";
    cin >> DriverInfo.hasDriverLicense;
    cout << "Please enter your Recommendtion : ";
    cin >> DriverInfo.hasRecommendtion;
    cout << "************************ \n\n";
    return DriverInfo;
}

bool CheckDriver_v2(stDriverInfo_v2 DriverInfo)
{
    return (DriverInfo.hasRecommendtion ||(DriverInfo.Age >= 21 && DriverInfo.hasDriverLicense));
}

void PrintDriverResult_v2(stDriverInfo_v2 DriverInfo)
{
    if(CheckDriver_v2 (DriverInfo))
        cout << "Hired\n";
    else
        cout << "Rejected\n";
}






int main()
{
    // [1] print name
    Print_name1();

    // [2] print entered name
    PrintEnteredName(ReadEnteredName());

    // [3] Even or odd
    PrintResults(CheckNumberType(ReadEnteredNumber()));

    // [4] Hire or Rejecte the driver
    PrintDriverResult(ReadDriverInfo());

    // [5] Hire or Rejecte the driver + hasrecommendation?
    PrintDriverResult_v2(ReadDriverInfo_v2());
    return 0;
}