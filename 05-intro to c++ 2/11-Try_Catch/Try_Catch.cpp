#include <iostream>
#include <vector>
using namespace std;

int main()
{
    vector<int> vNums = {1, 2, 3, 4};

    // for handling expected errors
    // to handle expected program crach
    try
    {

        cout << vNums.at(5);
    }
    catch (...)
    {

        cout << "Not Found";
    }

    // Not Found
    return 0;
}