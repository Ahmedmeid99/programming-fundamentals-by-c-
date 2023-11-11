#include <iostream>
#include <cmath>
#include <string>
using namespace std;


///////////////////////////////

int ReadNumber(string Massage)
{
    int Number;
    cout << Massage;
    cin >> Number;
    return Number;
}

///////////////////////////////

float HoursToDays(float NumberOfHours)
{
    int HoursInDay = 24 ;
    float Result = NumberOfHours/HoursInDay;
    return Result;
}

float HoursToWeeks(float NumberOfHours)
{
    int HoursInWeek = 24 * 7;
    float Result = NumberOfHours/HoursInWeek;
    return Result;
}

float DaysToWeeks(float NumberOfDays)
{
    int DaysInWeek =  7;
    float Result = NumberOfDays/DaysInWeek;
    return Result;
}

void PrintResults(string Message,float Value)
{
    cout << Message << Value << endl;
}

///////////////////////////////

struct stWorkTime
{
    int Days;
    int Hours;
    int Minutes;
    int Seconds;
};

stWorkTime ReadWorkTime(){

    stWorkTime WorkTime;
    cout << "************************************************\n";
    cout << "Enter you work tim in Days Hours Minutes Seconds \n";
    WorkTime.Days = ReadNumber("Enter Days : ");
    WorkTime.Hours = ReadNumber("Enter Hours : ");
    WorkTime.Minutes = ReadNumber("Enter Minutes : ");
    WorkTime.Seconds = ReadNumber("Enter Seconds : ");
    cout << "************************************************\n";

    return WorkTime;
}

int MinutestoSeconds(int Minutes)
{
    int SecondInMinutes = 60;

    return  Minutes * SecondInMinutes;
}

int HourstoSeconds(int Hours)
{
    int SecondInHours = 60 * 60;

    return  Hours * SecondInHours;
}

int DaystoSeconds(int Days)
{
    int SecondInDay = 24 * 60 * 60;

    return  Days * SecondInDay;
}

int CalcTimeInSecond(stWorkTime WorkTime)
{
    int MtoSeconds = MinutestoSeconds(WorkTime.Minutes);
    int HtoSeconds = HourstoSeconds(WorkTime.Hours);
    int DtoSeconds = DaystoSeconds(WorkTime.Days);
    int TotalSeconds = WorkTime.Seconds + MtoSeconds + HtoSeconds + DtoSeconds ;
    return TotalSeconds;
}

///////////////////////////////

string Calc_DHMS_FromSecond(int TotalSecond)
{
    const int SecondsPerDay = 24 * 60 * 60;
    const int SecondsPerHour = 60 * 60;
    const int SecondsPerMinute = 60;

    int NumberOfDays = floor(TotalSecond / SecondsPerDay);
    int Remender = TotalSecond % SecondsPerDay;
    int NumberOfHours = floor(Remender / SecondsPerHour);
    Remender = Remender % SecondsPerHour;
    int NumberOfMinutes = floor(Remender / SecondsPerMinute);
    Remender = Remender % SecondsPerMinute;
    int NumberOfSeconds = Remender;

    string Result= to_string(NumberOfDays)+":"+to_string(NumberOfHours) +":"+to_string(NumberOfMinutes)+":"+to_string(NumberOfSeconds);
    return Result;


}

int ReadNumberInRange(int Start, int End)
{
    int Number;
    do
    {
        cout << "Enter Number betwen" << Start <<  "and " << End << " : ";
        cin >> Number ;
    }while(Number < Start || Number > End);
        return Number;
}

enum enDays {Sat = 1, Sun = 2, Mo = 3, Tue = 4, Wes = 5, Thu = 6, Fr = 7};

enDays NumberToDay(int Number)
{
    switch (Number)
    {
    case enDays::Sat:
        return enDays::Sat;
        break;
    case enDays::Sun:
        return enDays::Sun;
        break;
    case enDays::Mo:
        return enDays::Mo;
        break;
    case enDays::Tue:
        return enDays::Tue;
        break;
    case enDays::Wes:
        return enDays::Wes;
        break;
    case enDays::Thu:
        return enDays::Thu;
        break;
    case enDays::Fr:
        return enDays::Fr;
        break;
    
    default:
        return enDays::Sat;
        break;
    }
}

string GetDay(enDays Day)
{
    switch (Day)
    {
    case enDays::Sat:
        return "Sat";
        break;
    case enDays::Sun:
        return "Sun";
        break;
    case enDays::Mo:
        return "Mo";
        break;
    case enDays::Tue:
        return "Tue";
        break;
    case enDays::Wes:
        return "Wes";
        break;
    case enDays::Thu:
        return "Thu";
        break;
    case enDays::Fr:
        return "Fr";
        break;
    
    default:
        return "Sat";
        break;
    }
}

