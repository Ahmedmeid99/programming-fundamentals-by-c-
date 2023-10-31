#include <iostream>
using namespace std;

// create a function print message 
void printMessage() {
    cout << "this is first c++ function \n";
};

// creat a function print the sum of two numbers 
int printSum() {
    int num1 = 3;
    int num2 = 2;
    return num1 + num2;
};

// creat a function print the sum of two entered numbers 
int printSum2(int num1, int num2) {
    return num1 + num2;
}

struct st_userInfo {
    string name;
    string email;
    string phone;
};
// creat a function read entered user info and print user card
void readuserinfo(st_userInfo& user) {
    cout << "whit is your name? " << endl;
    cin >> user.name;
    cout << "whit is your email? " << endl;
    cin >> user.email;
    cout << "whit is your phone? " << endl;
    cin >> user.phone;
};

// 
void printuserinfo(st_userInfo user) {
    cout << "******************************\n" << endl;

    cout << "name : " << user.name << endl;
    cout << "email : " << user.email << endl;
    cout << "phone : " << user.phone << endl;

    cout << "\n******************************\n" << endl;
}
int main()
{
    printMessage(); // this is first c++ function
    cout << printSum() << endl; //5
    cout << printSum2(2, 3) << endl; // 5

    // creat user card
    st_userInfo user;
    readuserinfo(user);
    printuserinfo(user);

    /*******************************

     name : ahmed
     email : ahmedalbakrycool@gmail.com
     phone : 01095814411

     *******************************/
    return 0;
};