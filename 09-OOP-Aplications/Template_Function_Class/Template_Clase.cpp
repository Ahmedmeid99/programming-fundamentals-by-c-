#include <iostream>
using namespace std;

template <class T>
class Calculator
{
private:
    T _Number1;
    T _Number2;

public:
    Calculator(T Number1, T Number2)
    {
        _Number1 = Number1;
        _Number2 = Number2;
    }

    T Add()
    {
        return _Number1 + _Number2;
    }
};

int main()
{
    Calculator<int> intCalcu(2, 3);
    Calculator<double> doubleCalcu(2.33, 3.22);

    cout << intCalcu.Add() << endl;    // 5
    cout << doubleCalcu.Add() << endl; // 5.55

    return 0;
}