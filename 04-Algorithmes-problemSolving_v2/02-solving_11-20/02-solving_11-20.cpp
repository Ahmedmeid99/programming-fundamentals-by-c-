#include <iostream>
#include <string>
#include <cstdlib>
using namespace std;



/////////////////////////////////////
//         Helpers Functions
int ReadInputNumber(string Message)
{
    int Number;
    do{
        cout << Message << endl;
        cin >> Number;
    }while(Number < 0);
    
    return Number;
}

string ReadInputString(string Message)
{
    string String;
    cout << Message << endl;
    cin >> String;
    return String;
}

void PrintResult(int Result )
{
    cout << "The Result is :" << Result  << endl;
}

/////////////////////////////////////
int ReverseNumber(int Number)
{
    int Remainder = 0, Number2 = 0;
    while(Number > 0)
    {
        Remainder = Number % 10;
        Number = Number / 10;
        Number2 = Number2 * 10 + Remainder;
    }
    return Number2;
}
/////////////////////////////////////

int ReturnRemainder(int Number)
{
    int Remainder = 0, Result = 0;
    while(Number > 0)
    {
    Remainder = Number % 10; // 4   => 3  => 2 => 1
    Number = Number / 10;   // 123 => 12 => 1 => 0
    return Remainder ;
    }
}

bool PalindromeChecking_v(int Number)
{
    // ex : Number = 12321
    bool IsPalindrome = 1;
    int ReversedNumber = ReverseNumber(Number) ; //   = 12321

    int Remainder = 0  ,Remainder2 = 0, Result = 0;
    while(Number > 0)
    {
    Remainder = Number % 10; // 1   => 2   => 3  => 2
    Number = Number / 10;   // 1232 => 123 => 12 => 1 => 0

    Remainder2 = ReversedNumber % 10;       // 1   => 2   => 3  => 2
    ReversedNumber = ReversedNumber / 10;  // 1232 => 123 => 12 => 1 => 0

    if(Remainder2 == Remainder)
        continue;
    else
        IsPalindrome = 0;
    };
    return IsPalindrome;

}

bool PalindromeChecking(int Number)
{
    return Number == ReverseNumber(Number);
}

void PrintResultOfPalindromeChecking(bool IsPalindrome)
{
    if(IsPalindrome)
        cout << "Yes , it is a Palindrome Number .\n" ;
    else
        cout << "No , it is Not a Palindrome Number .\n" ;
}

/////////////////////////////////////

void PrintInvertedNumberPattern(int Number)
{
    // 5
    for(int i = Number; i > 0 ;i--) // 5 : 1
    {
        for(int j = i; j > 0 ;j--) // i : 1 => times
        {
            cout << i ;
        }
        cout << endl;
    }
}

/////////////////////////////////////

void PrintNumberPattern(int Number)
{
    // 5
    for(int i = 1; i <= Number ;i++) // 1 : 5
    {
        for(int j = i; j > 0 ;j--) // i : 1 => times
        {
            cout << i ;
        }
        cout << endl;
    }
}

/////////////////////////////////////

void PrintInvertedLetterPattern(int Number)
{
    // 5
    int start = Number+64;
    int end = 64;
    for(int i = start; i > end ;i--) // 5 : 1
    {
        for(int j = i; j > end ;j--) // i : 1 => times
        {
            cout << static_cast<char>(i) ;
        }
        cout << endl;
    }
}

/////////////////////////////////////

void PrintLetterPattern(int Number)
{
    // 5
    int start = 64;
    int  end = Number+64;
    for(int i = start; i <= end ;i++) // 1 : 5
    {
        for(int j = i; j > start ;j--) // i : 1 => times
        {
            cout << static_cast<char>(i) ;
        }
        cout << endl;
    }
}

/////////////////////////////////////

void PrintAAAtoZZZ()
{
    for(int i = 65; i <= 91; i++)
    {
        for(int j = 65; j <= 91; j++)
        {
            for(int e = 65; e <= 91; e++)
            {
                cout << char(i) <<char(j) << char(e) << endl ;
            }
        }
    }
}

