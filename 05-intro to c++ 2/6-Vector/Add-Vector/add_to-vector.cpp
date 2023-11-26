#include <iostream>
#include <vector>
using namespace std;

void ReadNumbers(vector<int> &vNumbers)
{
    string addNewItem = "Y";
    do
    {
        cout << "Do you want to add New Item Y/N? : ";
        cin >> addNewItem; // Y
        if (addNewItem == "Y" || addNewItem == "y")
        {
            int NewItem;
            cout << "What is the Number you want to add ? : ";
            cin >> NewItem;
            vNumbers.push_back(NewItem);
        }
        else
            break;

    } while (addNewItem == "Y" || addNewItem == "y");
}

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
    vector<int> vNumbers = {1, 2, 3, 4, 5, 6};

    for (int &Number : vNumbers)
    {
        cout << Number << " ";
    }
    cout << endl;

    ///////////////////////
    vector<int> vNums;
    vNums.push_back(10);
    vNums.push_back(20);
    vNums.push_back(30);
    for (int &Num : vNums)
    {
        cout << Num << " ";
    }
    cout << endl; // 10 20 30

    /////////////////////////
    //       HomeWork      //
    /////////////////////////

    vector<int> vMyEnteredNumbers;
    ReadNumbers(vMyEnteredNumbers);
    PrintVectorNumbers(vMyEnteredNumbers);
    return 0;
}