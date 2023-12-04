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
    // cin.ignore(0, '\n');
    getline(cin, Line);
    return Line;
}
struct stLetterCount
{
    short CharCount = 0;
    short CapitalCharCount = 0;
    short SmallCharCount = 0;
};
enum enCharType
{
    SmallLetter = 0,
    CapitalLetter = 1,
    AllLetter = 3
};

short LetterCount(string Line, char Letter, enCharType CharType)
{
    short TotalCount = 0;
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (CharType == enCharType::SmallLetter)
        {
            if (Line[i] == strings::ToLowerCase(Letter))
            {
                TotalCount++;
            }
        }
        else if (CharType == enCharType::CapitalLetter)
        {
            if (Line[i] == strings::ToUperCase(Letter))
            {
                TotalCount++;
            }
        }
        else if (CharType == enCharType::AllLetter)
        {
            if (Line[i] == strings::ToLowerCase(Letter) || Line[i] == strings::ToUperCase(Letter))
            {
                TotalCount++;
            }
        }
    }
    return TotalCount;
}

bool IsAVowle(char Letter)
{
    char AVowleArray[5] = {'a', 'e', 'i', 'o', 'u'};
    bool IsFound = false;
    for (short i = 0; i < 5; i++)
    {
        if (Letter == AVowleArray[i] || Letter == char(int(AVowleArray[i]) - 32))
        {
            IsFound = true;
            break;
        }
        else
            continue;
    }
    return IsFound;
}

void PrintIsVowle(bool IsAVowle)
{
    if (IsAVowle)
    {
        cout << "Yes, This is a vowle" << endl;
    }
    else
    {
        cout << "No, This is not a vowle" << endl;
    }
}

short CountOfVowle(string Line)
{
    short TotalCount = 0;
    for (short i = 0; i < Line.length(); i++)
    {
        if (IsAVowle(Line[i]))
        {
            TotalCount++;
        }
    }
    return TotalCount;
}

void PrintAVowleLetters(string Line)
{
    for (short i = 0; i < Line.length(); i++)
    {
        if (IsAVowle(Line[i]))
        {
            cout << Line[i] << " ";
        }
    }
    cout << endl;
}

void PrintEachWordInString_v0(string Line)
{
    for (short i = 0; i < Line.length(); i++)
    {
        if (Line[i] != ' ')
        {
            cout << Line[i];
        }
        else
            cout << endl;
    }
    cout << endl;
}
void PrintEachWordInString(string Line)
{
    short Pos = 0;
    string Word;
    string Delim = " ";

    while ((Pos = Line.find(Delim)) != std::string::npos)
    {
        Word = Line.substr(0, Pos);

        if (Word != "")
        {
            cout << Word << endl;
        }

        Line.erase(0, Pos + Delim.length());
    }

    // get lasr word in string
    if (Line != "")
    {
        cout << Line << endl;
    }
}

int main()
{
    // [31]
    string Line = "My Name : Ahmed Mohamed Eid";
    cout << "All Char Letter Count : " << LetterCount(Line, 'm', enCharType::AllLetter) << endl;
    cout << "Capital Letter Count : " << LetterCount(Line, 'm', enCharType::CapitalLetter) << endl;
    cout << "Small Letter Count : " << LetterCount(Line, 'm', enCharType::SmallLetter) << endl;

    // [32] check Char is a vowle (a e i o u)
    PrintIsVowle(IsAVowle('u'));
    PrintIsVowle(IsAVowle('E'));
    PrintIsVowle(IsAVowle('x'));

    // [33] count of Vowles in string
    cout << CountOfVowle("Ahmed Mohamed Eid Ali") << endl; // 9

    // [34] print a vowle in order
    PrintAVowleLetters("Ahmed Mohamed Eid Ali"); // A e o a e E i A i

    // [35]
    PrintEachWordInString("Ahmed Mohamed Eid Ali");

    return 0;
}