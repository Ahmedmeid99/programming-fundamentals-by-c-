#include <iostream>

using namespace std;

union unClient
{
    int Age;
    float Balance;
    char firstChar;
};
int main()
{
    // You Can not store string in union
    // this Data Type has many problems in its;
    unClient Client1;
    Client1.Age = 25;
    Client1.Balance = 500;
    Client1.firstChar = 'A';
    cout << Client1.Age << " :  " << Client1.firstChar << " : " << Client1.Balance << endl;
    return 0;
}