#include <iostream>
using namespace std;

class clsPerson
{
private:
    string _FirstName;
    string _LastName;

public:
    // constractor
    clsPerson(string FirstName, string LastName)
    {
        _FirstName = FirstName;
        _LastName = LastName;
    }

    // copy Constractor (optional)
    clsPerson(clsPerson &OldPerson)
    {
        _FirstName = OldPerson.FirstName();
        _LastName = OldPerson.LastName();
    }

    void SetFirstName(string FirstName)
    {
        _FirstName = FirstName;
    }

    void SetLastName(string LastName)
    {
        _LastName = LastName;
    }
    string FirstName()
    {
        return _FirstName;
    }

    string LastName()
    {
        return _LastName;
    }

    string FullName()
    {
        return _FirstName + " " + _LastName;
    }
};

int main()
{
    clsPerson Person1("Ahmed", "Eid");
    cout << Person1.FullName() << endl;

    clsPerson Person2 = Person1;

    Person1.SetLastName("Mohamed Eid");
    cout << Person1.FullName() << endl;

    cout << Person2.FullName() << endl;

    Person2.SetLastName("Abo Eid");
    cout << Person2.FullName() << endl;

    return 0;
}