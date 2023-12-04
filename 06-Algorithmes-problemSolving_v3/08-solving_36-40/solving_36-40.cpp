#include <iostream>
#include <vector>
#include <string>
using namespace std;

short CountEachWordInString_v0(string Line)
{
    short TotalCount = 0;
    bool FirstLetter = true;
    for (short i = 0; i < Line.length(); i++)
    {
        if (Line[i] != ' ' && FirstLetter)
        {
            TotalCount++;
        }

        FirstLetter = (Line[i] == ' ') ? true : false;
    }
    return TotalCount;
}

short CountEachWordInString(string Line)
{
    short Pos = 0;
    string Word;
    string Delim = " ";
    short Counter = 0;

    while ((Pos = Line.find(Delim)) != std::string::npos)
    {
        Word = Line.substr(0, Pos);

        if (Word != "")
        {
            Counter++;
        }

        Line.erase(0, Pos + Delim.length());
    }

    // get lasr word in string
    if (Line != "")
    {
        Counter++;
    }
    return Counter;
}

vector<string> SplitStringOn(string Line, string Delim)
{
    vector<string> vString;
    short Pos = 0;
    string Word;

    while ((Pos = Line.find(Delim)) != std::string::npos)
    {
        Word = Line.substr(0, Pos);

        if (Word != "")
        {
            vString.push_back(Word);
        }

        Line.erase(0, Pos + Delim.length());
    }

    // get lasr word in string
    if (Line != "")
    {
        vString.push_back(Line);
    }
    return vString;
}

string trimLeft(string Line)
{
    for (short i = 0; i <= Line.length() - 1; i++)
    {
        if (Line[i] == ' ' && Line[i + 1] != ' ')
        {
            Line.erase(0, i + 1);
            break;
        }
    }
    return Line;
}

string trimRight(string Line)
{
    for (short i = Line.length() - 1; i <= 0; i++)
    {
        if (Line[i] == ' ' && Line[i - 1] != ' ')
        {
            Line.erase(Line.length() - 1, i - 1);
            break;
        }
    }
    return Line;
}

string trim(string Line)
{
    return trimRight(trimLeft(Line));
}

string Join(vector<string> vWords, string Delim)
{
    string ResultString = "";
    for (string &Word : vWords)
    {
        ResultString += Word;
        if (Word != vWords[vWords.size() - 1])
            ResultString += Delim;
    }
    return ResultString;
}

void FillArray(string *pArray, short Length)
{
    *(pArray) = "Ahmed";
    *(pArray + 1) = "Mohamed";
    *(pArray + 2) = "Eid";
    *(pArray + 3) = "Ali";
}

string Join_v2(string *pArray, short Length, string Delim)
{
    string StringReslt = "";
    for (short i = 0; i <= Length - 1; i++)
    {
        StringReslt += *(pArray + i);
        if (i != Length - 1)
            StringReslt += Delim;
    }
    return StringReslt;
}
int main()
{
    // [36]
    cout << CountEachWordInString(" Ahmed Mohamed Eid Ali ") << endl;

    // [37] split string on
    vector vWords = SplitStringOn("ahmed mohamed eid ali", " ");
    vector vWords2 = SplitStringOn("ahmed#_#mohamed#_#eid#_#ali", "#_#");
    cout << vWords[0] << endl;
    cout << vWords[2] << endl;

    cout << vWords2[0] << endl;
    cout << vWords2[2] << endl;

    // [38] trim Left, right, all
    cout << trimLeft("         ahmed mohamed eid ali    ") << endl;
    cout << trimRight("ahmed mohamed eid ali       ") << endl;
    cout << trim("   ahmed mohamed eid ali       ") << endl;

    // [39] Join some of words using delim than return string (input-> vector)
    cout << Join(vWords, "_") << endl;
    cout << Join(vWords, " ") << endl;

    // [40] Join some of words using delim than return string (input-> array)
    int Number = 4;
    string *pArray = new string[Number];
    FillArray(pArray, Number);
    cout << Join_v2(pArray, Number, "-") << endl;
    delete[] pArray;
    return 0;
}