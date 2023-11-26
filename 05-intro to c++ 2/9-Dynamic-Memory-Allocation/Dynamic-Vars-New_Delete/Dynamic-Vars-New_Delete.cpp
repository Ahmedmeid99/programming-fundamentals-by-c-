#include <iostream>
using namespace std;

int main()
{
    int *ptrX;
    float *ptrY;

    ptrX = new int;
    ptrY = new float;

    *ptrX = 20;
    *ptrY = 2.5;

    cout << "ptrX : " << *ptrX << endl;
    cout << "ptrY : " << *ptrY << endl;

    delete ptrX;
    delete ptrY;

    return 0;
}