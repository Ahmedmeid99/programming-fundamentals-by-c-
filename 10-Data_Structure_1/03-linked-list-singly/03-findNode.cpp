#include <iostream>

using namespace std;

// Create Linked list
class Node
{
public:
    int value;  // Data
    Node *next; // next Node Location
};

void PrintLinkedListItems(Node *head)
{
    while (head != NULL)
    {

        // print its value
        cout << head->value << endl;

        // transate to next Node
        head = head->next;
    }
}

Node *FindNode(Node *head, int value)
{
    // loop on list if node->value == value return node
    while (head != NULL)
    {
        if (head->value == value)
        {
            return head;
        }
        head = head->next;
    }
    return NULL; // if Is Not found or Node is empty
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
    Node1->next = Node2;
    Node2->next = Node3;
    Node3->next = NULL;

    // set head of linked list
    Node *head;
    head = Node1;

    PrintLinkedListItems(head);

    Node *Node_2 = FindNode(head, 2);
    cout << Node_2->value << endl;
    return 0;
}