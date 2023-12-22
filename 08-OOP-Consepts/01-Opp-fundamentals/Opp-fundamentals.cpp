#include <iostream>
using namespace std;

class clsPerson
{

private:
    string _FirstName;
    string _LastName;

public:
    // set firstname
    void setFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }

    // set lastname
    void setLastName(string LastName)
    {
        _LastName = LastName;
    }

    // get firstname
    string FirstName()
    {
        return _FirstName;
    }

    // get lastname
    string LastName()
    {
        return _LastName;
    }

    // full name
    string FullName()
    {
        return _FirstName + " " + _LastName;
    }
};

int main()
{
    // create person object
    clsPerson Person;

    Person.setFirstName("Ahmed");
    Person.setLastName("Eid");

    cout << Person.FirstName() << endl; // Ahmed
    cout << Person.LastName() << endl;  // Eid
    cout << Person.FullName() << endl;  // Ahmed Eid
    return 0;
}