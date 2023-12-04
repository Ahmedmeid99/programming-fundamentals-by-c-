#include <iostream>
using namespace std;

string ReverseEachWordInString(string Line)
{
    // Ahmed Mohamed Eid Ali
    string Word;
    string ReversdLine;
    short Pos;
    string Delim = " ";

    while ((Pos = Line.find_last_of(Delim)) != std::string::npos)
    {
        Word = Line.substr(Pos + Delim.length(), Line.length() - 1);
        if (Word != "")
        {
            ReversdLine += Word + Delim;
        }
        Line.erase(Pos, Line.length() - 1);
    }

    if (Line != "")
    {
        ReversdLine += Line;
    }

    return ReversdLine;
}

string ReplaceString(string Line, string OldStr, string NewStr)
{
    // ahmed mo eid ali
    // ahmed mohamed eid ali
    short Pos = Line.find(OldStr);
    if (Pos != std::string::npos)
    {

        Line = Line.replace(Pos, OldStr.length(), NewStr);
    }
    return Line;
}

string ReplaceString_v2(string Line, string OldStr, string NewStr)
{
    // ahmed mo eid ali
    // ahmed mohamed eid ali
    short Pos = Line.find(OldStr);
    if (Pos != std::string::npos)
    {
        string FirstSlice = Line.substr(0, Pos);
        string SecondSlice = Line.substr(Pos + OldStr.length(), Line.length() - 1);

        return FirstSlice + NewStr + SecondSlice;
    }
    return Line;
}

string RemoveSpecialChar(string Line)
{
    string CleanLine;
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (isalpha(Line[i]) || Line[i] == ' ')
        {
            CleanLine += Line[i];
        }
    }
    return CleanLine;
}

int main()
{
    // [41] Reverse word in string
    cout << ReverseEachWordInString("Ahmed Mohamed Eid Ali") << endl;

    // [42]
    cout << ReplaceString("Ahmed Mo Eid Ali", "mo", "Mohamed") << endl;

    // [43]
    cout << ReplaceString_v2("Ahmed Mo Eid Ali", "mo", "Mohamed") << endl;

    // [44]
    cout << RemoveSpecialChar("Yes, I`am Ahm$ed Mohamed@ Eid #Ali.");

    // [45] in [10-solving_46-50/solving_46-50.cpp] file
    return 0;
}