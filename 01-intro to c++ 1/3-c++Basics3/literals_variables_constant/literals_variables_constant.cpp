// literals and variables and constant
#include <iostream>;
using namespace std;

int main() {
	// Escape Seqences \n \' \" \t \a
	cout << "my name is : \"Ahmed\" and day is 28\\10\\2023\n";
	cout << "\a\n";
	cout << "ahmed\tmohamed\teid\n";
	cout << "hassan\tamal\tali\n";

	// variables and constant
	const string my_name = "Ahmed";
	int my_age = 24;
	float my_length = 1.70;
	double number_x = 7.87532;
	char my_char = 'A';
	bool learn_cpp = true;
	wchar_t arabic_char = 'ا';

	// print variabls value
	cout << "********************\n";
	cout << "name: " <<  my_name << "(" << my_char  << arabic_char << ")" << endl;
	cout << "age: " << my_age << endl;
	cout <<  "my_length: " << my_length << endl;
	cout << "learn c++: " << learn_cpp << endl;
	cout << "this is double number " << number_x << endl;
	cout << "********************\n";

	// update my_age value
	my_age = 25;
	cout << "my age become " << my_age << endl;

	// input 
	int age;
	string name;

	int num1;
	int num2;
	cout << "enter your name? ";
	cin >> name;
	cout << "enter your age? ";
	cin >> age;
	cout << "********************\n";
	cout << "name: " << name << endl;
	cout << "age: " << age << endl;
	cout << "********************\n";

	cout << "enter 2 numbers ?\n ";
	cout << "number_1 is ";
	cin >> num1;
	cout << "number_2 is ";
	cin >> num2;
	cout <<"the result is " << num1 << "+" << num2 << " = " << num1 + num2 << endl;

	// Arithmetic operators
	cout << 1 + 4 << 10 - 5 << 2.5*2 << 10 / 2 << 10 % 2;// 55550

	return 0;
}
