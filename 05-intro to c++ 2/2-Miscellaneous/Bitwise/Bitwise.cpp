#include <iostream>
using namespace std;
void printIncressNumber()
{
    static int Number = 1;
    cout << Number << endl;
    Number++;
}
int main()
{
    printf("and Bitwise %d \n", 12 & 25); // 00001000 =>8
    printf("or Bitwise %d \n", 12 | 25);  // 00011101 =>29

    /////////////////////////
    // static variables
    printIncressNumber(); // 1
    printIncressNumber(); // 2
    printIncressNumber(); // 3
    return 0;
}