#include <iostream>
using namespace std;

void search_in_array(int arr[100],int length, int num)
{
    for(int i=0; i <=length-1;i++)
    {
        if (arr[i] == 20)
        {
            cout << "20 found in position :" << i << endl;
            break;
        };
        cout << arr[i] <<" index= " << i << endl;
    }
}
void print_array_not_20(int arr[100], int length, int num)
{
    for (int i = 0; i <= length-1; i++)
    {
        if (arr[i] == 20)
        {
            cout << "20 found in position :" << i << endl;
            continue;
        };
        cout << arr[i] << " index= " << i << endl;
    }
}

int main()
{
    int arr[8] = { 10,120,20,23,43,34,52,98 };
    search_in_array(arr,8,20);
    print_array_not_20(arr,8,20);
    cout << "Hello World!\n";
}
