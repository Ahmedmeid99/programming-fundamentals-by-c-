#include <iostream>
#include <string>
using namespace std;

class clsCalculator
{
private:
    float _TotalResult;
    string _LastOperation;
    int _LastNumber;

    // Cal Final result string
    string CalcFinalResult()
    {
        // fix last number after clear operation
        string stLastNumber = (_LastOperation == "Clear") ? "" : to_string(_LastNumber);

        return "The result after " + _LastOperation + " " + stLastNumber + " is = " + to_string(_TotalResult);
    }

public:
    // sum new _TotalResult + number
    void Add(int Number)
    {
        // save last number & last Operation
        _LastOperation = "Adding";
        _LastNumber = Number;

        // sum new Number
        _TotalResult += Number;
    }

    // Substract _TotalResult - new number
    void Substract(int Number)
    {
        // save last number & last Operation
        _LastOperation = "Substracting";
        _LastNumber = Number;

        // sum new Number
        _TotalResult -= Number;
    }

    // Multyply _TotalResult * new number
    void Multyply(int Number)
    {
        // save last number & last Operation
        _LastOperation = "Multyplying";
        _LastNumber = Number;

        // sum new Number
        _TotalResult *= Number;
    }

    // Divide _TotalResult / new number
    void Divide(int Number)
    {
        // save last number & last Operation
        _LastOperation = "Divideing";
        _LastNumber = Number;

        // fix Divide on 0
        Number = (Number == 0) ? 1 : Number;

        // Divide new Number
        _TotalResult /= Number;
    }

    // print final result text
    void GetFinalResult()
    {
        cout << CalcFinalResult() << endl;
    }

    // reset _TotalResult to 0
    void Clear()
    {
        // save last Process
        _LastOperation = "Clear";
        _LastNumber = 0;

        _TotalResult = 0;
    }
};

int main()
{
    clsCalculator Calculator_1;

    Calculator_1.Add(10);
    Calculator_1.GetFinalResult();

    Calculator_1.Substract(5);
    Calculator_1.GetFinalResult();

    Calculator_1.Multyply(5);
    Calculator_1.GetFinalResult();

    Calculator_1.Divide(5);
    Calculator_1.GetFinalResult();
    Calculator_1.Clear();
    Calculator_1.GetFinalResult();

    return 0;
}