#pragma once

#include <iostream>
#include <string>
#include "random.cpp"
using namespace std;

namespace strings
{
    // [1]
    string ReadInputString(string Message)
    {
        string InputString;

        bool IsValid = true;
        do
        {
            cout << Message;
            getline(cin, InputString);
            for (char Digit : InputString)
            {
                if (isalpha(Digit))
                {
                    IsValid = false;
                    break;
                }
            }
        } while (IsValid);
        return InputString;
    }

    // [2]
    void PrintAtoZ()
    {
        for (int j = 65; j < 91; j++)
        {
            cout << char(j) << endl;
        }
    }

    // [2] is between  AAA and ZZZ
    void GuessPassward()
    {
        string GuessPassward = "AAC";
        for (int i = 65; i <= 91; i++)
        {
            for (int j = 65; j <= 91; j++)
            {
                for (int e = 65; e <= 91; e++)
                {
                    string CheckPassword;
                    CheckPassword.append(1, (char(i)));
                    CheckPassword.append(1, (char(j)));
                    CheckPassword.append(1, (char(e)));
                    int Times = e - 64;
                    cout << "Trial "
                         << "[" << Times << "] : " << CheckPassword << endl;

                    if (GuessPassward == CheckPassword)
                    {
                        cout << "Passward is " << CheckPassword << endl;
                        cout << "Found after " << Times << " Trial(s)" << endl;
                        break;
                    }
                }
                break;
            }
            break;
        }
    }

    // [3] note: key must be more complexed
    string EncryptEnPassWard(string Text, int Key)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] + Key);
        }
        return Text;
    }

    string DecryptEnPassWard(string Text, int Key)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] - Key);
        }
        return Text;
    }

    // [4]
    string GenerateKey()
    {
        string Key = "";
        for (int i = 1; i <= 16; i++)
        {
            //  Key [1] : YZER-GBDD-LSIF-BSRV
            if (i % 4 == 0 && i != 16)
            {
                Key += random::Random_of(random::enCharType::CapitalLetter);
                Key += "-";
            }
            else
            {
                Key += random::Random_of(random::enCharType::CapitalLetter);
            }
        }
        return Key;
    }

    ///////////////////////////////
    ////////////[ Char ]///////////
    ///////////////////////////////
    bool IsSmallLetter(char Letter)
    {
        return int(Letter) >= 97 && int(Letter) <= 122;
    }

    bool IsCapitalLetter(char Letter)
    {
        return int(Letter) >= 65 && int(Letter) <= 90;
    }

    char ToUperCase(char Letter)
    {
        if (IsCapitalLetter(Letter))
            return Letter;
        else
            return char(int(Letter - 32));
    }

    char ToLowerCase(char Letter)
    {
        if (IsSmallLetter(Letter))
            return Letter;
        else
            return char(int(Letter + 32));
    }
}