#include <iostream>
#include "lib.cpp"
using namespace std;

int main()
{
    myFirstLib::HelloMessage();
    cout << myFirstLib::sum(1, 4) << endl; // 5

    return 0;
}