#pragma once
#include <iostream>
using namespace std;

namespace random
{
    // [1]
    int RandomNumber(int From, int To)
    {
        return (rand() % (To - From + 1) + From);
    }

    // [2]
    enum enCharType
    {
        SmallLetter = 1,
        CapitalLetter = 2,
        SpecialCharacter = 3,
        Digit = 4
    };

    char Random_of(enCharType CharType)
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

}