#pragma once
#include <iostream>
#include "../00-Date-Library/clsDate.cpp";
using namespace std;

class clsUtility
{
public:
    enum enCharType
    {
        SmallLetter = 1,
        CapitalLetter = 2,
        SpecialCharacter = 3,
        Digit = 4
    };
    // all methods are static
    /*************************/

    static int RandomNumber(int From, int To)
    {
        return (rand() % (To - From + 1) + From);
    }

    static char Random_of(enCharType CharType)
    {
        switch (CharType)
        {
        case enCharType::SmallLetter:
            return char(RandomNumber(97, 122));
            break;
        case enCharType::CapitalLetter:
            return char(RandomNumber(65, 90));
            break;
        case enCharType::SpecialCharacter:
            return char(RandomNumber(33, 47));
            break;
        case enCharType::Digit:
            return char(RandomNumber(48, 57));
            break;

        default:
            return char(RandomNumber(48, 57));
            break;
        }
    }

    static string Space(short Number)
    {
        string SpaceLong;
        for (short i = 1; i <= Number; i++)
        {
            SpaceLong += "\t";
        }
        return SpaceLong;
    }

    /*************************/

    static void PrintAtoZ()
    {
        for (int j = 65; j < 91; j++)
        {
            cout << char(j) << endl;
        }
    }

    // [2] is between  AAA and ZZZ
    static void GuessPassward()
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
    static string EncryptEnPassWard(string Text, int Key)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] + Key);
        }
        return Text;
    }

    static string DecryptEnPassWard(string Text, int Key)
    {
        for (int i = 0; i <= Text.length(); i++)
        {
            Text[i] = char((int)Text[i] - Key);
        }
        return Text;
    }

    string GenerateKey()
    {
        string Key = "";
        for (int i = 1; i <= 16; i++)
        {
            //  Key [1] : YZER-GBDD-LSIF-BSRV
            if (i % 4 == 0 && i != 16)
            {
                Key += Random_of(enCharType::CapitalLetter);
                Key += "-";
            }
            else
            {
                Key += Random_of(enCharType::CapitalLetter);
            }
        }
        return Key;
    }

    /*************************/
    // [3] swap numbers
    static void Swap(int &num1, int &num2)
    {
        int temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void Swap(float &num1, float &num2)
    {
        float temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void Swap(double &num1, double &num2)
    {
        double temp;
        temp = num1;
        num1 = num2;
        num2 = temp;
    }

    static void Swap(string &st1, string &st2)
    {
        string temp;
        temp = st1;
        st1 = st2;
        st2 = temp;
    }

    void Swap(clsDate &Date_1, clsDate &Date_2)
    {
        clsDate temp;
        temp = Date_1;
        Date_1 = Date_2;
        Date_2 = temp;
    }

    /*************************/
    static void SuffleArray(int arr[100], int Length)
    {
        // swap rabdom 2 Numbers in array
        for (int i = 0; i <= Length - 1; i++)
        {
            int index1 = RandomNumber(0, Length - 1);
            int index2 = RandomNumber(0, Length - 1);

            Swap(arr[index1], arr[index2]);
        }
    }

    static string NumberToText(int Number)
    {
        if (Number == 0)
        {
            return "";
        }
        else if (Number > 0 && Number <= 19)
        {

            string Array1[20] =
                {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};

            return Array1[Number] + " ";
        }
        else if (Number >= 20 && Number <= 99)
        {
            string Array2[10] =
                {"", "", "twenty", "thirty", "forty", "fifty", "sisty", "seventy", "eighty", "ninety"};

            return Array2[Number / 10] + " " + NumberToText(Number % 10);
        }
        else if (Number >= 100 && Number <= 199)
        {
            // 199 => 1 99
            return "One hundred " + NumberToText(Number % 100);
        }
        else if (Number >= 200 && Number <= 999)
        {
            // 220 = > 2 20
            return NumberToText(Number / 100) + "hundred " + NumberToText(Number % 100);
        }
        else if (Number >= 1000 && Number <= 1999)
        {
            // 199 => 1 999
            return "One thousand " + NumberToText(Number % 1000);
        }
        else if (Number >= 2000 && Number <= 999999)
        {
            // 999999 =>999 999
            return NumberToText(Number / 1000) + "thousand " + NumberToText(Number % 1000);
        }
        else if (Number >= 1000000 && Number <= 1999999)
        {
            // 1999999 => 1 999999
            return "One Million " + NumberToText(Number % 1000000);
        }
        else if (Number >= 2000000 && Number <= 999999999)
        {
            // 999999999 =>999 999999
            return NumberToText(Number / 1000000) + "thousand " + NumberToText(Number % 1000000);
        }
        else if (Number >= 1000000000 && Number <= 1999999999)
        {
            // 1999999999 => 1 999999999
            return "One Billion " + NumberToText(Number % 1000000000);
        }
        else
        {
            // 999999999 =>999 999999
            return NumberToText(Number / 1000000000) + "Billion " + NumberToText(Number % 1000000000);
        }
    }
};