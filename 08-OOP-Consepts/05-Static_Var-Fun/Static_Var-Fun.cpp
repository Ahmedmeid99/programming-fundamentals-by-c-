#include <iostream>

using namespace std;

class clsPerson
{
private:
    string _FirstName;
    string _LastName;

public:
    // static Var
    static short CountOfPepole;

    clsPerson()
    {
        CountOfPepole++;
    }

    short GetCountOfPepole()
    {
        return CountOfPepole;
    }

    // static Fun
    static short SetNumber()
    {
        return 10;
    }

    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }

    string FirstName()
    {
        return _FirstName;
    }

    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }

    string LastName()
    {
        return _LastName;
    }
};
// set Static Variable intial value
short clsPerson::CountOfPepole = 0;

int main()
{
    // run function before create object
    cout << clsPerson::SetNumber() << endl; // 10

    clsPerson Person_1, Person_2, Person_3;

    cout << Person_1.GetCountOfPepole() << endl; // 3

    return 0;
}