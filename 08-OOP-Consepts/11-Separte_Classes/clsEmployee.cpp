#pragma once;
#include <iostream>
#include "./clsPerson.cpp"
using namespace std;

class clsEmployee : public clsPerson
{
private:
    string _Title;
    string _Department;
    float _Salary;

public:
    clsEmployee(int ID, string FirstName, string LastName, string Email, string Phone, string Title, string Department, float Salary)
        : clsPerson(ID, FirstName, LastName, Email, Phone)
    {
        // for Subclass Employee
        _Title = Title;
        _Department = Department;
        _Salary = Salary;
    }

    void SetTitle(string Title)
    {
        _Title = Title;
    }

    string Title()
    {
        return _Title;
    }

    void SetDepartment(string Department)
    {
        _Department = Department;
    }

    string Department()
    {
        return _Department;
    }

    void SetSalary(float Salary)
    {
        _Salary = Salary;
    }

    float Salary()
    {
        return _Salary;
    }

    // Print Function Overrade
    void Print()
    {
        // Add new lines of code to the oldest function
        // clsPerson::Print();

        // Overrade the oldest function
        cout << "Info\n\n";
        cout << "__________________________________\n";
        cout << "ID          : " << ID() << endl;
        cout << "FirstName   : " << FirstName() << endl;
        cout << "LastName    : " << LastName() << endl;
        cout << "FullName    : " << FullName() << endl;
        cout << "Email       : " << Email() << endl;
        cout << "Phone       : " << Phone() << endl;

        cout << "Title       : " << _Title << endl;
        cout << "Department  : " << _Department << endl;
        cout << "Salary      : " << _Salary << endl;
        cout << "\n__________________________________\n";
    }
};
