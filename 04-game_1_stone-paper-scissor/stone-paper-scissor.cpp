#include <iostream>
#include <cstdlib>
using namespace std;

///////////////////////////////////////////////////
//////////////////[ Helper Functions ]/////////////
int ReadInputNumber(string Message)
{
    int Number;
    do
    {
        cout << Message;
        cin >> Number;
    } while (Number < 1 || Number > 10);

    return Number;
}
string ReadInputString(string Message)
{
    string String;
    cout << Message << endl;
    cin >> String;
    return String;
}
int RandomNumber(int From, int To)
{
    return (rand() % (To - From + 1) + From);
}
//////////////////////////////////////////////////

enum enGameChoice
{
    Stone = 1,
    Paper = 2,
    Scissor = 3,
};

struct stGameInfo
{
    int TotlaRound;
    int Round;
    int Draw;
    int UserScore;
    int ComputerScore;
};

struct stGame
{
    enGameChoice userChoice;
    enGameChoice ComputerChoice;
};

enGameChoice MakecomputerChoice() // ok
{
    int NumberOfChoice = RandomNumber(1, 3);
    return (enGameChoice)NumberOfChoice;
}

void SoundOfRoundLose()
{
    cout << "\a";
}

void RoundGame(stGameInfo &GameInfo, stGame &Game) // ok
{
    // fill Game and GameInfo
    int userChoice;
    do
    {
        userChoice = ReadInputNumber("Your Choice : [1]:Stone, [2]:Paper, [3]:Scissor ? ");

    } while (userChoice > 3 || userChoice < 1);
    cout << endl;
    Game.userChoice = (enGameChoice)userChoice;
    enGameChoice computerChoice = MakecomputerChoice();
    Game.ComputerChoice = computerChoice;
    GameInfo.Round++;
}

string GameWinner(int UserScore, int ComputerScore) //
{
    if (UserScore > ComputerScore)
    {
        return "User";
    }
    else if (ComputerScore > UserScore)
    {
        return "Computer";
    }
    else
        return "[No Winner]";
}

string RoundWinner(stGameInfo &GameInfo, stGame &Game)
{
    if (Game.userChoice == enGameChoice::Paper)
    {
        if (Game.ComputerChoice == enGameChoice::Scissor)
        {
            GameInfo.ComputerScore++;
            system("color 4f");
            SoundOfRoundLose();
            return "ComputerScore";
        }
        else if (Game.ComputerChoice == enGameChoice::Stone)
        {
            GameInfo.UserScore++;
            system("color 2f");
            return "User";
        }
    }
    else if (Game.userChoice == enGameChoice::Scissor)
    {
        if (Game.ComputerChoice == enGameChoice::Paper)
        {
            GameInfo.UserScore++;
            system("color 2f");
            return "User";
        }
        else if (Game.ComputerChoice == enGameChoice::Stone)
        {
            GameInfo.ComputerScore++;
            system("color 4f");
            SoundOfRoundLose();
            return "Computer";
        }
    }
    else if (Game.userChoice == enGameChoice::Stone)
    {
        if (Game.ComputerChoice == enGameChoice::Paper)
        {
            GameInfo.ComputerScore++;
            system("color 4f");
            SoundOfRoundLose();
            return "Computer";
        }
        else if (Game.ComputerChoice == enGameChoice::Scissor)
        {
            GameInfo.UserScore++;
            system("color 2f");
            return "User";
        }
    }
    GameInfo.Draw++;
    system("color 6f");
    return "[No Winner]";
}

string ChoiseResult(enGameChoice Choice)
{
    switch (Choice)
    {
    case enGameChoice::Paper:
        return "Paper";
        break;
    case enGameChoice::Scissor:
        return "Scissor";
        break;
    case enGameChoice::Stone:
        return "Stone";
        break;

    default:
        return "Paper";
        break;
    }
}

void RoundResult(stGameInfo &GameInfo, stGame &Game) // ok
{
    cout << "__________Round [" << GameInfo.Round << "]__________\n";
    cout << "Player1  choice:     " << ChoiseResult(Game.userChoice) << endl;
    cout << "Computer choice:     " << ChoiseResult(Game.ComputerChoice) << endl;
    cout << "Round Winner   :   " << RoundWinner(GameInfo, Game) << endl;
    cout << "_____________________________\n\n";
}

void GameResult(stGameInfo GameInfo)
{
    string theWinner = GameWinner(GameInfo.UserScore, GameInfo.ComputerScore);
    cout << "\n\n\t\t-------------------------------------------------------\n";
    cout << "\t\t\t\t +++ G a m e O v e r +++\n";
    cout << "\t\t-------------------------------------------------------\n";
    cout << "\t\t--------------------[ Game Results ]-------------------\n";
    cout << "\t\tGame Rounds         : " << GameInfo.Round << endl;
    cout << "\t\tPlayer1 won times   : " << GameInfo.UserScore << endl;
    cout << "\t\tComputer won times  : " << GameInfo.ComputerScore << endl;
    cout << "\t\tDraw times          : " << GameInfo.Draw << endl;
    cout << "\t\tFinal Winner        : " << theWinner << endl;
    cout << "\t\t-------------------------------------------------------\n";

    if (theWinner == "User")
        system("color 2f");
    else if (theWinner == "Computer")
        system("color 4f");
    else
        system("color 6f");
}

void RestGameInfo(stGameInfo &GameInfo)
{
    GameInfo.TotlaRound = 0;
    GameInfo.Round = 0;
    GameInfo.UserScore = 0;
    GameInfo.ComputerScore = 0;
    GameInfo.Draw = 0;
    system("color f0");
    system("cls");
}

void Start()
{
    stGame Game;
    stGameInfo GameInfo;
    RestGameInfo(GameInfo);
    string NewGame;
    do
    {
        GameInfo.TotlaRound = ReadInputNumber("How Many Rounds 1 to 10? ");
        for (int i = 1; i <= GameInfo.TotlaRound; i++)
        {
            RoundGame(GameInfo, Game);
            RoundResult(GameInfo, Game);
        }
        GameResult(GameInfo);
        NewGame = ReadInputString("Do you want to play again Y/N? ");
        RestGameInfo(GameInfo);
    } while (NewGame == "y" || NewGame == "Y");
}

int main()
{
    srand((unsigned)time(NULL));
    Start();
    return 0;
}