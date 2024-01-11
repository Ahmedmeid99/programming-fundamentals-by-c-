#include <iostream>
#include "clsBankClient.cpp";
using namespace std;

int main()
{
    clsBankClient BankClient_1 = clsBankClient::Find("p03");
    BankClient_1.Print();
    clsBankClient BankClient_2 = clsBankClient::Find("p05", "125");
    BankClient_2.Print();
    cout << BankClient_1.IsEmpty() << endl;
    cout << clsBankClient::IsClientExist("p03") << endl;
    return 0;
}