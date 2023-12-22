#include <iostream>
using namespace std;

class clsPerson
{
private:
    int _ID;
    string _FirstName;
    string _LastName;
    string _Phone;
    string _Email;

public:
    clsPerson(int ID, string FirstName, string LastName, string Phone, string Email)
    {
        _ID = ID;
        _FirstName = FirstName;
        _LastName = LastName;
        _Phone = Phone;
        _Email = Email;
    }

    // Set and Get functions

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

    void Print()
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
    clsEmployee(int ID, string FirstName, string LastName, string Phone, string Email, string Title, string Department, float Salary)
        : clsPerson(ID, FirstName, LastName, Phone, Email)
    {
        _Title = Title;
        _Department = Department;
        _Salary = Salary;
    }
    // Set and Get Functions

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
};

class clsDevloper : private clsEmployee
{

private:
    string _MainProgrammingLanguage;

public:
    clsDevloper(int ID, string FirstName, string LastName, string Phone, string Email, string Title, string Department, float Salary, string MainProgrammingLanguage)
        : clsEmployee(ID, FirstName, LastName, Phone, Email, Title, Department, Salary)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }

    // Set and Get Functions
    void SetMainProgrammingLanguage(string MainProgrammingLanguage)
    {
        _MainProgrammingLanguage = MainProgrammingLanguage;
    }

    string MainProgrammingLanguage()
    {
        return _MainProgrammingLanguage;
    }
};

class clsStudent : protected clsPerson
{

private:
    string _ClassRoom;
    string _Hobby;

public:
    clsStudent(int ID, string FirstName, string LastName, string Phone, string Email, string ClassRoom, string Hobby)
        : clsPerson(ID, FirstName, LastName, Phone, Email)
    {
        _ClassRoom = ClassRoom;
        _Hobby = Hobby;
    }

    // Set and Get Functions
    void SetClassRoom(string ClassRoom)
    {
        _ClassRoom = ClassRoom;
    }

    string ClassRoom()
    {
        return _ClassRoom;
    }

    void SetHobby(string Hobby)
    {
        _Hobby = Hobby;
    }

    string Hobby()
    {
        return _Hobby;
    }
};

class clsCollegeStudent : public clsStudent
{

private:
    string _Specialization;

public:
    clsCollegeStudent(int ID, string FirstName, string LastName, string Phone, string Email, string ClassRoom, string Hobby, string Specialization)
        : clsStudent(ID, FirstName, LastName, Phone, Email, ClassRoom, Hobby)
    {
        _Specialization = Specialization;
    }

    // Set and Get Functions
    void SetSpecialization(string Specialization)
    {
        _Specialization = Specialization;
    }

    string Specialization()
    {
        return _Specialization;
    }
};

int main()
{
    // inside class
    // public Mode inherite     public->public     private->private  protected->protected
    // protected Mode inherite  public->protected  private->private  protected->protected
    // private Mode inherite    public->private    private->private  protected->private

    return 0;
}