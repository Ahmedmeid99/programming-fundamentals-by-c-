#include <iostream>

using namespace std;

// Create Linked list
class Node
{
public:
    int value;  // Data
    Node *Next; // Next Node Location
};

void PrintLinkedListItems(Node *head)
{
    while (head != NULL)
    {

        // print its value
        cout << head->value << endl;

        // transate to Next Node
        head = head->Next;
    }
}

void InsertAtBeninning(Node *&head, int value)
{
    Node *New_Node = new Node();

    New_Node->value;
    New_Node->Next = head;

    head = New_Node;
}
int main()
{
    // alocate 3 node the heap
    Node *Node1 = new Node();
    Node *Node2 = new Node();
    Node *Node3 = new Node();

    // Assign value values
    Node1->value = 1;
    Node2->value = 2;
    Node3->value = 3;

    // Connect Nodes
    Node1->Next = Node2;
    Node2->Next = Node3;
    Node3->Next = NULL;

    // set head of linked list
    Node *head;
    head = Node1;

    InsertAtBeninning(head, 0);

    PrintLinkedListItems(head);
    return 0;
}