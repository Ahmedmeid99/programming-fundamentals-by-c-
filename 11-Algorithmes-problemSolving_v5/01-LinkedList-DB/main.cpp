#include <iostream>
#include "clsDbLinkedList.cpp"
using namespace std;

int main()
{
    clsDbLinkedList<int> DbLinkedList;

    cout << DbLinkedList.IsEmpty() << endl; // true 1

    DbLinkedList.InsertAtEnd(1);
    DbLinkedList.InsertAtEnd(2);
    DbLinkedList.InsertAtEnd(3);
    DbLinkedList.InsertAtEnd(4);
    DbLinkedList.InsertAtEnd(5);
    DbLinkedList.PrintLinkedListItems(); // 1 2 3 4 5

    DbLinkedList.InsertAtBigining(33);
    DbLinkedList.PrintLinkedListItems(); // 33 1 2 3 4 5

    DbLinkedList.DeleteFirstNode();
    DbLinkedList.PrintLinkedListItems(); // 1 2 3 4 5

    DbLinkedList.DeleteLastNode();
    DbLinkedList.PrintLinkedListItems(); // 1 2 3 4

    clsDbLinkedList<int>::Node *N3 = DbLinkedList.FindNode(3);
    clsDbLinkedList<int>::PrintNode(N3); // <== 3 ==>

    clsDbLinkedList<int>::Node *N2 = DbLinkedList.GetNode(1); // index 1
    clsDbLinkedList<int>::PrintNode(N2);                      // <== 2 ==>

    cout << DbLinkedList.GetNodeIndex(N3) << endl; // 2
    cout << DbLinkedList.GetItem(1) << endl;       // 2
    DbLinkedList.UpdateItem(1, 500);
    DbLinkedList.Reverse();
    DbLinkedList.PrintLinkedListItems(); // 4 3 2 1

    clsDbLinkedList<int>::Node *N1 = DbLinkedList.FindNode(1);
    clsDbLinkedList<int>::Node *N4 = DbLinkedList.FindNode(4);

    DbLinkedList.Swap(N1, N4);
    DbLinkedList.PrintLinkedListItems(); // 1 3 2 4

    DbLinkedList.InsertAfter(N3, 44);
    DbLinkedList.InsertAfter(3, 100);

    DbLinkedList.PrintLinkedListItems(); // 1 2 3 44 4

    DbLinkedList.DeleteNode(N3);
    DbLinkedList.PrintLinkedListItems(); // 1 2 44 5

    cout << DbLinkedList.Size() << endl;    // 4
    cout << DbLinkedList.IsEmpty() << endl; // false 0

    DbLinkedList.Clear();
    cout << DbLinkedList.Size() << endl; // 0
    return 0;
}