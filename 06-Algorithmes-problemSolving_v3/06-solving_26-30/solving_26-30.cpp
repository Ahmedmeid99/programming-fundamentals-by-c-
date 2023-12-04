#include <iostream>
#include <string>
#include <iomanip>
#include "../00-MyLibrary/numbers.cpp"
#include "../00-MyLibrary/strings.cpp"
using namespace std;

string ReadString(string Message)
{
    cout << Message;
    string Line;
    getline(cin, Line);
    return Line;
}

string StringToUpperCase(string Line)
{
    string UpdatedLine = "";
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (isalpha(Line[i]))
            UpdatedLine.push_back(strings::ToUperCase(Line[i]));
        else
            UpdatedLine.push_back(Line[i]);
    }
    return UpdatedLine;
}

string StringToLowerCase(string Line)
{
    string UpdatedLine = "";
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (isalpha(Line[i]))
            UpdatedLine.push_back(strings::ToLowerCase(Line[i]));
        else
            UpdatedLine.push_back(Line[i]);
    }
    return UpdatedLine;
}

char InvertLetterCase(char Letter)
{
    if (strings::IsSmallLetter(Letter))
        return strings::ToUperCase(Letter);
    else
        return strings::ToLowerCase(Letter);
}

string InvertAllLetters(string Line)
{
    string UpdatedLine = "";
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (isalpha(Line[i]))
            UpdatedLine.push_back(InvertLetterCase(Line[i]));
        else
            UpdatedLine.push_back(Line[i]);
    }
    return UpdatedLine;
}

short CapitalLettersCount(string Line)
{
    short TotalCount = 0;
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (strings::IsCapitalLetter(Line[i]))
            TotalCount++;
        else
            continue;
    }
    return TotalCount;
}

short SmallLettersCount(string Line)
{
    short TotalCount = 0;
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (strings::IsSmallLetter(Line[i]))
            TotalCount++;
        else
            continue;
    }
    return TotalCount;
}

short LetterCount(string Line, char Letter)
{
    short TotalCount = 0;
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (Line[i] == Letter)
            TotalCount++;
        else
            continue;
    }
    return TotalCount;
}

int main()
{
    // [26] Upper all letters in String
    cout << StringToUpperCase("ahmed eid") << endl;
    cout << StringToLowerCase("AHMED EID") << endl;

    // [27] A -> a and a -> A
    cout << InvertLetterCase('A') << endl;
    cout << InvertLetterCase('a') << endl;

    // [28] Invert all letters
    cout << InvertAllLetters("AHMED mohamed EID") << endl;

    // [29]
    string Line = "Ahmed Mohamed Eid Ali";
    cout << "\n\n";
    cout << setw(30) << "String Length : " << Line.length() << endl;
    cout << setw(30) << "small letters count : " << SmallLettersCount(Line) << endl;
    cout << setw(30) << "Capital letters count : " << CapitalLettersCount(Line) << endl;

    // [30]
    cout << LetterCount(Line, 'e') << endl;
    cout << LetterCount(Line, 'm') << endl;
    return 0;
}