#include <iostream>

using namespace std;

// Linked list (singly)
// -----------------------------------------------------
// |value,next| -> |value,next| -> |value,next| -> NULL
// -----------------------------------------------------

// Create Linked list
class Node
{
public:
    int value;  // Data
    Node *Next; // Next Node Location
};

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

    // print Linked list items
    Node *head;

    head = Node1;

    while (head != NULL)
    {

        // print its value
        cout << head->value << endl;

        // transate to Next Node
        head = head->Next;
    }

    return 0;
}