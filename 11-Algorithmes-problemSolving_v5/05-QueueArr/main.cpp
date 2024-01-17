#include <iostream>
#include "clsQueueArr.cpp"
using namespace std;

int main()
{
    clsQueueArr<int> Queue_1;
    Queue_1.Push(1);
    Queue_1.Push(2);
    Queue_1.Push(3);
    Queue_1.Push(4);
    Queue_1.Print();

    Queue_1.Pop();
    Queue_1.Print();

    cout << "Front : " << Queue_1.Front() << endl;
    cout << "Back : " << Queue_1.Back() << endl;
    cout << "Size : " << Queue_1.Size() << endl;
    cout << "first : " << Queue_1.GetItem(0) << endl;

    Queue_1.UpdateItem(1, 33); // 2 33 4
    Queue_1.Print();

    Queue_1.Reverse();

    Queue_1.InsertAfter(2, 22); // 2 33 4 22
    Queue_1.Print();

    Queue_1.InsertBack(5); // 2 33 4 22 5
    Queue_1.Print();

    Queue_1.InsertFront(1); // 1 2 33 4 22 5
    Queue_1.Print();

    Queue_1.Clear();
    Queue_1.Print();
    return 0;
}