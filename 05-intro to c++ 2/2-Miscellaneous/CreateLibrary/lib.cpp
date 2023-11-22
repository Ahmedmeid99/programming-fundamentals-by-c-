#pragma once

#include <iostream>
using namespace std;

namespace myFirstLib
{
    void HelloMessage()
    {
        cout << "Hello from my first Library in C++" << endl;
    }
    int sum(int a, int b)
    {
        return a + b;
    }
}