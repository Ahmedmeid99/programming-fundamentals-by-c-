#include <iostream>
#include "clsLogin.cpp";
using namespace std;

// UI List Clients

int main()
{
    while (true)
    {

        if (!clsLogin::ShowLoginScreen())
        {
            break;
        }
    }

    return 0;
}