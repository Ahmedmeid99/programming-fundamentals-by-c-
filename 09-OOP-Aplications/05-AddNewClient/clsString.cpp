#pragma once
#include <iostream>
#include <vector>
#include <string>

using namespace std;

class clsString
{
private:
    string _Value;

public:
    // constractor [1]
    clsString()
    {
        _Value = "";
    }

    // constractor [2]
    clsString(string Value)
    {
        _Value = Value;
    }

    void SetValue(string Value)
    {
        _Value = Value;
    }

    string GetValue()
    {
        return _Value;
    }

    static string ToUpperCase(string Text)
    {
        string UpdatedText = "";
        for (short i = 0; i <= Text.length() - 1; i++)
        {
            if (isalpha(Text[i]))
                UpdatedText.push_back(toupper(Text[i]));
            else
                UpdatedText.push_back(Text[i]);
        }
        return UpdatedText;
    }

    void ToUpperCase()
    {
        _Value = ToUpperCase(_Value);
    }

    static string ToLowerCase(string Text)
    {
        string UpdatedText = "";
        for (short i = 0; i <= Text.length() - 1; i++)
        {
            if (isalpha(Text[i]))
                UpdatedText.push_back(tolower(Text[i]));
            else
                UpdatedText.push_back(Text[i]);
        }
        return UpdatedText;
    }

    void ToLowerCase()
    {
        _Value = ToLowerCase(_Value);
    }

    static string FirstLetters(string Text)
    {
        bool isFirstLetter = true;
        string FirstLetters = "";
        for (short i = 0; i < Text.length(); i++)
        {
            if (Text[i] != ' ' && isFirstLetter)
            {
                FirstLetters += Text[i];
            }

            isFirstLetter = (Text[i] == ' ') ? true : false;
        }
        return FirstLetters;
    }

    string FirstLetters()
    {
        return FirstLetters(_Value);
    }

    static string UpperFirstLetters(string Text)
    {
        bool isFirstLetter = true;
        string UpdatedText = "";
        for (short i = 0; i < Text.length(); i++)
        {
            if (Text[i] != ' ' && isFirstLetter)
            {
                UpdatedText += toupper(Text[i]);
            }
            else
                UpdatedText += Text[i];

            isFirstLetter = (Text[i] == ' ') ? true : false;
        }
        return UpdatedText;
    }

    void UpperFirstLetters()
    {
        _Value = UpperFirstLetters(_Value);
    }

    static string LowerFirstLetters(string Text)
    {
        bool isFirstLetter = true;
        string UpdatedText = "";
        for (short i = 0; i < Text.length(); i++)
        {
            if (Text[i] != ' ' && isFirstLetter)
            {
                UpdatedText += tolower(Text[i]);
            }
            else
                UpdatedText += Text[i];

            isFirstLetter = (Text[i] == ' ') ? true : false;
        }
        return UpdatedText;
    }

    void LowerFirstLetters()
    {
        _Value = LowerFirstLetters(_Value);
    }

    static short CountWords(string Text, string Delim = " ")
    {
        short Pos = 0;
        string Word;
        short Counter = 0;

        while ((Pos = Text.find(Delim)) != std::string::npos)
        {
            Word = Text.substr(0, Pos);

            if (Word != "")
            {
                Counter++;
            }

            Text.erase(0, Pos + Delim.length());
        }

        // get lasr word in string
        if (Text != "")
        {
            Counter++;
        }
        return Counter;
    }

    short CountWords(string Delim = " ")
    {
        Delim = (Delim != " ") ? Delim : " ";
        return CountWords(_Value, Delim);
    }

    static vector<string> SplitStringOn(string Text, string Delim = " ")
    {
        vector<string> vString;
        short Pos = 0;
        string Word;

        while ((Pos = Text.find(Delim)) != std::string::npos)
        {
            Word = Text.substr(0, Pos);

            if (Word != "")
            {
                vString.push_back(Word);
            }

            Text.erase(0, Pos + Delim.length());
        }

        // get lasr word in string
        if (Text != "")
        {
            vString.push_back(Text);
        }
        return vString;
    }

    vector<string> SplitStringOn(string Delim = " ")
    {
        return SplitStringOn(_Value, Delim);
    }

    static string trimLeft(string Text)
    {
        for (short i = 0; i <= Text.length() - 1; i++)
        {
            if (Text[i] == ' ' && Text[i + 1] != ' ')
            {
                Text.erase(0, i + 1);
                break;
            }
        }
        return Text;
    }

    void trimLeft()
    {
        _Value = trimLeft(_Value);
    }

    static string trimRight(string Text)
    {
        for (short i = Text.length() - 1; i <= 0; i++)
        {
            if (Text[i] == ' ' && Text[i - 1] != ' ')
            {
                Text.erase(Text.length() - 1, i - 1);
                break;
            }
        }
        return Text;
    }

    void trimRight()
    {
        _Value = trimRight(_Value);
    }

    static string trim(string Text)
    {
        return trimRight(trimLeft(Text));
    }

    void trim()
    {
        _Value = trim(_Value);
    }

    static string JoinWords(vector<string> vWords, string Delim)
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

    void JoinWords(vector<string> vWords)
    {
        string Delim = " ";
        _Value += Delim + JoinWords(vWords, Delim);
    }
    static string ReverseEachWordInString(string Text, string Delim = " ")
    {
        // Ahmed Mohamed Eid Ali
        string Word;
        string ReversdText;
        short Pos;

        while ((Pos = Text.find_last_of(Delim)) != std::string::npos)
        {
            Word = Text.substr(Pos + Delim.length(), Text.length() - 1);
            if (Word != "")
            {
                ReversdText += Word + Delim;
            }
            Text.erase(Pos, Text.length() - 1);
        }

        if (Text != "")
        {
            ReversdText += Text;
        }

        return ReversdText;
    }

    void ReverseEachWordInString(string Delim = " ")
    {
        _Value = ReverseEachWordInString(_Value, Delim);
    }

    static string ReplaceString(string Text, string OldStr, string NewStr)
    {
        short Pos = Text.find(OldStr);
        if (Pos != std::string::npos)
        {
            string FirstSlice = Text.substr(0, Pos);
            string SecondSlice = Text.substr(Pos + OldStr.length(), Text.length() - 1);

            return FirstSlice + NewStr + SecondSlice;
        }
        return Text;
    }

    void ReplaceString(string OldStr, string NewStr)
    {
        _Value = ReplaceString(_Value, OldStr, NewStr);
    }

    static string RemoveSpecialChar(string Text)
    {
        string CleanText;
        for (short i = 0; i <= Text.length() - 1; i++)
        {
            if (isalpha(Text[i]) || Text[i] == ' ')
            {
                CleanText += Text[i];
            }
        }
        return CleanText;
    }

    void RemoveSpecialChar()
    {
        _Value = RemoveSpecialChar(_Value);
    }

    // set by = "" and get by [].[]
    // __declspec(property(get = GetValue, put = SetValue)) string Value;
};