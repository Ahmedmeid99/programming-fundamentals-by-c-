#include <iostream>
using namespace std;


// [24] check if age is valid or not 18 : 45
void check_age(int &age)
{
    cout << "enter your age\n";
    cin >> age;
    if (age <= 18 || age >= 45)
    {
        cout << age << " invalid age\n\n";
    }else{ cout << age << " valid age\n\n"; }

}

// [25] enter valid age only
void enter_valid_age(int &age)
{
    do {
        cout << "enter your age\n";
        cin >> age;
    }while(age < 18 || age > 45);

    cout << age << " is valid age\n\n";
    
}

// [26] prin from 1 to n (entered number)
void print_to(int &n)
{
    cout << "enter a number to print from 1 to this number\n";
    cin >> n;
    for (int i = 1; i <= n; i++) {
        cout << i << endl;
    }
}

// [27] prin from n to 1 (n is entered number)
void print_to_1(int &n)
{
    cout << "enter a number to print from n to 1 \n";
    cin >> n;
    for (int i = n; i >= 1; i--)
    {
        cout << i << endl;
    }
}

// [28] print Even number to n
void print_Even(int &n)
{
    cout << "enter number ...\n";
    cin >> n;
    cout << "the even numbers is \n";
    for (int i = 0; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            cout << i << endl;
        }
    }
}

// [29] print ODD number to n
void print_ODD(int &n)
{
    cout << "enter number ...\n";
    cin >> n;
    cout << "the odd numbers is \n";
    for (int i = 0; i <= n; i++)
    {
        if (i % 2 != 0)
        {
            cout << i << endl;
        }
    }
}

int main()
{
    int age1,age2,n1,n2,num1,num2;
    // [24] check if age is valid or not 18 : 45
    check_age(age1);

    // [25] enter valid age only
    enter_valid_age(age2);

    // [26] prin from 1 to n (n is entered number)
    print_to(n1);

    // [27] prin from n to 1 (n is entered number)
     print_to_1(n2);
    
    // [28] print Even number to n
    print_Even(num1);

    // [29] print ODD number to n
    print_ODD(num2);
    cout << "hello";
    return 0;
}
