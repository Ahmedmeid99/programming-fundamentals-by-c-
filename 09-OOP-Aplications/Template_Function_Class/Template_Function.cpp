#include <iostream>
using namespace std;

// short SumTwoNums(short Num1, short Num2)
// {
//     return Num1 + Num2;
// }

// int SumTwoNums(int Num1, int Num2)
// {
//     return Num1 + Num2;
// }

// float SumTwoNums(float Num1, float Num2)
// {
//     return Num1 + Num2;
// }

// double SumTwoNums(double Num1, double Num2)
// {
//     return Num1 + Num2;
// }

template <typename T>
T SumTwoNums(T Num1, T Num2)
{
    return Num1 + Num2;
}

int main()
{
    cout << SumTwoNums(2, 3) << endl;         // 5
    cout << SumTwoNums(2.3, 3.2) << endl;     // 5.5
    cout << SumTwoNums(2.003, 3.002) << endl; // 5.005
    return 0;
}