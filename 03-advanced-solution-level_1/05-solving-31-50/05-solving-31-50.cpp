#include <iostream>
using namespace std;


///////////////////////////////

struct stPowerofNum
{
    int N2;
    int N3;
    int N4;
};
int ReadEnterNum()
{
    int Number;
    cout << "Enter Number n=> n^2 n^3 n^4 : ";
    cin >> Number;
    return Number;
}

stPowerofNum CalcResult(int Number)
{
    stPowerofNum PowerofNum;
    PowerofNum.N2=Number * Number; // or pow
    PowerofNum.N3=Number * Number * Number;
    PowerofNum.N4=Number * Number * Number * Number;
    
    return PowerofNum;
}

void PrintResult(stPowerofNum PowerofNum)
{
    cout << "n^2 = " << PowerofNum.N2<< ", n^3 = " << PowerofNum.N3 << ", n^4 = " << PowerofNum.N4 << endl;
}

///////////////////////////////
struct stPower
{
    int N;
    int M;
};
stPower ReadEnter2Nums()
{
    stPower Power;
    cout << "Enter n^m \n";
    cout << "Enter n : ";
    cin >> Power.N;
    cout << "Enter m : ";
    cin >> Power.M;
    return Power;
}

int PowofNumber (stPower Power)
{
    int Result=1;
    for(int i=1;i<=Power.M;i++)
    {
        Result *=Power.N;
    }
    return Result;
}

void PrintPowerofN(int Result)
{
    cout << "The Result is " << Result << endl;
}

///////////////////////////////

enum enMark {A = 1, B = 2, C = 3, D = 4, E = 5, F = 0};
int ReadStudentGrade()
{
    int Grade;
    cout << "Enter your Grade\n";
    cin >> Grade;
    return Grade;
}

enMark MarkofGrade(int Grade)
{
    if (Grade >= 90)
        return enMark::A;
    else
        if(Grade >= 80)
            return enMark::B;
        else
            if(Grade >= 70)
                return enMark::C;
            else
                if(Grade >= 60)
                    return enMark::D;
                else
                    if(Grade >= 50)
                        return enMark::E;
                    else
                        return enMark::F;
            
}

void PrintMark(enMark Mark)
{
    switch (Mark)
    {
    case enMark::A :
        cout << "your Mark is A" << endl;
        break;
    case enMark::B :
        cout << "your Mark is B" << endl;
        break;
    case enMark::C :
        cout << "your Mark is C" << endl;
        break;
    case enMark::D :
        cout << "your Mark is D" << endl;
        break;
    case enMark::E :
        cout << "your Mark is E" << endl;
        break;
    default:
        cout << "your Mark is F" << endl;
        break;
    }
}

///////////////////////////////

enum enPercent {onePercent = 1, twoPercent = 2, threePercent = 3, fivePercent = 5, zeroPercent = 0};

void ReadTotalSales(int &TotalSales)
{
    cout << "Enter Total of Sales\n";
    cin >> TotalSales;
}

enPercent CalcSellerRatio(int &TotalSales)
{
    if (TotalSales >= 1000000)
        return enPercent::onePercent;
    else
        if(TotalSales >= 500000)
            return enPercent::twoPercent;
        else
            if(TotalSales >= 100000)
                return enPercent::threePercent;
            else
                if(TotalSales >= 50000)
                    return enPercent::fivePercent;
                else
                    return enPercent::zeroPercent;

}

int CalcNetProfit(int &TotalSales,double Percent)
{
    float Result = TotalSales * Percent;
    return Result;
}

void PrintSellerProfit(enPercent Percent,int &TotalSales)
{
    cout << "Total Sales is : " <<  TotalSales << endl;
    cout << "And Your Net Profit of this Sales Will be : " ;

    switch (Percent)
    {
    case enPercent::onePercent :
        cout << CalcNetProfit(TotalSales,.01) << " and You Percent is .01"<< endl;
        break;
    case enPercent::twoPercent :
        cout << CalcNetProfit(TotalSales,.02) << " and You Percent is .02"<< endl;
        break;
    case enPercent::threePercent :
        cout << CalcNetProfit(TotalSales,.03) << " and You Percent is .03" << endl;
        break;
    case enPercent::fivePercent :
        cout << CalcNetProfit(TotalSales,.05) << " and You Percent is .05" << endl;
        break;
    case enPercent::zeroPercent :
        cout << CalcNetProfit(TotalSales,.00) << " and You Percent is 0" << endl;
        break;
    default:
        cout << CalcNetProfit(TotalSales,.00) << " and You Percent is 0" << endl;
        break;
    }
}

///////////////////////////////

struct stCurrency 
{
    int Penny;
    int Nickel;
    int Dime;
    int Quarter;
    int Dollar;
};

