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

char ReadInputChar(string Message)
{
    char Char;
    cout << Message << endl;
    cin >> Char;
    return Char;
}

int RandomNumber(int From, int To)
{
    return (rand() % (To - From + 1) + From);
}
//////////////////////////////////////////////////

enum enOperatorType
{
    Add = 1,
    Sub = 2,
    Mul = 3,
    Div = 4,
    Mix = 5
};

enum enLevel
{
    Easy = 1,
    Mid = 2,
    Hard = 3,
    MixL = 4
};

enum enGameResult
{
    PASS = 1,
    FAIL = 0
};

struct stQuestion
{
    int firstNumber;
    int SecondNumber;
    enOperatorType OP;
    int userAnswer;
    int RightAnswer;
};

struct stMathGameInfo
{
    int NumberOfQuestions;
    int RigthQuestions = 0;
    int WrongQuestions = 0;
    enLevel QuestionsLevel;
    enOperatorType Operator;
    enGameResult GameResult;
};

//////////////////////////////////////////////////

void SetMathGameInfo(stMathGameInfo &MathGameInfo)
{
    MathGameInfo.NumberOfQuestions = ReadInputNumber("Hom Many Questions do you want to answer? : ");
    MathGameInfo.QuestionsLevel = (enLevel)ReadInputNumber("Enter Questions Level [1] Easy, [2] Med, [3] Hard, [4] Mix? : ");
    MathGameInfo.Operator = (enOperatorType)ReadInputNumber("Enter Operation Type [1] Add, [2] Sub, [3] Mul, [4] Div, [5] Mix? : ");
}

enLevel RandomLevel()
{
    return (enLevel)RandomNumber(1, 3);
}

enLevel Level(enLevel QuestionsLevel)
{
    switch (QuestionsLevel)
    {
    case enLevel::Easy:
        return enLevel::Easy;
        break;
    case enLevel::Mid:
        return enLevel::Mid;
        break;
    case enLevel::Hard:
        return enLevel::Hard;
        break;
    case enLevel::MixL:
        return RandomLevel();
        break;
    default:
        return enLevel::Easy;
        break;
    }
}

int CreatRandNumber(enLevel QuestionsLevel)
{
    switch (QuestionsLevel)
    {
    case enLevel::Easy:
        return RandomNumber(1, 10);
        break;
    case enLevel::Mid:
        return RandomNumber(11, 20);
        break;
    case enLevel::Hard:
        return RandomNumber(50, 100);
        break;
    default:
        return RandomNumber(1, 10);
        break;
    }
}

enOperatorType RandomOp()
{
    return (enOperatorType)RandomNumber(1, 4);
}

enOperatorType CreateOP(enOperatorType Operator)
{
    switch (Operator)
    {
    case enOperatorType::Add:
        return enOperatorType::Add;
        break;
    case enOperatorType::Sub:
        return enOperatorType::Sub;
        break;
    case enOperatorType::Mul:
        return enOperatorType::Mul;
        break;
    case enOperatorType::Div:
        return enOperatorType::Div;
        break;

    case enOperatorType::Mix:
        return RandomOp();
        break;
    default:
        return enOperatorType::Add;
        break;
    }
}

char PrintOP(enOperatorType Operator)
{
    switch (Operator)
    {
    case enOperatorType::Add:
        return '+';
        break;
    case enOperatorType::Sub:
        return '-';
        break;
    case enOperatorType::Mul:
        return '*';
        break;
    case enOperatorType::Div:
        return '/';
        break;
    default:
        return '+';
        break;
        // enOperatorType::Mix random char + - * /
    }
}

stQuestion CreateQuestion(stMathGameInfo MathGameInfo, stQuestion &Question)
{
    Question.firstNumber = CreatRandNumber(Level(MathGameInfo.QuestionsLevel));
    Question.SecondNumber = CreatRandNumber(Level(MathGameInfo.QuestionsLevel));
    Question.OP = CreateOP(MathGameInfo.Operator);
    return Question;
}

void PrintQuestion(stQuestion Question)
{
    cout << Question.firstNumber << endl;
    cout << Question.SecondNumber
         << " " << PrintOP(Question.OP) << endl;
    cout << "--------------" << endl;
}

int ReadUserAnswer()
{
    int UserAnswer;
    cin >> UserAnswer;
    return UserAnswer;
}

void SetUserAnswer(stQuestion &Question, int UserAnswer)
{
    Question.userAnswer = UserAnswer;
}

void SetRigthAnswer(stQuestion &Question)
{
    switch (Question.OP)
    {
    case enOperatorType::Add:
        Question.RightAnswer = Question.firstNumber + Question.SecondNumber;
        break;
    case enOperatorType::Sub:
        Question.RightAnswer = Question.firstNumber - Question.SecondNumber;
        break;
    case enOperatorType::Mul:
        Question.RightAnswer = Question.firstNumber * Question.SecondNumber;
        break;
    case enOperatorType::Div:
        Question.RightAnswer = Question.firstNumber / Question.SecondNumber;
        break;
    }
}

bool IsRigthAnswer(int userAnswer, int RightAnswer)
{
    return userAnswer == RightAnswer;
}

