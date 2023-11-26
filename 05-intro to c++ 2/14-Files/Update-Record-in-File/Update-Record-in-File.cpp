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
        File.close();
    }
}

void LoadVectorToFile(string FileName, vector<string> &vDataFile)
{
    fstream File;

    File.open(FileName, ios::out);

    if (File.is_open())
    {
        for (string &Line : vDataFile)
        {
            if (Line != "")
            {
                File << Line << endl;
            }
        }
        File.close();
    }
}

void UpdateRecord(string FileName, string Record, string UpdateTo)
{
    // create new vector and pust in it filtered lines
    vector<string> vDataFiltered;
    LoadDataFromFileToVector(FileName, vDataFiltered);

    for (string &Line : vDataFiltered)
    {
        if (Line == Record)
        {
            Line = UpdateTo;
        }
    }
    // save the new vector in file
    LoadVectorToFile(FileName, vDataFiltered);
}

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
    FillFileWithNames("MyFile.txt");
    PrintFileContent("MyFile.txt");
    UpdateRecord("MyFile.txt", "Hassan", "H");
    PrintFileContent("MyFile.txt");
    return 0;
}