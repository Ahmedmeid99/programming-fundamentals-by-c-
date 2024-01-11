#pragma once;
#include <iostream>
using namespace std;

class clsPerson
{
private:
    int _ID;
    string _FirstName;
    string _LastName;
    string _Email;
    string _Phone;

public:
    clsPerson(int ID, string FirstName, string LastName, string Email, string Phone)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Email = Email;
        _Phone = Phone;
    }

    // Read onle Id
    int ID()
    {
        return _ID;
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

    void SetEmail(string Email)
    {
        _Email = Email;
    }

    string Email()
    {
        return _Email;
    }

    void SetPhone(string Phone)
    {
        _Phone = Phone;
    }

    string Phone()
    {
        return _Phone;
    }

    string FullName()
    {
        return _FirstName + " " + _LastName;
    }

    virtual void Print()
    {
        cout << "Info\n\n";
        cout << "__________________________________\n";
        cout << "ID       : " << _ID << endl;
        cout << "FirstName: " << _FirstName << endl;
        cout << "LastName : " << _LastName << endl;
        cout << "FullName : " << FullName() << endl;
        cout << "Email    : " << _Email << endl;
        cout << "Phone    : " << _Phone << endl;
        cout << "\n__________________________________\n";
    }

    void SendEmail(string Subject, string Body)
    {
        cout << "The following messagebsent successfully to email: " << _Email << endl;
        cout << Subject << endl;
        cout << Body << endl;
    }

    void SendMessage(string Message)
    {
        cout << "The following messagebsent successfully to phone: " << _Phone << endl;
        cout << Message << endl;
    }
};
