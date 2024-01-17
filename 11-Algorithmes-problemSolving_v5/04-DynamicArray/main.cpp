#include <iostream>
#include "clsDynamicArray.cpp"

using namespace std;

int main()
{
    clsDynamicArray<int> DynamicArray(5);
    DynamicArray.setItem(0, 1);
    DynamicArray.setItem(1, 2);
    DynamicArray.setItem(2, 3);
    DynamicArray.setItem(3, 4);
    DynamicArray.setItem(4, 5);

    DynamicArray.PrintList(); // 1 2 3 4 5

    // DynamicArray.DeleteFirstItem();
    // DynamicArray.DeleteLastItem();

    int ItemIndex = DynamicArray.Find(4);
    int Item = DynamicArray.GetItem(ItemIndex);
    cout << ItemIndex << endl; // in index 3
    cout << Item << endl;      // 4

    DynamicArray.DeleteItem(4);

    DynamicArray.DeleteItemAt(1); // 1 3 5
    DynamicArray.PrintList();

    cout << DynamicArray.InsertAt(1, 2) << endl; // 1 true
    cout << DynamicArray.InsertAt(3, 4) << endl; // 1 true

    DynamicArray.Reverse();
    DynamicArray.InsertAtBegining(6);
    DynamicArray.InsertAfter(5, 0);
    DynamicArray.InsertAtEnd(99);

    DynamicArray.PrintList(); // 6 5 4 3 2 1 0 99

    DynamicArray.Resize(2);
    DynamicArray.PrintList(); // 5 3

    DynamicArray.Resize(4);
    DynamicArray.PrintList(); // 5 3 0 0

    cout << DynamicArray.IsEmpty() << endl; // 0
    cout << DynamicArray.Size() << endl;    // 4

    DynamicArray.Clear();
    cout << DynamicArray.IsEmpty() << endl; // 1

    DynamicArray.PrintList();
    return 0;
}