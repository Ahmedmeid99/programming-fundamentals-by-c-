#include <iostream>
using namespace std;

// program 1
void read_entered_number(int &num)
{
	cout << "whit is your entered Number? ";
	cin >> num;

};
string check_entered_number(int num)
{

	if (num > 5)
	{
		return "this number is  bigger than 5 \n";
	}
	else if (num == 5)
	{
		return "this number is equal to 5 \n";;
	}
	else
	{
		return "this number is  smaller than 5 \n";
	}

};
void print_result_message(int num)
{
	string result = check_entered_number(num);
	cout << result << endl;
};

// program 2
int main() {
	// program 1
	int num1;
	read_entered_number(num1);
	print_result_message(num1);

	// program 2


	return 0;
}