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

void InsertAtEnd(Node *&head, int value)
{
    // creat New_Node
    Node *New_Node = new Node();
    New_Node->value = value;
    New_Node->next = NULL;

    // insert first node in linked list
    if (head == NULL)
    {
        head = New_Node;
        return; // break
    }

    // loop on list to find (move on to) last node
    Node *Last_Node = head;
    while (Last_Node->next != NULL)
    {
        Last_Node = Last_Node->next;
    }

    Last_Node->next = New_Node;
    return;
}

void DeleteNode(Node *&head, int value)
{
    // empty list ( head == NULL )
    if (head == NULL)
    {
        return;
    }

    Node *Current_Node = head, *Prev_Node = head;

    // one Node in List and it is the node you want to delete
    // or first Node in List
    if (Current_Node->value == value)
    {
        head = Current_Node->next; // NULL or Second Node
        delete Current_Node;
        return;
    }

    // loop on list to set Prev_Node and Current_Node
    while (Current_Node != NULL && Current_Node->value != value)
    {
        Prev_Node = Current_Node;
        Current_Node = Current_Node->next;
    }
    if (Current_Node == NULL)
        return;

    Prev_Node->next = Current_Node->next;
    delete Current_Node;
}

void DeleteFirstNode(Node *&head)
{
    Node *Current_Node = head;
    if (head == NULL)
        return; // break

    head = Current_Node->next;
    delete Current_Node;
    return; // break
}
void DeleteLastNode(Node *&head)
{
    Node *Current_Node = head, *Prev_Node = head;
    if (head == NULL)
        return; // break

    if (Current_Node->value == NULL)
    {
        head = NULL;
        delete Current_Node;
        return;
    }
    while (Current_Node->next != NULL)
    {
        Prev_Node = Current_Node;
        Current_Node = Current_Node->next;
    }
    Prev_Node->next = NULL;
    delete Current_Node;
}
int main()
{

    // set head of linked list
    Node *head = NULL;
    InsertAtEnd(head, 1);
    InsertAtEnd(head, 2);
    InsertAtEnd(head, 3);
    InsertAtEnd(head, 4);
    InsertAtEnd(head, 5);

    PrintLinkedListItems(head);

    DeleteLastNode(head);

    PrintLinkedListItems(head);
    return 0;
}