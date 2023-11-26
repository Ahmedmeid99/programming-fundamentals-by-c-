#include <iostream>
#include <string>
#include <fstream>
using namespace std;
void PrintFileContent(string FileName)
{
    fstream File;

    File.open(FileName, ios::in);

    if (File.is_open())
    {
        string Line;
        while (getline(File, Line))
        {
            cout << Line << endl;
        }
        File.close();
    }
}

int main()
{
    PrintFileContent("MyInfo.txt");
    return 0;
}