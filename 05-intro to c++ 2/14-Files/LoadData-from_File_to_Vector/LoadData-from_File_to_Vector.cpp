#include <iostream>
#include <fstream>
#include <string>
#include <vector>
using namespace std;
void FillFileWithNames(string FileName)
{
    fstream File;

    File.open(FileName, ios::out);

    if (File.is_open())
    {

        File << "Ahmed\n";
        File << "Mohamed\n";
        File << "Hassan\n";
        File << "Eid\n";
        File << "Ali\n";
        File << "Hassan\n";
        File.close();
    }
}
void PrintVectorContent(string FileName, vector<string> vDataFile)
{
    fstream File;

    File.open(FileName, ios::in);

    if (File.is_open())
    {
        for (string Line : vDataFile)
        {
            if (Line != " ")
            {

                cout << Line << endl;
            }
        }
        File.close();
    }
}

void LoadDataFromFileToVector(string FileName, vector<string> &vDataFile)
{
    fstream File;
    File.open(FileName, ios::in);

    if (File.is_open())
    {
        string Line;

        while (getline(File, Line))
        {
            vDataFile.push_back(Line);
        }
    }
}
int main()
{
    vector<string> vDataFile;
    FillFileWithNames("MyFile.txt");                   // creat file and fill it with data
    LoadDataFromFileToVector("MyFile.txt", vDataFile); // load data to vector
    PrintVectorContent("MyFile.txt", vDataFile);
    return 0;
}