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