#include <iostream>
using namespace std;

struct stEmployee
{
    string Name;
    int Salary;
};
int main()
{
    stEmployee Employee;
    stEmployee *p;

    p = &Employee;

    Employee.Name = "Ahmed";
    Employee.Salary = 200;

    cout << "struct Address : " << p << endl;
    cout << "struct Name : " << p->Name << endl;
    cout << "struct Salary : " << p->Salary << endl;

    return 0;
}