#include <iostream>
#include <map>

using namespace std;
void PrintList(map<string, int> StudentGrads)
{
    for (const auto &Pair : StudentGrads)
    {
        cout << Pair.first << " : " << Pair.second << endl;
    }
}
int main()
{
    // Search ,Find ,Delete ,Insert => O(1)
    map<string, int> StudentGrads;
    StudentGrads["ali"] = 75;
    StudentGrads["ahmed"] = 85;
    StudentGrads["eid"] = 70;

    PrintList(StudentGrads);

    return 0;
}