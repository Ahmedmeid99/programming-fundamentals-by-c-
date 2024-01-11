#pragma once;
#include <iostream>
#include "./clsEmployee.cpp"
using namespace std;

class clsDeveloper : public clsEmployee
{
private:
    string _MainProgramminLanguage;

public:
    clsDeveloper(int ID, string FirstName, string LastName, string Email, string Phone, string Title, string Department, float Salary, string MainProgramminLanguage)
        : clsEmployee(ID, FirstName, LastName, Email, Phone, Title, Department, Salary)
    {
        _MainProgramminLanguage = MainProgramminLanguage;
    }

    void Print()
    {
        // Overrade the oldest function
        cout << "Info\n\n";
        cout << "__________________________________\n";
        cout << "ID                    : " << ID() << endl;
        cout << "FirstName             : " << FirstName() << endl;
        cout << "LastName              : " << LastName() << endl;
        cout << "FullName              : " << FullName() << endl;
        cout << "Email                 : " << Email() << endl;
        cout << "Phone                 : " << Phone() << endl;

        cout << "Title                 : " << Title() << endl;
        cout << "Department            : " << Department() << endl;
        cout << "Salary                : " << Salary() << endl;

        cout << "MainProgramminLanguage: " << _MainProgramminLanguage << endl;
        cout << "\n__________________________________\n";
    }
};
