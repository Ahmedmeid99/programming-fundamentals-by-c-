#include <iostream>
using namespace std;

int main()
{
    int grade = 51;
    string IsPass = (grade >= 50) ? "PASS" : "FAIL";
    printf("the grade is %d ", grade, IsPass);
    cout << " the result is " << IsPass << endl;
    // printf(" the result is : %s \n", IsPass);

    ///////////////////////////////////////
    int A = 1, B = 12, C = 3;
    int TheGigest = ((A > B)   ? (C > A) ? C : A
                     : (C > B) ? C
                               : B);
    printf("the gigest number is : %d", TheGigest);
    return 0;
}