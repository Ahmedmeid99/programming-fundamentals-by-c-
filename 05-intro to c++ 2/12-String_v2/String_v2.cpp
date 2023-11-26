#include <iostream>
#include <string>

using namespace std;

int main()
{
    string MyInfo = "My name is : Ahmed Mohammed Eid Ali =>ahmedmoeid";

    cout << "Length is : " << MyInfo.length() << endl; // 48

    cout << "Position of 0 is : " << MyInfo.at(0) << endl; // M

    MyInfo.append(".com");
    cout << "Append .com to the end : " << MyInfo << endl;

    MyInfo.insert(12, " :-)");
    cout << "insert :-) before name : " << MyInfo << endl;

    cout << "my first name is : " << MyInfo.substr(17, 5) << endl;

    MyInfo.push_back('Z');
    cout << "Push Z char to the end" << MyInfo << endl;

    MyInfo.pop_back();
    cout << "Remove Z from the end : " << MyInfo << endl;

    if (MyInfo.find(".com") == MyInfo.npos)
        cout << "Cant find .com in string" << endl;
    else
        cout << MyInfo.find(".com") << endl; // 52

    MyInfo.clear(); //_____
    cout << "My Info after use clear method is :  " << MyInfo << endl;
    return 0;
}