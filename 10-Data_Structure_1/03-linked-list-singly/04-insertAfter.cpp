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
        cout << head->value << " ";

        // transate to next Node
        head = head->next;
    }
    cout << endl;
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

void InsertNodeAfter(Node *&Prev_Node, int value)
{
    // create new_Node
    // Insert New_Node after Prev_Node
    if (Prev_Node == NULL)
    {
        cout << "the given prev node can not be NULL \n";
        return;
    }
    Node *New_Node = new Node();
    New_Node->value = value;
    New_Node->next = Prev_Node->next;

    Prev_Node->next = New_Node;
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

    InsertNodeAfter(Node2, 2); // 1223

    PrintLinkedListItems(head);
    return 0;
}