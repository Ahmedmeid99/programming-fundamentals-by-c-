#include <iostream>
using namespace std;

int main()
{
    void *p;

    int a = 9;
    float c = 4.5;

    p = &a;
    cout << p << endl;                        // 0x6c547ffc84
    cout << *(static_cast<int *>(p)) << endl; // 9

    p = &c;
    cout << p << endl; // 0x6c547ffc80 (int take 4 bit)

    cout << *(static_cast<float *>(p)) << endl; // 4.5
    return 0;
}