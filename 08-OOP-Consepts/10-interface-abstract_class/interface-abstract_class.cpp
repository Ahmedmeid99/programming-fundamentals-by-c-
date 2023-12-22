#include <iostream>
using namespace std;

// InterFace / Abstract Class / Contract
class clsMobile
{
    virtual void Dial(string PhonrNumber) = 0;
    virtual void SendMessage(string PhonrNumber, string Text) = 0;
    virtual void TakePicture() = 0;
};

class clsIPhone : public clsMobile
{
public:
    // Constractor
    clsIPhone()
    {
    }

    void Dial(string PhonrNumber)
    {
        // block of cobe
    }

    void SendMessage(string PhonrNumber, string Text)
    {
        // block of cobe
    }

    void TakePicture()
    {
        // block of cobe
    }
};

class clsHuawel : public clsMobile
{
public:
    // Constractor
    clsHuawel()
    {
    }

    void Dial(string PhonrNumber)
    {
        // block of cobe
    }

    void SendMessage(string PhonrNumber, string Text)
    {
        // block of cobe
    }

    void TakePicture()
    {
        // block of cobe
    }
};

int main()
{
    clsIPhone IPhone_1;

    IPhone_1.Dial("01095814411");
    IPhone_1.SendMessage("01095814411", "How are you?");
    IPhone_1.TakePicture();

    clsHuawel Huawel_1;

    Huawel_1.Dial("01095814411");
    Huawel_1.SendMessage("01095814411", "How are you?");
    Huawel_1.TakePicture();

    return 0;
}