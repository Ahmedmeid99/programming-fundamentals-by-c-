#include <iostream>
using namespace std;

/*
create a program can get number from user and change cmd color
depend on the color number
*/

enum enColor { Red = 1, Green = 2, Blue = 3, Yellow = 4 };

void displaymessage()
{
    cout << "enter number to change cmd color\n";
    cout << "******************************\n";
    cout << "1 => Red\n";
    cout << "2 => Green\n";
    cout << "3 => Blue\n";
    cout << "4 => Yello\n";
    cout << "******************************\n";

};
void get_color_number(int& c)
{
    cout << "enter number of color : ";
    cin >> c;
}
void change_cmd_color(int c) // 3 type num
{
    // int => enum
    enColor color;
    color = enColor(c);

    switch (color) {
    case enColor::Red:
        system("color 4f");
        break;

    case enColor::Green:
        system("color 2f");
        break;

    case enColor::Blue:
        system("color 3f");
        break;

    case enColor::Yellow:
        system("color 6f");
        break;

    default:
        cout << "not valid";
    }

}
int main() {
    int c;
    displaymessage();
    get_color_number(c);
    change_cmd_color(c);

    return 0;
}