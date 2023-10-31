#include <iostream>
using namespace std;

int main() {
	// increment & decrement
	int A = 10;   
	int B = A++;  //   10  A=11
	int C = ++A ; //   12  A=12
	cout << "A = " << A << ",B = " << B << ",C = " << C <<	endl;
	//                12              10              12

	// Assignment operators
	int a = 5;
	a += 1; // 6
	cout << "a = " << a << endl;
	a -= 2; // 4
	cout << "a = " << a << endl;
	a *= 2;// 8
	cout << "a = " << a << endl;

	// Relational operators
	cout << (5 == 6 )<< (5 != 6) << (5>6) << (5<6) << (5<=6) << endl;
	//         0            1          0       1         1 

	//logical operators
	cout << (true && true);     // true   1
	cout << (true && false);    // false  0
	cout << (true || true);     // true   1
	cout << (true || false);    // true   1
	cout << !(true == false);   // true   1
	return 0;
}