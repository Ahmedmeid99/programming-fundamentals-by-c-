#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    fstream FileName;

    FileName.open("MyInfo.txt", ios::out | ios::app);

    if (FileName.is_open())
    {
        FileName << "---------------------------------\n";
        FileName << "       MY FATHER INFORMATION      \n";
        FileName << "---------------------------------\n";
        FileName << "and My Father: Mohamed Eid \n";
        FileName << "his Age is   : 51 \n";
        FileName << "his Level is : 3 \n";
        FileName << "his Skills is: Word Excle \n";
        FileName << "-------------------------------\n";
        FileName << "\n";

        FileName.close();
    }
    return 0;
}