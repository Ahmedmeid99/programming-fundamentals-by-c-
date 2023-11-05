#include <iostream>
using namespace std;
// while loop
void print_1_5() {
    int num = 1;
    while (num <= 5) {
        cout << num << endl;
        num++;
    }
}

void print_positive_number() {
    cout << "please enter number > 0 \n";
    int number;
    cin >> number;
    while (number <= 0) {
        cout << "please enter number > 0 \n";
        cin >> number;
    }
    cout << "the  number you entered is " << number << endl;

}

void print_num_5_to_50(int &enterednumber)
{
    cout << "please enter number betwen 5 and 500\n";
    cin >> enterednumber;

    while (enterednumber < 5 || enterednumber >500) {
        cout << "not vaild number \n";
        cout << "please enter number betwen 5 and 500\n";
        cin >> enterednumber;
    }

    cout << "good jop you entered : " << enterednumber << endl;
}

// Do while loop
void print2_num_5_to_50(int& enterednumber)
{

    do{
        cout << "not vaild number \n";
        cout << "please enter number betwen 5 and 500\n";
        cin >> enterednumber;
    } while (enterednumber < 5 || enterednumber >500);

    cout << "good jop you entered : " << enterednumber << endl;
}
void print_num_inrange(int &from, int &to) {
    cout << "enter number between range of numbers\n";
    cout << "from \n";  cin >> from;
    cout << "to \n";    cin >> to;
    int num;
    do 
    {
        cout << "enter a number in range \n";
        cin >> num;

    } while (num <from || num >to);
    cout << "good jop the number you entered is : " << num << endl;
}
int main()
{
    print_1_5();
    print_positive_number();
    int num;
    // print_num_5_to_50(num);

    // do while
    int num2;
    print_num_5_to_50(num2);

    int from, to;
    print_num_inrange(from, to);

    cout << "Hello World!\n";
    return 0;
}