void CheckAnswer(stMathGameInfo &MathGameInfo, stQuestion Question)
{
    if (IsRigthAnswer(Question.userAnswer, Question.RightAnswer))
    {
        MathGameInfo.RigthQuestions++;
    }
    else
    {
        MathGameInfo.WrongQuestions++;
    }
}

void QuestionColorStat(stQuestion Question)
{
    if (IsRigthAnswer(Question.userAnswer, Question.RightAnswer))
    {
        system("color 2F");
    }
    else
    {
        system("color 4F");
    }
}

void PrintAnswerResult(stQuestion &Question)
{
    if (IsRigthAnswer(Question.userAnswer, Question.RightAnswer))
    {
        cout << "Right Answer :-) \n";
    }
    else
    {
        cout << "Wrong Answer :-( \n";
        cout << "The Rigth Answer is " << Question.RightAnswer << "\n\n\n";
    }
}

void setGameResult(stMathGameInfo &MathGameInfo)
{
    if (MathGameInfo.RigthQuestions > MathGameInfo.WrongQuestions)
        MathGameInfo.GameResult = enGameResult::PASS;
    else
        MathGameInfo.GameResult = enGameResult::FAIL;
}

string FaceResult(enGameResult GameResult)
{
    switch (GameResult)
    {
    case enGameResult::PASS:
        return ":-)";
        break;
    case enGameResult::FAIL:
        return ":-(";
        break;
    default:
        return ":-| Error!";
        break;
    }
}

string GameResult(enGameResult GameResult)
{
    if (GameResult == enGameResult::PASS)
        return "PASS";
    else
        return "FAIL";
}

string GameOperatorType(enOperatorType OperatorType)
{
    switch (OperatorType)
    {
    case enOperatorType::Add:
        return "+";
        break;
    case enOperatorType::Sub:
        return "-";
        break;
    case enOperatorType::Mul:
        return "*";
        break;
    case enOperatorType::Div:
        return "/";
        break;
    default:
        return "Mix";
        break;
    }
}

string GameLevel(enLevel Level)
{
    switch (Level)
    {
    case enLevel::Easy:
        return "Easy";
        break;
    case enLevel::Mid:
        return "Mid";
        break;
    case enLevel::Hard:
        return "Hard";
        break;
    case enLevel::MixL:
        return "Mix";
        break;
    default:
        return "Easy";
        break;
    }
}

void PrintGameResult(stMathGameInfo MathGameInfo)
{
    cout << "\n----------------------------------\n";
    cout << " Final Result is " << GameResult(MathGameInfo.GameResult) << " " << FaceResult(MathGameInfo.GameResult) << endl;
    cout << "----------------------------------\n";
    cout << " Number of Questions     : " << MathGameInfo.NumberOfQuestions << endl;
    cout << " Questions Level         : " << GameLevel(MathGameInfo.QuestionsLevel) << endl;
    cout << " Operator Type           : " << GameOperatorType(MathGameInfo.Operator) << endl;
    cout << " Number of Right Answers : " << MathGameInfo.RigthQuestions << endl;
    cout << " Number of Wrong Answers : " << MathGameInfo.WrongQuestions << endl;
    cout << "----------------------------------\n";
}

void GameColorStat(stMathGameInfo MathGameInfo)
{
    switch (MathGameInfo.GameResult)
    {
    case enGameResult::PASS:
        system("color 2F");
        break;
    case enGameResult::FAIL:
        system("color 4F");
        break;
    }
}

void ReadPlayAgainAnswer(char &PlayAgainAnswer)
{
    PlayAgainAnswer = ReadInputChar("Do you want to play again? Y/N? ");
}

void SoundOfRoundLose()
{
    cout << "\a";
}

void RestMathGame(stMathGameInfo &MathGameInfo)
{
    MathGameInfo.RigthQuestions = 0;
    MathGameInfo.WrongQuestions = 0;
    system("color f0");
    system("cls");
}

void StartGame()
{

    stMathGameInfo MathGameInfo;
    stQuestion Question;
    char PlayAgainAnswer;

    do
    {
        SetMathGameInfo(MathGameInfo);

        for (int i = 1; i <= MathGameInfo.NumberOfQuestions; i++)
        {

            cout << "\nQuestion [" << i << "/" << MathGameInfo.NumberOfQuestions << "]\n\n";
            PrintQuestion(CreateQuestion(MathGameInfo, Question));
            SetUserAnswer(Question, ReadUserAnswer());
            SetRigthAnswer(Question);
            CheckAnswer(MathGameInfo, Question);
            QuestionColorStat(Question);
            PrintAnswerResult(Question);
        }
        setGameResult(MathGameInfo);
        PrintGameResult(MathGameInfo);
        GameColorStat(MathGameInfo);
        RestMathGame(MathGameInfo);
        ReadPlayAgainAnswer(PlayAgainAnswer);
    } while (PlayAgainAnswer == 'Y' || PlayAgainAnswer == 'y');
}

int main()
{
    srand((unsigned)time(NULL));
    /////////////////////////////
    //
    StartGame();
    //
    return 0;
}