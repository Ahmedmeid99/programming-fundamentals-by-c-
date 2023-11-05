#include <iostream>
using namespace std;

// print this 

// AA to ZZ
void printAA_to_ZZ() {
    for (int i = 65; i < 91; i++)
    {
        for (int j = 65; j < 91; j++)
        {
            cout << static_cast<char>(i) << static_cast<char>(j) << endl;
        }
    }
}

/*
A
AB
ABC
ABCD
ABCDF
*/
void print_tringle_ofchars() {
    for (int i = 65; i <=70; i++)
    {
        for (int j = 65; j <= i; j++)
        {
            cout << static_cast<char>(j);
        }
        cout << "\n";

    }
}
/* [ 1 ]
**********
**********
**********
**********
**********
*/
void print_square_ofstars() {
    for (int i = 1; i <= 4; i++) {
        for (int j = 1; j <= 10; j++) {
            cout << "*";
        }
        cout << "\n";
    }
}

/* [ 2 ]
*
**
***
****
*****
******
*******
********
*********
**********
*/
void print_triangle_ofstars() {
    for (int i = 1; i <= 10; i++) {
        for (int j = 1; j <= i; j++) {
            cout << "*";
        }
        cout << "\n";
    }
}

/*
  1 2 3 4 5 6 7 8 9 10
  2 3 4 5 6 7 8 9 10
  3 4 5 6 7 8 9 10
  4 5 6 7 8 9 10
  5 6 7 8 9 10
  6 7 8 9 10
  7 8 9 10
  8 9 10
  9 10
  10
*/

void print_figure_5()
{
    for (int i = 10; i >=1 ; i--)
    {

    }
}
int main()
{
    print_tringle_ofchars();
    //printAA_to_ZZ();
    print_square_ofstars();
    print_triangle_ofstars();
    return 0;
}


