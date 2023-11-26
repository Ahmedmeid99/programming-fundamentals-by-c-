#include <iostream>
#include <cctype>
using namespace std;

int main()
{
    char FirstChar = 'a';
    char UpperChar = toupper(FirstChar);
    char LowerChar = tolower(UpperChar);

    cout << UpperChar << endl;
    cout << LowerChar << endl;

    cout << "isupper('a') is : " << isupper('a') << endl; // 0
    cout << "isupper('A') is : " << isupper('A') << endl; // 1

    cout << "islower('A') is : " << islower('A') << endl; // 0
    cout << "islower('a') is : " << islower('a') << endl; // 2

    cout << "isdigit('A') is : " << isdigit('A') << endl; // 0
    cout << "isdigit('5') is : " << isdigit('5') << endl; // 1

    cout << "ispunct('A') is : " << ispunct('A') << endl; // 0
    cout << "ispunct(';') is : " << ispunct(';') << endl; // 16
    return 0;
}