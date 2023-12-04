#include <iostream>
#include <string>
#include "../00-MyLibrary/numbers.cpp"
using namespace std;

int EntervalidNumber(string Message)
{
    // Validate Number
    int Number;
    cout << Message;
    cin >> Number;
    while (cin.fail())
    {
        cin.clear();
        cin.ignore(1000, '\n');
        cout << "UnValid Tray again : \n";
        cin >> Number;
    }
    return Number;
}

string EntervalidString(string Message)
{
    string EnteredST;

    bool IsValid = true;
    do
    {
        cout << Message;
        cin >> EnteredST;

        for (char Digit : EnteredST)
        {
            if (isalpha(Digit))
            {
                IsValid = false;
                break;
            }
        }
    } while (IsValid);
    return EnteredST;
}

int main()
{
    // Validate Number
    cout << EntervalidNumber("Pleas Enter Number here: \n") << endl;

    // Validate string
    cout << EntervalidString("ENter your name?\n") << endl;

    cout << nums::ReadPositveNumber("Pleas Enter Number here: \n") << endl;
    ////////////////////////////

    return 0;
}