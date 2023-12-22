#include <iostream>
using namespace std;

class clsEmployee
{
private:
    int _ID;
    string _FirstName;
    string _LastName;
    string _Title;
    string _Department;
    int _Salary;
    string _Email;
    string _Phone;

public:
    clsEmployee(int ID, string FirstName, string LastName, string Title, string Department, int Salary, string Email, string Phone)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Title = Title;
        _Department = Department;
        _Salary = Salary;
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

    void SetSalary(int Salary)
    {
        _Salary = Salary;
    }

    int Salary()
    {
        return _Salary;
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

    void Print()
    {
        cout << "Info\n\n";
        cout << "__________________________________\n";
        cout << "ID        : " << _ID << endl;
        cout << "FirstName : " << _FirstName << endl;
        cout << "LastName  : " << _LastName << endl;
        cout << "FullName  : " << FullName() << endl;
        cout << "Title     : " << _Title << endl;
        cout << "Department: " << _Department << endl;
        cout << "Salary    : " << _Salary << endl;
        cout << "Email     : " << _Email << endl;
        cout << "Phone     : " << _Phone << endl;
        cout << "\n__________________________________\n";
    }

    void SendEmail(string Subject, string Body)
    {
        cout << "The following messagebsent successfully to email: " << _Email << endl;
        cout << "Subject : " << Subject << endl;
        cout << "Body    : " << Body << endl;
    }

    void SendMessage(string Message)
    {
        cout << "The following messagebsent successfully to phone: " << _Phone << endl;
        cout << Message << endl;
    }
};

int main()
{
    clsEmployee Employee_1(10, "Ahmed", "eid", "React Developer", "Software", 12000, "ahmed@gmail.com", "01095814411");

    Employee_1.Print();

    Employee_1.SendEmail("Lernning Programing by C++", "Now I am in Course Number 10 its name is OOP Consepts (oop as it should be)");

    Employee_1.SendMessage("How are you Ahmed?");

    return 0;
}