void ReadEnteredCurrency(stCurrency &Currency)
{
    cout << "Enter Currencies\n";  
    cout << "Enter Dollar : ";  
    cin >> Currency.Dollar;
    cout << "Enter Quarter : ";  
    cin >> Currency.Quarter;
    cout << "Enter Dime : ";  
    cin >> Currency.Dime;
    cout << "Enter Nickel : ";  
    cin >> Currency.Nickel;
    cout << "Enter Penny : ";  
    cin >> Currency.Penny;
}

int ExchangeCurrencyToPenny (stCurrency &Currency)
{
    int PennytoPenny = Currency.Penny;
    int NickeltoPenny = Currency.Nickel * 5;
    int DimetoPenny = Currency.Dime * 10;
    int QuarterroPenny = Currency.Quarter * 25;
    int DollartoPenny = Currency.Dollar * 100;
    int Penny = (PennytoPenny + NickeltoPenny + DimetoPenny + QuarterroPenny + DollartoPenny);
    return Penny;
}

float ExchangeCurrencyToDollar(stCurrency &Currency)
{
    float Dollar= ExchangeCurrencyToPenny(Currency) /100;
    return Dollar;
}

void PrintResultsofExchangeCurrency(int Penny,float Dollar)
{
    cout << "in Penny : "<< Penny << endl;
    cout << "in Dollar : "<< Dollar << endl;
}

///////////////////////////////
void ReadEnteredNum(int &Number)
{
    cout << "Enter number";
    cin >> Number;
}

int SumofNumbers(int &Number)
{
    
    ReadEnteredNum(Number);
    int Result = 0;
    while(Number != -99)
    {
        Result += Number;
        ReadEnteredNum(Number);
    };
    return Result;
}

void PrintSumofNumbers(int Result)
{
    cout <<"The Result is = " << Result << endl;

}

///////////////////////////////
struct stOperation
{
    int N1;
    int N2;
    string OperationMark;
};

stOperation ReadOperationInputs()
{
    stOperation Operation;
    cout << "Enter operation of 2 numbers like 2 + 3 \n";
    cout << "First Number is : ";
    cin >> Operation.N1;
    cout << "Second Number is : ";
    cin >> Operation.N2;
    cout << "and operation is : ";
    cin >> Operation.OperationMark;
    
    return Operation;
}

float Calc(stOperation Operation)
{
    if (Operation.OperationMark == "+")
    {
        return Operation.N1 + Operation.N2;
    }
    else if (Operation.OperationMark == "-")
    {
        return Operation.N1 - Operation.N2;
    }
    else if (Operation.OperationMark == "*")
    {
        return Operation.N1 * Operation.N2;
    }
    else if(Operation.OperationMark == "/")
    {
        return Operation.N1 / Operation.N2;
    }
    else
    {
        return 000000;
    }
    
}

void PrintResults(float Result)
{
    cout << "The Result is = " << Result << endl;
}


///////////////////////////////

int ReadInputNumber()
{
    int Number;
    cout << " Check Entered Number\n";
    cin >> Number;
    return Number;
}

string CheckNum(int Number)
{
    if(Number > 0){
        int counter = 2;
        if(Number > counter)
        {
            counter += 1;
            // 
            
        }else
        {
            return "Prim";
        }
    }else
    {
        return "Entered Number must be < 0";
    }
}

///////////////////////////////
int main()
{
    // [31] print n^2 n^3 n^4 (n => entered Number)
    PrintResult(CalcResult(ReadEnterNum()));

    // [32] build in function pow(n,m) => n^m
    PrintPowerofN(PowofNumber(ReadEnter2Nums()));

    // [33] Print Mark of Student grade (A,B,C,D,E,F)
    PrintMark(MarkofGrade(ReadStudentGrade()));

    // [34] Calculate the Net Profit Based on Total Sales
    int TotalSales;
    ReadTotalSales(TotalSales);
    PrintSellerProfit(CalcSellerRatio(TotalSales),TotalSales);

    // [35] Currency Exchange from (Penny,Nickel,Dime,Quarter,Dollar) to => (Pennies,Dollar)
    stCurrency Currency;
    ReadEnteredCurrency(Currency);
    PrintResultsofExchangeCurrency(ExchangeCurrencyToPenny(Currency),ExchangeCurrencyToDollar(Currency));

    // [36] Calc(n1,n2,+) 
     PrintResults(Calc(ReadOperationInputs()));

    // [37] Print Sum of Numbers
    int Number;
    PrintSumofNumbers(SumofNumbers(Number));

    // [38] Print Prim or not 
    // PrintPrim(CheckNum(ReadInputNumber()));


    return 0;
}