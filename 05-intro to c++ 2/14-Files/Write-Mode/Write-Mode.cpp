#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    fstream FileName;

    FileName.open("MyInfo.txt", ios::out);

    if (FileName.is_open())
    {
        FileName << "---------------------------------\n";
        FileName << "          MY INFORMATION         \n";
        FileName << "---------------------------------\n";
        FileName << "My Name is   : Ahmed Mohamed Eid \n";
        FileName << "My Age is    : 25 \n";
        FileName << "MY Level is  : 3 \n";
        FileName << "My Skills is : C++ JS React CSS \n";
        FileName << "-------------------------------\n";

        FileName.close();
    }
    return 0;
}