void GuessPassward()
{
    string GuessPassward = "AAC";
    for(int i = 65; i <= 91; i++)
    {
        for(int j = 65; j <= 91; j++)
        {
            for(int e = 65; e <= 91; e++)
            {
                string CheckPassword;
                CheckPassword.append(1,(char(i)) );
                CheckPassword.append(1,(char(j)) );
                CheckPassword.append(1,(char(e)) );
                int Times = e - 64;
                cout << "Trial " << "["<< Times <<"] : " << CheckPassword << endl;

                if(GuessPassward == CheckPassword)
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

/////////////////////////////////////

string EncryptEnPassWard(string Text,int Key)
{
    for (int i = 0; i <= Text.length(); i++)
    {
        Text[i] = char((int) Text[i] + Key); 
    }
    return Text;

}

string DecryptEnPassWard(string Text,int Key)
{
    for (int i = 0; i <= Text.length(); i++)
    {
        Text[i] = char((int) Text[i] - Key); 
    }
    return Text;

}

void Random1_10()
{
    cout << rand() % 5 << endl;
}

int RandomNumber(int From,int To)
{
    return (rand() % (To - From + 1) + From );
}

enum enCharType {SmallLetter = 1,CapitalLetter = 2,SpecialCharacter = 3,Digit = 4};

char RandomOf(char Char)
{
    if ((int)Char >= 33 && (int)Char <=47 )
    {
        return char(RandomNumber(33,47));
    
    }
    else if((int)Char >= 48 && (int)Char <=57)
    {
        return char(RandomNumber(48,57));
    }
    else if((int)Char >= 58 && (int)Char <=64)
    {
        return char(RandomNumber(58,64));
    }
    else if((int)Char >= 65 && (int)Char <=90)
    {
        return char(RandomNumber(65,90));
    }
    else if((int)Char >= 91 && (int)Char <=96)
    {
        return char(RandomNumber(91,96));
    }
    else if((int)Char >= 93 && (int)Char <=122)
    {
        return char(RandomNumber(97,122));
    }
    
}

char Random_of(enCharType CharType)
{
    switch (CharType)
    {
    case enCharType::SmallLetter :
        return char(RandomNumber(97,122));
        break;
    case enCharType::CapitalLetter :
        return char(RandomNumber(65,90));
        break;
    case enCharType::SpecialCharacter :
        return char(RandomNumber(33,47));
        break;
    case enCharType::Digit :
        return char(RandomNumber(48,57));
        break;
    
    default:
        break;
    }
}

int main()
{
    // [11] Palindrome Number
    // int N = ReadInputNumber("Enter Number to Check Is it a Palindrome Number or Not ");
    // PrintResultOfPalindromeChecking(PalindromeChecking(N));

    //[12] Inverted Number Pattern
    // int N2 = ReadInputNumber("Enter Number to Print Inverted Number Pattern ");
    // PrintInvertedNumberPattern(N2);

    // [13] Number Pattern 
    // int N3 = ReadInputNumber("Enter Number to Print Number Pattern ");
    // PrintNumberPattern(N3);

    // [14] Inverted Letter Pattern
    // int N4 = ReadInputNumber("Enter Number to Print Inverted Letter Pattern ");
    // PrintInvertedLetterPattern(N4);

    // [15] Letter Pattern
    // int N5 = ReadInputNumber("Enter Number to Print Letter Pattern ");
    // PrintLetterPattern(N5);

    // [16] AAA to ZZZ
    // PrintAAAtoZZZ();

    // [17] Guess 3-Letter Passward (all capital) From AAA to ZZZ
    // GuessPassward();

    // [18] get string and Print EncryptText and DecryptText
    // int Key = 2 ; // must be more complexed
    // string PassWard =ReadInputString("Enter PassWard to Encrypt it");
    // string EncryptText = EncryptEnPassWard(PassWard,Key);
    // string DecryptText = DecryptEnPassWard(EncryptText,Key);
    // cout << "The PassWard You Entered is" <<PassWard <<"\n"<< EncryptText <<"\n"<< DecryptText<< "\n";

    // [19] Write a program to print 3 random numbers from 1 to 10
    // Seed the random number generator in c++ called only once
    srand((unsigned)time(NULL));
    // Random1_10();        // 7
    // RandomNumber(1,20);  // 12
    // cout <<rand()<<endl; // get random number between 0 and maxNumber in int ex:17641

    // [20] Random of same Entered Character
    enCharType CharType;
    cout<<Random_of(enCharType::CapitalLetter)<<endl;     // C
    cout<<Random_of(enCharType::SmallLetter)<<endl;       // n
    cout<<Random_of(enCharType::SpecialCharacter)<<endl;  // #
    cout<<Random_of(enCharType::Digit)<<endl;             // 7
    /////////////////////////////////////
    cout<< RandomOf('A')<<endl;  // Z
    cout<< RandomOf('%')<<endl;  // +
    cout<< RandomOf('1')<<endl;  // 2
    cout<< RandomOf('a')<<endl;  // s
    cout<< RandomOf('[')<<endl;  // _
    cout<< RandomOf('<')<<endl;  // <
    return 0;
}