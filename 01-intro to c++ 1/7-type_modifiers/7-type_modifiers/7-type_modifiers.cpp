
#include <iostream>
#include <string>
using namespace std;


int main()
{
    int number1 = 12;
    unsigned int number1_p = 12; //ثابت size ويضل range حزف الارقام السالبه و استبدالها بارقام موجبه لذلك يذيد ال 

    short int number2 = 12;
    long int number3 = 12;
    long long number4 = 12;

    cout << sizeof(number1) << endl;     // size is 4 byte
    cout << sizeof(number1_p) << endl;   // size is 4 byte but the range will be the double
    cout << sizeof(number2) << endl;     // size is 2 byte
    cout << sizeof(number3) << endl;     // size is 4 byte but the range will be the double
    cout << sizeof(number4) << endl;     // size is 8 byte but the range will be the double

    // range functions
    cout << INT_MIN << INT_MAX << endl;
    cout << INT_MIN << INT_MAX << endl;


    // data type converversion
    string str1 = "123";
    string str2 = "321";

    int num1, num2;
    num1 = stoi(str1); // 123
    num2  = stoi(str2); // 321

    cout << "123 + 321 = " << num1 + num2 << endl; // 444

    // String 

    string my_name = "Ahmed mohamed eid";
    int name_length = my_name.length(); // 17
    char dad_first_char = my_name[6];  // m
    string my_full_name = my_name + " ali";

    cout << my_name << " length is " << name_length << endl;
    cout << "my_full_name " << my_full_name << endl;
    cout << "dad_first_char " << dad_first_char << endl;
    return 0;

}
