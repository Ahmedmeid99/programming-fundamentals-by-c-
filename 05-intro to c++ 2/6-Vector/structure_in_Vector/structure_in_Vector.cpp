#include <iostream>
#include <vector>
using namespace std;

struct stEmployee
{
    string First_Name;
    string Last_Name;
    int Salary;
};

void ReadEmployees(vector<stEmployee> &vEmployees)
{
    stEmployee Employee;
    string AddNewEmplyeeState = "Y";
    do
    {
        cout << "Dou you want to add New Employee? Y/N? \n";
        cin >> AddNewEmplyeeState;
        if (AddNewEmplyeeState == "Y" || AddNewEmplyeeState == "y")
        {
            cout << "Enter First Name : ";
            cin >> Employee.First_Name;

            cout << "\nEnter Last Name : ";
            cin >> Employee.Last_Name;

            cout << "\nEnter Salary : ";
            cin >> Employee.Salary;

            vEmployees.push_back(Employee);
        }
        else
            break;

    } while (AddNewEmplyeeState == "Y" || AddNewEmplyeeState == "y");
}

void PrintEmployes(vector<stEmployee> &Employees)
{
    for (stEmployee &Employee : Employees)
    {
        cout << "First Name is :" << Employee.First_Name << " \n";
        cout << "Last Name is : " << Employee.Last_Name << "\n";
        printf("and Salary is : %d\n", Employee.Salary);
        cout << endl;
    }
}

int main()
{
    vector<stEmployee> Employees;

    stEmployee Employee;
    Employee.First_Name = "Ahmed";
    Employee.Last_Name = "Eid";
    Employee.Salary = 5000;
    Employees.push_back(Employee);

    Employee.First_Name = "Mohamed";
    Employee.Last_Name = "Ali";
    Employee.Salary = 4000;
    Employees.push_back(Employee);

    Employee.First_Name = "Hassan";
    Employee.Last_Name = "Ali";
    Employee.Salary = 6000;
    Employees.push_back(Employee);

    /////////////////////////
    PrintEmployes(Employees);

    /////////////////////////
    vector<stEmployee> Employees_v2;
    ReadEmployees(Employees_v2);
    PrintEmployes(Employees_v2);
    return 0;
}