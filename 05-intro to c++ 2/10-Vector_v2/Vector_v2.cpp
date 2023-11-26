#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> vNums = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    cout << "access using .at() \n";
    cout << "vNums.at(0) index 0 : " << vNums.at(0) << endl;
    cout << "vNums.at(9) index 9 : " << vNums.at(9) << endl;

    cout << "access using [] \n";
    cout << "vNums[0] index 0 : " << vNums[0] << endl;
    cout << "vNums[9] index 9 : " << vNums[9] << endl;

    /*Update vector items*/
    vNums[0] = 0;
    cout << "vNums[0] from 1 to 0 : " << vNums[0] << endl;

    vNums[3] = 44;
    cout << "vNums[3] from 4 to 44 : " << vNums[3] << endl;

    /*Iterator in Vector*/
    vector<int>::iterator iter;
    for (iter = vNums.begin(); iter != vNums.end(); iter++)
    {
        cout << *iter << " ";
    }
    return 0;
}