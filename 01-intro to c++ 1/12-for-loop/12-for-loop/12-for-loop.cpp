#include <iostream>
using namespace std;

void print_1_to_5() {
    for (int i = 1; i <= 5; i++) {
        cout << i << endl;
    }
}
void print_5_to_1() {
    for (int i = 5; i >= 1; i--) {
        cout << i << endl;
    }
}
// program level 1
void print_items_of_array(string names[4], int length) {
    for (int i = 0; i <= length-1; i++) {
        cout << names[i] << endl;
    };
}

//// program level 2
void get_length(int &length) {
    cout << "please enter the length of array\n";
    cin >> length;
}
void create_array_of_nums(int nums[100], int length) {
    for (int i = 0; i <= length - 1; i++) {
        cin >> nums[i];
    }
}

void printarray(int nums[100],int length) {
    cout << "the array will be \n ";
    cout << "[ ";
    for (int i = 0; i <= length - 1; i++) {
        
        cout << nums[i] << ", " ;
    }
    cout << "]\n ";
    
}
void print_sum_of_arry_items(int nums[100], int length) {
    int sum = 0;
    for (int i = 0; i <= length-1; i++) {
        sum += nums[i];
    }
    cout << sum << endl;
}


int main() {
    print_1_to_5();
    print_5_to_1();

    string names[4] = { "ahmed","mohamed","eid","ali" };
    print_items_of_array(names, 4);

    // dynamic program create array and print sum of its numbers
    /*int length;
    int nums[100];*/
    /*get_length(length);
    create_array_of_nums(nums, length);
    printarray(nums, length);
    print_sum_of_arry_items(nums, length);*/


    return 0;
}
