#include <iostream>
#include <vector>
using namespace std;

void PrintVectorNumbers(vector<int> &vNumbers)
{
    for (int &Number : vNumbers)
    {
        cout << Number << " ";
    }
    cout << endl;
}

int main()
{
    ///////////////////
    /*
    Vector use Stack structure
    so the new item added to end
    "Last added first Removed"
    */
    ///////////////////

    vector<int> vNums;
    vNums.push_back(10);
    vNums.push_back(20);
    vNums.push_back(30);

    cout << vNums.front() << endl;    // 10
    cout << vNums.back() << endl;     // 30
    cout << vNums.size() << endl;     // 3
    cout << vNums.capacity() << endl; // 4

    // vNums.clear();
    PrintVectorNumbers(vNums); // 10 20 30
    vNums.pop_back();
    PrintVectorNumbers(vNums); // 10 20
    vNums.pop_back();
    PrintVectorNumbers(vNums); // 10
    vNums.pop_back();
    PrintVectorNumbers(vNums); //

    // Handl Removing
    // [1]
    if (!vNums.empty()) // true false
        vNums.pop_back();

    // [2]
    if (vNums.size() > 0) // size = vector Length
        vNums.pop_back();
    return 0;
}