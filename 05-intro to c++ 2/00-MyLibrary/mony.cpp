#pragma once

#include <iostream>
using namespace std;

namespace mony
{
    // [1]
    float CalcReminder(int CashPaid, int TotalBill)
    {
        float Result = CashPaid - TotalBill;
        return (float)Result;
    }

    // [2]
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

    int ExchangeCurrencyToPenny(stCurrency &Currency)
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
        float Dollar = ExchangeCurrencyToPenny(Currency) / 100;
        return Dollar;
    }

    // [3]
    enum enPercent
    {
        onePercent = 1,
        twoPercent = 2,
        threePercent = 3,
        fivePercent = 5,
        zeroPercent = 0
    };

    enPercent CalcSellerRatio(int &TotalSales)
    {
        if (TotalSales >= 1000000)
            return enPercent::onePercent;
        else if (TotalSales >= 500000)
            return enPercent::twoPercent;
        else if (TotalSales >= 100000)
            return enPercent::threePercent;
        else if (TotalSales >= 50000)
            return enPercent::fivePercent;
        else
            return enPercent::zeroPercent;
    }

    int CalcNetProfit(int &TotalSales, double Percent)
    {
        float Result = TotalSales * Percent;
        return Result;
    }

    void PrintSellerProfit(enPercent Percent, int &TotalSales)
    {
        cout << "Total Sales is : " << TotalSales << endl;
        cout << "And Your Net Profit of this Sales Will be : ";

        switch (Percent)
        {
        case enPercent::onePercent:
            cout << CalcNetProfit(TotalSales, .01) << " and You Percent is .01" << endl;
            break;
        case enPercent::twoPercent:
            cout << CalcNetProfit(TotalSales, .02) << " and You Percent is .02" << endl;
            break;
        case enPercent::threePercent:
            cout << CalcNetProfit(TotalSales, .03) << " and You Percent is .03" << endl;
            break;
        case enPercent::fivePercent:
            cout << CalcNetProfit(TotalSales, .05) << " and You Percent is .05" << endl;
            break;
        case enPercent::zeroPercent:
            cout << CalcNetProfit(TotalSales, .00) << " and You Percent is 0" << endl;
            break;
        default:
            cout << CalcNetProfit(TotalSales, .00) << " and You Percent is 0" << endl;
            break;
        }
    }

}