///////////////////////////////

void PrintAtoZ()
{
    for(int j = 65; j < 91; j++)
    {
        cout << static_cast<char>(j) << endl;
    }
}

///////////////////////////////

// [47] Loan instalment Months
struct stLoan
{
    int LoanAmount;
    int NumberOfMonths;
    int instalmentAmount;
};

stLoan ReadLoanAmountInstalmentAmount()
{
    stLoan Loan;
    cout << "Enter Loan Amount : ";
    cin >> Loan.LoanAmount;
    cout << "Enter Monthly Amount : ";
    cin >> Loan.instalmentAmount;
    return Loan;
}

float CalcNumberOfMonth(stLoan Loan)
{
    Loan.NumberOfMonths= (float)Loan.LoanAmount / Loan.instalmentAmount;
    return Loan.NumberOfMonths;
}

///////////////////////////////
stLoan ReadLoanAmountNumberOfMonths()
{
    stLoan Loan;
    cout << "Enter Loan Amount : ";
    cin >> Loan.LoanAmount;
    cout << "Enter Number of Months : ";
    cin >> Loan.NumberOfMonths;
    return Loan;
}

int CalcinstalmentAmount(stLoan Loan)
{
    Loan.instalmentAmount= (float)Loan.LoanAmount / Loan.NumberOfMonths;
    return Loan.instalmentAmount;
}

///////////////////////////////

string ReadPINCODE()
{
    string PINCODE;
    cout << "Enter your PIN Code her Please : ";
    cin >> PINCODE;
    return PINCODE;
}

bool Login()
{

     string PINCODE;
     int Times = 3;
    do{
        Times--; // frist try
        PINCODE = ReadPINCODE();

        if(PINCODE ==  "1234")
        {  
            
            return 1;
        }
        else
        {
            system("color 4f"); // turn screen Red
            cout << "\n Wrong PIN You have " << Times<<" more tries \n" ;
        }

    }while(PINCODE !=  "1234" && Times >= 1);
    return 0; // login faild

};

void ATM_SYSTEM()
{    
    if(Login())
    {
        system("color 2f");
        cout << "Login Sucessfuly \n";
        cout << "Your Balance is " << 7500 <<endl;
    }
    else
    {
        cout << "\n Your Acount was Blocked\n";
            system("color 4f"); // turn screen Red   
    }
   
    
}

///////////////////////////////
int main ()
{
    // // [41] Enter number of hours to get week and day
    float NumberOfHours =(float) ReadNumber("Please Enter Numner of Hours? ");
    float NumberOfDays = HoursToDays(NumberOfHours);
    float NumberOfWeeks = HoursToWeeks(NumberOfHours);
    PrintResults("Total Hours = ", NumberOfHours);
    PrintResults("Total Days = ", NumberOfDays);
    PrintResults("Total Weeks = ", NumberOfWeeks);

    // // [42] Enter Days Hours Minutes Seconds of Work => time in Seconds
    stWorkTime WorkTime = ReadWorkTime();
    int Result = CalcTimeInSecond(WorkTime);
    cout <<"The Time in Second is : " << Result << endl;

    // // [43] Enter Total Second => Days : Hours : Minutes : Seconds of Work
    int TotalSeconds = ReadNumber("Please enter Number of Second that you work : ");
    string DHMS = Calc_DHMS_FromSecond(TotalSeconds);
    cout <<"The Time is " <<endl;
    cout << "D :H :M :S\n";
    cout << DHMS << endl;

    // // [44] Read Days 1:7 1  => sut ...
    int NumberOfDay = ReadNumberInRange(1,7);
    string Day= GetDay( NumberToDay(NumberOfDay));
    cout << "The Day You Entered is : "<< NumberOfDay << "-"<< Day << endl;

    // // [45] Read Months 1:12  3 => Mar

    // // [46] Print From A to Z
    // PrintAtoZ();

    // // [47] Loan instalment Months 1
    int Months = CalcNumberOfMonth(ReadLoanAmountInstalmentAmount());
    PrintResults("The Number of Months You Need is  : ", Months);

    // // [48] Loan instalment Months 2
    int instalmentAmount = CalcinstalmentAmount(ReadLoanAmountNumberOfMonths());
    PrintResults("The Instalment Amount in Month is : ", instalmentAmount);

    // [49] ATM PIN 
    // true => Your Balance is 7500 false ask him again to enter PINCODE
    ATM_SYSTEM();

    // [50] Solved before
    
     return 0;
}