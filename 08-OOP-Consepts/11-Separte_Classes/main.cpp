#include <iostream>
#include "./clsPerson.cpp"
#include "./clsEmployee.cpp"
#include "./clsDeveloper.cpp"
using namespace std;

int main()
{
    // use virtual keyword in superclass to folloing the overrited functions

    clsEmployee Employee(10, "Ahmed", "Mo-eid", "Ahmed@gmail.com", "01005006879", "Green house Eng", "Ageicalture", 5000);

    Employee.Print();

    clsDeveloper Developer(11, "Ahmed", "Eid", "Software@gmail.com", "01095814411", "React Devloper", "Software", 5000, "Javascript");

    Developer.Print();

    // Up castring
    clsEmployee Employee_2(12, "hassan", "Mo-eid", "Ahmed@gmail.com", "01005006879", "Green house Eng", "Ageicalture", 5000);
    clsDeveloper Developer_2(13, "ali", "Eid", "Software@gmail.com", "01095814411", "Viu Devloper", "Software", 5000, "Javascript");

    clsPerson *Person_1 = &Employee_2;
    clsPerson *Person_2 = &Developer_2;

    Person_1->Print();
    Person_2->Print();
    return 0;
}