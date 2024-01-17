#include <iostream>
#include "clsStackArr.cpp"
using namespace std;

int main()
{
    clsStackArr<int> Stack_1;
    Stack_1.Push(1);
    Stack_1.Push(2);
    Stack_1.Push(3);
    Stack_1.Push(4);
    Stack_1.Print();

    Stack_1.Pop();
    Stack_1.Print();

    cout << "Top : " << Stack_1.Top() << endl;
    cout << "Bottom : " << Stack_1.Bottom() << endl;
    cout << "Size : " << Stack_1.Size() << endl;
    cout << "first : " << Stack_1.GetItem(0) << endl;

    Stack_1.UpdateItem(1, 33); // 2 33 4
    Stack_1.Print();

    Stack_1.Reverse();

    Stack_1.InsertAfter(2, 22); // 2 33 4 22
    Stack_1.Print();

    Stack_1.InsertBottom(5); // 2 33 4 22 5
    Stack_1.Print();

    Stack_1.InsertTop(1); // 1 2 33 4 22 5
    Stack_1.Print();

    Stack_1.Clear();
    Stack_1.Print();
    return 0;
}