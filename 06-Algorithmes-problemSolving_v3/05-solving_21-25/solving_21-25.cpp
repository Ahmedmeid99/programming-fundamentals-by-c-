#include <iostream>
#include <string>
#include "../00-MyLibrary/numbers.cpp"
#include "../00-MyLibrary/strings.cpp"
using namespace std;

string ReadString(string Message)
{
    cout << Message;
    string Line;
    // cin.ignore(0, '\n');
    getline(cin, Line);
    return Line;
}

void PrintArray(int *Array, short Length)
{
    for (short i = 0; i <= Length - 1; i++)
    {
        cout << *(Array + i) << " ";
    }
    cout << endl;
}

void CreatFibonacciArray(int *Array, short Length)
{
    int Prev_1 = 1, Prev_2 = 1;
    *Array = Prev_1;
    *(Array + 1) = Prev_2;

    for (short i = 2; i <= Length - 1; i++)
    {
        *(Array + i) = *(Array + i - 1) + *(Array + i - 2);
        Prev_1 = *(Array + i);
        Prev_2 = Prev_1;
    }
}

string FirstLetterInEachWord_v0(string Line)
{
    string FirstLetters = "";
    // check first char
    if (isalpha(Line[0]))
    {
        FirstLetters.push_back(Line[0]);
    }
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (!isalpha(Line[i]) && isalpha(Line[i + 1]) && i < Line.length())
            FirstLetters.push_back(Line[i + 1]);
        else
            continue;
    }
    return FirstLetters;
}

string FirstLetterInEachWord(string Line)
{
    bool isFirstLetter = true;
    string FirstLetters = "";
    for (short i = 0; i < Line.length(); i++)
    {
        if (Line[i] != ' ' && isFirstLetter)
        {
            FirstLetters += Line[i];
        }

        isFirstLetter = (Line[i] == ' ') ? true : false;
    }
    return FirstLetters;
}

string UpperFirstLetterInEachWord(string Line)
{
    bool isFirstLetter = true;
    string UpdatedLine = "";
    for (short i = 0; i < Line.length(); i++)
    {
        if (Line[i] != ' ' && isFirstLetter)
        {
            UpdatedLine += strings::ToUperCase(Line[i]);
        }
        else
            UpdatedLine += Line[i];

        isFirstLetter = (Line[i] == ' ') ? true : false;
    }
    return UpdatedLine;
}

string LowerFirstLetterInEachWord(string Line)
{
    bool isFirstLetter = true;
    string UpdatedLine = "";
    for (short i = 0; i < Line.length(); i++)
    {
        if (Line[i] != ' ' && isFirstLetter)
        {
            UpdatedLine += strings::ToLowerCase(Line[i]);
        }
        else
            UpdatedLine += Line[i];

        isFirstLetter = (Line[i] == ' ') ? true : false;
    }
    return UpdatedLine;
}

int main()
{
    // [21] Fibonacci Series 1 1 2 3 5 8 13 21 34 55
    // short Length = nums::ReadPositveNumber("Enter Length of Fibonacci that you want : ");
    // int *P_FibonacciArray;
    // P_FibonacciArray = new int[Length];
    // CreatFibonacciArray(P_FibonacciArray, Length);
    // PrintArray(P_FibonacciArray, Length);
    // delete[] P_FibonacciArray;

    // [22] same last problem but solving by recursion

    // [23] First Letter in each word
    string Line = ReadString("Enter Some Words here : ");
    cout << FirstLetterInEachWord(Line) << endl;

    // [24]
    cout << UpperFirstLetterInEachWord("ahmed mohamed eid ali") << endl;

    // [25]
    cout << LowerFirstLetterInEachWord("Ahmed Mohamed Eid Ali") << endl;
    return 0;
}